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
	public partial class FormHslChinaMap2 : FormContent
	{
		public FormHslChinaMap2( )
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
			Bitmap bitmap = Properties.Resources.plane; //(Bitmap)Image.FromFile( System.IO.Path.Combine( Application.StartupPath, "plane.png" ) );
			hslChinaMap1.DrawLineAndImage( e.Graphics, "北京", "广州", 50, bitmap );
			hslChinaMap1.DrawLineAndImage( e.Graphics, "北京", "哈尔滨", 50, bitmap );
			hslChinaMap1.DrawLineAndImage( e.Graphics, "北京", "乌鲁木齐", 50, bitmap );
			hslChinaMap1.DrawLineAndImage( e.Graphics, "北京", "杭州", 50, bitmap );
			hslChinaMap1.DrawLineAndImage( e.Graphics, "杭州", "延安", 80, bitmap );
			hslChinaMap1.DrawLineAndImage( e.Graphics, "杭州", "三亚", 90, bitmap );
			hslChinaMap1.DrawLineAndImage( e.Graphics, "杭州", "拉萨", 80, bitmap );
			hslChinaMap1.DrawLineAndImage( e.Graphics, "杭州", "西安", 40, bitmap );
			hslChinaMap1.DrawLineAndImage( e.Graphics, "杭州", "太原", 40, bitmap );
			hslChinaMap1.DrawLineAndImage( e.Graphics, "杭州", "南宁", 10, bitmap );
			hslChinaMap1.DrawLineAndImage( e.Graphics, "杭州", "昆明", 60, bitmap );
			hslChinaMap1.DrawLineAndImage( e.Graphics, "杭州", "台北", 70, bitmap );
			hslChinaMap1.DrawLineAndImage( e.Graphics, "杭州", "长春", 60, bitmap );
			hslChinaMap1.DrawLineAndImage( e.Graphics, "杭州", "呼和浩特", 60, bitmap );
		}

		private void hslChinaMap1_Click( object sender, EventArgs e )
		{
			Control_Click( sender, e );
		}

	}
}
