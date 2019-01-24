namespace HslControlsDemo
{
    partial class FormGanttDay
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
            this.hslGanttChart1 = new HslControls.HslGanttChart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hslGanttChart2 = new HslControls.HslGanttChart();
            this.hslGanttChart3 = new HslControls.HslGanttChart();
            this.hslGanttChart4 = new HslControls.HslGanttChart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hslGanttChart5 = new HslControls.HslGanttChart();
            this.hslGanttChart6 = new HslControls.HslGanttChart();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.hslGanttChart7 = new HslControls.HslGanttChart();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // hslGanttChart1
            // 
            this.hslGanttChart1.Location = new System.Drawing.Point(18, 31);
            this.hslGanttChart1.Name = "hslGanttChart1";
            this.hslGanttChart1.Size = new System.Drawing.Size(296, 65);
            this.hslGanttChart1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.hslGanttChart4);
            this.groupBox1.Controls.Add(this.hslGanttChart3);
            this.groupBox1.Controls.Add(this.hslGanttChart2);
            this.groupBox1.Controls.Add(this.hslGanttChart1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(980, 235);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "简单的使用";
            // 
            // hslGanttChart2
            // 
            this.hslGanttChart2.Location = new System.Drawing.Point(18, 134);
            this.hslGanttChart2.Name = "hslGanttChart2";
            this.hslGanttChart2.Size = new System.Drawing.Size(296, 65);
            this.hslGanttChart2.TabIndex = 1;
            this.hslGanttChart2.TimeSegment = 8;
            // 
            // hslGanttChart3
            // 
            this.hslGanttChart3.Location = new System.Drawing.Point(355, 31);
            this.hslGanttChart3.Name = "hslGanttChart3";
            this.hslGanttChart3.Size = new System.Drawing.Size(619, 65);
            this.hslGanttChart3.TabIndex = 2;
            this.hslGanttChart3.TimeCount = 31;
            this.hslGanttChart3.TimeFormate = "{0}";
            this.hslGanttChart3.TimeMax = 31;
            this.hslGanttChart3.TimeSegment = 31;
            // 
            // hslGanttChart4
            // 
            this.hslGanttChart4.GanttBackColor = System.Drawing.Color.Transparent;
            this.hslGanttChart4.Location = new System.Drawing.Point(355, 134);
            this.hslGanttChart4.Name = "hslGanttChart4";
            this.hslGanttChart4.Size = new System.Drawing.Size(619, 65);
            this.hslGanttChart4.TabIndex = 3;
            this.hslGanttChart4.TimeCount = 31;
            this.hslGanttChart4.TimeFormate = "{0}";
            this.hslGanttChart4.TimeMax = 31;
            this.hslGanttChart4.TimeSegment = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "区段设置";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(588, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "范围设置，用来表示一个月的情况";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(636, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "背景隐藏";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.hslGanttChart6);
            this.groupBox2.Controls.Add(this.hslGanttChart5);
            this.groupBox2.Location = new System.Drawing.Point(12, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(974, 172);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "动态更新";
            // 
            // hslGanttChart5
            // 
            this.hslGanttChart5.Location = new System.Drawing.Point(46, 50);
            this.hslGanttChart5.Name = "hslGanttChart5";
            this.hslGanttChart5.Size = new System.Drawing.Size(402, 65);
            this.hslGanttChart5.TabIndex = 1;
            // 
            // hslGanttChart6
            // 
            this.hslGanttChart6.Location = new System.Drawing.Point(507, 50);
            this.hslGanttChart6.Name = "hslGanttChart6";
            this.hslGanttChart6.Size = new System.Drawing.Size(402, 65);
            this.hslGanttChart6.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.groupBox3.Controls.Add(this.hslGanttChart7);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 431);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(974, 202);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "暗色主题";
            // 
            // hslGanttChart7
            // 
            this.hslGanttChart7.ForeColor = System.Drawing.Color.DarkGray;
            this.hslGanttChart7.GanttBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.hslGanttChart7.Location = new System.Drawing.Point(287, 64);
            this.hslGanttChart7.Name = "hslGanttChart7";
            this.hslGanttChart7.Size = new System.Drawing.Size(402, 75);
            this.hslGanttChart7.TabIndex = 1;
            // 
            // FormGanttDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 645);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormGanttDay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormGanttDay";
            this.Load += new System.EventHandler(this.FormGanttDay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private HslControls.HslGanttChart hslGanttChart1;
        private System.Windows.Forms.GroupBox groupBox1;
        private HslControls.HslGanttChart hslGanttChart2;
        private HslControls.HslGanttChart hslGanttChart3;
        private HslControls.HslGanttChart hslGanttChart4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private HslControls.HslGanttChart hslGanttChart6;
        private HslControls.HslGanttChart hslGanttChart5;
        private System.Windows.Forms.GroupBox groupBox3;
        private HslControls.HslGanttChart hslGanttChart7;
    }
}