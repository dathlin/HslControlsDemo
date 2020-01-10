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
    public partial class FormPanel : FormContent
    {
        public FormPanel( )
        {
            InitializeComponent( );
        }

        private void FormPanel_Load( object sender, EventArgs e )
        {

            hslBarChart1.SetDataSource( new int[] { 1, 2, 4, 0, 3 }, new string[] { "周一", "周二", "周三", "周四", "周五" } );
            hslBarChart2.SetDataSource( new int[] { 1, 2, 4, 0, 3 }, new string[] { "周一", "周二", "周三", "周四", "周五" } );
        }

        private void HslPanelText1_Click( object sender, EventArgs e )
        {
            Control_Click( sender, e );
        }
    }
}
