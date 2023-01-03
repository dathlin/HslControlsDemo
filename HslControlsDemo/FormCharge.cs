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
            textBox1.Text = @"V3.3.1
1. HslLanternSimple: 信号灯控件优化坐标变换代码，由原先的重置坐标变换修改为恢复之前的坐标变换。
2. HslTable: 优化表格绘制，修复在没有边界情况下绘制超出范围的小问题。
3. HslCurveHistory: 历史曲线控件新增属性MarkLineVisible，用来设置是否显示移动的光标辅助线。
4. HslCurveHistory: 新增属性MarkBorderColor用来设置光标移动时，横轴纵轴等提示的消息的边框颜色。
5. HslCurveHistory: 新增属性HoverBackColor用来设置光标移动时，横轴纵轴等提示的消息的背景颜色。
6. HslChinaMap:中国地图新增九段线标记。
7. HslControls企业授权费：4200rmb，一次付费，终身授权，开放源代码，支持后续更新。
";
        }
    }
}
