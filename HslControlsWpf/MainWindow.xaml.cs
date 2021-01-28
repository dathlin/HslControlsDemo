using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HslControlsWpf
{
	/// <summary>
	/// MainWindow.xaml 的交互逻辑
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow( )
		{
			InitializeComponent( );
		}

		protected override void OnRender( DrawingContext drawingContext )
		{
			base.OnRender( drawingContext );
		}

		private void B_HslBottle_Click( object sender, RoutedEventArgs e )
		{
			WindowHslBottle window = new WindowHslBottle( );
			window.ShowDialog( );
		}

		private void B_HslPipeLine_Click( object sender, RoutedEventArgs e )
		{
			WindowHslPipeLine window = new WindowHslPipeLine( );
			window.ShowDialog( );
		}

		private void B_HslLanternSimple_Click( object sender, RoutedEventArgs e )
		{
			WindowHslLanternSimple window = new WindowHslLanternSimple( );
			window.ShowDialog( );
		}

		private void B_HslHandValve_Click( object sender, RoutedEventArgs e )
		{
			WindowHslHandValve window = new WindowHslHandValve( );
			window.ShowDialog( );
		}

		private void B_HslWaterBasin_Click( object sender, RoutedEventArgs e )
		{
			WindowHslWaterBasin window = new WindowHslWaterBasin( );
			window.ShowDialog( );
		}

		private void B_HslBarChart_Click( object sender, RoutedEventArgs e )
		{
			WindowHslBarChart window = new WindowHslBarChart( );
			window.ShowDialog( );
		}

		private void B_HslCncCenter_Click( object sender, RoutedEventArgs e )
		{
			WindowHslCncCenter window = new WindowHslCncCenter( );
			window.ShowDialog( );
		}

		private void B_HslCurve_Click( object sender, RoutedEventArgs e )
		{
			WindowHslCurve window = new WindowHslCurve( );
			window.ShowDialog( );
		}

		private void B_HslMachineCenter_Click( object sender, RoutedEventArgs e )
		{
			WindowHslMachineCenter window = new WindowHslMachineCenter( );
			window.ShowDialog( );
		}

		private void B_HslPumpOne_Click( object sender, RoutedEventArgs e )
		{
			WindowHslPumpOne window = new WindowHslPumpOne( );
			window.ShowDialog( );
		}

		private void B_HslVacuumPump_Click( object sender, RoutedEventArgs e )
		{
			WindowHslVacuumPump window = new WindowHslVacuumPump( );
			window.ShowDialog( );
		}

		private void B_HslMotorTwo_Click( object sender, RoutedEventArgs e )
		{
			WindowHslMotorTwo window = new WindowHslMotorTwo( );
			window.ShowDialog( );
		}

		private void B_HslWaterBox_Click( object sender, RoutedEventArgs e )
		{
			WindowHslWaterBox window = new WindowHslWaterBox( );
			window.ShowDialog( );
		}

		private void B_HslMoveText_Click( object sender, RoutedEventArgs e )
		{
			WindowHslMoveText window = new WindowHslMoveText( );
			window.ShowDialog( );
		}

		private void B_HslWaterPump_Click( object sender, RoutedEventArgs e )
		{
			WindowHslWaterPump window = new WindowHslWaterPump( );
			window.ShowDialog( );
		}

		private void B_HslCoolFan_Click( object sender, RoutedEventArgs e )
		{
			WindowHslCoolFan window = new WindowHslCoolFan( );
			window.ShowDialog( );
		}

		private void B_HslClassifier_Click( object sender, RoutedEventArgs e )
		{
			WindowHslClassifier window = new WindowHslClassifier( );
			window.ShowDialog( );
		}

		private void B_HslSignature_Click( object sender, RoutedEventArgs e )
		{
			WindowHslSignature window = new WindowHslSignature( );
			window.ShowDialog( );
		}

		private void B_HslCircularGauge_Click( object sender, RoutedEventArgs e )
		{
			WindowHslCircularGauge window = new WindowHslCircularGauge( );
			window.ShowDialog( );
		}

		private void B_HslSegments_Click( object sender, RoutedEventArgs e )
		{
			WindowSevenSegments window = new WindowSevenSegments( );
			window.ShowDialog( );
		}

		private void B_HslArcGauge_Click( object sender, RoutedEventArgs e )
		{
			WindowHslArcGauge window = new WindowHslArcGauge( );
			window.ShowDialog( );
		}

		private void B_HslBagFilter_Click( object sender, RoutedEventArgs e )
		{
			WindowHslBagFilter window = new WindowHslBagFilter( );
			window.ShowDialog( );
		}

		private void B_HslCurveHistory_Click( object sender, RoutedEventArgs e )
		{
			WindowHslCurveHistory window = new WindowHslCurveHistory( );
			window.ShowDialog( );
		}

		private void B_HslBattery_Click( object sender, RoutedEventArgs e )
		{
			WindowHslBattery window = new WindowHslBattery( );
			window.ShowDialog( );
		}

		private void B_HslArrow_Click( object sender, RoutedEventArgs e )
		{
			WindowHslArrow window = new WindowHslArrow( );
			window.ShowDialog( );
		}

		private void B_HslGanttChart_Click( object sender, RoutedEventArgs e )
		{
			WindowHslGanttChart window = new WindowHslGanttChart( );
			window.ShowDialog( );
		}

		private void B_HslStatus_Click( object sender, RoutedEventArgs e )
		{
			WindowHslStatusManagement window = new WindowHslStatusManagement( );
			window.ShowDialog( );
		}

		private void B_HslTitle_Click( object sender, RoutedEventArgs e )
		{
			WindowHslTitle window = new WindowHslTitle( );
			window.ShowDialog( );
		}

        private void B_HslSwitch_Click( object sender, RoutedEventArgs e )
        {
			hslSwitch1.ChangeSwitchStatus( !hslSwitch1.SwitchStatus );
        }

		private void B_HslThermometer_Click( object sender, RoutedEventArgs e )
		{
			WindowHslThermometer window = new WindowHslThermometer( );
			window.ShowDialog( );
		}
	}
}
