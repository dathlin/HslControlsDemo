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
            textBox1.Text = @"V2.2.8
1. HslDigitalInput: 数字键盘控件修复一些逻辑bug，增加掩码功能，这样就可以用于密码输入。
2. HslCircularGauge: wpf版本的仪表盘控件优化，动画效果优化，更加流畅。
3. wpf: Wpf版本新增七段数码管和十六段数码管的控件，感谢埃及朋友abdalaMask（QQ：3165336899）提供支持，详细功能见demo。
4. wpf: Wpf版本角度仪表盘控件，感谢埃及朋友abdalaMask（QQ：3165336899）提供支持，详细功能见demo。
";
        }
    }
}
