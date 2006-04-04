using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Timers;
using System.Runtime.InteropServices;
using System.Drawing;

namespace Infinity_Project
{
    public class Snes : UserControl
    {
        private Bus _bus;
        private bool _inEmulation;
        internal Bitmap frameBuffer;

        public bool InEmulation
        {
            get { return _inEmulation; }
        }

        private HighResolutionTimer Timer = HighResolutionTimer.Instance;

        public Snes()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.Opaque, true);
            this.ClientSize = new System.Drawing.Size(256, 224);
            this.frameBuffer = new Bitmap(256, 224, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
            //this.BackgroundImage = frameBuffer;

            _bus = new Bus(this);
        }

        public void Reset()
        {
            _bus.Reset();
        }

        public void LoadRom(string Rom)
        {
            _bus.LoadRom(Rom);
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
    }
}
