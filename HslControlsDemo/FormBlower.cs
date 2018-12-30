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
    public partial class FormBlower : Form
    {
        public FormBlower( )
        {
            InitializeComponent( );
        }

        private void button1_Click( object sender, EventArgs e )
        {
            hslBlower8.MoveSpeed = 1f;
            hslPipeLine1.MoveSpeed = 1f;
        }

        private void button2_Click( object sender, EventArgs e )
        {
            hslBlower8.MoveSpeed = 0f;
            hslPipeLine1.MoveSpeed = 0f;
        }
    }
}
