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
            this.hslPanelText1 = new HslControls.HslPanelText();
            this.hslPanelText2 = new HslControls.HslPanelText();
            this.hslPanelText3 = new HslControls.HslPanelText();
            this.hslBarChart1 = new HslControls.HslBarChart();
            this.hslPanelHead1 = new HslControls.HslPanelHead();
            this.hslPanelHead2 = new HslControls.HslPanelHead();
            this.hslPanelHead3 = new HslControls.HslPanelHead();
            this.hslBarChart2 = new HslControls.HslBarChart();
            this.hslPanelText3.SuspendLayout();
            this.hslPanelHead3.SuspendLayout();
            this.SuspendLayout();
            // 
            // hslPanelText1
            // 
            this.hslPanelText1.Location = new System.Drawing.Point(22, 24);
            this.hslPanelText1.Name = "hslPanelText1";
            this.hslPanelText1.Size = new System.Drawing.Size(396, 135);
            this.hslPanelText1.TabIndex = 0;
            this.hslPanelText1.Text = "hslPanelText1";
            this.hslPanelText1.TextOffect = 20;
            // 
            // hslPanelText2
            // 
            this.hslPanelText2.ForeColor = System.Drawing.Color.Blue;
            this.hslPanelText2.Location = new System.Drawing.Point(22, 195);
            this.hslPanelText2.Name = "hslPanelText2";
            this.hslPanelText2.Size = new System.Drawing.Size(396, 135);
            this.hslPanelText2.TabIndex = 1;
            this.hslPanelText2.Text = "hslPanelText2";
            this.hslPanelText2.TextOffect = 20;
            this.hslPanelText2.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            // 
            // hslPanelText3
            // 
            this.hslPanelText3.Controls.Add(this.hslBarChart1);
            this.hslPanelText3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hslPanelText3.ForeColor = System.Drawing.Color.Blue;
            this.hslPanelText3.Location = new System.Drawing.Point(22, 365);
            this.hslPanelText3.Name = "hslPanelText3";
            this.hslPanelText3.Size = new System.Drawing.Size(396, 268);
            this.hslPanelText3.TabIndex = 2;
            this.hslPanelText3.Text = "产量信息";
            this.hslPanelText3.TextOffect = 20;
            this.hslPanelText3.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            // 
            // hslBarChart1
            // 
            this.hslBarChart1.Location = new System.Drawing.Point(5, 32);
            this.hslBarChart1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.hslBarChart1.Name = "hslBarChart1";
            this.hslBarChart1.ShowBarValueFormat = "{0}";
            this.hslBarChart1.Size = new System.Drawing.Size(386, 231);
            this.hslBarChart1.TabIndex = 0;
            this.hslBarChart1.Text = "hslBarChart1";
            // 
            // hslPanelHead1
            // 
            this.hslPanelHead1.Location = new System.Drawing.Point(507, 12);
            this.hslPanelHead1.Name = "hslPanelHead1";
            this.hslPanelHead1.Size = new System.Drawing.Size(485, 179);
            this.hslPanelHead1.TabIndex = 3;
            this.hslPanelHead1.Text = "hslPanelHead1";
            // 
            // hslPanelHead2
            // 
            this.hslPanelHead2.Location = new System.Drawing.Point(507, 207);
            this.hslPanelHead2.Name = "hslPanelHead2";
            this.hslPanelHead2.Size = new System.Drawing.Size(485, 179);
            this.hslPanelHead2.TabIndex = 4;
            this.hslPanelHead2.Text = "hslPanelHead2";
            this.hslPanelHead2.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
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
            // 
            // hslBarChart2
            // 
            this.hslBarChart2.Location = new System.Drawing.Point(7, 41);
            this.hslBarChart2.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.hslBarChart2.Name = "hslBarChart2";
            this.hslBarChart2.ShowBarValueFormat = "{0}";
            this.hslBarChart2.Size = new System.Drawing.Size(471, 183);
            this.hslBarChart2.TabIndex = 1;
            this.hslBarChart2.Text = "hslBarChart2";
            // 
            // FormPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 645);
            this.Controls.Add(this.hslPanelHead3);
            this.Controls.Add(this.hslPanelHead2);
            this.Controls.Add(this.hslPanelHead1);
            this.Controls.Add(this.hslPanelText3);
            this.Controls.Add(this.hslPanelText2);
            this.Controls.Add(this.hslPanelText1);
            this.Name = "FormPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "卡片容器控件";
            this.Load += new System.EventHandler(this.FormPanel_Load);
            this.hslPanelText3.ResumeLayout(false);
            this.hslPanelHead3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private HslControls.HslPanelText hslPanelText1;
        private HslControls.HslPanelText hslPanelText2;
        private HslControls.HslPanelText hslPanelText3;
        private HslControls.HslBarChart hslBarChart1;
        private HslControls.HslPanelHead hslPanelHead1;
        private HslControls.HslPanelHead hslPanelHead2;
        private HslControls.HslPanelHead hslPanelHead3;
        private HslControls.HslBarChart hslBarChart2;
    }
}