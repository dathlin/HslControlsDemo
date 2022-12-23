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
	public partial class FormBarChartHorizon : FormContent
	{
		public FormBarChartHorizon( )
		{
			InitializeComponent( );
		}

		private void FormBarChart_Load( object sender, EventArgs e )
		{
			//hslBarChart2.SetDataSource( new int[] { 1, 2, 4, 0, 3 }, new string[] { "周一", "周二", "周三", "周四", "周五" } );
			hslHorizonBarChart2.SetDataSource( new List<HslControls.BarValue>( )
			{
				new HslControls.BarValue(1.5, "周一"),
				new HslControls.BarValue(2.8, "周二"),
				new HslControls.BarValue(12.4, "周三"),
				new HslControls.BarValue(9.55, "周四"),
				new HslControls.BarValue(7, "周五"),
			} );
			hslHorizonBarChart3.SetDataSource( new List<HslControls.BarValue>( )
			{
				new HslControls.BarValue(2, "周一", Color.Tomato),
				new HslControls.BarValue(1, "周二", Color.Tomato),
				new HslControls.BarValue(4, "周三", Color.Tomato),
				new HslControls.BarValue(0, "周四", Color.Tomato),
				new HslControls.BarValue(3, "周五", Color.Tomato),
			} );


			hslHorizonBarChart4.SetDataSource( new List<HslControls.BarValue>( )
			{
				new HslControls.BarValue(random.Next(1500), "周一", Color.DodgerBlue),
				new HslControls.BarValue(random.Next( 1000 ), "周二", Color.DarkGreen),
				new HslControls.BarValue(random.Next( 600 ), "周三", Color.DarkOrange),
				new HslControls.BarValue(random.Next( 1500 ), "周四", Color.DarkOrchid),
				new HslControls.BarValue(random.Next( 800 ), "周五", Color.DimGray),
			} );

			hslHorizonBarChart5.SetDataSource( new List<HslControls.BarValue>( )
			{
				new HslControls.BarValue(800, "第一名", Color.OrangeRed, "布加迪 车型A {0}"),
				new HslControls.BarValue(700, "第二名", Color.OrangeRed, "帕加尼 车型B {0}"),
				new HslControls.BarValue(600, "第三名", Color.OrangeRed, "法拉利 车型C {0}"),
				new HslControls.BarValue(500, "第四名", Color.OrangeRed, "兰博基尼 车型D {0}"),
				new HslControls.BarValue(300, "第五名", Color.OrangeRed, "柯尼塞格 车型E {0}"),
			} );

			//foreach(var control in components.Components)
			//{
			//    control
			//}
		}


		private Random random = new Random( );

		private void hslHorizonBarChart1_Click( object sender, EventArgs e )
		{
			Control_Click( sender, e );
		}
	}
}
