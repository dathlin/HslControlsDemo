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
            textBox1.Text = @"V2.5.4
1. HslCurveHistory: 底部的高度部分改为 ButtomHeight ，增加专门的 ScrollHeight 可以设置滚动条的高度，这样X轴时间可以有空间多行显示。
2. HslCurveHistory: 使用了局部切片绘制的技术，大大提高了大数据量的绘制性能，目前测试10条曲线，每条10万点。
3. HslCurveHistory: 支持使用按压滚轮来对曲线进行左右移动，鼠标中间滚轮按下，移动即可平滑左右移动，直到松开为止。
4, HslCurveHistory: 横轴的时间格式化不依赖系统设置，可以随意的根据自己的需求格式化。
5. HslCurveHistory: 当曲线放大15倍以上时，曲线上的点位信息会显示出来，当然你也可以强制 PointsRadius 为0，不显示。
6. HslControls企业授权费：4200rmb，一次付费，终身授权，开放源代码，支持后续更新。
";
        }
    }
}
