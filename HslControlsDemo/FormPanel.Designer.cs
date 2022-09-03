namespace HslControlsDemo
{
    partial class FormPanel
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
            this.hslPanel1 = new HslControls.HslPanel();
            this.hslPanelHead3 = new HslControls.HslPanelHead();
            this.hslBarChart2 = new HslControls.HslBarChart();
            this.hslPanelHead2 = new HslControls.HslPanelHead();
            this.hslBarChart4 = new HslControls.HslBarChart();
            this.hslPanelHead1 = new HslControls.HslPanelHead();
            this.hslPanel2 = new HslControls.HslPanel();
            this.hslPanel3 = new HslControls.HslPanel();
            this.hslPanelHead3.SuspendLayout();
            this.hslPanelHead2.SuspendLayout();
            this.SuspendLayout();
            // 
            // hslPanel1
            // 
            this.hslPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.hslPanel1.CenterColor = System.Drawing.Color.Tomato;
            this.hslPanel1.EdgeColor = System.Drawing.Color.OrangeRed;
            this.hslPanel1.Location = new System.Drawing.Point(12, 12);
            this.hslPanel1.Name = "hslPanel1";
            this.hslPanel1.Size = new System.Drawing.Size(462, 179);
            this.hslPanel1.TabIndex = 6;
            // 
            // hslPanelHead3
            // 
            this.hslPanelHead3.Controls.Add(this.hslBarChart2);
            this.hslPanelHead3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hslPanelHead3.ForeColor = System.Drawing.Color.White;
            this.hslPanelHead3.Location = new System.Drawing.Point(507, 397);
            this.hslPanelHead3.Name = "hslPanelHead3";
            this.hslPanelHead3.Size = new System.Drawing.Size(485, 231);
            this.hslPanelHead3.TabIndex = 5;
            this.hslPanelHead3.Text = "产量信息";
            this.hslPanelHead3.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.hslPanelHead3.Click += new System.EventHandler(this.HslPanelText1_Click);
            // 
            // hslBarChart2
            // 
            this.hslBarChart2.Location = new System.Drawing.Point(7, 41);
            this.hslBarChart2.Margin = new System.Windows.Forms.Padding(7);
            this.hslBarChart2.Name = "hslBarChart2";
            this.hslBarChart2.ShowBarValueFormat = "{0}";
            this.hslBarChart2.Size = new System.Drawing.Size(471, 183);
            this.hslBarChart2.TabIndex = 1;
            this.hslBarChart2.Text = "hslBarChart2";
            // 
            // hslPanelHead2
            // 
            this.hslPanelHead2.BackColor = System.Drawing.SystemColors.Info;
            this.hslPanelHead2.Controls.Add(this.hslBarChart4);
            this.hslPanelHead2.Location = new System.Drawing.Point(507, 207);
            this.hslPanelHead2.Name = "hslPanelHead2";
            this.hslPanelHead2.Size = new System.Drawing.Size(485, 179);
            this.hslPanelHead2.TabIndex = 4;
            this.hslPanelHead2.Text = "hslPanelHead2";
            this.hslPanelHead2.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.hslPanelHead2.Click += new System.EventHandler(this.HslPanelText1_Click);
            // 
            // hslBarChart4
            // 
            this.hslBarChart4.BarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.hslBarChart4.BarPercentWidth = 0.5F;
            this.hslBarChart4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hslBarChart4.Location = new System.Drawing.Point(0, 33);
            this.hslBarChart4.Name = "hslBarChart4";
            this.hslBarChart4.ShowBarValueFormat = "{0}";
            this.hslBarChart4.Size = new System.Drawing.Size(478, 143);
            this.hslBarChart4.TabIndex = 4;
            this.hslBarChart4.Text = "hslBarChart4";
            this.hslBarChart4.UseGradient = true;
            // 
            // hslPanelHead1
            // 
            this.hslPanelHead1.BackColor = System.Drawing.Color.White;
            this.hslPanelHead1.Location = new System.Drawing.Point(507, 12);
            this.hslPanelHead1.Name = "hslPanelHead1";
            this.hslPanelHead1.ShowBorder = false;
            this.hslPanelHead1.Size = new System.Drawing.Size(485, 179);
            this.hslPanelHead1.TabIndex = 3;
            this.hslPanelHead1.Text = "hslPanelHead1";
            this.hslPanelHead1.Click += new System.EventHandler(this.HslPanelText1_Click);
            // 
            // hslPanel2
            // 
            this.hslPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.hslPanel2.CenterColor = System.Drawing.Color.ForestGreen;
            this.hslPanel2.EdgeColor = System.Drawing.Color.Green;
            this.hslPanel2.Location = new System.Drawing.Point(12, 207);
            this.hslPanel2.Name = "hslPanel2";
            this.hslPanel2.Size = new System.Drawing.Size(462, 179);
            this.hslPanel2.TabIndex = 7;
            // 
            // hslPanel3
            // 
            this.hslPanel3.Location = new System.Drawing.Point(12, 416);
            this.hslPanel3.Name = "hslPanel3";
            this.hslPanel3.Size = new System.Drawing.Size(462, 205);
            this.hslPanel3.TabIndex = 8;
            this.hslPanel3.Text = "hslPanel3";
            // 
            // FormPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1004, 645);
            this.Controls.Add(this.hslPanel3);
            this.Controls.Add(this.hslPanel2);
            this.Controls.Add(this.hslPanel1);
            this.Controls.Add(this.hslPanelHead3);
            this.Controls.Add(this.hslPanelHead2);
            this.Controls.Add(this.hslPanelHead1);
            this.Name = "FormPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "卡片容器控件";
            this.Load += new System.EventHandler(this.FormPanel_Load);
            this.hslPanelHead3.ResumeLayout(false);
            this.hslPanelHead2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private HslControls.HslPanelHead hslPanelHead1;
        private HslControls.HslPanelHead hslPanelHead2;
        private HslControls.HslPanelHead hslPanelHead3;
        private HslControls.HslBarChart hslBarChart2;
        private HslControls.HslBarChart hslBarChart4;
        private HslControls.HslPanel hslPanel1;
		private HslControls.HslPanel hslPanel2;
		private HslControls.HslPanel hslPanel3;
	}
}