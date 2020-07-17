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
            textBox1.Text = @"V2.4.1
1. HslChinaMap: 中国地图完善缺失的城市信息，添加了新疆的几个城市，添加了青海的自治州，添加了宁夏的地级市。
2. HslChinaMap: 新增一个画图的API方法，允许用户把自定义的image绘制到地图的指定区域，参考demo的天气预报。
3. HslGanttChart: WPF版本的控件添加一个甘特图的控件。
4. HslBattery: WPF版本的电池控件修复一个显示的bug信息。
5. HslControls企业授权费：3900rmb，一次付费，终身授权，开放源代码，支持后续更新。
";
        }
    }
}
