using HslControls.WPF.Segments;
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
    /// WindowSevenSegments.xaml 的交互逻辑
    /// </summary>
    public partial class WindowSevenSegments : Window
    {
        public WindowSevenSegments( )
        {
            InitializeComponent( );
        }


        private void Button_Click( object sender, RoutedEventArgs e )
        {
            int[] segments =
            {
                (int) SixteenSegmentsNumbers.LeftMiddle,
                (int) SixteenSegmentsNumbers.RightBottomDiagonal
            };

            MySegments.ClearSegments( );
            MySegments.SelectedSegments = segments.ToList( );
        }


        private void Button_Click_1( object sender, RoutedEventArgs e )
        {
            MySegments.ClearSegments( );
            MySegments.Value = "1";
        }

        private void Button_Click_2( object sender, RoutedEventArgs e )
        {

            Tuple<int, Brush, Color>[] brushes =
            {
                new Tuple<int, Brush, Color>(
                (int)SixteenSegmentsNumbers.RightVertTop,
                new SolidColorBrush(Colors.Yellow),
                Colors.Red),

                new Tuple<int, Brush, Color>(
                (int)SixteenSegmentsNumbers.RightVertBottom,
                new SolidColorBrush(Colors.Orange),
                Colors.Blue)
            };

            MySegments.ClearSegments( );
            MySegments.SegmentsBrush = brushes.ToList( );

        }

    }
}
