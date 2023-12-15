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
            textBox1.Text = @"V3.4.1
1. HslDigitalInput: 数字键盘输入控件修复当使用FormHslDigitalInput的时候，设置初始化文本，但是实际仍然还是0的bug。
2. HslConveyer: 传送带属性HslConveyerStyle新增垂直样式，设置示例：HslConveyer.ConveyerStyle = HslConveyerStyle.Vertical
3. HslArrow: 新增属性ArrowBoth，表示箭头是否应用于两头，默认为 False, 如果设置为 True 则表示两个方向都有箭头。
4. HslArrow(WPF): WPF版本的箭头也新增属性ArrowBoth
5. 全新的曲线控件使用手册：http://www.hsltechnology.cn/Doc/HslControls
6. HslControls企业授权费：4200rmb，一次付费，终身授权，开放源代码，支持后续更新。
";
        }
    }
}
