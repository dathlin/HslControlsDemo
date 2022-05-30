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
            textBox1.Text = @"V3.0.0
1. HslCurveHistory: 在历史曲线控件双击固定光标后，鼠标移出界面，固定的光标线现在仍然显示，方便截图等操作。
2. HslCurveHistory: X轴坐标显示的文本及光标移动显示的X轴文本消息高度自适应，文本对齐为中间对齐。
3. HslCurveHistory: 光标移动时，显示曲线名称及值的框框，修复往上移动时造成出届导致数据显示不全的bug。移动到超出界限时，自动固定位置
4. HslCurveHistory: 新增属性RightRemainWidth用来设置当前的曲线控件右侧的预留的空白宽度信息，像素为单位，默认200
5. HslCurveHistory: X轴和Y轴的滚轮缩放的等级可以自定义控制，通过方法SetScaleXOptions及SetScaleYOptions实现，例如缩放1，2，3，4，5倍
6. HslCurveHistory: 代码优化，缩小倍率小于10倍以下时，绘制选择速度优先，当数据量很多时，自动选择绘制的区域进行绘制，当10万级数据量时，无论怎么缩放依然带来丝滑般的体验。
7. HslCurveHistory: 历史曲线控件的方法SaveToBitmap新增一个可选的参数，是否输出当前显示界面，也就是说现在支持仅保存当前的显示界面的功能，类似截屏。
8. HslCurveHistory: 支持了基于曲线区间的范围的背景标记功能，实例化曲线控件的CurveRanges对象即可，支持多个区间范围的显示。如果需要移除，直接设置为NULL
9. HslBarChart: 设置柱状图数据类型支持double类型，修复double类型时，最大值计算错误的bug，新增属性IsAoordinateRoundInt，如果设置为Ture, Y轴自动使用整数。Wpf版本柱状图同步更新
10. HslControls企业授权费：4200rmb，一次付费，终身授权，开放源代码，支持后续更新。
";
        }
    }
}
