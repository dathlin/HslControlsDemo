namespace HslControlsDemo
{
    partial class FormBlower
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBlower));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.hslBlower8 = new HslControls.HslBlower();
            this.hslPipeLine1 = new HslControls.HslPipeLine();
            this.hslBlower7 = new HslControls.HslBlower();
            this.hslBlower6 = new HslControls.HslBlower();
            this.hslBlower5 = new HslControls.HslBlower();
            this.hslBlower4 = new HslControls.HslBlower();
            this.hslBlower3 = new HslControls.HslBlower();
            this.hslBlower2 = new HslControls.HslBlower();
            this.hslBlower1 = new HslControls.HslBlower();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.hslBlower8);
            this.groupBox1.Controls.Add(this.hslPipeLine1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 317);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(973, 316);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "黑色的主题下";
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(726, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 46);
            this.button2.TabIndex = 10;
            this.button2.Text = "停止";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(726, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 46);
            this.button1.TabIndex = 9;
            this.button1.Text = "启动";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hslBlower8
            // 
            this.hslBlower8.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(205)))), ((int)(((byte)(211)))));
            this.hslBlower8.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.hslBlower8.Color3 = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(220)))));
            this.hslBlower8.Color4 = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(160)))), ((int)(((byte)(169)))));
            this.hslBlower8.Color5 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(100)))), ((int)(((byte)(111)))));
            this.hslBlower8.Color6 = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(114)))), ((int)(((byte)(121)))));
            this.hslBlower8.Color7 = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.hslBlower8.Color8 = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(182)))), ((int)(((byte)(189)))));
            this.hslBlower8.Location = new System.Drawing.Point(23, 46);
            this.hslBlower8.MoveSpeed = 0F;
            this.hslBlower8.Name = "hslBlower8";
            this.hslBlower8.Size = new System.Drawing.Size(153, 186);
            this.hslBlower8.TabIndex = 7;
            this.hslBlower8.Text = "风机";
            this.hslBlower8.Click += new System.EventHandler(this.HslBlower1_Click);
            // 
            // hslPipeLine1
            // 
            this.hslPipeLine1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hslPipeLine1.BackgroundImage")));
            this.hslPipeLine1.Location = new System.Drawing.Point(175, 70);
            this.hslPipeLine1.Name = "hslPipeLine1";
            this.hslPipeLine1.PipeLineActive = true;
            this.hslPipeLine1.Size = new System.Drawing.Size(380, 45);
            this.hslPipeLine1.TabIndex = 8;
            this.hslPipeLine1.Click += new System.EventHandler(this.HslBlower1_Click);
            // 
            // hslBlower7
            // 
            this.hslBlower7.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(205)))), ((int)(((byte)(211)))));
            this.hslBlower7.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.hslBlower7.Color3 = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(220)))));
            this.hslBlower7.Color4 = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(160)))), ((int)(((byte)(169)))));
            this.hslBlower7.Color5 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(100)))), ((int)(((byte)(111)))));
            this.hslBlower7.Color6 = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(114)))), ((int)(((byte)(121)))));
            this.hslBlower7.Color7 = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.hslBlower7.Color8 = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(182)))), ((int)(((byte)(189)))));
            this.hslBlower7.ExportDirection = HslControls.GraphDirection.Leftward;
            this.hslBlower7.Location = new System.Drawing.Point(706, 12);
            this.hslBlower7.MoveSpeed = 2F;
            this.hslBlower7.Name = "hslBlower7";
            this.hslBlower7.Size = new System.Drawing.Size(223, 274);
            this.hslBlower7.TabIndex = 12;
            this.hslBlower7.Text = "大号控件";
            this.hslBlower7.Click += new System.EventHandler(this.HslBlower1_Click);
            // 
            // hslBlower6
            // 
            this.hslBlower6.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(205)))), ((int)(((byte)(211)))));
            this.hslBlower6.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.hslBlower6.Color3 = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(220)))));
            this.hslBlower6.Color4 = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(160)))), ((int)(((byte)(169)))));
            this.hslBlower6.Color5 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(100)))), ((int)(((byte)(111)))));
            this.hslBlower6.Color6 = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(114)))), ((int)(((byte)(121)))));
            this.hslBlower6.Color7 = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.hslBlower6.Color8 = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(182)))), ((int)(((byte)(189)))));
            this.hslBlower6.ExportDirection = HslControls.GraphDirection.Downward;
            this.hslBlower6.Location = new System.Drawing.Point(170, 156);
            this.hslBlower6.MoveSpeed = 1.5F;
            this.hslBlower6.Name = "hslBlower6";
            this.hslBlower6.Size = new System.Drawing.Size(120, 138);
            this.hslBlower6.TabIndex = 11;
            this.hslBlower6.Text = "方向向下";
            this.hslBlower6.Click += new System.EventHandler(this.HslBlower1_Click);
            // 
            // hslBlower5
            // 
            this.hslBlower5.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(205)))), ((int)(((byte)(211)))));
            this.hslBlower5.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.hslBlower5.Color3 = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(220)))));
            this.hslBlower5.Color4 = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(160)))), ((int)(((byte)(169)))));
            this.hslBlower5.Color5 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(100)))), ((int)(((byte)(111)))));
            this.hslBlower5.Color6 = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(114)))), ((int)(((byte)(121)))));
            this.hslBlower5.Color7 = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.hslBlower5.Color8 = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(182)))), ((int)(((byte)(189)))));
            this.hslBlower5.ExportDirection = HslControls.GraphDirection.Upward;
            this.hslBlower5.Location = new System.Drawing.Point(486, 12);
            this.hslBlower5.MoveSpeed = -1F;
            this.hslBlower5.Name = "hslBlower5";
            this.hslBlower5.Size = new System.Drawing.Size(120, 138);
            this.hslBlower5.TabIndex = 10;
            this.hslBlower5.Text = "方向向上";
            this.hslBlower5.Click += new System.EventHandler(this.HslBlower1_Click);
            // 
            // hslBlower4
            // 
            this.hslBlower4.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(205)))), ((int)(((byte)(211)))));
            this.hslBlower4.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.hslBlower4.Color3 = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(220)))));
            this.hslBlower4.Color4 = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(160)))), ((int)(((byte)(169)))));
            this.hslBlower4.Color5 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(100)))), ((int)(((byte)(111)))));
            this.hslBlower4.Color6 = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(114)))), ((int)(((byte)(121)))));
            this.hslBlower4.Color7 = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.hslBlower4.Color8 = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(182)))), ((int)(((byte)(189)))));
            this.hslBlower4.ExportDirection = HslControls.GraphDirection.Leftward;
            this.hslBlower4.Location = new System.Drawing.Point(337, 12);
            this.hslBlower4.MoveSpeed = 0F;
            this.hslBlower4.Name = "hslBlower4";
            this.hslBlower4.Size = new System.Drawing.Size(120, 138);
            this.hslBlower4.TabIndex = 9;
            this.hslBlower4.Text = "方向向左";
            this.hslBlower4.Click += new System.EventHandler(this.HslBlower1_Click);
            // 
            // hslBlower3
            // 
            this.hslBlower3.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(205)))), ((int)(((byte)(211)))));
            this.hslBlower3.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.hslBlower3.Color3 = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(220)))));
            this.hslBlower3.Color4 = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(160)))), ((int)(((byte)(169)))));
            this.hslBlower3.Color5 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(100)))), ((int)(((byte)(111)))));
            this.hslBlower3.Color6 = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(114)))), ((int)(((byte)(121)))));
            this.hslBlower3.Color7 = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.hslBlower3.Color8 = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(182)))), ((int)(((byte)(189)))));
            this.hslBlower3.Location = new System.Drawing.Point(160, 12);
            this.hslBlower3.MoveSpeed = 0F;
            this.hslBlower3.Name = "hslBlower3";
            this.hslBlower3.Size = new System.Drawing.Size(120, 138);
            this.hslBlower3.TabIndex = 8;
            this.hslBlower3.Text = "转速为0";
            this.hslBlower3.Click += new System.EventHandler(this.HslBlower1_Click);
            // 
            // hslBlower2
            // 
            this.hslBlower2.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(205)))), ((int)(((byte)(211)))));
            this.hslBlower2.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.hslBlower2.Color3 = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(220)))));
            this.hslBlower2.Color4 = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(160)))), ((int)(((byte)(169)))));
            this.hslBlower2.Color5 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(100)))), ((int)(((byte)(111)))));
            this.hslBlower2.Color6 = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(114)))), ((int)(((byte)(121)))));
            this.hslBlower2.Color7 = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.hslBlower2.Color8 = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(182)))), ((int)(((byte)(189)))));
            this.hslBlower2.Location = new System.Drawing.Point(35, 182);
            this.hslBlower2.Name = "hslBlower2";
            this.hslBlower2.Size = new System.Drawing.Size(36, 104);
            this.hslBlower2.TabIndex = 7;
            this.hslBlower2.Text = "迷你的控件";
            this.hslBlower2.Click += new System.EventHandler(this.HslBlower1_Click);
            // 
            // hslBlower1
            // 
            this.hslBlower1.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(205)))), ((int)(((byte)(211)))));
            this.hslBlower1.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.hslBlower1.Color3 = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(220)))));
            this.hslBlower1.Color4 = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(160)))), ((int)(((byte)(169)))));
            this.hslBlower1.Color5 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(100)))), ((int)(((byte)(111)))));
            this.hslBlower1.Color6 = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(114)))), ((int)(((byte)(121)))));
            this.hslBlower1.Color7 = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.hslBlower1.Color8 = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(182)))), ((int)(((byte)(189)))));
            this.hslBlower1.Location = new System.Drawing.Point(12, 12);
            this.hslBlower1.Name = "hslBlower1";
            this.hslBlower1.Size = new System.Drawing.Size(120, 138);
            this.hslBlower1.TabIndex = 6;
            this.hslBlower1.Text = "简单的应用";
            this.hslBlower1.Click += new System.EventHandler(this.HslBlower1_Click);
            // 
            // FormBlower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1004, 645);
            this.Controls.Add(this.hslBlower7);
            this.Controls.Add(this.hslBlower6);
            this.Controls.Add(this.hslBlower5);
            this.Controls.Add(this.hslBlower4);
            this.Controls.Add(this.hslBlower3);
            this.Controls.Add(this.hslBlower2);
            this.Controls.Add(this.hslBlower1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormBlower";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "鼓风机控件";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private HslControls.HslBlower hslBlower1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private HslControls.HslBlower hslBlower8;
        private HslControls.HslPipeLine hslPipeLine1;
        private HslControls.HslBlower hslBlower2;
        private HslControls.HslBlower hslBlower3;
        private HslControls.HslBlower hslBlower4;
        private HslControls.HslBlower hslBlower5;
        private HslControls.HslBlower hslBlower6;
        private HslControls.HslBlower hslBlower7;
    }
}