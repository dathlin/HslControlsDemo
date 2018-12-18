using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HslControlsDemo
{
    public partial class FormCurve : Form
    {
        public FormCurve( )
        {
            InitializeComponent( );
            random = new Random( );
        }

        private float[] GetRandomData( int length, int max )
        {
            float[] buffer = new float[length];
            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = random.Next( max );
            }
            return buffer;
        }

        private void FormCurve_Load( object sender, EventArgs e )
        {
            timerTick = new Timer( );
            timerTick.Interval = 300;
            timerTick.Tick += TimerTick_Tick;
            timerTick.Start( );

            hslCurve1.SetCurveText( new string[] { "一", "二", "三", "四", "五", "六", "七", "八", "九", "十", "十一", "十二" } );
            hslCurve1.SetLeftCurve( "A", GetRandomData( 12, 100 ), Color.Blue );

            hslCurve3.SetLeftCurve( "A", null, Color.DodgerBlue );
            hslCurve3.SetLeftCurve( "B", null, Color.DarkOrange );
            hslCurve3.SetLeftCurve( "C", null, Color.LimeGreen );
            
            hslCurve4.SetLeftCurve( "A", null, Color.LightSkyBlue );
            hslCurve4.SetLeftCurve( "B", null, Color.Tomato );
            hslCurve4.SetRightCurve( "C", null, Color.LimeGreen );
            hslCurve4.SetRightCurve( "D", null, Color.Orchid );

            hslCurve5.SetLeftCurve( "A", null, Color.DodgerBlue, true );
            hslCurve5.SetLeftCurve( "B", null, Color.DarkOrange, true );
            hslCurve5.SetLeftCurve( "C", null, Color.LimeGreen, true );


            hslCurve6.SetLeftCurve( "A", null, Color.DodgerBlue );
            hslCurve6.SetLeftCurve( "B", null, Color.DarkOrange );
        }

        private void TimerTick_Tick( object sender, EventArgs e )
        {
            float random1 = (float)random.NextDouble( );
            float random2 = (float)random.NextDouble( );
            float random3 = (float)random.NextDouble( );

            hslCurve3.AddCurveData(
                new string[] { "A", "B", "C"},
                new float[]
                {
                    random1*10 + 80,
                    random2*20+50,
                    random2*30,
                }
            );

            hslCurve5.AddCurveData(
                new string[] { "A", "B", "C" },
                new float[]
                {
                    random1*10 + 80,
                    random2*20+50,
                    random2*30,
                }
            );

            hslCurve4.AddCurveData( new string[] { "A", "B", "C", "D" },
                new float[]
                {
                   (float)random.NextDouble( ) * 10 + 170,
                   (float)random.NextDouble( ) * 4 + 150,
                   (float)random.NextDouble( ) * 1 + 3,
                   (float)random.NextDouble( ) * 0.4f,
                }
            );

            hslCurve6.AddCurveData(
                new string[] { "A", "B" },
                new float[]
                {
                    random1*10 + 80,
                    random2*20+50,
                }
            );

        }


        private Random random = null;
        private Timer timerTick = null;

        private void button1_Click( object sender, EventArgs e )
        {
            // 新增辅助线
            if (float.TryParse( textBox1.Text, out float value ))
            {
                hslCurve6.AddLeftAuxiliary( value, Color.Yellow );
            }
        }

        private void button2_Click( object sender, EventArgs e )
        {
            // 移除辅助线
            if (float.TryParse( textBox1.Text, out float value ))
            {
                hslCurve6.RemoveAuxiliary( value );
            }
        }

        private bool isVisiable = true;
        private void button3_Click( object sender, EventArgs e )
        {
            // 隐藏曲线
            isVisiable = !isVisiable;
            hslCurve6.SetCurveVisible( new string[] { "A" }, isVisiable );
        }
    }
}
