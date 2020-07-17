namespace HslControlsDemo
{
	partial class FormHslChinaMap3
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
            this.hslChinaMap1 = new HslControls.Advanced.HslChinaMap();
            this.SuspendLayout();
            // 
            // hslChinaMap1
            // 
            this.hslChinaMap1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hslChinaMap1.CanMouseMoveHighlight = false;
            this.hslChinaMap1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hslChinaMap1.GraphicColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.hslChinaMap1.Location = new System.Drawing.Point(0, 0);
            this.hslChinaMap1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.hslChinaMap1.Name = "hslChinaMap1";
            this.hslChinaMap1.OffsetX = 0;
            this.hslChinaMap1.OffsetY = 0;
            this.hslChinaMap1.ProvinceColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.hslChinaMap1.ShowRiversAndLakes = false;
            this.hslChinaMap1.Size = new System.Drawing.Size(1004, 645);
            this.hslChinaMap1.TabIndex = 0;
            this.hslChinaMap1.Click += new System.EventHandler(this.hslChinaMap1_Click);
            // 
            // FormHslChinaMap3
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1004, 645);
            this.Controls.Add(this.hslChinaMap1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "FormHslChinaMap3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormHslChinaMap";
            this.Load += new System.EventHandler(this.FormNoBoundaryControl_Load);
            this.ResumeLayout(false);

		}

        #endregion

        private HslControls.Advanced.HslChinaMap hslChinaMap1;
    }
}