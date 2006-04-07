using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Timers;
using System.Runtime.InteropServices;
using System.Drawing;
using Bigwave.Graphx;
using System.Threading;
using Microsoft.DirectX.Direct3D;

namespace Infinity_Project
{
    public class Snes : IDisposable
    {
        private Bus _bus;
        private bool _inEmulation;

        public bool InEmulation
        {
            get { return _inEmulation; }
        }

        private HighResolutionTimer Timer = HighResolutionTimer.Instance;

        public Snes(Device dev)
        {
            _bus = new Bus(this, dev);

            dev.PresentationParameters.DeviceWindow.Paint += new PaintEventHandler(DeviceWindow_Paint);
        }

        void DeviceWindow_Paint(object sender, PaintEventArgs e)
        {
            if (this._inEmulation)
            {
                this._bus.Run();
                Timer.Set();
            }
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
            this.Timer.Reset();
        }

        public void StopEmulation()
        {
            this._bus.Enabled = false;

            this._inEmulation = false;
        }

        #region Miembros de IDisposable

        public void Dispose()
        {
            
        }

        #endregion
    }
}
