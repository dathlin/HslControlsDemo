namespace HslControlsDemo
{
    partial class FormGauge
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
            this.hslGauge7 = new HslControls.HslGauge();
            this.hslGauge6 = new HslControls.HslGauge();
            this.hslGauge5 = new HslControls.HslGauge();
            this.hslGauge4 = new HslControls.HslGauge();
            this.hslGauge3 = new HslControls.HslGauge();
            this.hslGauge2 = new HslControls.HslGauge();
            this.hslGauge1 = new HslControls.HslGauge();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hslGauge1);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "简单的使用";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.hslGauge2);
            this.groupBox2.Location = new System.Drawing.Point(331, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 235);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "设置颜色，数据范围";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.groupBox3.Controls.Add(this.hslGauge3);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(650, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(313, 235);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "大的圆盘加黑色主题";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.groupBox4.Controls.Add(this.hslGauge7);
            this.groupBox4.Controls.Add(this.hslGauge6);
            this.groupBox4.Controls.Add(this.hslGauge5);
            this.groupBox4.Controls.Add(this.hslGauge4);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(12, 262);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(980, 371);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "汽车的仪表盘示例";
            // 
            // hslGauge7
            // 
            this.hslGauge7.Location = new System.Drawing.Point(500, 259);
            this.hslGauge7.Name = "hslGauge7";
            this.hslGauge7.PointerColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.hslGauge7.PointerSize = 1;
            this.hslGauge7.SegmentCount = 2;
            this.hslGauge7.Size = new System.Drawing.Size(121, 76);
            this.hslGauge7.TabIndex = 3;
            this.hslGauge7.ValueAlarmMax = 2F;
            this.hslGauge7.ValueAlarmMin = 0F;
            this.hslGauge7.ValueMax = 2F;
            // 
            // hslGauge6
            // 
            this.hslGauge6.Location = new System.Drawing.Point(388, 259);
            this.hslGauge6.Name = "hslGauge6";
            this.hslGauge6.PointerSize = 1;
            this.hslGauge6.SegmentCount = 2;
            this.hslGauge6.Size = new System.Drawing.Size(121, 76);
            this.hslGauge6.TabIndex = 2;
            this.hslGauge6.ValueAlarmMax = 2F;
            this.hslGauge6.ValueAlarmMin = 0F;
            this.hslGauge6.ValueMax = 2F;
            // 
            // hslGauge5
            // 
            this.hslGauge5.Font = new System.Drawing.Font("华文细黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hslGauge5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.hslGauge5.GaugeBorder = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(196)))), ((int)(((byte)(216)))));
            this.hslGauge5.IsBigSemiCircle = true;
            this.hslGauge5.Location = new System.Drawing.Point(589, 31);
            this.hslGauge5.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.hslGauge5.Name = "hslGauge5";
            this.hslGauge5.PointerColor = System.Drawing.Color.HotPink;
            this.hslGauge5.SegmentCount = 11;
            this.hslGauge5.Size = new System.Drawing.Size(324, 295);
            this.hslGauge5.TabIndex = 1;
            this.hslGauge5.UnitText = "KM/H";
            this.hslGauge5.ValueAlarmMax = 220F;
            this.hslGauge5.ValueAlarmMin = 0F;
            this.hslGauge5.ValueMax = 220F;
            // 
            // hslGauge4
            // 
            this.hslGauge4.Font = new System.Drawing.Font("华文细黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hslGauge4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hslGauge4.GaugeBorder = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(196)))), ((int)(((byte)(216)))));
            this.hslGauge4.IsBigSemiCircle = true;
            this.hslGauge4.Location = new System.Drawing.Point(80, 31);
            this.hslGauge4.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.hslGauge4.Name = "hslGauge4";
            this.hslGauge4.PointerColor = System.Drawing.Color.HotPink;
            this.hslGauge4.SegmentCount = 8;
            this.hslGauge4.Size = new System.Drawing.Size(324, 295);
            this.hslGauge4.TabIndex = 0;
            this.hslGauge4.UnitText = "× 1000 R/MIN";
            this.hslGauge4.ValueAlarmMax = 6.5F;
            this.hslGauge4.ValueAlarmMin = 0F;
            this.hslGauge4.ValueMax = 8F;
            // 
            // hslGauge3
            // 
            this.hslGauge3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.hslGauge3.GaugeBorder = System.Drawing.Color.Gray;
            this.hslGauge3.IsBigSemiCircle = true;
            this.hslGauge3.Location = new System.Drawing.Point(55, 32);
            this.hslGauge3.Name = "hslGauge3";
            this.hslGauge3.PointerColor = System.Drawing.Color.Lime;
            this.hslGauge3.Size = new System.Drawing.Size(203, 182);
            this.hslGauge3.TabIndex = 0;
            // 
            // hslGauge2
            // 
            this.hslGauge2.GaugeBorder = System.Drawing.Color.Blue;
            this.hslGauge2.Location = new System.Drawing.Point(6, 20);
            this.hslGauge2.Name = "hslGauge2";
            this.hslGauge2.SegmentCount = 5;
            this.hslGauge2.Size = new System.Drawing.Size(301, 182);
            this.hslGauge2.TabIndex = 0;
            this.hslGauge2.UnitText = "* 10 ℃";
            this.hslGauge2.ValueMax = 10F;
            // 
            // hslGauge1
            // 
            this.hslGauge1.Location = new System.Drawing.Point(6, 20);
            this.hslGauge1.Name = "hslGauge1";
            this.hslGauge1.Size = new System.Drawing.Size(301, 182);
            this.hslGauge1.TabIndex = 0;
            // 
            // FormGauge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 645);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormGauge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "仪表盘控件新版";
            this.Load += new System.EventHandler(this.FormGauge_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private HslControls.HslGauge hslGauge1;
        private System.Windows.Forms.GroupBox groupBox2;
        private HslControls.HslGauge hslGauge2;
        private System.Windows.Forms.GroupBox groupBox3;
        private HslControls.HslGauge hslGauge3;
        private System.Windows.Forms.GroupBox groupBox4;
        private HslControls.HslGauge hslGauge7;
        private HslControls.HslGauge hslGauge6;
        private HslControls.HslGauge hslGauge5;
        private HslControls.HslGauge hslGauge4;
    }
}