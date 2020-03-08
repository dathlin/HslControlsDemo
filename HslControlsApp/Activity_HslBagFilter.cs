using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace HslControlsApp
{
	[Activity( Label = "HslBagFilter Demo" )]
	public class Activity_HslBagFilter : AppCompatActivity
	{
		protected override void OnCreate( Bundle savedInstanceState )
		{
			base.OnCreate( savedInstanceState );

			// Create your application here

			SetContentView( Resource.Layout.layout_HslBagFilter );
		}
	}
}