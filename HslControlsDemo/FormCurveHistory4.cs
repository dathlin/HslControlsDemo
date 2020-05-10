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
    public partial class FormCurveHistory4 : FormContent
    {
        public FormCurveHistory4( )
        {
            InitializeComponent();
        }

        private void button1_Click( object sender, EventArgs e )
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
            string[] customer = new string[2000];

            for (int i = 0; i < data.Length; i++)
            {
                steps[i] = random.Next( 10 );
                data[i] = Convert.ToSingle( random.NextDouble( ) * 40 + 100 );
                customer[i] = "Data" + (i + 1).ToString( );
                press[i] = Convert.ToSingle( random.NextDouble( ) * 0.5d + 4 );
            }

            // 显示出数据信息来
            Invoke( new Action( ( ) =>
             {
                 hslCurveHistory1.SetLeftCurve( "步序", steps );
                 hslCurveHistory1.SetLeftCurve( "温度", data, Color.DodgerBlue, HslControls.CurveStyle.Curve, "{0:F1} ℃" );
                 hslCurveHistory1.SetRightCurve( "压力", press, Color.Tomato, HslControls.CurveStyle.Curve, "{0:F2} Mpa" );
                 hslCurveHistory1.SetDateCustomer( customer );
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

                 hslCurveHistory1.SetCurveVisible( "步序", false );   // 步序不是曲线信息，不用显示出来
                 hslCurveHistory1.RenderCurveUI( );
             } ) );
        }

        private Random random = new Random( );

        private void FormCurveHistory_Load( object sender, EventArgs e )
        {
            hslCurveHistory1.AddLeftAuxiliary( 172f );

            linkLabel1.Click += LinkLabel1_Click;
            checkBox3.CheckedChanged += CheckBox3_CheckedChanged;
        }

        private void CheckBox3_CheckedChanged( object sender, EventArgs e )
        {
            hslCurveHistory1.RenderRightCoordinate = checkBox3.Checked;
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

        private void button7_Click( object sender, EventArgs e )
        {
            SaveFileDialog fileDialog = new SaveFileDialog( );
            fileDialog.Filter = "图片|*.png";
            fileDialog.InitialDirectory = Application.StartupPath;
            if (fileDialog.ShowDialog( ) == DialogResult.OK)
            {
                hslCurveHistory1.SaveToBitmap( ).Save( fileDialog.FileName );
                MessageBox.Show( "保存成功!" );
            }
            fileDialog.Dispose( );
        }

        private void Button8_Click( object sender, EventArgs e )
        {
            hslCurveHistory1.ScrollToRight( );
        }

        private void HslCurveHistory1_onCurveRangeSelect( HslControls.HslCurveHistory hslCurve, int index, int end )
        {
            label4.Text = DateTime.Now.ToString( "HH:mm:ss" ) + "  Start:" + index + "  End:" + end;
        }

        private void Button9_Click( object sender, EventArgs e )
        {
            hslCurveHistory1.RemoveAllMarkMouseSection( );
            hslCurveHistory1.RenderCurveUI( );
        }

        private void HslCurveHistory1_Click( object sender, EventArgs e )
        {
            Control_Click( sender, e );
        }
    }
}
