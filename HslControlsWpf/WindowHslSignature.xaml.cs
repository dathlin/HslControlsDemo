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
    /// WindowHslSignature.xaml 的交互逻辑
    /// </summary>
    public partial class WindowHslSignature : Window
    {
        public WindowHslSignature( )
        {
            InitializeComponent( );

            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
        }

        private void Button2_Click( object sender, RoutedEventArgs e )
        {
            // 保存
            hslSignature1.SaveBitmap( ).Save( System.IO.Path.Combine( AppDomain.CurrentDomain.BaseDirectory, "sign.jpg" ) );
            MessageBox.Show( "保存成功，当前目录的文件夹下的Sign.jpg文件" );
        }

        private void Button1_Click( object sender, RoutedEventArgs e )
        {
            // 清除
            hslSignature1.ClearSign( );
        }


    }
}
