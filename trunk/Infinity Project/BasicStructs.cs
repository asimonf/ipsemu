using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace Infinity_Project
{
    [StructLayout(LayoutKind.Explicit)]
    public struct Word
    {
		// Atributos
        [FieldOffset(0)]
        public byte Low;

        [FieldOffset(0)]
        public ushort Data;

        [FieldOffset(1)]
        public byte High;

        public Word(byte Low, byte High)
        {
            this.Data = 0;
            this.Low = Low;
            this.High = High;
        }
    }

    [StructLayout(LayoutKind.Explicit)]
	public struct DWord
    {
		// Atributos
        [FieldOffset(0)]
        public Word LowerWord;

        [FieldOffset(2)]
        public Word HigherWord;

        [FieldOffset(0)]
        public uint Data;
    }

    [StructLayout(LayoutKind.Explicit)]
	public struct LWord
    {
		// Atributos
        [FieldOffset(0)]
        public Word LowerWord;

        [FieldOffset(2)]
        public byte HigherByte;

        [FieldOffset(0)]
        public uint Data;
    }
}
