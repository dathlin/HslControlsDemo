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
            textBox1.Text = @"V2.9.0
1. HslPieChart: 饼图控件的布局调整为自动居中，新增两个属性用于控制饼图的图形效果，StartAngle起始角度，RotateDirection数据旋转方向，边框颜色可修改。
2. HslBadge: 修复徽章控件dock样式为fill时，导致绘制失败，不显示图形的bug。
3. HslBarChart: 柱状图控件支持同时显示多种柱状图信息，方便进行对比，比如上周的每天数据，和本周的每天数据的对比操作，wpf版本的也进行了更新支持。
4. HslCurveHistory: 曲线样式新增截面样式，也就是曲线下方的区域使用透明的曲线颜色填充，实时曲线和历史曲线均支持。
5. 个人赞助240加入VIP群，获得激活码激活后有效时间从1年调整为3年。
6. HslControls企业授权费：4200rmb，一次付费，终身授权，开放源代码，支持后续更新。
";
        }
    }
}
