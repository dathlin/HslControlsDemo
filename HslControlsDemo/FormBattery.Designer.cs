namespace HslControlsDemo
{
    partial class FormBattery
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
            this.hslBattery12 = new HslControls.HslBattery();
            this.hslBattery11 = new HslControls.HslBattery();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hslBattery15 = new HslControls.HslBattery();
            this.hslBattery14 = new HslControls.HslBattery();
            this.hslBattery13 = new HslControls.HslBattery();
            this.hslBattery10 = new HslControls.HslBattery();
            this.hslBattery9 = new HslControls.HslBattery();
            this.hslBattery8 = new HslControls.HslBattery();
            this.hslBattery7 = new HslControls.HslBattery();
            this.hslBattery6 = new HslControls.HslBattery();
            this.hslBattery5 = new HslControls.HslBattery();
            this.hslBattery4 = new HslControls.HslBattery();
            this.hslBattery3 = new HslControls.HslBattery();
            this.hslBattery2 = new HslControls.HslBattery();
            this.hslBattery1 = new HslControls.HslBattery();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.groupBox1.Controls.Add(this.hslBattery12);
            this.groupBox1.Controls.Add(this.hslBattery11);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(352, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 347);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "黑色的主题下";
            // 
            // hslBattery12
            // 
            this.hslBattery12.BatteryBackColor = System.Drawing.Color.Silver;
            this.hslBattery12.BatteryStyle = HslControls.HslDirectionStyle.Vertical;
            this.hslBattery12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hslBattery12.ForeColor = System.Drawing.Color.Blue;
            this.hslBattery12.IsTextRender = true;
            this.hslBattery12.Location = new System.Drawing.Point(363, 21);
            this.hslBattery12.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hslBattery12.Name = "hslBattery12";
            this.hslBattery12.Size = new System.Drawing.Size(217, 63);
            this.hslBattery12.StringFormat = "{0} ma";
            this.hslBattery12.TabIndex = 11;
            this.hslBattery12.Value = 3450F;
            this.hslBattery12.ValueMax = 5000F;
            // 
            // hslBattery11
            // 
            this.hslBattery11.BatteryBackColor = System.Drawing.Color.Silver;
            this.hslBattery11.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hslBattery11.ForeColor = System.Drawing.Color.Blue;
            this.hslBattery11.IsTextRender = true;
            this.hslBattery11.Location = new System.Drawing.Point(147, 21);
            this.hslBattery11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hslBattery11.Name = "hslBattery11";
            this.hslBattery11.Size = new System.Drawing.Size(74, 173);
            this.hslBattery11.StringFormat = "{0} ma";
            this.hslBattery11.TabIndex = 10;
            this.hslBattery11.Value = 3450F;
            this.hslBattery11.ValueMax = 5000F;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "五种数量等级下，不同的颜色演示";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(786, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "横向模式的显示";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 470);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "动态变化";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 612);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "设置背景";
            // 
            // hslBattery15
            // 
            this.hslBattery15.BatteryBackColor = System.Drawing.Color.Gray;
            this.hslBattery15.Location = new System.Drawing.Point(143, 501);
            this.hslBattery15.Name = "hslBattery15";
            this.hslBattery15.Size = new System.Drawing.Size(35, 102);
            this.hslBattery15.TabIndex = 14;
            this.hslBattery15.Value = 10F;
            // 
            // hslBattery14
            // 
            this.hslBattery14.BatteryBackColor = System.Drawing.Color.Wheat;
            this.hslBattery14.Location = new System.Drawing.Point(88, 501);
            this.hslBattery14.Name = "hslBattery14";
            this.hslBattery14.Size = new System.Drawing.Size(35, 102);
            this.hslBattery14.TabIndex = 13;
            this.hslBattery14.Value = 10F;
            // 
            // hslBattery13
            // 
            this.hslBattery13.BatteryBackColor = System.Drawing.Color.LightPink;
            this.hslBattery13.Location = new System.Drawing.Point(37, 501);
            this.hslBattery13.Name = "hslBattery13";
            this.hslBattery13.Size = new System.Drawing.Size(35, 102);
            this.hslBattery13.TabIndex = 12;
            this.hslBattery13.Value = 10F;
            // 
            // hslBattery10
            // 
            this.hslBattery10.BatteryBackColor = System.Drawing.Color.Silver;
            this.hslBattery10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hslBattery10.ForeColor = System.Drawing.Color.Blue;
            this.hslBattery10.IsTextRender = true;
            this.hslBattery10.Location = new System.Drawing.Point(244, 283);
            this.hslBattery10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hslBattery10.Name = "hslBattery10";
            this.hslBattery10.Size = new System.Drawing.Size(74, 173);
            this.hslBattery10.StringFormat = "{0} ma";
            this.hslBattery10.TabIndex = 9;
            this.hslBattery10.Value = 3450F;
            this.hslBattery10.ValueMax = 5000F;
            // 
            // hslBattery9
            // 
            this.hslBattery9.BatteryBackColor = System.Drawing.Color.Silver;
            this.hslBattery9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hslBattery9.ForeColor = System.Drawing.Color.Blue;
            this.hslBattery9.IsTextRender = true;
            this.hslBattery9.Location = new System.Drawing.Point(134, 283);
            this.hslBattery9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hslBattery9.Name = "hslBattery9";
            this.hslBattery9.Size = new System.Drawing.Size(74, 173);
            this.hslBattery9.StringFormat = "{0:F2} V";
            this.hslBattery9.TabIndex = 8;
            this.hslBattery9.Value = 2.45F;
            this.hslBattery9.ValueMax = 5F;
            // 
            // hslBattery8
            // 
            this.hslBattery8.BatteryBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(196)))), ((int)(((byte)(216)))));
            this.hslBattery8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hslBattery8.ForeColor = System.Drawing.Color.Blue;
            this.hslBattery8.IsTextRender = true;
            this.hslBattery8.Location = new System.Drawing.Point(37, 283);
            this.hslBattery8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hslBattery8.Name = "hslBattery8";
            this.hslBattery8.Size = new System.Drawing.Size(74, 173);
            this.hslBattery8.StringFormat = "{0:F2} V";
            this.hslBattery8.TabIndex = 7;
            this.hslBattery8.Value = 1.45F;
            this.hslBattery8.ValueMax = 5F;
            // 
            // hslBattery7
            // 
            this.hslBattery7.BatteryBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(196)))), ((int)(((byte)(216)))));
            this.hslBattery7.BatteryStyle = HslControls.HslDirectionStyle.Vertical;
            this.hslBattery7.IsTextRender = true;
            this.hslBattery7.Location = new System.Drawing.Point(799, 136);
            this.hslBattery7.Name = "hslBattery7";
            this.hslBattery7.Size = new System.Drawing.Size(146, 63);
            this.hslBattery7.TabIndex = 6;
            this.hslBattery7.Value = 88F;
            // 
            // hslBattery6
            // 
            this.hslBattery6.BatteryBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(196)))), ((int)(((byte)(216)))));
            this.hslBattery6.BatteryStyle = HslControls.HslDirectionStyle.Vertical;
            this.hslBattery6.IsTextRender = true;
            this.hslBattery6.Location = new System.Drawing.Point(701, 42);
            this.hslBattery6.Name = "hslBattery6";
            this.hslBattery6.Size = new System.Drawing.Size(244, 88);
            this.hslBattery6.TabIndex = 5;
            this.hslBattery6.Value = 3F;
            // 
            // hslBattery5
            // 
            this.hslBattery5.BatteryBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(196)))), ((int)(((byte)(216)))));
            this.hslBattery5.Location = new System.Drawing.Point(523, 42);
            this.hslBattery5.Name = "hslBattery5";
            this.hslBattery5.Size = new System.Drawing.Size(86, 174);
            this.hslBattery5.TabIndex = 4;
            this.hslBattery5.Value = 96F;
            // 
            // hslBattery4
            // 
            this.hslBattery4.BatteryBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(196)))), ((int)(((byte)(216)))));
            this.hslBattery4.Location = new System.Drawing.Point(411, 42);
            this.hslBattery4.Name = "hslBattery4";
            this.hslBattery4.Size = new System.Drawing.Size(86, 174);
            this.hslBattery4.TabIndex = 3;
            this.hslBattery4.Value = 75F;
            // 
            // hslBattery3
            // 
            this.hslBattery3.BatteryBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(196)))), ((int)(((byte)(216)))));
            this.hslBattery3.Location = new System.Drawing.Point(294, 42);
            this.hslBattery3.Name = "hslBattery3";
            this.hslBattery3.Size = new System.Drawing.Size(86, 174);
            this.hslBattery3.TabIndex = 2;
            this.hslBattery3.Value = 50F;
            // 
            // hslBattery2
            // 
            this.hslBattery2.BatteryBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(196)))), ((int)(((byte)(216)))));
            this.hslBattery2.Location = new System.Drawing.Point(167, 42);
            this.hslBattery2.Name = "hslBattery2";
            this.hslBattery2.Size = new System.Drawing.Size(86, 174);
            this.hslBattery2.TabIndex = 1;
            this.hslBattery2.Value = 25F;
            // 
            // hslBattery1
            // 
            this.hslBattery1.BatteryBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(196)))), ((int)(((byte)(216)))));
            this.hslBattery1.Location = new System.Drawing.Point(37, 42);
            this.hslBattery1.Name = "hslBattery1";
            this.hslBattery1.Size = new System.Drawing.Size(86, 174);
            this.hslBattery1.TabIndex = 0;
            this.hslBattery1.Value = 3F;
            // 
            // FormBattery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 645);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hslBattery15);
            this.Controls.Add(this.hslBattery14);
            this.Controls.Add(this.hslBattery13);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.hslBattery10);
            this.Controls.Add(this.hslBattery9);
            this.Controls.Add(this.hslBattery8);
            this.Controls.Add(this.hslBattery7);
            this.Controls.Add(this.hslBattery6);
            this.Controls.Add(this.hslBattery5);
            this.Controls.Add(this.hslBattery4);
            this.Controls.Add(this.hslBattery3);
            this.Controls.Add(this.hslBattery2);
            this.Controls.Add(this.hslBattery1);
            this.Name = "FormBattery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "电池控件";
            this.Load += new System.EventHandler(this.FormBattery_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HslControls.HslBattery hslBattery1;
        private HslControls.HslBattery hslBattery2;
        private HslControls.HslBattery hslBattery3;
        private HslControls.HslBattery hslBattery4;
        private HslControls.HslBattery hslBattery5;
        private HslControls.HslBattery hslBattery6;
        private HslControls.HslBattery hslBattery7;
        private HslControls.HslBattery hslBattery8;
        private HslControls.HslBattery hslBattery9;
        private HslControls.HslBattery hslBattery10;
        private System.Windows.Forms.GroupBox groupBox1;
        private HslControls.HslBattery hslBattery13;
        private HslControls.HslBattery hslBattery12;
        private HslControls.HslBattery hslBattery11;
        private HslControls.HslBattery hslBattery14;
        private HslControls.HslBattery hslBattery15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}