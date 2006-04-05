using System;
using System.Collections.Generic;
using System.Text;
using Tao.Sdl;

namespace Bigwave.Graphx
{
    public unsafe class FrameBuffer
    {
        private IntPtr _frameBuffer;
        private int _width, _height, _pitch, _offset;
        private bool _windowed;

        static FrameBuffer()
        {
            Sdl.SDL_Init(Sdl.SDL_INIT_VIDEO);
        }

        static void Application_ApplicationExit(object sender, EventArgs e)
        {
            //Sdl.SDL_Quit();
        }

        public FrameBuffer(int width, int height, bool windowed)
        {
            this._windowed = windowed;
            this._height = height;
            this._width = width;

            if (windowed)
                this._frameBuffer = Sdl.SDL_SetVideoMode(width, height, 32, Sdl.SDL_SWSURFACE | Sdl.SDL_DOUBLEBUF);
            else
                this._frameBuffer = Sdl.SDL_SetVideoMode(width, height, 32, Sdl.SDL_HWSURFACE | Sdl.SDL_FULLSCREEN | Sdl.SDL_DOUBLEBUF);
            
            this._pitch = (((Sdl.SDL_Surface*)this._frameBuffer.ToPointer())->pitch) >> 2;
            this._offset = (((Sdl.SDL_Surface*)this._frameBuffer.ToPointer())->offset) >> 2;
        }

        /// <summary>
        /// Performs a blit from the source surface.
        /// Assumes this surface to have the same size as the suplied surface
        /// </summary>
        /// <param name="surf"></param>
        public void Blit(ManagedSurface surf)
        {
            surf.FastBlitTo(this._frameBuffer);
        }

        /// <summary>
        /// Performs stretched blit with nearest neighbour 2x.
        /// Assumes this surface to be at least twice as large as the suplied surface.
        /// If it is larger than 2x the source surface, then it is centered.
        /// </summary>
        /// <param name="surf">Surface to be transfered here</param>
        public void StretchBlit2xNearest(ManagedSurface surf)
        {
            fixed (int* source = surf.Data)
            {
                bool MustLock = Sdl.SDL_MUSTLOCK(this._frameBuffer) > 0;

                if (MustLock)
                    Sdl.SDL_LockSurface(this._frameBuffer);

                int* fb = (int*)((Sdl.SDL_Surface*)this._frameBuffer.ToPointer())->pixels.ToPointer();

                int initialOffset = (_pitch * ((this._height - (surf.Height << 1)) >> 1)) + ((_pitch - (surf.Width << 1)) >> 1) + _offset;
                fb += initialOffset;

                for (int i = 0; i < (surf.Height << 1); i++)
                {
                    for (int j = 0; j < (surf.Width << 1); j++)
                    {
                        *fb = source[(j >> 1) + (surf.Width * (i >> 1))];
                        fb++;
                    }

                    fb += (_pitch - (surf.Width << 1));
                }

                if (MustLock)
                    Sdl.SDL_UnlockSurface(this._frameBuffer);
            }
        }

        public void Present()
        {
            if (this._windowed)
                Sdl.SDL_UpdateRect(_frameBuffer, 0, 0, this._width, this._height);
            else
                Sdl.SDL_Flip(_frameBuffer);
        }
    }
}
