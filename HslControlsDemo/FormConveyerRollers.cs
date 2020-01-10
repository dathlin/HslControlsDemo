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
    public partial class FormConveyerRollers : FormContent
    {
        public FormConveyerRollers( )
        {
            InitializeComponent( );
        }

        private void button1_Click( object sender, EventArgs e )
        {
            if(float.TryParse(textBox1.Text, out float speed ))
            {
                hslConveyerRollers8.MoveSpeed = speed;
                hslConveyerRollers9.MoveSpeed = speed;
                hslConveyerRollers10.MoveSpeed = speed;
            }
            else
            {
                MessageBox.Show( "您输入的数据不正确！" );
            }
        }

        private void HslConveyerRollers1_Click( object sender, EventArgs e )
        {
            Control_Click( sender, e );
        }
    }
}
