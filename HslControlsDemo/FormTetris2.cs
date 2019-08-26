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
    public partial class FormTetris2 : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public FormTetris2( )
        {
            InitializeComponent( );
        }

        private void FormTetris_Load( object sender, EventArgs e )
        {
            // 自定义游戏实现
            hslTetris1.FuncGetNewTetrisItem = GetPoints;
        }

        private Point[] GetPoints( )
        {
            if (random.Next( 100 ) < 2)
            {
                // 3%的几率出现暴击
                return new Point[] { new Point( 0, 0 ), new Point( 0, 3 ), new Point( 3, 0 ), new Point( 3, 3 ) };
            }

            if (random.Next( 100 ) < 5)
            {
                // 10%的几率出现比较难的图形
                return new Point[] { new Point( 0, 0 ), new Point( 0, 1 ), new Point( 0, 2 ), new Point( 1, 2 ), new Point( 2, 2 ), new Point( 2, 1 ), new Point( 2, 0 ), new Point( 1, 0 ) };
            }

            return list[random.Next( list.Count )];
        }

        List<Point[]> list = new List<Point[]>( )
            {
                new Point[]{new Point(0,0),new Point(0,1),new Point(1,1),new Point(1,2),new Point(2,0),new Point(2,1)},
                new Point[]{new Point(0,0),new Point(0,1),new Point(1,1),new Point(2,0),new Point(2,1)},
                new Point[]{ new Point(0, 0), new Point(0, 1), new Point(0, 2), new Point(1, 2),new Point(2, 2) },
                new Point[]{ new Point(0, 2), new Point(0, 1), new Point(1, 1), new Point(1, 0) ,new Point(0,0)},
                new Point[]{ new Point(0, 2), new Point(1, 2), new Point(1, 1), new Point(1, 0), new Point(2, 2) },
                new Point[]{ new Point(0, 0), new Point(1, 0), new Point(1, 1), new Point(2, 0), new Point(3,0) },
                new Point[]{ new Point(0, 0), new Point(0, 1), },
            };


        Random random = new Random( );
    }
}
