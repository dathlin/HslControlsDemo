namespace HslControlsDemo
{
    partial class FormCurve
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.hslCurve6 = new HslControls.HslCurve();
			this.hslCurve5 = new HslControls.HslCurve();
			this.hslCurve4 = new HslControls.HslCurve();
			this.hslCurve3 = new HslControls.HslCurve();
			this.hslCurve1 = new HslControls.HslCurve();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(444, 187);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 12);
			this.label1.TabIndex = 6;
			this.label1.Text = "静态的数据显示";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(145, 405);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(191, 12);
			this.label2.TabIndex = 7;
			this.label2.Text = "动态的数据刷新：3条曲线实时更新";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(682, 405);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(101, 12);
			this.label3.TabIndex = 8;
			this.label3.Text = "双坐标多曲线显示";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(76, 611);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(203, 12);
			this.label4.TabIndex = 9;
			this.label4.Text = "曲线平滑显示，曲线数据总数为100点";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(503, 612);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 21);
			this.textBox1.TabIndex = 10;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(620, 611);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(83, 23);
			this.button1.TabIndex = 11;
			this.button1.Text = "新增辅助线";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(709, 611);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(83, 23);
			this.button2.TabIndex = 12;
			this.button2.Text = "移除辅助线";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(849, 610);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(83, 23);
			this.button3.TabIndex = 13;
			this.button3.Text = "清空曲线";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(301, 606);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(101, 23);
			this.button4.TabIndex = 14;
			this.button4.Text = "保存图片";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// hslCurve6
			// 
			this.hslCurve6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
			this.hslCurve6.ColorDashLines = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.hslCurve6.ColorLinesAndText = System.Drawing.Color.LightGray;
			this.hslCurve6.FontCalibration = new System.Drawing.Font("宋体", 9F);
			this.hslCurve6.Location = new System.Drawing.Point(503, 425);
			this.hslCurve6.Name = "hslCurve6";
			this.hslCurve6.Size = new System.Drawing.Size(429, 172);
			this.hslCurve6.TabIndex = 5;
			this.hslCurve6.Click += new System.EventHandler(this.HslCurve1_Click);
			// 
			// hslCurve5
			// 
			this.hslCurve5.ColorDashLines = System.Drawing.Color.LightGray;
			this.hslCurve5.FontCalibration = new System.Drawing.Font("微软雅黑", 9F);
			this.hslCurve5.IntervalAbscissaText = 20;
			this.hslCurve5.IsAbscissaStrech = true;
			this.hslCurve5.IsRenderRightCoordinate = false;
			this.hslCurve5.Location = new System.Drawing.Point(24, 436);
			this.hslCurve5.Name = "hslCurve5";
			this.hslCurve5.ReferenceAxisLeft.Color = System.Drawing.Color.DimGray;
			this.hslCurve5.ReferenceAxisLeft.Max = 0F;
			this.hslCurve5.ReferenceAxisLeft.Min = -100F;
			this.hslCurve5.Size = new System.Drawing.Size(429, 172);
			this.hslCurve5.StrechDataCountMax = 100;
			this.hslCurve5.TabIndex = 4;
			this.hslCurve5.Click += new System.EventHandler(this.HslCurve1_Click);
			// 
			// hslCurve4
			// 
			this.hslCurve4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
			this.hslCurve4.ColorDashLines = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.hslCurve4.ColorLinesAndText = System.Drawing.Color.Silver;
			this.hslCurve4.FontCalibration = new System.Drawing.Font("微软雅黑", 12F);
			this.hslCurve4.IntervalAbscissaText = 30;
			this.hslCurve4.Location = new System.Drawing.Point(503, 221);
			this.hslCurve4.Name = "hslCurve4";
			this.hslCurve4.ReferenceAxisLeft.Max = 200F;
			this.hslCurve4.ReferenceAxisRight.Max = 5F;
			this.hslCurve4.Size = new System.Drawing.Size(429, 172);
			this.hslCurve4.TabIndex = 3;
			this.hslCurve4.Title = "温度压力实时曲线图";
			this.hslCurve4.Click += new System.EventHandler(this.HslCurve1_Click);
			// 
			// hslCurve3
			// 
			this.hslCurve3.ColorDashLines = System.Drawing.Color.LightGray;
			this.hslCurve3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.hslCurve3.FontCalibration = new System.Drawing.Font("微软雅黑", 9F);
			this.hslCurve3.IsRenderRightCoordinate = false;
			this.hslCurve3.Location = new System.Drawing.Point(24, 221);
			this.hslCurve3.Name = "hslCurve3";
			this.hslCurve3.ReferenceAxisLeft.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.hslCurve3.ReferenceAxisLeft.Unit = "℃";
			this.hslCurve3.Size = new System.Drawing.Size(429, 172);
			this.hslCurve3.TabIndex = 2;
			this.hslCurve3.Click += new System.EventHandler(this.HslCurve1_Click);
			// 
			// hslCurve1
			// 
			this.hslCurve1.ColorDashLines = System.Drawing.Color.LightGray;
			this.hslCurve1.FontCalibration = new System.Drawing.Font("微软雅黑", 9F);
			this.hslCurve1.IntervalAbscissaText = -1;
			this.hslCurve1.IsAbscissaStrech = true;
			this.hslCurve1.IsRenderRightCoordinate = false;
			this.hslCurve1.Location = new System.Drawing.Point(24, 12);
			this.hslCurve1.Name = "hslCurve1";
			this.hslCurve1.ReferenceAxisLeft.Color = System.Drawing.Color.DimGray;
			this.hslCurve1.ReferenceAxisLeft.Unit = "产量";
			this.hslCurve1.Size = new System.Drawing.Size(908, 172);
			this.hslCurve1.StrechDataCountMax = 12;
			this.hslCurve1.TabIndex = 0;
			this.hslCurve1.Title = "销售数据";
			this.hslCurve1.Click += new System.EventHandler(this.HslCurve1_Click);
			// 
			// FormCurve
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1004, 645);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.hslCurve6);
			this.Controls.Add(this.hslCurve5);
			this.Controls.Add(this.hslCurve4);
			this.Controls.Add(this.hslCurve3);
			this.Controls.Add(this.hslCurve1);
			this.Name = "FormCurve";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "曲线控件 (简易的实时曲线)";
			this.Load += new System.EventHandler(this.FormCurve_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private HslControls.HslCurve hslCurve1;
        private HslControls.HslCurve hslCurve3;
        private HslControls.HslCurve hslCurve5;
        private HslControls.HslCurve hslCurve6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private HslControls.HslCurve hslCurve4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}