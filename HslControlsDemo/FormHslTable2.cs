using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HslControls;

namespace HslControlsDemo
{
    public partial class FormHslTable2 : FormContent
    {
        public FormHslTable2( )
        {
            InitializeComponent( );
        }

        private void FormHslTable_Load( object sender, EventArgs e )
        {
            hslTable1.SetTableValue( new List<string[]>( )
            {
                new string[] { "φ30", "1000", "A类型", "80", "★★★☆" },
                new string[] { "φ100", "1000", "A类型", "20", "★★☆" },
                new string[] { "φ500", "3000", "A类型", "100", "★" },
            } );

            hslTable1.OnDrawCellTextEvent += HslTable1_OnDrawCellTextEvent;
            hslTable2.OnDrawCellTextEvent += HslTable2_OnDrawCellTextEvent;
            hslProgress.ProgressStyle = HslProgressStyle.Horizontal;
        }

        private HslProgress hslProgress = new HslProgress( );

        private void HslTable1_OnDrawCellTextEvent( Graphics g, int rowIndex, int colIndex, RectangleF rectangle, string value, StringFormat sf )
        {
            if (colIndex != 3)
            {
                // 普通的绘制方式
                hslTable1.DrawCellText( g, rowIndex, colIndex, rectangle, value, sf );
            }
            else
            {
                // 进度的特殊绘制
                hslProgress.Value = int.Parse( value );
                hslProgress.ProgressColor = hslProgress.Value >= 80 ? Color.LimeGreen : hslProgress.Value >= 40 ? Color.Orange : Color.Red;

                g.TranslateTransform( rectangle.X + 1, rectangle.Y + 3 );
                hslProgress.PaintHslControls( g, (int)(rectangle.Width - 2), (int)(rectangle.Height - 6));
                g.TranslateTransform( -rectangle.X - 1, -rectangle.Y - 2 );
            }
        }

        private void HslTable2_OnDrawCellTextEvent( Graphics g, int rowIndex, int colIndex, RectangleF rectangle, string value, StringFormat sf )
        {
            // 根据生产数量的不同，背景不一样
            if (colIndex == 2)
            {
                int number = int.Parse( value );
                if (number > 6000)
                {
                    g.FillRectangle( Brushes.OrangeRed, rectangle );
                    g.DrawString( value, hslTable2.Font, Brushes.White, rectangle, sf );
                }
                else if (number > 4000)
                {
                    g.FillRectangle( Brushes.Orange, rectangle );
                    g.DrawString( value, hslTable2.Font, Brushes.White, rectangle, sf );
                }
                else
                {
                    g.DrawString( value, hslTable2.Font, Brushes.DimGray, rectangle, sf );
                }
            }
            else
            {
                hslTable2.DrawCellText( g, rowIndex, colIndex, rectangle, value, sf );
            }

        }

        private int count = 0;
        private Random random = new Random( );

        private void button1_Click( object sender, EventArgs e )
        {
            // 新增底部数据
            count++;
            hslTable2.AddRowDown( new string[] { count.ToString( ), "A1-1-1", random.Next( 1000, 10000 ).ToString( ), "80 %", "应到 16 人，实到 15 人" } );
        }

        private void button2_Click( object sender, EventArgs e )
        {
            // 新增顶部数据
            count++;
            hslTable2.AddRowTop( new string[] { count.ToString( ), "A1-1-1", random.Next( 1000, 10000 ).ToString( ), "80 %", "应到 16 人，实到 15 人" } );
        }

        private void button4_Click( object sender, EventArgs e )
        {
            // 清楚数据
            hslTable2.SetTableValue( new List<string[]>( ) );
        }

        private void button3_Click( object sender, EventArgs e )
        {
            // 设定数据
            try
            {
                int row = int.Parse( textBox1.Text );
                int col = int.Parse( textBox2.Text );
                hslTable2.SetTableValue( row, col, textBox3.Text );
            }
            catch(Exception ex)
            {
                MessageBox.Show( "设置数据失败！" + ex.Message );
            }
        }
    }
}
