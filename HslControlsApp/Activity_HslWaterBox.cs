using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    [Activity( Label = "HslWaterBox Demo" )]
    public class Activity_HslWaterBox : AppCompatActivity
    {
        protected override void OnCreate( Bundle savedInstanceState )
        {
            base.OnCreate( savedInstanceState );

            // Create your application here
            SetContentView( Resource.Layout.layout_HslWaterBox );

            button1 = FindViewById<Button>( Resource.Id.button1 );
            hslWaterBox1 = FindViewById<HslWaterBox>( Resource.Id.hslWaterBox1 );
            hslWaterBox2 = FindViewById<HslWaterBox>( Resource.Id.hslWaterBox2 );
            hslWaterBox3 = FindViewById<HslWaterBox>( Resource.Id.hslWaterBox3 );
            button1.Click += Button1_Click;


            Button button2 = FindViewById<Button>( Resource.Id.button2 );
            Button button3 = FindViewById<Button>( Resource.Id.button3 );
            hslValves1 = FindViewById<HslValves>( Resource.Id.hslValves1 );
            pipeLine1 = FindViewById<HslPipeLine>( Resource.Id.hslPipeLine1 );
            pipeLine2 = FindViewById<HslPipeLine>( Resource.Id.hslPipeLine2 );
            pipeLine1.PipeLineActive = true;
            pipeLine2.PipeLineActive = true;
            pipeLine1.MoveSpeed = 0;
            pipeLine2.MoveSpeed = 0;
            hslValves1.EdgeColor = Color.Tomato;
            button2.Click += Button2_Click;
            button3.Click += Button3_Click;

            hslWaterBox3.Text = hslWaterBox3.Value.ToString( );
            timer = new Timer( new TimerCallback( TimerTick ), null, 100, 100 );
        }

        private void Button1_Click( object sender, EventArgs e )
        {
            float value = random.Next( 1001 ) / 10f;
            hslWaterBox1.Value = value;
            hslWaterBox2.Value = value;
        }

        private void Button3_Click( object sender, EventArgs e )
        {
            // close
            isOpen = false;
            pipeLine1.MoveSpeed = 0;
            pipeLine2.MoveSpeed = 0;
            hslValves1.EdgeColor = Color.Tomato;
        }

        private void Button2_Click( object sender, EventArgs e )
        {
            // open
            isOpen = true;
            pipeLine1.MoveSpeed = 1;
            pipeLine2.MoveSpeed = 1;
            hslValves1.EdgeColor = Color.Gray;
        }

        private void TimerTick(object state )
        {
            if (isOpen)
            {
                RunOnUiThread( new Action( ( ) =>
                 {
                     hslWaterBox3.Value += 0.3f;
                     hslWaterBox3.Text = hslWaterBox3.Value.ToString( );
                     if (hslWaterBox3.Value >= 100f) hslWaterBox3.Value = 0;
                 } ) );
            }
        }

        private Random random = new Random( );
        private Button button1 = null;
        private HslWaterBox hslWaterBox1 = null;
        private HslWaterBox hslWaterBox2 = null;
        private HslWaterBox hslWaterBox3 = null;

        HslValves hslValves1 = null;
        HslPipeLine pipeLine1 = null;
        HslPipeLine pipeLine2 = null;
        bool isOpen = false;
        Timer timer = null;
    }
}