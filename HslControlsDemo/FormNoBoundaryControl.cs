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


				g.DrawImage( Properties.Resources.weipay, new PointF( 700, 200 ) );
				g.DrawString( "这是我的微信", Font, Brushes.Red, new Point( 800, 240 ) );

				noBoundaryControl1.ResetGraphicsTransform( g );                                  // 不在变换操作
				g.DrawString( "固定标题的字符串", Font, Brushes.Red, new Point( 10, 10 ) );       // 绘制的点位是绝对位置的点位，永远在左上角位置
				noBoundaryControl1.GraphicsTransform( g );                                       // 恢复变换操作

				// g.DrawImage( Image.FromFile("D:\\123.jpg"), new PointF( 700, 200 ) );  // 如果是绝对路径的情况
			};
		}
	}
}
