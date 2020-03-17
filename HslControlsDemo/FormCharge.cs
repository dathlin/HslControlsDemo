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
            textBox1.Text = @"V2.3.0
1. HslStatusManagement：对每个的点阵信息，支持设置消息提示，当光标挪动到点阵上，提示信息文本。
2. HslTruck: 新增一个卡车控件，支持两种状态，方向变换，升降功能，目前仅支持winform。
";
        }
    }
}
