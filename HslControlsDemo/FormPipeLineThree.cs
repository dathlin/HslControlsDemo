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
    public partial class FormPipeLineThree : FormContent
    {
        public FormPipeLineThree( )
        {
            InitializeComponent( );
        }

        private void FormPipeLine_Load( object sender, EventArgs e )
        {
            hslPipeLines = new List<HslPipeLine>( );
            hslPipeLines.Add( hslPipeLine4 );
            hslPipeLines.Add( hslPipeLine12 );
            hslPipeLines.Add( hslPipeLine13 );
            hslPipeLines.Add( hslPipeLine14 );
            hslPipeLines.Add( hslPipeLine15 );
            hslPipeLines.Add( hslPipeLine16 );
            hslPipeLines.Add( hslPipeLine17 );
            hslPipeLines.Add( hslPipeLine18 );
            hslPipeLines.Add( hslPipeLine23 );
            hslPipeLines.Add( hslPipeLine1 );

            SetMoveSpeed( 0.3f );
        }

        private List<HslPipeLine> hslPipeLines;

        private void SetMoveSpeed(float moveSpeed )
        {
            if(hslPipeLines != null)
            {
                for (int i = 0; i < hslPipeLines.Count; i++)
                {
                    if (i == 2 || i == 5)
                    {
                        hslPipeLines[i].MoveSpeed = -moveSpeed;
                    }
                    else
                    {
                        hslPipeLines[i].MoveSpeed = moveSpeed;
                    }
                }
                hslPipeLineThree12.MoveSpeed1 = moveSpeed;
                hslPipeLineThree12.MoveSpeed2 = moveSpeed;
            }
        }

        private void SetActive( bool isActive )
        {
            if (hslPipeLines != null)
            {
                for (int i = 0; i < hslPipeLines.Count; i++)
                {
                    hslPipeLines[i].PipeLineActive = isActive;
                }
            }
            hslPipeLineThree12.PipeLineActive1 = isActive;
            hslPipeLineThree12.PipeLineActive2 = isActive;
        }

        private void button1_Click( object sender, EventArgs e )
        {
            SetActive( true );
        }

        private void button2_Click( object sender, EventArgs e )
        {
            SetActive( false );
        }

        private void button3_Click( object sender, EventArgs e )
        {
            if(float.TryParse(textBox1.Text, out float moveSpeed ))
            {
                SetMoveSpeed( moveSpeed );
            }
            else
            {
                MessageBox.Show( "速度值输入错误！" );
            }
        }

        private void HslPipeLine22_Click( object sender, EventArgs e )
        {
            Control_Click( sender, e );
        }
    }
}
