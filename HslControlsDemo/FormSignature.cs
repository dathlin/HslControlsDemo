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
    public partial class FormSignature : FormContent
    {
        public FormSignature( )
        {
            InitializeComponent( );
        }

        private void HslFactory4_Click( object sender, EventArgs e )
        {
            Control_Click( sender, e );
        }

        private void button1_Click( object sender, EventArgs e )
        {
            hslSignature4.ClearSign( );
        }

        private void button2_Click( object sender, EventArgs e )
        {
            SaveFileDialog sfd = new SaveFileDialog( );
            sfd.Filter = "图片文件（*.bmp）|*.bmp";
            sfd.FilterIndex = 1;
            sfd.FileName = "Sign.bmp";
            sfd.RestoreDirectory = true;
            if (sfd.ShowDialog( ) == DialogResult.OK)
            {
                hslSignature4.SaveBitmap( sfd.FileName );
            }
            else
            {
                MessageBox.Show( "取消保存" );
                return;
            }
        }
    }
}
