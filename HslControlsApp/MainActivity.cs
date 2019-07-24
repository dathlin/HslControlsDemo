using System;
using Android;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Android.Support.V4.Widget;
using Android.Support.V7.App;
using Android.Views;
using HslCommunication.Enthernet;
using System.Threading;

namespace HslControlsApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, NavigationView.IOnNavigationItemSelectedListener
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            fab.Click += FabOnClick;

            DrawerLayout drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            ActionBarDrawerToggle toggle = new ActionBarDrawerToggle(this, drawer, toolbar, Resource.String.navigation_drawer_open, Resource.String.navigation_drawer_close);
            drawer.AddDrawerListener(toggle);
            toggle.SyncState();

            NavigationView navigationView = FindViewById<NavigationView>(Resource.Id.nav_view);
            navigationView.SetNavigationItemSelectedListener(this);

            bool isSuccess = HslControls.Authorization.SetAuthorizationCode( "你的授权码" );
            if (!isSuccess)
            {
                Console.WriteLine( "注册失败" );
            }

            new Thread( new ThreadStart( CheckServer ) ) { IsBackground = true }.Start( );
        }

        private void CheckServer( )
        {
            NetSimplifyClient simplifyClient = new NetSimplifyClient( "118.24.36.220", 18467 );
            HslCommunication.OperateResult<HslCommunication.NetHandle, string> read = simplifyClient.ReadCustomerFromServer( 101, "2.1.7" );
        }

        public override void OnBackPressed()
        {
            DrawerLayout drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            if(drawer.IsDrawerOpen(GravityCompat.Start))
            {
                drawer.CloseDrawer(GravityCompat.Start);
            }
            else
            {
                base.OnBackPressed();
            }
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            View view = (View) sender;
            Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
                .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
        }

        public bool OnNavigationItemSelected(IMenuItem item)
        {
            int id = item.ItemId;

            if (id == Resource.Id.nav_HslBottle)
            {
                Intent i = new Intent( this, typeof( Activity_HslBottle ) );
                this.StartActivity( i );
            }
            else if (id == Resource.Id.nav_HslPipeLine)
            {
                Intent i = new Intent( this, typeof( Activity_HslPipeLine ) );
                this.StartActivity( i );
            }
            else if(id == Resource.Id.nav_HslValves)
            {
                Intent i = new Intent( this, typeof( Activity_HslValves ) );
                this.StartActivity( i );
            }
            else if (id == Resource.Id.nav_HslLedDisplay)
            {
                Intent i = new Intent( this, typeof( Activity_HslLedDisplay ) );
                this.StartActivity( i );
            }
            else if (id == Resource.Id.nav_HslPumpOne)
            {
                Intent i = new Intent( this, typeof( Activity_HslPumpOne ) );
                this.StartActivity( i );
            }
            else if (id == Resource.Id.nav_HslWaterBox)
            {
                Intent i = new Intent( this, typeof( Activity_HslWaterBox ) );
                this.StartActivity( i );
            }
            else if (id == Resource.Id.nav_HslStatusManagement)
            {
                Intent i = new Intent( this, typeof( Activity_HslStatusManagement ) );
                this.StartActivity( i );
            }
            else if (id == Resource.Id.nav_HslClassifier)
            {
                Intent i = new Intent( this, typeof( Activity_HslClassifier ) );
                this.StartActivity( i );
            }
            else if (id == Resource.Id.nav_HslBattery)
            {
                Intent i = new Intent( this, typeof( Activity_HslBattery ) );
                this.StartActivity( i );
            }
            else if (id == Resource.Id.nav_HslProgress)
            {
                Intent i = new Intent( this, typeof( Activity_HslProgress ) );
                this.StartActivity( i );
            }
            else if (id == Resource.Id.nav_HslGanttChart)
            {
                Intent i = new Intent( this, typeof( Activity_HslGanttChart ) );
                this.StartActivity( i );
            }
            else if (id == Resource.Id.nav_HslLanternSimple)
            {
                Intent i = new Intent( this, typeof( Activity_HslLanternSimple ) );
                this.StartActivity( i );
            }
            else if (id == Resource.Id.nav_HslGauge)
            {
                Intent i = new Intent( this, typeof( Activity_HslGauge ) );
                this.StartActivity( i );
            }
            else if (id == Resource.Id.nav_HslPieChart)
            {
                Intent i = new Intent( this, typeof( Activity_HslPieChart ) );
                this.StartActivity( i );
            }
            else if (id == Resource.Id.nav_HslBarChart)
            {
                Intent i = new Intent( this, typeof( Activity_HslBarChart ) );
                this.StartActivity( i );
            }
            else if (id == Resource.Id.nav_HslCurve)
            {
                Intent i = new Intent( this, typeof( Activity_HslCurve ) );
                this.StartActivity( i );
            }
            else if (id == Resource.Id.nav_HslConveyer)
            {
                Intent i = new Intent( this, typeof( Activity_HslConveyer ) );
                this.StartActivity( i );
            }
            else if (id == Resource.Id.nav_HslThermometer)
            {
                Intent i = new Intent( this, typeof( Activity_HslThermometer ) );
                this.StartActivity( i );
            }
            else if (id == Resource.Id.nav_HslMotor)
            {
                Intent i = new Intent( this, typeof( Activity_HslMotor ) );
                this.StartActivity( i );
            }
            else if (id == Resource.Id.nav_HslCncCenter)
            {
                Intent i = new Intent( this, typeof( Activity_HslCncCenter ) );
                this.StartActivity( i );
            }
            else if (id == Resource.Id.nav_HslMachineCenter)
            {
                Intent i = new Intent( this, typeof( Activity_HslMachineCenter ) );
                this.StartActivity( i );
            }

            DrawerLayout drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            drawer.CloseDrawer(GravityCompat.Start);
            return true;
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}

