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
using Android.Graphics;
using Android.Support.V7.App;

namespace HslControlsApp
{
    [Activity( Label = "HslCurve Demo" )]
    public class Activity_HslCurve : AppCompatActivity
    {
        protected override void OnCreate( Bundle savedInstanceState )
        {
            base.OnCreate( savedInstanceState );

            // Create your application here
            SetContentView( Resource.Layout.layout_HslCurve );

            hslCurve1 = FindViewById<HslCurve>( Resource.Id.hslCurve1 );
            hslCurve2 = FindViewById<HslCurve>( Resource.Id.hslCurve2 );
            hslCurve3 = FindViewById<HslCurve>( Resource.Id.hslCurve3 );


            hslCurve1.SetLeftCurve( "A", null, Color.DodgerBlue );
            hslCurve1.SetLeftCurve( "B", null, Color.DarkOrange );
            hslCurve1.SetCurve( "C", true, null, Color.LimeGreen, 2f, true );

            hslCurve2.SetLeftCurve( "A", null, Color.LightSkyBlue );
            hslCurve2.SetLeftCurve( "B", null, Color.Tomato );
            hslCurve2.SetRightCurve( "C", null, Color.LimeGreen );
            hslCurve2.SetRightCurve( "D", null, Color.Orchid );

            hslCurve3.SetLeftCurve( "A", null, Color.DodgerBlue );
            hslCurve3.SetLeftCurve( "B", null, Color.DarkOrange );
            hslCurve3.SetLeftCurve( "C", null, Color.LimeGreen );

            timer = new Timer( new TimerCallback( TimerTick ), null, 100, 300 );
        }


        private void TimerTick( object state )
        {
            count_tick++;
            RunOnUiThread( new Action( ( ) =>
            {
                float random1 = (float)random.NextDouble( );
                float random2 = (float)random.NextDouble( );
                float random3 = (float)random.NextDouble( );


                hslCurve1.AddCurveData(
                    new string[] { "A", "B", "C" },
                    new float[]
                    {
                    random1*10 + 80,
                    random2*20+50,
                    random2*30,
                    }
                );

                if (count_tick % 100 == 0)
                {
                    hslCurve3.AddCurveData(
                        new string[] { "A", "B", "C" },
                        new float[]
                        {
                        random1*10 + 80,
                        random2*20+50,
                        random2*30,
                        },
                        new string[]
                        {
                        "正常",
                        "报警",
                        "危险",
                        }
                    );
                }
                else
                {
                    hslCurve3.AddCurveData(
                       new string[] { "A", "B", "C" },
                       new float[]
                       {
                    random1*10 + 80,
                    random2*20+50,
                    random2*30,
                       }
                   );
                }

                hslCurve2.AddCurveData( new string[] { "A", "B", "C", "D" },
                    new float[]
                    {
                   (float)random.NextDouble( ) * 10 + 170,
                   (float)random.NextDouble( ) * 4 + 150,
                   (float)random.NextDouble( ) * 1 + 3,
                   (float)random.NextDouble( ) * 0.4f,
                    }
                );
            } ) );
        }

        private Timer timer = null;
        private int count_tick = 0;
        private Random random = new Random( );
        private HslCurve hslCurve1 = null;
        private HslCurve hslCurve2 = null;
        private HslCurve hslCurve3 = null;
    }
}