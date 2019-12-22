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
            textBox1.Text = @"V2.2.7
1. HslBottle: Wpf版本的控件修复BottleTag失败的bug。
2. HslSignature: 新增签名控件，支持设置颜色，背景，画笔粗细，支持winform，wpf，安卓的版本。
3. HslCircularGauge: Wpf版本新增仪表盘控件，感谢埃及朋友abdalaMask（QQ：3165336899）提供支持，详细功能见demo。
";
        }
    }
}
