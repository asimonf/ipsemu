using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Windows.Forms;
using System.Collections;

namespace Infinity_Project
{
    public partial class CentralProcesingUnit
    {
        public struct Registers
        {
            // Atributos
            public Word Accumulator, X, Y, ProgramCounter, DirectPage, StackPointer;
            public byte _Flags;
            public byte DataBank, ProgramBank;
            public uint EmulatorMode, AccumulatorMode, IndexMode;
            public bool InterruptsDisabled;

            // Propiedades
            public byte Flags
            {
                get
                {
                    return this._Flags;
                }
                set
                {
                    if (value != this._Flags)
                    {
                        this.AccumulatorMode = (uint)((value & 0x20) >> 5);
                        this.IndexMode = (uint)((value & 0x10) >> 4);
                        this.InterruptsDisabled = (value & 0x04) > 0;

                        this._Flags = value;
                    }
                }
            }
        }

		// Atributos
        internal Registers _regs;
        internal int CurrentOpCycles = 0;

        private Bus _bus;

		private bool _inNMI;
        private bool _nmiPending;
        private bool _irqPending;
        private bool _waitInterrupt;

        public bool InNmi
        {
            get
            {
                return this._inNMI;
            }
        }

        private OpcodeHandler[, , ,] _opcodeTable;

        public const int NMIVector_E1 = 0x0000FFFA;
        public const int NMIVector_E0 = 0x0000FFEA;

        public const int IRQVector_E1 = 0x0000FFFE;
        public const int IRQVector_E0 = 0x0000FFEE;

        public const int RESVector = 0x0000FFFC;

		public delegate void OpcodeHandler();

		// Constructores
        public CentralProcesingUnit(Bus bus)
        {
            _regs = new Registers();
            _bus = bus;

			_opcodeTable = new OpcodeHandler[2, 2, 2, 256];

			GenerateOpcodeTable();
        }

        internal bool NMIPending
        {
            get
            {
                return this._nmiPending;
            }
            set
            {
                this._nmiPending = value;

                if (value)
                    this._waitInterrupt = false;
            }
        }

        internal bool IRQPending
        {
            get
            {
                return this._irqPending;
            }
            set
            {
                this._irqPending = value;
            }
        }

        internal bool WaitingInterrupt
        {
            get
            {
                return this._waitInterrupt;
            }
        }

		// Métodos
		#region Addressing Modes (Listo)

