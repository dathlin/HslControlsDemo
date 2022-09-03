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
	public partial class FormProgressBar : FormContent
	{
		public FormProgressBar( )
		{
			InitializeComponent( );
		}

		private string ProgressText(int value, int max )
		{
			return $"当前第{value}个，总计{max}个";
		}

		private void FormProgressBar_Load( object sender, EventArgs e )
		{
			hslProgressBar9.CustmerTextTranslate = ProgressText;
		}
	}
}
