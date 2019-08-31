using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HslControls;

namespace HslControlsDemo
{
    public partial class FormBottle : FormContent
    {
        public FormBottle( )
        {
            InitializeComponent( );

            hslPipeLines.Add( hslPipeLine1 );
            hslPipeLines.Add( hslPipeLine2 );
            hslPipeLines.Add( hslPipeLine3 );
        }

        private void button1_Click( object sender, EventArgs e )
        {
            hslBottle1.Value = random.NextDouble( ) * 100;
            hslBottle2.Value = random.NextDouble( ) * 100;
            hslBottle3.Value = random.NextDouble( ) * 100;
            hslBottle4.Value = random.NextDouble( ) * 100;
            hslBottle5.Value = random.NextDouble( ) * 100;
            hslBottle6.Value = random.NextDouble( ) * 100;
            hslBottle7.Value = random.NextDouble( ) * 100;
            hslBottle8.Value = random.NextDouble( ) * 100;

            for (int i = 0; i < hslPipeLines.Count; i++)
            {
                hslPipeLines[i].MoveSpeed = 0.2f;
            }
        }

        private List<HslPipeLine> hslPipeLines = new List<HslPipeLine>( );
        private Timer timer = new Timer( );
        private Random random = new Random( );

        private void FormBottle_Load( object sender, EventArgs e )
        {
            timer.Interval = 600;
            timer.Tick += Timer_Tick;
            timer.Start( );
        }

        private void Timer_Tick( object sender, EventArgs e )
        {
            if(hslBottle1.Value == 0)
            {
                return;
            }


            if (hslBottle1.Value >= 1)
            {
                hslBottle1.Value--;
            }
            else
            {
                hslBottle1.Value = 0;
            }

            hslBottle9.Value += 0.3d;
            if (hslBottle9.Value >= 100) hslBottle9.Value = 0;

            if (hslBottle1.Value == 0)
            {
                for (int i = 0; i < hslPipeLines.Count; i++)
                {
                    hslPipeLines[i].MoveSpeed = 0;
                }
            }
        }

        private void HslBottle8_Click( object sender, EventArgs e )
        {
            Control_Click( sender, e );
        }
    }
}
