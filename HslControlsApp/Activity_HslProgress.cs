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
    [Activity( Label = "HslProgress Demo" )]
    public class Activity_HslProgress : AppCompatActivity
    {
        protected override void OnCreate( Bundle savedInstanceState )
        {
            base.OnCreate( savedInstanceState );

            // Create your application here
            SetContentView( Resource.Layout.layout_HslProgress );
            hslProgress1 = FindViewById<HslProgress>( Resource.Id.hslProgress1 );
            hslProgress2 = FindViewById<HslProgress>( Resource.Id.hslProgress2 );
            hslProgress3 = FindViewById<HslProgress>( Resource.Id.hslProgress3 );
            hslProgress4 = FindViewById<HslProgress>( Resource.Id.hslProgress4 );

            hslProgressLine1 = FindViewById<HslProgressLine>( Resource.Id.hslProgressLine1 );
            hslProgressLine2 = FindViewById<HslProgressLine>( Resource.Id.hslProgressLine2 );
            hslProgressLine3 = FindViewById<HslProgressLine>( Resource.Id.hslProgressLine3 );
            hslProgressLine4 = FindViewById<HslProgressLine>( Resource.Id.hslProgressLine4 );
            hslProgressLine5 = FindViewById<HslProgressLine>( Resource.Id.hslProgressLine5 );
            hslProgressLine6 = FindViewById<HslProgressLine>( Resource.Id.hslProgressLine6 );

            timer = new Timer( new TimerCallback( TimerTick ), null, 500, 1000 );
        }

        private void TimerTick(object state )
        {
            RunOnUiThread( new Action( ( ) =>
             {
                 hslProgress1.Value = random.Next( 101 );
                 hslProgress2.Value = random.Next( 101 );
                 hslProgress3.Value = random.Next( 101 );
                 hslProgress4.Value = random.Next( 101 );

                 hslProgressLine1.Value = random.Next( 101 );
                 hslProgressLine2.Value = random.Next( 101 );
                 hslProgressLine3.Value = random.Next( 101 );
                 hslProgressLine4.Value = random.Next( 101 );
                 hslProgressLine5.Value = random.Next( 101 );
                 hslProgressLine6.Value = random.Next( 101 );
             } ) );
        }

        private Random random = new Random( );
        private HslProgress hslProgress1 = null;
        private HslProgress hslProgress2 = null;
        private HslProgress hslProgress3 = null;
        private HslProgress hslProgress4 = null;

        private HslProgressLine hslProgressLine1 = null;
        private HslProgressLine hslProgressLine2 = null;
        private HslProgressLine hslProgressLine3 = null;
        private HslProgressLine hslProgressLine4 = null;
        private HslProgressLine hslProgressLine5 = null;
        private HslProgressLine hslProgressLine6 = null;

        private Timer timer;
    }
}