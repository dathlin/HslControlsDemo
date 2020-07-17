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
    /// WindowHslBattery.xaml 的交互逻辑
    /// </summary>
    public partial class WindowHslBattery : Window
    {
        public WindowHslBattery( )
        {
            InitializeComponent( );

            random = new Random( );

            timerTick = new Timer( );
            timerTick.Interval = 500;
            timerTick.Tick += TimerTick_Tick;
            timerTick.Start( );

        }
        private void TimerTick_Tick( object sender, EventArgs e )
        {
            float newValue = random.Next( 500 ) / 100f;
            hslBattery1.Value = newValue;
            hslBattery2.SetValueByAnimation( newValue, 200 );
            hslBattery3.SetValueByAnimation( random.Next( 5000 ), 200 );
        }

        private Random random = null;
        private Timer timerTick = null;
    }
}
