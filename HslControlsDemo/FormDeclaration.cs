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
    public partial class FormDeclaration : Form
    {
        public FormDeclaration( )
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
                HslCommunication.BasicFramework.SoftBasic.ShowExceptionMessage( ex );
            }
        }
    }
}
