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
using System.Windows.Media.Animation;

namespace HslControlsWpf
{
    /// <summary>
    /// WindowHslArcGauge.xaml 的交互逻辑
    /// </summary>
    public partial class WindowHslArcGauge : Window
    {
        public WindowHslArcGauge( )
        {
            InitializeComponent( );

            timer1 = new System.Threading.Timer( ThreadTimer, null, 800, 800 );
        }

        private Random random = new Random( );
        System.Threading.Timer timer1;

        private void ThreadTimer( object obj )
        {
            try
            {
                this.Dispatcher.Invoke( new Action( ( ) =>
                {
                    hslArcGauge2.Value = random.NextDouble( ) * 500;

                    DoubleAnimation doubleAnimation = new DoubleAnimation( hslArcGauge3.Value, random.NextDouble( ) * 60, TimeSpan.FromSeconds( 0.5d ) );
                    hslArcGauge3.BeginAnimation( HslControls.WPF.HslArcGauge.ValueProperty, doubleAnimation );
                } ) );
            }
            catch
            {

            }
        }

    }


    public class MainWindowModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged( string prop )
        {
            if (PropertyChanged == null) return;

            PropertyChanged( this, new PropertyChangedEventArgs( prop ) );
        }

        private string _gaugeTitle;
        private string _gaugeUnit;
        private double _max = 100;
        private double _min = 0;
        private double _value = 50;
        private double _settingValue;

        public string GaugeTitle
        {
            get { return _gaugeTitle; }
            set
            {
                _gaugeTitle = value;
                OnPropertyChanged( "GaugeTitle" );
            }
        }

        public string GaugeUnit
        {
            get { return _gaugeUnit; }
            set
            {
                _gaugeUnit = value;
                OnPropertyChanged( "GaugeUnit" );
            }
        }

        public double Max
        {
            get { return _max; }
            set
            {
                _max = value;
                OnPropertyChanged( "Max" );
            }
        }

        public double Min
        {
            get { return _min; }
            set
            {
                _min = value;
                OnPropertyChanged( "Min" );
            }
        }

        public double Value
        {
            get { return _value; }
            set
            {
                _value = value;
                OnPropertyChanged( "Value" );
            }
        }

        public double SettingValue
        {
            get { return _settingValue; }
            set
            {
                _settingValue = value;
                OnPropertyChanged( "SettingValue" );
            }
        }
    }
}
