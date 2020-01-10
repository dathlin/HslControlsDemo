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

namespace HslControlsApp
{
    [Activity( Label = "HslLanternSimple Demo" )]
    public class Activity_HslLanternSimple : AppCompatActivity
    {
        protected override void OnCreate( Bundle savedInstanceState )
        {
            base.OnCreate( savedInstanceState );

            // Create your application here
            SetContentView( Resource.Layout.layout_HslLanternSimple );

            button1 = FindViewById<Button>( Resource.Id.button1 );
            button2 = FindViewById<Button>( Resource.Id.button2 );
            lanternAlarm1 = FindViewById<HslLanternAlarm>( Resource.Id.hslLanternAlarm1 );
            lanternAlarm2 = FindViewById<HslLanternAlarm>( Resource.Id.hslLanternAlarm2 );

            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
        }

        private void Button2_Click( object sender, EventArgs e )
        {
            lanternAlarm1.IsAlarm = true;
            lanternAlarm2.IsAlarm = true;
        }

        private void Button1_Click( object sender, EventArgs e )
        {
            lanternAlarm1.IsAlarm = false;
            lanternAlarm2.IsAlarm = false;
        }

        private Button button1 = null;
        private Button button2 = null;
        private HslLanternAlarm lanternAlarm1 = null;
        private HslLanternAlarm lanternAlarm2 = null;

    }
}