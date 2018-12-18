using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HslControlsDemo
{
    public partial class FormLedDisplay : Form
    {
        public FormLedDisplay( )
        {
            InitializeComponent( );
        }

        private void button1_Click( object sender, EventArgs e )
        {
            try
            {
                hslLedDisplay7.DisplayNumber = int.Parse( textBox1.Text );
            }
            catch(Exception ex)
            {
                MessageBox.Show( "错误：" + ex.Message );
            }
        }

        private void button2_Click( object sender, EventArgs e )
        {
            try
            {
                hslLedDisplay7.LedNumberSize = int.Parse( textBox2.Text );
            }
            catch (Exception ex)
            {
                MessageBox.Show( "错误：" + ex.Message );
            }
        }

        private void button3_Click( object sender, EventArgs e )
        {
            try
            {
                hslLedDisplay7.DisplayText = textBox3.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show( "错误：" + ex.Message );
            }
        }

        private void FormLedDisplay_Load( object sender, EventArgs e )
        {
            timer.Tick += Timer_Tick;
            timer.Interval = 100;
            timer.Start( );
        }

        private void Timer_Tick( object sender, EventArgs e )
        {
            hslLedDisplay10.DisplayText = number.ToString( );
            number++;

            DateTime dt = DateTime.Now;
            if(number % 10 < 5)
            {
                hslLedDisplay12.DisplayText = $"{dt.Hour.ToString( "D2" )}:{dt.Minute.ToString( "D2" )}";
            }
            else
            {
                hslLedDisplay12.DisplayText = $"{dt.Hour.ToString( "D2" )} {dt.Minute.ToString( "D2" )}";
            }
        }

        private int number = 0;
        private Timer timer = new Timer( );
    }
}
