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
    }
}
