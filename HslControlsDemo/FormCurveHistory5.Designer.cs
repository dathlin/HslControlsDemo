namespace HslControlsDemo
{
    partial class FormCurveHistory5
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
                components.Dispose();
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.button9 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.hslPanel1 = new HslControls.HslPanel();
			this.hslCurveHistory1 = new HslControls.HslCurveHistory();
			this.button3 = new System.Windows.Forms.Button();
			this.hslPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button1.Location = new System.Drawing.Point(12, 606);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(114, 37);
			this.button1.TabIndex = 1;
			this.button1.Text = "加载数据测试";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button2.Location = new System.Drawing.Point(147, 606);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(203, 37);
			this.button2.TabIndex = 2;
			this.button2.Text = "自定义缩放倍数";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button6
			// 
			this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button6.Location = new System.Drawing.Point(882, 613);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(86, 23);
			this.button6.TabIndex = 18;
			this.button6.Text = "移除所有";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button5
			// 
			this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button5.Location = new System.Drawing.Point(821, 614);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(55, 23);
			this.button5.TabIndex = 17;
			this.button5.Text = "增加";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(698, 619);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 12);
			this.label2.TabIndex = 16;
			this.label2.Text = "标注";
			// 
			// textBox2
			// 
			this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBox2.Location = new System.Drawing.Point(740, 614);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(75, 21);
			this.textBox2.TabIndex = 15;
			this.textBox2.Text = "标注信息";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(589, 618);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 12);
			this.label1.TabIndex = 14;
			this.label1.Text = "索引";
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBox1.Location = new System.Drawing.Point(631, 613);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(51, 21);
			this.textBox1.TabIndex = 13;
			this.textBox1.Text = "100";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 12);
			this.label3.TabIndex = 19;
			this.label3.Text = "详细博客：";
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(83, 9);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(287, 12);
			this.linkLabel1.TabIndex = 20;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "https://www.cnblogs.com/dathlin/p/10291327.html";
			// 
			// checkBox3
			// 
			this.checkBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBox3.AutoSize = true;
			this.checkBox3.Checked = true;
			this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox3.Location = new System.Drawing.Point(935, 9);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(60, 16);
			this.checkBox3.TabIndex = 22;
			this.checkBox3.Text = "右坐标";
			this.checkBox3.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(414, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 12);
			this.label4.TabIndex = 24;
			this.label4.Text = "选择信息";
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(700, 4);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(115, 23);
			this.button9.TabIndex = 25;
			this.button9.Text = "移除前景标记";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.Button9_Click);
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(821, 4);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(77, 23);
			this.button10.TabIndex = 26;
			this.button10.Text = "修改范围";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.Button10_Click);
			// 
			// hslPanel1
			// 
			this.hslPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.hslPanel1.BorderColor = System.Drawing.Color.IndianRed;
			this.hslPanel1.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(74)))));
			this.hslPanel1.Controls.Add(this.hslCurveHistory1);
			this.hslPanel1.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
			this.hslPanel1.Location = new System.Drawing.Point(10, 29);
			this.hslPanel1.Name = "hslPanel1";
			this.hslPanel1.Size = new System.Drawing.Size(985, 571);
			this.hslPanel1.TabIndex = 27;
			this.hslPanel1.Text = "hslPanel1";
			// 
			// hslCurveHistory1
			// 
			this.hslCurveHistory1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.hslCurveHistory1.BackColor = System.Drawing.Color.Transparent;
			this.hslCurveHistory1.CurveRanges = null;
			this.hslCurveHistory1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.hslCurveHistory1.Location = new System.Drawing.Point(5, 5);
			this.hslCurveHistory1.MarkTextColor = System.Drawing.Color.Yellow;
			this.hslCurveHistory1.Name = "hslCurveHistory1";
			this.hslCurveHistory1.ReferenceAxisLeft.Color = System.Drawing.Color.LightGreen;
			this.hslCurveHistory1.ReferenceAxisLeft.Max = 230F;
			this.hslCurveHistory1.ReferenceAxisLeft.Min = 30F;
			this.hslCurveHistory1.ReferenceAxisLeft.Unit = " ℃";
			this.hslCurveHistory1.ReferenceAxisRight.Max = 5F;
			this.hslCurveHistory1.ReferenceAxisRight.Unit = "Mpa";
			this.hslCurveHistory1.Size = new System.Drawing.Size(969, 564);
			this.hslCurveHistory1.TabIndex = 0;
			this.hslCurveHistory1.Text = "hslCurveHistory1";
			this.hslCurveHistory1.ValueSegment = 25;
			this.hslCurveHistory1.onCurveDoubleClick += new HslControls.HslCurveHistory.CurveDoubleClick(this.hslCurveHistory1_onCurveDoubleClick);
			this.hslCurveHistory1.onCurveRangeSelect += new HslControls.HslCurveHistory.CurveRangeSelect(this.HslCurveHistory1_onCurveRangeSelect);
			this.hslCurveHistory1.Click += new System.EventHandler(this.HslCurveHistory1_Click);
			// 
			// button3
			// 
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button3.Location = new System.Drawing.Point(383, 614);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(119, 23);
			this.button3.TabIndex = 28;
			this.button3.Text = "隐藏温度提示";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// FormCurveHistory5
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1007, 645);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.hslPanel1);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.checkBox3);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "FormCurveHistory5";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FormCurveHistory";
			this.Load += new System.EventHandler(this.FormCurveHistory_Load);
			this.hslPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private HslControls.HslCurveHistory hslCurveHistory1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
		private HslControls.HslPanel hslPanel1;
		private System.Windows.Forms.Button button3;
	}
}