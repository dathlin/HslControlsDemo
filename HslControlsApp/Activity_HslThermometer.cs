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
using System.Threading;

namespace HslControlsApp
{
    [Activity( Label = "HslThermometer Demo" )]
    public class Activity_HslThermometer : AppCompatActivity
    {
        protected override void OnCreate( Bundle savedInstanceState )
        {
            base.OnCreate( savedInstanceState );

            // Create your application here
            SetContentView( Resource.Layout.layout_HslThermometer );
            hslThermometer1 = FindViewById<HslThermometer>( Resource.Id.hslThermometer1 );
            hslThermometer2 = FindViewById<HslThermometer>( Resource.Id.hslThermometer2 );

            timer = new Timer( new TimerCallback( TimerTick ), null, 500, 1000 );

        }

        private void TimerTick( object state )
        {
            RunOnUiThread( new Action( ( ) =>
            {
                hslThermometer1.Value = random.Next( 800 ) / 10f - 20;
                hslThermometer2.Value = random.Next( 800 ) / 10f - 20;
            } ) );
        }

        private HslThermometer hslThermometer1 = null;
        private HslThermometer hslThermometer2 = null;
        private Timer timer;
        private Random random = new Random( );
    }
}