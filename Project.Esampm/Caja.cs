using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Esampm
{
  public  class Caja
    {
       private Point m_point1 = new Point(0, 0);
        int dx = 0;
        int dy = 0;
        int cx = 0;
        int cy = 0;
        private Point m_point2 = new Point(0, 0);
         int cod;
          int numero;
        string codplano;
        string tipo;
        public Caja()
        { }
        public Caja(int cx, int cy, int dx, int dy, int numero, string codplano, string tipo) 
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
            if ((grfx == null))
                throw new ArgumentNullException("grfx");

            Image newImage = Image.FromFile(@"\\STORAGE\\Public\\Esam compartido\\Informática\\imagenes\\Caja Cebadera.PNG");
            //Z:\Esam compartido\Informática\imagenes
            //@"\\STORAGE\\Public\\Esam compartido\\Informática\\esam.jpg"
            // Create Point for upper-left corner of image.
            Point ulCorner = new Point(Cx, Cy);

            // Draw image to screen.
            //    g.DrawImage(newImage, ulCorner);
            grfx.DrawImage(newImage, Cx, Cy, Dx, Dy);

        }
    
    }
}
