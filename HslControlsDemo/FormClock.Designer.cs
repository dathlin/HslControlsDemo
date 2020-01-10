namespace HslControlsDemo
{
    partial class FormClock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClock));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hslClock7 = new HslControls.HslClock();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hslClock3 = new HslControls.HslClock();
            this.hslClock2 = new HslControls.HslClock();
            this.hslClock1 = new HslControls.HslClock();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hslClock6 = new HslControls.HslClock();
            this.hslClock5 = new HslControls.HslClock();
            this.hslClock4 = new HslControls.HslClock();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hslClock7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.hslClock3);
            this.groupBox1.Controls.Add(this.hslClock2);
            this.groupBox1.Controls.Add(this.hslClock1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(966, 321);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "简单的使用";
            // 
            // hslClock7
            // 
            this.hslClock7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hslClock7.BackgroundImage")));
            this.hslClock7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hslClock7.IsShowCalendar = false;
            this.hslClock7.Location = new System.Drawing.Point(26, 216);
            this.hslClock7.Margin = new System.Windows.Forms.Padding(2);
            this.hslClock7.Name = "hslClock7";
            this.hslClock7.Size = new System.Drawing.Size(88, 93);
            this.hslClock7.TabIndex = 5;
            this.hslClock7.Click += new System.EventHandler(this.HslClock1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(696, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "秒针按照每秒钟行走，并调大字体";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "指针颜色变化，并显示日期";
            // 
            // hslClock3
            // 
            this.hslClock3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hslClock3.BackgroundImage")));
            this.hslClock3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hslClock3.IsSecondStep = true;
            this.hslClock3.IsShowCalendar = false;
            this.hslClock3.IsShowWeek = false;
            this.hslClock3.Location = new System.Drawing.Point(638, 20);
            this.hslClock3.Margin = new System.Windows.Forms.Padding(5);
            this.hslClock3.Name = "hslClock3";
            this.hslClock3.Size = new System.Drawing.Size(310, 274);
            this.hslClock3.TabIndex = 2;
            this.hslClock3.Text = "hslClock3";
            this.hslClock3.Click += new System.EventHandler(this.HslClock1_Click);
            // 
            // hslClock2
            // 
            this.hslClock2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hslClock2.BackgroundImage")));
            this.hslClock2.HourColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.hslClock2.IsShowCalendar = false;
            this.hslClock2.Location = new System.Drawing.Point(339, 30);
            this.hslClock2.MinuteColor = System.Drawing.Color.Blue;
            this.hslClock2.Name = "hslClock2";
            this.hslClock2.Size = new System.Drawing.Size(224, 220);
            this.hslClock2.TabIndex = 1;
            this.hslClock2.Text = "hslClock2";
            this.hslClock2.Click += new System.EventHandler(this.HslClock1_Click);
            // 
            // hslClock1
            // 
            this.hslClock1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hslClock1.BackgroundImage")));
            this.hslClock1.IsShowCalendar = false;
            this.hslClock1.Location = new System.Drawing.Point(26, 30);
            this.hslClock1.Name = "hslClock1";
            this.hslClock1.Size = new System.Drawing.Size(171, 196);
            this.hslClock1.TabIndex = 0;
            this.hslClock1.Text = "hslClock1";
            this.hslClock1.Click += new System.EventHandler(this.HslClock1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.groupBox2.Controls.Add(this.hslClock6);
            this.groupBox2.Controls.Add(this.hslClock5);
            this.groupBox2.Controls.Add(this.hslClock4);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 348);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(965, 276);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "深色主题下";
            // 
            // hslClock6
            // 
            this.hslClock6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hslClock6.BackgroundImage")));
            this.hslClock6.ClockBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.hslClock6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.hslClock6.HourColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.hslClock6.IsSecondStep = true;
            this.hslClock6.IsShowCalendar = false;
            this.hslClock6.Location = new System.Drawing.Point(638, 30);
            this.hslClock6.MinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hslClock6.Name = "hslClock6";
            this.hslClock6.SecondColor = System.Drawing.Color.Chartreuse;
            this.hslClock6.Size = new System.Drawing.Size(224, 222);
            this.hslClock6.TabIndex = 2;
            this.hslClock6.Text = "hslClock6";
            this.hslClock6.Click += new System.EventHandler(this.HslClock1_Click);
            // 
            // hslClock5
            // 
            this.hslClock5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hslClock5.BackgroundImage")));
            this.hslClock5.IsSecondStep = true;
            this.hslClock5.IsShowCalendar = false;
            this.hslClock5.Location = new System.Drawing.Point(325, 52);
            this.hslClock5.Name = "hslClock5";
            this.hslClock5.Size = new System.Drawing.Size(179, 190);
            this.hslClock5.TabIndex = 1;
            this.hslClock5.Text = "hslClock5";
            this.hslClock5.Click += new System.EventHandler(this.HslClock1_Click);
            // 
            // hslClock4
            // 
            this.hslClock4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hslClock4.BackgroundImage")));
            this.hslClock4.ClockBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.hslClock4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(196)))), ((int)(((byte)(216)))));
            this.hslClock4.IsShowCalendar = false;
            this.hslClock4.Location = new System.Drawing.Point(56, 52);
            this.hslClock4.Name = "hslClock4";
            this.hslClock4.SecondColor = System.Drawing.Color.LimeGreen;
            this.hslClock4.Size = new System.Drawing.Size(179, 190);
            this.hslClock4.TabIndex = 0;
            this.hslClock4.Text = "hslClock4";
            this.hslClock4.Click += new System.EventHandler(this.HslClock1_Click);
            // 
            // FormClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1004, 645);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormClock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "时钟控件的举例使用";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private HslControls.HslClock hslClock1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private HslControls.HslClock hslClock3;
        private HslControls.HslClock hslClock2;
        private System.Windows.Forms.GroupBox groupBox2;
        private HslControls.HslClock hslClock6;
        private HslControls.HslClock hslClock5;
        private HslControls.HslClock hslClock4;
        private HslControls.HslClock hslClock7;
    }
}