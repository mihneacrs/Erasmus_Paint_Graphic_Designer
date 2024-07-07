using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GEditor_ENG
{
    public partial class frmPicture : Form
    {

        Point startPosition, endPosition;
        Pen blackPen = new Pen(Color.Black, 3);
        SolidBrush brush = new SolidBrush(Color.Transparent);

        string currentOperation = "";
        Graphics myGraph;

        public frmPicture()
        {
            InitializeComponent();
        }


        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            tSSLabeL3.Text = e.X + " x " + e.Y; //shows X and Y coordonates when the mouse is moving
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            tSSLabel1.Text = e.X + " x " + e.Y; //shows X and Y coordonates when the mouse button is raised
            startPosition.X = e.X;
            startPosition.Y = e.Y;
            blackPen.Width = trackBar1.Value;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            tSSLabel2.Text = e.X + " x " + e.Y; //shows X and Y coordonates when the mouse button is released
            endPosition.Y = e.Y;
            endPosition.X = e.X;

            int width = endPosition.X - startPosition.X;
            int height = endPosition.Y - startPosition.Y;
            myGraph = panelBackColor.CreateGraphics();

            switch (currentOperation)
            {
                case "Elipse":
                    {
                        myGraph.FillEllipse(brush, startPosition.X, startPosition.Y, width, height);
                        myGraph.DrawEllipse(blackPen, startPosition.X, startPosition.Y, width, height);
                        break;
                    }
                case "Rectangle":
                    {
                        myGraph.FillRectangle(brush,startPosition.X, startPosition.Y, width, height);
                        myGraph.DrawRectangle(blackPen, startPosition.X, startPosition.Y, width, height);
                        break;
                    }
                case "Line":
                    myGraph.DrawLine(blackPen, startPosition, endPosition);
                    break;
                case "Actor":
                    {
                        int headHeight = (int)Math.Round(1.0 / 4.0 * height);
                        int headWidth = (int)Math.Round((1.0 / 3.0) * width);
                        myGraph.DrawEllipse(blackPen,
                                                    startPosition.X + (int)Math.Round((1.0 / 3.0) * width),
                                                    startPosition.Y,
                                                    headWidth,
                                                    headHeight);
                        //head
                        myGraph.DrawLine(blackPen,
                                         startPosition.X + (int)Math.Round((1.0 / 2.0) * width),
                                         startPosition.Y + (int)Math.Round((1.0 / 4.0) * height),
                                         startPosition.X + (int)Math.Round((1.0 / 2.0) * width),
                                         startPosition.Y + (int)Math.Round((5.0 / 8.0) * height));
                        //body
                        myGraph.DrawLine(blackPen,
                                         startPosition.X + (int)Math.Round((1.0 / 2.0) * width),
                                         startPosition.Y + (int)Math.Round((1.0 / 4.0) * height),
                                         startPosition.X + (int)Math.Round((1.0 / 2.0) * width),
                                         startPosition.Y + (int)Math.Round((5.0 / 8.0) * height));
                        //left leg
                        myGraph.DrawLine(blackPen,
                                         startPosition.X + (int)Math.Round((1.0 / 2.0) * width),
                                         startPosition.Y + (int)Math.Round((5.0 / 8.0) * height),
                                         startPosition.X + (int)Math.Round((1.0 / 5.0) * width),
                                         endPosition.Y);
                        //right leg
                        myGraph.DrawLine(blackPen,
                                         startPosition.X + (int)Math.Round((1.0 / 2.0) * width),
                                         startPosition.Y + (int)Math.Round((5.0 / 8.0) * height),
                                         startPosition.X + (int)Math.Round((4.0 / 5.0) * width),
                                         endPosition.Y);

                        //arms
                        myGraph.DrawLine(blackPen,
                                        startPosition.X,
                                        startPosition.Y + (int)Math.Round((1.0 / 3.0) * height),
                                        endPosition.X,
                                        startPosition.Y + (int)Math.Round((1.0 / 3.0) * height));

                        break;
                    }
            }



        }

        private void btnEclipste_Click(object sender, EventArgs e)
        {
            currentOperation = "Elipse";
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            currentOperation = "Rectangle";
        }

        private void btnline_Click(object sender, EventArgs e)
        {
            currentOperation = "Line";
        }

        private void btnActor_Click(object sender, EventArgs e)
        {
            currentOperation = "Actor";
        }

        private void panelConturColor_DoubleClick(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                blackPen.Color = colorDialog1.Color;
                panelConturColor.BackColor = colorDialog1.Color;

            }

        }

        private void panelBackColor2_DoubleClick(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                brush.Color = colorDialog1.Color;
                panelBackColor2.BackColor = colorDialog1.Color;

            }
        }
    }
}
