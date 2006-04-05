using System;
using System.Collections.Generic;
using System.Text;
using Tao.Sdl;

namespace Bigwave.Graphx
{
    public unsafe class ManagedSurface
    {
        public int[] Data;

        public int Width;
        public int Height;

        public ManagedSurface(int Width, int Height)
        {
            this.Width = Width;
            this.Height = Height;

            this.Data = new int[Width * Height];
        }

        public void FastBlitTo(ManagedSurface dest)
        {
            Buffer.BlockCopy(this.Data, 0, dest.Data, 0, this.Height * this.Width * 4);
        }
        internal void FastBlitTo(IntPtr destSurf)
        {
            fixed (int* sourceSurf = this.Data)
            {
                int* source = sourceSurf;

                bool MustLock = Sdl.SDL_MUSTLOCK(destSurf) > 0;

                if (MustLock)
                    Sdl.SDL_LockSurface(destSurf);

                int* dest = (int*)((Sdl.SDL_Surface*)destSurf.ToPointer())->pixels.ToPointer();

                for (int i = 0; i < Width * Height; i++)
                {
                    *dest = *source;

                    source++;
                    dest++;
                }

                if (MustLock)
                    Sdl.SDL_UnlockSurface(destSurf);
            }
        }
        internal void FastBlitTo(Sdl.SDL_Surface* destSurface)
        {
            fixed (int* sourceSurf = this.Data)
            {
                int* source = sourceSurf;
                IntPtr destSurf = new IntPtr(destSurface);

                bool MustLock = Sdl.SDL_MUSTLOCK(destSurf) > 0;

                if (MustLock)
                    Sdl.SDL_LockSurface(destSurf);

                int* dest = (int*)destSurface->pixels;

                for (int i = 0; i < Width * Height; i++)
                {
                    *dest = *source;

                    source++;
                    dest++;
                }

                if (MustLock)
                    Sdl.SDL_UnlockSurface(destSurf);
            }
        }
    }
}
