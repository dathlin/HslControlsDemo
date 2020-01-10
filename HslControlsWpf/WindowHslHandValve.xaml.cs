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
    /// WindowHslHandValve.xaml 的交互逻辑
    /// </summary>
    public partial class WindowHslHandValve : Window
    {
        public WindowHslHandValve( )
        {
            InitializeComponent( );
        }

        private void HslSwitch_OnSwitchChanged( object arg1, bool arg2 )
        {
            if (arg2)
            {
                // 打开
                pipeLine1.MoveSpeed = -0.3;
                handValve1.Text = "0.3m/s";
                handValve1.OpenEnable = true;
            }
            else
            {
                pipeLine1.MoveSpeed = 0;
                handValve1.Text = "0m/s";
                handValve1.OpenEnable = false;
            }
        }
    }
}
