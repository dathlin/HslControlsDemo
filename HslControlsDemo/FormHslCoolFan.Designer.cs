namespace HslControlsDemo
{
    partial class FormHslCoolFan
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
            this.hslCoolFan1 = new HslControls.HslCoolFan();
            this.label2 = new System.Windows.Forms.Label();
            this.hslCoolFan2 = new HslControls.HslCoolFan();
            this.label3 = new System.Windows.Forms.Label();
            this.hslCoolFan3 = new HslControls.HslCoolFan();
            this.label4 = new System.Windows.Forms.Label();
            this.hslCoolFan4 = new HslControls.HslCoolFan();
            this.label5 = new System.Windows.Forms.Label();
            this.hslCoolFan5 = new HslControls.HslCoolFan();
            this.label6 = new System.Windows.Forms.Label();
            this.hslCoolFan6 = new HslControls.HslCoolFan();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "正常的冷却风机";
            // 
            // hslCoolFan1
            // 
            this.hslCoolFan1.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(93)))));
            this.hslCoolFan1.EdgeColor = System.Drawing.Color.Gray;
            this.hslCoolFan1.Location = new System.Drawing.Point(37, 13);
            this.hslCoolFan1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hslCoolFan1.Name = "hslCoolFan1";
            this.hslCoolFan1.Size = new System.Drawing.Size(194, 184);
            this.hslCoolFan1.TabIndex = 0;
            this.hslCoolFan1.Text = "hslCoolFan1";
            this.hslCoolFan1.Click += new System.EventHandler(this.hslCoolFan1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "停止的冷却风机";
            // 
            // hslCoolFan2
            // 
            this.hslCoolFan2.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(93)))));
            this.hslCoolFan2.EdgeColor = System.Drawing.Color.Gray;
            this.hslCoolFan2.Location = new System.Drawing.Point(272, 13);
            this.hslCoolFan2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hslCoolFan2.MoveSpeed = 0F;
            this.hslCoolFan2.Name = "hslCoolFan2";
            this.hslCoolFan2.Size = new System.Drawing.Size(194, 184);
            this.hslCoolFan2.TabIndex = 2;
            this.hslCoolFan2.Text = "hslCoolFan2";
            this.hslCoolFan2.Click += new System.EventHandler(this.hslCoolFan1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(550, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "逆向的冷却风机";
            // 
            // hslCoolFan3
            // 
            this.hslCoolFan3.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(93)))));
            this.hslCoolFan3.EdgeColor = System.Drawing.Color.Gray;
            this.hslCoolFan3.Location = new System.Drawing.Point(505, 13);
            this.hslCoolFan3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hslCoolFan3.MoveSpeed = -0.3F;
            this.hslCoolFan3.Name = "hslCoolFan3";
            this.hslCoolFan3.Size = new System.Drawing.Size(194, 184);
            this.hslCoolFan3.TabIndex = 4;
            this.hslCoolFan3.Text = "hslCoolFan3";
            this.hslCoolFan3.Click += new System.EventHandler(this.hslCoolFan1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(780, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "高速的冷却风机";
            // 
            // hslCoolFan4
            // 
            this.hslCoolFan4.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(93)))));
            this.hslCoolFan4.EdgeColor = System.Drawing.Color.Gray;
            this.hslCoolFan4.Location = new System.Drawing.Point(735, 13);
            this.hslCoolFan4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hslCoolFan4.MoveSpeed = 1F;
            this.hslCoolFan4.Name = "hslCoolFan4";
            this.hslCoolFan4.Size = new System.Drawing.Size(194, 184);
            this.hslCoolFan4.TabIndex = 6;
            this.hslCoolFan4.Text = "hslCoolFan4";
            this.hslCoolFan4.Click += new System.EventHandler(this.hslCoolFan1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "设置颜色";
            // 
            // hslCoolFan5
            // 
            this.hslCoolFan5.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.hslCoolFan5.EdgeColor = System.Drawing.Color.Gray;
            this.hslCoolFan5.Location = new System.Drawing.Point(37, 232);
            this.hslCoolFan5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hslCoolFan5.MoveSpeed = 0.5F;
            this.hslCoolFan5.Name = "hslCoolFan5";
            this.hslCoolFan5.Size = new System.Drawing.Size(194, 184);
            this.hslCoolFan5.TabIndex = 8;
            this.hslCoolFan5.Text = "hslCoolFan5";
            this.hslCoolFan5.Click += new System.EventHandler(this.hslCoolFan1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(331, 434);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "设置颜色";
            // 
            // hslCoolFan6
            // 
            this.hslCoolFan6.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.hslCoolFan6.EdgeColor = System.Drawing.Color.Gray;
            this.hslCoolFan6.Location = new System.Drawing.Point(272, 232);
            this.hslCoolFan6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hslCoolFan6.MoveSpeed = 0.5F;
            this.hslCoolFan6.Name = "hslCoolFan6";
            this.hslCoolFan6.Size = new System.Drawing.Size(194, 184);
            this.hslCoolFan6.TabIndex = 10;
            this.hslCoolFan6.Text = "hslCoolFan6";
            this.hslCoolFan6.Click += new System.EventHandler(this.hslCoolFan1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(871, 619);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "WPF版本非常流畅";
            // 
            // FormHslCoolFan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1004, 645);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.hslCoolFan6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hslCoolFan5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hslCoolFan4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hslCoolFan3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hslCoolFan2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hslCoolFan1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormHslCoolFan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormHslCoolFan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HslControls.HslCoolFan hslCoolFan1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private HslControls.HslCoolFan hslCoolFan2;
        private System.Windows.Forms.Label label3;
        private HslControls.HslCoolFan hslCoolFan3;
        private System.Windows.Forms.Label label4;
        private HslControls.HslCoolFan hslCoolFan4;
        private System.Windows.Forms.Label label5;
        private HslControls.HslCoolFan hslCoolFan5;
        private System.Windows.Forms.Label label6;
        private HslControls.HslCoolFan hslCoolFan6;
        private System.Windows.Forms.Label label7;
    }
}