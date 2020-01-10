using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using HslControls;

namespace HslControlsApp
{
    [Activity( Label = "HslBattery Demo" )]
    public class Activity_HslBattery : AppCompatActivity
    {
        protected override void OnCreate( Bundle savedInstanceState )
        {
            base.OnCreate( savedInstanceState );

            // Create your application here
            SetContentView( Resource.Layout.layout_HslBattery );
            hslBattery1 = FindViewById<HslBattery>( Resource.Id.hslBattery1 );
            hslBattery2 = FindViewById<HslBattery>( Resource.Id.hslBattery2 );
            hslBattery3 = FindViewById<HslBattery>( Resource.Id.hslBattery3 );

            timer = new Timer( new TimerCallback( TimeTick ), null, 500, 1000 );
        }

        private void TimeTick(object state )
        {
            RunOnUiThread( new Action( ( ) =>
             {
                 hslBattery1.Value = random.Next( 50 ) / 10f;
                 hslBattery2.Value = random.Next( 50 ) / 10f;
                 hslBattery3.Value = random.Next( 5001 );
             } ) );
        }

        private Random random = new Random( );
        private HslBattery hslBattery1 = null;
        private HslBattery hslBattery2 = null;
        private HslBattery hslBattery3 = null;
        private Timer timer = null;
    }
}