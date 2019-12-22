using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Threading;

namespace HslControlsWpf
{
    /// <summary>
    /// WindowHslCircularGauge.xaml 的交互逻辑
    /// </summary>
    public partial class WindowHslCircularGauge : Window
    {
        public WindowHslCircularGauge( )
        {
            InitializeComponent( );
            game = new Game( 0 );
        }

        DispatcherTimer timer;
        Game game;

        private void Window_Loaded( object sender, RoutedEventArgs e )
        {
            myGauge4.DataContext = game;

            //Start the timer
            timer = new DispatcherTimer( );
            timer.Interval = TimeSpan.FromMilliseconds( 1000 );
            timer.Tick += new EventHandler( timer_Tick );
            timer.Start( );
        }

        Random r = new Random( );

        void timer_Tick( object sender, EventArgs e )
        {
            //Update random scores
            double val = r.Next( 1, 10 );

            myGauge1.CurrentValue = r.Next( 1000 );
            myGauge2.CurrentValue = r.NextDouble( );
            myGauge3.CurrentValue = r.Next( 100 ) - 50;

            // 采用数据绑定的示例
            game.Score = r.Next( 0, 1000 );
        }
    }

    /// <summary>
    /// Helper class to simulate a game
    /// </summary>
    public class Game : INotifyPropertyChanged
    {
        private double score;

        public double Score
        {
            get { return score; }
            set
            {
                score = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged( this, new PropertyChangedEventArgs( "Score" ) );
                }
            }
        }


        public Game( double scr )
        {
            this.Score = scr;
        }


        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
