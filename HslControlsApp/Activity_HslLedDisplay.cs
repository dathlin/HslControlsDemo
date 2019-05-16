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
    [Activity( Label = "HslLedDisplay Demo" )]
    public class Activity_HslLedDisplay : AppCompatActivity
    {
        protected override void OnCreate( Bundle savedInstanceState )
        {
            base.OnCreate( savedInstanceState );

            // Create your application here

            SetContentView( Resource.Layout.layout_HslLedDisplay );
            ledDisplay1 = FindViewById<HslLedDisplay>( Resource.Id.hslLedDisplay1 );
            timer = new Timer( new TimerCallback( timeTick ), null, 100, 20 );
        }

        private void timeTick(object state )
        {
            count++;
            RunOnUiThread( new Action( ( ) =>
             {
                 ledDisplay1.DisplayText = count.ToString( );
             } ) );
        }

        private Timer timer = null;
        private HslLedDisplay ledDisplay1 = null;
        private int count = 0;
    }
}