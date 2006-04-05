using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Timers;
using System.Runtime.InteropServices;
using System.Drawing;
using Bigwave.Graphx;
using System.Threading;
using SdlDotNet;

namespace Infinity_Project
{
    public class Snes
    {
        private Bus _bus;
        private bool _inEmulation;
        internal FrameBuffer frameBuffer;
        internal ManagedSurface backBuffer;

        public bool InEmulation
        {
            get { return _inEmulation; }
        }

        private HighResolutionTimer Timer = HighResolutionTimer.Instance;

        public Snes()
        {
            backBuffer = new ManagedSurface(256, 224);

            _bus = new Bus(this);
        }

        public void Reset()
        {
            _bus.Reset();
        }

        public void LoadRom(string Rom)
        {
            _bus.LoadRom(Rom);

            frameBuffer = new FrameBuffer(640, 480, true);
        }

        public void StartEmulation()
        {
            this._bus.Enabled = true;

            this._inEmulation = true;
        }

        public void StopEmulation()
        {
            this._bus.Enabled = false;

            this._inEmulation = false;
        }

        public void Events_Tick()
        {
            if (this.InEmulation)
            {
                this._bus.Render();
                this.frameBuffer.StretchBlit2xNearest(this.backBuffer);
                this.frameBuffer.Present();
            }
        }
    }
}
