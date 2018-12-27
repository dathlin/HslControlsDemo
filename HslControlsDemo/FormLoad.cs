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


        private void ThreadPoolCheckVersion( object obj )
        {
            System.Threading.Thread.Sleep( 100 );
            HslCommunication.Enthernet.NetSimplifyClient simplifyClient = new HslCommunication.Enthernet.NetSimplifyClient( "118.24.36.220", 18467 );
            HslCommunication.OperateResult<HslCommunication.NetHandle, string> read = simplifyClient.ReadCustomerFromServer( 100, "1.0.3" );
            if (read.IsSuccess)
            {
                HslCommunication.BasicFramework.SystemVersion version = new HslCommunication.BasicFramework.SystemVersion( read.Content2 );
                if (version > new HslCommunication.BasicFramework.SystemVersion( "1.0.3" ))
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
    }
}
