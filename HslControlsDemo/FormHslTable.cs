using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HslControlsDemo
{
    public partial class FormHslTable : FormContent
    {
        public FormHslTable( )
        {
            InitializeComponent( );
        }

        private void FormHslTable_Load( object sender, EventArgs e )
        {
            hslTable1.SetTableValue( new List<string[]>( )
            {
                new string[] { "φ30", "1000", "A类型", "800", "" },
                new string[] { "φ100", "1000", "A类型", "800", "" },
                new string[] { "φ500", "3000", "A类型", "1000", "" },
            } );

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
