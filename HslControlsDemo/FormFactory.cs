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
    public partial class FormFactory : FormContent
    {
        public FormFactory( )
        {
            InitializeComponent( );
        }

        private void HslFactory4_Click( object sender, EventArgs e )
        {
            Control_Click( sender, e );
        }
    }
}
