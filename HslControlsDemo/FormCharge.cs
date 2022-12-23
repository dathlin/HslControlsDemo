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
    public partial class FormCharge : FormContent
    {
        public FormCharge( )
        {
            InitializeComponent( );
        }

        private void LinkLabel1_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            try
            {
                System.Diagnostics.Process.Start( linkLabel1.Text );
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message );
            }
        }

        private void FormCharge_Load( object sender, EventArgs e )
        {
            textBox1.Text = @"V3.3.0
1. HslGobang: 修复五子棋点击右侧边界发生索引超出范围的异常bug。
2. HslTable: 修复HslTable控件默认背景色和实际背景色不一致的bug，在某些情况下，始终显示白色底色。
3. HslConveyer: MoveSpeed增加注释值范围为 -9 ~ 9，修复设置巨大的情况下，绘制发生偏移的bug。
4. HslDialPlate: HslDialPlate仪表盘控件支持显示更小刻度的信息，如果设置透明色即不显示刻度。
5. HslGauge: HslGauge仪表盘控件优化，刻度显示分为10个挡。
6. HslHorizonBarChart: 增加横向的柱状图控件，支持设置每个数据的颜色，显示的格式化文本信息。
7. HslControls: 几乎所有的控件都支持了方法接口PaintHslControls( Graphics g, int width, int height)，可以自行绘制到任意的其他地方或是打印。
8. HslControls企业授权费：4200rmb，一次付费，终身授权，开放源代码，支持后续更新。
";
        }
    }
}
