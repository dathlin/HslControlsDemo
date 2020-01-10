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
    public partial class FormCurveHistory5 : FormContent
    {
        public FormCurveHistory5( )
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

            string info = "154,154,153,153,153,153,154,154,154,154,154,154,155,155,155,155,154,154,154,154,155,155,154,155,154,154,153,153,153," +
                "153,154,154,153,153,153,153,155,155,155,155,153,153,154,154,154,154,155,155,153,154,153,153,153,153,154,154,154,154,153,154,154," +
                "154,154,154,153,153,152,152,152,152,150,151,148,149,73,147,0,0,0,0,0,0,0,0,107,143,35,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,27,0," +
                "109,109,110,111,83,111,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0," +
                "0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0," +
                "0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,77,0,154,154,154,154,156,156,156,156,156,156,156,156,155,155,154,155,154,154,154,154,155,155," +
                "153,154,153,153,153,153,154,154,153,154,153,153,153,153,153,153,154,154,153,153,153,153,153,153,153,153,153,153,153,153,154,154," +
                "154,154,154,154,154,154,153,154,152,152,153,153,153,153,154,154,153,154,153,153,153,153,153,153,153,153,153,153,152,152,153,153," +
                "154,154,153,154,153,153,153,153,153,153,154,154,155,156,154,155,153,154,151,152,151,152,152,152,152,152,152,152,151,152,151,152," +
                "151,152,151,151,150,150,149,150,37,0,0,0,0,0,0,0,35,0,107,143,0,0,106,142,35,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0," +
                "0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0," +
                "0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0," +
                "0,0,0,0,0,0,0,0,0,0,0,0,154,154,154,154,77,154,0,0,0,0,153,153,153,153,153,153,154,154,153,154,153,153,153,153,153,153,154,154,153," +
                "154,152,153,151,152,113,151,0,0,0,0,0,0,0,0,0,0,0,0,0,0,114,153,38,0,0,0,38,0,153,154,152,152,151,151,113,151,0,0,0,0,0,0,77,154,0," +
                "0,0,0,0,0,0,0,114,153,153,153,155,155,155,156,154,154,154,154,154,154,153,154,153,153,154,154,156,156,156,157,155,156,155,155,155," +
                "156,152,152,113,151,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,34,0,103,138,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0," +
                "0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,52,0,106,106,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,53,0,106,106,53,106,0,0," +
                "0,0,52,0,52,104,0,0,0,0,0,0,52,105,0,0,0,0,54,108,0,0,0,0,0,0,27,0,108,108,110,110,83,111,0,0,0,0,87,116,118,119,90,120,0,0,0,0,0,0,0," +
                "0,0,0,0,0,0,0,0,0,0,0,110,147,37,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0," +
                "0,0,0,0,0,0,0,0,116,155,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,38,0,154,154,154,154,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,78,0,154," +
                "154,153,153,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,72,0,72,0,143,144,143,144,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0," +
                "0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,53,0,53,0,53,106,0,0,51,0,103,103,103,103,53,106,0,0,53,0,106,107,53,106,0,0,26,0,105,105," +
                "78,105,0,0,26,0,105,105,79,106,0,0,0,0,78,105,104,104,26,0,0,0,78,104,105,105,26,0,0,0,78,105,105,105,26,0,0,0,26,0,107,107,26,0,0,0," +
                "0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,35,0,143,144,146,147,149,149,37,0,0,0,0,0,0,0,0,0,78,156," +
                "0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
            string[] infos = info.Split( new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries );
            List<string> lists = new List<string>( info.Length * 10 );
            lists.AddRange( infos );
            lists.AddRange( infos );
            lists.AddRange( infos );
            lists.AddRange( infos );
            lists.AddRange( infos );
            lists.AddRange( infos );
            lists.AddRange( infos );
            lists.AddRange( infos );
            lists.AddRange( infos );
            lists.AddRange( infos );
            infos = lists.ToArray( );

            int datalength = infos.Length;
            Thread.Sleep( 2000 );
            // 我们假定从数据库中获取到了这些数据信息
            float[] steps = new float[datalength];
            float[] data = new float[datalength];
            float[] press = new float[datalength];
            DateTime[] times = new DateTime[datalength];

            for (int i = 0; i < data.Length; i++)
            {
                // 模拟中间空了一些数据段
                //if(i > 200 && i < 300)
                //{
                //    steps[i] = random.Next( 10 );
                //    data[i] = float.NaN;
                //    times[i] = DateTime.Now.AddSeconds( i - datalength );
                //    press[i] = (float)(Math.Sin( 2 * Math.PI * i / 100 ) * 0.5d + 4.1d);
                //    continue;
                //}

                //if( i > 1000 && i < 1200)
                //{
                //    steps[i] = random.Next( 10 );
                //    data[i] = float.NaN;
                //    times[i] = DateTime.Now.AddSeconds( i - datalength );
                //    press[i] = (float)(Math.Sin( 2 * Math.PI * i / 100 ) * 0.5d + 4.1d);
                //    continue;
                //}

                steps[i] = random.Next( 10 );
                data[i] = float.Parse( infos[i] ) == 0 ? float.NaN : float.Parse( infos[i] ); // (float)(Math.Sin( 2 * Math.PI * i / 50 ) * 20 + 120);
                times[i] = DateTime.Now.AddSeconds( i - datalength );
                press[i] = (float)(Math.Sin( 2 * Math.PI * i / 100 ) * 0.5d + 4.1d);
            }

            // 显示出数据信息来
            Invoke( new Action( ( ) =>
             {
                 hslCurveHistory1.SetLeftCurve( "步序", steps );
                 hslCurveHistory1.SetLeftCurve( "温度", data, Color.DodgerBlue, false, "{0:F1} ℃" );
                 hslCurveHistory1.SetRightCurve( "压力", press, Color.Tomato, true, "{0:F2} Mpa" );
                 hslCurveHistory1.SetDateTimes( times );
                 hslCurveHistory1.AddAuxiliaryLabel( new HslControls.AuxiliaryLable( )
                 {
                     LocationX = 0.6f,
                     Text = $"今日产量：{random.Next(10)}个",
                     TextBack = new SolidBrush(Color.FromArgb(10,10,10)),
                     TextBrush = Brushes.Gray,
                 } );
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

        private void Button10_Click( object sender, EventArgs e )
        {
            hslCurveHistory1.ValueMinLeft = 80;
            hslCurveHistory1.RenderCurveUI( );
        }
    }
}
