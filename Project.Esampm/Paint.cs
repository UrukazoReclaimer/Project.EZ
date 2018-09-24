using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.IO;

namespace Project.Esampm
{
    public partial class Paint : Form
    {
        Graphics g;
        Pen p = new Pen(Color.Black, 1);
        Point sp = new Point(0, 0);
        Point ep = new Point(0, 0);
        int k = 0;
        int figura;
        private int cX, cY, x, y, dX, dY;
        private Point px = new Point();
        private Point py = new Point();
        Color color;
        public Paint()
        {
            InitializeComponent();
            color = Color.Black;
		
		
        }

      

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = "X: " + Convert.ToString(x);
            label2.Text = "y: " + Convert.ToString(y);
            if (k == 1)
            {
                ep = e.Location;
                x = e.X;
                y = e.Y;

                if (figura == 1)
                {
                    g.DrawLine(new Pen(color), sp, ep);
                }
                else if (figura == 2)
                {
                    g.FillEllipse(new SolidBrush(color), e.X, e.Y, 60, 60);
                }
                if (figura == 3)
                {

                    g.DrawLine(new Pen(color), px, e.Location);
                  

                }
               
                else if (figura == 6)
                {
                    g.FillEllipse(new SolidBrush(color), e.X, e.Y, 60, 60);
                }
                else if (figura == 7)
                {
                    g.FillEllipse(new SolidBrush(color), e.X, e.Y, 5, 5);
                }
                else if (figura == 8)
                {
                    g.FillEllipse(new SolidBrush(color), e.X, e.Y, 15, 15);
                }
                else if (figura == 9)
                {
                    g.FillEllipse(new SolidBrush(color), e.X, e.Y, 25, 25);
                }
                else if (figura == 10)
                {
                    g.FillEllipse(new SolidBrush(color), e.X, e.Y, 35, 35);
                }
                sp = ep;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            sp = e.Location;
            if (e.Button == MouseButtons.Left)
            {
                k = 1;
            }
            cX = e.X;
            cY = e.Y;

            if (figura == 3) 
            {
                px = e.Location;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (figura == 3)
            {
                
                g.DrawLine(new Pen(color), px, e.Location);


            }
            k = 0;
        }

        private void Paint_Load(object sender, EventArgs e)
        {
            g = pictureBox1.CreateGraphics();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            figura = 3;
        }
    }
}
