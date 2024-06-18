using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using HslCommunication.BasicFramework;

namespace HslControlsDemo
{
	public partial class FormCurveHistory9 : FormContent
	{
		public FormCurveHistory9( )
		{
			InitializeComponent();
		}
		private int eventSet = 0;
		private DateTime scrollTime = DateTime.Now.AddSeconds( -10 );

		private void button1_Click( object sender, EventArgs e )
		{
			hslCurveHistory1.Text = "正在加载数据...";
			hslCurveHistory1.RemoveAllCurve( );
			new Thread( new ThreadStart( ThreadReadExample1 ) ) { IsBackground = true }.Start( );
			if (System.Threading.Interlocked.Increment( ref eventSet ) == 1)
			{
				// 保证重复点击，只设置一次事件
				hslCurveHistory1.OnScrollChanged += HslCurveHistory1_OnScrollChanged;
			}
		}
		private void HslCurveHistory1_OnScrollChanged( HslControls.HslCurveHistory hslCurve, int scrollX, float scale, int offsetPaintScrollX )
		{
			// 更新当前鼠标操作的时间
			scrollTime = DateTime.Now;
		}

		private void ThreadReadExample1( )
		{
			Thread.Sleep( 100 );
			// 我们假定已经生成了这么多数据，快速就可以占满全部的曲线，方便测试功能，一般来说，初始化的长度都是0
			float[] data = new float[2900];
			float[] press = new float[2900];
			DateTime[] times = new DateTime[2900];
			// 放一些初始值进去，不然都是0了
			for (int j = 0; j < times.Length; j++)
			{
				data[j] = j % 150;
				times[j] = DateTime.Now.AddSeconds( j - times.Length );
			}

			// 缓存的数据区，如果滚动条动了，就先把数据放到缓存里
			float[] cache_data = new float[0];
			float[] cache_pressure = new float[0];
			DateTime[] cache_times = new DateTime[0];

			int i = 0;
			int dataMax = 3000;         // 本来数据显示的最大数量
			while (true)
			{
				Thread.Sleep( 200 );  // 模拟每隔200ms 获取到数据

				// 模拟获取到值
				float data_value = (float)(Math.Sin( 2 * Math.PI * i / 50 ) * 20 + 120);
				float press_value = (float)(Math.Sin( 2 * Math.PI * i / 100 ) * 0.5d + 4.1d);
				DateTime time_value = DateTime.Now;

				if (data.Length < dataMax)  // 如果数据没有满的话
				{
					HslCommunication.BasicFramework.SoftBasic.AddArrayData( ref data, new float[] { data_value }, dataMax ); // 最多3000个数
					HslCommunication.BasicFramework.SoftBasic.AddArrayData( ref press, new float[] { press_value }, dataMax ); // 最多3000个数
					HslCommunication.BasicFramework.SoftBasic.AddArrayData( ref times, new DateTime[] { time_value }, dataMax );

					// 显示出数据信息来
					Invoke( new Action( ( ) =>
					{
						hslCurveHistory1.SetLeftCurve( "温度", data, Color.DodgerBlue, HslControls.CurveStyle.LineSegment ); // Curve样式，实际很多种可选样式，虚线，点线
						hslCurveHistory1.SetRightCurve( "压力", press, Color.Tomato, HslControls.CurveStyle.LineSegment );
						hslCurveHistory1.SetDateTimes( times );

						// 如果鼠标操作的时候，就停止5秒不更新
						if ((DateTime.Now - scrollTime).TotalSeconds > 5)
						{
							hslCurveHistory1.ScrollToRight( ); // 直接滚动到最右侧
						}
						else
						{
							// 没有到5秒的时候
							hslCurveHistory1.RenderCurveUI( );
						}
					} ) );
				}
				else
				{
					// 如果当前进行了鼠标操作的话，新增的数据就先放到缓存区，缓存区可以设置非常大
					// 如果鼠标操作的时候，就停止5秒不更新
					if ((DateTime.Now - scrollTime).TotalSeconds > 5)
					{
						if (cache_data.Length > 0)  // 有缓存数据的话，就把缓存数据挪到曲线里
						{
							HslCommunication.BasicFramework.SoftBasic.AddArrayData( ref data, cache_data, dataMax ); // 最多3000个数
							HslCommunication.BasicFramework.SoftBasic.AddArrayData( ref press, cache_pressure, dataMax ); // 最多3000个数
							HslCommunication.BasicFramework.SoftBasic.AddArrayData( ref times, cache_times, dataMax );

							cache_data = new float[0];       // 然后把所有的数据清空
							cache_pressure = new float[0];
							cache_times = new DateTime[0];
						}

						HslCommunication.BasicFramework.SoftBasic.AddArrayData( ref data, new float[] { data_value }, dataMax ); // 最多3000个数
						HslCommunication.BasicFramework.SoftBasic.AddArrayData( ref press, new float[] { press_value }, dataMax ); // 最多3000个数
						HslCommunication.BasicFramework.SoftBasic.AddArrayData( ref times, new DateTime[] { time_value }, dataMax );
						// 显示出数据信息来
						Invoke( new Action( ( ) =>
						{
							hslCurveHistory1.SetLeftCurve( "温度", data, Color.DodgerBlue, HslControls.CurveStyle.LineSegment ); // Curve样式，实际很多种可选样式，虚线，点线
							hslCurveHistory1.SetRightCurve( "压力", press, Color.Tomato, HslControls.CurveStyle.LineSegment );
							hslCurveHistory1.SetDateTimes( times );
							hslCurveHistory1.ScrollToRight( ); // 直接滚动到最右侧
						} ) );
					}
					else
					{
						// 没有到5秒的时候，数据添加进缓存
						HslCommunication.BasicFramework.SoftBasic.AddArrayData( ref cache_data, new float[] { data_value }, dataMax ); // 最多3000个数
						HslCommunication.BasicFramework.SoftBasic.AddArrayData( ref cache_pressure, new float[] { press_value }, dataMax ); // 最多3000个数
						HslCommunication.BasicFramework.SoftBasic.AddArrayData( ref cache_times, new DateTime[] { time_value }, dataMax );
					}
				}

				i++;
			}
		}

