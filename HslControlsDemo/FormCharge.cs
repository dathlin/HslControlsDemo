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
            textBox1.Text = @"V3.3.2
1. HslProgressBar: HslProgressBar进度条控件新增属性UseSmallSquares，支持显示块状的进度条信息。
2. HslCurve: 实时曲线控件支持使用属性UpDownHeight上下边距调整，使用属性LeftRightWidth调整左右的坐标轴的边距。
3. HslLanternAlarm: 报警灯控件底部的高度支持使用属性ButtonHeight来自定义调整，小于1表示高度百分比，大于1表示绝对像素值。
4. HslBottle: 瓶子控件当顶部的文本设置为空的时候自动延展高度，底部的大小高度支持设置小于1，表示占用百分比信息。
5. HslAgvCar: 新增AGV小车的控件，暂时只能设置一个方向，但是在接下来另一个高级控件产品里支持移动，旋转动画。
6. Curve: HslCurve和HslCurveHistory曲线控件新增方法接口GetAllCurve(), 用来获取当前控件所有的曲线数据信息，从而可以进行一些更加自由的操作。
7. HslControls企业授权费：4200rmb，一次付费，终身授权，开放源代码，支持后续更新。
";
        }
    }
}
