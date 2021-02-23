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
            textBox1.Text = @"V2.5.5
1. HslCurveHistory: 清空曲线的数据的方法里复位当前的滚动条位置。
2. HslCurveHistory: 修复数量量在20万个以上，放大倍数在32倍时，部分的图形不限制的bug。
3. HslCurveHistory: 修复在20万数据量以上，进行放大缩小时，滚动条跳变位置不正确的bug。
4. HslCurveHistory: 曲线样式增加点点线，虚线，长虚线，以及对应的曲线版本。也适用于HslCurve实时曲线，wpf版本的实时曲线。
5. HslControls企业授权费：4200rmb，一次付费，终身授权，开放源代码，支持后续更新。
";
        }
    }
}
