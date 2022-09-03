namespace HslControlsDemo
{
	partial class FormNoBoundaryControl
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
			this.noBoundaryControl1 = new HslControls.Advanced.NoBoundaryControl();
			this.SuspendLayout();
			// 
			// noBoundaryControl1
			// 
			this.noBoundaryControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.noBoundaryControl1.Location = new System.Drawing.Point(104, 3);
			this.noBoundaryControl1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
			this.noBoundaryControl1.Name = "noBoundaryControl1";
			this.noBoundaryControl1.Size = new System.Drawing.Size(896, 639);
			this.noBoundaryControl1.TabIndex = 0;
			// 
			// FormNoBoundaryControl
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1004, 645);
			this.Controls.Add(this.noBoundaryControl1);
			this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Name = "FormNoBoundaryControl";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FormNoBoundaryControl";
			this.Load += new System.EventHandler(this.FormNoBoundaryControl_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private HslControls.Advanced.NoBoundaryControl noBoundaryControl1;
	}
}