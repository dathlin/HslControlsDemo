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
using System.Windows.Shapes;

namespace HslControlsWpf
{
    /// <summary>
    /// WindowHslCncCenter.xaml 的交互逻辑
    /// </summary>
    public partial class WindowHslCncCenter : Window
    {
        public WindowHslCncCenter( )
        {
            InitializeComponent( );
        }

        private void Button_Click( object sender, RoutedEventArgs e )
        {
            // 开启
            hslCncCenter1.SetDoorState( 0 );
            hslCncCenter2.SetDoorState( 0 );
        }

        private void Button_Click_1( object sender, RoutedEventArgs e )
        {
            // 关闭
            hslCncCenter1.SetDoorState( 100 );
            hslCncCenter2.SetDoorState( 100 );
        }
    }
}
