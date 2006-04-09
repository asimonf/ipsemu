using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Infinity_Project
{
    public partial class App: Form
    {
        private Snes snes1;

        public App()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.Opaque, true);

            InitializeComponent();

            this.openFileDialog1.Title = "Abrir ROM";

            this.snes1 = new Snes(this);
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
            Application.Exit();
        }
    }
}