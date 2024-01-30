﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HslCommunication.BasicFramework;

namespace HslControlsDemo
{
    public partial class FormCurveHistory9 : FormContent
    {
        public FormCurveHistory9( )
        {
            InitializeComponent();
        }

        private void button1_Click( object sender, EventArgs e )
        {
            if (timerEnable)
            {
                timerEnable = false;
                button1.Text = "模拟实时";
            }
            else
            {
                timerEnable = true;
                button1.Text = "停止模拟";
            }
        }

        private void ThreadReadExample1( )
        {
            int total = 400000;
            // 我们假定从数据库中获取到了这些数据信息

            for (int i = 0; i < data.Length; i++)
            {
                steps[i] = random.Next( 10 );
                data[i] = (float)(Math.Sin( 2 * Math.PI * i / 50 ) * 20 + 120);
                times[i] = DateTime.Now.AddSeconds( i - total );
                press[i] = (float)(Math.Sin( 2 * Math.PI * i / 100 ) * 0.5d + 4.1d);
            }

            // 显示出数据信息来
            Invoke( new Action( ( ) =>
            {
                hslCurveHistory1.SetLeftCurve( "步序", steps );
                hslCurveHistory1.SetLeftCurve( "温度", data, Color.DodgerBlue, HslControls.CurveStyle.Curve, "{0:F1} ℃" );
                hslCurveHistory1.SetRightCurve( "压力", press, Color.Tomato, HslControls.CurveStyle.Curve, "{0:F2} Mpa" );
                hslCurveHistory1.SetDateTimes( times );
                hslCurveHistory1.AddAuxiliaryLabel( new HslControls.AuxiliaryLable( )
                {
                    LocationX = 0.6f,
                    Text = $"今日产量：{random.Next( 10 )}个",
                    TextBack = new SolidBrush( Color.FromArgb( 10, 10, 10 ) ),
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

        private void FormCurveHistory_Load( object sender, EventArgs e )
        {
            hslCurveHistory1.AddLeftAuxiliary( 172f );

            linkLabel1.Click += LinkLabel1_Click;
            checkBox3.CheckedChanged += CheckBox3_CheckedChanged;

            hslCurveHistory1.RenderCurveUI( );   // 这步很重要
            timer = new Timer( );
            timer.Interval = 50;
            timer.Tick += Timer_Tick;
            timer.Start( );
        }

        private Random random = new Random( );
        private Timer timer;
        private bool timerEnable = false;
        private float[] steps = new float[0];
        private float[] data = new float[0];
        private float[] press = new float[0];
        private DateTime[] times = new DateTime[0];
        private int timeTick = 0;

        private void Timer_Tick( object sender, EventArgs e )
        {
            if (timerEnable)
            {
                // 把数据新增到每一个数组里，并指定最大3000个数，再多就覆盖之前的
                SoftBasic.AddArrayData( ref steps, new float[] { random.Next( 10 ) }, 3000 );
                SoftBasic.AddArrayData( ref data, new float[] { (float)(Math.Sin( 2 * Math.PI * timeTick / 50 ) * 20 + 120) }, 3000 );
                SoftBasic.AddArrayData( ref times, new DateTime[] { DateTime.Now }, 3000 );
                SoftBasic.AddArrayData( ref press, new float[] { (float)(Math.Sin( 2 * Math.PI * timeTick / 100 ) * 0.5d + 4.1d) }, 3000 );

                hslCurveHistory1.SetLeftCurve( "步序", steps );
                hslCurveHistory1.SetLeftCurve( "温度", data, Color.DodgerBlue, HslControls.CurveStyle.Curve, "{0:F1} ℃" );
                hslCurveHistory1.SetRightCurve( "压力", press, Color.Tomato, HslControls.CurveStyle.Curve, "{0:F2} Mpa" );
                hslCurveHistory1.SetDateTimes( times );
                hslCurveHistory1.SetCurveVisible( "步序", false );   // 步序不是曲线信息，不用显示出来
                if (checkBox1.Checked)
                    hslCurveHistory1.RenderCurveUI( stretchToFull: true );
                else
                    hslCurveHistory1.ScrollToRight( );
                timeTick++;
            }
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