		private uint Immediate() //Listo
		{
			return (uint)(_regs.ProgramBank << 16 | _regs.ProgramCounter.Data + 1);
		}
		private uint Absolute() //Listo
		{
			return (uint)(_regs.DataBank << 16 |
				(_bus.ReadByte((uint)(_regs.ProgramBank << 16 | _regs.ProgramCounter.Data + 1))) |
				(_bus.ReadByte((uint)(_regs.ProgramBank << 16 | _regs.ProgramCounter.Data + 2)) << 8));
		}
		private uint AbsoluteLong() //Listo
		{
			return (uint)(_bus.ReadByte((uint)(_regs.ProgramBank << 16 | _regs.ProgramCounter.Data + 3)) << 16 |
				_bus.ReadByte((uint)(_regs.ProgramBank << 16 | _regs.ProgramCounter.Data + 2)) << 8 |
				_bus.ReadByte((uint)(_regs.ProgramBank << 16 | _regs.ProgramCounter.Data + 1)));
		}
		private uint Direct() //Listo
		{
			return (uint)(_regs.DirectPage.Data + _bus.ReadByte((uint)(_regs.ProgramBank << 16 | _regs.ProgramCounter.Data + 1)));
		}
		private uint DirectIndirectIndexed_X1() //Listo
		{
			return (uint)((uint)(_regs.DataBank << 16) | Direct()) + _regs.Y.Low;
		}
		private uint DirectIndirectIndexed_X0() //Listo
		{
			return (uint)((uint)(_regs.DataBank << 16) | Direct()) + _regs.Y.Data;
		}
		private uint DirectIndirectIndexedLong_X1() //Listo
		{
			return Direct() + _regs.Y.Low;
		}
		private uint DirectIndirectIndexedLong_X0() //Listo
		{
			return Direct() + _regs.Y.Data;
		}
		private uint DirectIndexedIndirect_X1() //Listo
		{
			return (uint)((uint)(_regs.DataBank << 16) | Direct()) + _regs.X.Low;
		}
		private uint DirectIndexedIndirect_X0() //Listo
		{
			return (uint)((uint)(_regs.DataBank << 16) | Direct()) + _regs.X.Data;
		}
		private uint DirectIndexedX_X1() //Listo
		{
			return (uint)(Direct() + _regs.X.Low);
		}
		private uint DirectIndexedX_X0() //Listo
		{
			return (uint)(Direct() + _regs.X.Data & 0xFFFF);
		}
		private uint DirectIndexedY_X1() //Listo
		{
			return (uint)(Direct() + _regs.Y.Low);
		}
		private uint DirectIndexedY_X0() //Listo
		{
			return (uint)(Direct() + _regs.Y.Data & 0xFFFF);
		}
		private uint AbsoluteIndexedX_X1() //Listo
		{
			return Absolute() + _regs.X.Low;
		}
		private uint AbsoluteIndexedX_X0() //Listo
		{
			return Absolute() + _regs.X.Data;
		}
		private uint AbsoluteIndexedY_X1() //Listo
		{
			return Absolute() + _regs.Y.Low;
		}
		private uint AbsoluteIndexedY_X0() //Listo
		{
			return Absolute() + _regs.Y.Data;
		}
		private uint AbsoluteLongIndexedX_X1() //Listo
		{
			return AbsoluteLong() + _regs.X.Low;
		}
		private uint AbsoluteLongIndexedX_X0() //Listo
		{
			return AbsoluteLong() + _regs.X.Data;
		}
		private uint AbsoluteIndirect() //Listo
		{
			return (uint)(_bus.ReadByte((uint)(_regs.ProgramBank << 16 | _regs.ProgramCounter.Data + 2)) << 8 | _bus.ReadByte((uint)(_regs.ProgramBank << 16 | _regs.ProgramCounter.Data + 1)));
		}
		private uint AbsoluteIndirectLong() //Listo
		{
			return (uint)(_bus.ReadByte((uint)(_regs.ProgramBank << 16 | _regs.ProgramCounter.Data + 3)) << 16 | _bus.ReadByte((uint)(_regs.ProgramBank << 16 | _regs.ProgramCounter.Data + 2)) << 8 | _bus.ReadByte((uint)(_regs.ProgramBank << 16 | _regs.ProgramCounter.Data + 1)));
		}
		private uint DirectIndirect() //Listo
		{
			uint Address = Direct();
			return (uint)(_regs.DataBank << 16 | _bus.ReadByte(Address + 1) << 8 | _bus.ReadByte(Address));
		}
		private uint DirectIndirectLong() //Listo
		{
			uint Address = Direct();
			return (uint)(_bus.ReadByte(Address + 2) << 16 | _bus.ReadByte(Address + 1) << 8 | _bus.ReadByte(Address));
		}
		private uint AbsoluteIndexedIndirect_X1() //Listo
		{
			return (uint)((_bus.ReadByte((uint)(_regs.ProgramBank << 16 | _regs.ProgramCounter.Data + 2)) << 8 | _bus.ReadByte((uint)(_regs.ProgramBank << 16 | _regs.ProgramCounter.Data + 1))) + _regs.X.Low);
		}
		private uint AbsoluteIndexedIndirect_X0() //Listo
		{
			return (uint)((_bus.ReadByte((uint)(_regs.ProgramBank << 16 | _regs.ProgramCounter.Data + 2)) << 8 | _bus.ReadByte((uint)(_regs.ProgramBank << 16 | _regs.ProgramCounter.Data + 1))) + _regs.X.Data);
		}
		private uint StackRelative() //Listo
		{
			return (uint)(_regs.StackPointer.Data + _bus.ReadByte((uint)(_regs.ProgramBank << 16 | _regs.ProgramCounter.Data + 1)) & 0xFFFF);
		}
		private uint StackRelativeIndirectIndexed_X1() //Listo
		{
			return (uint)(((uint)(_regs.DataBank << 16) | StackRelative()) + _regs.Y.Low);
		}
		private uint StackRelativeIndirectIndexed_X0() //Listo
		{
			return (uint)(((uint)(_regs.DataBank << 16) | StackRelative()) + _regs.Y.Data);
		}

        #region Modos Raros

		//private Address WAbsolute() //Listo
		//{
		//    addr.High = Registers.ProgramBank;
		//    addr.Low = (word)(Registers.ProgramCounter.Word + 1);

		//    addr.Low = Memoria.GetMemWord(addr);
		//    addr.High = Registers.DataBank;

		//    this.Registers.CycleCounter += 4;
		//    this.Registers.ProgramCounter.Word += 2;

		//    return addr;
		//}

		//private Address WDirect() //Listo
		//{
		//    addr.High = Registers.ProgramBank;
		//    addr.Low = (word)(Registers.ProgramCounter.Word + 1);

		//    addr.All = (longword)(Registers.DirectPage.Word + Memoria.GetMemByte(addr));

