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
    public partial class FormHslCoolFan : FormContent
    {
        public FormHslCoolFan( )
        {
            InitializeComponent( );
        }

        private void hslCoolFan1_Click( object sender, EventArgs e )
        {
            Control_Click( sender, e );
        }
    }
}
