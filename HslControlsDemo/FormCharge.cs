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
            textBox1.Text = @"V2.3.2
1. HslDialPlate: 安卓版本添加流量表控件。
2. hslcurve：实时曲线控件的样式，从是否平滑改为，线段，曲线，阶梯，阶梯不带竖线。
3. hslcurvehistory：历史曲线控件的样式，从是否平滑改为，线段，曲线，阶梯，阶梯不带竖线。
4. hslcurve：实时曲线控件增加一个属性PointsRadius，数据点的大小，默认为0，不显示，值越大，显示的数据点越大。
5. hslcurvehistory：历史曲线控件增加一个属性PointsRadius，数据点的大小，默认为0，不显示，值越大，显示的数据点越大。
";
        }
    }
}
