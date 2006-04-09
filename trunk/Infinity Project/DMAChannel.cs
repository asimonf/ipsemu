using System;
using System.Collections.Generic;
using System.Text;

namespace Infinity_Project
{
    public class DMAChannel
    {
        public delegate void StepHDMADelegate();

        private int _count;
        private byte _delayCount;
        private Word _data;
        private LWord _tmpSourceAddress;

        public LWord SourceAddress;
        public byte DestinationAddress;
        public Word ByteAmount;
        public bool TransferQueued;
        public bool InHDMATransfer;

        public bool ReadFromRegsToCPUMemory = false;
        public bool FixedCPUMemory = false;
        public bool DecrementCPUPointer = false;
        public byte TransferType;

        public bool HDMAMode;
        public bool IndirectHDMA;
        public bool HDMATransferEnabled;

        public bool PriorityBit = false;

        public Bus Bus;

        public DMAChannel(Bus bus)
        {
            this.Bus = bus;
        }

        public void StartTransfer()
        {
            this._count = 0;
        }
        public void StartHDMATransfer()
        {
            this.HDMATransferEnabled = true;
            this._tmpSourceAddress = this.SourceAddress;

            this._delayCount = this.Bus.ReadByte(this._tmpSourceAddress.Data++);

            this._data.Low = this.Bus.ReadByte(this._tmpSourceAddress.Data++);

            if (this.TransferType != 0x00)
                this._data.High = this.Bus.ReadByte(this._tmpSourceAddress.Data++);

            switch (this.TransferType)
            {
                case 0x00:
                    this.Bus.WriteByteRegister((uint)0x2100 + this.DestinationAddress, this._data.Low);
                    break;
                case 0x01:
                    this.Bus.WriteByteRegister((uint)0x2100 + this.DestinationAddress, this._data.Low);
                    this.Bus.WriteByteRegister((uint)0x2100 + this.DestinationAddress + 1, this._data.High);
                    break;
                case 0x02:
                    this.Bus.WriteByteRegister((uint)0x2100 + this.DestinationAddress, this._data.Low);
                    this.Bus.WriteByteRegister((uint)0x2100 + this.DestinationAddress, this._data.High);
                    break;
            }
        }
        public void StopTransfer()
        {
            this.Bus.StopDMATransfer();
        }
        public void StopHDMATransfer()
        {
            this.HDMATransferEnabled = false;
        }

