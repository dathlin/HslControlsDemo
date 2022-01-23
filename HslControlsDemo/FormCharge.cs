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
            textBox1.Text = @"V2.8.0
1. HMILedSingle: 修改继承改自 UserControl，底色支持透明色，即使底色是渐变色。
2. HslCurve: 修复WPF版本的hslcurve实时曲线控件在IsAbscissaStrech=true时，显示右坐标轴数据时，都显示为0的bug。
3. HslBarChart: WPF版本的柱状图控件支持了动画效果，使用属性UseAnimation可以决定是否开启动画，AnimationTime设置动画时间。
4. HslLabelCombo: Winform版本新增组合标签的控件信息，可以用来显示一些值，单位的数据，支持箭头显示。
5. HslMarkText点位标记的类支持Image图片，可以在指定点位绘制图片信息，实时曲线和历史曲线都支持，显示位置也进行了优化。
6. HslCurveHistory: 历史曲线控件还支持直接添加局部图片，AddMarkImage方法增加，RemoveMarkImage方法移除。
7. HslCurveHistory: 历史曲线控件绘图优化，支持背景设置透明，例如父控件Panel设置自定义的图片，就可以实现任意的背景。
8. HslCurveHistory: 所有坐标轴的颜色可以自定义，左坐标轴和右坐标轴机制优化，注意：删除了原来的属性，导致历史曲线不兼容升级。
9. HslControls企业授权费：4200rmb，一次付费，终身授权，开放源代码，支持后续更新。
";
        }
    }
}
