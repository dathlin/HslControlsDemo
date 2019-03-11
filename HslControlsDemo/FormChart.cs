using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HslControls;
using HslControls.HslCharts;

namespace HslControlsDemo
{
    public partial class FormChart : Form
    {
        public FormChart()
        {
            InitializeComponent();

            int temp = r.Next(0, 10000);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    columnChart.Series[i].Values.Add(new ChartPoint());
                    columnChart.Series[i].Values[j].Y = r.Next(0, temp);
                }
            }
            
            myValues = lineMonitorChart.Series[0].Values;

            t = new Timer() { Interval = 200 };
            t.Tick += (s,e)=>
            {
                double y = Math.Sin(x / 180f * Math.PI) * 10d;
                myValues.Add(new ChartPoint(x, y));
                x += 20;
            };
        }
        
        private Timer t;

        private double x = 0d;

        private Random r = new Random();

        private ChartPointCollection myValues;
        
        private void btnChangeColumn_Click(object sender, EventArgs e)
        {
            int temp = r.Next(0, 10000);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    columnChart.Series[i].Values[j].Y = r.Next(0, temp);
                }
            }
        }

        private void btnChangeLine_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                double y = r.NextDouble();
                lineChart.Series[0].Values[i].Y = y;
                lineChart.Series[3].Values[i].Y = y;
            }
            for (int j = 0; j < 2; j++)
            {
                lineChart.Series[1].Values[j].X = r.NextDouble();
                lineChart.Series[1].Values[j].Y = r.NextDouble();
                lineChart.Series[2].Values[j].X = r.NextDouble();
                lineChart.Series[2].Values[j].Y = r.NextDouble();
            }
        }

        private void btnTimerSwitch_Click(object sender, EventArgs e)
        {
            t.Enabled = !t.Enabled;
            btnTimerSwitch.Text = t.Enabled ? "Stop" : "Start";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (t.Enabled)
                btnTimerSwitch_Click(null, EventArgs.Empty);
            x = 0d;
            myValues.Clear();
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            Bitmap b = lineMonitorChart.DrawImage(new Size(600, 500), Color.Black);
            b.Save(Application.StartupPath + string.Format(@"\LineMonitor.bmp"));
        }
        
        private void btnChangeMultipleAxes_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                multipleAxesChart.Series[0].Values[i].Y = r.Next(-100, 100);
                multipleAxesChart.Series[1].Values[i].Y = r.Next(0, 250);
            }
            
        }
    }
}
