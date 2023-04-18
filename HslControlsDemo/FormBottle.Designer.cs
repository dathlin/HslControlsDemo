namespace HslControlsDemo
{
    partial class FormBottle
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBottle));
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.hslPipeLine6 = new HslControls.HslPipeLine();
			this.hslBottle10 = new HslControls.HslBottle();
			this.hslPipeLine7 = new HslControls.HslPipeLine();
			this.hslBottle11 = new HslControls.HslBottle();
			this.hslPipeLine5 = new HslControls.HslPipeLine();
			this.hslPipeLine1 = new HslControls.HslPipeLine();
			this.hslPipeLine4 = new HslControls.HslPipeLine();
			this.hslPipeLine3 = new HslControls.HslPipeLine();
			this.hslBottle9 = new HslControls.HslBottle();
			this.hslBottle8 = new HslControls.HslBottle();
			this.hslBottle7 = new HslControls.HslBottle();
			this.hslBottle6 = new HslControls.HslBottle();
			this.hslBottle5 = new HslControls.HslBottle();
			this.hslBottle4 = new HslControls.HslBottle();
			this.hslBottle3 = new HslControls.HslBottle();
			this.hslBottle2 = new HslControls.HslBottle();
			this.hslBottle1 = new HslControls.HslBottle();
			this.hslPipeLine2 = new HslControls.HslPipeLine();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(634, 29);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(171, 55);
			this.button1.TabIndex = 13;
			this.button1.Text = "加载物料";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.groupBox1.Controls.Add(this.hslPipeLine6);
			this.groupBox1.Controls.Add(this.hslBottle10);
			this.groupBox1.Controls.Add(this.hslPipeLine7);
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(603, 107);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(373, 515);
			this.groupBox1.TabIndex = 15;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// hslPipeLine6
			// 
			this.hslPipeLine6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hslPipeLine6.BackgroundImage")));
			this.hslPipeLine6.EdgeColor = System.Drawing.Color.HotPink;
			this.hslPipeLine6.ForeColor = System.Drawing.Color.White;
			this.hslPipeLine6.LineCenterColor = System.Drawing.Color.Pink;
			this.hslPipeLine6.Location = new System.Drawing.Point(81, 229);
			this.hslPipeLine6.MoveSpeed = 0.2F;
			this.hslPipeLine6.Name = "hslPipeLine6";
			this.hslPipeLine6.PipeLineActive = true;
			this.hslPipeLine6.PipeLineStyle = HslControls.HslDirectionStyle.Vertical;
			this.hslPipeLine6.PipeTurnRight = HslControls.HslPipeTurnDirection.Right;
			this.hslPipeLine6.Size = new System.Drawing.Size(22, 156);
			this.hslPipeLine6.TabIndex = 10;
			this.hslPipeLine6.Click += new System.EventHandler(this.HslBottle8_Click);
			// 
			// hslBottle10
			// 
			this.hslBottle10.BackColorCenter = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.hslBottle10.BackColorEdge = System.Drawing.Color.Gray;
			this.hslBottle10.BackColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.hslBottle10.DockHeight = 20F;
			this.hslBottle10.ForeColorCenter = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.hslBottle10.ForeColorEdge = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.hslBottle10.ForeColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.hslBottle10.Location = new System.Drawing.Point(70, 20);
			this.hslBottle10.Name = "hslBottle10";
			this.hslBottle10.Size = new System.Drawing.Size(43, 220);
			this.hslBottle10.TabIndex = 0;
			this.hslBottle10.Value = 50D;
			this.hslBottle10.Click += new System.EventHandler(this.HslBottle8_Click);
			// 
			// hslPipeLine7
			// 
			this.hslPipeLine7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hslPipeLine7.BackgroundImage")));
			this.hslPipeLine7.EdgeColor = System.Drawing.Color.HotPink;
			this.hslPipeLine7.ForeColor = System.Drawing.Color.White;
			this.hslPipeLine7.LineCenterColor = System.Drawing.Color.Pink;
			this.hslPipeLine7.Location = new System.Drawing.Point(102, 363);
			this.hslPipeLine7.MoveSpeed = 0.2F;
			this.hslPipeLine7.Name = "hslPipeLine7";
			this.hslPipeLine7.PipeLineActive = true;
			this.hslPipeLine7.PipeTurnRight = HslControls.HslPipeTurnDirection.Right;
			this.hslPipeLine7.Size = new System.Drawing.Size(220, 22);
			this.hslPipeLine7.TabIndex = 11;
			this.hslPipeLine7.Click += new System.EventHandler(this.HslBottle8_Click);
			// 
			// hslBottle11
			// 
			this.hslBottle11.BackColorCenter = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.hslBottle11.BackColorEdge = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(196)))), ((int)(((byte)(216)))));
			this.hslBottle11.BackColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(232)))), ((int)(((byte)(244)))));
			this.hslBottle11.DockHeight = 8F;
			this.hslBottle11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.hslBottle11.ForeColorCenter = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(221)))), ((int)(((byte)(98)))));
			this.hslBottle11.ForeColorEdge = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(190)))), ((int)(((byte)(77)))));
			this.hslBottle11.ForeColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(139)))));
			this.hslBottle11.HeadTag = "";
			this.hslBottle11.Location = new System.Drawing.Point(441, 153);
			this.hslBottle11.Name = "hslBottle11";
			this.hslBottle11.Size = new System.Drawing.Size(24, 24);
			this.hslBottle11.TabIndex = 17;
			this.hslBottle11.Value = 0D;
			// 
			// hslPipeLine5
			// 
			this.hslPipeLine5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hslPipeLine5.BackgroundImage")));
			this.hslPipeLine5.Location = new System.Drawing.Point(356, 527);
			this.hslPipeLine5.Name = "hslPipeLine5";
			this.hslPipeLine5.PipeLineStyle = HslControls.HslDirectionStyle.Vertical;
			this.hslPipeLine5.Size = new System.Drawing.Size(22, 66);
			this.hslPipeLine5.TabIndex = 16;
			this.hslPipeLine5.Click += new System.EventHandler(this.HslBottle8_Click);
			// 
			// hslPipeLine1
			// 
			this.hslPipeLine1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hslPipeLine1.BackgroundImage")));
			this.hslPipeLine1.Location = new System.Drawing.Point(45, 168);
			this.hslPipeLine1.Name = "hslPipeLine1";
			this.hslPipeLine1.PipeLineActive = true;
			this.hslPipeLine1.PipeLineStyle = HslControls.HslDirectionStyle.Vertical;
			this.hslPipeLine1.PipeTurnRight = HslControls.HslPipeTurnDirection.Right;
			this.hslPipeLine1.Size = new System.Drawing.Size(22, 153);
			this.hslPipeLine1.TabIndex = 9;
			this.hslPipeLine1.Click += new System.EventHandler(this.HslBottle8_Click);
			// 
			// hslPipeLine4
			// 
			this.hslPipeLine4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hslPipeLine4.BackgroundImage")));
			this.hslPipeLine4.Location = new System.Drawing.Point(356, 593);
			this.hslPipeLine4.Name = "hslPipeLine4";
			this.hslPipeLine4.PipeTurnLeft = HslControls.HslPipeTurnDirection.Up;
			this.hslPipeLine4.Size = new System.Drawing.Size(199, 22);
			this.hslPipeLine4.TabIndex = 12;
			this.hslPipeLine4.Click += new System.EventHandler(this.HslBottle8_Click);
			// 
			// hslPipeLine3
			// 
			this.hslPipeLine3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hslPipeLine3.BackgroundImage")));
			this.hslPipeLine3.Location = new System.Drawing.Point(266, 299);
			this.hslPipeLine3.Name = "hslPipeLine3";
			this.hslPipeLine3.PipeLineActive = true;
			this.hslPipeLine3.PipeLineStyle = HslControls.HslDirectionStyle.Vertical;
			this.hslPipeLine3.PipeTurnLeft = HslControls.HslPipeTurnDirection.Left;
			this.hslPipeLine3.Size = new System.Drawing.Size(22, 109);
			this.hslPipeLine3.TabIndex = 11;
			this.hslPipeLine3.Click += new System.EventHandler(this.HslBottle8_Click);
			// 
			// hslBottle9
			// 
			this.hslBottle9.BackColorCenter = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.hslBottle9.BackColorEdge = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(196)))), ((int)(((byte)(216)))));
			this.hslBottle9.BackColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(232)))), ((int)(((byte)(244)))));
			this.hslBottle9.BottleTag = "1#";
			this.hslBottle9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.hslBottle9.ForeColorCenter = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(221)))), ((int)(((byte)(98)))));
			this.hslBottle9.ForeColorEdge = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(190)))), ((int)(((byte)(77)))));
			this.hslBottle9.ForeColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(139)))));
			this.hslBottle9.Location = new System.Drawing.Point(254, 389);
			this.hslBottle9.Name = "hslBottle9";
			this.hslBottle9.Size = new System.Drawing.Size(124, 167);
			this.hslBottle9.TabIndex = 8;
			this.hslBottle9.Value = 20D;
			this.hslBottle9.Click += new System.EventHandler(this.HslBottle8_Click);
			// 
			// hslBottle8
			// 
			this.hslBottle8.BackColorCenter = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.hslBottle8.BackColorEdge = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(196)))), ((int)(((byte)(216)))));
			this.hslBottle8.BackColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(232)))), ((int)(((byte)(244)))));
			this.hslBottle8.BottleTag = "8#";
			this.hslBottle8.DockHeight = 20F;
			this.hslBottle8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.hslBottle8.ForeColorCenter = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(221)))), ((int)(((byte)(98)))));
			this.hslBottle8.ForeColorEdge = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(190)))), ((int)(((byte)(77)))));
			this.hslBottle8.ForeColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(139)))));
			this.hslBottle8.Location = new System.Drawing.Point(390, 12);
			this.hslBottle8.Name = "hslBottle8";
			this.hslBottle8.Size = new System.Drawing.Size(45, 165);
			this.hslBottle8.TabIndex = 7;
			this.hslBottle8.Value = 0D;
			this.hslBottle8.Click += new System.EventHandler(this.HslBottle8_Click);
			// 
			// hslBottle7
			// 
			this.hslBottle7.BackColorCenter = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.hslBottle7.BackColorEdge = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(196)))), ((int)(((byte)(216)))));
			this.hslBottle7.BackColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(232)))), ((int)(((byte)(244)))));
			this.hslBottle7.BottleTag = "7#";
			this.hslBottle7.DockHeight = 20F;
			this.hslBottle7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.hslBottle7.ForeColorCenter = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(221)))), ((int)(((byte)(98)))));
			this.hslBottle7.ForeColorEdge = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(190)))), ((int)(((byte)(77)))));
			this.hslBottle7.ForeColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(139)))));
			this.hslBottle7.Location = new System.Drawing.Point(339, 12);
			this.hslBottle7.Name = "hslBottle7";
			this.hslBottle7.Size = new System.Drawing.Size(45, 165);
			this.hslBottle7.TabIndex = 6;
			this.hslBottle7.Value = 0D;
			this.hslBottle7.Click += new System.EventHandler(this.HslBottle8_Click);
			// 
			// hslBottle6
			// 
			this.hslBottle6.BackColorCenter = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.hslBottle6.BackColorEdge = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(196)))), ((int)(((byte)(216)))));
			this.hslBottle6.BackColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(232)))), ((int)(((byte)(244)))));
			this.hslBottle6.BottleTag = "6#";
			this.hslBottle6.DockHeight = 20F;
			this.hslBottle6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.hslBottle6.ForeColorCenter = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(221)))), ((int)(((byte)(98)))));
			this.hslBottle6.ForeColorEdge = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(190)))), ((int)(((byte)(77)))));
			this.hslBottle6.ForeColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(139)))));
			this.hslBottle6.Location = new System.Drawing.Point(288, 12);
			this.hslBottle6.Name = "hslBottle6";
			this.hslBottle6.Size = new System.Drawing.Size(45, 165);
			this.hslBottle6.TabIndex = 5;
			this.hslBottle6.Value = 0D;
			this.hslBottle6.Click += new System.EventHandler(this.HslBottle8_Click);
			// 
			// hslBottle5
			// 
			this.hslBottle5.BackColorCenter = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.hslBottle5.BackColorEdge = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(196)))), ((int)(((byte)(216)))));
			this.hslBottle5.BackColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(232)))), ((int)(((byte)(244)))));
			this.hslBottle5.BottleTag = "5#";
			this.hslBottle5.DockHeight = 20F;
			this.hslBottle5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.hslBottle5.ForeColorCenter = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(221)))), ((int)(((byte)(98)))));
			this.hslBottle5.ForeColorEdge = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(190)))), ((int)(((byte)(77)))));
			this.hslBottle5.ForeColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(139)))));
			this.hslBottle5.Location = new System.Drawing.Point(237, 12);
			this.hslBottle5.Name = "hslBottle5";
			this.hslBottle5.Size = new System.Drawing.Size(45, 165);
			this.hslBottle5.TabIndex = 4;
			this.hslBottle5.Value = 0D;
			this.hslBottle5.Click += new System.EventHandler(this.HslBottle8_Click);
			// 
			// hslBottle4
			// 
			this.hslBottle4.BackColorCenter = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.hslBottle4.BackColorEdge = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(196)))), ((int)(((byte)(216)))));
			this.hslBottle4.BackColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(232)))), ((int)(((byte)(244)))));
			this.hslBottle4.BottleTag = "4#";
			this.hslBottle4.DockHeight = 20F;
			this.hslBottle4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.hslBottle4.ForeColorCenter = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(221)))), ((int)(((byte)(98)))));
			this.hslBottle4.ForeColorEdge = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(190)))), ((int)(((byte)(77)))));
			this.hslBottle4.ForeColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(139)))));
			this.hslBottle4.Location = new System.Drawing.Point(186, 12);
			this.hslBottle4.Name = "hslBottle4";
			this.hslBottle4.Size = new System.Drawing.Size(45, 165);
			this.hslBottle4.TabIndex = 3;
			this.hslBottle4.Value = 0D;
			this.hslBottle4.Click += new System.EventHandler(this.HslBottle8_Click);
			// 
			// hslBottle3
			// 
			this.hslBottle3.BackColorCenter = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.hslBottle3.BackColorEdge = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(196)))), ((int)(((byte)(216)))));
			this.hslBottle3.BackColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(232)))), ((int)(((byte)(244)))));
			this.hslBottle3.BottleTag = "3#";
			this.hslBottle3.DockHeight = 20F;
			this.hslBottle3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.hslBottle3.ForeColorCenter = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(221)))), ((int)(((byte)(98)))));
			this.hslBottle3.ForeColorEdge = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(190)))), ((int)(((byte)(77)))));
			this.hslBottle3.ForeColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(139)))));
			this.hslBottle3.Location = new System.Drawing.Point(135, 12);
			this.hslBottle3.Name = "hslBottle3";
			this.hslBottle3.Size = new System.Drawing.Size(45, 165);
			this.hslBottle3.TabIndex = 2;
			this.hslBottle3.Value = 0D;
			this.hslBottle3.Click += new System.EventHandler(this.HslBottle8_Click);
			// 
			// hslBottle2
			// 
			this.hslBottle2.BackColorCenter = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.hslBottle2.BackColorEdge = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(196)))), ((int)(((byte)(216)))));
			this.hslBottle2.BackColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(232)))), ((int)(((byte)(244)))));
			this.hslBottle2.BottleTag = "2#";
			this.hslBottle2.DockHeight = 20F;
			this.hslBottle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.hslBottle2.ForeColorCenter = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(221)))), ((int)(((byte)(98)))));
			this.hslBottle2.ForeColorEdge = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(190)))), ((int)(((byte)(77)))));
			this.hslBottle2.ForeColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(139)))));
			this.hslBottle2.Location = new System.Drawing.Point(84, 12);
			this.hslBottle2.Name = "hslBottle2";
			this.hslBottle2.Size = new System.Drawing.Size(45, 165);
			this.hslBottle2.TabIndex = 1;
			this.hslBottle2.Value = 0D;
			this.hslBottle2.Click += new System.EventHandler(this.HslBottle8_Click);
			// 
			// hslBottle1
			// 
			this.hslBottle1.BackColorCenter = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.hslBottle1.BackColorEdge = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(196)))), ((int)(((byte)(216)))));
			this.hslBottle1.BackColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(232)))), ((int)(((byte)(244)))));
			this.hslBottle1.BottleTag = "1#";
			this.hslBottle1.DockHeight = 20F;
			this.hslBottle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.hslBottle1.ForeColorCenter = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(221)))), ((int)(((byte)(98)))));
			this.hslBottle1.ForeColorEdge = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(190)))), ((int)(((byte)(77)))));
			this.hslBottle1.ForeColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(139)))));
			this.hslBottle1.Location = new System.Drawing.Point(33, 12);
			this.hslBottle1.Name = "hslBottle1";
			this.hslBottle1.Size = new System.Drawing.Size(45, 165);
			this.hslBottle1.TabIndex = 0;
			this.hslBottle1.Value = 0D;
			this.hslBottle1.Click += new System.EventHandler(this.HslBottle8_Click);
			// 
			// hslPipeLine2
			// 
			this.hslPipeLine2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hslPipeLine2.BackgroundImage")));
			this.hslPipeLine2.Location = new System.Drawing.Point(66, 299);
			this.hslPipeLine2.Name = "hslPipeLine2";
			this.hslPipeLine2.PipeLineActive = true;
			this.hslPipeLine2.Size = new System.Drawing.Size(200, 22);
			this.hslPipeLine2.TabIndex = 10;
			this.hslPipeLine2.Click += new System.EventHandler(this.HslBottle8_Click);
			// 
			// FormBottle
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1004, 645);
			this.Controls.Add(this.hslBottle11);
			this.Controls.Add(this.hslPipeLine5);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.hslPipeLine1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.hslPipeLine4);
			this.Controls.Add(this.hslPipeLine3);
			this.Controls.Add(this.hslBottle9);
			this.Controls.Add(this.hslBottle8);
			this.Controls.Add(this.hslBottle7);
			this.Controls.Add(this.hslBottle6);
			this.Controls.Add(this.hslBottle5);
			this.Controls.Add(this.hslBottle4);
			this.Controls.Add(this.hslBottle3);
			this.Controls.Add(this.hslBottle2);
			this.Controls.Add(this.hslBottle1);
			this.Controls.Add(this.hslPipeLine2);
			this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Name = "FormBottle";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FormBottle";
			this.Load += new System.EventHandler(this.FormBottle_Load);
			this.Click += new System.EventHandler(this.HslBottle8_Click);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private HslControls.HslBottle hslBottle1;
        private HslControls.HslBottle hslBottle2;
        private HslControls.HslBottle hslBottle3;
        private HslControls.HslBottle hslBottle4;
        private HslControls.HslBottle hslBottle5;
        private HslControls.HslBottle hslBottle6;
        private HslControls.HslBottle hslBottle7;
        private HslControls.HslBottle hslBottle8;
        private HslControls.HslBottle hslBottle9;
        private HslControls.HslPipeLine hslPipeLine1;
        private HslControls.HslPipeLine hslPipeLine2;
        private HslControls.HslPipeLine hslPipeLine3;
        private HslControls.HslPipeLine hslPipeLine4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private HslControls.HslPipeLine hslPipeLine5;
        private HslControls.HslBottle hslBottle10;
        private HslControls.HslPipeLine hslPipeLine6;
        private HslControls.HslPipeLine hslPipeLine7;
		private HslControls.HslBottle hslBottle11;
	}
}