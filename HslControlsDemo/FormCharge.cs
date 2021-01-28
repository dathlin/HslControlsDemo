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
            textBox1.Text = @"V2.5.2
1. HslLanternAlarm: 修复IsAlarm设置为false的时候，信号灯颜色可能仍然为报警色的bug。
2. HslCurve和HslCurveHistory: 曲线控件的添加辅助线的方法返回辅助线对象本身，方便动态修改这个辅助线信息。
3. HslCurveHistory: 当鼠标点击曲线名称隐藏曲线的操作的时候，增加隐藏提示信息曲线数据值的操作。
4. HslCurve: 修复在多次 SetCurve 的时候，数组长度不一致的情况导致绘图异常的bug。
5. WPF:  新增HslThermometer 温度计控件信息。
6. HslHistoryCureve: onCurveRangeSelect事件签名修改，可以动态修改一些显示的信息。
7. HslControls企业授权费：4000rmb，一次付费，终身授权，开放源代码，支持后续更新。
";
        }
    }
}
