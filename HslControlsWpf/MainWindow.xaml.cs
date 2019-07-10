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
    }
}
