using System;
using System.Collections.Generic;
using System.Text;

namespace Infinity_Project
{
    public partial class AudioProcessingUnit
    {
        private void CheckZeroFlag(byte b)
        {
            if (b > 0) this._regs.ProgramStatusWord &= 0xFD;
            else this._regs.ProgramStatusWord |= 0x02;
        }
        private void CheckZeroFlag(ushort b)
        {
            if (b > 0) this._regs.ProgramStatusWord &= 0xFD;
            else this._regs.ProgramStatusWord |= 0x02;
        }
        private void CheckNegativeFlag(byte b)
        {
            if ((b & 0x80) > 0) this._regs.ProgramStatusWord |= 0x80;
            else this._regs.ProgramStatusWord &= 0x7F;
        }
        private void CheckHCFlags(ushort Sum)
        {
            if ((Sum & 0x100) > 0) _regs.ProgramStatusWord |= 0x01;
            else _regs.ProgramStatusWord &= 0xFE;

            if ((Sum & 0x10) > 0) _regs.ProgramStatusWord |= 0x10;
            else _regs.ProgramStatusWord &= 0xEF;
        }
        private void ClearOverflowFlag()
        {
            _regs.ProgramStatusWord &= 0x7F;
        }
        private void SetOverflowFlag()
        {
            _regs.ProgramStatusWord |= 0x40;
        }
        private void ClearCarryFlag()
        {
            _regs.ProgramStatusWord &= 0xFE;
        }        
        private void SetCarryFlag()
        {
            _regs.ProgramStatusWord |= 0x01;
        }
        private void ClearZeroFlag()
        {
            _regs.ProgramStatusWord &= 0xFD;
        }
        private void SetZeroFlag()
        {
            _regs.ProgramStatusWord |= 0x02;
        }
        private void ClearNegativeFlag()
        {
            _regs.ProgramStatusWord &= 0x7F;
        }
        private void SetNegativeFlag()
        {
            _regs.ProgramStatusWord |= 0x80;
        }
        
        private void AccumulatorMOV(ushort OperandAddress)
        {
            this._regs.Accumulator = _bus.ReadByteAPU(OperandAddress);

            CheckNegativeFlag(this._regs.Accumulator);
            CheckZeroFlag(this._regs.Accumulator);
        }
        private void XMOV(ushort OperandAddress)
        {
            this._regs.X = _bus.ReadByteAPU(OperandAddress);

            CheckNegativeFlag(this._regs.X);
            CheckZeroFlag(this._regs.X);
        }
        private void YMOV(ushort OperandAddress)
        {
            this._regs.Y = _bus.ReadByteAPU(OperandAddress);

            CheckNegativeFlag(this._regs.Y);
            CheckZeroFlag(this._regs.Y);
        }

        private void MOVAccumulator(ushort OperandAddress)
        {
            _bus.WriteByteAPU(OperandAddress, this._regs.Accumulator);
        }
        private void MOVX(ushort OperandAddress)
        {
            _bus.WriteByteAPU(OperandAddress, this._regs.X);
        }
        private void MOVY(ushort OperandAddress)
        {
            _bus.WriteByteAPU(OperandAddress, this._regs.Y);
        }

        private void ADC(ushort OperandAddress)
        {

            byte Operand = (byte)(_bus.ReadByteAPU(OperandAddress) + (_regs.ProgramStatusWord & 0x01));
            ushort Sum = (ushort)(_regs.Accumulator + Operand);

            if ((~(_regs.Accumulator ^ Operand) & (Operand ^ Sum) & 0x80) > 0) SetOverflowFlag();
            else ClearOverflowFlag();

            _regs.Accumulator = (byte)Sum;

            CheckNegativeFlag(_regs.Accumulator);
            CheckZeroFlag(_regs.Accumulator);
            CheckHCFlags(Sum);
        }
        private void SBC(ushort OperandAddress)
        {

            byte Operand = (byte)(_bus.ReadByteAPU(OperandAddress) + (~_regs.ProgramStatusWord & 0x01));
            ushort Sum = (ushort)(_regs.Accumulator - Operand);

            if ((~(_regs.Accumulator ^ Operand) & (Operand ^ Sum) & 0x80) > 0) SetOverflowFlag();
            else ClearOverflowFlag();

            _regs.Accumulator = (byte)Sum;

            CheckNegativeFlag(_regs.Accumulator);
            CheckZeroFlag(_regs.Accumulator);
            CheckHCFlags(Sum);
        }

