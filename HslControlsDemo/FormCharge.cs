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
            textBox1.Text = @"V2.7.0
1. HslCurveHistory: 新增属性RenderInvertedTriangle，可以控制历史曲线的纵轴的倒三角是否显示。
2. HslCurveHistory: 新增属性RenderScaleInfo，用于控制是否显示缩放的倍率信息。
3. HslButton: 优化圆角代码，现在四个角分别都支持选择是否圆角操作，方便自定义按钮样式。
4. hslbadge: 新增HSL的徽章显示控件，可以用来显示一些键值数据，支持左右两部分单独使用，右部分可以当按钮使用。
5. HslCurveHistory: 删除属性ScrollEnable，新增ScaleMode缩放模式属性，支持不缩放，X轴缩放，XY轴同时缩放，先X轴后Y轴缩放。
6. HslControls企业授权费：4200rmb，一次付费，终身授权，开放源代码，支持后续更新。
";
        }
    }
}