		private void FormCurveHistory_Load( object sender, EventArgs e )
		{
			hslCurveHistory1.AddLeftAuxiliary( 172f );

			linkLabel1.Click += LinkLabel1_Click;
			checkBox3.CheckedChanged += CheckBox3_CheckedChanged;

			hslCurveHistory1.RenderCurveUI( );   // 这步很重要
			timer = new System.Windows.Forms.Timer( );
			timer.Interval = 50;
			timer.Tick += Timer_Tick;
			timer.Start( );
		}

		private Random random = new Random( );
		private System.Windows.Forms.Timer timer;
		private bool timerEnable = false;
		private float[] steps = new float[0];
		private float[] data = new float[0];
		private float[] press = new float[0];
		private DateTime[] times = new DateTime[0];
		private int timeTick = 0;

		private void Timer_Tick( object sender, EventArgs e )
		{
			if (timerEnable)
			{
				// 把数据新增到每一个数组里，并指定最大3000个数，再多就覆盖之前的
				SoftBasic.AddArrayData( ref steps, new float[] { random.Next( 10 ) }, 3000 );
				SoftBasic.AddArrayData( ref data, new float[] { (float)(Math.Sin( 2 * Math.PI * timeTick / 50 ) * 20 + 120) }, 3000 );
				SoftBasic.AddArrayData( ref times, new DateTime[] { DateTime.Now }, 3000 );
				SoftBasic.AddArrayData( ref press, new float[] { (float)(Math.Sin( 2 * Math.PI * timeTick / 100 ) * 0.5d + 4.1d) }, 3000 );

				hslCurveHistory1.SetLeftCurve( "步序", steps );
				hslCurveHistory1.SetLeftCurve( "温度", data, Color.DodgerBlue, HslControls.CurveStyle.Curve, "{0:F1} ℃" );
				hslCurveHistory1.SetRightCurve( "压力", press, Color.Tomato, HslControls.CurveStyle.Curve, "{0:F2} Mpa" );
				hslCurveHistory1.SetDateTimes( times );
				hslCurveHistory1.SetCurveVisible( "步序", false );   // 步序不是曲线信息，不用显示出来
				if (checkBox1.Checked)
					hslCurveHistory1.RenderCurveUI( stretchToFull: true );
				else
					hslCurveHistory1.ScrollToRight( );
				timeTick++;
			}
		}

