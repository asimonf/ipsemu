using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Microsoft.DirectX.Direct3D;

namespace Infinity_Project
{
    public partial class App: Form
    {
        private Snes snes1;

        private Device dev;

        public App()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.Opaque, true);

            InitializeComponent();

            this.openFileDialog1.Title = "Abrir ROM";

            this.timer2.Tick += new EventHandler(timer2_Tick);

            this.ClientSize = new Size(640, 480);

            PresentParameters param = new PresentParameters();
            param.Windowed = true;
            param.SwapEffect = SwapEffect.Discard;
            param.DeviceWindow = this;
            
            this.dev = new Device(0, DeviceType.Hardware, this, CreateFlags.SoftwareVertexProcessing, param);
            this.snes1 = new Snes(dev);
        }

        void timer2_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
                this.Opacity -= 0.05;
            else
                this.timer2.Stop();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            //this.timer1.Stop();

            //if (run != null)
            //    if (run.IsAlive)
            //        run.Abort();

            //this.timer2.Interval = 10;
            //this.timer2.Start();
            //this.snes1.Dispose();

            //while (timer2.Enabled)
            //    Application.DoEvents();

            base.OnClosing(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            this.Invalidate();
        }

        private void abrirRomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog(this);
        }

        private void App_Load(object sender, EventArgs e)
        {
            this.SetDesktopLocation((Screen.PrimaryScreen.Bounds.Width / 2) - (this.Width / 2), (Screen.PrimaryScreen.Bounds.Height / 2) - (this.Height / 2));

            //this.timer1.Interval = 10;
            //this.timer1.Start();
            //SdlDotNet.Events.Fps = 60;
            //SdlDotNet.Events.Tick += new SdlDotNet.TickEventHandler(Events_Tick);
            //Thread thread = new Thread(new ThreadStart(SdlDotNet.Events.Run));
            //thread.IsBackground = true;
            //thread.Name = "SDL";
            //thread.Priority = ThreadPriority.Normal;
            //thread.Start();
            //this.run = thread;
        }

        private void openFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {
            if (e.Cancel)
                return;

            this.snes1.LoadRom(openFileDialog1.FileName);
            this.snes1.Reset();
            this.snes1.StartEmulation();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
                this.Opacity += 0.007;
            else
                this.timer1.Stop();
        }
    }
}