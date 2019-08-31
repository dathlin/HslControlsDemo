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
    public partial class FormMoveText : FormContent
    {
        public FormMoveText( )
        {
            InitializeComponent( );
        }

        private void FormMoveText_Load( object sender, EventArgs e )
        {

        }

        private void HslMoveText1_Click( object sender, EventArgs e )
        {
            Control_Click( sender, e );
        }
    }
}
