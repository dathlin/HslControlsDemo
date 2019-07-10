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
    /// WindowHslBottle.xaml 的交互逻辑
    /// </summary>
    public partial class WindowHslBottle : Window
    {
        public WindowHslBottle( )
        {
            InitializeComponent( );

            random = new Random( );
            timer1 = new Timer( );
            timer1.Interval = 500;
            timer1.Tick += Timer1_Tick;
            timer1.Start( );
        }

        private void Timer1_Tick( object sender, EventArgs e )
        {
            hslBottle1.Value = random.NextDouble( ) * 100;
            hslBottle2.Value = random.NextDouble( ) * 100;
            hslBottle3.Value = random.NextDouble( ) * 100;
            hslBottle4.Value = random.NextDouble( ) * 100;
            hslBottle5.Value = random.NextDouble( ) * 100;
            hslBottle6.Value = random.NextDouble( ) * 100;
            hslBottle7.Value = random.NextDouble( ) * 100;
        }

        private Timer timer1;
        private Random random;
    }
}
