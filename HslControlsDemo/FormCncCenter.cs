using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HslControlsDemo
{
    public partial class FormCncCenter : FormContent
    {
        public FormCncCenter( )
        {
            InitializeComponent( );
        }

        private void Button1_Click( object sender, EventArgs e )
        {
            if(float.TryParse(textBox1.Text, out float value ))
            {
                hslCncCenter4.CncDoorState = value;
            }
            else
            {
                MessageBox.Show( "进度输入错误！需要为数值，0-100" );
            }
        }

        private void Button2_Click( object sender, EventArgs e )
        {
            if (float.TryParse( textBox2.Text, out float value ))
            {
                hslCncCenter5.SetDoorState( value );
            }
            else
            {
                MessageBox.Show( "进度输入错误！需要为数值，0-100" );
            }
        }

        private void HslCncCenter1_Click( object sender, EventArgs e )
        {
            Control_Click( sender, e );
        }
    }
}
