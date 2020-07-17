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
	public partial class FormNoBoundaryControl : FormContent
	{
		public FormNoBoundaryControl( )
		{
			InitializeComponent( );
		}

		private void FormNoBoundaryControl_Load( object sender, EventArgs e )
		{
			noBoundaryControl1.MouseMove += ( m, n ) => noBoundaryControl1.Invalidate( );
			noBoundaryControl1.MouseDown += ( m, n ) => noBoundaryControl1.Invalidate( );
			noBoundaryControl1.MouseLeave += ( m, n ) => noBoundaryControl1.Invalidate( );
			noBoundaryControl1.Paint += ( m, n ) =>
			{
				Graphics g = n.Graphics;
				g.DrawRectangle( Pens.Black, new Rectangle( 100, 100, 500, 200 ) );

				// 如果固定住在界面的位置使用注释的坐标信息
				// Point point = noBoundaryControl1.ControlToActualPoint( new Point( 110, 110 ) );
				Point point = new Point( 110, 110 );
				g.DrawRectangle( Pens.Black, new Rectangle( point.X, point.Y, 500, 200 ) );

				g.DrawString( "这是一条测试的数据信息", Font, Brushes.Red, new Point( 300, 500 ) );

			};
		}
	}
}
