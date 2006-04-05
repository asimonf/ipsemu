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
            //this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.Opaque, true);

            InitializeComponent();

            this.snes1 = new Snes();
            this.openFileDialog1.Title = "Abrir ROM";
        }

        private void abrirRomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog(this);
        }

        private void App_Load(object sender, EventArgs e)
        {
            //this.timer1.Enabled = true;
            SdlDotNet.Events.Fps = 60;
            SdlDotNet.Events.Tick += new SdlDotNet.TickEventHandler(Events_Tick);
            Thread thread = new Thread(new ThreadStart(SdlDotNet.Events.Run));
            thread.IsBackground = true;
            thread.Name = "SDL";
            thread.Priority = ThreadPriority.Normal;
            thread.Start();
        }

        void Events_Tick(object sender, SdlDotNet.TickEventArgs e)
        {
            this.snes1.Events_Tick();
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