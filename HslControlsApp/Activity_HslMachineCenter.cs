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
    [Activity( Label = "HslMachineCenter Demo" )]
    public class Activity_HslMachineCenter : AppCompatActivity
    {
        protected override void OnCreate( Bundle savedInstanceState )
        {
            base.OnCreate( savedInstanceState );

            SetContentView( Resource.Layout.layout_HslMachineCenter );
            // Create your application here

            Button button1 = FindViewById<Button>( Resource.Id.button1 );
            Button button2 = FindViewById<Button>( Resource.Id.button2 );
            hslMachineCenter = FindViewById<HslControls.HslMachineCenter>( Resource.Id.hslMachineCenter1 );
            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
        }
        private void Button2_Click( object sender, EventArgs e )
        {
            // close
            hslMachineCenter.DoorOpenStatus = false;
        }

        private void Button1_Click( object sender, EventArgs e )
        {
            // open
            hslMachineCenter.DoorOpenStatus = true;
        }


        HslControls.HslMachineCenter hslMachineCenter = null;
    }
}