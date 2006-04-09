using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Infinity_Project
{
    public interface IFramebuffer
    {
        void ShowConfigurationDialog(Control Owner);
        void LoadConfigurationData();

        void Initialize();

        IntPtr Lock();
        void Unlock();

        void Render();
        void Idle();
    }
}
