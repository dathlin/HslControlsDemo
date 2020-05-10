namespace HslControlsDemo
{
    partial class FormBasic
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
			this.hslPlay2 = new HslControls.HslPlay();
			this.label1 = new System.Windows.Forms.Label();
			this.hslPlay1 = new HslControls.HslPlay();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.hslSwitch2 = new HslControls.HslSwitch();
			this.hslSwitch1 = new HslControls.HslSwitch();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.hslArrow9 = new HslControls.HslArrow();
			this.hslArrow8 = new HslControls.HslArrow();
			this.hslArrow7 = new HslControls.HslArrow();
			this.hslArrow6 = new HslControls.HslArrow();
			this.hslArrow5 = new HslControls.HslArrow();
			this.hslArrow4 = new HslControls.HslArrow();
			this.hslArrow3 = new HslControls.HslArrow();
			this.hslArrow2 = new HslControls.HslArrow();
			this.hslArrow1 = new HslControls.HslArrow();
			this.hslButton4 = new HslControls.HslButton();
			this.hslButton3 = new HslControls.HslButton();
			this.hslButton2 = new HslControls.HslButton();
			this.hslButton1 = new HslControls.HslButton();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.hslPlay2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.hslPlay1);
			this.groupBox1.Location = new System.Drawing.Point(29, 169);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(482, 216);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "开关的按钮";
			// 
			// hslPlay2
			// 
			this.hslPlay2.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.hslPlay2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.hslPlay2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.hslPlay2.ForeColor = System.Drawing.Color.DimGray;
			this.hslPlay2.Location = new System.Drawing.Point(172, 37);
			this.hslPlay2.Name = "hslPlay2";
			this.hslPlay2.Size = new System.Drawing.Size(132, 173);
			this.hslPlay2.TabIndex = 5;
			this.hslPlay2.Text = "hslPlay2";
			this.hslPlay2.Click += new System.EventHandler(this.HslButton1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(45, 167);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 12);
			this.label1.TabIndex = 4;
			this.label1.Text = "状态：";
			// 
			// hslPlay1
			// 
			this.hslPlay1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.hslPlay1.Location = new System.Drawing.Point(47, 37);
			this.hslPlay1.Name = "hslPlay1";
			this.hslPlay1.Size = new System.Drawing.Size(96, 110);
			this.hslPlay1.TabIndex = 3;
			this.hslPlay1.Text = "hslPlay1";
			this.hslPlay1.OnPlayChanged += new System.Action<object, bool>(this.hslPlay1_OnPlayChanged);
			this.hslPlay1.Click += new System.EventHandler(this.HslButton1_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.hslSwitch2);
			this.groupBox2.Controls.Add(this.hslSwitch1);
			this.groupBox2.Location = new System.Drawing.Point(29, 391);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(482, 326);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "开关按钮";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(45, 227);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 12);
			this.label2.TabIndex = 5;
			this.label2.Text = "状态：";
			// 
			// hslSwitch2
			// 
			this.hslSwitch2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.hslSwitch2.Location = new System.Drawing.Point(233, 49);
			this.hslSwitch2.Name = "hslSwitch2";
			this.hslSwitch2.Size = new System.Drawing.Size(183, 175);
			this.hslSwitch2.SwitchForeground = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
			this.hslSwitch2.SwitchStatusDescription = "关;开";
			this.hslSwitch2.TabIndex = 1;
			this.hslSwitch2.Text = "hslSwitch2";
			this.hslSwitch2.Click += new System.EventHandler(this.HslButton1_Click);
			// 
			// hslSwitch1
			// 
			this.hslSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.hslSwitch1.Location = new System.Drawing.Point(34, 49);
			this.hslSwitch1.Name = "hslSwitch1";
			this.hslSwitch1.Size = new System.Drawing.Size(183, 175);
			this.hslSwitch1.SwitchForeground = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
			this.hslSwitch1.TabIndex = 0;
			this.hslSwitch1.Text = "hslSwitch1";
			this.hslSwitch1.OnSwitchChanged += new System.Action<object, bool>(this.hslSwitch1_OnSwitchChanged);
			this.hslSwitch1.Click += new System.EventHandler(this.HslButton1_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.hslArrow9);
			this.groupBox3.Controls.Add(this.hslArrow8);
			this.groupBox3.Controls.Add(this.hslArrow7);
			this.groupBox3.Controls.Add(this.hslArrow6);
			this.groupBox3.Controls.Add(this.hslArrow5);
			this.groupBox3.Controls.Add(this.hslArrow4);
			this.groupBox3.Controls.Add(this.hslArrow3);
			this.groupBox3.Controls.Add(this.hslArrow2);
			this.groupBox3.Controls.Add(this.hslArrow1);
			this.groupBox3.Location = new System.Drawing.Point(517, 169);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(475, 342);
			this.groupBox3.TabIndex = 10;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "箭头";
			// 
			// hslArrow9
			// 
			this.hslArrow9.ArrowDirection = System.Windows.Forms.ArrowDirection.Down;
			this.hslArrow9.EdgeColor = System.Drawing.Color.Gray;
			this.hslArrow9.FactorX = 0.75F;
			this.hslArrow9.FactorY = 0.17F;
			this.hslArrow9.Location = new System.Drawing.Point(276, 204);
			this.hslArrow9.Name = "hslArrow9";
			this.hslArrow9.Size = new System.Drawing.Size(91, 124);
			this.hslArrow9.TabIndex = 8;
			this.hslArrow9.Text = "流量";
			this.hslArrow9.UseGradient = false;
			this.hslArrow9.Click += new System.EventHandler(this.HslButton1_Click);
			// 
			// hslArrow8
			// 
			this.hslArrow8.ArrowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.hslArrow8.ArrowDirection = System.Windows.Forms.ArrowDirection.Up;
			this.hslArrow8.EdgeColor = System.Drawing.Color.Gray;
			this.hslArrow8.FactorX = 0.85F;
			this.hslArrow8.FactorY = 0.27F;
			this.hslArrow8.ForeColor = System.Drawing.Color.DarkOrange;
			this.hslArrow8.Location = new System.Drawing.Point(207, 204);
			this.hslArrow8.Name = "hslArrow8";
			this.hslArrow8.Size = new System.Drawing.Size(48, 132);
			this.hslArrow8.TabIndex = 7;
			this.hslArrow8.Text = "出水口";
			this.hslArrow8.UseGradient = false;
			this.hslArrow8.Click += new System.EventHandler(this.HslButton1_Click);
			// 
			// hslArrow7
			// 
			this.hslArrow7.ArrowDirection = System.Windows.Forms.ArrowDirection.Left;
			this.hslArrow7.EdgeColor = System.Drawing.Color.Gray;
			this.hslArrow7.FactorX = 0.75F;
			this.hslArrow7.FactorY = 0.27F;
			this.hslArrow7.Location = new System.Drawing.Point(24, 242);
			this.hslArrow7.Name = "hslArrow7";
			this.hslArrow7.Size = new System.Drawing.Size(176, 49);
			this.hslArrow7.TabIndex = 6;
			this.hslArrow7.Text = "hslArrow7";
			this.hslArrow7.UseGradient = false;
			this.hslArrow7.Click += new System.EventHandler(this.HslButton1_Click);
			// 
			// hslArrow6
			// 
			this.hslArrow6.ArrowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.hslArrow6.EdgeColor = System.Drawing.Color.Gray;
			this.hslArrow6.FactorX = 0.75F;
			this.hslArrow6.FactorY = 0.27F;
			this.hslArrow6.Location = new System.Drawing.Point(24, 297);
			this.hslArrow6.Name = "hslArrow6";
			this.hslArrow6.Size = new System.Drawing.Size(176, 39);
			this.hslArrow6.TabIndex = 5;
			this.hslArrow6.Text = "出水口";
			this.hslArrow6.UseGradient = false;
			this.hslArrow6.Click += new System.EventHandler(this.HslButton1_Click);
			// 
			// hslArrow5
			// 
			this.hslArrow5.ArrowDirection = System.Windows.Forms.ArrowDirection.Down;
			this.hslArrow5.EdgeColor = System.Drawing.Color.Gray;
			this.hslArrow5.FactorX = 0.75F;
			this.hslArrow5.FactorY = 0.17F;
			this.hslArrow5.Location = new System.Drawing.Point(327, 25);
			this.hslArrow5.Name = "hslArrow5";
			this.hslArrow5.Size = new System.Drawing.Size(142, 173);
			this.hslArrow5.TabIndex = 4;
			this.hslArrow5.Text = "流量";
			this.hslArrow5.Click += new System.EventHandler(this.HslButton1_Click);
			// 
			// hslArrow4
			// 
			this.hslArrow4.ArrowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.hslArrow4.ArrowDirection = System.Windows.Forms.ArrowDirection.Up;
			this.hslArrow4.EdgeColor = System.Drawing.Color.Gray;
			this.hslArrow4.FactorX = 0.85F;
			this.hslArrow4.FactorY = 0.27F;
			this.hslArrow4.ForeColor = System.Drawing.Color.DarkOrange;
			this.hslArrow4.Location = new System.Drawing.Point(252, 25);
			this.hslArrow4.Name = "hslArrow4";
			this.hslArrow4.Size = new System.Drawing.Size(48, 173);
			this.hslArrow4.TabIndex = 3;
			this.hslArrow4.Text = "出水口";
			this.hslArrow4.Click += new System.EventHandler(this.HslButton1_Click);
			// 
			// hslArrow3
			// 
			this.hslArrow3.ArrowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.hslArrow3.EdgeColor = System.Drawing.Color.Gray;
			this.hslArrow3.FactorX = 0.75F;
			this.hslArrow3.FactorY = 0.27F;
			this.hslArrow3.Location = new System.Drawing.Point(24, 146);
			this.hslArrow3.Name = "hslArrow3";
			this.hslArrow3.Size = new System.Drawing.Size(176, 49);
			this.hslArrow3.TabIndex = 2;
			this.hslArrow3.Text = "出水口";
			this.hslArrow3.Click += new System.EventHandler(this.HslButton1_Click);
			// 
			// hslArrow2
			// 
			this.hslArrow2.ArrowDirection = System.Windows.Forms.ArrowDirection.Left;
			this.hslArrow2.EdgeColor = System.Drawing.Color.Gray;
			this.hslArrow2.FactorX = 0.75F;
			this.hslArrow2.FactorY = 0.27F;
			this.hslArrow2.Location = new System.Drawing.Point(24, 80);
			this.hslArrow2.Name = "hslArrow2";
			this.hslArrow2.Size = new System.Drawing.Size(176, 49);
			this.hslArrow2.TabIndex = 1;
			this.hslArrow2.Text = "hslArrow2";
			this.hslArrow2.Click += new System.EventHandler(this.HslButton1_Click);
			// 
			// hslArrow1
			// 
			this.hslArrow1.EdgeColor = System.Drawing.Color.Gray;
			this.hslArrow1.FactorX = 0.75F;
			this.hslArrow1.FactorY = 0.27F;
			this.hslArrow1.Location = new System.Drawing.Point(24, 25);
			this.hslArrow1.Name = "hslArrow1";
			this.hslArrow1.Size = new System.Drawing.Size(176, 49);
			this.hslArrow1.TabIndex = 0;
			this.hslArrow1.Text = "hslArrow1";
			this.hslArrow1.Click += new System.EventHandler(this.HslButton1_Click);
			// 
			// hslButton4
			// 
			this.hslButton4.CustomerInformation = null;
			this.hslButton4.Location = new System.Drawing.Point(593, 108);
			this.hslButton4.Name = "hslButton4";
			this.hslButton4.Selected = true;
			this.hslButton4.Size = new System.Drawing.Size(124, 44);
			this.hslButton4.TabIndex = 11;
			this.hslButton4.Text = "hslButton4";
			this.hslButton4.UseGradient = true;
			this.hslButton4.Click += new System.EventHandler(this.HslButton1_Click);
			// 
			// hslButton3
			// 
			this.hslButton3.CustomerInformation = null;
			this.hslButton3.Enabled = false;
			this.hslButton3.Location = new System.Drawing.Point(321, 108);
			this.hslButton3.Name = "hslButton3";
			this.hslButton3.Size = new System.Drawing.Size(124, 44);
			this.hslButton3.TabIndex = 2;
			this.hslButton3.Text = "hslButton3";
			this.hslButton3.Click += new System.EventHandler(this.HslButton1_Click);
			// 
			// hslButton2
			// 
			this.hslButton2.CustomerInformation = null;
			this.hslButton2.Location = new System.Drawing.Point(173, 108);
			this.hslButton2.Name = "hslButton2";
			this.hslButton2.Selected = true;
			this.hslButton2.Size = new System.Drawing.Size(124, 44);
			this.hslButton2.TabIndex = 1;
			this.hslButton2.Text = "hslButton2";
			this.hslButton2.Click += new System.EventHandler(this.HslButton1_Click);
			// 
			// hslButton1
			// 
			this.hslButton1.CustomerInformation = null;
			this.hslButton1.ForeColor = System.Drawing.Color.Black;
			this.hslButton1.Location = new System.Drawing.Point(29, 108);
			this.hslButton1.Name = "hslButton1";
			this.hslButton1.Size = new System.Drawing.Size(124, 44);
			this.hslButton1.TabIndex = 0;
			this.hslButton1.Text = "hslButton1";
			this.hslButton1.Click += new System.EventHandler(this.HslButton1_Click);
			// 
			// FormBasic
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1055, 645);
			this.Controls.Add(this.hslButton4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.hslButton3);
			this.Controls.Add(this.hslButton2);
			this.Controls.Add(this.hslButton1);
			this.Name = "FormBasic";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FormBasic";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private HslControls.HslButton hslButton1;
        private HslControls.HslButton hslButton2;
        private HslControls.HslButton hslButton3;
        private HslControls.HslPlay hslPlay1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private HslControls.HslPlay hslPlay2;
        private System.Windows.Forms.GroupBox groupBox2;
        private HslControls.HslSwitch hslSwitch2;
        private HslControls.HslSwitch hslSwitch1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private HslControls.HslArrow hslArrow5;
        private HslControls.HslArrow hslArrow4;
        private HslControls.HslArrow hslArrow3;
        private HslControls.HslArrow hslArrow2;
        private HslControls.HslArrow hslArrow1;
        private HslControls.HslArrow hslArrow8;
        private HslControls.HslArrow hslArrow7;
        private HslControls.HslArrow hslArrow6;
        private HslControls.HslArrow hslArrow9;
        private HslControls.HslButton hslButton4;
	}
}