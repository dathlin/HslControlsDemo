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
            textBox1.Text = @"V3.1.0
1. HslProgressBar: 新增一个基于系统进度条演变来的进度条，支持显示文本，自定义文本，支持设置进度条的颜色信息。
2. HslBarChart: 饼图控件在调用SetDataSource方法的参数，修复输入null结果报异常的bug。
3. HslTitle: 看板标题控件的左右侧文字支持单独的设置颜色，文字渐变色效果微调，背景的渐变支持设置变化比例，参数属性：LeftRightCenterColorScale。
4. HslCurveHistory: 历史曲线控件在绘制选择区域范围的时间差时，根据时间差信息，自动匹配不同的单位显示。
5. HslCurveHistory: 增加图片绘制时，可选是否进行缩放，点位标记使用显示图片时，图片位置的偏移量可以自由设定。
6. HslCurveHistory: 修复在某些特殊情况下触发空对象的bug，Demo程序里新增一个天气预报的应用示例，并且缩放倍率自适应。
7. HslCurveHistory: 历史曲线控件支持隐藏额外坐标轴的显示，可以使用属性IsOtherAxisHide控制，或是界面上滚动条左边的区域点击控制。
8. HslCurveHistory: 历史曲线控件支持当Y轴放大到4倍以上时，Y轴的刻度线自动进行扩充倍数显示。
9. HslControls企业授权费：4200rmb，一次付费，终身授权，开放源代码，支持后续更新。
";
        }
    }
}
