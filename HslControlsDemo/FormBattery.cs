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
    public partial class FormBattery : FormContent
    {
        public FormBattery( )
        {
            InitializeComponent( );
        }

        private void FormBattery_Load( object sender, EventArgs e )
        {
            random = new Random( );
            timer = new Timer( );
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start( );
        }

        private void Timer_Tick( object sender, EventArgs e )
        {
            hslBattery6.Value = random.Next( 100 );
            hslBattery8.Value = (float)random.NextDouble( ) * 5;
            hslBattery9.Value = (float)random.NextDouble( ) * 5;
            hslBattery10.Value = random.Next( 5000 );
        }

        private Timer timer;
        private Random random;

        private void HslBattery7_Click( object sender, EventArgs e )
        {
            Control_Click( sender, e );
        }
    }
}
