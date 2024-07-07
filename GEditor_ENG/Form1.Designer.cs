namespace GEditor_ENG
{
    partial class frmPicture
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnActor = new System.Windows.Forms.Button();
            this.btnEclipste = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnline = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tSSLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSLabeL3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelBackColor = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panelBackColor2 = new System.Windows.Forms.Panel();
            this.panelConturColor = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelBackColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelConturColor);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.panelBackColor2);
            this.panel1.Controls.Add(this.btnActor);
            this.panel1.Controls.Add(this.btnEclipste);
            this.panel1.Controls.Add(this.btnRectangle);
            this.panel1.Controls.Add(this.btnline);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 552);
            this.panel1.TabIndex = 0;
            // 
            // btnActor
            // 
            this.btnActor.Location = new System.Drawing.Point(136, 129);
            this.btnActor.Name = "btnActor";
            this.btnActor.Size = new System.Drawing.Size(106, 70);
            this.btnActor.TabIndex = 3;
            this.btnActor.Text = "Actor";
            this.btnActor.UseVisualStyleBackColor = true;
            this.btnActor.Click += new System.EventHandler(this.btnActor_Click);
            // 
            // btnEclipste
            // 
            this.btnEclipste.Location = new System.Drawing.Point(23, 23);
            this.btnEclipste.Name = "btnEclipste";
            this.btnEclipste.Size = new System.Drawing.Size(94, 70);
            this.btnEclipste.TabIndex = 2;
            this.btnEclipste.Text = "Eclipse";
            this.btnEclipste.UseVisualStyleBackColor = true;
            this.btnEclipste.Click += new System.EventHandler(this.btnEclipste_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.Location = new System.Drawing.Point(136, 23);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(106, 70);
            this.btnRectangle.TabIndex = 1;
            this.btnRectangle.Text = "Rectangle";
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnline
            // 
            this.btnline.Location = new System.Drawing.Point(23, 129);
            this.btnline.Name = "btnline";
            this.btnline.Size = new System.Drawing.Size(94, 70);
            this.btnline.TabIndex = 0;
            this.btnline.Text = "Line";
            this.btnline.UseVisualStyleBackColor = true;
            this.btnline.Click += new System.EventHandler(this.btnline_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSSLabel1,
            this.tSSLabel2,
            this.tSSLabeL3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 558);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1174, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tSSLabel1
            // 
            this.tSSLabel1.AutoSize = false;
            this.tSSLabel1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tSSLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.tSSLabel1.Name = "tSSLabel1";
            this.tSSLabel1.Size = new System.Drawing.Size(118, 17);
            // 
            // tSSLabel2
            // 
            this.tSSLabel2.AutoSize = false;
            this.tSSLabel2.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tSSLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.tSSLabel2.Name = "tSSLabel2";
            this.tSSLabel2.Size = new System.Drawing.Size(118, 17);
            // 
            // tSSLabeL3
            // 
            this.tSSLabeL3.AutoSize = false;
            this.tSSLabeL3.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tSSLabeL3.BorderStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.tSSLabeL3.Name = "tSSLabeL3";
            this.tSSLabeL3.Size = new System.Drawing.Size(118, 17);
            // 
            // panelBackColor
            // 
            this.panelBackColor.BackColor = System.Drawing.Color.White;
            this.panelBackColor.Location = new System.Drawing.Point(283, 3);
            this.panelBackColor.Name = "panelBackColor";
            this.panelBackColor.Size = new System.Drawing.Size(888, 552);
            this.panelBackColor.TabIndex = 2;
            this.panelBackColor.TabStop = false;
            this.panelBackColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.panelBackColor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.panelBackColor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // panelBackColor2
            // 
            this.panelBackColor2.BackColor = System.Drawing.Color.White;
            this.panelBackColor2.Location = new System.Drawing.Point(34, 226);
            this.panelBackColor2.Name = "panelBackColor2";
            this.panelBackColor2.Size = new System.Drawing.Size(94, 98);
            this.panelBackColor2.TabIndex = 3;
            this.panelBackColor2.DoubleClick += new System.EventHandler(this.panelBackColor2_DoubleClick);
            // 
            // panelConturColor
            // 
            this.panelConturColor.BackColor = System.Drawing.Color.Black;
            this.panelConturColor.Location = new System.Drawing.Point(141, 230);
            this.panelConturColor.Name = "panelConturColor";
            this.panelConturColor.Size = new System.Drawing.Size(101, 94);
            this.panelConturColor.TabIndex = 4;
            this.panelConturColor.DoubleClick += new System.EventHandler(this.panelConturColor_DoubleClick);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(23, 349);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(230, 45);
            this.trackBar1.TabIndex = 5;
            // 
            // frmPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 580);
            this.Controls.Add(this.panelBackColor);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "frmPicture";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelBackColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tSSLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tSSLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tSSLabeL3;
        private System.Windows.Forms.Button btnActor;
        private System.Windows.Forms.Button btnEclipste;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnline;
        private System.Windows.Forms.PictureBox panelBackColor;
        private System.Windows.Forms.Panel panelBackColor2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panelConturColor;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

