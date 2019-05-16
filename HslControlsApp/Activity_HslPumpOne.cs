using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    [Activity( Label = "HslPumpOne Demo" )]
    public class Activity_HslPumpOne : AppCompatActivity
    {
        protected override void OnCreate( Bundle savedInstanceState )
        {
            base.OnCreate( savedInstanceState );

            // Create your application here
            SetContentView( Resource.Layout.layout_HslPumpOne );

            button1 = FindViewById<Button>( Resource.Id.button1 );
            button2 = FindViewById<Button>( Resource.Id.button2 );
            hslPipeLine1 = FindViewById<HslPipeLine>( Resource.Id.hslPipeLine1 );
            hslPipeLine2 = FindViewById<HslPipeLine>( Resource.Id.hslPipeLine2 );
            hslPumpOne1 = FindViewById<HslPumpOne>( Resource.Id.hslPumpOne1 );

            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
        }

        private void Button2_Click( object sender, EventArgs e )
        {
            // stop
            hslPipeLine1.MoveSpeed = 0;
            hslPipeLine2.MoveSpeed = 0;
            hslPumpOne1.MoveSpeed = 0;
        }

        private void Button1_Click( object sender, EventArgs e )
        {
            // start
            hslPipeLine1.MoveSpeed = 1;
            hslPipeLine2.MoveSpeed = 1;
            hslPumpOne1.MoveSpeed = 1;
        }

        private Button button1 = null;
        private Button button2 = null;

        private HslPipeLine hslPipeLine1 = null;
        private HslPipeLine hslPipeLine2 = null;

        private HslPumpOne hslPumpOne1 = null;
    }
}