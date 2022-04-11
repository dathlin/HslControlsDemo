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
    public partial class FormCurveHistory10 : FormContent
    {
        public FormCurveHistory10( )
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
            int total = 400000;
            Thread.Sleep( 2000 );
            // 我们假定从数据库中获取到了这些数据信息
            float[] steps = new float[total];
            float[] data = new float[total];
            float[] press = new float[total];
            DateTime[] times = new DateTime[total];

            for (int i = 0; i < data.Length; i++)
            {
                steps[i] = random.Next( 10 );
                data[i] = (float)(Math.Sin( 2 * Math.PI * i / 300 ) * 70 + 110);
                times[i] = DateTime.Now.AddSeconds( i - total );
                press[i] = (float)(Math.Sin( 2 * Math.PI * i / 400 ) * 1d + 3.1d);
            }

            // 显示出数据信息来
            Invoke( new Action( ( ) =>
            {
                hslCurveHistory1.SetLeftCurve( "步序", steps );
                hslCurveHistory1.SetLeftCurve( "温度", data, Color.DodgerBlue, HslControls.CurveStyle.Section, "{0:F1} ℃" );
                hslCurveHistory1.SetRightCurve( "压力", press, Color.Tomato, HslControls.CurveStyle.Section, "{0:F2} Mpa" );
                hslCurveHistory1.SetDateTimes( times );
                hslCurveHistory1.AddAuxiliaryLabel( new HslControls.AuxiliaryLable( )
                {
                    LocationX = 0.6f,
                    Text = $"今日产量：{random.Next( 10 )}个",
                    TextBack = new SolidBrush( Color.FromArgb( 222, 222, 222 ) ),
                    TextBrush = Brushes.Gray,
                } );
                // 添加两个背景标记的示例，可以用来标记特殊用途的背景，例如一个产品的周期，停机，维修等等状态
                
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
                // 增加一个点的标记图片
                hslCurveHistory1.AddMarkText( new HslControls.HslMarkText( )
                {
                    CircleBrush = Brushes.Tomato,
                    CurveKey = "温度",
                    Index = 300,
                    TextBrush = Brushes.Tomato,
                    MarkImage = global::HslControlsDemo.Properties.Resources.plane
                } );

                hslCurveHistory1.SetCurveVisible( "步序", false );   // 步序不是曲线信息，不用显示出来
                hslCurveHistory1.RenderCurveUI( );
            } ) );
        }

        private void ThreadReadExample2( )
        {
            Thread.Sleep( 100 );
            // 我们读取记事本的数据
            string text = System.IO.File.ReadAllText( @"C:\Users\DATHLIN\Desktop\历史曲线-数据.txt", Encoding.UTF8 );
            string[] texts = text.Split( new char[] { '#' } );

            string[] str_datas = texts[0].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
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
            Invoke( new Action( ( ) =>
            {
                hslCurveHistory1.ReferenceAxisLeft.Min = 0;
                hslCurveHistory1.ReferenceAxisLeft.Max = 1500;

                hslCurveHistory1.SetLeftCurve( "温度", data, Color.DodgerBlue, HslControls.CurveStyle.Curve, "{0:F1} ℃" );
                hslCurveHistory1.SetDateTimes( times );
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

        private void HslCurveHistory1_onCurveRangeSelect( HslControls.HslCurveHistory hslCurve, HslControls.HslMarkForeSection foreSection )
        {
            label4.Text = DateTime.Now.ToString( "HH:mm:ss" ) + "  Start:" + foreSection.StartIndex + "  End:" + foreSection.EndIndex;
            foreSection.MarkText = "这是标记的自定义的数据";
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
            hslCurveHistory1.ReferenceAxisLeft.Min = 80;
            hslCurveHistory1.RenderCurveUI( );
        }
    }
}