        public void Step()
        {
            if (this._count < ((this.ByteAmount.Data > 0) ? this.ByteAmount.Data : 65536))
            {
                switch (this.TransferType)
                {
                    case 0x00:
                        if (!this.FixedCPUMemory)
                        {
                            if (this.DecrementCPUPointer)
                            {
                                byte TransferData = Bus.ReadByte(this.SourceAddress.Data);
                                this.SourceAddress.LowerWord.Data--;
                                this.Bus.WriteByteRegister((uint)(0x2100 + this.DestinationAddress), TransferData);
                            }
                            else
                            {
                                byte TransferData = Bus.ReadByte(this.SourceAddress.Data);
                                this.SourceAddress.LowerWord.Data++;
                                this.Bus.WriteByteRegister((uint)(0x2100 + this.DestinationAddress), TransferData);
                            }
                        }
                        else
                        {
                            byte TransferData = Bus.ReadByte(this.SourceAddress.Data);
                            this.Bus.WriteByteRegister((uint)(0x2100 + this.DestinationAddress), TransferData);
                        }
                        break;
                    case 0x01:
                        if (!this.FixedCPUMemory)
                        {
                            if (this.DecrementCPUPointer)
                            {
                                byte TransferData = Bus.ReadByte(this.SourceAddress.Data);
                                this.SourceAddress.LowerWord.Data--;
                                this.Bus.WriteByteRegister((uint)(0x2100 + this.DestinationAddress + (_count % 2)), TransferData);
                            }
                            else
                            {
                                byte TransferData = Bus.ReadByte(this.SourceAddress.Data);
                                this.SourceAddress.LowerWord.Data++;
                                this.Bus.WriteByteRegister((uint)(0x2100 + this.DestinationAddress + (_count % 2)), TransferData);
                            }
                        }
                        else
                        {
                            byte TransferData = Bus.ReadByte(this.SourceAddress.Data);
                            this.Bus.WriteByteRegister((uint)(0x2100 + this.DestinationAddress + (_count % 2)), TransferData);
                        }
                        break;
                    case 0x02:
                        if (!this.FixedCPUMemory)
                        {
                            if (this.DecrementCPUPointer)
                            {
                                byte TransferData = Bus.ReadByte(this.SourceAddress.Data);
                                this.SourceAddress.LowerWord.Data -= (ushort)(_count % 2);
                                this.Bus.WriteByteRegister((uint)(0x2100 + this.DestinationAddress), TransferData);
                            }
                            else
                            {
                                byte TransferData = Bus.ReadByte(this.SourceAddress.Data);
                                this.SourceAddress.LowerWord.Data += (ushort)(_count % 2);
                                this.Bus.WriteByteRegister((uint)(0x2100 + this.DestinationAddress), TransferData);
                            }
                        }
                        else
                        {
                            byte TransferData = Bus.ReadByte(this.SourceAddress.Data);
                            this.Bus.WriteByteRegister((uint)(0x2100 + this.DestinationAddress), TransferData);
                        }
                        break;
                    case 0x03:
                        if (!this.FixedCPUMemory)
                        {
                            if (this.DecrementCPUPointer)
                            {
                                byte TransferData = Bus.ReadByte(this.SourceAddress.Data);
                                this.SourceAddress.LowerWord.Data -= (ushort)(_count % 2);
                                this.Bus.WriteByteRegister((uint)(0x2100 + this.DestinationAddress + (_count % 2)), TransferData);
                            }
                            else
                            {
                                byte TransferData = Bus.ReadByte(this.SourceAddress.Data);
                                this.SourceAddress.LowerWord.Data += (ushort)(_count % 2);
                                this.Bus.WriteByteRegister((uint)(0x2100 + this.DestinationAddress + (_count % 2)), TransferData);
                            }
                        }
                        else
                        {
                            byte TransferData = Bus.ReadByte(this.SourceAddress.Data);
                            this.Bus.WriteByteRegister((uint)(0x2100 + this.DestinationAddress + (_count % 2)), TransferData);
                        }
                        break;
                    case 0x04:
                        if (!this.FixedCPUMemory)
                        {
                            if (this.DecrementCPUPointer)
                            {
                                byte TransferData = Bus.ReadByte(this.SourceAddress.Data);
                                this.SourceAddress.LowerWord.Data--;
                                this.Bus.WriteByteRegister((uint)(0x2100 + this.DestinationAddress + (_count % 4)), TransferData);
                            }
                            else
                            {
                                byte TransferData = Bus.ReadByte(this.SourceAddress.Data);
                                this.SourceAddress.LowerWord.Data++;
                                this.Bus.WriteByteRegister((uint)(0x2100 + this.DestinationAddress + (_count % 4)), TransferData);
                            }
                        }
                        else
                        {
                            byte TransferData = Bus.ReadByte(this.SourceAddress.Data);
                            this.Bus.WriteByteRegister((uint)(0x2100 + this.DestinationAddress + (_count % 4)), TransferData);
                        }
                        break;
                }

                this._count++;
            }
            else
            {
                this.StopTransfer();
            }
        }
        public void StepHDMA()
        {
            if (this.TransferQueued || !HDMATransferEnabled)
                return;

            if (this._delayCount != 0)
            {
                this._delayCount--;
                return;
            }

            this._delayCount = this.Bus.ReadByte(this._tmpSourceAddress.Data++);

            this._data.Low = this.Bus.ReadByte(this._tmpSourceAddress.Data++);

            if (this.TransferType != 0x00)
                this._data.High = this.Bus.ReadByte(this._tmpSourceAddress.Data++);

            if (_delayCount == 0)
            {
                this.StopHDMATransfer();
                return;
            }

            switch (this.TransferType)
            {
                case 0x00:
                    this.Bus.WriteByteRegister((uint)0x2100 + this.DestinationAddress, this._data.Low);
                    break;
                case 0x01:
                    this.Bus.WriteByteRegister((uint)0x2100 + this.DestinationAddress, this._data.Low);
                    this.Bus.WriteByteRegister((uint)0x2100 + this.DestinationAddress + 1, this._data.High);
                    break;
                case 0x02:
                    this.Bus.WriteByteRegister((uint)0x2100 + this.DestinationAddress, this._data.Low);
                    this.Bus.WriteByteRegister((uint)0x2100 + this.DestinationAddress, this._data.High);
                    break;
            }
        }
    }
}
