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
    public partial class FormConveryer : FormContent
    {
        public FormConveryer( )
        {
            InitializeComponent( );
        }

        private void button1_Click( object sender, EventArgs e )
        {
            // 停止
            hslConveyer4.MoveSpeed = 0;
            hslConveyer5.MoveSpeed = 0;
            hslConveyer6.MoveSpeed = 0;
        }

        private void button2_Click( object sender, EventArgs e )
        {
            // 正转
            hslConveyer4.MoveSpeed = 1;
            hslConveyer5.MoveSpeed = 1;
            hslConveyer6.MoveSpeed = 1;
        }

        private void button3_Click( object sender, EventArgs e )
        {
            // 反转
            hslConveyer4.MoveSpeed = -1;
            hslConveyer5.MoveSpeed = -1;
            hslConveyer6.MoveSpeed = -1;
        }

        private void HslConveyer8_Click( object sender, EventArgs e )
        {
            Control_Click( sender, e );
        }
    }
}
