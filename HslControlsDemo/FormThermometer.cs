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
    public partial class FormThermometer : FormContent
    {
        public FormThermometer( )
        {
            InitializeComponent( );
        }

        private void button1_Click( object sender, EventArgs e )
        {
            if(float.TryParse(textBox1.Text, out float tmp ))
            {
                hslThermometer1.Value = tmp;
            }
            else
            {
                MessageBox.Show( "数值输入错误" );
            }
        }

        private void FormThermometer_Load( object sender, EventArgs e )
        {
            timer = new Timer( );
            timer.Tick += Timer_Tick;
            timer.Interval = 1000;
            timer.Start( );

            hslThermometer6.RightDataTransfer = m => m;
        }

        private void Timer_Tick( object sender, EventArgs e )
        {
            hslThermometer4.Value = random.Next( -20, 61 );
            hslThermometer5.Value = random.Next( -20, 61 );
        }

        private Timer timer;
        private Random random = new Random( );

        private void HslThermometer1_Click( object sender, EventArgs e )
        {
            Control_Click( sender, e );
        }
    }
}
