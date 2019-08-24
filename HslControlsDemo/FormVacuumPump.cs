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
    public partial class FormVacuumPump : Form
    {
        public FormVacuumPump( )
        {
            InitializeComponent( );
        }

        private void FormVacuumPump_Load( object sender, EventArgs e )
        {
            propertyGrid1.SelectedObject = hslVacuumPump7;
        }
    }
}
