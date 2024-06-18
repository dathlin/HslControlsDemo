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
            textBox1.Text = @"V3.4.2
1. HslCurveHistory: 修复历史曲线控件在某些特殊的情况下缩小化再复原导致意外的bug。
2. HslMarkText: 文本标记类新增属性CenterPointSize控制中心点大小，新增属性FontSize可以控制文本字体大小。
3. HslCurveHistory: 历史曲线控件新增属性CurveNameHideAlpha控制曲线隐藏时标题的透明度情况。
4. HslCurve: 历史曲线的样式新增PointMark，曲线完全隐藏，但是可以用来实现任意位置的数据标签标记，具体看文档。优化了文本标签遍历的代码。
5. HslSwitch: 开关的控件新增属性ReadOnly，默认false，设置为true时，不能通过鼠标来操作开关。
6. HslStatusManagement: 新增事件OnStatusClick，可以方便的获取到鼠标点击哪个行列，新增SetMark方法设置标记文本。
7. HslStatusManagement: 状态集控件新增方法StopRendering和ContinueRendering，在组合设置颜色时，可以避免中途刷新，加快性能。
8. FormPortraitSelect: 新增一个头像选择的窗体，从hslcommunication移植二来。
9. 全新的曲线控件使用手册：http://www.hsltechnology.cn/Doc/HslControls
10. HslControls企业授权费：4200rmb，一次付费，终身授权，开放源代码，支持后续更新。
";
        }
    }
}
