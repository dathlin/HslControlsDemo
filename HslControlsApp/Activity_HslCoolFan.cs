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
    [Activity( Label = "HslCoolFan Demo" )]
    public class Activity_HslCoolFan : AppCompatActivity
    {
        protected override void OnCreate( Bundle savedInstanceState )
        {
            base.OnCreate( savedInstanceState );

            SetContentView( Resource.Layout.layout_HslCoolFan );
            // Create your application here
        }
    }
}