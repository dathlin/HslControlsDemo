namespace HslControlsDemo
{
    partial class FormCncCenter
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.hslCncCenter5 = new HslControls.HslCncCenter();
            this.hslCncCenter4 = new HslControls.HslCncCenter();
            this.hslCncCenter3 = new HslControls.HslCncCenter();
            this.hslCncCenter2 = new HslControls.HslCncCenter();
            this.hslCncCenter1 = new HslControls.HslCncCenter();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "默认的样式";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "仓门关闭到一半的效果";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(719, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "仓门全部关闭的效果";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 559);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "设定仓门状态，范围0-100";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(216, 556);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 21);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "100";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 548);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "设定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(854, 548);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 34);
            this.button2.TabIndex = 13;
            this.button2.Text = "设定";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(729, 556);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 21);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(568, 559);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "设定仓门状态，范围0-100";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 605);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "正常设定。没有动画";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(618, 605);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(323, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "方法设定，有简单的动画，高级动画的版本请使用wpf版本。";
            // 
            // hslCncCenter5
            // 
            this.hslCncCenter5.Location = new System.Drawing.Point(501, 209);
            this.hslCncCenter5.Name = "hslCncCenter5";
            this.hslCncCenter5.Size = new System.Drawing.Size(472, 337);
            this.hslCncCenter5.TabIndex = 7;
            this.hslCncCenter5.Text = "hslCncCenter5";
            this.hslCncCenter5.Click += new System.EventHandler(this.HslCncCenter1_Click);
            // 
            // hslCncCenter4
            // 
            this.hslCncCenter4.Location = new System.Drawing.Point(23, 209);
            this.hslCncCenter4.Name = "hslCncCenter4";
            this.hslCncCenter4.Size = new System.Drawing.Size(472, 337);
            this.hslCncCenter4.TabIndex = 6;
            this.hslCncCenter4.Text = "hslCncCenter4";
            this.hslCncCenter4.Click += new System.EventHandler(this.HslCncCenter1_Click);
            // 
            // hslCncCenter3
            // 
            this.hslCncCenter3.CncDoorState = 100F;
            this.hslCncCenter3.LightGreen = true;
            this.hslCncCenter3.Location = new System.Drawing.Point(650, 12);
            this.hslCncCenter3.Name = "hslCncCenter3";
            this.hslCncCenter3.Size = new System.Drawing.Size(218, 154);
            this.hslCncCenter3.TabIndex = 4;
            this.hslCncCenter3.Text = "hslCncCenter3";
            this.hslCncCenter3.Click += new System.EventHandler(this.HslCncCenter1_Click);
            // 
            // hslCncCenter2
            // 
            this.hslCncCenter2.CncDoorState = 50F;
            this.hslCncCenter2.LightYellow = true;
            this.hslCncCenter2.Location = new System.Drawing.Point(341, 12);
            this.hslCncCenter2.Name = "hslCncCenter2";
            this.hslCncCenter2.Size = new System.Drawing.Size(218, 154);
            this.hslCncCenter2.TabIndex = 2;
            this.hslCncCenter2.Text = "hslCncCenter2";
            this.hslCncCenter2.Click += new System.EventHandler(this.HslCncCenter1_Click);
            // 
            // hslCncCenter1
            // 
            this.hslCncCenter1.LightRed = true;
            this.hslCncCenter1.Location = new System.Drawing.Point(12, 12);
            this.hslCncCenter1.Name = "hslCncCenter1";
            this.hslCncCenter1.Size = new System.Drawing.Size(218, 154);
            this.hslCncCenter1.TabIndex = 0;
            this.hslCncCenter1.Text = "hslCncCenter1";
            this.hslCncCenter1.Click += new System.EventHandler(this.HslCncCenter1_Click);
            // 
            // FormCncCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1004, 645);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hslCncCenter5);
            this.Controls.Add(this.hslCncCenter4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hslCncCenter3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hslCncCenter2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hslCncCenter1);
            this.Name = "FormCncCenter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "加工中心控件";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HslControls.HslCncCenter hslCncCenter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private HslControls.HslCncCenter hslCncCenter2;
        private System.Windows.Forms.Label label3;
        private HslControls.HslCncCenter hslCncCenter3;
        private HslControls.HslCncCenter hslCncCenter4;
        private HslControls.HslCncCenter hslCncCenter5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}