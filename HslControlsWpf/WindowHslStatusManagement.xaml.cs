using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HslControlsWpf
{
	/// <summary>
	/// WindowHslStatusManagement.xaml 的交互逻辑
	/// </summary>
	public partial class WindowHslStatusManagement : Window
	{
		public WindowHslStatusManagement( )
		{
			InitializeComponent( );
			random = new Random( );
		}

		#region 示例

		private void SetExample( )
		{
			byte[] buffer = new byte[hslStatusManagement6.RowCount * hslStatusManagement6.ColCount];
			random.NextBytes( buffer );
			hslStatusManagement6.SetColorAll( buffer.Select( new Func<byte, Color>( GetColorFromValue ) ).ToArray( ) );
			hslStatusManagement6.SetAllDescription( buffer.Select( new Func<byte, string>( m => $"Value:{m}" ) ).ToArray( ) );
		}

		private Color GetColorFromValue( byte value )
		{
			if (value < 50)
			{
				return Color.FromRgb( 224, 224, 224 );
			}
			else if (value < 100)
			{
				return Color.FromRgb( 198, 228, 139 );
			}
			else if (value < 150)
			{
				return Color.FromRgb( 123, 201, 111 );
			}
			else if (value < 200)
			{
				return Color.FromRgb( 35, 154, 59 );
			}
			else
			{
				return Color.FromRgb( 25, 97, 39 );
			}
		}

		#endregion

		#region 跑马灯示例

		private Timer timer;
		private Point activePoint = new Point( 0, 0 );

		private void Inni( )
		{
			timer = new Timer( );
			timer.Interval = 60;
			timer.Tick += Timer_Tick;
			timer.Start( );
			hslStatusManagement5.SetColorByLocation( activePoint, Colors.DodgerBlue );
		}

		private void Timer_Tick( object sender, EventArgs e )
		{
			// 先判断能否往右
			if (activePoint.Y + 1 < hslStatusManagement5.ColCount && activePoint.X == 0)
			{
				hslStatusManagement5.ResetColorByLocation( activePoint );
				activePoint.Y++;
				hslStatusManagement5.SetColorByLocation( activePoint, Colors.DodgerBlue );
				return;
			}

			// 判断能否往下
			if (activePoint.X + 1 < hslStatusManagement5.RowCount && activePoint.Y == hslStatusManagement5.ColCount - 1)
			{
				hslStatusManagement5.ResetColorByLocation( activePoint );
				activePoint.X++;
				hslStatusManagement5.SetColorByLocation( activePoint, Colors.DodgerBlue );
				return;
			}

			// 判断能否往左
			if (activePoint.Y - 1 >= 0 && activePoint.X == hslStatusManagement5.RowCount - 1)
			{
				hslStatusManagement5.ResetColorByLocation( activePoint );
				activePoint.Y--;
				hslStatusManagement5.SetColorByLocation( activePoint, Colors.DodgerBlue );
				return;
			}

			// 判断能否往上
			if (activePoint.X - 1 >= 0 && activePoint.Y == 0)
			{
				hslStatusManagement5.ResetColorByLocation( activePoint );
				activePoint.X--;
				hslStatusManagement5.SetColorByLocation( activePoint, Colors.DodgerBlue );
			}
		}



		#endregion


		private Random random;

		private void Window_Loaded( object sender, RoutedEventArgs e )
		{

			Inni( );

			SetExample( );
		}

		private void Button_Click( object sender, RoutedEventArgs e )
		{
			hslStatusManagement2.RenderStyle = HslControls.HslRenderStyle.Rectangle;
		}

		private void Button_Click_1( object sender, RoutedEventArgs e )
		{
			hslStatusManagement2.RenderStyle = HslControls.HslRenderStyle.Ellipse;
		}

		private void Button_Click_2( object sender, RoutedEventArgs e )
		{
			hslStatusManagement2.RenderStyle = HslControls.HslRenderStyle.Rhombus;
		}

		private void Button_Click_3( object sender, RoutedEventArgs e )
		{
			hslStatusManagement2.SetColorAll( Color.FromRgb( (byte)random.Next( 256 ), (byte)random.Next( 256 ), (byte)random.Next( 256 ) ) );
		}

		private void Button_Click_4( object sender, RoutedEventArgs e )
		{
			hslStatusManagement2.ResetColorAll( );
		}
	}
}
