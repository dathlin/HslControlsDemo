namespace HslControlsDemo
{
    partial class FormBarChart
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
			this.hslPanel1 = new HslControls.HslPanel();
			this.hslBarChart4 = new HslControls.HslBarChart();
			this.hslBarChart7 = new HslControls.HslBarChart();
			this.hslBarChart6 = new HslControls.HslBarChart();
			this.hslBarChart5 = new HslControls.HslBarChart();
			this.hslBarChart3 = new HslControls.HslBarChart();
			this.hslBarChart2 = new HslControls.HslBarChart();
			this.hslBarChart1 = new HslControls.HslBarChart();
			this.hslPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 624);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(401, 12);
			this.label1.TabIndex = 7;
			this.label1.Text = "举例应用，将1000以下和以上的颜色区分开来，并增加1000的辅助线标记。";
			// 
			// hslPanel1
			// 
			this.hslPanel1.CenterColor = System.Drawing.Color.LavenderBlush;
			this.hslPanel1.Controls.Add(this.hslBarChart4);
			this.hslPanel1.EdgeColor = System.Drawing.Color.Moccasin;
			this.hslPanel1.Location = new System.Drawing.Point(24, 203);
			this.hslPanel1.Name = "hslPanel1";
			this.hslPanel1.Size = new System.Drawing.Size(310, 209);
			this.hslPanel1.TabIndex = 8;
			this.hslPanel1.Text = "hslPanel1";
			// 
			// hslBarChart4
			// 
			this.hslBarChart4.BarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.hslBarChart4.BarPercentWidth = 0.5F;
			this.hslBarChart4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.hslBarChart4.Location = new System.Drawing.Point(0, 3);
			this.hslBarChart4.Name = "hslBarChart4";
			this.hslBarChart4.ShowBarValueFormat = "{0}";
			this.hslBarChart4.Size = new System.Drawing.Size(307, 203);
			this.hslBarChart4.TabIndex = 3;
			this.hslBarChart4.Text = "hslBarChart4";
			this.hslBarChart4.UseGradient = true;
			this.hslBarChart4.Click += new System.EventHandler(this.HslBarChart1_Click);
			// 
			// hslBarChart7
			// 
			this.hslBarChart7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
			this.hslBarChart7.BarBackColor = System.Drawing.Color.Gold;
			this.hslBarChart7.ColorDashLines = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
			this.hslBarChart7.ColorLinesAndText = System.Drawing.Color.Silver;
			this.hslBarChart7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.hslBarChart7.ForeColor = System.Drawing.Color.White;
			this.hslBarChart7.Location = new System.Drawing.Point(24, 418);
			this.hslBarChart7.Name = "hslBarChart7";
			this.hslBarChart7.ShowBarValueFormat = "{0}";
			this.hslBarChart7.Size = new System.Drawing.Size(968, 197);
			this.hslBarChart7.TabIndex = 6;
			this.hslBarChart7.Text = "hslBarChart7";
			this.hslBarChart7.Title = "月产量统计表";
			this.hslBarChart7.UseGradient = true;
			this.hslBarChart7.Click += new System.EventHandler(this.HslBarChart1_Click);
			// 
			// hslBarChart6
			// 
			this.hslBarChart6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
			this.hslBarChart6.BarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.hslBarChart6.ColorDashLines = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
			this.hslBarChart6.ColorLinesAndText = System.Drawing.Color.Silver;
			this.hslBarChart6.ForeColor = System.Drawing.Color.White;
			this.hslBarChart6.Location = new System.Drawing.Point(670, 203);
			this.hslBarChart6.Name = "hslBarChart6";
			this.hslBarChart6.ShowBarValueFormat = "{0}";
			this.hslBarChart6.Size = new System.Drawing.Size(324, 209);
			this.hslBarChart6.TabIndex = 5;
			this.hslBarChart6.Text = "hslBarChart6";
			this.hslBarChart6.UseGradient = true;
			this.hslBarChart6.Click += new System.EventHandler(this.HslBarChart1_Click);
			// 
			// hslBarChart5
			// 
			this.hslBarChart5.BackColor = System.Drawing.Color.White;
			this.hslBarChart5.BarBackColor = System.Drawing.Color.MediumOrchid;
			this.hslBarChart5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.hslBarChart5.Location = new System.Drawing.Point(340, 203);
			this.hslBarChart5.Name = "hslBarChart5";
			this.hslBarChart5.ShowBarValueFormat = "{0}";
			this.hslBarChart5.Size = new System.Drawing.Size(324, 209);
			this.hslBarChart5.TabIndex = 4;
			this.hslBarChart5.Text = "hslBarChart5";
			this.hslBarChart5.Title = "日产量统计表";
			this.hslBarChart5.UseGradient = true;
			this.hslBarChart5.Click += new System.EventHandler(this.HslBarChart1_Click);
			// 
			// hslBarChart3
			// 
			this.hslBarChart3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.hslBarChart3.Location = new System.Drawing.Point(668, 12);
			this.hslBarChart3.Name = "hslBarChart3";
			this.hslBarChart3.ShowBarValueFormat = "{0}";
			this.hslBarChart3.Size = new System.Drawing.Size(324, 197);
			this.hslBarChart3.TabIndex = 2;
			this.hslBarChart3.Text = "hslBarChart3";
			this.hslBarChart3.Title = "测试的信息";
			this.hslBarChart3.UseGradient = true;
			this.hslBarChart3.Click += new System.EventHandler(this.HslBarChart1_Click);
			// 
			// hslBarChart2
			// 
			this.hslBarChart2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.hslBarChart2.IsShowBarValue = false;
			this.hslBarChart2.Location = new System.Drawing.Point(340, 12);
			this.hslBarChart2.Name = "hslBarChart2";
			this.hslBarChart2.ShowBarValueFormat = "{0}";
			this.hslBarChart2.Size = new System.Drawing.Size(324, 197);
			this.hslBarChart2.TabIndex = 1;
			this.hslBarChart2.Text = "hslBarChart2";
			this.hslBarChart2.Click += new System.EventHandler(this.HslBarChart1_Click);
			// 
			// hslBarChart1
			// 
			this.hslBarChart1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.hslBarChart1.Location = new System.Drawing.Point(12, 12);
			this.hslBarChart1.Name = "hslBarChart1";
			this.hslBarChart1.ShowBarValueFormat = "{0}";
			this.hslBarChart1.Size = new System.Drawing.Size(308, 197);
			this.hslBarChart1.TabIndex = 0;
			this.hslBarChart1.Text = "hslBarChart1";
			this.hslBarChart1.Click += new System.EventHandler(this.HslBarChart1_Click);
			// 
			// FormBarChart
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1004, 645);
			this.Controls.Add(this.hslPanel1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.hslBarChart7);
			this.Controls.Add(this.hslBarChart6);
			this.Controls.Add(this.hslBarChart5);
			this.Controls.Add(this.hslBarChart3);
			this.Controls.Add(this.hslBarChart2);
			this.Controls.Add(this.hslBarChart1);
			this.Name = "FormBarChart";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "柱形图的示例demo";
			this.Load += new System.EventHandler(this.FormBarChart_Load);
			this.hslPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private HslControls.HslBarChart hslBarChart1;
        private HslControls.HslBarChart hslBarChart2;
        private HslControls.HslBarChart hslBarChart3;
        private HslControls.HslBarChart hslBarChart4;
        private HslControls.HslBarChart hslBarChart5;
        private HslControls.HslBarChart hslBarChart6;
        private HslControls.HslBarChart hslBarChart7;
        private System.Windows.Forms.Label label1;
        private HslControls.HslPanel hslPanel1;
    }
}