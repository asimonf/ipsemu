using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Drawing;

namespace Infinity_Project
{
    public class Bus
    {
        // Atributos

        private CentralProcesingUnit _cpu;
        private PictureProcesingUnit _ppu;
        private AudioProcessingUnit _apu;

        private byte[] _rom, _lowRam, _highRam, _expandedRam, _sRam, _hardwareRegs;

        private DMAChannel[] _dmaChannels;
        private DMAChannel currentDMAChannel = null;

        private byte[] _vram;
        private byte[] _cgram;

        private int _cgramUploadAddress;
        private int _incrementRate;
        private bool _nmiEnabled;
        private bool _register4210NotRead;
        private int _vramByteUploadAddress;
        private int _vramWordUploadAddress
        {
            get
            {
                return _vramByteUploadAddress >> 1;
            }
            set
            {
                _vramByteUploadAddress = value << 1;
            }
        }
        private bool _verticalLatchActivated;
        private bool _verticalLatchHighByte;
        private bool _horizontalLatchActivated;
        private bool _horizontalLatchHighByte;
        private int _verticalCounter;
        private bool _verticalCounterActivated;
        private int _horizontalCounter;
        private bool _horizontalCounterActivated;
        private bool _horizontalCounterUntriggered;
        private bool _verticalCounterUntriggered;
        private bool _incrementHighByte;
        private bool _enabled;
        private LWord _wramAddressAccess = new LWord();
        private Snes _snes;

        private int _scanLineNumber = 0;
        private int _cpuCyclesPerMasterCycles = 8;
        private int _cyclesToNextScanline = CyclesPerScanline;

        public bool Enabled
        {
            get
            {
                return this._enabled;
            }
            set
            {
                this._enabled = value;
            }
        }
        public byte[] VRam
        {
            get
            {
                return this._vram;
            }
        }
        public byte[] CGRam
        {
            get
            {
                return this._cgram;
            }
        }

        public const int CyclesPerScanline = 1324;
        public const int WRamRefreshDelay = 40;
        public const int CyclesPerDot = 4;
        public const int CyclesPerDotShift = CyclesPerDot >> 2;
        public const int ScanlinesPerFrame = 262;
        public const int NMIScanlineTrigger = 240; 

        public Bus(Snes s)
        {
            this._snes = s;

            this._cpu = new CentralProcesingUnit(this);
            this._apu = new AudioProcessingUnit(this);
            this._ppu = new PictureProcesingUnit(this);

            //s.Paint += new System.Windows.Forms.PaintEventHandler(s_Paint);
            //Events.Tick += new TickEventHandler(Events_Tick);

            //dev.PresentationParameters.DeviceWindow.Paint += new System.Windows.Forms.PaintEventHandler(DeviceWindow_Paint);

            _vram = new byte[0x10000];
            _cgram = new byte[0x200];
            _rom = new byte[0x400000];
            _lowRam = new byte[0x2000];
            _highRam = new byte[0x8000];
            _expandedRam = new byte[0x18000];
            _sRam = new byte[0x40000];
            _hardwareRegs = new byte[0x2000];

            _dmaChannels = new DMAChannel[8];

            for (int i = 0; i < 8; i++)
            {
                _dmaChannels[i] = new DMAChannel(this);
            }
        }

        Font f = new Font("arial", 12, FontStyle.Regular, GraphicsUnit.Pixel);

        Rectangle StretchRect = new Rectangle(0, 0, 512, 448);

        public unsafe void Render()
        {
            //HighResolutionTimer.Instance.Set();

            if (this.Enabled)
            {
                //this._ppu.LockFrameBuffer();
                fixed (int* ptr = this._snes.backBuffer.Data)
                {
                    this._ppu.frameBufferPtr = ptr;
                    this.Run();
                }
                //this._ppu.UnlockFrameBuffer();
            }

            //Graphics g = e.Graphics;
            //g.DrawImage(this._snes.frameBuffer, 0, 0);
            //g.DrawString(HighResolutionTimer.Instance.FramesPerSecond.ToString(), f, Brushes.Red, 10, 10);
        }

        public void TriggerNMI()
        {
            if (_nmiEnabled)
            {
                this._cpu.NMIPending = true;
            }
        }
        public void TriggerIRQ()
        {
            this._cpu.IRQPending = true;
        }
        private void _untriggerIRQ()
        {
            this._cpu.IRQPending = false;
        }
        public void TriggerRES()
        {
            this.Reset();
        }

        public void StartDMATransfer(DMAChannel c)
        {
            this.currentDMAChannel = c;
            c.StartTransfer();
        }
        public void StopDMATransfer()
        {
            this.currentDMAChannel = null;
        }

        public void LoadRom(string romFile)
        {
            bool HasHeader = true;

            byte[] Buff = null;
            Buff = File.ReadAllBytes(romFile);

            this._rom.Initialize();

            if (HasHeader)
            {
                for (int i = 0x200; i < Buff.Length; i++)
                {
                    this._rom[i - 0x200] = Buff[i];
                }
            }
            else
            {
                for (int i = 0x00; i < Buff.Length; i++)
                {
                    this._rom[i] = Buff[i];
                }
            }
        }

