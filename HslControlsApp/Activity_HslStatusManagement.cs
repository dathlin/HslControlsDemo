using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    [Activity( Label = "HslStatusManagement Demo" )]
    public class Activity_HslStatusManagement : AppCompatActivity
    {
        protected override void OnCreate( Bundle savedInstanceState )
        {
            base.OnCreate( savedInstanceState );

            // Create your application here
            SetContentView( Resource.Layout.layout_HslStatusManagement );

            hslStatusManagement1 = FindViewById<HslStatusManagement>( Resource.Id.hslStatusManagement1 );
            hslStatusManagement2 = FindViewById<HslStatusManagement>( Resource.Id.hslStatusManagement2 );
            button1 = FindViewById<Button>( Resource.Id.button1 );
            button2 = FindViewById<Button>( Resource.Id.button2 );
            button3 = FindViewById<Button>( Resource.Id.button3 );
            button4 = FindViewById<Button>( Resource.Id.button4 );
            button5 = FindViewById<Button>( Resource.Id.button5 );
            button6 = FindViewById<Button>( Resource.Id.button6 );
            button7 = FindViewById<Button>( Resource.Id.button7 );

            button1.Click += ( object sender, EventArgs e ) => { hslStatusManagement2.RenderStyle = HslRenderStyle.Rectangle; };
            button2.Click += ( object sender, EventArgs e ) => { hslStatusManagement2.RenderStyle = HslRenderStyle.Ellipse; };
            button3.Click += ( object sender, EventArgs e ) => { hslStatusManagement2.RenderStyle = HslRenderStyle.Rhombus; };
            button4.Click += ( object sender, EventArgs e ) => { hslStatusManagement2.SetColorAll( new Color( random.Next( 256 ), random.Next( 256 ), random.Next( 256 ) ) ); };
            button5.Click += ( object sender, EventArgs e ) => { hslStatusManagement2.ResetColorAll( ); };
            button6.Click += Button6_Click;
            button7.Click += Button7_Click;
            Inni( );
        }

        private void Button7_Click( object sender, EventArgs e )
        {
            if (int.TryParse( FindViewById<EditText>( Resource.Id.editText2 ).Text, out int colIndex ))
            {
                hslStatusManagement2.SetColorByCol( colIndex, new Color( random.Next( 256 ), random.Next( 256 ), random.Next( 256 ) ) );
            }
            else
            {
                Toast.MakeText( this, "colIndex Input wrong", ToastLength.Long ).Show( );
            }
        }

        private void Button6_Click( object sender, EventArgs e )
        {
            if(int.TryParse( FindViewById<EditText>( Resource.Id.editText1 ).Text, out int rowIndex ))
            {
                hslStatusManagement2.SetColorByRow( rowIndex, new Color( random.Next( 256 ), random.Next( 256 ), random.Next( 256 ) ) );
            }
            else
            {
                Toast.MakeText( this, "rowIndex Input wrong", ToastLength.Long ).Show( );
            }
        }

        private HslStatusManagement hslStatusManagement1 = null;
        private HslStatusManagement hslStatusManagement2 = null;
        private Button button1 = null;
        private Button button2 = null;
        private Button button3 = null;
        private Button button4 = null;
        private Button button5 = null;
        private Button button6 = null;
        private Button button7 = null;


        #region 跑马灯示例

        private Timer timer;
        private Random random = new Random( );
        private Point activePoint = new Point( 0, 0 );
        private Action updateAction = null;
            

        private void Inni( )
        {
            updateAction = new Action( ( ) =>
            {
                // 先判断能否往右
                if (activePoint.Y + 1 < hslStatusManagement1.ColCount && activePoint.X == 0)
                {
                    hslStatusManagement1.ResetColorByLocation( activePoint );
                    activePoint.Y++;
                    hslStatusManagement1.SetColorByLocation( activePoint, Color.DodgerBlue );
                    return;
                }

                // 判断能否往下
                if (activePoint.X + 1 < hslStatusManagement1.RowCount && activePoint.Y == hslStatusManagement1.ColCount - 1)
                {
                    hslStatusManagement1.ResetColorByLocation( activePoint );
                    activePoint.X++;
                    hslStatusManagement1.SetColorByLocation( activePoint, Color.DodgerBlue );
                    return;
                }

                // 判断能否往左
                if (activePoint.Y - 1 >= 0 && activePoint.X == hslStatusManagement1.RowCount - 1)
                {
                    hslStatusManagement1.ResetColorByLocation( activePoint );
                    activePoint.Y--;
                    hslStatusManagement1.SetColorByLocation( activePoint, Color.DodgerBlue );
                    return;
                }

                // 判断能否往上
                if (activePoint.X - 1 >= 0 && activePoint.Y == 0)
                {
                    hslStatusManagement1.ResetColorByLocation( activePoint );
                    activePoint.X--;
                    hslStatusManagement1.SetColorByLocation( activePoint, Color.DodgerBlue );
                }
            } );
            hslStatusManagement1.SetColorByLocation( activePoint, Color.DodgerBlue );
            timer = new Timer( new TimerCallback( Timer_Tick ), null, 100, 60 );
        }

        private void Timer_Tick( object state )
        {
            hslStatusManagement1.Post( updateAction );
        }



        #endregion
    }
}