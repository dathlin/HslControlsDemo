using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using HslControls;

namespace HslControlsApp
{
    [Activity( Label = "HslSignature Demo" )]
    public class Activity_HslSignature : AppCompatActivity
    {
        protected override void OnCreate( Bundle savedInstanceState )
        {
            base.OnCreate( savedInstanceState );
            // Create your application here

            SetContentView( Resource.Layout.layout_HslSignature );

            hslSignature1 = FindViewById<HslSignature>( Resource.Id.hslSignature1 );
            button1 = FindViewById<Button>( Resource.Id.button1 );
            button2 = FindViewById<Button>( Resource.Id.button2 );

            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
        }

        private void Button2_Click( object sender, EventArgs e )
        {
            string fileName = Android.OS.Environment.GetExternalStoragePublicDirectory( Android.OS.Environment.DirectoryPictures ).Path + "/DCIM/" + $"{DateTime.Now.ToString( "yyyyMMddHHmmss" )}.jpg";

           hslSignature1.SaveBitmap( fileName );

            BaseContext.SendBroadcast( new Intent( Intent.ActionMediaScannerScanFile, Android.Net.Uri.Parse( "file://" + fileName ) ) );

        }

        private void Button1_Click( object sender, EventArgs e )
        {
            hslSignature1.ClearSign( );
        }

        private HslSignature hslSignature1;
        private Button button1;
        private Button button2;
    }
}