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
    public partial class FormPanelBack : FormContent
    {
        public FormPanelBack( )
        {
            InitializeComponent( );
        }

        private void FormPanel_Load( object sender, EventArgs e )
        {

        }

        private void HslPanelTextBack1_Click( object sender, EventArgs e )
        {
            Control_Click( sender, e );
        }
    }
}