		//    this.Registers.CycleCounter += (byte)(this.Registers.DirectPage.Low != 0 ? 4 : 3);
		//    this.Registers.ProgramCounter.Word++;

		//    return addr;
		//}

		//private Address WDirIndexedXX1() //Listo
		//{
		//    addr = WDirect();
		//    addr.Low += Registers.X.Low;

		//    this.Registers.CycleCounter += 1;


		//    return addr;
		//}

		//private Address WDirIndexedXX0() //Listo
		//{
		//    addr = WDirect();
		//    addr.Low += Registers.X.Word;

		//    this.Registers.CycleCounter += 1;

		//    return addr;
		//}

		//private Address WAbsIndexedXX1() //Listo
		//{
		//    addr = WAbsolute();

		//    addr.Low += Registers.X.Low;

		//    this.Registers.CycleCounter += 1;

		//    return addr;
		//}

		//private Address WAbsIndexedXX0() //Listo
		//{
		//    addr = WAbsolute();
		//    addr.Low += Registers.X.Word;

		//    this.Registers.CycleCounter += 1;

		//    return addr;
		//}

		#endregion
		#endregion

		#region Stack Related
		private void PushByte(byte b)
		{
			_bus.WriteByte(_regs.StackPointer.Data--, b);
		}
		private byte PullByte()
		{
			return _bus.ReadByte(++_regs.StackPointer.Data);
		}
		#endregion

		#region Flag Related

		private byte GetNegativeFlag(byte b)
		{
			return (byte)((b & 0x80));
		}
		private byte GetZeroFlag(byte b)
		{
			return (byte)(b > 0 ? 0x00 : 0x02);
		}
		private byte GetZeroFlag(ushort b)
		{
			return (byte)(b > 0 ? 0x00 : 0x02);
		}
		private byte GetZeroFlag(uint b)
		{
			return (byte)(b > 0 ? 0x00 : 0x02);
		}
		private void SetZeroFlag()
		{
			_regs.Flags |= 0x02;
		}
		private void ClearZeroFlag()
		{
			_regs.Flags &= 0xFD;
		}
		private void SetNegativeFlag()
		{
			_regs.Flags |= 0x80;
		}
		private void ClearNegativeFlag()
		{
			_regs.Flags &= 0x7F;
		}
		private void SetOverflowFlag()
		{
			_regs.Flags |= 0x40;
		}
		private void ClearOverflowFlag()
		{
			_regs.Flags &= 0xBF;
		}

		#endregion

		private void InterruptE1(ushort x)
		{
            //Regs.ProgramCounter.Data += 2;
			PushByte(_regs.ProgramCounter.High);
			PushByte(_regs.ProgramCounter.Low);
			PushByte(_regs.Flags);
			_regs.Flags = (byte)((_regs.Flags | 0x04) & 0xF7);

			_regs.ProgramCounter.Low = _bus.ReadByte(x);
			_regs.ProgramCounter.High = _bus.ReadByte(x + (uint)1);
		}
        private void InterruptE0(ushort x)
        {
            //Regs.ProgramCounter.Data += 2;
            PushByte(_regs.ProgramBank);
            PushByte(_regs.ProgramCounter.High);
            PushByte(_regs.ProgramCounter.Low);
            PushByte(_regs.Flags);

            _regs.ProgramCounter.Low = _bus.ReadByte(x);
            _regs.ProgramCounter.High = _bus.ReadByte(x + (uint)1);
        }

		public void Reset()
		{
			_regs.Accumulator.Data = 0;
			_regs.X.Data = 0;
			_regs.Y.Data = 0;
			_regs.DataBank = 0;
			_regs.DirectPage.Data = 0;
			_regs.EmulatorMode = 1;
			_regs.Flags = 0x34;
			_regs.StackPointer.Data = 0x01FF;

			_regs.ProgramBank = 0;
            _regs.ProgramCounter.Low = _bus.ReadByte(RESVector);
            _regs.ProgramCounter.High = _bus.ReadByte(RESVector + 1);    
		}

		public void Step()
		{
            if (_nmiPending)
            {
                if (_regs.EmulatorMode > 0) InterruptE1(NMIVector_E1);
                else InterruptE0(NMIVector_E0);

                _nmiPending = false;
                _inNMI = true;
            }
            else if (_irqPending && !_inNMI)
            {
                if (_regs.EmulatorMode > 0) InterruptE1(IRQVector_E1);
                else InterruptE0(IRQVector_E0);

                _irqPending = false;
            }

            this._opcodeTable[_regs.EmulatorMode, _regs.AccumulatorMode, _regs.IndexMode, this._bus.ReadByte((uint)(_regs.ProgramBank << 16) | _regs.ProgramCounter.Data)]();
		}
    }
}
