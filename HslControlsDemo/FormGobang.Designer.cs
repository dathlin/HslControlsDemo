namespace HslControlsDemo
{
    partial class FormGobang
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
            this.hslGobang1 = new HslControls.HslGobang();
            this.SuspendLayout();
            // 
            // hslGobang1
            // 
            this.hslGobang1.BackColor = System.Drawing.Color.Transparent;
            this.hslGobang1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hslGobang1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.hslGobang1.Location = new System.Drawing.Point(90, 46);
            this.hslGobang1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hslGobang1.Name = "hslGobang1";
            this.hslGobang1.Size = new System.Drawing.Size(816, 545);
            this.hslGobang1.TabIndex = 0;
            // 
            // FormGobang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 645);
            this.Controls.Add(this.hslGobang1);
            this.Name = "FormGobang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "五子棋的控件，可以作为程序的彩蛋";
            this.ResumeLayout(false);

        }

        #endregion

        private HslControls.HslGobang hslGobang1;
    }
}