namespace HslControlsDemo
{
    partial class FormCurveHistory3
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
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.hslCurveHistory1 = new HslControls.HslCurveHistory();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.hslCurveHistory2 = new HslControls.HslCurveHistory();
			this.button7 = new System.Windows.Forms.Button();
			this.hslCurveHistory3 = new HslControls.HslCurveHistory();
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
			this.button2.Location = new System.Drawing.Point(132, 606);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(59, 37);
			this.button2.TabIndex = 2;
			this.button2.Text = "0.5 倍";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button3.Location = new System.Drawing.Point(197, 606);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(59, 37);
			this.button3.TabIndex = 3;
			this.button3.Text = "1 倍";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button4.Location = new System.Drawing.Point(262, 606);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(59, 37);
			this.button4.TabIndex = 4;
			this.button4.Text = "2 倍";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// hslCurveHistory1
			// 
			this.hslCurveHistory1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.hslCurveHistory1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
			this.hslCurveHistory1.DashCoordinateColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
			this.hslCurveHistory1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.hslCurveHistory1.Location = new System.Drawing.Point(12, 30);
			this.hslCurveHistory1.MarkTextColor = System.Drawing.Color.Yellow;
			this.hslCurveHistory1.Name = "hslCurveHistory1";
			this.hslCurveHistory1.Size = new System.Drawing.Size(980, 200);
			this.hslCurveHistory1.TabIndex = 0;
			this.hslCurveHistory1.Text = "hslCurveHistory1";
			this.hslCurveHistory1.ReferenceAxisLeft.Unit = " ℃";
			this.hslCurveHistory1.ReferenceAxisRight.Unit = "Mpa";
			this.hslCurveHistory1.ReferenceAxisLeft.Max = 250F;
			this.hslCurveHistory1.ReferenceAxisRight.Max = 5F;
			this.hslCurveHistory1.ValueSegment = 10;
			this.hslCurveHistory1.onCurveDoubleClick += new HslControls.HslCurveHistory.CurveDoubleClick(this.hslCurveHistory1_onCurveDoubleClick);
			this.hslCurveHistory1.Click += new System.EventHandler(this.HslCurveHistory1_Click);
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
			// hslCurveHistory2
			// 
			this.hslCurveHistory2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.hslCurveHistory2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
			this.hslCurveHistory2.DashCoordinateColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
			this.hslCurveHistory2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.hslCurveHistory2.Location = new System.Drawing.Point(12, 213);
			this.hslCurveHistory2.MarkTextColor = System.Drawing.Color.Yellow;
			this.hslCurveHistory2.Name = "hslCurveHistory2";
			this.hslCurveHistory2.Size = new System.Drawing.Size(980, 200);
			this.hslCurveHistory2.TabIndex = 21;
			this.hslCurveHistory2.Text = "hslCurveHistory2";
			this.hslCurveHistory2.ReferenceAxisLeft.Unit = " ℃";
			this.hslCurveHistory2.ReferenceAxisRight.Unit = "Mpa";
			this.hslCurveHistory2.ReferenceAxisLeft.Max = 250F;
			this.hslCurveHistory2.ReferenceAxisRight.Max = 5F;
			this.hslCurveHistory2.ValueSegment = 10;
			this.hslCurveHistory2.Click += new System.EventHandler(this.HslCurveHistory1_Click);
			// 
			// button7
			// 
			this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button7.Location = new System.Drawing.Point(327, 606);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(59, 37);
			this.button7.TabIndex = 22;
			this.button7.Text = "32 倍";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// hslCurveHistory3
			// 
			this.hslCurveHistory3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.hslCurveHistory3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
			this.hslCurveHistory3.DashCoordinateColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
			this.hslCurveHistory3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.hslCurveHistory3.Location = new System.Drawing.Point(12, 396);
			this.hslCurveHistory3.MarkTextColor = System.Drawing.Color.Yellow;
			this.hslCurveHistory3.Name = "hslCurveHistory3";
			this.hslCurveHistory3.Size = new System.Drawing.Size(980, 200);
			this.hslCurveHistory3.TabIndex = 23;
			this.hslCurveHistory3.Text = "hslCurveHistory3";
			this.hslCurveHistory3.ReferenceAxisLeft.Unit = " ℃";
			this.hslCurveHistory3.ReferenceAxisRight.Unit = "Mpa";
			this.hslCurveHistory3.ReferenceAxisLeft.Max = 250F;
			this.hslCurveHistory3.ReferenceAxisRight.Max = 5F;
			this.hslCurveHistory3.ValueSegment = 10;
			// 
			// FormCurveHistory3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1004, 645);
			this.Controls.Add(this.hslCurveHistory3);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.hslCurveHistory2);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.hslCurveHistory1);
			this.Name = "FormCurveHistory3";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FormCurveHistory3";
			this.Load += new System.EventHandler(this.FormCurveHistory_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private HslControls.HslCurveHistory hslCurveHistory1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private HslControls.HslCurveHistory hslCurveHistory2;
		private System.Windows.Forms.Button button7;
		private HslControls.HslCurveHistory hslCurveHistory3;
	}
}