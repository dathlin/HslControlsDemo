namespace HslControlsDemo
{
    partial class FormBarChartHorizon
	{
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.hslHorizonBarChart5 = new HslControls.HslHorizonBarChart();
			this.hslHorizonBarChart4 = new HslControls.HslHorizonBarChart();
			this.hslHorizonBarChart3 = new HslControls.HslHorizonBarChart();
			this.hslHorizonBarChart2 = new HslControls.HslHorizonBarChart();
			this.hslHorizonBarChart1 = new HslControls.HslHorizonBarChart();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 606);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(317, 12);
			this.label1.TabIndex = 7;
			this.label1.Text = "自定义格式数据内容，外加暗黑效果显示，柱状图颜色渐变";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(208, 167);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 12);
			this.label2.TabIndex = 13;
			this.label2.Text = "没有数据";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(705, 167);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 12);
			this.label3.TabIndex = 14;
			this.label3.Text = "设置数据";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(194, 346);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(125, 12);
			this.label4.TabIndex = 15;
			this.label4.Text = "变更颜色，柱状图变细";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(705, 346);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(101, 12);
			this.label5.TabIndex = 16;
			this.label5.Text = "每个都不同的颜色";
			// 
			// hslHorizonBarChart5
			// 
			this.hslHorizonBarChart5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
			this.hslHorizonBarChart5.ColorLinesAndText = System.Drawing.Color.Silver;
			this.hslHorizonBarChart5.ForeColor = System.Drawing.Color.White;
			this.hslHorizonBarChart5.Location = new System.Drawing.Point(12, 372);
			this.hslHorizonBarChart5.Name = "hslHorizonBarChart5";
			this.hslHorizonBarChart5.Size = new System.Drawing.Size(941, 210);
			this.hslHorizonBarChart5.TabIndex = 12;
			this.hslHorizonBarChart5.Text = "hslHorizonBarChart5";
			this.hslHorizonBarChart5.Title = "汽车销量排行榜";
			this.hslHorizonBarChart5.UseGradient = true;
			this.hslHorizonBarChart5.Click += new System.EventHandler(this.hslHorizonBarChart1_Click);
			// 
			// hslHorizonBarChart4
			// 
			this.hslHorizonBarChart4.Location = new System.Drawing.Point(505, 191);
			this.hslHorizonBarChart4.Name = "hslHorizonBarChart4";
			this.hslHorizonBarChart4.Size = new System.Drawing.Size(460, 152);
			this.hslHorizonBarChart4.TabIndex = 11;
			this.hslHorizonBarChart4.Text = "hslHorizonBarChart4";
			this.hslHorizonBarChart4.Click += new System.EventHandler(this.hslHorizonBarChart1_Click);
			// 
			// hslHorizonBarChart3
			// 
			this.hslHorizonBarChart3.BarPercentWidth = 0.6F;
			this.hslHorizonBarChart3.Location = new System.Drawing.Point(12, 191);
			this.hslHorizonBarChart3.Name = "hslHorizonBarChart3";
			this.hslHorizonBarChart3.Size = new System.Drawing.Size(460, 152);
			this.hslHorizonBarChart3.TabIndex = 10;
			this.hslHorizonBarChart3.Text = "hslHorizonBarChart3";
			this.hslHorizonBarChart3.Click += new System.EventHandler(this.hslHorizonBarChart1_Click);
			// 
			// hslHorizonBarChart2
			// 
			this.hslHorizonBarChart2.Location = new System.Drawing.Point(505, 12);
			this.hslHorizonBarChart2.Name = "hslHorizonBarChart2";
			this.hslHorizonBarChart2.Size = new System.Drawing.Size(460, 152);
			this.hslHorizonBarChart2.TabIndex = 9;
			this.hslHorizonBarChart2.Text = "hslHorizonBarChart2";
			this.hslHorizonBarChart2.Title = "月度排行榜";
			this.hslHorizonBarChart2.Click += new System.EventHandler(this.hslHorizonBarChart1_Click);
			// 
			// hslHorizonBarChart1
			// 
			this.hslHorizonBarChart1.Location = new System.Drawing.Point(12, 12);
			this.hslHorizonBarChart1.Name = "hslHorizonBarChart1";
			this.hslHorizonBarChart1.Size = new System.Drawing.Size(460, 152);
			this.hslHorizonBarChart1.TabIndex = 8;
			this.hslHorizonBarChart1.Text = "hslHorizonBarChart1";
			this.hslHorizonBarChart1.Click += new System.EventHandler(this.hslHorizonBarChart1_Click);
			// 
			// FormBarChartHorizon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1004, 645);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.hslHorizonBarChart5);
			this.Controls.Add(this.hslHorizonBarChart4);
			this.Controls.Add(this.hslHorizonBarChart3);
			this.Controls.Add(this.hslHorizonBarChart2);
			this.Controls.Add(this.hslHorizonBarChart1);
			this.Controls.Add(this.label1);
			this.Name = "FormBarChartHorizon";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "柱形图的示例demo";
			this.Load += new System.EventHandler(this.FormBarChart_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
		private HslControls.HslHorizonBarChart hslHorizonBarChart1;
		private HslControls.HslHorizonBarChart hslHorizonBarChart2;
		private HslControls.HslHorizonBarChart hslHorizonBarChart3;
		private HslControls.HslHorizonBarChart hslHorizonBarChart4;
		private HslControls.HslHorizonBarChart hslHorizonBarChart5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
	}
}