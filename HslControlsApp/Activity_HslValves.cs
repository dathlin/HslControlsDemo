using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using HslControls;

namespace HslControlsApp
{
    [Activity( Label = "HslValves Demo" )]
    public class Activity_HslValves : AppCompatActivity
    {
        protected override void OnCreate( Bundle savedInstanceState )
        {
            base.OnCreate( savedInstanceState );

            // Create your application here

            SetContentView( Resource.Layout.layout_HslValves );

            Button button1 = FindViewById<Button>( Resource.Id.button1 );
            Button button2 = FindViewById<Button>( Resource.Id.button2 );
            hslValves1 = FindViewById<HslValves>( Resource.Id.hslValves1 );
            pipeLine1 = FindViewById<HslPipeLine>( Resource.Id.hslPipeLine1 );
            pipeLine2 = FindViewById<HslPipeLine>( Resource.Id.hslPipeLine2 );
            pipeLine1.PipeLineActive = true;
            pipeLine2.PipeLineActive = true;
            pipeLine1.MoveSpeed = 1;
            pipeLine2.MoveSpeed = 1;
            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
        }

        private void Button2_Click( object sender, EventArgs e )
        {
            // close
            pipeLine1.MoveSpeed = 0;
            pipeLine2.MoveSpeed = 0;
            hslValves1.EdgeColor = Color.Tomato;
        }

        private void Button1_Click( object sender, EventArgs e )
        {
            // open
            pipeLine1.MoveSpeed = 1;
            pipeLine2.MoveSpeed = 1;
            hslValves1.EdgeColor = Color.Gray;
        }

        HslValves hslValves1 = null;
        HslPipeLine pipeLine1 = null;
        HslPipeLine pipeLine2 = null;

    }
}