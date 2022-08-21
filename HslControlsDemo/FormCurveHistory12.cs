using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using HslCommunication.BasicFramework;

namespace HslControlsDemo
{
    public partial class FormCurveHistory12 : FormContent
    {
        public FormCurveHistory12( )
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
            // 我们假定从数据库中获取到了这些数据信息
            float[] data1 = new float[8] { float.NaN, 28.5f, 31.4f, 35.1f, 31.6f, 35.9f, 38.1f, 37.3f };   // 最高温度
            float[] data2 = new float[8] { float.NaN, 18.5f, 19.4f, 22.2f, 23.0f, 26.1f, 18.5f, 20.0f };   // 最低温度
            DateTime[] dateTimes = new DateTime[8];
            dateTimes[0] = DateTime.Now.AddDays( -7 );

            // 显示出数据信息来
            Invoke( new Action( ( ) =>
            {
                hslCurveHistory1.SetLeftCurve( "最高温度", data1, Color.DodgerBlue, HslControls.CurveStyle.Curve, "{0:F1} ℃" );
                hslCurveHistory1.SetLeftCurve( "最低温度", data2, Color.LightSkyBlue, HslControls.CurveStyle.Curve, "{0:F1} ℃" );

                for ( int i = 1; i < 8; i++)
                {
                    dateTimes[i] = DateTime.Now.AddDays( i - 7 );
                    hslCurveHistory1.AddMarkText( new HslControls.HslMarkText( )
                    {
                        Index = i,
                        CurveKey = "最高温度",
                        MarkImage = Properties.Resources.Scattered_T_Storms,
                        PositionStyle = HslControls.MarkTextPositionStyle.Up,
                        MarkTextOffect = 10
                    } );


                    // 添加一个活动的标记
                    HslControls.HslMarkForeSection active = new HslControls.HslMarkForeSection( )
                    {
                        StartIndex = i,
                        EndIndex = i,
                        Height = 0.9f,
                    };
                    active.CursorTexts.Add( "日期", DateTime.Now.AddDays( i - 7 ).ToString( "yyyy-MM-dd" ) );
                    active.CursorTexts.Add( "天气", "多云转阵雨" );

                    hslCurveHistory1.SetDateTimes( dateTimes );
                    hslCurveHistory1.AddMarkActiveSection( active );
                }

                hslCurveHistory1.RenderCurveUI( );
            } ) );
        }

        private void FormCurveHistory_Load( object sender, EventArgs e )
        {
            hslCurveHistory1.RightRemainWidth = 0;                                 // 右侧不留空白
            hslCurveHistory1.SizeChanged += HslCurveHistory1_SizeChanged;          // 窗体大小变了，立即重新设置倍率
            HslCurveHistory1_SizeChanged( hslCurveHistory1, e );

            hslCurveHistory1.DateTimeFormate = "yyyy-MM-dd\r\ndddd";
            hslCurveHistory1.HoverDateTimeFormate = "yyyy-MM-dd\r\ndddd";          // 显示日期及星期
            hslCurveHistory1.RenderCurveUI( );                                     // 这步很重要

            linkLabel1.Click += LinkLabel1_Click;
            checkBox3.CheckedChanged += CheckBox3_CheckedChanged;
        }

        private void HslCurveHistory1_SizeChanged( object sender, EventArgs e )
        {
            // 重新设置缩放倍率信息
            float scale = (hslCurveHistory1.Width - hslCurveHistory1.LeftWidth - 10) / 8;   // 因为有8个数据，所以是除以8
            hslCurveHistory1.SetScaleXOptions( new float[] { scale }, 0 );
            hslCurveHistory1.IntervalAbscissaText = (int)scale;
        }

        private Random random = new Random( );

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
