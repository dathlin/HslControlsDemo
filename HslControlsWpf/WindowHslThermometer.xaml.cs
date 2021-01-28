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
	/// WindowHslThermometer.xaml 的交互逻辑
	/// </summary>
	public partial class WindowHslThermometer : Window
	{
		public WindowHslThermometer( )
		{
			InitializeComponent( );
		}

		protected override void OnSourceInitialized( EventArgs e )
		{
			base.OnSourceInitialized( e );

			hslThermometer3.RightDataTransfer = new Func<float, float>( m => m );

			random = new Random( );
			timerTick = new Timer( );
			timerTick.Interval = 1000;
			timerTick.Tick += TimerTick_Tick;
			timerTick.Start( );
		}


		private void TimerTick_Tick( object sender, EventArgs e )
		{
			hslThermometer1.Value = random.Next( 80 ) - 20;
			hslThermometer2.SetValue( random.Next( 80 ) - 20 );
			hslThermometer3.SetValue( random.Next( 100 ) );
		}


		private Random random = null;
		private Timer timerTick = null;
	}
}
