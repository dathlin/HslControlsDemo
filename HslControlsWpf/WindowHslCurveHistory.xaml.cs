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
using System.Threading;

namespace HslControlsWpf
{
    /// <summary>
    /// WindowHslCurve.xaml 的交互逻辑
    /// </summary>
    public partial class WindowHslCurveHistory : Window
    {
        public WindowHslCurveHistory( )
        {
            InitializeComponent( );
            random = new Random( );
        }

        protected override void OnSourceInitialized( EventArgs e )
        {
            base.OnSourceInitialized( e );
        }

        private WpfAuxiliaryLable auxiliaryLable5;

        private void TimerTick_Tick( object sender, EventArgs e )
        {
            count_tick++;
            float random1 = (float)(Math.Sin( 2 * Math.PI * count_tick / 30 ) * 0.5d + 0.5);
            float random2 = (float)(Math.Sin( 2 * Math.PI * count_tick / 50 ) * 0.5d + 0.5);
            float random3 = (float)(Math.Cos( 2 * Math.PI * count_tick / 80 ) * 0.5d + 0.5);


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
        private int count_tick = 0;

        private void Button_Click( object sender, RoutedEventArgs e )
        {
            // 新增
            if (float.TryParse( textBox1.Text, out float value ))
            {
                hslCurveHistory1.AddLeftAuxiliary( value, System.Drawing.Color.Yellow );
            }
        }

        private void Button_Click_1( object sender, RoutedEventArgs e )
        {
            // 移除
            if (float.TryParse( textBox1.Text, out float value ))
            {
                hslCurveHistory1.RemoveAuxiliary( value );
            }
        }

        private void Button_Click_2( object sender, RoutedEventArgs e )
        {
            // 清除
            hslCurveHistory1.RemoveAllAuxiliary( );
        }

        private void Button_Click_3( object sender, RoutedEventArgs e )
        {
            hslCurveHistory1.Text = "正在加载数据...";
            hslCurveHistory1.RemoveAllCurve( );
            new Thread( new ThreadStart( ThreadReadExample1 ) ) { IsBackground = true }.Start( );
        }

        private void ThreadReadExample1( )
        {
            Thread.Sleep( 100 );
            // 我们读取记事本的数据
            string text = System.IO.File.ReadAllText( @"C:\Users\DATHLIN\Desktop\历史曲线-数据.txt", Encoding.UTF8 );
            string[] texts = text.Split( new char[] { '#' } );

            string[] str_datas = texts[0].Split( new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries );
            string[] str_dates = texts[1].Split( new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries );

            float[] data = new float[str_datas.Length];
            DateTime[] times = new DateTime[str_dates.Length];
            for (int i = 0; i < str_datas.Length; i++)
            {
                if (str_datas[i] == "NaN")
                    data[i] = float.NaN;
                else
                    data[i] = float.Parse( str_datas[i] );
            }
            for (int i = 0; i < str_dates.Length; i++)
            {
                times[i] = DateTime.Parse( str_dates[i] );
            }


            // 显示出数据信息来
            Dispatcher.Invoke( new Action( ( ) =>
            {
                hslCurveHistory1.ValueMinLeft = 0;
                hslCurveHistory1.ValueMaxLeft = 150;

                hslCurveHistory1.SetLeftCurve( "温度", data, System.Drawing.Color.DodgerBlue, HslControls.CurveStyle.Curve, "{0:F1} ℃" );
                hslCurveHistory1.SetDateTimes( times );
                hslCurveHistory1.RenderCurveUI( );
            } ) );
        }
    }
}
