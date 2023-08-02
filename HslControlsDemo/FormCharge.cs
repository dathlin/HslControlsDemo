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
            textBox1.Text = @"V3.4.0
1. HslValves: 控制阀门方向的属性PipeLineStyle修改为 GraphDirection 枚举，现在支持上下左右四种方向朝向了(升级可能不兼容，手动修改一点代码)。
2. HslCurveHistory: 历史曲线控件新增滚动到指定索引的数据，指定的时间位置的功能方法，新增RenderCurveUI指定数据索引区间，或是指定时间区间的功能方法。
3. HslCurveHistory: 方法新增参数 RenderCurveUI( bool stretchToFull = false )， 如果传入true，可以自动铺满当前的控件界面显示。
4. HslCurveHistory: 调试光标移动提示框的宽度属性DataTipWidth支持如果设置小于0，则宽度自适应，如果等于0则不显示，大于0则表示绝对像素宽度。
5. HslCurveHistory: 新增方法AddMarkCurvePeakPoint，用来增加历史曲线控件的峰值标记功能。
6. HslCurveHistory: 新增事件OnScrollChanged当滚动条操作的时候，以及挪动曲线显示的时候触发，ScrollToRight直接取消文本显示模式。
7. HslCurveHistory: 坐标轴新增是否设置为对数坐标轴的功能，可能用于对数的方式显示曲线信息。
8. 全新的曲线控件使用手册：http://www.hsltechnology.cn/Doc/HslControls
9. HslControls企业授权费：4200rmb，一次付费，终身授权，开放源代码，支持后续更新。
";
        }
    }
}
