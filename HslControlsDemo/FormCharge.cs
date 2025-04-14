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
            textBox1.Text = @"V3.5.0
1. HslCurveHistory: 历史曲线控件新增 public void SetTextTip( string key, string[] data ) 方法，用来添加纯字符串信息到提示上去，可以显示任何字符串。
2. HslCurveHistory: 历史曲线控件新增事件 onCurveMouseHover , 方便外界获取到光标实时的位置及数据内容信息。
3. AuxiliaryLine: 历史曲线的辅助线类AuxiliaryLine新增枚举属性TextLocation，可以用来设置文本在不同的位置，具体教程参考官网。
4. HslCurveHistory: 历史曲线控件除了按下滚轮可以拖动曲线外，还支持了按下Ctrl键+鼠标左键来拖动曲线，方便用于没有滚轮的情况，需要注意，控件需要先获取焦点。
5. CurveStyle: 曲线样式新增PointCircle, PointTriangle, PointSquare分别为圆点，三角形，正方形，不再绘制曲线线条，只有一个一个的点。
6. HslCurveHistory: 历史曲线控件新增属性EnableMouseDoubleClickFreeze,可以手动控制是否运行双击固定光标直线标记，优化部分字体颜色。
7. 全新的曲线控件使用手册：http://www.hsltechnology.cn/Doc/HslControls
8. HslControls企业授权费：4200rmb，一次付费，终身授权，开放源代码，支持后续更新。
";
        }
    }
}
