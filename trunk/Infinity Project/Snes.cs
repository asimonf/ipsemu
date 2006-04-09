using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Timers;
using System.Runtime.InteropServices;
using System.Drawing;
using Bigwave.Graphx;
using System.Threading;
using System.Reflection;
using System.IO;

namespace Infinity_Project
{
    public class Snes
    {
        private Bus _bus;
        private bool _inEmulation;

        public bool InEmulation
        {
            get { return _inEmulation; }
        }

        private HighResolutionTimer Timer = HighResolutionTimer.Instance;
        private IFramebuffer _frameBuffer;

        public Snes(Control owner)
        {
            if (File.Exists("D3D Plugin.dll"))
            {

                Assembly a = Assembly.LoadFile(Path.Combine(Environment.CurrentDirectory, "D3D Plugin.dll"));
                _frameBuffer = a.CreateInstance("D3D_Plugin.D3DFramebuffer", false, BindingFlags.CreateInstance, null, new object[] { owner }, null, null) as IFramebuffer;
                _bus = new Bus(this, _frameBuffer);

                owner.Paint += new PaintEventHandler(DeviceWindow_Paint);
            }
            else
                throw new Exception();
        }

        void DeviceWindow_Paint(object sender, PaintEventArgs e)
        {
            if (this._inEmulation)
            {
                this._bus.Run();
                Timer.Set();
            }

            _frameBuffer.Render();
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
