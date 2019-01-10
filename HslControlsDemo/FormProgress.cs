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
    public partial class FormProgress : Form
    {
        public FormProgress( )
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
            hslProgress5.Value = random.Next( 101 );
            hslProgress6.Value = random.Next( 101 );

            hslProgressLine4.Value = random.Next( 101 );
            hslProgressLine5.Value = random.Next( 101 );

            hslProgress10.Value = random.Next( 101 );
            hslProgress11.Value = random.Next( 101 );

            hslProgressLine9.Value = random.Next( 101 );
            hslProgressLine10.Value = random.Next( 101 );
            
            hslProgressLine13.Value = random.Next(101);
        }

        private Timer timer = new Timer( );
        private Random random = new Random( );
    }
}
