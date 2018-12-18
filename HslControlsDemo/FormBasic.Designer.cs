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
            this.hslSwitch2 = new HslControls.HslSwitch();
            this.hslSwitch1 = new HslControls.HslSwitch();
            this.hslPlay2 = new HslControls.HslPlay();
            this.hslPlay1 = new HslControls.HslPlay();
            this.hslButton3 = new HslControls.HslButton();
            this.hslButton2 = new HslControls.HslButton();
            this.hslButton1 = new HslControls.HslButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
    }
}