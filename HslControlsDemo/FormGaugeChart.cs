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
    public partial class FormGaugeChart : Form
    {
        public FormGaugeChart( )
        {
            InitializeComponent( );
        }

        private void FormGaugeChart_Load( object sender, EventArgs e )
        {
            random = new Random( );
            timer = new Timer( );
            timer.Interval = 500;
            timer.Tick += Timer_Tick;
            timer.Start( );
        }

        private void Timer_Tick( object sender, EventArgs e )
        {
            hslGaugeChart4.Value = Math.Round( random.NextDouble( ), 2 ) * 8;
            hslGaugeChart6.Value = Math.Round( random.NextDouble( ), 4 ) * 100;
            hslGaugeChart7.Value = Math.Round( random.NextDouble( ), 4 ) * 100;
        }

        private Timer timer;
        private Random random;
    }
}
