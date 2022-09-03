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
	public partial class FormHslChinaMap3 : FormContent
	{
		public FormHslChinaMap3( )
		{
			InitializeComponent( );
		}

		private void FormNoBoundaryControl_Load( object sender, EventArgs e )
		{
			hslChinaMap1.Paint += HslChinaMap1_Paint;

			timer = new Timer( );
			timer.Interval = 1000;
			timer.Tick += Timer_Tick;
			timer.Start( );
		}

		private void Timer_Tick( object sender, EventArgs e )
		{

		}

		Timer timer;

		private void HslChinaMap1_Paint( object sender, PaintEventArgs e )
		{
			Bitmap bitmap1 = Properties.Resources.weatherSun;
			Bitmap bitmap2 = Properties.Resources.weatherRain;
			hslChinaMap1.DrawImage( e.Graphics, new Point( 390, 304 ), bitmap1, false );
			hslChinaMap1.DrawImage( e.Graphics, new Point( 417, 759 ), bitmap1, false );
			hslChinaMap1.DrawImage( e.Graphics, new Point( 706, 573 ), bitmap1, false );
			hslChinaMap1.DrawImage( e.Graphics, new Point( 758, 587 ), bitmap1, false );
			hslChinaMap1.DrawImage( e.Graphics, new Point( 819, 518 ), bitmap1, false );
			hslChinaMap1.DrawImage( e.Graphics, new Point( 945, 445 ), bitmap1, false );
			hslChinaMap1.DrawImage( e.Graphics, new Point( 1059, 464 ), bitmap1, false );
			hslChinaMap1.DrawImage( e.Graphics, new Point( 1212, 391 ), bitmap1, false );
			hslChinaMap1.DrawImage( e.Graphics, new Point( 1245, 319 ), bitmap1, false );
			hslChinaMap1.DrawImage( e.Graphics, new Point( 1261, 261 ), bitmap1, false );
			hslChinaMap1.DrawImage( e.Graphics, new Point( 1175, 751 ), bitmap2, false );
			hslChinaMap1.DrawImage( e.Graphics, new Point( 1178, 567 ), bitmap2, false );
			hslChinaMap1.DrawImage( e.Graphics, new Point( 990, 821 ), bitmap2, false );
			hslChinaMap1.DrawImage( e.Graphics, new Point( 721, 913 ), bitmap2, false );
			hslChinaMap1.DrawImage( e.Graphics, new Point( 1003, 974 ), bitmap2, false );
			hslChinaMap1.DrawImage( e.Graphics, new Point( 1067, 806 ), bitmap2, false );
			hslChinaMap1.DrawImage( e.Graphics, new Point( 1023, 749 ), bitmap2, false );
			hslChinaMap1.DrawImage( e.Graphics, new Point( 824, 785 ), bitmap2, false );
			hslChinaMap1.DrawImage( e.Graphics, new Point( 1207, 716 ), bitmap2, false );
		}

		private void hslChinaMap1_Click( object sender, EventArgs e )
		{
			Control_Click( sender, e );
		}

	}
}