        private void CMP(ushort OperandAddress1, ushort OperandAddress2)
        {
            sbyte Operand1 = (sbyte)_bus.ReadByteAPU(OperandAddress1);
            sbyte Operand2 = (sbyte)_bus.ReadByteAPU(OperandAddress2);

            if (Operand1 > Operand2)
            {
                SetNegativeFlag();
                ClearCarryFlag();
                ClearZeroFlag();
            }
            else if (Operand1 < Operand2)
            {
                ClearNegativeFlag();
                SetCarryFlag();
                ClearZeroFlag();
            }
            else
            {
                ClearNegativeFlag();
                SetZeroFlag();
                SetCarryFlag();
            }
        }
        private void CMPA(ushort OperandAddress)
        {
            sbyte Operand = (sbyte)_bus.ReadByteAPU(OperandAddress);

            if (Operand > (sbyte)_regs.Accumulator)
            {
                SetNegativeFlag();
                ClearCarryFlag();
                ClearZeroFlag();
            }
            else if (Operand < (sbyte)_regs.Accumulator)
            {
                ClearNegativeFlag();
                SetCarryFlag();
                ClearZeroFlag();
            }
            else
            {
                ClearNegativeFlag();
                SetZeroFlag();
                SetCarryFlag();
            }
        }
        private void CMPX(ushort OperandAddress)
        {
            sbyte Operand = (sbyte)_bus.ReadByteAPU(OperandAddress);

            if (Operand > (sbyte)_regs.X)
            {
                SetNegativeFlag();
                ClearCarryFlag();
                ClearZeroFlag();
            }
            else if (Operand < (sbyte)_regs.X)
            {
                ClearNegativeFlag();
                SetCarryFlag();
                ClearZeroFlag();
            }
            else
            {
                ClearNegativeFlag();
                SetZeroFlag();
                SetCarryFlag();
            }
        }
        private void CMPY(ushort OperandAddress)
        {
            sbyte Operand = (sbyte)_bus.ReadByteAPU(OperandAddress);

            if (Operand > (sbyte)_regs.Y)
            {
                SetNegativeFlag();
                ClearCarryFlag();
                ClearZeroFlag();
            }
            else if (Operand < (sbyte)_regs.Y)
            {
                ClearNegativeFlag();
                SetCarryFlag();
                ClearZeroFlag();
            }
            else
            {
                ClearNegativeFlag();
                SetZeroFlag();
                SetCarryFlag();
            }
        }

        private void AND(ushort OperandAddress)
        {
            byte Operand = _bus.ReadByteAPU(OperandAddress);

            _regs.Accumulator &= Operand;

            CheckZeroFlag(_regs.Accumulator);
            CheckNegativeFlag(_regs.Accumulator);
        }
        private void OR(ushort OperandAddress)
        {
            byte Operand = _bus.ReadByteAPU(OperandAddress);

            _regs.Accumulator |= Operand;

            CheckZeroFlag(_regs.Accumulator);
            CheckNegativeFlag(_regs.Accumulator);
        }
        private void EOR(ushort OperandAddress)
        {
            byte Operand = _bus.ReadByteAPU(OperandAddress);

            _regs.Accumulator ^= Operand;

            CheckZeroFlag(_regs.Accumulator);
            CheckNegativeFlag(_regs.Accumulator);
        }
    }
}
