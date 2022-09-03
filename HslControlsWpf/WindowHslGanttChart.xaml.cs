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
    /// WindowHslGanttChart.xaml 的交互逻辑
    /// </summary>
    public partial class WindowHslGanttChart : Window
    {
        public WindowHslGanttChart( )
        {
            InitializeComponent( );
        }



        private List<int> data_my = new List<int>( ) { 1000 };
        private List<Color> colors_my = new List<Color>( ) { Colors.DodgerBlue };

        private Timer timer;
        private Random random = new Random( );

		private void Canvas_Initialized( object sender, EventArgs e )
		{
            // 图1默认为秒，共计86400秒，图3按照天的，设置为了31天
            hslGanttChart1.SetGanttChart( new int[] { 15000, 10000, 7800, 42000 }, new Color[] { Colors.Tomato, Colors.DodgerBlue, Colors.LimeGreen, Colors.DodgerBlue } );
            hslGanttChart2.SetGanttChart( new int[] { 1, 5, 10, 7, 8 }, new Color[] { Colors.DodgerBlue, Colors.Tomato, Colors.DimGray, Colors.Chocolate, Colors.Orchid } );

            timer = new Timer( );
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start( );
        }


        private void Timer_Tick( object sender, EventArgs e )
        {
            // 更新hslGanttChart5, 随机的创建数据
            int[] data = new int[10] { 8640, 8640, 8640, 8640, 8640, 8640, 8640, 8640, 8640, 8640 };
            Color[] colors = new Color[] { Colors.DodgerBlue, Colors.Tomato, Colors.DimGray, Colors.Orange };
            Color[] colors_random = new Color[10]{colors[random.Next( 4 )], colors[random.Next( 4 )], colors[random.Next( 4 )], colors[random.Next( 4 )], colors[random.Next( 4 )], colors[random.Next( 4 )],
                colors[random.Next( 4 )], colors[random.Next( 4 )] ,colors[random.Next( 4 )], colors[random.Next( 4 )]};
            hslGanttChart3.SetGanttChart( data, colors_random );


            // 更新hslGanttChart6, 随机的创建数据
            if (random.Next( 100 ) < 60)
            {
                data_my[data_my.Count - 1] += 1000;
            }
            else
            {
                data_my.Add( 1000 );
                colors_my.Add( colors[random.Next( 4 )] );
            }
            hslGanttChart4.SetGanttChart( data_my.ToArray( ), colors_my.ToArray( ) );

            if (data_my.Sum( ) > 86400)
            {
                data_my = new List<int>( ) { 1000 };
                colors_my = new List<Color>( ) { Colors.DodgerBlue };
            }
        }
    }
}
