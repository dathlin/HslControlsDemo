namespace HslControlsDemo
{
    partial class FormMoveText
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
            this.hslMoveText1 = new HslControls.HslMoveText();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hslMoveText2 = new HslControls.HslMoveText();
            this.label3 = new System.Windows.Forms.Label();
            this.hslMoveText3 = new HslControls.HslMoveText();
            this.label4 = new System.Windows.Forms.Label();
            this.hslMoveText4 = new HslControls.HslMoveText();
            this.label5 = new System.Windows.Forms.Label();
            this.hslMoveText5 = new HslControls.HslMoveText();
            this.SuspendLayout();
            // 
            // hslMoveText1
            // 
            this.hslMoveText1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hslMoveText1.Location = new System.Drawing.Point(12, 12);
            this.hslMoveText1.Name = "hslMoveText1";
            this.hslMoveText1.Size = new System.Drawing.Size(726, 30);
            this.hslMoveText1.TabIndex = 0;
            this.hslMoveText1.Text = "hslMoveText1";
            this.hslMoveText1.Click += new System.EventHandler(this.HslMoveText1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "最基本的使用";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "调整了速度";
            // 
            // hslMoveText2
            // 
            this.hslMoveText2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hslMoveText2.Location = new System.Drawing.Point(12, 98);
            this.hslMoveText2.MoveSpeed = 5F;
            this.hslMoveText2.Name = "hslMoveText2";
            this.hslMoveText2.Size = new System.Drawing.Size(726, 30);
            this.hslMoveText2.TabIndex = 2;
            this.hslMoveText2.Text = "hslMoveText2";
            this.hslMoveText2.Click += new System.EventHandler(this.HslMoveText1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "设置字体颜色";
            // 
            // hslMoveText3
            // 
            this.hslMoveText3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hslMoveText3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hslMoveText3.ForeColor = System.Drawing.Color.Blue;
            this.hslMoveText3.Location = new System.Drawing.Point(12, 182);
            this.hslMoveText3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hslMoveText3.MoveSpeed = 2F;
            this.hslMoveText3.Name = "hslMoveText3";
            this.hslMoveText3.Size = new System.Drawing.Size(726, 42);
            this.hslMoveText3.TabIndex = 4;
            this.hslMoveText3.Text = "hslMoveText3";
            this.hslMoveText3.Click += new System.EventHandler(this.HslMoveText1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "设置字体颜色及背景";
            // 
            // hslMoveText4
            // 
            this.hslMoveText4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hslMoveText4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.hslMoveText4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hslMoveText4.ForeColor = System.Drawing.Color.Yellow;
            this.hslMoveText4.Location = new System.Drawing.Point(12, 290);
            this.hslMoveText4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hslMoveText4.MoveSpeed = 2F;
            this.hslMoveText4.Name = "hslMoveText4";
            this.hslMoveText4.Size = new System.Drawing.Size(726, 42);
            this.hslMoveText4.TabIndex = 6;
            this.hslMoveText4.Text = "hslMoveText4";
            this.hslMoveText4.Click += new System.EventHandler(this.HslMoveText1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "设置字体颜色及背景";
            // 
            // hslMoveText5
            // 
            this.hslMoveText5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hslMoveText5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.hslMoveText5.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hslMoveText5.ForeColor = System.Drawing.Color.Yellow;
            this.hslMoveText5.Location = new System.Drawing.Point(12, 381);
            this.hslMoveText5.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.hslMoveText5.MoveSpeed = 2F;
            this.hslMoveText5.Name = "hslMoveText5";
            this.hslMoveText5.Size = new System.Drawing.Size(726, 49);
            this.hslMoveText5.TabIndex = 8;
            this.hslMoveText5.Text = "公告：这是一条测试的公告信息。";
            this.hslMoveText5.Click += new System.EventHandler(this.HslMoveText1_Click);
            // 
            // FormMoveText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(750, 514);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hslMoveText5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hslMoveText4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hslMoveText3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hslMoveText2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hslMoveText1);
            this.Name = "FormMoveText";
            this.Text = "移动的文本";
            this.Load += new System.EventHandler(this.FormMoveText_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HslControls.HslMoveText hslMoveText1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private HslControls.HslMoveText hslMoveText2;
        private System.Windows.Forms.Label label3;
        private HslControls.HslMoveText hslMoveText3;
        private System.Windows.Forms.Label label4;
        private HslControls.HslMoveText hslMoveText4;
        private System.Windows.Forms.Label label5;
        private HslControls.HslMoveText hslMoveText5;
    }
}