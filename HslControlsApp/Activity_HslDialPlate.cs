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
using System.Threading;
using Android.Graphics;

namespace HslControlsApp
{
	[Activity( Label = "HslDialPlate Demo" )]
	public class Activity_HslDialPlate : AppCompatActivity
	{
		protected override void OnCreate( Bundle savedInstanceState )
		{
			base.OnCreate( savedInstanceState );

			// Create your application here
			SetContentView( Resource.Layout.layout_HslDialPlate );

			hslDialPlate1 = FindViewById<HslDialPlate>( Resource.Id.hslDialPlate1 );
			hslDialPlate2 = FindViewById<HslDialPlate>( Resource.Id.hslDialPlate2 );
			hslDialPlate3 = FindViewById<HslDialPlate>( Resource.Id.hslDialPlate3 );

			hslDialPlate2.SetMarkValues( new List<MarkValue>( )
			{
				new MarkValue(){Value = 7f, LineWidth = 3, Color = Color.Red},
				new MarkValue(){Value = 5.5f, LineWidth = 3, Color = Color.DodgerBlue}
			} );
			timer = new Timer( new TimerCallback( TimerTick ), null, 100, 300 );
		}

        private void TimerTick( object state )
        {
			count_tick++;

			RunOnUiThread( new Action( ( ) =>
			{
				float random1 = (float)(Math.Sin( 2 * Math.PI * count_tick / 30 ) * 0.5d + 0.5);
				float random2 = (float)(Math.Sin( 2 * Math.PI * count_tick / 50 ) * 0.5d + 0.5);
				float random3 = (float)(Math.Cos( 2 * Math.PI * count_tick / 80 ) * 0.5d + 0.5);

				hslDialPlate1.Value = random1 * 60 + 30;

				// 使用动画的更新方式
				hslDialPlate2.SetValueAnimator( random2 * 8 + 1 );
				hslDialPlate3.SetValueAnimator( random3 * 100 );
			} ) );
        }

		private long count_tick = 0;
		private Timer timer = null;

		private Random random = new Random( );
		private HslDialPlate hslDialPlate1 = null;
		private HslDialPlate hslDialPlate2 = null;
		private HslDialPlate hslDialPlate3 = null;
	}
}