using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Infinity_Project
{
    public partial class App : Form
    {
        public App()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.Opaque, true);

            InitializeComponent();

            this.openFileDialog1.Title = "Abrir ROM";
        }

        private void abrirRomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog(this);
        }

        private void App_Load(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
            //Thread thread = new Thread(new ThreadStart(SdlDotNet.Events.Run));
            //thread.IsBackground = true;
            //thread.Name = "SDL";
            //thread.Priority = ThreadPriority.Normal;
            //thread.Start();
        }

        private void openFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {
            if (e.Cancel)
                return;

            this.snes1.LoadRom(openFileDialog1.FileName);
            this.snes1.Reset();
            this.snes1.StartEmulation();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Invalidate(true);
        }
    }
}