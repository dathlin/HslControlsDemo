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
using HslControls;

namespace HslControlsApp
{
    [Activity( Label = "HslBottle Demo" )]
    public class Activity_HslBottle : AppCompatActivity
    {
        protected override void OnCreate( Bundle savedInstanceState )
        {
            base.OnCreate( savedInstanceState );

            // Create your application here
            SetContentView( Resource.Layout.layout_HslBottle );

            hslBottle1 = FindViewById<HslBottle>( Resource.Id.hslBottle1 );
            hslBottle2 = FindViewById<HslBottle>( Resource.Id.hslBottle2 );
            button1 = FindViewById<Button>( Resource.Id.button1 );

            button1.Click += Button1_Click;
        }

        private void Button1_Click( object sender, EventArgs e )
        {
            float value = random.Next( 1001 ) / 10f;
            hslBottle1.Value = value;
            hslBottle2.Value = value;
        }



        #region Private Member

        private HslBottle hslBottle1 = null;
        private HslBottle hslBottle2 = null;
        private Button button1 = null;
        private Random random = new Random( );

        #endregion
    }
}