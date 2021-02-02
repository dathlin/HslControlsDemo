using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace HslControlsDemo
{
    public partial class FormCurveHistory3 : FormContent
    {
        public FormCurveHistory3( )
        {
            InitializeComponent();
        }

        private void button1_Click( object sender, EventArgs e )
        {
            hslCurveHistory1.Text = "正在加载数据...";
            hslCurveHistory1.RemoveAllCurve( );

            hslCurveHistory2.Text = "正在加载数据...";
            hslCurveHistory2.RemoveAllCurve( );
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
            Invoke( new Action( ( ) =>
             {
                 hslCurveHistory1.SetLeftCurve( "步序", steps );
                 hslCurveHistory1.SetLeftCurve( "温度", data, Color.DodgerBlue, HslControls.CurveStyle.Curve, "{0:F1} ℃" );
                 hslCurveHistory1.SetRightCurve( "压力", press, Color.Tomato, HslControls.CurveStyle.Curve, "{0:F2} Mpa" );
                 hslCurveHistory1.SetDateTimes( times );
                 hslCurveHistory1.AddMarkBackSection( new HslControls.HslMarkBackSection( ) { StartIndex = 1000, EndIndex = 1200, MarkText = "报警了" } );
                 // 添加两个背景标记的示例，可以用来标记特殊用途的背景，例如一个产品的周期，停机，维修等等状态
                 hslCurveHistory1.AddMarkForeSection( new HslControls.HslMarkForeSection( )
                 {
                     StartIndex = 900,
                     EndIndex = 1300,
                     StartHeight = 0.2f,
                     Height = 0.8f,
                 } );
                 hslCurveHistory1.AddMarkForeSection( new HslControls.HslMarkForeSection( )
                 {
                     StartIndex = 500,
                     EndIndex = 700,
                     StartHeight = 0.3f,
                     Height = 0.7f,
                     IsRenderTimeText = false,
                     LinePen = Pens.Orange,
                     MarkText = "报警区域"
                 } );

                 // 增加一个三角形的线段标记示例 Points的每个点的X是数据索引，Y是数据值（需要选对参考坐标轴，默认为左坐标轴）
                 hslCurveHistory1.AddMarkLine( new HslControls.HslMarkLine( )
                 {
                     CircleBrush = Brushes.DodgerBlue,
                     IsLeftFrame = true,
                     IsLineClosed = true,
                     LinePen = Pens.DodgerBlue,
                     TextBrush = Brushes.DodgerBlue,
                     Points = new PointF[]
                     {
                         new PointF(200, 180f), new PointF(260, 20f), new PointF(550, 150f),
                     },
                     Marks = new string[] { "AA", "BB", "CC" },
                 } );

                 // 添加一个活动的标记
                 HslControls.HslMarkForeSection active = new HslControls.HslMarkForeSection( )
                 {
                     StartIndex = 1000,
                     EndIndex = 1500,
                     Height = 0.9f,
                 };
                 active.CursorTexts.Add( "条码", "A123123124ashdiahsd是的iahsidasd" );
                 active.CursorTexts.Add( "工号", "asd2sd123dasf" );
                 hslCurveHistory1.AddMarkActiveSection( active );

                 hslCurveHistory1.SetCurveVisible( "步序", false );   // 步序不是曲线信息，不用显示出来
                 hslCurveHistory1.RenderCurveUI( );




                 hslCurveHistory2.SetLeftCurve( "步序", steps );
                 hslCurveHistory2.SetLeftCurve( "温度", data, Color.DodgerBlue, HslControls.CurveStyle.Curve, "{0:F1} ℃" );
                 hslCurveHistory2.SetRightCurve( "压力", press, Color.Tomato, HslControls.CurveStyle.Curve, "{0:F2} Mpa" );
                 hslCurveHistory2.SetDateTimes( times );
                 hslCurveHistory2.SetCurveVisible( "步序", false );
                 hslCurveHistory2.RenderCurveUI( );
             } ) );
        }

        private Random random = new Random( );

        private void FormCurveHistory_Load( object sender, EventArgs e )
        {
            hslCurveHistory1.AddLeftAuxiliary( 172f );

            linkLabel1.Click += LinkLabel1_Click;
            // 此处强制曲线图2随着曲线图1动作
            //hslCurveHistory1.Scroll += ( sender1, e1 ) => { hslCurveHistory2.SetScrollPosition( e1 ); Console.WriteLine( "设置曲线2的滚动条：" + e1.NewValue ); };
            //hslCurveHistory1.onCurveMouseMove += ( curve, x, y ) => { hslCurveHistory2.SetCurveMousePosition( x, y ); Console.WriteLine( "设置曲线2的坐标：" + x + "," + y  ); };
            // 此处强制曲线图1随着曲线图2动作
            hslCurveHistory2.Scroll += ( sender1, e1 ) => { hslCurveHistory1.SetScrollPosition( e1 ); Console.WriteLine( "设置曲线1的滚动条：" + e1.NewValue ); };
            hslCurveHistory2.onCurveMouseMove += ( curve, x, y ) => { hslCurveHistory1.SetCurveMousePosition( x, y ); Console.WriteLine( "设置曲线1的坐标：" + x + "," + y ); };

        }
        
        private void LinkLabel1_Click( object sender, EventArgs e )
        {
            try
            {
                System.Diagnostics.Process.Start( linkLabel1.Text );
            }
            catch(Exception ex)
            {
                MessageBox.Show( ex.Message );
            }
        }
        
        private void button2_Click( object sender, EventArgs e )
        {
            hslCurveHistory1.SetScaleByXAxis( 0.5f );
            hslCurveHistory1.RenderCurveUI( );
        }

        private void button3_Click( object sender, EventArgs e )
        {
            hslCurveHistory1.SetScaleByXAxis(1f );
            hslCurveHistory1.RenderCurveUI( );
        }

        private void button4_Click( object sender, EventArgs e )
        {
            hslCurveHistory1.SetScaleByXAxis( 2f );
            hslCurveHistory1.RenderCurveUI( );
        }

        private void hslCurveHistory1_onCurveDoubleClick( HslControls.HslCurveHistory hslCurve, int index, DateTime dateTime )
        {
            MessageBox.Show( $"Index: {index} Time:{dateTime.ToString( )}" );
        }

        private void button5_Click( object sender, EventArgs e )
        {
            if (int.TryParse( textBox1.Text, out int index ))
            {
                hslCurveHistory1.AddMarkText( new HslControls.HslMarkText( )
                {
                    Index = index,
                    CurveKey = "温度",
                    MarkText = textBox2.Text,
                    CircleBrush = Brushes.HotPink,
                    TextBrush = Brushes.Pink
                } );
                hslCurveHistory1.RenderCurveUI( );
            }
            else
            {
                MessageBox.Show( "Input Error" );
            }
        }

        private void button6_Click( object sender, EventArgs e )
        {
            hslCurveHistory1.RemoveAllMarkText( );
            hslCurveHistory1.RenderCurveUI( );
        }

        private void HslCurveHistory1_Click( object sender, EventArgs e )
        {
            Control_Click( sender, e );
        }
    }
}