		private void CheckBox3_CheckedChanged( object sender, EventArgs e )
		{
			hslCurveHistory1.RenderRightCoordinate = checkBox3.Checked;
		}

		private void LinkLabel1_Click( object sender, EventArgs e )
		{
			try
			{
				System.Diagnostics.Process.Start( linkLabel1.Text );
			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message );
			}
		}

		private void button2_Click( object sender, EventArgs e )
		{
			hslCurveHistory1.SetScaleByXAxis( 0.5f );
			hslCurveHistory1.RenderCurveUI( );
		}

		private void button3_Click( object sender, EventArgs e )
		{
			hslCurveHistory1.SetScaleByXAxis(1f );
			hslCurveHistory1.RenderCurveUI( );
		}

		private void button4_Click( object sender, EventArgs e )
		{
			hslCurveHistory1.SetScaleByXAxis( 2f );
			hslCurveHistory1.RenderCurveUI( );
		}

		private void hslCurveHistory1_onCurveDoubleClick( HslControls.HslCurveHistory hslCurve, int index, DateTime dateTime )
		{
			MessageBox.Show( $"Index: {index} Time:{dateTime.ToString( )}" );
		}

		private void button5_Click( object sender, EventArgs e )
		{
			if (int.TryParse( textBox1.Text, out int index ))
			{
				hslCurveHistory1.AddMarkText( new HslControls.HslMarkText( )
				{
					Index = index,
					CurveKey = "温度",
					MarkText = textBox2.Text,
					CircleBrush = Brushes.HotPink,
					TextBrush = Brushes.Pink
				} );
				hslCurveHistory1.RenderCurveUI( );
			}
			else
			{
				MessageBox.Show( "Input Error" );
			}
		}

		private void button6_Click( object sender, EventArgs e )
		{
			hslCurveHistory1.RemoveAllMarkText( );
			hslCurveHistory1.RenderCurveUI( );
		}

		private void button7_Click( object sender, EventArgs e )
		{
			SaveFileDialog fileDialog = new SaveFileDialog( );
			fileDialog.Filter = "图片|*.png";
			fileDialog.InitialDirectory = Application.StartupPath;
			if (fileDialog.ShowDialog( ) == DialogResult.OK)
			{
				hslCurveHistory1.SaveToBitmap( ).Save( fileDialog.FileName );
				MessageBox.Show( "保存成功!" );
			}
			fileDialog.Dispose( );
		}

		private void Button8_Click( object sender, EventArgs e )
		{
			hslCurveHistory1.ScrollToRight( );
		}

		private void HslCurveHistory1_onCurveRangeSelect( HslControls.HslCurveHistory hslCurve, HslControls.HslMarkForeSection foreSection )
		{
			label4.Text = DateTime.Now.ToString( "HH:mm:ss" ) + "  Start:" + foreSection.StartIndex + "  End:" + foreSection.EndIndex;
			foreSection.MarkText = "这是标记的自定义的数据";
		}

		private void Button9_Click( object sender, EventArgs e )
		{
			hslCurveHistory1.RemoveAllMarkMouseSection( );
			hslCurveHistory1.RenderCurveUI( );
		}

		private void HslCurveHistory1_Click( object sender, EventArgs e )
		{
			Control_Click( sender, e );
		}

		private void Button10_Click( object sender, EventArgs e )
		{
			hslCurveHistory1.ReferenceAxisLeft.Min = 80;
			hslCurveHistory1.RenderCurveUI( );
		}
	}
}
