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
    public partial class FormPumpOne : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public FormPumpOne( )
        {
            InitializeComponent( );
        }

        private void Button1_Click( object sender, EventArgs e )
        {
            hslPumpOne7.MoveSpeed = 1f;
            hslPipeLine1.MoveSpeed = 1f;
            hslPipeLine2.MoveSpeed = 1f;
        }

        private void Button2_Click( object sender, EventArgs e )
        {
            hslPumpOne7.MoveSpeed = 0f;
            hslPipeLine1.MoveSpeed = 0f;
            hslPipeLine2.MoveSpeed = 0f;
        }
    }
}
