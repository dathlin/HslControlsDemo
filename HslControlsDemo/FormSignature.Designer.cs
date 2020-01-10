namespace HslControlsDemo
{
    partial class FormSignature
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.hslSignature4 = new HslControls.HslSignature();
            this.hslSignature3 = new HslControls.HslSignature();
            this.hslSignature2 = new HslControls.HslSignature();
            this.hslSignature1 = new HslControls.HslSignature();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(748, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "调整样式";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "调整样式";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "禁止签名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 556);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "右键清除，或是点击下方清除";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 545);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 35);
            this.button1.TabIndex = 14;
            this.button1.Text = "清除";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(411, 545);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 35);
            this.button2.TabIndex = 15;
            this.button2.Text = "保存";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // hslSignature4
            // 
            this.hslSignature4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hslSignature4.Location = new System.Drawing.Point(78, 268);
            this.hslSignature4.Name = "hslSignature4";
            this.hslSignature4.Size = new System.Drawing.Size(817, 256);
            this.hslSignature4.TabIndex = 12;
            this.hslSignature4.Text = "hslSignature4";
            this.hslSignature4.Click += new System.EventHandler(this.HslFactory4_Click);
            // 
            // hslSignature3
            // 
            this.hslSignature3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.hslSignature3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hslSignature3.Location = new System.Drawing.Point(669, 36);
            this.hslSignature3.Name = "hslSignature3";
            this.hslSignature3.SignColor = System.Drawing.Color.Blue;
            this.hslSignature3.SignWidth = 2F;
            this.hslSignature3.Size = new System.Drawing.Size(226, 113);
            this.hslSignature3.TabIndex = 10;
            this.hslSignature3.Text = "hslSignature3";
            this.hslSignature3.Click += new System.EventHandler(this.HslFactory4_Click);
            // 
            // hslSignature2
            // 
            this.hslSignature2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.hslSignature2.Location = new System.Drawing.Point(362, 36);
            this.hslSignature2.Name = "hslSignature2";
            this.hslSignature2.SignColor = System.Drawing.Color.Blue;
            this.hslSignature2.SignWidth = 2F;
            this.hslSignature2.Size = new System.Drawing.Size(226, 113);
            this.hslSignature2.TabIndex = 8;
            this.hslSignature2.Text = "hslSignature2";
            this.hslSignature2.Click += new System.EventHandler(this.HslFactory4_Click);
            // 
            // hslSignature1
            // 
            this.hslSignature1.EnableSign = false;
            this.hslSignature1.Location = new System.Drawing.Point(78, 36);
            this.hslSignature1.Name = "hslSignature1";
            this.hslSignature1.Size = new System.Drawing.Size(226, 113);
            this.hslSignature1.TabIndex = 6;
            this.hslSignature1.Text = "hslSignature1";
            this.hslSignature1.Click += new System.EventHandler(this.HslFactory4_Click);
            // 
            // FormSignature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1004, 645);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hslSignature4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hslSignature3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hslSignature2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hslSignature1);
            this.Name = "FormSignature";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormSign";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private HslControls.HslSignature hslSignature3;
        private System.Windows.Forms.Label label2;
        private HslControls.HslSignature hslSignature2;
        private System.Windows.Forms.Label label1;
        private HslControls.HslSignature hslSignature1;
        private HslControls.HslSignature hslSignature4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}