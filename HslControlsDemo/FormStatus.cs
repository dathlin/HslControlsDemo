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
    public partial class FormStatus : Form
    {
        public FormStatus( )
        {
            InitializeComponent();
            random = new Random( );
        }

        private void hslStatusManagement2_Load( object sender, EventArgs e )
        {

        }

        private Random random;

        private void button3_Click( object sender, EventArgs e )
        {
            hslStatusManagement2.RenderStyle = HslControls.HslRenderStyle.Rectangle;
        }

        private void button4_Click( object sender, EventArgs e )
        {
            hslStatusManagement2.RenderStyle = HslControls.HslRenderStyle.Ellipse;
        }

        private void button5_Click( object sender, EventArgs e )
        {
            hslStatusManagement2.RenderStyle = HslControls.HslRenderStyle.Rhombus;
        }

        private void button1_Click( object sender, EventArgs e )
        {
            hslStatusManagement2.SetColorAll( Color.FromArgb( random.Next( 256 ), random.Next( 256 ), random.Next( 256 ) ) );
        }

        private void button2_Click( object sender, EventArgs e )
        {
            hslStatusManagement2.ResetColorAll( );
        }

        private void button6_Click( object sender, EventArgs e )
        {
            if (int.TryParse( textBox1.Text, out int rowIndex ))
            {
                hslStatusManagement2.SetColorByRow( rowIndex, Color.FromArgb( random.Next( 256 ), random.Next( 256 ), random.Next( 256 ) ) );
            }
            else
            {
                MessageBox.Show( "Row Input error!" );
            }
        }

        private void button7_Click( object sender, EventArgs e )
        {
            if (int.TryParse( textBox1.Text, out int rowIndex ))
            {
                hslStatusManagement2.ResetColorByRow( rowIndex );
            }
            else
            {
                MessageBox.Show( "Row Input error!" );
            }
        }

        private void button9_Click( object sender, EventArgs e )
        {
            if (int.TryParse( textBox2.Text, out int colIndex ))
            {
                hslStatusManagement2.SetColorByCol( colIndex, Color.FromArgb( random.Next( 256 ), random.Next( 256 ), random.Next( 256 ) ) );
            }
            else
            {
                MessageBox.Show( "Col Input error!" );
            }
        }

        private void button8_Click( object sender, EventArgs e )
        {
            if (int.TryParse( textBox2.Text, out int colIndex ))
            {
                hslStatusManagement2.ResetColorByRow( colIndex );
            }
            else
            {
                MessageBox.Show( "Col Input error!" );
            }
        }

        private void button11_Click( object sender, EventArgs e )
        {
            if(int.TryParse( textBox3.Text, out int rowIndex ) && int.TryParse( textBox4.Text, out int colIndex ))
            {
                hslStatusManagement2.SetColorByLocation( rowIndex, colIndex, Color.FromArgb( random.Next( 256 ), random.Next( 256 ), random.Next( 256 ) ) );
            }
            else
            {
                MessageBox.Show( "Input error!" );
            }
        }

        private void button10_Click( object sender, EventArgs e )
        {
            if (int.TryParse( textBox3.Text, out int rowIndex ) && int.TryParse( textBox4.Text, out int colIndex ))
            {
                hslStatusManagement2.ResetColorByLocation( rowIndex, colIndex );
            }
            else
            {
                MessageBox.Show( "Input error!" );
            }
        }

        private void button12_Click( object sender, EventArgs e )
        {
            if (int.TryParse( textBox5.Text, out int offect ))
            {
                hslStatusManagement2.SpacingOffect = offect;
            }
            else
            {
                MessageBox.Show( "offect Input error!" );
            }
        }

        private void FormStatus_Load( object sender, EventArgs e )
        {
            Inni();

            SetExample();

        }

        #region 示例

        private void SetExample( )
        {
            byte[] buffer = new byte[hslStatusManagement6.RowCount * hslStatusManagement6.ColCount];
            random.NextBytes(buffer);
            hslStatusManagement6.SetColorAll(buffer.Select(new Func<byte, Color>(GetColorFromValue)).ToArray());
        }

        private Color GetColorFromValue( byte value )
        {
            if (value < 50)
            {
                return Color.FromArgb(224, 224, 224);
            }
            else if (value < 100)
            {
                return Color.FromArgb(198, 228, 139);
            }
            else if (value < 150)
            {
                return Color.FromArgb(123, 201, 111);
            }
            else if (value < 200)
            {
                return Color.FromArgb(35, 154, 59);
            }
            else
            {
                return Color.FromArgb(25, 97, 39);
            }
        }

        #endregion

        #region 跑马灯示例

        private Timer timer;
        private Point activePoint = new Point(0, 0);

        private void Inni( )
        {
            timer = new Timer();
            timer.Interval = 60;
            timer.Tick += Timer_Tick;
            timer.Start();
            hslStatusManagement5.SetColorByLocation(activePoint, Color.DodgerBlue);
        }

        private void Timer_Tick( object sender, EventArgs e )
        {
            // 先判断能否往右
            if(activePoint.Y + 1 < hslStatusManagement5.ColCount && activePoint.X == 0)
            {
                hslStatusManagement5.ResetColorByLocation(activePoint);
                activePoint.Y++;
                hslStatusManagement5.SetColorByLocation(activePoint, Color.DodgerBlue);
                return;
            }

            // 判断能否往下
            if(activePoint.X + 1 < hslStatusManagement5.RowCount && activePoint.Y == hslStatusManagement5.ColCount - 1)
            {
                hslStatusManagement5.ResetColorByLocation(activePoint);
                activePoint.X++;
                hslStatusManagement5.SetColorByLocation(activePoint, Color.DodgerBlue);
                return;
            }

            // 判断能否往左
            if (activePoint.Y - 1 >= 0 && activePoint.X == hslStatusManagement5.RowCount - 1)
            {
                hslStatusManagement5.ResetColorByLocation(activePoint);
                activePoint.Y--;
                hslStatusManagement5.SetColorByLocation(activePoint, Color.DodgerBlue);
                return;
            }

            // 判断能否往上
            if (activePoint.X - 1 >= 0 && activePoint.Y == 0)
            {
                hslStatusManagement5.ResetColorByLocation(activePoint);
                activePoint.X--;
                hslStatusManagement5.SetColorByLocation(activePoint, Color.DodgerBlue);
            }
        }
        


        #endregion
    }
}
