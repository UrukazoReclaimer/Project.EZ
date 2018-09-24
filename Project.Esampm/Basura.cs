using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Esampm
{
  public  class Basura
    {

         private Point m_point1 = new Point(0, 0);
        int dx = 0;
        int dy = 0;
        int cx = 0;
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

            Image newImage = Image.FromFile(@"\\STORAGE\\Public\\Esam compartido\\Informática\\imagenes\\Basura.jpg");          
            Point ulCorner = new Point(Cx, Cy);
            grfx.DrawImage(newImage, Cx, Cy, Dx, Dy);
            
        }
        public void DrawWhite(Graphics grfx)
        {
            if ((grfx == null))
                throw new ArgumentNullException("grfx");
            grfx.DrawRectangle(Pens.White, Cx, Cy, Dx, Dy);

        }
    }

    }