        public byte ReadByte(uint Addr)
        {
            uint bank = (Addr >> 16) & 0x7F;
            uint effectiveAddr = Addr & 0xFFFF;

            if (bank < 0x40)
                if (effectiveAddr < 0x2000)
                    return _lowRam[effectiveAddr];
                else if (effectiveAddr < 0x6000)
                    return ReadByteRegister(effectiveAddr);
                else if (effectiveAddr < 0x8000)
                    return 0;
                else
                    return _rom[Addr - (0x8000 * (bank + 1))];
            else if (bank < 0x60)
                if (effectiveAddr < 0x8000)
                    return 0;
                else
                    return _rom[Addr - (0x8000 * (bank + 1))];
            else if (bank < 0x70)
                return 0;
            else if (bank < 0x78)
                if (effectiveAddr < 0x8000)
                {
                    bank -= 0x70;
                    return _sRam[Addr - (0x700000 + 0x8000 * bank)];
                }
                else
                    return 0;
            else if (bank < 0x7E)
                return 0;
            else if (bank < 0x7F)
                if (effectiveAddr < 0x2000)
                    return _lowRam[effectiveAddr];
                else if (effectiveAddr < 0x8000)
                    return _highRam[effectiveAddr - 0x2000];
                else
                    return _expandedRam[effectiveAddr - 0x8000];
            else
                return _expandedRam[effectiveAddr + 0x8000];
        }
        public byte ReadByteRegister(uint Addr)
        {
            uint Register = (uint)(Addr & 0xFFFF);

            switch (Register)
            {
                case 0x4212:
                    {
                        byte ret = 0;

                        if (this._ppu.InVBlank)
                            ret |= 0x80;

                        if (this._cyclesToNextScanline >> Bus.CyclesPerDotShift > 256)
                            ret |= 0x40;

                        return ret;
                    }
                case 0x430A:
                case 0x431A:
                case 0x432A:
                case 0x433A:
                case 0x434A:
                case 0x435A:
                case 0x436A:
                case 0x437A:
                    return 0;

                case 0x4308:
                case 0x4309:

                case 0x4318:
                case 0x4319:

                case 0x4328:
                case 0x4329:

                case 0x4338:
                case 0x4339:

                case 0x4348:
                case 0x4349:

                case 0x4358:
                case 0x4359:

                case 0x4368:
                case 0x4369:

                case 0x4378:
                case 0x4379:
                    return 0;

                case 0x4211:
                    {
                        byte ret = 0x00;

                        if (!_horizontalCounterUntriggered)
                        {
                            this._untriggerIRQ();
                            this._horizontalCounterUntriggered = true;
                            ret = 0x80;
                        }

                        if (!_verticalCounterUntriggered)
                        {
                            this._untriggerIRQ();
                            this._verticalCounterUntriggered = true;
                            ret = 0x80;
                        }

                        return ret;
                    }
                case 0x4210:
                    {
                        byte ret;

                        if (_ppu.InVBlank && _register4210NotRead)
                        {
                            ret = 0x82;
                        }
                        else
                            ret = 0x02;

                        _register4210NotRead = false;

                        return ret;
                    }
                case 0x2140:
                    return _cpu._regs.Accumulator.Low;
                case 0x2141:
                    return _cpu._regs.Accumulator.High;
                case 0x2142:
                    return _cpu._regs.Accumulator.Low;
                case 0x2143:
                    return _cpu._regs.Accumulator.High;
                case 0x2137:
                    _horizontalLatchActivated = true;
                    _verticalLatchActivated = true;
                    return 0x55;
                case 0x213C:
                    if (_horizontalLatchActivated)
                    {
                        if (_horizontalLatchHighByte)
                        {
                            _horizontalLatchHighByte = false;
                            _horizontalLatchActivated = false;
                            return (byte)((this._cyclesToNextScanline >> CyclesPerDotShift) >> 8); 
                        }
                        else
                        {
                            _horizontalLatchHighByte = true;
                            return (byte)((this._cyclesToNextScanline >> CyclesPerDotShift) & 0xFF);
                        }
                    }
                    else
                        return 0x00;
                case 0x213D:
                    if (_verticalLatchActivated)
                    {
                        if (_verticalLatchHighByte)
                        {
                            _verticalLatchHighByte = false;
                            _verticalLatchActivated = false;
                            return (byte)(this._scanLineNumber >> 8);
                        }
                        else
                        {
                            _verticalLatchHighByte = true;
                            return (byte)(this._scanLineNumber & 0xFF);
                        }
                    }
                    else
                        return 0;
                case 0x213B:
                    if (this._cgramUploadAddress >= 0x200)
                        this._cgramUploadAddress -= 0x200;

                    return this._cgram[this._cgramUploadAddress++];
                case 0x2139:
                    {
                        byte ret = _vram[_vramByteUploadAddress];

                        if (!_incrementHighByte)
                            _vramByteUploadAddress += _incrementRate;

                        return ret;
                    }
                case 0x213A:
                    {
                        byte ret = _vram[_vramByteUploadAddress + 1];

                        if (_incrementHighByte)
                            _vramByteUploadAddress += _incrementRate;

                        return ret;
                    }
                case 0x2180:
                    {
                        return this.ReadByteWRam(this._wramAddressAccess.Data++);
                    }
                default:
                    return _hardwareRegs[Register - 0x2000];

            }
        }        

        public byte ReadByteRom(uint Addr)
        {
            uint bank = (Addr >> 16) & 0x7F;
            uint effectiveAddr = Addr & 0xFFFF;

            return _rom[Addr - (0x8000 * (bank + 1))];
        }

