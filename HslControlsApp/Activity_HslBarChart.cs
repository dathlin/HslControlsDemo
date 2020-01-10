using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HslControls;

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
    [Activity( Label = "HslBarChart Demo" )]
    public class Activity_HslBarChart : AppCompatActivity
    {
        protected override void OnCreate( Bundle savedInstanceState )
        {
            base.OnCreate( savedInstanceState );

            // Create your application here
            SetContentView( Resource.Layout.layout_HslBarChart );

            hslBarChart1 = FindViewById<HslBarChart>( Resource.Id.hslBarChart1 );
            hslBarChart2 = FindViewById<HslBarChart>( Resource.Id.hslBarChart2 );
            hslBarChart3 = FindViewById<HslBarChart>( Resource.Id.hslBarChart3 );

            hslBarChart1.SetDataSource( new int[] { random.Next( 1500 ), random.Next( 1000 ), random.Next( 600 ), random.Next( 1500 ), random.Next( 800 ) },
               new string[] { "周一", "周二", "周三", "周四", "周五" } );

            hslBarChart2.SetDataSource( new int[] { random.Next( 1500 ), random.Next( 1000 ), random.Next( 600 ), random.Next( 1500 ), random.Next( 800 ), random.Next( 1500 ), random.Next( 800 ) },
                new string[] { "周一", "周二", "周三", "周四", "周五", "周六", "周日" } );

            List<int> month = new List<int>( );
            List<string> days = new List<string>( );
            for (int i = 0; i < 31; i++)
            {
                month.Add( random.Next( 1500 ) );
                if (i % 2 == 0)
                {
                    days.Add( (i + 1).ToString( ) );
                }
                else
                {
                    days.Add( "" );
                }
            }
            // 此处将小于1000的和大于1000的颜色区分开发
            hslBarChart3.IsShowBarValue = false;
            hslBarChart3.SetDataSource( month.ToArray( ), days.ToArray( ), month.Select( m => m < 1000 ? Color.Orchid : Color.Gold ).ToArray( ) );
            hslBarChart3.AddLeftAuxiliary( 1000, Color.Yellow );
        }

        private Random random = new Random( );
        private HslBarChart hslBarChart1 = null;
        private HslBarChart hslBarChart2 = null;
        private HslBarChart hslBarChart3 = null;
    }
}