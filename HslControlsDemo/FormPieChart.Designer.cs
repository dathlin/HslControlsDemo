namespace HslControlsDemo
{
    partial class FormPieChart
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
            this.hslPieChart5 = new HslControls.HslPieChart();
            this.hslPieChart4 = new HslControls.HslPieChart();
            this.hslPieChart3 = new HslControls.HslPieChart();
            this.hslPieChart2 = new HslControls.HslPieChart();
            this.hslPieChart1 = new HslControls.HslPieChart();
            this.SuspendLayout();
            // 
            // hslPieChart5
            // 
            this.hslPieChart5.BackColor = System.Drawing.Color.Transparent;
            this.hslPieChart5.Location = new System.Drawing.Point(510, 326);
            this.hslPieChart5.Name = "hslPieChart5";
            this.hslPieChart5.Size = new System.Drawing.Size(224, 233);
            this.hslPieChart5.TabIndex = 4;
            // 
            // hslPieChart4
            // 
            this.hslPieChart4.BackColor = System.Drawing.Color.Transparent;
            this.hslPieChart4.Location = new System.Drawing.Point(154, 326);
            this.hslPieChart4.Name = "hslPieChart4";
            this.hslPieChart4.Size = new System.Drawing.Size(224, 233);
            this.hslPieChart4.TabIndex = 3;
            // 
            // hslPieChart3
            // 
            this.hslPieChart3.BackColor = System.Drawing.Color.Transparent;
            this.hslPieChart3.Location = new System.Drawing.Point(659, 42);
            this.hslPieChart3.Name = "hslPieChart3";
            this.hslPieChart3.Size = new System.Drawing.Size(224, 233);
            this.hslPieChart3.TabIndex = 2;
            // 
            // hslPieChart2
            // 
            this.hslPieChart2.BackColor = System.Drawing.Color.Transparent;
            this.hslPieChart2.IsRenderPercent = true;
            this.hslPieChart2.Location = new System.Drawing.Point(336, 42);
            this.hslPieChart2.Name = "hslPieChart2";
            this.hslPieChart2.Size = new System.Drawing.Size(224, 233);
            this.hslPieChart2.TabIndex = 1;
            // 
            // hslPieChart1
            // 
            this.hslPieChart1.BackColor = System.Drawing.Color.Transparent;
            this.hslPieChart1.Location = new System.Drawing.Point(40, 42);
            this.hslPieChart1.Name = "hslPieChart1";
            this.hslPieChart1.Size = new System.Drawing.Size(224, 233);
            this.hslPieChart1.TabIndex = 0;
            // 
            // FormPieChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 645);
            this.Controls.Add(this.hslPieChart5);
            this.Controls.Add(this.hslPieChart4);
            this.Controls.Add(this.hslPieChart3);
            this.Controls.Add(this.hslPieChart2);
            this.Controls.Add(this.hslPieChart1);
            this.Name = "FormPieChart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "饼图控件";
            this.Load += new System.EventHandler(this.FormPieChart_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private HslControls.HslPieChart hslPieChart1;
        private HslControls.HslPieChart hslPieChart2;
        private HslControls.HslPieChart hslPieChart3;
        private HslControls.HslPieChart hslPieChart4;
        private HslControls.HslPieChart hslPieChart5;
    }
}