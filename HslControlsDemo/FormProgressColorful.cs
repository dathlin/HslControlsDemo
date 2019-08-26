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
    public partial class FormProgressColorful : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public FormProgressColorful( )
        {
            InitializeComponent( );
        }

        private void FormProgress_Load( object sender, EventArgs e )
        {
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start( );
        }

        private void Timer_Tick( object sender, EventArgs e )
        {
            hslProgressColorful3.Value = random.Next( 101 );
            hslProgressColorful4.Value = random.Next( 101 );
            hslProgressColorful5.Value = random.Next( 101 );
            hslProgressColorful6.Value = random.Next( 101 );

            hslProgressColorful11.Value = random.Next( 101 );
            hslProgressColorful12.Value = random.Next( 101 );
            hslProgressColorful13.Value = random.Next( 101 );
            hslProgressColorful14.Value = random.Next( 101 );
        }

        private Timer timer = new Timer( );
        private Random random = new Random( );
    }
}
