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
            barChart1.SetDataSource( new int[] { 123, 533, 736, 283, 87 } );
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
    }
}
