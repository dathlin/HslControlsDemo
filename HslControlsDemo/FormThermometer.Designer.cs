namespace HslControlsDemo
{
    partial class FormThermometer
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
            this.hslThermometer5 = new HslControls.HslThermometer();
            this.hslThermometer4 = new HslControls.HslThermometer();
            this.hslThermometer3 = new HslControls.HslThermometer();
            this.hslThermometer2 = new HslControls.HslThermometer();
            this.hslThermometer1 = new HslControls.HslThermometer();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 574);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "简单的使用";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 574);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "调整字体颜色大小";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 574);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "调整范围并显示温度文字";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(700, 574);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "调整背景并动态变更数据";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 612);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 612);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "设置值";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hslThermometer5
            // 
            this.hslThermometer5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.hslThermometer5.Font = new System.Drawing.Font("等线 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hslThermometer5.ForeColor = System.Drawing.Color.Bisque;
            this.hslThermometer5.Location = new System.Drawing.Point(793, 6);
            this.hslThermometer5.Margin = new System.Windows.Forms.Padding(4);
            this.hslThermometer5.Name = "hslThermometer5";
            this.hslThermometer5.Size = new System.Drawing.Size(152, 551);
            this.hslThermometer5.TabIndex = 7;
            this.hslThermometer5.TemperatureBackColor = System.Drawing.Color.DimGray;
            this.hslThermometer5.TemperatureColor = System.Drawing.Color.DodgerBlue;
            // 
            // hslThermometer4
            // 
            this.hslThermometer4.BackColor = System.Drawing.Color.Gray;
            this.hslThermometer4.Font = new System.Drawing.Font("等线 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hslThermometer4.ForeColor = System.Drawing.Color.Black;
            this.hslThermometer4.Location = new System.Drawing.Point(592, 6);
            this.hslThermometer4.Margin = new System.Windows.Forms.Padding(4);
            this.hslThermometer4.Name = "hslThermometer4";
            this.hslThermometer4.Size = new System.Drawing.Size(152, 551);
            this.hslThermometer4.TabIndex = 6;
            this.hslThermometer4.TemperatureBackColor = System.Drawing.Color.LightGray;
            this.hslThermometer4.TemperatureColor = System.Drawing.Color.DodgerBlue;
            // 
            // hslThermometer3
            // 
            this.hslThermometer3.Font = new System.Drawing.Font("华文细黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hslThermometer3.IsRenderText = true;
            this.hslThermometer3.Location = new System.Drawing.Point(375, 6);
            this.hslThermometer3.Margin = new System.Windows.Forms.Padding(4);
            this.hslThermometer3.Name = "hslThermometer3";
            this.hslThermometer3.SegmentCount = 6;
            this.hslThermometer3.Size = new System.Drawing.Size(155, 551);
            this.hslThermometer3.TabIndex = 4;
            this.hslThermometer3.TemperatureBackColor = System.Drawing.Color.LightGray;
            this.hslThermometer3.TemperatureColor = System.Drawing.Color.DarkOrchid;
            this.hslThermometer3.Value = 60F;
            this.hslThermometer3.ValueMax = 100F;
            this.hslThermometer3.ValueStart = 40F;
            // 
            // hslThermometer2
            // 
            this.hslThermometer2.Font = new System.Drawing.Font("等线 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hslThermometer2.Location = new System.Drawing.Point(180, 6);
            this.hslThermometer2.Margin = new System.Windows.Forms.Padding(4);
            this.hslThermometer2.Name = "hslThermometer2";
            this.hslThermometer2.Size = new System.Drawing.Size(152, 551);
            this.hslThermometer2.TabIndex = 2;
            this.hslThermometer2.TemperatureBackColor = System.Drawing.Color.LightGray;
            this.hslThermometer2.TemperatureColor = System.Drawing.Color.DodgerBlue;
            // 
            // hslThermometer1
            // 
            this.hslThermometer1.Location = new System.Drawing.Point(47, 6);
            this.hslThermometer1.Name = "hslThermometer1";
            this.hslThermometer1.Size = new System.Drawing.Size(113, 551);
            this.hslThermometer1.TabIndex = 0;
            this.hslThermometer1.TemperatureBackColor = System.Drawing.Color.LightGray;
            // 
            // FormThermometer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 645);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hslThermometer5);
            this.Controls.Add(this.hslThermometer4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hslThermometer3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hslThermometer2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hslThermometer1);
            this.Name = "FormThermometer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "温度计的控件示例";
            this.Load += new System.EventHandler(this.FormThermometer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HslControls.HslThermometer hslThermometer1;
        private System.Windows.Forms.Label label1;
        private HslControls.HslThermometer hslThermometer2;
        private System.Windows.Forms.Label label2;
        private HslControls.HslThermometer hslThermometer3;
        private System.Windows.Forms.Label label3;
        private HslControls.HslThermometer hslThermometer4;
        private HslControls.HslThermometer hslThermometer5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}