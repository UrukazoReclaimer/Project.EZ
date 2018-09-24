using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Esampm
{
   public class Actualizadopor
    {
        private Point m_point1 = new Point(0, 0);
        private Point m_point2 = new Point(0, 0);
        private PointF pf = new PointF(0, 0);
        int cx = 0;
        int cy = 0;
        string tex = "";
        int f = 8;
        public Point Point1
        {
            get { return m_point1; }
            set { m_point1 = value; }
        }

        public Point Point2
        {
            get { return m_point2; }
            set { m_point2 = value; }
        }
        public PointF PointFF
        {
            get { return pf; }
            set { pf = value; }
        }
        public int Cx
        {
            get { return cx; }
            set { cx = value; }
        }
        public int Cy
        {
            get { return cy; }
            set { cy = value; }
        }
        public string TEX
        {
            get { return tex; }
            set { tex = value; }
        }
        public int F
        {
            get { return f; }
            set { f = value; }
        }

        public void Draw(Graphics grfx)
        {
            if ((grfx == null))
                throw new ArgumentNullException("grfx");

            Font myFont = new Font("Arial", 14);

            // Draw image to screen.
            // g.DrawImage(newImage, ulCorner);
            grfx.DrawString("Actualizado Por:" + TEX, myFont, Brushes.Black, Point1);
            //  grfx.Dispose();
            //  pen.Dispose();
        }
    }
}
