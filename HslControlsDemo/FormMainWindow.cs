using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HslControlsDemo
{
    public partial class FormMainWindow : Form
    {
        public FormMainWindow( )
        {
            InitializeComponent( );
        }


        private void OpenWebside( string url )
        {
            try
            {
                System.Diagnostics.Process.Start( url );
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message );
            }
        }
        private void FormMainWindow_Load( object sender, EventArgs e )
        {
            dockPanel1.Theme = vS2015BlueTheme1;
            propertySetting = new FormPropertySetting( );


            treeView1.ExpandAll( );
            treeView1.MouseDoubleClick += TreeView1_MouseDoubleClick;

            // propertySetting.Show( dockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.DockRight );
            官网ToolStripMenuItem.Click += 官网ToolStripMenuItem_Click;
            论坛ToolStripMenuItem.Click += 论坛ToolStripMenuItem_Click;
            demo地址ToolStripMenuItem.Click += Demo地址ToolStripMenuItem_Click;
            赞助说明ToolStripMenuItem.Click += 赞助说明ToolStripMenuItem_Click;
            wpfDemoToolStripMenuItem.Click += WpfDemoToolStripMenuItem_Click;


            this.Text += $" [v{versionCurr.ToString( )}]";
            System.Threading.ThreadPool.QueueUserWorkItem( new System.Threading.WaitCallback( ThreadPoolCheckVersion ), null );

            FormContent form = new FormCharge( );
            form.Show( dockPanel1 );
        }



        private HslCommunication.BasicFramework.SystemVersion versionCurr = new HslCommunication.BasicFramework.SystemVersion( "2.3.2" );

        private void ThreadPoolCheckVersion( object obj )
        {
            System.Threading.Thread.Sleep( 100 );
            HslCommunication.Enthernet.NetSimplifyClient simplifyClient = new HslCommunication.Enthernet.NetSimplifyClient( "118.24.36.220", 18467 );
            HslCommunication.OperateResult<HslCommunication.NetHandle, string> read = simplifyClient.ReadCustomerFromServer( 100, versionCurr.ToString( ) );
            if (read.IsSuccess)
            {
                HslCommunication.BasicFramework.SystemVersion version = new HslCommunication.BasicFramework.SystemVersion( read.Content2 );
                if (version > versionCurr)
                {
                    // 有更新
                    Invoke( new Action( ( ) =>
                    {
                        if (MessageBox.Show( "服务器有新版本：" + read.Content2 + Environment.NewLine + "是否启动更新？", "检测到更新", MessageBoxButtons.YesNo ) == DialogResult.Yes)
                        {
                            try
                            {
                                System.Diagnostics.Process.Start( Application.StartupPath + "\\软件自动更新.exe" );
                                System.Threading.Thread.Sleep( 50 );
                                Close( );
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show( "更新软件丢失，无法启动更新： " + ex.Message );
                            }
                        }
                    } ) );
                }
            }
        }

        private void WpfDemoToolStripMenuItem_Click( object sender, EventArgs e )
        {
            try
            {
                System.Diagnostics.Process.Start( System.IO.Path.Combine( Application.StartupPath, "HslControlsWpf.exe" ) );
            }
            catch
            {
                MessageBox.Show( "启动wpf版本的程序失败！程序不存在，或是权限错误！" );
            }
        }

        private void 赞助说明ToolStripMenuItem_Click( object sender, EventArgs e )
        {
            OpenWebside( "http://www.hslcommunication.cn/Cooperation" );
        }

        private void Demo地址ToolStripMenuItem_Click( object sender, EventArgs e )
        {
            OpenWebside( "https://github.com/dathlin/HslControlsDemo" );
        }

        private void 论坛ToolStripMenuItem_Click( object sender, EventArgs e )
        {
            OpenWebside( "http://bbs.hslcommunication.cn" );
        }
        private void 官网ToolStripMenuItem_Click( object sender, EventArgs e )
        {
            OpenWebside( "http://www.hslcommunication.cn" );
        }

        private FormPropertySetting propertySetting;

        private void 属性窗口ToolStripMenuItem_Click( object sender, EventArgs e )
        {
            if (propertySetting == null || propertySetting.IsDisposed) propertySetting = new FormPropertySetting( );
            propertySetting.Show( dockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.DockRight );
        }
        private void TreeView1_MouseDoubleClick( object sender, MouseEventArgs e )
        {
            TreeNode treeNode = treeView1.SelectedNode;
            if (treeNode == null) return;

            FormContent form = GetFormByName( treeNode.Text );
            if (form == null) return;
            if (propertySetting != null)
            {
                form.OnControlSelected += new Action<object>( m => propertySetting?.SetControlRender( m ) );
            }
            form.Show( dockPanel1 );
        }

        private FormContent GetFormByName( string name )
        {
            switch (name)
            {
                case "常用控件": return new FormBasic( );
                case "进度条": return new FormProgress( );
                case "进度条2": return new FormProgressColorful( );
                case "数码管": return new FormLedDisplay( );
                case "时钟": return new FormClock( );
                case "管道线": return new FormPipeLineTest( );
                case "瓶子控件": return new FormBottle( );
                case "信号灯": return new FormLanternSimple( );
                case "传送带": return new FormConveryer( );
                case "滚筒传送带": return new FormConveyerRollers( );
                case "温度计": return new FormThermometer( );
                case "鼓风机": return new FormBlower( );
                case "阀门": return new FormValves( );
                case "电池": return new FormBattery( );
                case "分类器": return new FormClassifier( );
                case "状态集": return new FormStatus( );
                case "电机": return new FormMotor( );
                case "容器1": return new FormPanel( );
                case "容器2": return new FormPanelBack( );
                case "甘特图": return new FormGanttDay( );
                case "水箱": return new FormWaterBox( );
                case "厂房": return new FormFactory( );
                case "泵": return new FormPumpOne( );
                case "看板标题": return new FormHslTitle( );
                case "HMI信号灯": return new FormHMILedSingle( );
                case "双叶泵": return new FormVacuumPump( );
                case "移动文本": return new FormMoveText( );
                case "数字键盘": return new FormDigitalInput( );
                case "冷却风扇": return new FormHslCoolFan( );
                case "手动签名": return new FormSignature( );
                case "袋式除尘": return new FormHslBagFilter( );
                case "卡车": return new FormHslTruck( );
                // 曲线
                case "实时曲线": return new FormCurve( );
                case "实时曲线中断": return new FormCurve2( );
                case "实时曲线阶梯": return new FormCurve3( );
                case "历史曲线暗": return new FormCurveHistory( );
                case "历史曲线亮": return new FormCurveHistory2( );
                case "历史曲线自定义": return new FormCurveHistory4( );
                case "历史曲线同步": return new FormCurveHistory3( );
                case "历史曲线中断": return new FormCurveHistory5( );
                case "历史曲线阶梯": return new FormCurveHistory6( );
                // 图表
                case "柱状图": return new FormBarChart( );
                case "饼图": return new FormPieChart( );
                case "综合图表": return new FormChart( );
                case "仪表盘1": return new FormGauge( );
                case "仪表盘2": return new FormGaugeChart( );
                case "流量表": return new FormHslDialPlate( );
                // 机床
                case "加工中心": return new FormCncCenter( );
                case "数控机床": return new FormMachineCenter( );
                    // 游戏
                case "五子棋": return new FormGobang( );
                case "俄罗斯方块正常版": return new FormTetris( );
                case "俄罗斯方块变态版": return new FormTetris2( );
                case "坦克大战": return new FormTank( );
                    // 测试
                case "管道测试": return new FormPipeLine( );
                default: return null;
            }
        }

    }
}
