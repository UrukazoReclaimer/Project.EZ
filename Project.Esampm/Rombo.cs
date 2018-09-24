using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Project.Esampm
{
   public class Rombo
    {
        GraphicsPath gp;
        public Point puntoInicial { get; set; }
        public Point puntoFinal { get; set; }
        Point difPuntos3;
        Point difPuntos4;

        public Rombo() { }
        public Rombo(Point pt1, Point pt2, Point pt3, Point pt4)
        {
            gp = new GraphicsPath();
            Point[] vertices = { pt1, pt2, pt3, pt4 };
            gp.AddPolygon(vertices);
            gp.CloseFigure();
        }
        public void DrawRombo(Graphics g, Point puntoInicial, Point puntoFinal)
        {
            //Dibujando empezando de arriba hasta llegar punto inicial por la derecha
            Pen pen = new Pen(Color.Black, 2);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.DrawLine(pen, puntoInicial, puntoFinal);
            difPuntos3 = new Point(puntoInicial.X, (puntoFinal.Y - puntoInicial.Y) + puntoFinal.Y);
            g.DrawLine(pen, puntoFinal, difPuntos3);
            difPuntos4 = new Point(puntoInicial.X - (puntoFinal.X - puntoInicial.X), puntoFinal.Y);
            g.DrawLine(pen, difPuntos3, difPuntos4);
            g.DrawLine(pen, difPuntos4, puntoInicial);
            g.Dispose();
            pen.Dispose();
        }
        public bool Dentro(Point p)
        {
            if (gp.IsOutlineVisible(p, new Pen(Color.DarkViolet)))
            {
                return true;
            }
            else
            {
                return gp.IsVisible(p);
            }
        }
        public void Mover(int dx, int dy)
        {
            gp.Transform(new Matrix(1, 0, 0, 1, dx, dy));
        }
        public void Dibujar(Graphics e)
        {
            Pen pen = new Pen(Color.DarkViolet, 2);
            e.SmoothingMode = SmoothingMode.AntiAlias;
            e.DrawPath(pen, gp);
        }
    }
}
