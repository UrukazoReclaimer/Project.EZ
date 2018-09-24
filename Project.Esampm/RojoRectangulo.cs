using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Esampm
{
    class RojoRectangulo
    {
          private Point m_point1 = new Point(0, 0);
        int dx=0;
        int dy=0;
        int cx=0;
        int cy = 0;
        private Point m_point2 = new Point(0, 0);
         int numero;
        string codplano;
        string tipo;
        public RojoRectangulo()
        { }
        public RojoRectangulo(int cx, int cy, int dx, int dy, int numero, string codplano, string tipo) 
        {
            this.Cx = cx;
            this.Cy = cy;
            this.Dx = dx;
            this.Dy = dy;
            this.Numero = numero;
            this.CodPlano = codplano;
            this.Tipo = tipo;
        
        }
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
        public string CodPlano
        {
            get { return codplano; }
            set { codplano = value; }
        }
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public void Draw(Graphics grfx)
        {
            m_point1.X = Cx;
            m_point1.Y = Cy;
            if ((grfx == null))
                throw new ArgumentNullException("grfx");
            
            // Dibujamos la línea.
            //
          //  Rectangle rect = new Rectangle(0, 100, 200, 200);
            grfx.FillRectangle(new SolidBrush(Color.Red), Cx, Cy, Dx, Dy);
         //   grfx.Dispose();
           // grfx.DrawRectangle(Pens.Black, rect);

        }
    
    }
}
