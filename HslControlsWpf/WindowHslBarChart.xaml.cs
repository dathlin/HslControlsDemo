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
    /// WindowHslBarChart.xaml 的交互逻辑
    /// </summary>
    public partial class WindowHslBarChart : Window
    {
        public WindowHslBarChart( )
        {
            InitializeComponent( );

        }

        protected override void OnSourceInitialized( EventArgs e )
        {
            base.OnSourceInitialized( e );

            hslBarChart2.SetDataSource( new int[] { 1, 2, 4, 0, 3 }, new string[] { "周一", "周二", "周三", "周四", "周五" } );
            hslBarChart3.SetDataSource( new int[] { 1, 2, 4, 0, 3 }, new string[] { "周一", "周二", "周三", "周四", "周五" } );



            hslBarChart4.SetDataSource( new int[] { random.Next( 1500 ), random.Next( 1000 ), random.Next( 600 ), random.Next( 1500 ), random.Next( 800 ) },
                new string[] { "周一", "周二", "周三", "周四", "周五" } );
            hslBarChart4.AddLeftAuxiliary( 300, Colors.Blue );

            hslBarChart5.SetDataSource( new int[] { random.Next( 1500 ), random.Next( 1000 ), random.Next( 600 ), random.Next( 1500 ), random.Next( 800 ) },
                new string[] { "周一", "周二", "周三", "周四", "周五" } );
            hslBarChart5.AddLeftAuxiliary( 300, Colors.Blue, 1f, false );

            hslBarChart6.UseAnimation = true;
            hslBarChart6.SetDataSource( new int[] { random.Next( 1500 ), random.Next( 1000 ), random.Next( 600 ), random.Next( 1500 ), random.Next( 800 ), random.Next( 1500 ), random.Next( 800 ) },
                new string[] { "周一", "周二", "周三", "周四", "周五", "周六", "周日" } );

            List<int> month = new List<int>( );
            List<string> days = new List<string>( );
            for (int i = 0; i < 31; i++)
            {
                month.Add( random.Next( 1500 ) );
                days.Add( (i + 1).ToString( ) );
            }
            // 此处将小于1000的和大于1000的颜色区分开发
            hslBarChart7.SetDataSource( month.ToArray( ), days.ToArray( ), month.Select( m => m < 1000 ? Colors.Orchid : Colors.Gold ).ToArray( ) );
            hslBarChart7.AddLeftAuxiliary( 1000, Colors.Yellow );




            timerTick = new Timer( );
            timerTick.Interval = 2000;
            timerTick.Tick += TimerTick_Tick;
            timerTick.Start( );
        }
        private void TimerTick_Tick( object sender, EventArgs e )
        {
            hslBarChart4.SetDataSource( new int[] { random.Next( 1500 ), random.Next( 1000 ), random.Next( 600 ), random.Next( 1500 ), random.Next( 800 ) },
                new string[] { "周一", "周二", "周三", "周四", "周五" } );
            hslBarChart6.SetDataSource( new int[] { random.Next( 1500 ), random.Next( 1000 ), random.Next( 600 ), random.Next( 1500 ), random.Next( 800 ), random.Next( 1500 ), random.Next( 800 ) },
                new string[] { "周一", "周二", "周三", "周四", "周五", "周六", "周日" } );
        }

        private Random random = new Random( );
        private Timer timerTick = null;

        private void HslBarChart5_MouseDoubleClick( object sender, MouseButtonEventArgs e )
        {
            hslBarChart5.SetDataSource( new int[] { random.Next( 1500 ), random.Next( 1000 ), random.Next( 600 ), random.Next( 1500 ), random.Next( 800 ) },
                new string[] { "周一", "周二", "周三", "周四", "周五" } );
        }

        private void HslBarChart7_MouseDown( object sender, MouseButtonEventArgs e )
        {
            List<int> month = new List<int>( );
            List<string> days = new List<string>( );
            for (int i = 0; i < 31; i++)
            {
                month.Add( random.Next( 1500 ) );
                days.Add( (i + 1).ToString( ) );
            }
            // 此处将小于1000的和大于1000的颜色区分开发
            hslBarChart7.SetDataSource( month.ToArray( ), days.ToArray( ), month.Select( m => m < 1000 ? Colors.Orchid : Colors.Gold ).ToArray( ) );
        }

		private void CheckBox_Checked( object sender, RoutedEventArgs e )
		{
            if(sender is System.Windows.Controls.CheckBox checkBox)
            {
                hslBarChart7.UseAnimation = checkBox.IsChecked.Value;

            }
		}
	}
}
