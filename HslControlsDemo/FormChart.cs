using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HslControls.Charts;

namespace HslControlsDemo
{
    public partial class FormChart : FormContent
    {
        public FormChart()
        {
            InitializeComponent();

            LineMonitorChartInit();
        }
        
        private Random r = new Random();

        #region 在图表中绘制多种数据

        private void btnChangeBaseChart_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                double y = r.NextDouble();
                baseChart.Series[0].Points[i].Y = y;
                baseChart.Series[3].Points[i].Y = y;
            }
            for (int j = 0; j < 2; j++)
            {
                // 修改数据也是这样的轻松
                baseChart.Series[1].Points[j].X = r.NextDouble();
                baseChart.Series[1].Points[j].Y = r.NextDouble();
                baseChart.Series[2].Points[j].X = r.NextDouble();
                baseChart.Series[2].Points[j].Y = r.NextDouble();
            }
        }

        private Point pt;
        private void lineChart_MouseUp(object sender, MouseEventArgs e)
        {
            pt = e.Location;
        }
        
        #endregion

        #region 动态应用

        private ChartPointCollection points;

        private Timer timer;

        private double x = 0d;

        private void LineMonitorChartInit()
        {
            // 可以这样直接获取Series对象的数据点引用
            points = lineMonitorChart.Series[0].Points;
            timer = new Timer() { Interval = 200 };
            timer.Tick += (s, e) =>
            {
                // 下面是动态应用的数据添加代码，只需要向Series对象的Points属性种添加ChartPoint对象就可以动态添加数据。
                double y = Math.Sin(x / 180f * Math.PI) * 10d;
                points.Add(new ChartPoint(x, y));
                x += 20;
            };
        }
        
        private void btnTimerSwitch_Click(object sender, EventArgs e)
        {
            timer.Enabled = !timer.Enabled;
            btnTimerSwitch.Text = timer.Enabled ? "Stop" : "Start";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
                btnTimerSwitch_Click(null, EventArgs.Empty);
            x = 0d;
            // 清空Series对象的数据点
            points.Clear();
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            // 将控件内容绘制成指定尺寸的位图
            Bitmap bmp = new Bitmap(1080, 720);
            lineMonitorChart.DrawToBitmap(bmp);
            bmp.Save(Application.StartupPath + string.Format(@"\LineMonitor.bmp"));
        }

        #endregion

        #region 创建多坐标轴

        private void btnChangeMultipleAxes_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                multipleAxesChart.Series[0].Points[i].Y = r.Next(-100, 100) * i;
                multipleAxesChart.Series[1].Points[i].Y = r.Next(0, 250) * i;
            }
        }

        #endregion

        #region 时间型坐标轴

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            DateTime[] datetimes = new DateTime[10000];
            double[] values1 = new double[10000];
            double[] values2 = new double[10000];
            for (int i = 0; i < 10000; i++)
            {
                datetimes[i] = DateTime.Now.AddSeconds(i);
                values1[i] = r.Next(90, 100);
                values2[i] = r.Next(20, 30);
            }
            // 只需要使用下面这两个方法，就可以创建时间型坐标轴。
            timeAxisChart.AxisX[0].SetLabels(datetimes);
            timeAxisChart.AxisX[0].Visible = true;
            timeAxisChart.Series[0].SetValuesY(values1);
            timeAxisChart.Series[1].SetValuesY(values2);
        }

        #endregion

        private void BaseChart_Click( object sender, EventArgs e )
        {
            Control_Click( sender, e );
        }
    }
}
