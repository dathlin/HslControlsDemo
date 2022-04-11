namespace HslControlsDemo
{
    partial class FormPieChart
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.hslPieChart5 = new HslControls.HslPieChart();
			this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.hslPieChart4 = new HslControls.HslPieChart();
			this.hslPieChart3 = new HslControls.HslPieChart();
			this.hslPieChart2 = new HslControls.HslPieChart();
			this.hslPieChart1 = new HslControls.HslPieChart();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.hslPieChart5);
			this.panel1.Location = new System.Drawing.Point(492, 257);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(480, 361);
			this.panel1.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(164, 334);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(180, 17);
			this.label2.TabIndex = 7;
			this.label2.Text = "起始角度设为了180, 并且顺时针";
			// 
			// hslPieChart5
			// 
			this.hslPieChart5.BackColor = System.Drawing.Color.Transparent;
			this.hslPieChart5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.hslPieChart5.Location = new System.Drawing.Point(44, 24);
			this.hslPieChart5.Name = "hslPieChart5";
			this.hslPieChart5.RotateDirection = HslControls.RotateDirection.ClockWise;
			this.hslPieChart5.Size = new System.Drawing.Size(417, 308);
			this.hslPieChart5.StartAngle = 180F;
			this.hslPieChart5.TabIndex = 4;
			this.hslPieChart5.Click += new System.EventHandler(this.HslPieChart1_Click);
			// 
			// fileSystemWatcher1
			// 
			this.fileSystemWatcher1.EnableRaisingEvents = true;
			this.fileSystemWatcher1.SynchronizingObject = this;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(165, 601);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(106, 17);
			this.label1.TabIndex = 6;
			this.label1.Text = "起始角度设为了90";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(406, 257);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 17);
			this.label3.TabIndex = 7;
			this.label3.Text = "显示了百分比";
			// 
			// hslPieChart4
			// 
			this.hslPieChart4.BackColor = System.Drawing.Color.Transparent;
			this.hslPieChart4.BorderColor = System.Drawing.Color.Silver;
			this.hslPieChart4.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.hslPieChart4.Location = new System.Drawing.Point(42, 290);
			this.hslPieChart4.Name = "hslPieChart4";
			this.hslPieChart4.Size = new System.Drawing.Size(381, 318);
			this.hslPieChart4.StartAngle = 90F;
			this.hslPieChart4.TabIndex = 3;
			this.hslPieChart4.Click += new System.EventHandler(this.HslPieChart1_Click);
			// 
			// hslPieChart3
			// 
			this.hslPieChart3.BackColor = System.Drawing.Color.Transparent;
			this.hslPieChart3.Location = new System.Drawing.Point(659, 42);
			this.hslPieChart3.Name = "hslPieChart3";
			this.hslPieChart3.Size = new System.Drawing.Size(224, 233);
			this.hslPieChart3.StartAngle = 0F;
			this.hslPieChart3.TabIndex = 2;
			this.hslPieChart3.Click += new System.EventHandler(this.HslPieChart1_Click);
			// 
			// hslPieChart2
			// 
			this.hslPieChart2.BackColor = System.Drawing.Color.Transparent;
			this.hslPieChart2.IsRenderPercent = true;
			this.hslPieChart2.Location = new System.Drawing.Point(336, 42);
			this.hslPieChart2.Name = "hslPieChart2";
			this.hslPieChart2.Size = new System.Drawing.Size(224, 233);
			this.hslPieChart2.StartAngle = 0F;
			this.hslPieChart2.TabIndex = 1;
			this.hslPieChart2.Click += new System.EventHandler(this.HslPieChart1_Click);
			// 
			// hslPieChart1
			// 
			this.hslPieChart1.BackColor = System.Drawing.Color.Transparent;
			this.hslPieChart1.Location = new System.Drawing.Point(42, 45);
			this.hslPieChart1.Name = "hslPieChart1";
			this.hslPieChart1.Size = new System.Drawing.Size(257, 239);
			this.hslPieChart1.StartAngle = 0F;
			this.hslPieChart1.TabIndex = 0;
			this.hslPieChart1.Click += new System.EventHandler(this.HslPieChart1_Click);
			// 
			// FormPieChart
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1004, 645);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.hslPieChart4);
			this.Controls.Add(this.hslPieChart3);
			this.Controls.Add(this.hslPieChart2);
			this.Controls.Add(this.hslPieChart1);
			this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Name = "FormPieChart";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "饼图控件";
			this.Load += new System.EventHandler(this.FormPieChart_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private HslControls.HslPieChart hslPieChart1;
        private HslControls.HslPieChart hslPieChart2;
        private HslControls.HslPieChart hslPieChart3;
        private HslControls.HslPieChart hslPieChart4;
        private HslControls.HslPieChart hslPieChart5;
		private System.Windows.Forms.Panel panel1;
		private System.IO.FileSystemWatcher fileSystemWatcher1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
	}
}