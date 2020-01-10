using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HslControlsDemo
{
    public partial class FormCurve2 : FormContent
    {
        public FormCurve2( )
        {
            InitializeComponent( );
            random = new Random( );
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

        private void FormCurve_Load( object sender, EventArgs e )
        {
            timerTick = new Timer( );
            timerTick.Interval = 300;
            timerTick.Tick += TimerTick_Tick;
            timerTick.Start( );

            hslCurve1.SetCurveText( new string[] { "一", "二", "三", "四", "五", "六", "七", "八", "九", "十", "十一", "十二" } );
            hslCurve1.SetLeftCurve( "A", GetRandomData( 12, 100, 0 ), Color.Blue );
            hslCurve1.AddMarkText( new HslControls.HslMarkText( )
            {
                Index = 2,
                CurveKey = "A",
                MarkText = "很给力"
            } );
            hslCurve1.AddMarkText( new HslControls.HslMarkText( )
            {
                Index = 5,
                CurveKey = "A",
                MarkText = "不太行了",
                TextBrush = Brushes.Red
            } );
            hslCurve1.AddAuxiliaryLabel( new HslControls.AuxiliaryLable( )
            {
                LocationX = 0.6f,
                Text = "带材厚度：0.1 mm",
                TextBack = Brushes.Black,
                TextBrush = Brushes.Pink
            } );
            hslCurve1.AddAuxiliaryLabel( new HslControls.AuxiliaryLable( )
            {
                LocationX = 0.8f,
                Text = "平均值：46 mm",
                TextBack = Brushes.Black,
                TextBrush = Brushes.Pink
            } );

            hslCurve3.SetLeftCurve( "A", null, Color.DodgerBlue );
            hslCurve3.SetLeftCurve( "B", null, Color.DarkOrange );
            hslCurve3.SetLeftCurve( "C", null, Color.LimeGreen );
            
            hslCurve4.SetLeftCurve( "A", null, Color.LightSkyBlue );
            hslCurve4.SetLeftCurve( "B", null, Color.Tomato );
            hslCurve4.SetRightCurve( "C", null, Color.LimeGreen );
            hslCurve4.SetRightCurve( "D", null, Color.Orchid );
            hslCurve4.AddAuxiliaryLabel( new HslControls.AuxiliaryLable( )
            {
                LocationX = 0.65f,
                Text = "平均值：46 mm",
                TextBack = Brushes.Black,
                TextBrush = Brushes.DodgerBlue
            } );

            hslCurve5.SetLeftCurve( "A", null, Color.DodgerBlue, true );
            hslCurve5.SetLeftCurve( "B", null, Color.DarkOrange, true );
            hslCurve5.SetLeftCurve( "C", null, Color.LimeGreen, true );
            auxiliaryLable5 = new HslControls.AuxiliaryLable( )
            {
                LocationX = 0.7f,
                Text = "报警信息：6 个",
                TextBack = Brushes.DimGray,
                TextBrush = Brushes.Pink
            };
            hslCurve5.AddAuxiliaryLabel( auxiliaryLable5 );

            hslCurve6.SetLeftCurve( "A", null, Color.DodgerBlue );
            hslCurve6.SetLeftCurve( "B", null, Color.DarkOrange );
        }

        private HslControls.AuxiliaryLable auxiliaryLable5;

        private void TimerTick_Tick( object sender, EventArgs e )
        {
            count_tick++;
            float random1 = (float)(Math.Sin( 2 * Math.PI * count_tick / 30 ) * 0.5d + 0.5);
            float random2 = (float)(Math.Sin( 2 * Math.PI * count_tick / 50 ) * 0.5d + 0.5);
            float random3 = (float)(Math.Cos( 2 * Math.PI * count_tick / 80 ) * 0.5d + 0.5);

            // 模拟每隔50个点，就插入5个NaN点
            if(count_tick > 20 && count_tick % 50 < 5)
            {
                hslCurve3.AddCurveData(
                    new string[] { "A", "B", "C" },
                    new float[]
                    {
                    float.NaN,
                    float.NaN,
                    float.NaN,
                    }
                );
            }
            else
            {
                hslCurve3.AddCurveData(
                    new string[] { "A", "B", "C" },
                    new float[]
                    {
                    random1*10 + 80,
                    random2*20+50,
                    random2*10,
                    }
                );
            }

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
                // 模拟每隔100个点，就插入20个NaN点
                if (count_tick > 20 && count_tick % 100 < 20)
                {
                    hslCurve5.AddCurveData(
                        new string[] { "A", "B", "C" },
                        new float[]
                        {
                    float.NaN,
                    float.NaN,
                    float.NaN,
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
            }

            // 模拟每隔60个点，就插入10个NaN点
            if (count_tick > 20 && count_tick % 60 < 10)
            {
                hslCurve4.AddCurveData( new string[] { "A", "B", "C", "D" },
                    new float[]
                    {
                    float.NaN,
                    float.NaN,
                    float.NaN,
                    float.NaN,
                    }
                );
            }
            else
            {
                hslCurve4.AddCurveData( new string[] { "A", "B", "C", "D" },
                    new float[]
                    {
                   (float)random.NextDouble( ) * 10 + 170,
                   (float)random.NextDouble( ) * 4 + 150,
                   (float)random.NextDouble( ) * 1 + 3,
                   (float)random.NextDouble( ) * 0.4f,
                    }
                );
            }


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


        private Random random = null;
        private Timer timerTick = null;
        private int count_tick = 0;

        private void button1_Click( object sender, EventArgs e )
        {
            // 新增辅助线
            if (float.TryParse( textBox1.Text, out float value ))
            {
                hslCurve6.AddLeftAuxiliary( value, Color.Yellow );
            }
        }

        private void button2_Click( object sender, EventArgs e )
        {
            // 移除辅助线
            if (float.TryParse( textBox1.Text, out float value ))
            {
                hslCurve6.RemoveAuxiliary( value );
            }

            //hslCurve3.GetCurveItem( "A" ).MarkText[5] = "标记";
            //hslCurve3.Invalidate( );
        }


        private void button3_Click( object sender, EventArgs e )
        {
            // 清空所有曲线的数据
            hslCurve6.RemoveAllCurveData( );
        }

        private void button4_Click( object sender, EventArgs e )
        {
            SaveFileDialog fileDialog = new SaveFileDialog( );
            fileDialog.Filter = "图片|*.png";
            fileDialog.InitialDirectory = Application.StartupPath;
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                hslCurve5.SaveToBitmap( ).Save( fileDialog.FileName );
                MessageBox.Show( "保存成功!" );
            }
            fileDialog.Dispose( );
        }

        private void HslCurve1_Click( object sender, EventArgs e )
        {
            Control_Click( sender, e );
        }
    }
}
