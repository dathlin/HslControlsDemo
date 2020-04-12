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
            textBox1.Text = @"V2.3.1
1. HslIndicator: WPF版本的控件添加指示灯控件，感谢埃及朋友支持。
2. hslcurvehistory：历史曲线控件的光标移动时X轴提示的信息支持自定义格式化操作。
3. hslcurvehistory：历史曲线控件的光标移动到边界时，x轴提示信息显示不会遮挡。
4. annotation：winform所有的控件增加设计时的注释信息，方便大家选取。
5. HslDialPlate：winform增加一个新的流量表控件。
";
        }
    }
}
