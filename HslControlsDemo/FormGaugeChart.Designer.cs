namespace HslControlsDemo
{
    partial class FormGaugeChart
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hslGaugeChart1 = new HslControls.HslGaugeChart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hslGaugeChart2 = new HslControls.HslGaugeChart();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.hslGaugeChart3 = new HslControls.HslGaugeChart();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.hslGaugeChart4 = new HslControls.HslGaugeChart();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.hslGaugeChart5 = new HslControls.HslGaugeChart();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.hslGaugeChart6 = new HslControls.HslGaugeChart();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.hslGaugeChart7 = new HslControls.HslGaugeChart();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hslGaugeChart1);
            this.groupBox1.Location = new System.Drawing.Point(20, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 159);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "最基本的使用";
            // 
            // hslGaugeChart1
            // 
            this.hslGaugeChart1.Location = new System.Drawing.Point(0, 20);
            this.hslGaugeChart1.Name = "hslGaugeChart1";
            this.hslGaugeChart1.Size = new System.Drawing.Size(220, 120);
            this.hslGaugeChart1.TabIndex = 0;
            this.hslGaugeChart1.Click += new System.EventHandler(this.HslGaugeChart1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.hslGaugeChart2);
            this.groupBox2.Location = new System.Drawing.Point(254, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 159);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "调整范围并显示单位";
            // 
            // hslGaugeChart2
            // 
            this.hslGaugeChart2.Location = new System.Drawing.Point(-8, 14);
            this.hslGaugeChart2.Name = "hslGaugeChart2";
            this.hslGaugeChart2.SegmentCount = 8;
            this.hslGaugeChart2.Size = new System.Drawing.Size(235, 139);
            this.hslGaugeChart2.TabIndex = 0;
            this.hslGaugeChart2.UnitText = "* 1000 rad/s";
            this.hslGaugeChart2.ValueAlarmMax = 6D;
            this.hslGaugeChart2.ValueAlarmMin = 0D;
            this.hslGaugeChart2.ValueMax = 8D;
            this.hslGaugeChart2.Click += new System.EventHandler(this.HslGaugeChart1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.hslGaugeChart3);
            this.groupBox3.Location = new System.Drawing.Point(493, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(233, 159);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "调整颜色";
            // 
            // hslGaugeChart3
            // 
            this.hslGaugeChart3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.hslGaugeChart3.GaugeBorder = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.hslGaugeChart3.Location = new System.Drawing.Point(-8, 14);
            this.hslGaugeChart3.Name = "hslGaugeChart3";
            this.hslGaugeChart3.PointerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.hslGaugeChart3.SegmentCount = 8;
            this.hslGaugeChart3.Size = new System.Drawing.Size(235, 139);
            this.hslGaugeChart3.TabIndex = 0;
            this.hslGaugeChart3.UnitText = "* 1000 rad/s";
            this.hslGaugeChart3.ValueAlarmMax = 6D;
            this.hslGaugeChart3.ValueAlarmMin = 0D;
            this.hslGaugeChart3.ValueMax = 8D;
            this.hslGaugeChart3.Click += new System.EventHandler(this.HslGaugeChart1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.hslGaugeChart4);
            this.groupBox4.Location = new System.Drawing.Point(732, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(233, 159);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "数值动态效果";
            // 
            // hslGaugeChart4
            // 
            this.hslGaugeChart4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.hslGaugeChart4.GaugeBorder = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.hslGaugeChart4.Location = new System.Drawing.Point(-8, 14);
            this.hslGaugeChart4.Name = "hslGaugeChart4";
            this.hslGaugeChart4.PointerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.hslGaugeChart4.SegmentCount = 8;
            this.hslGaugeChart4.Size = new System.Drawing.Size(235, 139);
            this.hslGaugeChart4.TabIndex = 0;
            this.hslGaugeChart4.UnitText = "* 1000 rad/s";
            this.hslGaugeChart4.ValueAlarmMax = 6D;
            this.hslGaugeChart4.ValueAlarmMin = 0D;
            this.hslGaugeChart4.ValueMax = 8D;
            this.hslGaugeChart4.Click += new System.EventHandler(this.HslGaugeChart1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.hslGaugeChart5);
            this.groupBox5.Location = new System.Drawing.Point(20, 394);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(220, 239);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "大于半圆的情况";
            // 
            // hslGaugeChart5
            // 
            this.hslGaugeChart5.IsBigSemiCircle = true;
            this.hslGaugeChart5.Location = new System.Drawing.Point(0, 20);
            this.hslGaugeChart5.Name = "hslGaugeChart5";
            this.hslGaugeChart5.Size = new System.Drawing.Size(214, 191);
            this.hslGaugeChart5.TabIndex = 0;
            this.hslGaugeChart5.ValueMax = 200D;
            this.hslGaugeChart5.Click += new System.EventHandler(this.HslGaugeChart1_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.groupBox6.Controls.Add(this.hslGaugeChart6);
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(20, 182);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(348, 206);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "深色主题下效果";
            // 
            // hslGaugeChart6
            // 
            this.hslGaugeChart6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hslGaugeChart6.ForeColor = System.Drawing.Color.White;
            this.hslGaugeChart6.GaugeBorder = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.hslGaugeChart6.Location = new System.Drawing.Point(0, 20);
            this.hslGaugeChart6.Margin = new System.Windows.Forms.Padding(4);
            this.hslGaugeChart6.Name = "hslGaugeChart6";
            this.hslGaugeChart6.PointerColor = System.Drawing.Color.Lime;
            this.hslGaugeChart6.Size = new System.Drawing.Size(332, 180);
            this.hslGaugeChart6.TabIndex = 0;
            this.hslGaugeChart6.Click += new System.EventHandler(this.HslGaugeChart1_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.hslGaugeChart7);
            this.groupBox7.Location = new System.Drawing.Point(377, 182);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(582, 331);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "超大号控件，字体调整";
            // 
            // hslGaugeChart7
            // 
            this.hslGaugeChart7.Font = new System.Drawing.Font("华文细黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hslGaugeChart7.GaugeBorder = System.Drawing.Color.Blue;
            this.hslGaugeChart7.Location = new System.Drawing.Point(0, 20);
            this.hslGaugeChart7.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.hslGaugeChart7.Name = "hslGaugeChart7";
            this.hslGaugeChart7.Size = new System.Drawing.Size(531, 292);
            this.hslGaugeChart7.TabIndex = 0;
            this.hslGaugeChart7.UnitText = "℃";
            this.hslGaugeChart7.Click += new System.EventHandler(this.HslGaugeChart1_Click);
            // 
            // FormGaugeChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1004, 645);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormGaugeChart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "仪表盘的示例";
            this.Load += new System.EventHandler(this.FormGaugeChart_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private HslControls.HslGaugeChart hslGaugeChart1;
        private System.Windows.Forms.GroupBox groupBox2;
        private HslControls.HslGaugeChart hslGaugeChart2;
        private System.Windows.Forms.GroupBox groupBox3;
        private HslControls.HslGaugeChart hslGaugeChart3;
        private System.Windows.Forms.GroupBox groupBox4;
        private HslControls.HslGaugeChart hslGaugeChart4;
        private System.Windows.Forms.GroupBox groupBox5;
        private HslControls.HslGaugeChart hslGaugeChart5;
        private System.Windows.Forms.GroupBox groupBox6;
        private HslControls.HslGaugeChart hslGaugeChart6;
        private System.Windows.Forms.GroupBox groupBox7;
        private HslControls.HslGaugeChart hslGaugeChart7;
    }
}