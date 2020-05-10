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
    public partial class FormCurveHistory6 : FormContent
    {
        public FormCurveHistory6( )
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
            float[] steps = new float[300];
            float[] data = new float[300];
            float[] press = new float[300];
            DateTime[] times = new DateTime[300];

            for (int i = 0; i < data.Length; i++)
            {
                steps[i] = random.Next( 10 );
                data[i]  = (float)(Math.Sin( 2 * Math.PI * i / 50 ) * 40 + 120);
                times[i] = DateTime.Now.AddSeconds( i - 2000 );
                press[i] = (float)(Math.Sin( 2 * Math.PI * i / 100 ) * 0.8d + 4.1d);
            }

            // 显示出数据信息来
            Invoke( new Action( ( ) =>
            {
                 hslCurveHistory1.SetScaleByXAxis( 8f );
                 hslCurveHistory1.SetLeftCurve( "步序", steps );
                 hslCurveHistory1.SetLeftCurve( "温度", data, Color.DodgerBlue, HslControls.CurveStyle.StepLine, "{0:F1} ℃" );
                 hslCurveHistory1.SetRightCurve( "压力", press, Color.Tomato, HslControls.CurveStyle.StepLineWithoutVertical, "{0:F2} Mpa" );
                 hslCurveHistory1.SetDateTimes( times );

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
                hslCurveHistory1.ValueMinLeft = 0;
                hslCurveHistory1.ValueMaxLeft = 1500;

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
            hslCurveHistory1.SetScaleByXAxis( 4f );
            hslCurveHistory1.RenderCurveUI( );
        }

        private void button3_Click( object sender, EventArgs e )
        {
            hslCurveHistory1.SetScaleByXAxis( 8f );
            hslCurveHistory1.RenderCurveUI( );
        }

        private void button4_Click( object sender, EventArgs e )
        {
            hslCurveHistory1.SetScaleByXAxis( 16f );
            hslCurveHistory1.RenderCurveUI( );
        }

        private void hslCurveHistory1_onCurveDoubleClick( HslControls.HslCurveHistory hslCurve, int index, DateTime dateTime )
        {
            MessageBox.Show( $"Index: {index} Time:{dateTime.ToString( )}" );
        }

        private void button5_Click( object sender, EventArgs e )
        {
            if (int.TryParse( textBox2.Text, out int radius ))
            {
                hslCurveHistory1.PointsRadius = radius;
                hslCurveHistory1.RenderCurveUI( );
            }
            else
            {
                MessageBox.Show( "Input Error" );
            }
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
