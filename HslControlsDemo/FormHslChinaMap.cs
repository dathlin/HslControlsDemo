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
	public partial class FormHslChinaMap : FormContent
	{
		public FormHslChinaMap( )
		{
			InitializeComponent( );
		}

		private void FormNoBoundaryControl_Load( object sender, EventArgs e )
		{
		}

		private void hslChinaMap1_Click( object sender, EventArgs e )
		{
			Control_Click( sender, e );
		}

		private void button1_Click( object sender, EventArgs e )
		{
			// 随机标记
			hslChinaMap1.MarkRandomTest( );
		}

		private void button2_Click( object sender, EventArgs e )
		{
			// 指定标记
			string[] city = new string[] { "北京", "上海", "广州", "深圳", "杭州", "南京", "苏州", "重庆" };
			int[] markSize = new int[] { 8, 7, 6, 6, 5, 5, 4, 4 };
			Color[] markColor = new Color[] { Color.Red, Color.Red, Color.Red, Color.Red, Color.Tomato, Color.Tomato, Color.Tomato, Color.Tomato };

			hslChinaMap1.MarkCity( city, markSize, markColor );
		}

		private void button3_Click( object sender, EventArgs e )
		{
			// 标记清除
			hslChinaMap1.MarkCityClear( );
		}

		private void button4_Click( object sender, EventArgs e )
		{
			hslChinaMap1.SetProvinceBackColor( "浙江", Color.Gray );
		}
	}
}
