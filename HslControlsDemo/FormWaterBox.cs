using HslControls;
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
    public partial class FormWaterBox : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public FormWaterBox( )
        {
            InitializeComponent( );

            hslPipeLines.Add( hslPipeLine1 );
            hslPipeLines.Add( hslPipeLine2 );
            hslPipeLines.Add( hslPipeLine3 );
        }

        private void FormWaterBox_Load( object sender, EventArgs e )
        {
            for (int i = 0; i < hslPipeLines.Count; i++)
            {
                hslPipeLines[i].MoveSpeed = 0.2f;
            }
            timer.Interval = 600;
            timer.Tick += Timer_Tick;
            timer.Start( );
        }

        private void Timer_Tick( object sender, EventArgs e )
        {
            if (hslWaterBox5.Value == 100)
            {
                hslWaterBox5.Value = 0;
                return;
            }

            hslWaterBox5.Value++;
        }

        private Timer timer = new Timer( );
        private List<HslPipeLine> hslPipeLines = new List<HslPipeLine>( );


    }
}
