namespace HslControlsDemo
{
    partial class FormTetris2
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
            this.hslTetris1 = new HslControls.HslTetris();
            this.SuspendLayout();
            // 
            // hslTetris1
            // 
            this.hslTetris1.CausesValidation = false;
            this.hslTetris1.Location = new System.Drawing.Point(282, 75);
            this.hslTetris1.Name = "hslTetris1";
            this.hslTetris1.Size = new System.Drawing.Size(447, 438);
            this.hslTetris1.TabIndex = 0;
            // 
            // FormTetris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 645);
            this.Controls.Add(this.hslTetris1);
            this.Name = "FormTetris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormTetris";
            this.Load += new System.EventHandler(this.FormTetris_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private HslControls.HslTetris hslTetris1;
    }
}