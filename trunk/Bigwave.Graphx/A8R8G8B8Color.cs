using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace Bigwave.Graphx
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct A8R8G8B8Color
    {
        [FieldOffset(0)]
        public fixed byte data[4];

        [FieldOffset(0)]
        public uint ucolor;

        [FieldOffset(0)]
        public int color;

        public void Add(A8R8G8B8Color* c1)
        {
            int temp;

            for (int i = 0; i < 4; i++)
            {
                fixed (byte* data = this.data)
                {
                    temp = data[i] + c1->data[i];

                    data[i] = temp > 255 ? (byte)255 : (byte)temp;
                }
            }
        }
        public void Substract(A8R8G8B8Color* c1)
        {
            int temp;

            for (int i = 0; i < 4; i++)
            {
                fixed (byte* data = this.data)
                {
                    temp = data[i] - c1->data[i];

                    data[i] = temp > 255 ? (byte)255 : (byte)temp;
                }
            }
        }
        public void Multiply(A8R8G8B8Color* c1)
        {
            int temp;

            for (int i = 0; i < 4; i++)
            {
                fixed (byte* data = this.data)
                {
                    temp = data[i] * c1->data[i];

                    data[i] = temp > 255 ? (byte)255 : (byte)temp;
                }
            }
        }
        public void Inverse()
        {
            for (int i = 0; i < 4; i++)
            {
                fixed (byte* data = this.data)
                    data[i] = (byte)(255 - data[i]);
            }
        }

        public static int Add(A8R8G8B8Color* c1, A8R8G8B8Color* c2)
        {
            int temp;

            A8R8G8B8Color ret = new A8R8G8B8Color();

            for (int i = 0; i < 4; i++)
            {
                temp = c2->data[i] + c1->data[i];

                ret.data[i] = temp > 255 ? (byte)255 : (byte)temp;
            }

            return ret.color;
        }
        public static int Substract(A8R8G8B8Color* c1, A8R8G8B8Color* c2)
        {
            int temp;

            A8R8G8B8Color ret = new A8R8G8B8Color();

            for (int i = 0; i < 4; i++)
            {
                temp = c2->data[i] - c1->data[i];

                ret.data[i] = temp > 255 ? (byte)255 : (byte)temp;
            }

            return ret.color;
        }
        public static int Multiply(A8R8G8B8Color* c1, A8R8G8B8Color* c2)
        {
            int temp;

            A8R8G8B8Color ret = new A8R8G8B8Color();

            for (int i = 0; i < 4; i++)
            {
                temp = c2->data[i] * c1->data[i];

                ret.data[i] = temp > 255 ? (byte)255 : (byte)temp;
            }

            return ret.color;
        }
        public static int Inverse(A8R8G8B8Color* c1)
        {
            A8R8G8B8Color ret = new A8R8G8B8Color();

            for (int i = 0; i < 4; i++)
            {
                ret.data[i] = (byte)(255 - c1->data[i]);
            }

            return ret.color;
        }

        public static int Add(A8R8G8B8Color c1, A8R8G8B8Color c2)
        {
            int temp;

            A8R8G8B8Color ret = new A8R8G8B8Color();

            for (int i = 0; i < 4; i++)
            {
                temp = c2.data[i] + c1.data[i];

                ret.data[i] = temp > 255 ? (byte)255 : (byte)temp;
            }

            return ret.color;
        }
        public static int Substract(A8R8G8B8Color c1, A8R8G8B8Color c2)
        {
            int temp;

            A8R8G8B8Color ret = new A8R8G8B8Color();

            for (int i = 0; i < 4; i++)
            {
                temp = c2.data[i] - c1.data[i];

                ret.data[i] = temp > 255 ? (byte)255 : (byte)temp;
            }

            return ret.color;
        }
        public static int Multiply(A8R8G8B8Color c1, A8R8G8B8Color c2)
        {
            int temp;

            A8R8G8B8Color ret = new A8R8G8B8Color();

            for (int i = 0; i < 4; i++)
            {
                temp = c2.data[i] * c1.data[i];

                ret.data[i] = temp > 255 ? (byte)255 : (byte)temp;
            }

            return ret.color;
        }
        public static int Inverse(A8R8G8B8Color c1)
        {
            A8R8G8B8Color ret = new A8R8G8B8Color();

            for (int i = 0; i < 4; i++)
            {
                ret.data[i] = (byte)(255 - c1.data[i]);
            }

            return ret.color;
        }
    }
}
