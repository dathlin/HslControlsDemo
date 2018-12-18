namespace HslControlsDemo
{
    partial class FormLedDisplay
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hslLedDisplay7 = new HslControls.HslLedDisplay();
            this.hslLedDisplay12 = new HslControls.HslLedDisplay();
            this.hslLedDisplay11 = new HslControls.HslLedDisplay();
            this.hslLedDisplay10 = new HslControls.HslLedDisplay();
            this.hslLedDisplay9 = new HslControls.HslLedDisplay();
            this.hslLedDisplay3 = new HslControls.HslLedDisplay();
            this.hslLedDisplay8 = new HslControls.HslLedDisplay();
            this.hslLedDisplay6 = new HslControls.HslLedDisplay();
            this.hslLedDisplay5 = new HslControls.HslLedDisplay();
            this.hslLedDisplay4 = new HslControls.HslLedDisplay();
            this.hslLedDisplay2 = new HslControls.HslLedDisplay();
            this.hslLedDisplay1 = new HslControls.HslLedDisplay();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hslLedDisplay1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(986, 124);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "支持的字符集：0123456789AbCcdEFHhJLoPrU:-";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.hslLedDisplay8);
            this.groupBox2.Controls.Add(this.hslLedDisplay6);
            this.groupBox2.Controls.Add(this.hslLedDisplay5);
            this.groupBox2.Controls.Add(this.hslLedDisplay4);
            this.groupBox2.Controls.Add(this.hslLedDisplay2);
            this.groupBox2.Location = new System.Drawing.Point(12, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 251);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "迷你的LED";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.hslLedDisplay12);
            this.groupBox3.Controls.Add(this.hslLedDisplay11);
            this.groupBox3.Controls.Add(this.hslLedDisplay10);
            this.groupBox3.Controls.Add(this.hslLedDisplay9);
            this.groupBox3.Controls.Add(this.hslLedDisplay3);
            this.groupBox3.Location = new System.Drawing.Point(231, 142);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(767, 251);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "大号的的LED";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.hslLedDisplay7);
            this.groupBox4.Location = new System.Drawing.Point(12, 416);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(986, 217);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "自定义的设置测试";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(862, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 26);
            this.button3.TabIndex = 9;
            this.button3.Text = "确定";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(862, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 26);
            this.button2.TabIndex = 8;
            this.button2.Text = "确定";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(862, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 7;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(709, 104);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(147, 23);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "1234";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(599, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "文本设置：";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(709, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(147, 23);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "12";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(599, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "数字的线条宽度：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(709, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "7";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(599, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "显示的数据位数：";
            // 
            // hslLedDisplay7
            // 
            this.hslLedDisplay7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.hslLedDisplay7.DisplayBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.hslLedDisplay7.DisplayNumber = 7;
            this.hslLedDisplay7.LedNumberSize = 10;
            this.hslLedDisplay7.Location = new System.Drawing.Point(20, 39);
            this.hslLedDisplay7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hslLedDisplay7.Name = "hslLedDisplay7";
            this.hslLedDisplay7.Size = new System.Drawing.Size(563, 136);
            this.hslLedDisplay7.TabIndex = 0;
            // 
            // hslLedDisplay12
            // 
            this.hslLedDisplay12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.hslLedDisplay12.DisplayBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.hslLedDisplay12.DisplayNumber = 5;
            this.hslLedDisplay12.DisplayText = "12:00";
            this.hslLedDisplay12.ForeColor = System.Drawing.Color.Pink;
            this.hslLedDisplay12.LedNumberSize = 2;
            this.hslLedDisplay12.Location = new System.Drawing.Point(555, 203);
            this.hslLedDisplay12.Margin = new System.Windows.Forms.Padding(3, 16, 3, 16);
            this.hslLedDisplay12.Name = "hslLedDisplay12";
            this.hslLedDisplay12.Size = new System.Drawing.Size(113, 33);
            this.hslLedDisplay12.TabIndex = 8;
            // 
            // hslLedDisplay11
            // 
            this.hslLedDisplay11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.hslLedDisplay11.DisplayBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.hslLedDisplay11.DisplayNumber = 8;
            this.hslLedDisplay11.DisplayText = "1.2.3.4.5";
            this.hslLedDisplay11.ForeColor = System.Drawing.Color.Cyan;
            this.hslLedDisplay11.LedNumberSize = 2;
            this.hslLedDisplay11.Location = new System.Drawing.Point(358, 203);
            this.hslLedDisplay11.Margin = new System.Windows.Forms.Padding(3, 11, 3, 11);
            this.hslLedDisplay11.Name = "hslLedDisplay11";
            this.hslLedDisplay11.Size = new System.Drawing.Size(171, 33);
            this.hslLedDisplay11.TabIndex = 7;
            // 
            // hslLedDisplay10
            // 
            this.hslLedDisplay10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.hslLedDisplay10.DisplayBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.hslLedDisplay10.DisplayNumber = 8;
            this.hslLedDisplay10.DisplayText = "0";
            this.hslLedDisplay10.ForeColor = System.Drawing.Color.Yellow;
            this.hslLedDisplay10.LedNumberSize = 2;
            this.hslLedDisplay10.Location = new System.Drawing.Point(197, 203);
            this.hslLedDisplay10.Margin = new System.Windows.Forms.Padding(3, 11, 3, 11);
            this.hslLedDisplay10.Name = "hslLedDisplay10";
            this.hslLedDisplay10.Size = new System.Drawing.Size(155, 33);
            this.hslLedDisplay10.TabIndex = 6;
            // 
            // hslLedDisplay9
            // 
            this.hslLedDisplay9.BackColor = System.Drawing.Color.Transparent;
            this.hslLedDisplay9.DisplayBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.hslLedDisplay9.DisplayNumber = 8;
            this.hslLedDisplay9.DisplayText = "123.45";
            this.hslLedDisplay9.ForeColor = System.Drawing.Color.Black;
            this.hslLedDisplay9.LedNumberSize = 2;
            this.hslLedDisplay9.Location = new System.Drawing.Point(20, 203);
            this.hslLedDisplay9.Margin = new System.Windows.Forms.Padding(3, 11, 3, 11);
            this.hslLedDisplay9.Name = "hslLedDisplay9";
            this.hslLedDisplay9.Size = new System.Drawing.Size(160, 33);
            this.hslLedDisplay9.TabIndex = 5;
            // 
            // hslLedDisplay3
            // 
            this.hslLedDisplay3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.hslLedDisplay3.DisplayBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.hslLedDisplay3.DisplayNumber = 8;
            this.hslLedDisplay3.DisplayText = "123.45";
            this.hslLedDisplay3.LedNumberSize = 16;
            this.hslLedDisplay3.Location = new System.Drawing.Point(20, 23);
            this.hslLedDisplay3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hslLedDisplay3.Name = "hslLedDisplay3";
            this.hslLedDisplay3.Size = new System.Drawing.Size(741, 170);
            this.hslLedDisplay3.TabIndex = 0;
            // 
            // hslLedDisplay8
            // 
            this.hslLedDisplay8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.hslLedDisplay8.DisplayBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.hslLedDisplay8.DisplayNumber = 8;
            this.hslLedDisplay8.DisplayText = "123.45";
            this.hslLedDisplay8.ForeColor = System.Drawing.Color.Yellow;
            this.hslLedDisplay8.LedNumberSize = 2;
            this.hslLedDisplay8.Location = new System.Drawing.Point(20, 203);
            this.hslLedDisplay8.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.hslLedDisplay8.Name = "hslLedDisplay8";
            this.hslLedDisplay8.Size = new System.Drawing.Size(171, 33);
            this.hslLedDisplay8.TabIndex = 4;
            // 
            // hslLedDisplay6
            // 
            this.hslLedDisplay6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.hslLedDisplay6.DisplayBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.hslLedDisplay6.DisplayNumber = 8;
            this.hslLedDisplay6.DisplayText = "5UCCE55";
            this.hslLedDisplay6.ForeColor = System.Drawing.Color.Lime;
            this.hslLedDisplay6.LedNumberSize = 2;
            this.hslLedDisplay6.Location = new System.Drawing.Point(20, 158);
            this.hslLedDisplay6.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.hslLedDisplay6.Name = "hslLedDisplay6";
            this.hslLedDisplay6.Size = new System.Drawing.Size(171, 33);
            this.hslLedDisplay6.TabIndex = 3;
            // 
            // hslLedDisplay5
            // 
            this.hslLedDisplay5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.hslLedDisplay5.DisplayBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.hslLedDisplay5.DisplayNumber = 8;
            this.hslLedDisplay5.DisplayText = "123.45";
            this.hslLedDisplay5.ForeColor = System.Drawing.Color.Lime;
            this.hslLedDisplay5.LedNumberSize = 2;
            this.hslLedDisplay5.Location = new System.Drawing.Point(20, 111);
            this.hslLedDisplay5.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.hslLedDisplay5.Name = "hslLedDisplay5";
            this.hslLedDisplay5.Size = new System.Drawing.Size(171, 33);
            this.hslLedDisplay5.TabIndex = 2;
            // 
            // hslLedDisplay4
            // 
            this.hslLedDisplay4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.hslLedDisplay4.DisplayBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.hslLedDisplay4.DisplayNumber = 8;
            this.hslLedDisplay4.DisplayText = "Error";
            this.hslLedDisplay4.LedNumberSize = 2;
            this.hslLedDisplay4.Location = new System.Drawing.Point(20, 66);
            this.hslLedDisplay4.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.hslLedDisplay4.Name = "hslLedDisplay4";
            this.hslLedDisplay4.Size = new System.Drawing.Size(171, 33);
            this.hslLedDisplay4.TabIndex = 1;
            // 
            // hslLedDisplay2
            // 
            this.hslLedDisplay2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.hslLedDisplay2.DisplayBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.hslLedDisplay2.DisplayNumber = 8;
            this.hslLedDisplay2.DisplayText = "123.45";
            this.hslLedDisplay2.LedNumberSize = 2;
            this.hslLedDisplay2.Location = new System.Drawing.Point(20, 23);
            this.hslLedDisplay2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hslLedDisplay2.Name = "hslLedDisplay2";
            this.hslLedDisplay2.Size = new System.Drawing.Size(171, 33);
            this.hslLedDisplay2.TabIndex = 0;
            // 
            // hslLedDisplay1
            // 
            this.hslLedDisplay1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.hslLedDisplay1.DisplayBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.hslLedDisplay1.DisplayNumber = 27;
            this.hslLedDisplay1.DisplayText = "0123456789AbCcdEFHhJLoPrU:-";
            this.hslLedDisplay1.LedNumberSize = 6;
            this.hslLedDisplay1.Location = new System.Drawing.Point(6, 30);
            this.hslLedDisplay1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hslLedDisplay1.Name = "hslLedDisplay1";
            this.hslLedDisplay1.Size = new System.Drawing.Size(974, 70);
            this.hslLedDisplay1.TabIndex = 1;
            // 
            // FormLedDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 645);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormLedDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LED 控件显示";
            this.Load += new System.EventHandler(this.FormLedDisplay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private HslControls.HslLedDisplay hslLedDisplay1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private HslControls.HslLedDisplay hslLedDisplay8;
        private HslControls.HslLedDisplay hslLedDisplay6;
        private HslControls.HslLedDisplay hslLedDisplay5;
        private HslControls.HslLedDisplay hslLedDisplay4;
        private HslControls.HslLedDisplay hslLedDisplay2;
        private System.Windows.Forms.GroupBox groupBox3;
        private HslControls.HslLedDisplay hslLedDisplay10;
        private HslControls.HslLedDisplay hslLedDisplay9;
        private HslControls.HslLedDisplay hslLedDisplay3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private HslControls.HslLedDisplay hslLedDisplay7;
        private HslControls.HslLedDisplay hslLedDisplay11;
        private HslControls.HslLedDisplay hslLedDisplay12;
    }
}