        public void Reset()
        {
            this._cyclesToNextScanline = CyclesPerScanline;
            this._scanLineNumber = 0;

            this._cpu.Reset();
            this._apu.Reset();
            this._ppu.Reset();

            _sRam = new byte[0x40000];
            _lowRam = new byte[0x2000];
            _highRam = new byte[0x6000];
            _expandedRam = new byte[0x18000];
            _hardwareRegs = new byte[0x4000];
        }

        public void WriteByte(uint Addr, byte b)
        {
            uint bank = (Addr >> 16) & 0x7F;
            uint effectiveAddr = Addr & 0xFFFF;

            if (bank < 0x40)
                if (effectiveAddr < 0x2000)
                    _lowRam[effectiveAddr] = b;
                else if (effectiveAddr < 0x6000)
                    WriteByteRegister(effectiveAddr, b);
                else return;
            else if (bank < 0x70)
                return;
            else if (bank < 0x78)
                if (effectiveAddr < 0x8000)
                {
                    bank -= 0x70;
                    _sRam[Addr - (0x700000 + 0x8000 * bank)] = b;
                }
                else
                    return;
            else if (bank < 0x7E)
                return;
            else if (bank < 0x7F)
                if (effectiveAddr < 0x2000)
                    _lowRam[effectiveAddr] = b;
                else if (effectiveAddr < 0x8000)
                    _highRam[effectiveAddr - 0x2000] = b;
                else
                    _expandedRam[effectiveAddr - 0x8000] = b;
            else
                _expandedRam[effectiveAddr + 0x8000] = b;
        }
        public void WriteByteRegister(uint Addr, byte b)
        {
            uint Register = (uint)(Addr & 0xFFFF);

            switch (Register)
            {
                case 0x420d:
                    if (b > 0)
                        this._cpuCyclesPerMasterCycles = 6;
                    else
                        this._cpuCyclesPerMasterCycles = 8;
                    break;
                case 0x2180:
                    this.WriteByteWRam(this._wramAddressAccess.Data++, b);
                    break;
                case 0x2181:
                    this._wramAddressAccess.LowerWord.Low = b;
                    break;
                case 0x2182:
                    this._wramAddressAccess.LowerWord.High = b;
                    break;
                case 0x2183:
                    this._wramAddressAccess.HigherByte = (byte)(b & 0x01);
                    break;
                case 0x213c:
                case 0x213d:
                    break;
                case 0x2131:
                    this._ppu.SubstractMode = (b & 0x80) > 0;
                    this._ppu.AffectBackground = (b & 0x20) > 0;

                    this._ppu.BG4.AffectedByColorConstant = (b & 0x08) > 0;
                    this._ppu.BG3.AffectedByColorConstant = (b & 0x04) > 0;
                    this._ppu.BG2.AffectedByColorConstant = (b & 0x02) > 0;
                    this._ppu.BG1.AffectedByColorConstant = (b & 0x01) > 0;

                    break;
                case 0x2132:
                    int colorConstant = (b & 0x1F) << 3;

                    unsafe
                    {
                        fixed (byte* data = this._ppu.ColorConstant.data)
                        {
                            data[0] = (byte)((b & 0x80) > 0 ? colorConstant : 0);
                            data[1] = (byte)((b & 0x40) > 0 ? colorConstant : 0);
                            data[2] = (byte)((b & 0x20) > 0 ? colorConstant : 0);
                        }
                    }
                    break;
                case 0x420B:
                    if ((b & 0x01) > 0) this.StartDMATransfer(_dmaChannels[0]);
                    if ((b & 0x02) > 0) this.StartDMATransfer(_dmaChannels[1]);
                    if ((b & 0x04) > 0) this.StartDMATransfer(_dmaChannels[2]);
                    if ((b & 0x08) > 0) this.StartDMATransfer(_dmaChannels[3]);
                    if ((b & 0x10) > 0) this.StartDMATransfer(_dmaChannels[4]);
                    if ((b & 0x20) > 0) this.StartDMATransfer(_dmaChannels[5]);
                    if ((b & 0x40) > 0) this.StartDMATransfer(_dmaChannels[6]);
                    if ((b & 0x80) > 0) this.StartDMATransfer(_dmaChannels[7]);
                    break;
                case 0x420C:
                    if ((b & 0x01) > 0) this.StartHDMATransfer(_dmaChannels[0]);
                    //else this.StopHDMATransfer(_dmaChannels[0]);
                    if ((b & 0x02) > 0) this.StartHDMATransfer(_dmaChannels[1]);
                    //else this.StopHDMATransfer(_dmaChannels[1]);
                    if ((b & 0x04) > 0) this.StartHDMATransfer(_dmaChannels[2]);
                    //else this.StopHDMATransfer(_dmaChannels[2]);
                    if ((b & 0x08) > 0) this.StartHDMATransfer(_dmaChannels[3]);
                    //else this.StopHDMATransfer(_dmaChannels[3]);
                    if ((b & 0x10) > 0) this.StartHDMATransfer(_dmaChannels[4]);
                    //else this.StopHDMATransfer(_dmaChannels[4]);
                    if ((b & 0x20) > 0) this.StartHDMATransfer(_dmaChannels[5]);
                    //else this.StopHDMATransfer(_dmaChannels[5]);
                    if ((b & 0x40) > 0) this.StartHDMATransfer(_dmaChannels[6]);
                    //else this.StopHDMATransfer(_dmaChannels[6]);
                    if ((b & 0x80) > 0) this.StartHDMATransfer(_dmaChannels[7]);
                    //else this.StopHDMATransfer(_dmaChannels[7]);
                    break;
                case 0x4300:
                    if ((b & 0x80) > 0) _dmaChannels[0].ReadFromRegsToCPUMemory = true;
                    else _dmaChannels[0].ReadFromRegsToCPUMemory = false;

                    if ((b & 0x40) > 0) _dmaChannels[0].IndirectHDMA = true;
                    else _dmaChannels[0].IndirectHDMA = false;

                    if ((b & 0x10) > 0) _dmaChannels[0].FixedCPUMemory = true;
                    else _dmaChannels[0].FixedCPUMemory = false;

                    if ((b & 0x08) > 0) _dmaChannels[0].DecrementCPUPointer = true;
                    else _dmaChannels[0].DecrementCPUPointer = false;

                    _dmaChannels[0].TransferType = (byte)(b & 0x07);
                    break;
                case 0x4301:
                    _dmaChannels[0].DestinationAddress = b;
                    break;
                case 0x4302:
                    _dmaChannels[0].SourceAddress.LowerWord.Low = b;
                    break;
                case 0x4303:
                    _dmaChannels[0].SourceAddress.LowerWord.High = b;
                    break;
                case 0x4304:
                    _dmaChannels[0].SourceAddress.HigherByte = b;
                    break;
                case 0x4305:
                    _dmaChannels[0].ByteAmount.Low = b;
                    break;
                case 0x4306:
                    _dmaChannels[0].ByteAmount.High = b;
                    break;
                case 0x4307:
                    break;
                case 0x4310:
                    if ((b & 0x80) > 0) _dmaChannels[1].ReadFromRegsToCPUMemory = true;
                    else _dmaChannels[1].ReadFromRegsToCPUMemory = false;

                    if ((b & 0x40) > 0) _dmaChannels[1].IndirectHDMA = true;
                    else _dmaChannels[1].IndirectHDMA = false;

                    if ((b & 0x10) > 0) _dmaChannels[1].FixedCPUMemory = true;
                    else _dmaChannels[1].FixedCPUMemory = false;

                    if ((b & 0x08) > 0) _dmaChannels[1].DecrementCPUPointer = true;
                    else _dmaChannels[1].DecrementCPUPointer = false;

                    _dmaChannels[1].TransferType = (byte)(b & 0x07);
                    break;
                case 0x4311:
                    _dmaChannels[1].DestinationAddress = b;
                    break;
                case 0x4312:
                    _dmaChannels[1].SourceAddress.LowerWord.Low = b;
                    break;
                case 0x4313:
                    _dmaChannels[1].SourceAddress.LowerWord.High = b;
                    break;
                case 0x4314:
                    _dmaChannels[1].SourceAddress.HigherByte = b;
                    break;
                case 0x4315:
                    _dmaChannels[1].ByteAmount.Low = b;
                    break;
                case 0x4316:
                    _dmaChannels[1].ByteAmount.High = b;
                    break;
                case 0x4317:
                    break;
                case 0x4320:
                    if ((b & 0x80) > 0) _dmaChannels[2].ReadFromRegsToCPUMemory = true;
                    else _dmaChannels[2].ReadFromRegsToCPUMemory = false;

                    if ((b & 0x40) > 0) _dmaChannels[2].IndirectHDMA = true;
                    else _dmaChannels[2].IndirectHDMA = false;

                    if ((b & 0x10) > 0) _dmaChannels[2].FixedCPUMemory = true;
                    else _dmaChannels[2].FixedCPUMemory = false;

                    if ((b & 0x08) > 0) _dmaChannels[2].DecrementCPUPointer = true;
                    else _dmaChannels[2].DecrementCPUPointer = false;

                    _dmaChannels[2].TransferType = (byte)(b & 0x07);
                    break;
                case 0x4321:
                    _dmaChannels[2].DestinationAddress = b;
                    break;
                case 0x4322:
                    _dmaChannels[2].SourceAddress.LowerWord.Low = b;
                    break;
                case 0x4323:
                    _dmaChannels[2].SourceAddress.LowerWord.High = b;
                    break;
                case 0x4324:
                    _dmaChannels[2].SourceAddress.HigherByte = b;
                    break;
                case 0x4325:
                    _dmaChannels[2].ByteAmount.Low = b;
                    break;
                case 0x4326:
                    _dmaChannels[2].ByteAmount.High = b;
                    break;
                case 0x4327:
                    break;
                case 0x4330:
                    if ((b & 0x80) > 0) _dmaChannels[3].ReadFromRegsToCPUMemory = true;
                    else _dmaChannels[3].ReadFromRegsToCPUMemory = false;

                    if ((b & 0x40) > 0) _dmaChannels[3].IndirectHDMA = true;
                    else _dmaChannels[3].IndirectHDMA = false;

                    if ((b & 0x10) > 0) _dmaChannels[3].FixedCPUMemory = true;
                    else _dmaChannels[3].FixedCPUMemory = false;

                    if ((b & 0x08) > 0) _dmaChannels[3].DecrementCPUPointer = true;
                    else _dmaChannels[3].DecrementCPUPointer = false;

                    _dmaChannels[3].TransferType = (byte)(b & 0x07);
                    break;
                case 0x4331:
                    _dmaChannels[3].DestinationAddress = b;
                    break;
                case 0x4332:
                    _dmaChannels[3].SourceAddress.LowerWord.Low = b;
                    break;
                case 0x4333:
                    _dmaChannels[3].SourceAddress.LowerWord.High = b;
                    break;
                case 0x4334:
                    _dmaChannels[3].SourceAddress.HigherByte = b;
                    break;
                case 0x4335:
                    _dmaChannels[3].ByteAmount.Low = b;
                    break;
                case 0x4336:
                    _dmaChannels[3].ByteAmount.High = b;
                    break;
                case 0x4337:
                    break;
                case 0x4340:
                    if ((b & 0x80) > 0) _dmaChannels[4].ReadFromRegsToCPUMemory = true;
                    else _dmaChannels[4].ReadFromRegsToCPUMemory = false;

                    if ((b & 0x10) > 0) _dmaChannels[4].FixedCPUMemory = true;
                    else _dmaChannels[4].FixedCPUMemory = false;

                    if ((b & 0x40) > 0) _dmaChannels[4].IndirectHDMA = true;
                    else _dmaChannels[4].IndirectHDMA = false;

                    if ((b & 0x08) > 0) _dmaChannels[4].DecrementCPUPointer = true;
                    else _dmaChannels[4].DecrementCPUPointer = false;

                    _dmaChannels[4].TransferType = (byte)(b & 0x07);
                    break;
                case 0x4341:
                    _dmaChannels[4].DestinationAddress = b;
                    break;
                case 0x4342:
                    _dmaChannels[4].SourceAddress.LowerWord.Low = b;
                    break;
                case 0x4343:
                    _dmaChannels[4].SourceAddress.LowerWord.High = b;
                    break;
                case 0x4344:
                    _dmaChannels[4].SourceAddress.HigherByte = b;
                    break;
                case 0x4345:
                    _dmaChannels[4].ByteAmount.Low = b;
                    break;
                case 0x4346:
                    _dmaChannels[4].ByteAmount.High = b;
                    break;
                case 0x4347:
                    break;
                case 0x4350:
                    if ((b & 0x80) > 0) _dmaChannels[5].ReadFromRegsToCPUMemory = true;
                    else _dmaChannels[5].ReadFromRegsToCPUMemory = false;

                    if ((b & 0x40) > 0) _dmaChannels[5].IndirectHDMA = true;
                    else _dmaChannels[5].IndirectHDMA = false;

                    if ((b & 0x10) > 0) _dmaChannels[5].FixedCPUMemory = true;
                    else _dmaChannels[5].FixedCPUMemory = false;

                    if ((b & 0x08) > 0) _dmaChannels[5].DecrementCPUPointer = true;
                    else _dmaChannels[5].DecrementCPUPointer = false;

                    _dmaChannels[5].TransferType = (byte)(b & 0x07);
                    break;
                case 0x4351:
                    _dmaChannels[5].DestinationAddress = b;
                    break;
                case 0x4352:
                    _dmaChannels[5].SourceAddress.LowerWord.Low = b;
                    break;
                case 0x4353:
                    _dmaChannels[5].SourceAddress.LowerWord.High = b;
                    break;
                case 0x4354:
                    _dmaChannels[5].SourceAddress.HigherByte = b;
                    break;
                case 0x4355:
                    _dmaChannels[5].ByteAmount.Low = b;
                    break;
                case 0x4356:
                    _dmaChannels[5].ByteAmount.High = b;
                    break;
                case 0x4357:
                    break;
                case 0x4360:
                    if ((b & 0x80) > 0) _dmaChannels[6].ReadFromRegsToCPUMemory = true;
                    else _dmaChannels[6].ReadFromRegsToCPUMemory = false;

                    if ((b & 0x40) > 0) _dmaChannels[6].IndirectHDMA = true;
                    else _dmaChannels[6].IndirectHDMA = false;

                    if ((b & 0x10) > 0) _dmaChannels[6].FixedCPUMemory = true;
                    else _dmaChannels[6].FixedCPUMemory = false;

                    if ((b & 0x08) > 0) _dmaChannels[6].DecrementCPUPointer = true;
                    else _dmaChannels[6].DecrementCPUPointer = false;

                    _dmaChannels[6].TransferType = (byte)(b & 0x07);
                    break;
                case 0x4361:
                    _dmaChannels[6].DestinationAddress = b;
                    break;
                case 0x4362:
                    _dmaChannels[6].SourceAddress.LowerWord.Low = b;
                    break;
                case 0x4363:
                    _dmaChannels[6].SourceAddress.LowerWord.High = b;
                    break;
                case 0x4364:
                    _dmaChannels[6].SourceAddress.HigherByte = b;
                    break;
                case 0x4365:
                    _dmaChannels[6].ByteAmount.Low = b;
                    break;
                case 0x4366:
                    _dmaChannels[6].ByteAmount.High = b;
                    break;
                case 0x4367:
                    break;
                case 0x4370:
                    if ((b & 0x80) > 0) _dmaChannels[7].ReadFromRegsToCPUMemory = true;
                    else _dmaChannels[7].ReadFromRegsToCPUMemory = false;

                    if ((b & 0x40) > 0) _dmaChannels[7].IndirectHDMA = true;
                    else _dmaChannels[7].IndirectHDMA = false;

                    if ((b & 0x10) > 0) _dmaChannels[7].FixedCPUMemory = true;
                    else _dmaChannels[7].FixedCPUMemory = false;

                    if ((b & 0x08) > 0) _dmaChannels[7].DecrementCPUPointer = true;
                    else _dmaChannels[7].DecrementCPUPointer = false;

                    _dmaChannels[7].TransferType = (byte)(b & 0x07);
                    break;
                case 0x4371:
                    _dmaChannels[7].DestinationAddress = b;
                    break;
                case 0x4372:
                    _dmaChannels[7].SourceAddress.LowerWord.Low = b;
                    break;
                case 0x4373:
                    _dmaChannels[7].SourceAddress.LowerWord.High = b;
                    break;
                case 0x4374:
                    _dmaChannels[7].SourceAddress.HigherByte = b;
                    break;
                case 0x4375:
                    _dmaChannels[7].ByteAmount.Low = b;
                    break;
                case 0x4376:
                    _dmaChannels[7].ByteAmount.High = b;
                    break;
                case 0x4377:
                    break;
                case 0x2121:
                    _cgramUploadAddress = (b << 1);
                    break;
                case 0x2122:
                    _cgram[_cgramUploadAddress++] = b;
                    break;
                case 0x2107:
                    {
                        if (_hardwareRegs[Register - 0x2000] != b)
                        {
                            _ppu.BG1.TileMapLocation = (b << 9) & 0xF800;
                            int Size = b & 0x03;
                            switch (Size)
                            {
                                case 0:
                                    _ppu.BG1.VerticalTileMapSize = 32;
                                    _ppu.BG1.HorizontalTileMapSize = 32;
                                    break;
                                case 1:
                                    _ppu.BG1.VerticalTileMapSize = 32;
                                    _ppu.BG1.HorizontalTileMapSize = 64;
                                    break;
                                case 2:
                                    _ppu.BG1.VerticalTileMapSize = 64;
                                    _ppu.BG1.HorizontalTileMapSize = 32;
                                    break;
                                case 3:
                                    _ppu.BG1.VerticalTileMapSize = 64;
                                    _ppu.BG1.HorizontalTileMapSize = 64;
                                    break;
                            }

                            _hardwareRegs[Register - 0x2000] = b;
                        }
                        break;
                    }
                case 0x2108:
                    {
                        _ppu.BG2.TileMapLocation = (b << 9) & 0xF800;
                        int Size = b & 0x03;
                        switch (Size)
                        {
                            case 0:
                                _ppu.BG2.VerticalTileMapSize = 32;
                                _ppu.BG2.HorizontalTileMapSize = 32;
                                break;
                            case 1:
                                _ppu.BG2.VerticalTileMapSize = 32;
                                _ppu.BG2.HorizontalTileMapSize = 64;
                                break;
                            case 2:
                                _ppu.BG2.VerticalTileMapSize = 64;
                                _ppu.BG2.HorizontalTileMapSize = 32;
                                break;
                            case 3:
                                _ppu.BG2.VerticalTileMapSize = 64;
                                _ppu.BG2.HorizontalTileMapSize = 64;
                                break;
                        }
                        break;
                    }
                case 0x2109:
                    {
                        _ppu.BG3.TileMapLocation = (b << 9) & 0xF800;
                        int Size = b & 0x03;
                        switch (Size)
                        {
                            case 0:
                                _ppu.BG3.VerticalTileMapSize = 32;
                                _ppu.BG3.HorizontalTileMapSize = 32;
                                break;
                            case 1:
                                _ppu.BG3.VerticalTileMapSize = 32;
                                _ppu.BG3.HorizontalTileMapSize = 64;
                                break;
                            case 2:
                                _ppu.BG3.VerticalTileMapSize = 64;
                                _ppu.BG3.HorizontalTileMapSize = 32;
                                break;
                            case 3:
                                _ppu.BG3.VerticalTileMapSize = 64;
                                _ppu.BG3.HorizontalTileMapSize = 64;
                                break;
                        }
                        break;
                    }
                case 0x210A:
                    {
                        _ppu.BG4.TileMapLocation = (b << 9) & 0xF800;
                        int Size = b & 0x03;
                        switch (Size)
                        {
                            case 0:
                                _ppu.BG4.VerticalTileMapSize = 32;
                                _ppu.BG4.HorizontalTileMapSize = 32;
                                break;
                            case 1:
                                _ppu.BG4.VerticalTileMapSize = 32;
                                _ppu.BG4.HorizontalTileMapSize = 64;
                                break;
                            case 2:
                                _ppu.BG4.VerticalTileMapSize = 64;
                                _ppu.BG4.HorizontalTileMapSize = 32;
                                break;
                            case 3:
                                _ppu.BG4.VerticalTileMapSize = 64;
                                _ppu.BG4.HorizontalTileMapSize = 64;
                                break;
                        }
                        break;
                    }
                case 0x210B:
                    _ppu.BG1.CharacterLocation = (b << 13) & 0xF000;
                    _ppu.BG2.CharacterLocation = ((b >> 4) << 13) & 0xF000;
                    break;
                case 0x210C:
                    _ppu.BG3.CharacterLocation = (b << 13) & 0xF000;
                    _ppu.BG4.CharacterLocation = ((b >> 4) << 13) & 0xF000;
                    break;
                case 0x2115:
                    _incrementHighByte = (b & 0x80) > 0;
                    int IncrementRate = b & 0x03;
                    switch (IncrementRate)
                    {
                        case 0x00:
                            _incrementRate = 2;
                            break;
                        case 0x01:
                            _incrementRate = 64;
                            break;
                        case 0x02:
                            _incrementRate = 128;
                            break;
                        case 0x03:
                            _incrementRate = 256;
                            break;
                    }
                    break;
                case 0x2116:
                    _vramWordUploadAddress &= 0xFF00;
                    _vramWordUploadAddress |= b;

                    if (_vramByteUploadAddress >= _vram.Length)
                        _vramByteUploadAddress -= _vram.Length;

                    break;
                case 0x2117:
                    _vramWordUploadAddress &= 0x00FF;
                    _vramWordUploadAddress |= b << 8;

                    if (_vramByteUploadAddress >= _vram.Length)
                        _vramByteUploadAddress -= _vram.Length;

                    break;
                case 0x2118:
                    _vram[_vramByteUploadAddress] = b;

                    if (!_incrementHighByte)
                    {
                        _vramByteUploadAddress += _incrementRate;

                        if (_vramByteUploadAddress >= _vram.Length)
                            _vramByteUploadAddress -= _vram.Length;
                    }
                    break;
                case 0x2119:
                    _vram[_vramByteUploadAddress + 1] = b;

                    if (_incrementHighByte)
                    {
                        _vramByteUploadAddress += _incrementRate;

                        if (_vramByteUploadAddress >= _vram.Length)
                            _vramByteUploadAddress -= _vram.Length;
                    }
                    break;
                case 0x2100:
                    if ((b & 0x80) > 0)
                    {
                        _ppu.DisableScreen = true;
                        _ppu.InVBlank = true;
                        _register4210NotRead = true;
                        _scanLineNumber = 224;

                        if (_nmiEnabled && !_cpu._regs.InterruptsDisabled)
                        {
                            this.TriggerNMI();
                        }
                    }
                    else
                    {
                        _ppu.DisableScreen = false;
                        _ppu.InVBlank = false;
                    }

                    _ppu.Brightness = b & 0x0F;
                    PictureProcesingUnit.BG.ColorScheme = PictureProcesingUnit.BG.ColorData[_ppu.Brightness];

                    break;
                case 0x212C:
                    //_ppu.BG1.Enabled = (b & 0x01) > 0;
                    //_ppu.BG2.Enabled = (b & 0x02) > 0;
                    //_ppu.BG3.Enabled = (b & 0x04) > 0;
                    //_ppu.BG4.Enabled = (b & 0x08) > 0;

                    break;
                case 0x4200:
                    this._nmiEnabled = (b & 0x80) > 0;
                    this._register4210NotRead = true;
                    this._verticalCounterActivated = (b & 0x20) > 0;
                    this._horizontalCounterActivated = (b & 0x10) > 0;
                    break;
                case 0x2105:
                    if (this._hardwareRegs[Register - 0x2000] != b)
                    {
                        int screenMode = b & 0x07;

                        _ppu.BG1.TileSize = (b & 0x10) > 0 ? 16 : 8;
                        _ppu.BG1.TileSizeShift = (b & 0x10) > 0 ? 4 : 3;
                        _ppu.BG2.TileSize = (b & 0x20) > 0 ? 16 : 8;
                        _ppu.BG2.TileSizeShift = (b & 0x20) > 0 ? 4 : 3;
                        _ppu.BG3.TileSize = (b & 0x40) > 0 ? 16 : 8;
                        _ppu.BG3.TileSizeShift = (b & 0x40) > 0 ? 4 : 3;
                        _ppu.BG4.TileSize = (b & 0x80) > 0 ? 16 : 8;
                        _ppu.BG4.TileSizeShift = (b & 0x80) > 0 ? 4 : 3;

                        _ppu.BGMode = screenMode;
                        _ppu.PriorityBit = (b & 0x08) > 0;

                        this._hardwareRegs[Register - 0x2000] = b;
                    }
                    break;

                case 0x210D:
                    if (this._ppu.BG1.HorizontalScrollHighByte)
                        this._ppu.BG1.HorizontalScroll |= (ushort)((b & 0x03) << 8);
                    else
                        this._ppu.BG1.HorizontalScroll = b;

                    this._ppu.BG1.HorizontalScrollHighByte = !this._ppu.BG1.HorizontalScrollHighByte;
                    break;

                case 0x210E:
                    if (this._ppu.BG1.VerticalScrollHighByte)
                        this._ppu.BG1.VerticalScroll |= (ushort)((b & 0x03) << 8);
                    else
                        this._ppu.BG1.VerticalScroll = b;

                    this._ppu.BG1.VerticalScrollHighByte = !this._ppu.BG1.VerticalScrollHighByte;
                    break;
                case 0x210F:
                    if (this._ppu.BG2.HorizontalScrollHighByte)
                        this._ppu.BG2.HorizontalScroll |= (ushort)((b & 0x03) << 8);
                    else
                        this._ppu.BG2.HorizontalScroll = b;

                    this._ppu.BG2.HorizontalScrollHighByte = !this._ppu.BG2.HorizontalScrollHighByte;
                    break;

                case 0x2110:
                    if (this._ppu.BG2.VerticalScrollHighByte)
                        this._ppu.BG2.VerticalScroll |= (ushort)((b & 0x03) << 8);
                    else
                        this._ppu.BG2.VerticalScroll = b;

                    this._ppu.BG2.VerticalScrollHighByte = !this._ppu.BG2.VerticalScrollHighByte;
                    break;
                case 0x2111:
                    if (this._ppu.BG3.HorizontalScrollHighByte)
                        this._ppu.BG3.HorizontalScroll |= (ushort)((b & 0x03) << 8);
                    else
                        this._ppu.BG3.HorizontalScroll = b;

                    this._ppu.BG3.HorizontalScrollHighByte = !this._ppu.BG3.HorizontalScrollHighByte;
                    break;

                case 0x2112:
                    if (this._ppu.BG3.VerticalScrollHighByte)
                        this._ppu.BG3.VerticalScroll |= (ushort)((b & 0x03) << 8);
                    else
                        this._ppu.BG3.VerticalScroll = b;

                    this._ppu.BG3.VerticalScrollHighByte = !this._ppu.BG3.VerticalScrollHighByte;
                    break;
                case 0x2113:
                    if (this._ppu.BG4.HorizontalScrollHighByte)
                        this._ppu.BG4.HorizontalScroll |= (ushort)((b & 0x03) << 8);
                    else
                        this._ppu.BG4.HorizontalScroll = b;

                    this._ppu.BG4.HorizontalScrollHighByte = !this._ppu.BG4.HorizontalScrollHighByte;
                    break;

                case 0x2114:
                    if (this._ppu.BG4.VerticalScrollHighByte)
                        this._ppu.BG4.VerticalScroll |= (ushort)((b & 0x03) << 8);
                    else
                        this._ppu.BG4.VerticalScroll = b;

                    this._ppu.BG4.VerticalScrollHighByte = !this._ppu.BG4.VerticalScrollHighByte;
                    break;
                case 0x2123:
                case 0x2124:
                case 0x2125:
                case 0x2126:
                case 0x2127:
                case 0x2128:
                case 0x2129:
                case 0x212A:
                case 0x212B:
                case 0x212E:
                case 0x212F:
                    break;
                case 0x4207:
                    this._horizontalCounter |= b;
                    break;
                case 0x4208:
                    this._horizontalCounter |= (b & 0x01) << 8;
                    break;
                case 0x4209:
                    this._verticalCounter |= b;
                    break;
                case 0x420A:
                    this._verticalCounter |= (b & 0x01) << 8;
                    break;
                default:
                    _hardwareRegs[Register - 0x2000] = b;
                    break;
            }
        }

