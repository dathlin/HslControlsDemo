﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HslControlsDemo
{
    public partial class FormBarChart : FormContent
    {
        public FormBarChart( )
        {
            InitializeComponent( );
        }

        private void FormBarChart_Load( object sender, EventArgs e )
        {
            //hslBarChart2.SetDataSource( new int[] { 1, 2, 4, 0, 3 }, new string[] { "周一", "周二", "周三", "周四", "周五" } );
            hslBarChart2.SetDataSource( new double[] { 1.5d, 2.8, 12.4d, 9.55d, 7d }, new string[] { "周一", "周二", "周三", "周四", "周五" } );
            hslBarChart3.SetDataSource( new int[] { 1, 2, 4, 0, 3 }, new string[] { "周一", "周二", "周三", "周四", "周五" } );
            


            hslBarChart4.SetDataSource( new int[] { random.Next(1500), random.Next( 1000 ), random.Next( 600 ), random.Next( 1500 ), random.Next( 800 ) }, 
                new string[] { "周一", "周二", "周三", "周四", "周五" } );
            hslBarChart4.AddLeftAuxiliary( 300, Color.Blue );

            hslBarChart5.SetDataSource( new int[] { random.Next( 1500 ), random.Next( 1000 ), random.Next( 600 ), random.Next( 1500 ), random.Next( 800 ) },
                new string[] { "周一", "周二", "周三", "周四", "周五" } );
            hslBarChart5.AddLeftAuxiliary( 300, Color.Blue, 1f, false );

            // 下面演示设置两种柱状同时显示的效果
            hslBarChart6.SetDataSource( new Dictionary<string, double[]>( )
            {
                { "上周产量", new double[] { random.Next( 1500 ), random.Next( 1000 ), random.Next( 600 ), random.Next( 1500 ), random.Next( 800 ), random.Next( 1500 ), random.Next( 800 ) } },
                { "本周产量" , new double[] { random.Next( 1500 ), random.Next( 1000 ), random.Next( 600 ), random.Next( 1500 ), random.Next( 800 ), random.Next( 1500 ), random.Next( 800 ) } }
            },
             new string[] { "周一", "周二", "周三", "周四", "周五", "周六", "周日" }, new Color[] { Color.Tomato, Color.DodgerBlue } );

            List<int> month = new List<int>( );
            List<string> days = new List<string>( );
            for (int i = 0; i < 31; i++)
            {
                month.Add( random.Next(1500) );
                days.Add( (i + 1).ToString( ) );
            }
            // 此处将小于1000的和大于1000的颜色区分开发
            hslBarChart7.SetDataSource( month.ToArray( ), days.ToArray( ), month.Select( m => m < 1000 ? Color.Orchid : Color.Gold ).ToArray( ) );
            hslBarChart7.AddLeftAuxiliary( 1000, Color.Yellow );



            //foreach(var control in components.Components)
            //{
            //    control
            //}
        }


        private Random random = new Random( );

        private void HslBarChart1_Click( object sender, EventArgs e )
        {
            Control_Click( sender, e );
        }
	}
}
