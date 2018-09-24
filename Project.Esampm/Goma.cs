using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Esampm
{
  public  class Goma
    {
       private Point m_point1 = new Point(0, 0);
        int dx=0;
        int dy=0;
        int cx=0;
        int cy = 0;
        private Point m_point2 = new Point(0, 0);
       
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
        public int Dx
        {
            get { return dx; }
            set { dx = value; }
        }
        public int Dy
        {
            get { return dy; }
            set { dy = value; }
        }
        public void Draw(Graphics grfx)
        {
            if ((grfx == null))
                throw new ArgumentNullException("grfx");
            
            // Dibujamos la línea.
          //  Rectangle rect = new Rectangle(0, 100, 200, 200);
            grfx.FillEllipse(new SolidBrush(Color.White), Cx, Cy, 8, 8);       
         //   grfx.Dispose();
           // grfx.DrawRectangle(Pens.Black, rect);

        }
        public void DrawLapiz(Graphics grfx, int grosor)
        {
            if ((grfx == null))
                throw new ArgumentNullException("grfx");

            // Dibujamos la línea.
            //  Rectangle rect = new Rectangle(0, 100, 200, 200);
            grfx.FillEllipse(new SolidBrush(Color.Black), Cx, Cy, grosor, grosor);
            //   grfx.Dispose();
            // grfx.DrawRectangle(Pens.Black, rect);

        }
    
    }
}
