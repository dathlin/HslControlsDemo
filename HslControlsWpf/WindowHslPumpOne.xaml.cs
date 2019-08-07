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
    /// WindowHslPumpOne.xaml 的交互逻辑
    /// </summary>
    public partial class WindowHslPumpOne : Window
    {
        public WindowHslPumpOne( )
        {
            InitializeComponent( );
        }

        private void Button_Click( object sender, RoutedEventArgs e )
        {
            // 启动
            hslPumpOne1.MoveSpeed = 0.5d;
            hslPipeLine1.MoveSpeed = -0.5d;
            hslPipeLine2.MoveSpeed = -0.5d;

        }

        private void Button_Click_1( object sender, RoutedEventArgs e )
        {
            // 停止
            hslPumpOne1.MoveSpeed = 0;
            hslPipeLine1.MoveSpeed = 0;
            hslPipeLine2.MoveSpeed = 0;

        }
    }
}
