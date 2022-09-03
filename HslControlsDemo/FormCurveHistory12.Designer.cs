namespace HslControlsDemo
{
    partial class FormCurveHistory12
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
			this.label3 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.button7 = new System.Windows.Forms.Button();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.button8 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.button9 = new System.Windows.Forms.Button();
			this.hslCurveHistory1 = new HslControls.HslCurveHistory();
			this.button10 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
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
			// button7
			// 
			this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button7.Location = new System.Drawing.Point(646, 597);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(111, 37);
			this.button7.TabIndex = 21;
			this.button7.Text = "图片保存";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// checkBox3
			// 
			this.checkBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBox3.AutoSize = true;
			this.checkBox3.Checked = true;
			this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox3.Location = new System.Drawing.Point(932, 9);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(60, 16);
			this.checkBox3.TabIndex = 22;
			this.checkBox3.Text = "右坐标";
			this.checkBox3.UseVisualStyleBackColor = true;
			// 
			// button8
			// 
			this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button8.Location = new System.Drawing.Point(773, 603);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(87, 25);
			this.button8.TabIndex = 23;
			this.button8.Text = "滚动条右侧";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.Button8_Click);
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
			// hslCurveHistory1
			// 
			this.hslCurveHistory1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.hslCurveHistory1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
			this.hslCurveHistory1.ButtomHeight = 40;
			this.hslCurveHistory1.CurveRanges = null;
			this.hslCurveHistory1.DashCoordinateColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
			this.hslCurveHistory1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.hslCurveHistory1.IsAllowSelectSection = false;
			this.hslCurveHistory1.Location = new System.Drawing.Point(12, 30);
			this.hslCurveHistory1.MarkTextColor = System.Drawing.Color.Yellow;
			this.hslCurveHistory1.Name = "hslCurveHistory1";
			this.hslCurveHistory1.ReferenceAxisLeft.Max = 50F;
			this.hslCurveHistory1.ReferenceAxisLeft.Unit = " ℃";
			this.hslCurveHistory1.ReferenceAxisRight.Max = 5F;
			this.hslCurveHistory1.ReferenceAxisRight.Unit = "Mpa";
			this.hslCurveHistory1.RenderRightCoordinate = false;
			this.hslCurveHistory1.RightWidth = 10;
			this.hslCurveHistory1.Size = new System.Drawing.Size(980, 524);
			this.hslCurveHistory1.TabIndex = 0;
			this.hslCurveHistory1.Text = "hslCurveHistory1";
			this.hslCurveHistory1.ValueSegment = 10;
			this.hslCurveHistory1.onCurveDoubleClick += new HslControls.HslCurveHistory.CurveDoubleClick(this.hslCurveHistory1_onCurveDoubleClick);
			this.hslCurveHistory1.onCurveRangeSelect += new HslControls.HslCurveHistory.CurveRangeSelect(this.HslCurveHistory1_onCurveRangeSelect);
			this.hslCurveHistory1.Click += new System.EventHandler(this.HslCurveHistory1_Click);
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
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(10, 562);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(485, 24);
			this.label5.TabIndex = 27;
			this.label5.Text = "天气预报就是调大倍数，自定义设置倍数，然后点位携带图片\r\n此处多了一个技巧，当控件大小变化时，自动重新设置缩放倍率，确保能显示下所有的数据";
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button1.Location = new System.Drawing.Point(481, 596);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(114, 37);
			this.button1.TabIndex = 1;
			this.button1.Text = "加载";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// FormCurveHistory12
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1004, 645);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.checkBox3);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.hslCurveHistory1);
			this.Name = "FormCurveHistory12";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FormCurveHistory-天气预报";
			this.Load += new System.EventHandler(this.FormCurveHistory_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private HslControls.HslCurveHistory hslCurveHistory1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label5;
	}
}