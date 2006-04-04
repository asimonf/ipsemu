using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace Infinity_Project
{
    public class AudioProcessingUnit
    {
        [StructLayout(LayoutKind.Explicit)]
        struct Registers
        {
            [FieldOffset(0)]
            public byte Accumulator;

            [FieldOffset(0)]
            public ushort PairedAccY;

            [FieldOffset(1)]
            public byte Y;

            [FieldOffset(2)]
            public byte X;

            [FieldOffset(3)]
            public ushort StackPointer;

            [FieldOffset(3)]
            public byte SPLow;

            [FieldOffset(4)]
            public byte SPHigh;

            [FieldOffset(5)]
            public byte ProgramStatusWord;

            [FieldOffset(6)]
            public short ProgramCounter;

            [FieldOffset(6)]
            public byte PCLow;

            [FieldOffset(7)]
            public byte PCHigh;
        }

        private Bus _bus;
        private AudioProcessingUnit.Registers _regs;

        public AudioProcessingUnit(Bus _bus)
        {
            this._bus = _bus;
        }

        public void Reset()
        {
            
        }

        public int Step(int masterCycles)
        {
            return 0;
        }
    }
}
