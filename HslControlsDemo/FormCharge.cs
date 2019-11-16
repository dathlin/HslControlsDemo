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
            textBox1.Text = @"V2.2.5
1. 实时曲线的控件支持曲线中断功能，新增数据的时候，添加 float.NaN 即可。
2. 历史的控件支持曲线中断功能，初始化曲线数据的时候，添加 float.NaN 即可。
3. wpf版本新增一个已经在winform上存在的控件，分类器控件。
";
        }
    }
}
