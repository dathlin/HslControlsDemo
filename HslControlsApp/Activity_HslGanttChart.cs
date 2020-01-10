using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HslControls;
using System.Threading;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Android.Graphics;

namespace HslControlsApp
{
    [Activity( Label = "HslGanttChart Demo" )]
    public class Activity_HslGanttChart : AppCompatActivity
    {
        protected override void OnCreate( Bundle savedInstanceState )
        {
            base.OnCreate( savedInstanceState );

            // Create your application here
            SetContentView( Resource.Layout.layout_HslGanttChart );

            hslGanttChart1 = FindViewById<HslGanttChart>( Resource.Id.hslGanttChart1 );
            hslGanttChart2 = FindViewById<HslGanttChart>( Resource.Id.hslGanttChart2 );
            hslGanttChart3 = FindViewById<HslGanttChart>( Resource.Id.hslGanttChart3 );
            hslGanttChart4 = FindViewById<HslGanttChart>( Resource.Id.hslGanttChart4 );
            hslGanttChart5 = FindViewById<HslGanttChart>( Resource.Id.hslGanttChart5 );


            // 图1和图2都是默认为秒，共计86400秒，图3图4都是按照天的，设置为了31天
            hslGanttChart1.SetGanttChart( new int[] { 15000, 10000, 7800, 42000 }, new Color[] { Color.Tomato, Color.DodgerBlue, Color.LimeGreen, Color.DodgerBlue } );
            hslGanttChart2.SetGanttChart( new int[] { 5000, 14000, 17800, 12000, 3000 }, new Color[] { Color.Tomato, Color.DodgerBlue, Color.LimeGreen, Color.DodgerBlue, Color.DimGray } );

            // 日期的格式的
            hslGanttChart3.SetGanttChart( new int[] { 1, 5, 10, 7, 8 }, new Color[] { Color.DodgerBlue, Color.Tomato, Color.DimGray, Color.Chocolate, Color.Orchid } );

            timer = new Timer( new TimerCallback( TimerTick ), null, 500, 1000 );
        }

        private void TimerTick(object state )
        {
            RunOnUiThread( new Action( ( ) =>
             {
                 // 更新hslGanttChart5, 随机的创建数据
                 int[] data = new int[10] { 8640, 8640, 8640, 8640, 8640, 8640, 8640, 8640, 8640, 8640 };
                 Color[] colors = new Color[] { Color.DodgerBlue, Color.Tomato, Color.DimGray, Color.Orange };
                 Color[] colors_random = new Color[10]{colors[random.Next( 4 )], colors[random.Next( 4 )], colors[random.Next( 4 )], colors[random.Next( 4 )], colors[random.Next( 4 )], colors[random.Next( 4 )],
                colors[random.Next( 4 )], colors[random.Next( 4 )] ,colors[random.Next( 4 )], colors[random.Next( 4 )]};
                 hslGanttChart4.SetGanttChart( data, colors_random );


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
                 hslGanttChart5.SetGanttChart( data_my.ToArray( ), colors_my.ToArray( ) );

                 if (data_my.Sum( ) > 86400)
                 {
                     data_my = new List<int>( ) { 1000 };
                     colors_my = new List<Color>( ) { Color.DodgerBlue };
                 }
             } ) );
        }


        private Random random = new Random( );
        private List<int> data_my = new List<int>( ) { 1000 };
        private List<Color> colors_my = new List<Color>( ) { Color.DodgerBlue };

        private HslGanttChart hslGanttChart1 = null;
        private HslGanttChart hslGanttChart2 = null;
        private HslGanttChart hslGanttChart3 = null;
        private HslGanttChart hslGanttChart4 = null;
        private HslGanttChart hslGanttChart5 = null;
        private Timer timer = null;
    }
}