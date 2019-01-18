namespace HslControlsDemo
{
    partial class FormTank
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
            this.hslTank1 = new HslControls.HslTank();
            this.SuspendLayout();
            // 
            // hslTank1
            // 
            this.hslTank1.Location = new System.Drawing.Point(64, 28);
            this.hslTank1.Name = "hslTank1";
            this.hslTank1.Size = new System.Drawing.Size(853, 513);
            this.hslTank1.TabIndex = 0;
            // 
            // FormTank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 645);
            this.Controls.Add(this.hslTank1);
            this.Name = "FormTank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormTank";
            this.ResumeLayout(false);

        }

        #endregion

        private HslControls.HslTank hslTank1;
    }
}