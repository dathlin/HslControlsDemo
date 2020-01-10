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
using System.Windows.Forms;

namespace HslControlsWpf
{
    /// <summary>
    /// WindowHslWaterBasin.xaml 的交互逻辑
    /// </summary>
    public partial class WindowHslWaterBasin : Window
    {
        public WindowHslWaterBasin( )
        {
            InitializeComponent( );
        }

        protected override void OnContentRendered( EventArgs e )
        {
            base.OnContentRendered( e );
            random = new Random( );
            timer1s = new Timer( );
            timer1s.Interval = 700;
            timer1s.Tick += Timer1s_Tick;
            timer1s.Start( );
        }

        private void Timer1s_Tick( object sender, EventArgs e )
        {
            waterBasin1.Value = random.NextDouble( ) * 100;

            if (swtich1.SwitchStatus)
            {
                waterBasin2.Value++;
                if (waterBasin2.Value > 99d) waterBasin2.Value = 0;
            }
        }

        private Timer timer1s;
        private Random random;




        // 应用的示例，当然了，这里也可以在界面上用MVVM的绑定来实现数据的更新


        private void HslSwitch_OnSwitchChanged( object arg1, bool arg2 )
        {
            if (arg2)
            {
                // 打开
                pipeLine1.MoveSpeed = -0.3;
                pipeLine2.MoveSpeed = -0.3;
                handValve1.Text = "0.3m/s";
                handValve1.OpenEnable = true;
            }
            else
            {
                pipeLine1.MoveSpeed = 0;
                pipeLine2.MoveSpeed = 0;
                handValve1.Text = "0m/s";
                handValve1.OpenEnable = false;
            }
        }
    }
}
