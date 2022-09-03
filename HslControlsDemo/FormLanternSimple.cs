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
    public partial class FormLanternSimple : FormContent
    {
        public FormLanternSimple( )
        {
            InitializeComponent( );
        }

        private void FormLanternSimple_Load( object sender, EventArgs e )
        {
            timer = new Timer( );
            timer.Interval = 500;
            timer.Tick += Timer_Tick;
            timer.Start( );
        }

        private void Timer_Tick( object sender, EventArgs e )
        {
            if (hslLanternSimple8.LanternBackground != Color.LimeGreen)
            {
                hslLanternSimple8.LanternBackground = Color.LimeGreen;
            }
            else
            {
                hslLanternSimple8.LanternBackground = Color.DarkOrange;
            }

            if(hslLanternSimple9.LanternBackground != Color.LimeGreen)
            {
                hslLanternSimple9.LanternBackground = Color.LimeGreen;
            }
            else
            {
                hslLanternSimple9.LanternBackground = Color.DarkOrange;
            }
        }

        private Timer timer = null;

        private void HslLanternSimple8_Click( object sender, EventArgs e )
        {
            Control_Click( sender, e );
        }

        private void button1_Click( object sender, EventArgs e )
        {
            hslLanternAlarm4.IsAlarm = true;
            hslLanternAlarm5.IsAlarm = true;
        }

        private void button2_Click( object sender, EventArgs e )
        {
            hslLanternAlarm4.IsAlarm = false;
            hslLanternAlarm5.IsAlarm = false;
        }
    }
}
