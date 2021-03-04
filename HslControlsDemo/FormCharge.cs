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
            textBox1.Text = @"V2.5.6
1. HslButton: 圆角支持0，按钮选中的颜色可以设置，通过SelectColor来设置。
2. HslCurveHistory: 在数据量很大的时候，滚轮移动曲线时，修复滚动条跳变0的bug。
3. HslCurveHistory: 修复在40万数据量以上，32倍放大条件下，X轴坐标轴消失的BUG。
4. HslCurveHistory: 曲线控件右上角显示了缩放的倍数，滚动条支持点击任意位置快速跳转曲线。
5. HslCurveHistory: 优化多个曲线控件同步动作的功能，只需要调用一个方法：SetSyncHslCurveHistory 就可以跟随另一个曲线控件动作。
6. HslControls企业授权费：4200rmb，一次付费，终身授权，开放源代码，支持后续更新。
";
        }
    }
}
