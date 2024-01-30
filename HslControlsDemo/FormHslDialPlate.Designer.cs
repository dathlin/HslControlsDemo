namespace HslControlsDemo
{
	partial class FormHslDialPlate
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
			HslControls.MarkValue markValue1 = new HslControls.MarkValue();
			HslControls.MarkValue markValue2 = new HslControls.MarkValue();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.hslDialPlate5 = new HslControls.HslDialPlate();
			this.hslDialPlate4 = new HslControls.HslDialPlate();
			this.hslDialPlate6 = new HslControls.HslDialPlate();
			this.hslDialPlate3 = new HslControls.HslDialPlate();
			this.hslDialPlate2 = new HslControls.HslDialPlate();
			this.hslDialPlate1 = new HslControls.HslDialPlate();
			this.button1 = new System.Windows.Forms.Button();
			this.hslDialPlate7 = new HslControls.HslDialPlate();
			this.label5 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(100, 257);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 17);
			this.label1.TabIndex = 3;
			this.label1.Text = "简单的使用";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(346, 332);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(140, 17);
			this.label2.TabIndex = 4;
			this.label2.Text = "设置单位，调整刻度数量";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(669, 404);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(233, 17);
			this.label3.TabIndex = 5;
			this.label3.Text = "设置特殊刻度，使用MarkValues集合修改";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.hslDialPlate5);
			this.panel1.Controls.Add(this.hslDialPlate4);
			this.panel1.Location = new System.Drawing.Point(35, 383);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(581, 250);
			this.panel1.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(132, 209);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(116, 17);
			this.label4.TabIndex = 5;
			this.label4.Text = "暗色效果及调整颜色";
			// 
			// hslDialPlate5
			// 
			this.hslDialPlate5.BoderColor2 = System.Drawing.Color.Gray;
			this.hslDialPlate5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.hslDialPlate5.CenterColor = System.Drawing.Color.DimGray;
			this.hslDialPlate5.DialPlateBackgroundColor = System.Drawing.Color.DimGray;
			this.hslDialPlate5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.hslDialPlate5.ForeColor = System.Drawing.Color.White;
			this.hslDialPlate5.Location = new System.Drawing.Point(212, 12);
			this.hslDialPlate5.MaxValue = 240F;
			this.hslDialPlate5.Name = "hslDialPlate5";
			this.hslDialPlate5.Segment = 12;
			this.hslDialPlate5.Size = new System.Drawing.Size(172, 194);
			this.hslDialPlate5.TabIndex = 1;
			this.hslDialPlate5.Click += new System.EventHandler(this.hslDialPlate1_Click);
			// 
			// hslDialPlate4
			// 
			this.hslDialPlate4.BoderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
			this.hslDialPlate4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.hslDialPlate4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.hslDialPlate4.Location = new System.Drawing.Point(18, 12);
			this.hslDialPlate4.MaxValue = 80F;
			this.hslDialPlate4.Name = "hslDialPlate4";
			this.hslDialPlate4.Size = new System.Drawing.Size(172, 194);
			this.hslDialPlate4.TabIndex = 0;
			this.hslDialPlate4.Click += new System.EventHandler(this.hslDialPlate1_Click);
			// 
			// hslDialPlate6
			// 
			this.hslDialPlate6.BoderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
			this.hslDialPlate6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.hslDialPlate6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.hslDialPlate6.IsRenderSegmentText = false;
			this.hslDialPlate6.Location = new System.Drawing.Point(653, 537);
			this.hslDialPlate6.Name = "hslDialPlate6";
			this.hslDialPlate6.Size = new System.Drawing.Size(90, 72);
			this.hslDialPlate6.TabIndex = 7;
			this.hslDialPlate6.Value = 40F;
			this.hslDialPlate6.Click += new System.EventHandler(this.hslDialPlate1_Click);
			// 
			// hslDialPlate3
			// 
			this.hslDialPlate3.BoderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
			this.hslDialPlate3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.hslDialPlate3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.hslDialPlate3.Location = new System.Drawing.Point(601, 36);
			markValue1.Color = System.Drawing.Color.Red;
			markValue1.LineWidth = 2F;
			markValue1.Value = 70F;
			markValue2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			markValue2.LineWidth = 1F;
			markValue2.Value = 55F;
			this.hslDialPlate3.MarkValues.Add(markValue1);
			this.hslDialPlate3.MarkValues.Add(markValue2);
			this.hslDialPlate3.Name = "hslDialPlate3";
			this.hslDialPlate3.Segment = 10;
			this.hslDialPlate3.Size = new System.Drawing.Size(350, 365);
			this.hslDialPlate3.TabIndex = 2;
			this.hslDialPlate3.Value = 52F;
			this.hslDialPlate3.Click += new System.EventHandler(this.hslDialPlate1_Click);
			// 
			// hslDialPlate2
			// 
			this.hslDialPlate2.BoderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
			this.hslDialPlate2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.hslDialPlate2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.hslDialPlate2.Location = new System.Drawing.Point(271, 36);
			this.hslDialPlate2.MaxValue = 10F;
			this.hslDialPlate2.Name = "hslDialPlate2";
			this.hslDialPlate2.Segment = 10;
			this.hslDialPlate2.Size = new System.Drawing.Size(280, 279);
			this.hslDialPlate2.TabIndex = 1;
			this.hslDialPlate2.UnitText = "×1000 rpm";
			this.hslDialPlate2.Value = 1.3F;
			this.hslDialPlate2.Click += new System.EventHandler(this.hslDialPlate1_Click);
			// 
			// hslDialPlate1
			// 
			this.hslDialPlate1.BoderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
			this.hslDialPlate1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.hslDialPlate1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.hslDialPlate1.Location = new System.Drawing.Point(35, 33);
			this.hslDialPlate1.Name = "hslDialPlate1";
			this.hslDialPlate1.Size = new System.Drawing.Size(202, 221);
			this.hslDialPlate1.TabIndex = 0;
			this.hslDialPlate1.Click += new System.EventHandler(this.hslDialPlate1_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(65, 306);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(126, 43);
			this.button1.TabIndex = 8;
			this.button1.Text = "随机设置值";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// hslDialPlate7
			// 
			this.hslDialPlate7.BoderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
			this.hslDialPlate7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.hslDialPlate7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.hslDialPlate7.Location = new System.Drawing.Point(772, 440);
			this.hslDialPlate7.MaxValue = 8F;
			this.hslDialPlate7.Name = "hslDialPlate7";
			this.hslDialPlate7.Size = new System.Drawing.Size(202, 169);
			this.hslDialPlate7.SmallScaleColor = System.Drawing.Color.Transparent;
			this.hslDialPlate7.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(834, 616);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(68, 17);
			this.label5.TabIndex = 10;
			this.label5.Text = "小刻度隐藏";
			// 
			// FormHslDialPlate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1004, 645);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.hslDialPlate7);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.hslDialPlate6);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.hslDialPlate3);
			this.Controls.Add(this.hslDialPlate2);
			this.Controls.Add(this.hslDialPlate1);
			this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "FormHslDialPlate";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FormHslDialPlate";
			this.Load += new System.EventHandler(this.FormHslDialPlate_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private HslControls.HslDialPlate hslDialPlate1;
		private HslControls.HslDialPlate hslDialPlate2;
		private HslControls.HslDialPlate hslDialPlate3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel1;
		private HslControls.HslDialPlate hslDialPlate5;
		private HslControls.HslDialPlate hslDialPlate4;
		private HslControls.HslDialPlate hslDialPlate6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private HslControls.HslDialPlate hslDialPlate7;
		private System.Windows.Forms.Label label5;
	}
}