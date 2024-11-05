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
            textBox1.Text = @"V3.4.3
1. HslCurveHistory: 曲线类HslCurveItem新增属性TipInfoVisiable来指示是否显示光标移动时的提示信息，使用方法为hslCurveHistory1.GetAllCurve( )[""温度""].TipInfoVisiable = false;
2. HslProgressLine: 基于线条的进度条新增属性CircularWidth用于调整粗细，属性LineCapStyle，用于调整两端的样式，圆形样式下的粗细。
3. HslCurveHistory: 修复历史曲线放大并拖动显示位置后，使用代码重新调整放大倍数时，显示Y轴偏移信息不正确的bug。
4. HslCurveHistory: 新增方法SetScaleByYAxis( float scale )可以单独调整Y轴的缩放倍率，RemoveAllCurve( )方法调用时重新初始化当前的Y轴显示偏移位置信息。
5. HslCurve: 修复实时曲线控件在曲线设置样式CurveStyle.Section下，阴影部分显示在上面的bug，原因来自Y轴基准线设置不正确。
6. 全新的曲线控件使用手册：http://www.hsltechnology.cn/Doc/HslControls
7. HslControls企业授权费：4200rmb，一次付费，终身授权，开放源代码，支持后续更新。
";
        }
    }
}
