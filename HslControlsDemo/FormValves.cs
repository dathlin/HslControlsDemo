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
    public partial class FormValves : FormContent
    {
        public FormValves( )
        {
            InitializeComponent( );
        }

        private void button1_Click( object sender, EventArgs e )
        {
            // 阀门开
            hslPipeLine6.MoveSpeed = 0.3f;
            hslValves6.EdgeColor = Color.ForestGreen;
        }

        private void button2_Click( object sender, EventArgs e )
        {
            // 阀门关
            hslPipeLine6.MoveSpeed = 0.0f;
            hslValves6.EdgeColor = Color.Red;
        }

        private void HslValves1_Click( object sender, EventArgs e )
        {
            Control_Click( sender, e );
        }

		private void FormValves_Load( object sender, EventArgs e )
		{
		}

	}
}
