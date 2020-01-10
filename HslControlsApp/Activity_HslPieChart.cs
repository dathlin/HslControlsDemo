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
using Android.Views;
using Android.Widget;
using Android.Support.V7.App;

namespace HslControlsApp
{
    [Activity( Label = "HslPieChart Demo" )]
    public class Activity_HslPieChart : AppCompatActivity
    {
        protected override void OnCreate( Bundle savedInstanceState )
        {
            base.OnCreate( savedInstanceState );

            // Create your application here
            SetContentView( Resource.Layout.layout_HslPieChart );

            hslPieChart1 = FindViewById<HslPieChart>( Resource.Id.hslPieChart1 );
            hslPieChart2 = FindViewById<HslPieChart>( Resource.Id.hslPieChart2 );
            hslPieChart3 = FindViewById<HslPieChart>( Resource.Id.hslPieChart3 );
            hslPieChart4 = FindViewById<HslPieChart>( Resource.Id.hslPieChart4 );

            SetRandomData( hslPieChart1 );
            SetRandomData( hslPieChart2 );
            SetRandomData( hslPieChart3 );
            SetRandomData( hslPieChart4 );

            timer = new Timer( new TimerCallback( Time_Tick ), null, 500, 3000 );
        }

        private void Time_Tick( object state )
        {
            RunOnUiThread( new Action( ( ) =>
            {
                SetRandomData( hslPieChart3 );
                SetRandomData( hslPieChart4 );
            } ) );
        }

        private void SetRandomData(HslPieChart pieChart )
        {
            List<string> data = new List<string>( );
            List<int> ints = new List<int>( );
            for (int i = 0; i < random.Next( 4, 12 ); i++)
            {
                data.Add( random.Next( 100, 999 ).ToString( ) );
                ints.Add( random.Next( 0, 5 ) );
            }

            pieChart.SetDataSource(
                data.ToArray( ),
                ints.ToArray( ) );
        }


        private Timer timer;
        private Random random = new Random( );
        private HslPieChart hslPieChart1 = null;
        private HslPieChart hslPieChart2 = null;
        private HslPieChart hslPieChart3 = null;
        private HslPieChart hslPieChart4 = null;
    }
}