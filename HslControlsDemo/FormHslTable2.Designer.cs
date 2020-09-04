namespace HslControlsDemo
{
    partial class FormHslTable2
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
			this.hslTable2 = new HslControls.HslTable();
			this.hslTable1 = new HslControls.HslTable();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// hslTable2
			// 
			this.hslTable2.BackColor = System.Drawing.Color.White;
			this.hslTable2.ColumnHeader = new string[] {
        "序号",
        "规格",
        "生产数量",
        "完成度",
        "到岗人数"};
			this.hslTable2.ColumnWidth = new float[] {
        0F,
        0.1F,
        0.35F,
        0.55F,
        0.8F,
        1F};
			this.hslTable2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.hslTable2.Location = new System.Drawing.Point(15, 325);
			this.hslTable2.Name = "hslTable2";
			this.hslTable2.Size = new System.Drawing.Size(977, 219);
			this.hslTable2.TabIndex = 1;
			this.hslTable2.Text = "hslTable2";
			this.hslTable2.TopHeaderTextSize = 18F;
			// 
			// hslTable1
			// 
			this.hslTable1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
			this.hslTable1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.hslTable1.ColumnHeader = new string[] {
        "规格",
        "生产数量",
        "工艺",
        "完成度",
        "特别说明"};
			this.hslTable1.ColumnWidth = new float[] {
        0F,
        0.3F,
        0.45F,
        0.55F,
        0.8F,
        1F};
			this.hslTable1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.hslTable1.ForeColor = System.Drawing.Color.Silver;
			this.hslTable1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.hslTable1.Location = new System.Drawing.Point(15, 24);
			this.hslTable1.Name = "hslTable1";
			this.hslTable1.Size = new System.Drawing.Size(977, 239);
			this.hslTable1.TabIndex = 0;
			this.hslTable1.Text = "hslTable1";
			this.hslTable1.TopHeaderColor = System.Drawing.Color.Turquoise;
			this.hslTable1.TopHeaderTextSize = 18F;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(15, 559);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(120, 29);
			this.button1.TabIndex = 2;
			this.button1.Text = "新增底部数据";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(150, 559);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(120, 29);
			this.button2.TabIndex = 3;
			this.button2.Text = "新增顶部数据";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(427, 559);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(52, 23);
			this.textBox1.TabIndex = 4;
			this.textBox1.Text = "0";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(518, 559);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(52, 23);
			this.textBox2.TabIndex = 5;
			this.textBox2.Text = "0";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(390, 562);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(20, 17);
			this.label1.TabIndex = 6;
			this.label1.Text = "行";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(485, 562);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(20, 17);
			this.label2.TabIndex = 7;
			this.label2.Text = "列";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(595, 562);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(20, 17);
			this.label3.TabIndex = 8;
			this.label3.Text = "值";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(645, 559);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(131, 23);
			this.textBox3.TabIndex = 9;
			this.textBox3.Text = "0";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(806, 556);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(120, 29);
			this.button3.TabIndex = 10;
			this.button3.Text = "设定";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(15, 604);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(120, 29);
			this.button4.TabIndex = 11;
			this.button4.Text = "清除数据";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label4.Location = new System.Drawing.Point(332, 604);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(402, 21);
			this.label4.TabIndex = 12;
			this.label4.Text = "此处演示，生产数量大于4000的橙色，大于6000的红色";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label5.Location = new System.Drawing.Point(349, 266);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(266, 21);
			this.label5.TabIndex = 13;
			this.label5.Text = "此处演示，特殊的列显示特殊的图形";
			// 
			// FormHslTable2
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1004, 645);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.hslTable2);
			this.Controls.Add(this.hslTable1);
			this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Name = "FormHslTable2";
			this.Text = "FormHslTable2";
			this.Load += new System.EventHandler(this.FormHslTable_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private HslControls.HslTable hslTable1;
        private HslControls.HslTable hslTable2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}