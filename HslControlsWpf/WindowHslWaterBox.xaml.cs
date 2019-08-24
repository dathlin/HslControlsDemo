using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HslControlsWpf
{
    /// <summary>
    /// WindowHslWaterBox.xaml 的交互逻辑
    /// </summary>
    public partial class WindowHslWaterBox : Window
    {
        public WindowHslWaterBox( )
        {
            InitializeComponent( );


        }

        protected override void OnSourceInitialized( EventArgs e )
        {
            base.OnSourceInitialized( e );


            random = new Random( );
            timerTick = new Timer( );
            timerTick.Interval = 300;
            timerTick.Tick += TimerTick_Tick;
            timerTick.Start( );
        }

        private void TimerTick_Tick( object sender, EventArgs e )
        {
            hslWaterBox1.WaterValue = random.NextDouble( ) * 100;
            hslWaterBox2.SetWaterValue( random.NextDouble( ) * 100 );
            hslWaterBox3.SetWaterValue( random.NextDouble( ) * 100 );
        }

        private Random random = null;
        private Timer timerTick = null;
    }
}
