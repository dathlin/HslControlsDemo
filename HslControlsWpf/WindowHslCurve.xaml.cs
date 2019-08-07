using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Forms;
using HslControls.WPF;

namespace HslControlsWpf
{
    /// <summary>
    /// WindowHslCurve.xaml 的交互逻辑
    /// </summary>
    public partial class WindowHslCurve : Window
    {
        public WindowHslCurve( )
        {
            InitializeComponent( );
            random = new Random( );
        }

        protected override void OnSourceInitialized( EventArgs e )
        {
            base.OnSourceInitialized( e );


            timerTick = new Timer( );
            timerTick.Interval = 300;
            timerTick.Tick += TimerTick_Tick;
            timerTick.Start( );

            hslCurve1.SetCurveText( new string[] { "一", "二", "三", "四", "五", "六", "七", "八", "九", "十", "十一", "十二" } );
            hslCurve1.SetLeftCurve( "A", GetRandomData( 12, 100, 0 ), Colors.Blue );
            hslCurve1.AddMarkText( new HslWpfMarkText( )
            {
                Index = 2,
                CurveKey = "A",
                MarkText = "很给力"
            } );
            hslCurve1.AddMarkText( new HslWpfMarkText( )
            {
                Index = 5,
                CurveKey = "A",
                MarkText = "不太行了",
                TextColor = Colors.Red
            } );
            hslCurve1.AddAuxiliaryLabel( new WpfAuxiliaryLable( )
            {
                LocationX = 0.6f,
                Text = "带材厚度：0.1 mm",
                TextBack = Colors.Black,
                TextBrush = Colors.Pink
            } );
            hslCurve1.AddAuxiliaryLabel( new WpfAuxiliaryLable( )
            {
                LocationX = 0.8f,
                Text = "平均值：46 mm",
                TextBack = Colors.Black,
                TextBrush = Colors.Pink
            } );

            hslCurve3.SetLeftCurve( "A", null, Colors.DodgerBlue );
            hslCurve3.SetLeftCurve( "B", null, Colors.DarkOrange );
            hslCurve3.SetLeftCurve( "C", null, Colors.LimeGreen );


            hslCurve4.SetLeftCurve( "A", null, Colors.LightSkyBlue );
            hslCurve4.SetLeftCurve( "B", null, Colors.Tomato );
            hslCurve4.SetRightCurve( "C", null, Colors.LimeGreen );
            hslCurve4.SetRightCurve( "D", null, Colors.Orchid );
            hslCurve4.AddAuxiliaryLabel( new HslControls.WPF.WpfAuxiliaryLable( )
            {
                LocationX = 0.65f,
                Text = "平均值：46 mm",
                TextBack = Colors.Black,
                TextBrush = Colors.DodgerBlue
            } );

            hslCurve5.SetLeftCurve( "A", null, Colors.DodgerBlue, true );
            hslCurve5.SetLeftCurve( "B", null, Colors.DarkOrange, true );
            hslCurve5.SetLeftCurve( "C", null, Colors.LimeGreen, true );
            auxiliaryLable5 = new WpfAuxiliaryLable( )
            {
                LocationX = 0.7f,
                Text = "报警信息：6 个",
                TextBack = Colors.DimGray,
                TextBrush = Colors.Pink
            };
            hslCurve5.AddAuxiliaryLabel( auxiliaryLable5 );


            hslCurve6.SetLeftCurve( "A", null, Colors.DodgerBlue );
            hslCurve6.SetLeftCurve( "B", null, Colors.DarkOrange );
        }

        private WpfAuxiliaryLable auxiliaryLable5;

        private void TimerTick_Tick( object sender, EventArgs e )
        {
            count_tick++;
            float random1 = (float)(Math.Sin( 2 * Math.PI * count_tick / 30 ) * 0.5d + 0.5);
            float random2 = (float)(Math.Sin( 2 * Math.PI * count_tick / 50 ) * 0.5d + 0.5);
            float random3 = (float)(Math.Cos( 2 * Math.PI * count_tick / 80 ) * 0.5d + 0.5);

            hslCurve3.AddCurveData(
                new string[] { "A", "B", "C" },
                new float[]
                {
                    random1*10 + 80,
                    random2*20+50,
                    random2*10,
                }
            );

            auxiliaryLable5.Text = "报警信息：" + random.Next( 10 ) + " 个";
            if (count_tick % 20 == 0)
            {
                hslCurve5.AddCurveData(
                    new string[] { "A", "B", "C" },
                    new float[]
                    {
                        random1*10 + 80 - 100,
                        random2*20 + 50 - 100,
                        random2*30 - 100,
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
                hslCurve5.AddCurveData(
                   new string[] { "A", "B", "C" },
                   new float[]
                   {
                        random1*10 + 80 - 100,
                        random2*20 + 50 - 100,
                        random2*30 - 100,
                   }
               );
            }

            hslCurve4.AddCurveData( new string[] { "A", "B", "C", "D" },
                new float[]
                {
                   (float)random.NextDouble( ) * 10 + 170,
                   (float)random.NextDouble( ) * 4 + 150,
                   (float)random.NextDouble( ) * 1 + 3,
                   (float)random.NextDouble( ) * 0.4f,
                }
            );

            if (count_tick % 40 == 0)
            {
                hslCurve6.AddCurveData(
                    new string[] { "A", "B" },
                    new float[]
                    {
                        random1*10 + 80,
                        random2*20+50,
                    },
                    new string[]
                    {
                        "报警",
                        "危险",
                    }
                );
            }
            else
            {
                hslCurve6.AddCurveData(
                    new string[] { "A", "B" },
                    new float[]
                    {
                    random1*10 + 80,
                    random2*20+50,
                    }
                );
            }


            if (count_tick > 10000) count_tick = 0;
        }

        private float[] GetRandomData( int length, int max, int offect )
        {
            float[] buffer = new float[length];
            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = random.Next( max ) - offect;
            }
            return buffer;
        }


        private Random random = null;
        private Timer timerTick = null;
        private int count_tick = 0;

        private void Button_Click( object sender, RoutedEventArgs e )
        {
            // 新增
            if (float.TryParse( textBox1.Text, out float value ))
            {
                hslCurve6.AddLeftAuxiliary( value, Colors.Yellow );
            }
        }

        private void Button_Click_1( object sender, RoutedEventArgs e )
        {
            // 移除
            if (float.TryParse( textBox1.Text, out float value ))
            {
                hslCurve6.RemoveAuxiliary( value );
            }
        }

        private void Button_Click_2( object sender, RoutedEventArgs e )
        {
            // 清除
            hslCurve6.RemoveAllCurveData( );
        }
    }
}
