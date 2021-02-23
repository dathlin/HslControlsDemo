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
            Thread.Sleep( 2000 );
            // 我们假定从数据库中获取到了这些数据信息
            float[] steps = new float[2000];
            float[] data = new float[2000];
            float[] press = new float[2000];
            DateTime[] times = new DateTime[2000];

            for (int i = 0; i < data.Length; i++)
            {
                steps[i] = random.Next( 10 );
                data[i] = Convert.ToSingle( random.NextDouble( ) * 40 + 100 );
                times[i] = DateTime.Now.AddSeconds( i - 2000 );
                press[i] = Convert.ToSingle( random.NextDouble( ) * 0.5d + 4 );
            }

            // 显示出数据信息来
            Dispatcher.Invoke( new Action( ( ) =>
            {
                hslCurveHistory1.SetLeftCurve( "步序", steps );
                hslCurveHistory1.SetLeftCurve( "温度", data, System.Drawing.Color.DodgerBlue, HslControls.CurveStyle.Curve, "{0:F1} ℃" );
                hslCurveHistory1.SetRightCurve( "压力", press, System.Drawing.Color.Tomato, HslControls.CurveStyle.Curve, "{0:F2} Mpa" );
                hslCurveHistory1.SetDateTimes( times );
                hslCurveHistory1.AddMarkBackSection( new HslControls.HslMarkBackSection( ) { StartIndex = 1000, EndIndex = 1200, MarkText = "报警了", BackColor = System.Drawing.Color.FromArgb( 56, 56, 56 ) } );
                // 添加两个标记
                hslCurveHistory1.AddMarkForeSection( new HslControls.HslMarkForeSection( )
                {
                    StartIndex = 900,
                    EndIndex = 1300,
                    StartHeight = 0.2f,
                    Height = 0.8f,
                    LinePen = System.Drawing.Pens.Blue,
                    FontBrush = System.Drawing.Brushes.Chocolate
                } );
                hslCurveHistory1.AddMarkForeSection( new HslControls.HslMarkForeSection( )
                {
                    StartIndex = 500,
                    EndIndex = 700,
                    StartHeight = 0.3f,
                    Height = 0.7f,
                    IsRenderTimeText = false,
                    LinePen = System.Drawing.Pens.Orange,
                    MarkText = "报警区域",
                    FontBrush = System.Drawing.Brushes.Chocolate
                } );

                // 添加一个活动的标记
                HslControls.HslMarkForeSection active = new HslControls.HslMarkForeSection( )
                {
                    StartIndex = 1000,
                    EndIndex = 1500,
                    Height = 0.9f,
                    LinePen = System.Drawing.Pens.Blue,
                    FontBrush = System.Drawing.Brushes.Chocolate
                };
                active.CursorTexts.Add( "条码", "A123123124ashdiahsd是的iahsidasd" );
                active.CursorTexts.Add( "工号", "asd2sd123dasf" );
                hslCurveHistory1.AddMarkActiveSection( active );
                hslCurveHistory1.SetCurveVisible( "步序", false );
                hslCurveHistory1.RenderCurveUI( );
            } ) );
        }
    }
}
