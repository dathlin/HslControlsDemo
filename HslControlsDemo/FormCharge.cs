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
            textBox1.Text = @"V2.5.3
1. HslCurve: 修复实时曲线当 IntervalAbscissaText 属性设置为负数时，会导致 vs 崩溃的bug。
2. HslLedDisplay: LED显示控件的小数点大小支持动态设置，默认为2。
3. HslCurveHistory: 历史曲线控件大优化，四个边宽度可调整，滚动条重新设计，支持超大数据量，占内存低。
4. HslCurveHistory: SetCurveVisible支持设置曲线可见，设置曲线及提示是否隐藏。
5. HslCurveHistory: 支持滚轮的放大缩小，支持横向的放大缩小，可以手动设置禁用滚轮。
6. HslControls企业授权费：4200rmb，一次付费，终身授权，开放源代码，支持后续更新。
";
        }
    }
}
