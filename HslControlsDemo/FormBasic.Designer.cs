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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.hslArrow5 = new HslControls.HslArrow();
            this.hslArrow4 = new HslControls.HslArrow();
            this.hslArrow3 = new HslControls.HslArrow();
            this.hslArrow2 = new HslControls.HslArrow();
            this.hslArrow1 = new HslControls.HslArrow();
            this.hslSwitch2 = new HslControls.HslSwitch();
            this.hslSwitch1 = new HslControls.HslSwitch();
            this.hslPlay2 = new HslControls.HslPlay();
            this.hslPlay1 = new HslControls.HslPlay();
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
            this.groupBox1.Location = new System.Drawing.Point(29, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 216);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "开关的按钮";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.hslSwitch2);
            this.groupBox2.Controls.Add(this.hslSwitch1);
            this.groupBox2.Location = new System.Drawing.Point(29, 307);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.hslArrow5);
            this.groupBox3.Controls.Add(this.hslArrow4);
            this.groupBox3.Controls.Add(this.hslArrow3);
            this.groupBox3.Controls.Add(this.hslArrow2);
            this.groupBox3.Controls.Add(this.hslArrow1);
            this.groupBox3.Location = new System.Drawing.Point(517, 85);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(475, 226);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "箭头";
            // 
            // hslArrow5
            // 
            this.hslArrow5.ArrowDirection = System.Windows.Forms.ArrowDirection.Down;
            this.hslArrow5.EdgeColor = System.Drawing.Color.Gray;
            this.hslArrow5.FactorX = 0.75F;
            this.hslArrow5.FactorY = 0.17F;
            this.hslArrow5.Location = new System.Drawing.Point(315, 37);
            this.hslArrow5.Name = "hslArrow5";
            this.hslArrow5.Size = new System.Drawing.Size(142, 173);
            this.hslArrow5.TabIndex = 4;
            this.hslArrow5.Text = "流量";
            // 
            // hslArrow4
            // 
            this.hslArrow4.ArrowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.hslArrow4.ArrowDirection = System.Windows.Forms.ArrowDirection.Up;
            this.hslArrow4.EdgeColor = System.Drawing.Color.Gray;
            this.hslArrow4.FactorX = 0.85F;
            this.hslArrow4.FactorY = 0.27F;
            this.hslArrow4.ForeColor = System.Drawing.Color.DarkOrange;
            this.hslArrow4.Location = new System.Drawing.Point(250, 37);
            this.hslArrow4.Name = "hslArrow4";
            this.hslArrow4.Size = new System.Drawing.Size(48, 173);
            this.hslArrow4.TabIndex = 3;
            this.hslArrow4.Text = "出水口";
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
            // 
            // hslButton3
            // 
            this.hslButton3.CustomerInformation = null;
            this.hslButton3.Enabled = false;
            this.hslButton3.Location = new System.Drawing.Point(321, 24);
            this.hslButton3.Name = "hslButton3";
            this.hslButton3.Size = new System.Drawing.Size(124, 44);
            this.hslButton3.TabIndex = 2;
            this.hslButton3.Text = "hslButton3";
            // 
            // hslButton2
            // 
            this.hslButton2.CustomerInformation = null;
            this.hslButton2.Location = new System.Drawing.Point(173, 24);
            this.hslButton2.Name = "hslButton2";
            this.hslButton2.Selected = true;
            this.hslButton2.Size = new System.Drawing.Size(124, 44);
            this.hslButton2.TabIndex = 1;
            this.hslButton2.Text = "hslButton2";
            // 
            // hslButton1
            // 
            this.hslButton1.CustomerInformation = null;
            this.hslButton1.Location = new System.Drawing.Point(29, 24);
            this.hslButton1.Name = "hslButton1";
            this.hslButton1.Size = new System.Drawing.Size(124, 44);
            this.hslButton1.TabIndex = 0;
            this.hslButton1.Text = "hslButton1";
            // 
            // FormBasic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 645);
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
    }
}