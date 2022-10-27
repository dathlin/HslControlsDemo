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
            textBox1.Text = @"V3.2.0
1. HslCurve: 实时曲线的坐标轴优化重新设计，支持了颜色调整，支持了单位显示，支持了数据格式化设置（不兼容更新，升级会报错）。
2. NoBoundaryControl: 无界控件增加ResetGraphicsTransform方法，用来重置变换，配合GraphicsTransform绘制固定位置的数据。
3. HslCurveHistory: 修复辅助线曲线在某些范围下触发异常的bug，历史曲线控件及实时曲线的坐标轴的数据显示支持格式化设置。
4. HslCurveHistory: 历史曲线控件支持了当光标移动时，在每个Y轴上显示光标对应的实时值，同时可以设置IsRenderYTip属性为false来关闭这个功能。
5. Demo: 修复demo界面的流量表控件点击不显示属性的bug。
6. HslCurveHistory: 当纵轴的格式设置为 {0:E} 时，指数部分的数据自动屏蔽前面多余的0。
7. HslControls企业授权费：4200rmb，一次付费，终身授权，开放源代码，支持后续更新。
";
        }
    }
}
