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
            hslCurve4 = FindViewById<HslCurve>( Resource.Id.hslCurve4 );


            hslCurve1.SetLeftCurve( "A", null, Color.DodgerBlue );
            hslCurve1.SetLeftCurve( "B", null, Color.DarkOrange );
            hslCurve1.SetCurve( "C", true, null, Color.LimeGreen, 2f, CurveStyle.LineSegment );

            hslCurve2.SetLeftCurve( "A", null, Color.LightSkyBlue );
            hslCurve2.SetLeftCurve( "B", null, Color.Tomato, CurveStyle.StepLine );
            hslCurve2.SetRightCurve( "C", null, Color.LimeGreen, CurveStyle.StepLineWithoutVertical );
            hslCurve2.SetRightCurve( "D", null, Color.Orchid );
            hslCurve2.AddAuxiliaryLabel( new HslControls.AuxiliaryLable( )
            {
                LocationX = 0.63f,
                Text = "平均值：46 mm",
                TextBack = Color.Black,
                TextBrush = Color.DodgerBlue
            } );


            hslCurve3.SetLeftCurve( "A", null, Color.DodgerBlue );
            hslCurve3.SetLeftCurve( "B", null, Color.DarkOrange );
            hslCurve3.SetLeftCurve( "C", null, Color.LimeGreen );
            auxiliaryLable3 = new AuxiliaryLable( )
            {
                LocationX = 0.6f,
                Text = "报警信息：6 个",
                TextBack = Color.DimGray,
                TextBrush = Color.Pink
            };
            hslCurve3.AddAuxiliaryLabel( auxiliaryLable3 );


            hslCurve4.SetLeftCurve( "A", null, Color.DodgerBlue, CurveStyle.StepLine );
            timer = new Timer( new TimerCallback( TimerTick ), null, 100, 300 );
        }

        private HslControls.AuxiliaryLable auxiliaryLable3;

        private void TimerTick( object state )
        {
            count_tick++;
            RunOnUiThread( new Action( ( ) =>
            {
                //float random1 = (float)random.NextDouble( );
                //float random2 = (float)random.NextDouble( );
                //float random3 = (float)random.NextDouble( );

                float random1 = (float)(Math.Sin( 2 * Math.PI * count_tick / 30 ) * 0.5d + 0.5);
                float random2 = (float)(Math.Sin( 2 * Math.PI * count_tick / 50 ) * 0.5d + 0.5);
                float random3 = (float)(Math.Cos( 2 * Math.PI * count_tick / 80 ) * 0.5d + 0.5);


                hslCurve1.AddCurveData(
                    new string[] { "A", "B", "C" },
                    new float[]
                    {
                    random1*10 + 80,
                    random2*20+50,
                    random2*30,
                    }
                );


                auxiliaryLable3.Text = "报警信息：" + random.Next( 10 ) + " 个";
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
                   (float)random1 * 80 + 80,
                   (float)random2 * 5 + 1,
                   (float)random.NextDouble( ) * 0.4f,
                    }
                );

                hslCurve4.AddCurveData( "A", random1 * 150 + 10 );
            } ) );
        }

        private Timer timer = null;
        private int count_tick = 0;
        private Random random = new Random( );
        private HslCurve hslCurve1 = null;
        private HslCurve hslCurve2 = null;
        private HslCurve hslCurve3 = null;
        private HslCurve hslCurve4 = null;
    }
}