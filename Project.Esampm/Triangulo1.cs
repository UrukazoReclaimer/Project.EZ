using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Esampm
{
  public  class Triangulo1
    {
        GraphicsPath gp= new GraphicsPath();
        Graphics g;
        private Point m_point1 = new Point(0, 0);
        int dx = 0;
        int dy = 0;
        int cx = 0;
        int cy = 0;
        private Point m_point2 = new Point(0, 0);
        Rectangle re = new Rectangle();
        Image imagen;
        Bitmap bmp;
        Bitmap newbmp;
        Image newImage = Image.FromFile(@"\\STORAGE\\Public\\Esam compartido\\Informática\\imagenes\\tri.jpg");
        string nombre="Trampa Pegajosa";
        Point xy = new Point(0, 0);
        int cod;
        int numero;
        string codplano;
        string tipo;
     
        public Triangulo1(int cx, int cy, int dx, int dy, int numero, string codplano, string tipo) 
        {
            this.Cx = cx;
            this.Cy = cy;
            this.Dx = dx;
            this.Dy = dy;
            this.Numero = numero;
            this.CodPlano = codplano;
            this.Tipo = tipo;
        }
        public Triangulo1()
        {

        }
        public int COD
        {
            get { return cod; }
            set { cod = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public Point XY
        {
            get { return xy; }
            set { xy = value; }
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
        public bool Dentro(Point p)
        {
            if (Point1.X>0)
            {
                return true;
            }
            else {

                return false;
            }
          
        }
        public void Mover(int dgx, int dgy)
        {
        
            gp.Transform(new Matrix(1, 0, 0, 1, dgx, dgy));
        }
        public void Draw(Graphics grfx)
        {
            xy=new Point(Cx,Cy);
            m_point1.X = Cx;
            m_point1.Y = Cy;
            m_point2.X = Dx;
            m_point2.Y = Dy;
            g = grfx;
            if ((grfx == null))
                throw new ArgumentNullException("grfx");

          //  Image newImage = Image.FromFile(@"\\STORAGE\\Public\\Esam compartido\\Informática\\imagenes\\tri.jpg");
            newImage = Image.FromFile(@"\\STORAGE\\Public\\Esam compartido\\Informática\\imagenes\\tri.jpg");
            // Create Point for upper-left corner of image.
            Point ulCorner = new Point(Cx, Cy);

            // Draw image to screen.
            //    g.DrawImage(newImage, ulCorner);
         
//           grfx.TranslateTransform(Dx/2, Dy/2);

           // grfx.RotateTransform(0.5F);
          //  newImage.RotateFlip(RotateFlipType.Rotate270FlipNone);
            grfx.DrawImage(newImage, Cx, Cy, Dx, Dy);
            
            /*
            Imagen = newImage;
            bmp = new Bitmap(@"\\STORAGE\\Public\\Esam compartido\\Informática\\imagenes\\tri.jpg");
            int origWidth = bmp.Width;
            int origHeight = bmp.Height;
            int sngRatio = origWidth / origHeight;
            int newWidth = Dx;
            int newHeight = Dy;
            if (newWidth > 0)
            {
                newbmp = new Bitmap(bmp, newWidth, newHeight);
            }
             */
        }
        public void Drawrot(Graphics grfx)
        {
            m_point1.X = Cx;
            m_point1.Y = Cy;
            m_point2.X = Dx;
            m_point2.Y = Dy;

            g = grfx;
            if ((grfx == null))
                throw new ArgumentNullException("grfx");
            newImage = Image.FromFile(@"\\STORAGE\\Public\\Esam compartido\\Informática\\imagenes\\tri.jpg");
            // Create Point for upper-left corner of image.
            Point ulCorner = new Point(Cx, Cy);
         
            newImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
            grfx.DrawImage(newImage, Cx, Cy, Dx, Dy);

          
        }
        public void reves() 
        {
            newImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
           
        }
        public void listobmp()
        {
            m_point1.X = Cx;
            m_point1.Y = Cy;
            m_point2.X = Dx;
            m_point2.Y = Dy;

            
            Imagen = newImage;
            bmp = new Bitmap(@"\\STORAGE\\Public\\Esam compartido\\Informática\\imagenes\\tri.jpg");
            int origWidth = bmp.Width;
            int origHeight = bmp.Height;
            int sngRatio = origWidth / origHeight;
            int newWidth = Dx;
            int newHeight = Dy;
            if (newWidth > 0)
            {
                newbmp = new Bitmap(bmp, newWidth, newHeight);
            }
             
        }
        public Bitmap BMP
        {
            get { return newbmp; }
            set { newbmp = value; }

        }
        public Image Imagen 
        {
            get { return newImage; }
            set { newImage = value; }
        
        }
    }



}
