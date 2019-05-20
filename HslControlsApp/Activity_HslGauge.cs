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

namespace HslControlsApp
{
    [Activity( Label = "HslGauge Demo" )]
    public class Activity_HslGauge : AppCompatActivity
    {
        protected override void OnCreate( Bundle savedInstanceState )
        {
            base.OnCreate( savedInstanceState );

            // Create your application here
            SetContentView( Resource.Layout.layout_HslGauge );

            hslGauge1 = FindViewById<HslGauge>( Resource.Id.hslGauge1 );
            hslGauge2 = FindViewById<HslGauge>( Resource.Id.hslGauge2 );

            timer = new Timer( new TimerCallback( Time_Tick ), null, 500, 800 );
        }

        private void Time_Tick(object state )
        {
            RunOnUiThread( new Action( ( ) =>
            {
                hslGauge1.Value = random.Next( 2200 ) / 10f;
                hslGauge2.Value = random.Next( 800 ) / 100f;

            } ) );
        }

        private Timer timer;
        private Random random = new Random( );
        private HslGauge hslGauge1 = null;
        private HslGauge hslGauge2 = null;
    }
}