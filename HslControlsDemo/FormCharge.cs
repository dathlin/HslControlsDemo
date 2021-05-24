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
            textBox1.Text = @"V2.6.0
1. HslPipeLine: 修复管道控件在设置 EdgeColor 属性和 LineCenterColor 属性时设计界面不发生变化的bug。
2. HslCurveHistory: 优化ScrollToRight方法，在滚动条挪动到最后之前，重新计算滚动条大小，可以消除实时刷新数据时抖动的问题。
3. HslCurveHistory: 新增多个Y轴的支持，通过属性ReferenceAxis来修改，然后设置曲线时，选择参考轴，详细参考demo。
4. HslCurveHistory: 当鼠标挪动时，在底部显示的当前的时间的矩形的宽度可调节，修改 HoverDateTimeWidth ，默认100。
5. HslControls企业授权费：4200rmb，一次付费，终身授权，开放源代码，支持后续更新。
";
        }
    }
}
