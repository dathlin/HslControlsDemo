using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HslControlsDemo
{
	public partial class FormHslDialPlate : FormContent
	{
		public FormHslDialPlate( )
		{
			InitializeComponent( );
		}

		private void FormHslDialPlate_Load( object sender, EventArgs e )
		{

		}

		private void hslDialPlate1_Click( object sender, EventArgs e )
		{
			Control_Click( sender, e );
		}

		private void button1_Click( object sender, EventArgs e )
		{
			hslDialPlate1.Value = new Random( ).Next( 100 ) / 1.0f;
		}
	}
}
