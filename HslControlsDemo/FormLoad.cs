using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HslCommunication.Enthernet;

namespace HslControlsDemo
{
    public partial class FormLoad : Form
    {
        public FormLoad( )
        {
            InitializeComponent( );
        }

        private void Form1_Load( object sender, EventArgs e )
        {
            this.Text += $" [v{versionCurr.ToString( )}]"; 
        }

        private void button2_Click( object sender, EventArgs e )
        {
            Hide( );
            using(FormLedDisplay form = new FormLedDisplay( ))
            {
                form.ShowDialog( );
            }
            System.Threading.Thread.Sleep( 200 );
            Show( );
        }

        private void button4_Click( object sender, EventArgs e )
        {
            Hide( );
            using (FormClock form = new FormClock( ))
            {
                form.ShowDialog( );
            }
            System.Threading.Thread.Sleep( 200 );
            Show( );
        }

        private void button5_Click( object sender, EventArgs e )
        {
            Hide( );
            using (FormCurve form = new FormCurve( ))
            {
                form.ShowDialog( );
            }
            System.Threading.Thread.Sleep( 200 );
            Show( );
        }

        private void button6_Click( object sender, EventArgs e )
        {
            Hide( );
            using (FormGaugeChart form = new FormGaugeChart( ))
            {
                form.ShowDialog( );
            }
            System.Threading.Thread.Sleep( 200 );
            Show( );
        }

        private void button7_Click( object sender, EventArgs e )
        {
            Hide( );
            using (FormGauge form = new FormGauge( ))
            {
                form.ShowDialog( );
            }
            System.Threading.Thread.Sleep( 200 );
            Show( );
        }

        private void button8_Click( object sender, EventArgs e )
        {
            Hide( );
            using (FormLanternSimple form = new FormLanternSimple( ))
            {
                form.ShowDialog( );
            }
            System.Threading.Thread.Sleep( 200 );
            Show( );
        }

        private void button9_Click( object sender, EventArgs e )
        {
            Hide( );
            using (FormPipeLine form = new FormPipeLine( ))
            {
                form.ShowDialog( );
            }
            System.Threading.Thread.Sleep( 200 );
            Show( );
        }

        private void button10_Click( object sender, EventArgs e )
        {
            Hide( );
            using (FormBottle form = new FormBottle( ))
            {
                form.ShowDialog( );
            }
            System.Threading.Thread.Sleep( 200 );
            Show( );
        }

        private void button3_Click( object sender, EventArgs e )
        {
            Hide( );
            using (FormProgress form = new FormProgress( ))
            {
                form.ShowDialog( );
            }
            System.Threading.Thread.Sleep( 200 );
            Show( );
        }

        private void button1_Click( object sender, EventArgs e )
        {
            Hide( );
            using (FormBasic form = new FormBasic( ))
            {
                form.ShowDialog( );
            }
            System.Threading.Thread.Sleep( 200 );
            Show( );
        }

        private void button11_Click( object sender, EventArgs e )
        {
            Hide( );
            using (FormPieChart form = new FormPieChart( ))
            {
                form.ShowDialog( );
            }
            System.Threading.Thread.Sleep( 200 );
            Show( );
        }

        private void linkLabel1_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            OpenWebside( "http://www.hslcommunication.cn/" );
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

        private void linkLabel2_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            using (FormDeclaration form = new FormDeclaration( ))
            {
                form.ShowDialog( );
            }
        }

        private void FormLoad_Shown( object sender, EventArgs e )
        {
            System.Threading.ThreadPool.QueueUserWorkItem( new System.Threading.WaitCallback( ThreadPoolCheckVersion ), null );
        }

        private HslCommunication.BasicFramework.SystemVersion versionCurr = new HslCommunication.BasicFramework.SystemVersion( "2.1.2" );

        private void ThreadPoolCheckVersion( object obj )
        {
            System.Threading.Thread.Sleep( 100 );
            HslCommunication.Enthernet.NetSimplifyClient simplifyClient = new HslCommunication.Enthernet.NetSimplifyClient( "118.24.36.220", 18467 );
            HslCommunication.OperateResult<HslCommunication.NetHandle, string> read = simplifyClient.ReadCustomerFromServer( 100, versionCurr.ToString() );
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

        private void button12_Click( object sender, EventArgs e )
        {
            Hide( );
            using (FormConveryer form = new FormConveryer( ))
            {
                form.ShowDialog( );
            }
            System.Threading.Thread.Sleep( 200 );
            Show( );
        }

        private void linkLabel3_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            OpenWebside( "https://github.com/dathlin/HslControlsDemo" );
        }

        private void button13_Click( object sender, EventArgs e )
        {
            Hide( );
            using (FormConveyerRollers form = new FormConveyerRollers( ))
            {
                form.ShowDialog( );
            }
            System.Threading.Thread.Sleep( 200 );
            Show( );
        }

        private void button14_Click( object sender, EventArgs e )
        {
            Hide( );
            using (FormThermometer form = new FormThermometer( ))
            {
                form.ShowDialog( );
            }
            System.Threading.Thread.Sleep( 200 );
            Show( );
        }

        private void button15_Click( object sender, EventArgs e )
        {
            Hide( );
            using (FormBlower form = new FormBlower( ))
            {
                form.ShowDialog( );
            }
            System.Threading.Thread.Sleep( 200 );
            Show( );
        }

