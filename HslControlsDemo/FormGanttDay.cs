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
    public partial class FormGanttDay : FormContent
    {
        public FormGanttDay( )
        {
            InitializeComponent( );
        }

        private void FormGanttDay_Load( object sender, EventArgs e )
        {
            // 图1和图2都是默认为秒，共计86400秒，图3图4都是按照天的，设置为了31天
            hslGanttChart1.SetGanttChart( new int[] { 15000, 10000, 7800, 42000 }, new Color[] { Color.Tomato, Color.DodgerBlue, Color.LimeGreen, Color.DodgerBlue } );
            hslGanttChart2.SetGanttChart( new int[] { 5000, 14000, 17800, 12000, 3000 }, new Color[] { Color.Tomato, Color.DodgerBlue, Color.LimeGreen, Color.DodgerBlue, Color.DimGray } );
            hslGanttChart3.SetGanttChart( new int[] { 1, 5, 10, 7, 8 }, new Color[] { Color.DodgerBlue, Color.Tomato, Color.DimGray, Color.Chocolate, Color.Orchid } );
            hslGanttChart4.SetGanttChart( new int[] { 1, 5, 10, 7 }, new Color[] { Color.DodgerBlue, Color.Tomato, Color.DimGray, Color.Chocolate } );
            hslGanttChart7.SetGanttChart( new int[] { 15000, 10000, 7800, 42000, 50000 }, new Color[] { Color.Tomato, Color.DodgerBlue, Color.LimeGreen, Color.DodgerBlue, Color.Yellow } );

            timer = new Timer( );
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start( );
        }

        private void Timer_Tick( object sender, EventArgs e )
        {
            // 更新hslGanttChart5, 随机的创建数据
            int[] data = new int[10] { 8640, 8640, 8640, 8640, 8640, 8640, 8640, 8640, 8640, 8640 };
            Color[] colors = new Color[] { Color.DodgerBlue, Color.Tomato, Color.DimGray, Color.Orange };
            Color[] colors_random = new Color[10]{colors[random.Next( 4 )], colors[random.Next( 4 )], colors[random.Next( 4 )], colors[random.Next( 4 )], colors[random.Next( 4 )], colors[random.Next( 4 )],
                colors[random.Next( 4 )], colors[random.Next( 4 )] ,colors[random.Next( 4 )], colors[random.Next( 4 )]};
            hslGanttChart5.SetGanttChart( data, colors_random );


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
            hslGanttChart6.SetGanttChart( data_my.ToArray( ), colors_my.ToArray( ) );

            if (data_my.Sum( ) > 86400)
            {
                data_my = new List<int>( ) { 1000 };
                colors_my = new List<Color>( ) { Color.DodgerBlue };
            }
        }

        private List<int> data_my = new List<int>( ) { 1000 };
        private List<Color> colors_my = new List<Color>( ) { Color.DodgerBlue };

        private Timer timer;
        private Random random = new Random( );

        private void HslGanttChart1_Click( object sender, EventArgs e )
        {
            Control_Click( sender, e );
        }
    }
}
