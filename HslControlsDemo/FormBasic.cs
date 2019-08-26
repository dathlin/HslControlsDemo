using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HslControlsDemo
{
    public partial class FormBasic : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public FormBasic( )
        {
            InitializeComponent( );
        }

        private void hslPlay1_OnPlayChanged( object arg1, bool arg2 )
        {
            label1.Text = "状态：" + arg2;
        }

        private void hslSwitch1_OnSwitchChanged( object arg1, bool arg2 )
        {
            label2.Text = "状态：" + arg2;
        }
    }
}