        private void button16_Click( object sender, EventArgs e )
        {
            Hide( );
            using (FormValves form = new FormValves( ))
            {
                form.ShowDialog( );
            }
            System.Threading.Thread.Sleep( 200 );
            Show( );
        }

        private void button17_Click( object sender, EventArgs e )
        {
            Hide( );
            using (FormBattery form = new FormBattery( ))
            {
                form.ShowDialog( );
            }
            System.Threading.Thread.Sleep( 200 );
            Show( );
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Hide();
            using (FormClassifier form = new FormClassifier())
            {
                form.ShowDialog();
            }
            System.Threading.Thread.Sleep(200);
            Show();
        }

        private void button19_Click( object sender, EventArgs e )
        {
            Hide( );
            using (FormGobang form = new FormGobang( ))
            {
                form.ShowDialog( );
            }
            System.Threading.Thread.Sleep( 200 );
            Show( );
        }

        private void button20_Click( object sender, EventArgs e )
        {
            Hide( );
            using (FormTetris form = new FormTetris( ))
            {
                form.ShowDialog( );
            }
            System.Threading.Thread.Sleep( 200 );
            Show( );
        }

        private void button21_Click( object sender, EventArgs e )
        {
            Hide( );
            using (FormTetris2 form = new FormTetris2( ))
            {
                form.ShowDialog( );
            }
            System.Threading.Thread.Sleep( 200 );
            Show( );
        }

        private void button22_Click( object sender, EventArgs e )
        {
            Hide( );
            using (FormStatus form = new FormStatus( ))
            {
                form.ShowDialog( );
            }
            System.Threading.Thread.Sleep( 200 );
            Show( );
        }

        private void button23_Click( object sender, EventArgs e )
        {
            Hide( );
            using (FormTank form = new FormTank( ))
            {
                form.ShowDialog( );
            }
            System.Threading.Thread.Sleep( 200 );
            Show( );
        }

        private void button24_Click( object sender, EventArgs e )
        {
            Hide( );
            using (FormCurveHistory form = new FormCurveHistory( ))
            {
                form.ShowDialog( );
            }
            System.Threading.Thread.Sleep( 200 );
            Show( );
        }

        private void button25_Click( object sender, EventArgs e )
        {
            Hide( );
            using (FormCurveHistory2 form = new FormCurveHistory2( ))
            {
                form.ShowDialog( );
            }
            System.Threading.Thread.Sleep( 200 );
            Show( );
        }

        private void button26_Click( object sender, EventArgs e )
        {
            Hide( );
            using (FormGanttDay form = new FormGanttDay( ))
            {
                form.ShowDialog( );
            }
            System.Threading.Thread.Sleep( 200 );
            Show( );
        }

        private void btnHslChart_Click(object sender, EventArgs e)
        {
            Hide();
            using (FormChart form = new FormChart())
            {
                form.ShowDialog();
            }
            System.Threading.Thread.Sleep(200);
            Show();
        }

        private void button27_Click( object sender, EventArgs e )
        {
            Hide( );
            using (FormCurveHistory3 form = new FormCurveHistory3( ))
            {
                form.ShowDialog( );
            }
            System.Threading.Thread.Sleep( 200 );
            Show( );
        }

        private void Button28_Click( object sender, EventArgs e )
        {
            Hide( );
            using (FormWaterBox form = new FormWaterBox( ))
            {
                form.ShowDialog( );
            }
            System.Threading.Thread.Sleep( 200 );
            Show( );
        }

        private void Button29_Click( object sender, EventArgs e )
        {
            Hide( );
            using (FormFactory form = new FormFactory( ))
            {
                form.ShowDialog( );
            }
            System.Threading.Thread.Sleep( 200 );
            Show( );
        }

        private void Button30_Click( object sender, EventArgs e )
        {
            Hide( );
            using (FormPumpOne form = new FormPumpOne( ))
            {
                form.ShowDialog( );
            }
            System.Threading.Thread.Sleep( 200 );
            Show( );
        }

        private void Button31_Click( object sender, EventArgs e )
        {
            Hide( );
            using (FormBarChart form = new FormBarChart( ))
            {
                form.ShowDialog( );
            }
            System.Threading.Thread.Sleep( 200 );
            Show( );
        }

        private void LinkLabel4_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            OpenWebside( "http://bbs.hslcommunication.cn/" );
        }

        private void Button32_Click( object sender, EventArgs e )
        {
            Hide( );
            using (FormCurveHistory4 form = new FormCurveHistory4( ))
            {
                form.ShowDialog( );
            }
            System.Threading.Thread.Sleep( 200 );
            Show( );
        }

        private void Button33_Click( object sender, EventArgs e )
        {
            Hide( );
            using (FormMotor form = new FormMotor( ))
            {
                form.ShowDialog( );
            }
            System.Threading.Thread.Sleep( 200 );
            Show( );
        }

        private void Button34_Click( object sender, EventArgs e )
        {
            Hide( );
            using (FormPanel form = new FormPanel( ))
            {
                form.ShowDialog( );
            }
            System.Threading.Thread.Sleep( 200 );
            Show( );
        }

        private void LinkLabel5_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            using (HslCommunication.BasicFramework.FormSupport form = new HslCommunication.BasicFramework.FormSupport( ))
            {
                form.ShowDialog( );
            }
        }
    }
}
