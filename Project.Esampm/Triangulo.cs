using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Project.Esampm
{
   public class Triangulo
    {
        GraphicsPath gp;
        /// <summary>
        /// Obtiene o establece el punto inicial.
        /// </summary>
        public Point PI { get; set; }
        Point puntoMedio;
        /// <summary>
        /// Obtiene o establece el punto final.
        /// </summary>
        public Point PF { get; set; }
        public Triangulo() { }
        /// <summary>
        /// Crea un figura del objeto GraphicsPath
        /// </summary>
        /// <param name="ptI"></param>
        /// <param name="ptM"></param>
        /// <param name="ptF"></param>
        public Triangulo(Point ptI, Point ptM, Point ptF)
        {
            gp = new GraphicsPath();
            Point[] vertices = { ptI, ptM, ptF };
            gp.AddPolygon(vertices);
            gp.CloseFigure();
        }
        public void DrawTriangulo(Graphics g, Point puntoInicial, Point puntoFinal)
        {
            Pen pen = new Pen(Color.Black, 2);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.DrawLine(pen, puntoInicial, puntoFinal);
            //Almacenando en difPuntos la diferencia en puntoInicial y puntoFinal
            puntoMedio = new Point(puntoInicial.X - (puntoFinal.X - puntoInicial.X), puntoFinal.Y);
            g.DrawLine(pen, puntoInicial, puntoMedio);
            g.DrawLine(pen, puntoMedio, puntoFinal);
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