        private void StopHDMATransfer(DMAChannel DMAChannel)
        {
            DMAChannel.StopHDMATransfer();
            DMAChannel.InHDMATransfer = false;
        }
        private void StartHDMATransfer(DMAChannel DMAChannel)
        {
            DMAChannel.StartHDMATransfer();
            DMAChannel.InHDMATransfer = true;
            DMAChannel.TransferQueued = true;
        }

        public byte ReadByteWRam(uint effectiveAddr)
        {
            if (effectiveAddr < 0x2000)
                return _lowRam[effectiveAddr];
            else if (effectiveAddr < 0x8000)
                return _highRam[effectiveAddr - 0x2000];
            else
                return _expandedRam[effectiveAddr - 0x8000];
        }
        public void WriteByteWRam(uint effectiveAddr, byte b)
        {
            if (effectiveAddr < 0x2000)
                _lowRam[effectiveAddr] = b;
            else if (effectiveAddr < 0x8000)
                _highRam[effectiveAddr - 0x2000] = b;
            else
                _expandedRam[effectiveAddr - 0x8000] = b;
        }

        public void Step()
        {
            if (this.currentDMAChannel != null)
            {
                this.currentDMAChannel.Step();
                this._cyclesToNextScanline -= _cpuCyclesPerMasterCycles;
            }
            else if (!this._cpu.WaitingInterrupt)
            {
                this._cpu.Step();
                int cycleCorrection = this._apu.Step(this._cpu.CurrentOpCycles * _cpuCyclesPerMasterCycles);
                this._cyclesToNextScanline -= this._cpu.CurrentOpCycles * _cpuCyclesPerMasterCycles + cycleCorrection;
            }
            else
            {
                int cycleCorrection = this._apu.Step(_cyclesToNextScanline);
                this._cyclesToNextScanline = -cycleCorrection;
            }

            if (_cyclesToNextScanline <= 0)
            {
                if (_scanLineNumber < 224 && !this._ppu.DisableScreen)
                    this._ppu.DrawScanline(_scanLineNumber);

                _horizontalCounterUntriggered = false;
                _cyclesToNextScanline += CyclesPerScanline;

                for (int i = 0; i < 8; i++)
                {
                    if (this._dmaChannels[i].InHDMATransfer)
                        this._dmaChannels[i].StepHDMA();
                }

                _scanLineNumber++;
            }

            if (_scanLineNumber == _verticalCounter && _verticalCounterActivated && !_verticalCounterUntriggered)
                TriggerIRQ();

            if (_cyclesToNextScanline >> CyclesPerDotShift == _horizontalCounter && _horizontalCounterActivated && !_horizontalCounterUntriggered)
                TriggerIRQ();

            if (_scanLineNumber == NMIScanlineTrigger && !this._ppu.InVBlank)
            {
                TriggerNMI();

                this._ppu.InVBlank = true;
                this._register4210NotRead = true;
            }
        }

        public void Run()
        {
            for (int i = 0; i < 8; i++)
            {
                if (this._dmaChannels[i].InHDMATransfer)
                    this._dmaChannels[i].StartHDMATransfer();
            }

            while (_scanLineNumber < ScanlinesPerFrame)
            {
                this.Step();
            }

            _scanLineNumber = 0;
            _ppu.InVBlank = false;
            _verticalCounterUntriggered = false;

            for (int i = 0; i < 8; i++)
            {
                if (this._dmaChannels[i].TransferQueued)
                    this._dmaChannels[i].TransferQueued = false;
            }
        }
    }
}
