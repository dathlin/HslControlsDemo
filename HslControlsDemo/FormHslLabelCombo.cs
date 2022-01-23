using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HslControlsDemo
{
	public partial class FormHslLabelCombo : FormContent
	{
		public FormHslLabelCombo( )
		{
			InitializeComponent( );
		}

		private void HslFactory4_Click( object sender, EventArgs e )
		{
			Control_Click( sender, e );
		}

		private void FormHslLabelCombo_Load( object sender, EventArgs e )
		{
			random = new Random( );
			timerTick = new Timer( );
			timerTick.Interval = 1000;
			timerTick.Tick += TimerTick_Tick; ;
			timerTick.Start( );

			hslLabelCombo14.TextValueColorTransFun = GetColorByValue;
		}

		private Color GetColorByValue( string value )
		{
			float val = float.Parse( value );
			if (val > 8f || val < 3) return Color.Tomato;
			return hslLabelCombo14.TextValueBackcolor;
		}

		private void TimerTick_Tick( object sender, EventArgs e )
		{
			float value = random.Next( 1000 ) / 100f;
			hslLabelCombo14.TextValue = value.ToString( );
			if (value > 8f)
			{
				hslLabelCombo14.ArrowDirection = ArrowDirection.Up;
			}
			else if (value < 3f)
			{
				hslLabelCombo14.ArrowDirection = ArrowDirection.Down;
			}
			else
				hslLabelCombo14.ArrowDirection = ArrowDirection.Left;
		}

		private Random random = null;
		private Timer timerTick = null;
	}
}
