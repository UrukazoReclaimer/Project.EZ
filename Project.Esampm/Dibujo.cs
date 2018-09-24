using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.IO;
using System.Drawing.Drawing2D;
using System.Drawing.Design;
using Project.BussinessRules;


namespace Project.Esampm
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class Dibujo : Form
    {
        Graphics g;
   
        private List<Line> m_lstOfLine = new List<Line>();
        private Line m_line;
        List<Point> points = new List<Point>();
        private Cuadrado m_cuadrado;
         List<int> pointscuadrado = new List<int>();
         private List<Cuadrado> m_lstOfcua = new List<Cuadrado>();
         private Circulo m_circulo;
         List<int> pointscirculo = new List<int>();
         private List<Circulo> m_lstOfcir = new List<Circulo>();
         private RectanguloFill m_rfill;
         List<int> pointrectangulofill = new List<int>();
         private List<RectanguloFill> m_lstOfrfill = new List<RectanguloFill>();
         private Lapiz m_lapiz = new Lapiz();
         List<int> pointlapiz= new List<int>();
         private List<Lapiz> m_lstOflapiz = new List<Lapiz>();
         private fillCirculo m_fillcirculo = new fillCirculo();
         List<int> pointFillCirculo = new List<int>();

         private List<RojoRectangulo> m_lstOfRojor = new List<RojoRectangulo>();
         private RojoRectangulo m_RojoCua= new RojoRectangulo();

         private List<Arbol> m_lstOfArbol = new List<Arbol>();
         private Arbol m_Arbol = new Arbol();

         private List<Cancha> m_lstOfCancha = new List<Cancha>();
         private Cancha m_Cancha = new Cancha();

         private List<Estacionamiento> m_lstOfEstacionamiento = new List<Estacionamiento>();
         private Estacionamiento m_Estacionamiento = new Estacionamiento();

         private List<Gota> m_lstOfGota = new List<Gota>();
         private Gota m_Gota = new Gota();

         private List<Basura> m_lstOfBasura = new List<Basura>();
         private Basura m_Basura = new Basura();

         private List<Zanja> m_lstOfZanja = new List<Zanja>();
         private Zanja m_Zanja= new Zanja();

         private List<Pozo> m_lstOfPozo = new List<Pozo>();
         private Pozo m_Pozo = new Pozo();

         private List<Zona> m_lstOfZona = new List<Zona>();
         private Zona m_Zona = new Zona();

         private List<Triangulo1> m_lstOfTri = new List<Triangulo1>();
         private Triangulo1 m_tria = new Triangulo1();

         private List<Anclado> m_lstOfAnclado = new List<Anclado>();
         private Anclado m_anclado = new Anclado();

         private List<Techado> m_lstOfTechado = new List<Techado>();
         private Techado m_techado = new Techado();

         private List<Tubo> m_lstOfTubo = new List<Tubo>();
         private Tubo m_tubo = new Tubo();
       

         private List<fillCirculo> m_lstfillCirculo = new List<fillCirculo>();

         private Palabras m_fillpalabra = new Palabras();
         List<int> pointFillpalabra = new List<int>();
         private List<Palabras> m_lstfillPalabra = new List<Palabras>();
         Pen p = new Pen(Color.Black, 1);
         Point sp = new Point(0, 0);
         Point ep = new Point(0, 0);
         int k = 0;
         int figura;
         private int cX, cY, x, y, dX, dY;
         Color color;
 
        bool clic;
        OpenFileDialog o = new OpenFileDialog();
        bool cargar;
        public Dibujo()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            Load += MainFormLoad;
            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
            color = Color.Black;
        }
        void MainFormMouseUp(object sender, MouseEventArgs e)
        {
          
        }
        void PantallaMouseDown(object sender, MouseEventArgs e)
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
                    if (e.Button == MouseButtons.Left)
                    {
                        clic = true;                    
                        m_line = new Line();
                        m_line.Point1 = e.Location;
                    }
                }
                if (figura == 5)
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        clic = true;                     
                        m_cuadrado = new Cuadrado();
                        m_cuadrado.Cx = e.Location.X;
                        m_cuadrado.Cy = e.Location.Y;                    
                    }
                }
                if (figura == 4)
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        clic = true;
                        m_circulo = new Circulo();
                        m_circulo.Cx = e.Location.X;
                        m_circulo.Cy = e.Location.Y;
                    }
                }
                if (figura == 13)
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        clic = true;
                        m_rfill = new RectanguloFill();
                        m_rfill.Cx = e.Location.X;
                        m_rfill.Cy = e.Location.Y;
                    
                    }
                }
                if (figura == 1)
                {
                    
                    if (e.Button == MouseButtons.Left)
                    {
                        clic = true;
                        m_lapiz = new Lapiz();
                        m_lapiz.Point1 = e.Location;
                        m_lapiz.Point2 = m_lapiz.Point1;
                       // m_lstOflapiz.Add(m_lapiz);
                    }
                      
                }
                if (figura == 19)
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        clic = true;
                        m_fillcirculo = new fillCirculo();
                        m_fillcirculo.Cx = e.Location.X;
                        m_fillcirculo.Cy = e.Location.Y;
                      
                    }
                }
                if (figura == 17)
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        clic = true;
                        m_fillpalabra = new Palabras();
                        m_fillpalabra.Point1 = e.Location;
                        
                    }
                }
                if (figura == 20)
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        clic = true;
                        m_RojoCua = new RojoRectangulo();
                        m_RojoCua.Cx = e.Location.X;
                        m_RojoCua.Cy = e.Location.Y;
                    }
                }
                if (figura == 15)
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        clic = true;
                        m_Arbol = new Arbol();
                        m_Arbol.Cx = e.Location.X;
                        m_Arbol.Cy = e.Location.Y;
                    }
                }
                if (figura == 12)
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        clic = true;
                        m_Cancha = new Cancha();
                        m_Cancha.Cx = e.Location.X;
                        m_Cancha.Cy = e.Location.Y;
                    }
                }

                if (figura == 16)
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        clic = true;
                        m_Estacionamiento = new Estacionamiento();
                        m_Estacionamiento.Cx = e.Location.X;
                        m_Estacionamiento.Cy = e.Location.Y;
                    }
                }
                if (figura == 21)
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        clic = true;
                        m_Gota = new Gota();
                        m_Gota.Cx = e.Location.X;
                        m_Gota.Cy = e.Location.Y;
                    }
                }
                if (figura == 22)
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        clic = true;
                        m_Basura = new Basura();
                        m_Basura.Cx = e.Location.X;
                        m_Basura.Cy = e.Location.Y;
                    }
                }
                if (figura == 14)
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        clic = true;
                        m_Zanja = new Zanja();
                        m_Zanja.Cx = e.Location.X;
                        m_Zanja.Cy = e.Location.Y;
                    }
                }
                if (figura == 23)
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        clic = true;
                        m_Pozo = new Pozo();
                        m_Pozo.Cx = e.Location.X;
                        m_Pozo.Cy = e.Location.Y;
                    }
                }
                if (figura == 24)
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        clic = true;
                        m_Zona = new Zona();
                        m_Zona.Cx = e.Location.X;
                        m_Zona.Cy = e.Location.Y;
                    }
                }
                if (figura == 25)
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        clic = true;
                        m_tria = new Triangulo1();
                        m_tria.Cx = e.Location.X;
                        m_tria.Cy = e.Location.Y;
                    }
                }

                if (figura == 26)
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        clic = true;
                        m_anclado = new Anclado();
                        m_anclado.Cx = e.Location.X;
                        m_anclado.Cy = e.Location.Y;
                    }
                }
                if (figura == 27)
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        clic = true;
                        m_techado = new Techado();
                        m_techado.Cx = e.Location.X;
                        m_techado.Cy = e.Location.Y;
                    }
                }
                if (figura == 28)
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        clic = true;
                        m_tubo = new Tubo();
                        m_tubo.Cx = e.Location.X;
                        m_tubo.Cy = e.Location.Y;
                    }
                }
        }
        void PantallaMouseMove(object sender, MouseEventArgs e)
        {
         //   g = Pantalla.CreateGraphics();
            if (cargar ==true)
            {
                g = Graphics.FromImage(Pantalla.Image);
            }
            if (clic)
             {
             
                if (figura == 3)
                {
                    if (((m_line == null) || (e.Button != MouseButtons.Left)))
                        return;      
                    m_line.Point2 = e.Location;
    //                g.Clear(Color.White);
    //                m_line.Draw(g);
                  
                    Pantalla.Invalidate();    
                    Pantalla.Image.Save("PictureBox.bmp", System.Drawing.Imaging.ImageFormat.Bmp); 
                }
                if (figura == 5)
                {
                    if (((m_cuadrado == null) || (e.Button != MouseButtons.Left)))
                        return;            
                    m_cuadrado.Dx = e.Location.X - m_cuadrado.Cx;
                    m_cuadrado.Dy = e.Location.Y - m_cuadrado.Cy;
                   // g.Clear(Color.White);

                    m_cuadrado.Draw(g);
                  
                   Pantalla.Invalidate();                 
                   Pantalla.Image.Save("PictureBox.bmp", System.Drawing.Imaging.ImageFormat.Bmp); 
                }
                if (figura == 4)
                {
                    if (((m_circulo == null) || (e.Button != MouseButtons.Left)))
                        return;        
                    m_circulo.Dx = e.Location.X - m_circulo.Cx;
                    m_circulo.Dy = e.Location.Y - m_circulo.Cy;
                //    g.Clear(Color.White);
                 
     //               m_circulo.Draw(g);
                  
                    Pantalla.Invalidate();                  
                    Pantalla.Image.Save("PictureBox.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                }
                if (figura == 1)
                {
                    if (((m_lapiz == null) || (e.Button != MouseButtons.Left)))
                        return;
                 
                     
                  
                    m_lapiz.Point2 = e.Location;
                  //  g.Clear(Color.White);
                
                  // m_lapiz.Draw(g);
                    
                    m_lapiz.Point1=  m_lapiz.Point2;
                  
                    
                    Pantalla.Image.Save("PictureBox.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                    Pantalla.Invalidate();
                    //Pantalla.Refresh();
                }

                if (figura == 12)
                {
                    if (((m_Cancha == null) || (e.Button != MouseButtons.Left)))
                        return;
                    m_Cancha.Dx = e.Location.X - m_Cancha.Cx;
                    m_Cancha.Dy = e.Location.Y - m_Cancha.Cy;
                 //   g.Clear(Color.White);                  
                   // m_Cancha.Draw(g);
                    Pantalla.Invalidate();
                    Pantalla.Image.Save("PictureBox.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                }
                if (figura == 16)
                {
                    if (((m_Estacionamiento == null) || (e.Button != MouseButtons.Left)))
                        return;
                    m_Estacionamiento.Dx = e.Location.X - m_Estacionamiento.Cx;
                    m_Estacionamiento.Dy = e.Location.Y - m_Estacionamiento.Cy;
                 //   g.Clear(Color.White);                  
                    m_Estacionamiento.Draw(g);
                    Pantalla.Invalidate();
                    Pantalla.Image.Save("PictureBox.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                }
                if (figura == 22)
                {
                    if (((m_Basura == null) || (e.Button != MouseButtons.Left)))
                        return;
                    m_Basura.Dx = e.Location.X - m_Basura.Cx;
                    m_Basura.Dy = e.Location.Y - m_Basura.Cy;
                  //  g.Clear(Color.White);
                    m_Basura.Draw(g);
                    Pantalla.Invalidate();
                    Pantalla.Image.Save("PictureBox.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                }
                if (figura == 14)
                {
                    if (((m_Zanja == null) || (e.Button != MouseButtons.Left)))
                        return;
                    m_Zanja.Dx = e.Location.X - m_Zanja.Cx;
                    m_Zanja.Dy = e.Location.Y - m_Zanja.Cy;
                 //   g.Clear(Color.White);
                    m_Zanja.Draw(g);
                    Pantalla.Invalidate();
                    Pantalla.Image.Save("PictureBox.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                }
                if (figura == 23)
                {
                    if (((m_Pozo == null) || (e.Button != MouseButtons.Left)))
                        return;
                    m_Pozo.Dx = e.Location.X - m_Pozo.Cx;
                    m_Pozo.Dy = e.Location.Y - m_Pozo.Cy;
                 //   g.Clear(Color.White);
                    m_Pozo.Draw(g);
                    Pantalla.Invalidate();
                    Pantalla.Image.Save("PictureBox.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                }
                if (figura == 24)
                {
                    if (((m_Zona == null) || (e.Button != MouseButtons.Left)))
                        return;
                    m_Zona.Dx = e.Location.X - m_Zona.Cx;
                    m_Zona.Dy = e.Location.Y - m_Zona.Cy;
                 //   g.Clear(Color.White);
                    m_Zona.Draw(g);
                    Pantalla.Invalidate();
                    Pantalla.Image.Save("PictureBox.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                }
                if (figura == 27)
                {
                    if (((m_techado == null) || (e.Button != MouseButtons.Left)))
                        return;
                    m_techado.Dx = e.Location.X - m_techado.Cx;
                    m_techado.Dy = e.Location.Y - m_techado.Cy;
                 //   g.Clear(Color.White);
                    m_techado.Draw(g);
                    Pantalla.Invalidate();
                    Pantalla.Image.Save("PictureBox.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                }
             







           /*    
                if (_selecting)
                {
                    _selection.Width = e.X - _selection.X;
                    _selection.Height = e.Y - _selection.Y;

               

                }
            */

            }

          ///////  Pantalla.Update();
            label1.Text = "X: " + Convert.ToString(x);
            label2.Text = "y: " + Convert.ToString(y);
            if (k == 1)
            {
               // ep = e.Location;
                x = e.X;
                y = e.Y;

                if (figura == 1)
                {
                  //  g.DrawLine(new Pen(color), sp, ep);
                }
                else if (figura == 2)
                {
                    g.FillEllipse(new SolidBrush(color), e.X, e.Y, 60, 60);
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
        void PantallaMouseUp(object sender, MouseEventArgs e)
        {
            k = 0;

         
         
            if (figura == 3) { 
            if (((m_line == null) || (!Pantalla.Capture) || (e.Button != MouseButtons.Left)))
                return;
        
            m_line.Point2 = e.Location;
            m_lstOfLine.Add(m_line);
           
        //    Pantalla.Invalidate();
    
        
        }
            if (figura == 5)
            {
                if (((m_cuadrado == null) || (!Pantalla.Capture) || (e.Button != MouseButtons.Left)))
                    return;

                m_cuadrado.Dx = e.Location.X - m_cuadrado.Cx;
                m_cuadrado.Dy = e.Location.Y - m_cuadrado.Cy;
           
                m_lstOfcua.Add(m_cuadrado);
             
              //  Pantalla.Invalidate();
        
            }
            if (figura == 4)
            {
                if (((m_circulo == null) || (!Pantalla.Capture) || (e.Button != MouseButtons.Left)))
                    return;
                m_circulo.Dx = e.Location.X - m_circulo.Cx;
                m_circulo.Dy = e.Location.Y - m_circulo.Cy;
                m_lstOfcir.Add(m_circulo);
                //Pantalla.Invalidate();

            }
            if (figura == 13)
            {
                if (((m_rfill == null) || (!Pantalla.Capture) || (e.Button != MouseButtons.Left)))
                    return;
                m_rfill.Dx = Convert.ToInt32(comboBox2.Text);
                m_rfill.Dy = Convert.ToInt32(comboBox2.Text);
                m_lstOfrfill.Add(m_rfill);
              //  Pantalla.Invalidate();

            }
            if (figura == 1)
            {
                if (((m_lapiz == null) || (!Pantalla.Capture) || (e.Button != MouseButtons.Left)))
                    return;

                m_lapiz.Point2 = e.Location;
                //m_lapiz.Point1 = m_lapiz.Point2;   
                m_lstOflapiz.Add(m_lapiz);
            //   Pantalla.Invalidate();
            }
            if (figura == 19)
            {
                if (((m_fillcirculo == null) || (!Pantalla.Capture) || (e.Button != MouseButtons.Left)))
                    return;
                m_fillcirculo.Dx = Convert.ToInt32(comboBox2.Text);
                m_fillcirculo.Dy = Convert.ToInt32(comboBox2.Text);
                m_lstfillCirculo.Add(m_fillcirculo);
                //  Pantalla.Invalidate();

            }
            if (figura == 17)
            {
                if (((m_fillpalabra == null) || (!Pantalla.Capture) || (e.Button != MouseButtons.Left)))
                    return;
             //   m_fillcirculo.Dx = 10;
              //  m_fillcirculo.Dy = 10;
                m_lstfillPalabra.Add(m_fillpalabra);
                //  Pantalla.Invalidate();

            }
            if (figura == 20)
            {
                if (((m_RojoCua == null) || (!Pantalla.Capture) || (e.Button != MouseButtons.Left)))
                    return;
                m_RojoCua.Dx = Convert.ToInt32(comboBox2.Text);
                m_RojoCua.Dy = Convert.ToInt32(comboBox2.Text);
                m_lstOfRojor.Add(m_RojoCua);
                //  Pantalla.Invalidate();

            }

            if (figura == 15)
            {
                if (((m_Arbol == null) || (!Pantalla.Capture) || (e.Button != MouseButtons.Left)))
                    return;
                m_Arbol.Dx = Convert.ToInt32(comboBox2.Text);
                m_Arbol.Dy = Convert.ToInt32(comboBox2.Text); 
                m_lstOfArbol.Add(m_Arbol);
                //  Pantalla.Invalidate();

            }
            if (figura == 12)
            {
                if (((m_Cancha == null) || (!Pantalla.Capture) || (e.Button != MouseButtons.Left)))
                    return;
                m_Cancha.Point2 = e.Location;
                m_lstOfCancha.Add(m_Cancha);
                //  Pantalla.Invalidate();

            }

            if (figura == 16)
            {
                if (((m_Estacionamiento == null) || (!Pantalla.Capture) || (e.Button != MouseButtons.Left)))
                    return;
                m_Estacionamiento.Point2 = e.Location;
                m_lstOfEstacionamiento.Add(m_Estacionamiento);
                //  Pantalla.Invalidate();

            }
            if (figura == 21)
            {
                if (((m_Gota == null) || (!Pantalla.Capture) || (e.Button != MouseButtons.Left)))
                    return;
                m_Gota.Dx = Convert.ToInt32(comboBox2.Text);
                m_Gota.Dy = Convert.ToInt32(comboBox2.Text);
                m_lstOfGota.Add(m_Gota);
                //  Pantalla.Invalidate();

            }
            if (figura == 22)
            {
                if (((m_Basura == null) || (!Pantalla.Capture) || (e.Button != MouseButtons.Left)))
                    return;
                m_Basura.Point2 = e.Location;
                m_lstOfBasura.Add(m_Basura);
                //  Pantalla.Invalidate();

            }
            if (figura == 14)
            {
                if (((m_Zanja == null) || (!Pantalla.Capture) || (e.Button != MouseButtons.Left)))
                    return;
                m_Zanja.Point2 = e.Location;
                m_lstOfZanja.Add(m_Zanja);
                //  Pantalla.Invalidate();

            }
            if (figura == 23)
            {
                if (((m_Pozo == null) || (!Pantalla.Capture) || (e.Button != MouseButtons.Left)))
                    return;
                m_Pozo.Point2 = e.Location;
                m_lstOfPozo.Add(m_Pozo);
                //  Pantalla.Invalidate();

            } if (figura == 24)
            {
                if (((m_Zona == null) || (!Pantalla.Capture) || (e.Button != MouseButtons.Left)))
                    return;
                m_Zona.Point2 = e.Location;
                m_lstOfZona.Add(m_Zona);
                //  Pantalla.Invalidate();

            }
            if (figura == 25)
            {
                if (((m_tria == null) || (!Pantalla.Capture) || (e.Button != MouseButtons.Left)))
                    return;
                m_tria.Dx = Convert.ToInt32(comboBox2.Text);
                m_tria.Dy = Convert.ToInt32(comboBox2.Text);
                m_lstOfTri.Add(m_tria);
                //  Pantalla.Invalidate();

            }

            if (figura == 25)
            {
                if (((m_anclado == null) || (!Pantalla.Capture) || (e.Button != MouseButtons.Left)))
                    return;
                m_anclado.Dx = Convert.ToInt32(comboBox2.Text);
                m_anclado.Dy = Convert.ToInt32(comboBox2.Text);
                m_lstOfAnclado.Add(m_anclado);
                //  Pantalla.Invalidate();

            }
            if (figura == 27)
            {
                if (((m_techado == null) || (!Pantalla.Capture) || (e.Button != MouseButtons.Left)))
                    return;
                m_techado.Point2 = e.Location;
                m_lstOfTechado.Add(m_techado);
                //  Pantalla.Invalidate();

            }
            if (figura == 28)
            {
                if (((m_tubo == null) || (!Pantalla.Capture) || (e.Button != MouseButtons.Left)))
                    return;
                m_tubo.Dx = Convert.ToInt32(comboBox2.Text);
                m_tubo.Dy = Convert.ToInt32(comboBox2.Text);
                m_lstOfTubo.Add(m_tubo);
                //  Pantalla.Invalidate();

            }
            clic = false;
        
        }
        void NegroClick(object sender, EventArgs e)
        {
            color = Color.Black;
            Default1.BackColor = color;
        }
        void DarkGrayClick(object sender, EventArgs e)
        {
            color = Color.DarkGray;
            Default1.BackColor = color;
        }
        void BrownClick(object sender, EventArgs e)
        {
            color = Color.Brown;
            Default1.BackColor = color;

        }
        void GrayClick(object sender, EventArgs e)
        {
            color = Color.Gray;
            Default1.BackColor = color;
        }
        void MaroonClick(object sender, EventArgs e)
        {
            color = Color.Maroon;
            Default1.BackColor = color;
        }
        void RedClick(object sender, EventArgs e)
        {
            color = Color.Red;
            Default1.BackColor = color;
        }
        void BlancoClick(object sender, EventArgs e)
        {
            color = Color.White;
            Default1.BackColor = color;
        }
        void PinkClick(object sender, EventArgs e)
        {
            color = Color.Pink;
            Default1.BackColor = color;
        }
        void YellowClick(object sender, EventArgs e)
        {
            color = Color.OrangeRed;
            Default1.BackColor = color;
        }
        void OrangeRedClick(object sender, EventArgs e)
        {
            color = Color.Yellow;
            Default1.BackColor = color;
        }
        void GoldClick(object sender, EventArgs e)
        {
            color = Color.Gold;
            Default1.BackColor = color;
        }
        void LightSalmonClick(object sender, EventArgs e)
        {
            color = Color.LightSalmon;
            Default1.BackColor = color;
        }
        void GreenClick(object sender, EventArgs e)
        {
            color = Color.Green;
            Default1.BackColor = color;
        }
        void YellowGreenClick(object sender, EventArgs e)
        {
            color = Color.YellowGreen;
            Default1.BackColor = color;
        }
        void SteelBlueClick(object sender, EventArgs e)
        {
            color = Color.SteelBlue;
            Default1.BackColor = color;
        }
        void AquaClick(object sender, EventArgs e)
        {
            color = Color.Aqua;
            Default1.BackColor = color;
        }
        void MediumSlateBlueClick(object sender, EventArgs e)
        {
            color = Color.MediumSlateBlue;
            Default1.BackColor = color;
        }
        void RoyalBlueClick(object sender, EventArgs e)
        {
            color = Color.RoyalBlue;
            Default1.BackColor = color;
        }
        void PurpleClick(object sender, EventArgs e)
        {
            color = Color.Purple;
            Default1.BackColor = color;
        }
        void BisqueClick(object sender, EventArgs e)
        {
            color = Color.Bisque;
            Default1.BackColor = color;
        }
      
      
      
        void MainFormLoad(object sender, EventArgs e)
        {
           
            m_line = new Line();
            m_cuadrado = new Cuadrado();
            m_circulo = new Circulo();
            m_rfill = new RectanguloFill();
            m_lapiz = new Lapiz();
            m_fillcirculo = new fillCirculo();
            m_fillpalabra = new Palabras();
            m_RojoCua = new RojoRectangulo();
            m_Arbol = new Arbol();
            m_Cancha = new Cancha();
            m_Estacionamiento = new Estacionamiento();
            m_Gota = new Gota();
            m_Basura = new Basura();
            m_Zanja = new Zanja();
            m_Pozo = new Pozo();
            m_Zona = new Zona();
            m_tria = new Triangulo1();
            m_techado = new Techado();
            g = Pantalla.CreateGraphics();
            clic = false;
            Pantalla.Image = new Bitmap(Pantalla.Width, Pantalla.Height);
            cargar = false;

        }
        void Default1Click(object sender, EventArgs e)
        {

        }
        void Button7Click(object sender, EventArgs e)
        {
            figura = 1;
        }
        void Button8Click(object sender, EventArgs e)
        {
            figura = 2;
            color = Color.White;
        }
        void Button1Click(object sender, EventArgs e)
        {
            figura = 3;
        }
        void Button3Click(object sender, EventArgs e)
        {
            figura = 4;
        }
        void Button2Click(object sender, EventArgs e)
        {
            figura = 5;
        }
      
        void PantallaMouseClick(object sender, MouseEventArgs e)
        {
            if (comboBox2.Text == "")
            {
                MessageBox.Show("Asignar Tamaño");

            }
            else
            {




                g = Pantalla.CreateGraphics();
                g = Graphics.FromImage(Pantalla.Image);
                if (k == 1)
                {
                    x = e.X;
                    y = e.Y;
                    dX = e.X - cX;
                    dY = e.Y - cY;
                    if (figura == 3)
                    {

                    }
                    if (figura == 4)
                    {

                    }
                    if (figura == 5)
                    {



                    }
                    if (figura == 12)
                    {

                        Image newImage = Image.FromFile("C:\\Users\\Urukazo\\Desktop\\respaldo bueno\\cancha-dimensiones-futbol.jpg");

                        // Create Point for upper-left corner of image.
                        Point ulCorner = new Point(cX, cY);

                        // Draw image to screen.
                        //    g.DrawImage(newImage, ulCorner);
                        g.DrawImage(newImage, cX, cY, dX, dY);
                    }
                    if (figura == 13)
                    {
                        if (clic)
                        {
                            if (((m_rfill == null) || (e.Button != MouseButtons.Left)))
                                return;
                            m_rfill.Dx = Convert.ToInt32(comboBox2.Text);
                            m_rfill.Dy = Convert.ToInt32(comboBox2.Text);
                            m_rfill.Draw(g);
                            m_cuadrado.Draw(g);
                            m_circulo.Draw(g);
                            m_fillcirculo.Draw(g);
                            Pantalla.Invalidate();
                            Pantalla.Image.Save("PictureBox.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                        }
                    }
                    if (figura == 14)
                    {
                        //falta achicar agrandar
                        Image newImage = Image.FromFile("C:\\Users\\Urukazo\\Desktop\\respaldo bueno\\Zanga.jpg");

                        // Create Point for upper-left corner of image.
                        Point ulCorner = new Point(cX, cY);

                        // Draw image to screen.
                        // g.DrawImage(newImage, ulCorner);
                        g.DrawImage(newImage, cX, cY, dX, dY);
                    }
                    if (figura == 15)
                    {
                        /*
                         //falta achicar agrandar
                         Image newImage = Image.FromFile("C:\\Users\\Urukazo\\Desktop\\respaldo bueno\\Arbolpequeño.jpg");

                         // Create Point for upper-left corner of image.
                         Point ulCorner = new Point(cX, cY);

                         // Draw image to screen.
                          g.DrawImage(newImage, ulCorner);
                         //g.DrawImage(newImage, cX, cY, dX, dY);
                         */

                        if (clic)
                        {
                            if (((m_Arbol == null) || (e.Button != MouseButtons.Left)))
                                return;
                            m_Arbol.Dx = Convert.ToInt32(comboBox2.Text);
                            m_Arbol.Dy = Convert.ToInt32(comboBox2.Text);
                            m_RojoCua.Draw(g);
                            m_cuadrado.Draw(g);
                            m_circulo.Draw(g);
                            m_fillcirculo.Draw(g);
                            m_rfill.Draw(g);
                            m_Arbol.Draw(g);
                            Pantalla.Invalidate();
                            Pantalla.Image.Save("PictureBox.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                        }
                    }
                    if (figura == 16)
                    {
                        /*
                        ///falta achicar agrandar
                        Image newImage = Image.FromFile("C:\\Users\\Urukazo\\Desktop\\respaldo bueno\\estacionamiento.jpg");

                        // Create Point for upper-left corner of image.
                        Point ulCorner = new Point(cX, cY);

                        // Draw image to screen.
                       // g.DrawImage(newImage, ulCorner);
                        g.DrawImage(newImage, cX, cY, dX, dY);
                         */
                    }
                    if (figura == 17)
                    {
                        if (clic)
                        {
                            if (((m_fillpalabra == null) || (e.Button != MouseButtons.Left)))
                                return;
                            m_rfill.Dx = Convert.ToInt32(comboBox2.Text);
                            m_rfill.Dy = Convert.ToInt32(comboBox2.Text);
                            m_rfill.Draw(g);
                            m_cuadrado.Draw(g);
                            m_circulo.Draw(g);
                            m_fillcirculo.Draw(g);

                     //       m_fillpalabra.Draw(g, textBox1.Text, Convert.ToInt32(comboBox1.Text));
                            Pantalla.Invalidate();
                            Pantalla.Image.Save("PictureBox.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                        }
                    }
                    if (figura == 19)
                    {
                        if (clic)
                        {
                            if (((m_fillcirculo == null) || (e.Button != MouseButtons.Left)))
                                return;
                            m_fillcirculo.Dx = Convert.ToInt32(comboBox2.Text);
                            m_fillcirculo.Dy = Convert.ToInt32(comboBox2.Text);
                            m_rfill.Draw(g);
                            m_cuadrado.Draw(g);
                            m_circulo.Draw(g);
                            m_fillcirculo.Draw(g);
                            Pantalla.Invalidate();
                            Pantalla.Image.Save("PictureBox.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                        }

                    }
                    if (figura == 20)
                    {
                        if (clic)
                        {
                            if (((m_RojoCua == null) || (e.Button != MouseButtons.Left)))
                                return;
                            m_RojoCua.Dx = Convert.ToInt32(comboBox2.Text);
                            m_RojoCua.Dy = Convert.ToInt32(comboBox2.Text);
                            m_RojoCua.Draw(g);
                            m_cuadrado.Draw(g);
                            m_circulo.Draw(g);
                            m_fillcirculo.Draw(g);
                            m_rfill.Draw(g);
                            Pantalla.Invalidate();
                            Pantalla.Image.Save("PictureBox.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                        }
                    }
                    if (figura == 21)
                    {
                        if (clic)
                        {
                            if (((m_Gota == null) || (e.Button != MouseButtons.Left)))
                                return;
                            m_Gota.Dx = Convert.ToInt32(comboBox2.Text);
                            m_Gota.Dy = Convert.ToInt32(comboBox2.Text);
                            m_RojoCua.Draw(g);
                            m_cuadrado.Draw(g);
                            m_circulo.Draw(g);
                            m_fillcirculo.Draw(g);
                            m_rfill.Draw(g);
                            m_Gota.Draw(g);
                            Pantalla.Invalidate();
                            Pantalla.Image.Save("PictureBox.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                        }
                    }
                    if (figura == 25)
                    {
                        if (clic)
                        {
                            if (((m_tria == null) || (e.Button != MouseButtons.Left)))
                                return;
                            m_tria.Dx = Convert.ToInt32(comboBox2.Text);
                            m_tria.Dy = Convert.ToInt32(comboBox2.Text);
                            m_tria.Draw(g);

                            Pantalla.Invalidate();
                            Pantalla.Image.Save("PictureBox.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                        }
                    }
                    if (figura == 26)
                    {
                        if (clic)
                        {
                            if (((m_anclado == null) || (e.Button != MouseButtons.Left)))
                                return;
                            m_anclado.Dx = Convert.ToInt32(comboBox2.Text);
                            m_anclado.Dy = Convert.ToInt32(comboBox2.Text);

                            m_anclado.Draw(g);
                            Pantalla.Invalidate();
                            Pantalla.Image.Save("PictureBox.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                        }
                    }
                    if (figura == 28)
                    {
                        if (clic)
                        {
                            if (((m_tubo == null) || (e.Button != MouseButtons.Left)))
                                return;
                            m_tubo.Dx = Convert.ToInt32(comboBox2.Text); ;
                            m_tubo.Dy = Convert.ToInt32(comboBox2.Text); ;

                            m_tubo.Draw(g);
                            Pantalla.Invalidate();
                            Pantalla.Image.Save("PictureBox.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                        }
                    }
                }
            }
        }
        void Button4Click(object sender, EventArgs e)
        {
            figura = 6;
        }
        void Label1Click(object sender, EventArgs e)
        {

        }
        void Button5Click(object sender, EventArgs e)
        {
            Pantalla.Refresh();
           // Pantalla.Image = null;
            m_lstOfLine.Clear();
            m_lstOfcua.Clear();
            m_lstOfcir.Clear();
            m_lstOfrfill.Clear();
            m_lstOflapiz.Clear();
            m_lstfillCirculo.Clear();
            m_lstOfRojor.Clear();
            m_lstOfArbol.Clear();
            m_lstOfCancha.Clear();
            m_lstOfEstacionamiento.Clear();
            m_lstOfGota.Clear();
            m_lstOfBasura.Clear();
            m_lstOfZanja.Clear();
            m_lstOfPozo.Clear();
            m_lstOfZona.Clear();
            m_lstOfTri.Clear();
            m_lstOfAnclado.Clear();
            m_lstOfTechado.Clear();
            m_lstOfTubo.Clear();
        }
        void SaveFileDialog1FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
        void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void GuardarClick(object sender, EventArgs e)
        {
            //dibujo uin rectangulo con un bitmap y un graphchs diferente
            //y rotate con g.rotate
            Bitmap bmp = new Bitmap(Pantalla.Width, Pantalla.Height);
            Graphics g = Graphics.FromImage(bmp);
            Rectangle rect = Pantalla.RectangleToScreen(Pantalla.ClientRectangle);
            g.CopyFromScreen(rect.Location, Point.Empty, Pantalla.Size);
            g.Dispose();
            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "Png files|*.png|jpeg files|*jpg|bitmaps|*.bmp";
            if (s.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {           
                if (File.Exists(s.FileName))
                {
                    File.Delete(s.FileName);
                }
                if (s.FileName.Contains(".jpg"))
                {
                    bmp.Save(s.FileName, ImageFormat.Jpeg);
                }
                else if (s.FileName.Contains(".png"))
                {
                    bmp.Save(s.FileName, ImageFormat.Png);
                }
                else if (s.FileName.Contains(".bmp"))
                {
                    bmp.Save(s.FileName, ImageFormat.Bmp);
                }
            }
        }
        void NuevoClick(object sender, EventArgs e)
        {
            Pantalla.Refresh();
            Pantalla.Image = null;

        }
        void AbrirClick(object sender, EventArgs e)
        {
           
            o.Filter = "Png files|*.png|jpeg files|*jpg|bitmaps|*.bmp";
            if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Pantalla.Image = (Image)Image.FromFile(o.FileName);
                cargar = true;
                Pantalla.Invalidate();
              //  g.Dispose();
               
            }
        }
        void Button9Click(object sender, EventArgs e)
        {
            figura = 8;
        }
        void Button10Click(object sender, EventArgs e)
        {
            figura = 9;
        }
        void Button11Click(object sender, EventArgs e)
        {
            figura = 10;
        }
        void Button6Click(object sender, EventArgs e)
        {
            figura = 7;
        }

        private void Pantalla_Click(object sender, EventArgs e)
        {

        }

        private void Colores_Enter(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            figura = 11;
          
        }

        private void button13_Click(object sender, EventArgs e)
        {
            figura = 12;
        }

        private void Figuras_Enter(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            figura = 13;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            figura = 14;
        }
     

      
        private void Pantalla_Paint(object sender, PaintEventArgs e)
        {
            if (cargar == true) { 
            Pantalla.Image = (Image)Image.FromFile(o.FileName);
            //g.Dispose();
        }
            m_lstfillPalabra= new List<Palabras>();
            g = e.Graphics;
            if (figura == 3)
            {
                m_lstOfLine.ForEach((Line item) => { item.Draw(e.Graphics); });
                
          
            if ((((m_line) != null)))
            {
               
                m_line.Draw(e.Graphics);
              
              
             

            }
        }
            if (figura == 5)
            {

                m_lstOfLine.ForEach((Line item) => { item.Draw(e.Graphics); });
                m_lstOfcua.ForEach((Cuadrado item) => { item.Draw(e.Graphics); });
                m_lstOfcir.ForEach((Circulo item) => { item.Draw(e.Graphics); });
                m_lstOfrfill.ForEach((RectanguloFill item) => { item.Draw(e.Graphics); });
                m_lstOflapiz.ForEach((Lapiz item) => { item.Draw(e.Graphics); });
                m_lstfillCirculo.ForEach((fillCirculo item) => { item.Draw(e.Graphics); });
                m_lstOfRojor.ForEach((RojoRectangulo item) => { item.Draw(e.Graphics); });
                m_lstOfArbol.ForEach((Arbol item) => { item.Draw(e.Graphics); });
                m_lstOfCancha.ForEach((Cancha item) => { item.Draw(e.Graphics); });
                m_lstOfEstacionamiento.ForEach((Estacionamiento item) => { item.Draw(e.Graphics); });
                m_lstOfGota.ForEach((Gota item) => { item.Draw(e.Graphics); });
                m_lstOfBasura.ForEach((Basura item) => { item.Draw(e.Graphics); });
                m_lstOfZanja.ForEach((Zanja item) => { item.Draw(e.Graphics); });
                m_lstOfPozo.ForEach((Pozo item) => { item.Draw(e.Graphics); });
                m_lstOfZona.ForEach((Zona item) => { item.Draw(e.Graphics); });
                 m_lstOfTri.ForEach((Triangulo1 item) => { item.Draw(e.Graphics); });
                 m_lstOfAnclado.ForEach((Anclado item) => { item.Draw(e.Graphics); });
                 m_lstOfTechado.ForEach((Techado item) => { item.Draw(e.Graphics); });
                 m_lstOfTubo.ForEach((Tubo item) => { item.Draw(e.Graphics); });
              
                if ((((m_cuadrado) != null)))
                {
                  
                    m_cuadrado.Draw(e.Graphics);
                   
                }
            }
            if (figura == 4)
            {
                m_lstOfLine.ForEach((Line item) => { item.Draw(e.Graphics); });
                m_lstOfcua.ForEach((Cuadrado item) => { item.Draw(e.Graphics); });
                m_lstOfcir.ForEach((Circulo item) => { item.Draw(e.Graphics); });
                m_lstOfrfill.ForEach((RectanguloFill item) => { item.Draw(e.Graphics); });
                m_lstOflapiz.ForEach((Lapiz item) => { item.Draw(e.Graphics); });
                m_lstfillCirculo.ForEach((fillCirculo item) => { item.Draw(e.Graphics); });
                m_lstOfRojor.ForEach((RojoRectangulo item) => { item.Draw(e.Graphics); });
                m_lstOfArbol.ForEach((Arbol item) => { item.Draw(e.Graphics); });
                m_lstOfCancha.ForEach((Cancha item) => { item.Draw(e.Graphics); });
                m_lstOfEstacionamiento.ForEach((Estacionamiento item) => { item.Draw(e.Graphics); });
                m_lstOfGota.ForEach((Gota item) => { item.Draw(e.Graphics); });
                m_lstOfBasura.ForEach((Basura item) => { item.Draw(e.Graphics); });
                m_lstOfZanja.ForEach((Zanja item) => { item.Draw(e.Graphics); });
                m_lstOfPozo.ForEach((Pozo item) => { item.Draw(e.Graphics); });
                m_lstOfZona.ForEach((Zona item) => { item.Draw(e.Graphics); });
                 m_lstOfTri.ForEach((Triangulo1 item) => { item.Draw(e.Graphics); });
                 m_lstOfAnclado.ForEach((Anclado item) => { item.Draw(e.Graphics); });
                 m_lstOfTechado.ForEach((Techado item) => { item.Draw(e.Graphics); });
                 m_lstOfTubo.ForEach((Tubo item) => { item.Draw(e.Graphics); });
                if ((((m_circulo) != null)))
                {
                  
                    m_circulo.Draw(e.Graphics);
                  
                }
            }
            if (figura == 13)
            {
                m_lstOfLine.ForEach((Line item) => { item.Draw(e.Graphics); });
                m_lstOfcua.ForEach((Cuadrado item) => { item.Draw(e.Graphics); });
                m_lstOfcir.ForEach((Circulo item) => { item.Draw(e.Graphics); });
                m_lstOfrfill.ForEach((RectanguloFill item) => { item.Draw(e.Graphics); });
                m_lstOflapiz.ForEach((Lapiz item) => { item.Draw(e.Graphics); });
                m_lstfillCirculo.ForEach((fillCirculo item) => { item.Draw(e.Graphics); });
                m_lstOfRojor.ForEach((RojoRectangulo item) => { item.Draw(e.Graphics); });
                m_lstOfArbol.ForEach((Arbol item) => { item.Draw(e.Graphics); });
                m_lstOfCancha.ForEach((Cancha item) => { item.Draw(e.Graphics); });
                m_lstOfEstacionamiento.ForEach((Estacionamiento item) => { item.Draw(e.Graphics); });
                m_lstOfGota.ForEach((Gota item) => { item.Draw(e.Graphics); });
                m_lstOfBasura.ForEach((Basura item) => { item.Draw(e.Graphics); });
                m_lstOfZanja.ForEach((Zanja item) => { item.Draw(e.Graphics); });
                m_lstOfPozo.ForEach((Pozo item) => { item.Draw(e.Graphics); });
                m_lstOfZona.ForEach((Zona item) => { item.Draw(e.Graphics); });
                 m_lstOfTri.ForEach((Triangulo1 item) => { item.Draw(e.Graphics); });
                 m_lstOfAnclado.ForEach((Anclado item) => { item.Draw(e.Graphics); });
                 m_lstOfTechado.ForEach((Techado item) => { item.Draw(e.Graphics); });
                 m_lstOfTubo.ForEach((Tubo item) => { item.Draw(e.Graphics); });
                if ((((m_rfill) != null)))
                {
                 
                    m_rfill.Draw(e.Graphics);
                    
                }
            }
            if (figura == 1)
            {
                m_lstOfLine.ForEach((Line item) => { item.Draw(e.Graphics); });
                m_lstOfcua.ForEach((Cuadrado item) => { item.Draw(e.Graphics); });
                m_lstOfcir.ForEach((Circulo item) => { item.Draw(e.Graphics); });
                m_lstOfrfill.ForEach((RectanguloFill item) => { item.Draw(e.Graphics); });
                m_lstOflapiz.ForEach((Lapiz item) => { item.Draw(e.Graphics); });
                m_lstfillCirculo.ForEach((fillCirculo item) => { item.Draw(e.Graphics); });
                m_lstOfRojor.ForEach((RojoRectangulo item) => { item.Draw(e.Graphics); });
                m_lstOfArbol.ForEach((Arbol item) => { item.Draw(e.Graphics); });
                m_lstOfCancha.ForEach((Cancha item) => { item.Draw(e.Graphics); });
                m_lstOfEstacionamiento.ForEach((Estacionamiento item) => { item.Draw(e.Graphics); });
                m_lstOfGota.ForEach((Gota item) => { item.Draw(e.Graphics); });
                m_lstOfBasura.ForEach((Basura item) => { item.Draw(e.Graphics); });
                m_lstOfZanja.ForEach((Zanja item) => { item.Draw(e.Graphics); });
                m_lstOfPozo.ForEach((Pozo item) => { item.Draw(e.Graphics); });
                m_lstOfZona.ForEach((Zona item) => { item.Draw(e.Graphics); });
                 m_lstOfTri.ForEach((Triangulo1 item) => { item.Draw(e.Graphics); });
                 m_lstOfAnclado.ForEach((Anclado item) => { item.Draw(e.Graphics); });
                 m_lstOfTechado.ForEach((Techado item) => { item.Draw(e.Graphics); });
                 m_lstOfTubo.ForEach((Tubo item) => { item.Draw(e.Graphics); });
                if ((((m_lapiz) != null)))
                {
                   
                  
                  
                    m_lapiz.Draw(e.Graphics);
                

                   
                }
               
            }
            if (figura == 19)
            {
                m_lstOfLine.ForEach((Line item) => { item.Draw(e.Graphics); });
                m_lstOfcua.ForEach((Cuadrado item) => { item.Draw(e.Graphics); });
                m_lstOfcir.ForEach((Circulo item) => { item.Draw(e.Graphics); });
                m_lstOfrfill.ForEach((RectanguloFill item) => { item.Draw(e.Graphics); });
                m_lstOflapiz.ForEach((Lapiz item) => { item.Draw(e.Graphics); });
                m_lstfillCirculo.ForEach((fillCirculo item) => { item.Draw(e.Graphics); });
                m_lstOfRojor.ForEach((RojoRectangulo item) => { item.Draw(e.Graphics); });
                m_lstOfArbol.ForEach((Arbol item) => { item.Draw(e.Graphics); });
                m_lstOfCancha.ForEach((Cancha item) => { item.Draw(e.Graphics); });
                m_lstOfEstacionamiento.ForEach((Estacionamiento item) => { item.Draw(e.Graphics); });
                m_lstOfGota.ForEach((Gota item) => { item.Draw(e.Graphics); });
                m_lstOfBasura.ForEach((Basura item) => { item.Draw(e.Graphics); });
                m_lstOfZanja.ForEach((Zanja item) => { item.Draw(e.Graphics); });
                m_lstOfPozo.ForEach((Pozo item) => { item.Draw(e.Graphics); });
                m_lstOfZona.ForEach((Zona item) => { item.Draw(e.Graphics); });
                 m_lstOfTri.ForEach((Triangulo1 item) => { item.Draw(e.Graphics); });
                 m_lstOfAnclado.ForEach((Anclado item) => { item.Draw(e.Graphics); });
                 m_lstOfTechado.ForEach((Techado item) => { item.Draw(e.Graphics); });
                 m_lstOfTubo.ForEach((Tubo item) => { item.Draw(e.Graphics); });
                if ((((m_fillcirculo) != null)))
                {

                
                    m_fillcirculo.Draw(e.Graphics);

                }

            }
            if (figura == 17)
            {
                m_lstOfLine.ForEach((Line item) => { item.Draw(e.Graphics); });
                m_lstOfcua.ForEach((Cuadrado item) => { item.Draw(e.Graphics); });
                m_lstOfcir.ForEach((Circulo item) => { item.Draw(e.Graphics); });
                m_lstOfrfill.ForEach((RectanguloFill item) => { item.Draw(e.Graphics); });
                m_lstOflapiz.ForEach((Lapiz item) => { item.Draw(e.Graphics); });
                m_lstfillCirculo.ForEach((fillCirculo item) => { item.Draw(e.Graphics); });
                m_lstOfRojor.ForEach((RojoRectangulo item) => { item.Draw(e.Graphics); });
                m_lstOfArbol.ForEach((Arbol item) => { item.Draw(e.Graphics); });
                m_lstOfCancha.ForEach((Cancha item) => { item.Draw(e.Graphics); });
                m_lstOfEstacionamiento.ForEach((Estacionamiento item) => { item.Draw(e.Graphics); });
                m_lstOfGota.ForEach((Gota item) => { item.Draw(e.Graphics); });
                m_lstOfBasura.ForEach((Basura item) => { item.Draw(e.Graphics); });
           //     m_lstfillPalabra.ForEach((Palabras item) => { item.Draw(e.Graphics,textBox1.Text, Convert.ToInt32(comboBox1.Text)); });
                m_lstOfZanja.ForEach((Zanja item) => { item.Draw(e.Graphics); });
                m_lstOfPozo.ForEach((Pozo item) => { item.Draw(e.Graphics); });
                m_lstOfZona.ForEach((Zona item) => { item.Draw(e.Graphics); });
                 m_lstOfTri.ForEach((Triangulo1 item) => { item.Draw(e.Graphics); });
                 m_lstOfAnclado.ForEach((Anclado item) => { item.Draw(e.Graphics); });
                 m_lstOfTechado.ForEach((Techado item) => { item.Draw(e.Graphics); });
                 m_lstOfTubo.ForEach((Tubo item) => { item.Draw(e.Graphics); });
                if ((((m_fillpalabra) != null)))
                {

                   
                 //   m_fillpalabra.Draw(e.Graphics,textBox1.Text,Convert.ToInt32(comboBox1.Text));
                }

            }
            if (figura == 20)
            {
                m_lstOfLine.ForEach((Line item) => { item.Draw(e.Graphics); });
                m_lstOfcua.ForEach((Cuadrado item) => { item.Draw(e.Graphics); });
                m_lstOfcir.ForEach((Circulo item) => { item.Draw(e.Graphics); });
                m_lstOfrfill.ForEach((RectanguloFill item) => { item.Draw(e.Graphics); });
                m_lstOflapiz.ForEach((Lapiz item) => { item.Draw(e.Graphics); });
                m_lstfillCirculo.ForEach((fillCirculo item) => { item.Draw(e.Graphics); });
                m_lstOfRojor.ForEach((RojoRectangulo item) => { item.Draw(e.Graphics); });
                m_lstOfArbol.ForEach((Arbol item) => { item.Draw(e.Graphics); });
                m_lstOfCancha.ForEach((Cancha item) => { item.Draw(e.Graphics); });
                m_lstOfEstacionamiento.ForEach((Estacionamiento item) => { item.Draw(e.Graphics); });
                m_lstOfGota.ForEach((Gota item) => { item.Draw(e.Graphics); });
                m_lstOfBasura.ForEach((Basura item) => { item.Draw(e.Graphics); });
                m_lstOfZanja.ForEach((Zanja item) => { item.Draw(e.Graphics); });
                m_lstOfPozo.ForEach((Pozo item) => { item.Draw(e.Graphics); });
                m_lstOfZona.ForEach((Zona item) => { item.Draw(e.Graphics); });
                 m_lstOfTri.ForEach((Triangulo1 item) => { item.Draw(e.Graphics); });
                 m_lstOfAnclado.ForEach((Anclado item) => { item.Draw(e.Graphics); });
                 m_lstOfTechado.ForEach((Techado item) => { item.Draw(e.Graphics); });
                 m_lstOfTubo.ForEach((Tubo item) => { item.Draw(e.Graphics); });

                if ((((m_RojoCua) != null)))
                {
                  
                    m_RojoCua.Draw(e.Graphics);
                }
            }
            if (figura == 15)
            {
                m_lstOfLine.ForEach((Line item) => { item.Draw(e.Graphics); });
                m_lstOfcua.ForEach((Cuadrado item) => { item.Draw(e.Graphics); });
                m_lstOfcir.ForEach((Circulo item) => { item.Draw(e.Graphics); });
                m_lstOfrfill.ForEach((RectanguloFill item) => { item.Draw(e.Graphics); });
                m_lstOflapiz.ForEach((Lapiz item) => { item.Draw(e.Graphics); });
                m_lstfillCirculo.ForEach((fillCirculo item) => { item.Draw(e.Graphics); });
                m_lstOfRojor.ForEach((RojoRectangulo item) => { item.Draw(e.Graphics); });
                m_lstOfArbol.ForEach((Arbol item) => { item.Draw(e.Graphics); });
                m_lstOfCancha.ForEach((Cancha item) => { item.Draw(e.Graphics); });
                m_lstOfEstacionamiento.ForEach((Estacionamiento item) => { item.Draw(e.Graphics); });
                m_lstOfGota.ForEach((Gota item) => { item.Draw(e.Graphics); });
                m_lstOfBasura.ForEach((Basura item) => { item.Draw(e.Graphics); });
                m_lstOfZanja.ForEach((Zanja item) => { item.Draw(e.Graphics); });
                m_lstOfPozo.ForEach((Pozo item) => { item.Draw(e.Graphics); });
                m_lstOfZona.ForEach((Zona item) => { item.Draw(e.Graphics); });
                 m_lstOfTri.ForEach((Triangulo1 item) => { item.Draw(e.Graphics); });
                 m_lstOfAnclado.ForEach((Anclado item) => { item.Draw(e.Graphics); });
                 m_lstOfTechado.ForEach((Techado item) => { item.Draw(e.Graphics); });
                 m_lstOfTubo.ForEach((Tubo item) => { item.Draw(e.Graphics); });
                if ((((m_Arbol) != null)))
                {
                  
                    m_Arbol.Draw(e.Graphics);
                }
            }
            if (figura == 12)
            {             
                m_lstOfCancha.ForEach((Cancha item) => { item.Draw(e.Graphics); });
             
                if ((((m_Cancha) != null)))
                {

                   
                    m_Cancha.Draw(e.Graphics);

                }
            }

            if (figura == 16)
            {
                m_lstOfLine.ForEach((Line item) => { item.Draw(e.Graphics); });
                m_lstOfcua.ForEach((Cuadrado item) => { item.Draw(e.Graphics); });
                m_lstOfcir.ForEach((Circulo item) => { item.Draw(e.Graphics); });
                m_lstOfrfill.ForEach((RectanguloFill item) => { item.Draw(e.Graphics); });
                m_lstOflapiz.ForEach((Lapiz item) => { item.Draw(e.Graphics); });
                m_lstfillCirculo.ForEach((fillCirculo item) => { item.Draw(e.Graphics); });
                m_lstOfRojor.ForEach((RojoRectangulo item) => { item.Draw(e.Graphics); });
                m_lstOfArbol.ForEach((Arbol item) => { item.Draw(e.Graphics); });
                m_lstOfCancha.ForEach((Cancha item) => { item.Draw(e.Graphics); });
                m_lstOfEstacionamiento.ForEach((Estacionamiento item) => { item.Draw(e.Graphics); });
                m_lstOfGota.ForEach((Gota item) => { item.Draw(e.Graphics); });
                m_lstOfBasura.ForEach((Basura item) => { item.Draw(e.Graphics); });
                m_lstOfZanja.ForEach((Zanja item) => { item.Draw(e.Graphics); });
                m_lstOfPozo.ForEach((Pozo item) => { item.Draw(e.Graphics); });
                m_lstOfZona.ForEach((Zona item) => { item.Draw(e.Graphics); });
                 m_lstOfTri.ForEach((Triangulo1 item) => { item.Draw(e.Graphics); });
                 m_lstOfAnclado.ForEach((Anclado item) => { item.Draw(e.Graphics); });
                 m_lstOfTechado.ForEach((Techado item) => { item.Draw(e.Graphics); });
                 m_lstOfTubo.ForEach((Tubo item) => { item.Draw(e.Graphics); });
                if ((((m_lstOfEstacionamiento) != null)))
                {

               
                    m_Estacionamiento.Draw(g);

                }
            }

            if (figura == 21)
            {
                m_lstOfLine.ForEach((Line item) => { item.Draw(e.Graphics); });
                m_lstOfcua.ForEach((Cuadrado item) => { item.Draw(e.Graphics); });
                m_lstOfcir.ForEach((Circulo item) => { item.Draw(e.Graphics); });
                m_lstOfrfill.ForEach((RectanguloFill item) => { item.Draw(e.Graphics); });
                m_lstOflapiz.ForEach((Lapiz item) => { item.Draw(e.Graphics); });
                m_lstfillCirculo.ForEach((fillCirculo item) => { item.Draw(e.Graphics); });
                m_lstOfRojor.ForEach((RojoRectangulo item) => { item.Draw(e.Graphics); });
                m_lstOfArbol.ForEach((Arbol item) => { item.Draw(e.Graphics); });
                m_lstOfCancha.ForEach((Cancha item) => { item.Draw(e.Graphics); });
                m_lstOfEstacionamiento.ForEach((Estacionamiento item) => { item.Draw(e.Graphics); });
                m_lstOfGota.ForEach((Gota item) => { item.Draw(e.Graphics); });
                m_lstOfBasura.ForEach((Basura item) => { item.Draw(e.Graphics); });
                m_lstOfZanja.ForEach((Zanja item) => { item.Draw(e.Graphics); });
                m_lstOfPozo.ForEach((Pozo item) => { item.Draw(e.Graphics); });
                m_lstOfZona.ForEach((Zona item) => { item.Draw(e.Graphics); });
                 m_lstOfTri.ForEach((Triangulo1 item) => { item.Draw(e.Graphics); });
                 m_lstOfAnclado.ForEach((Anclado item) => { item.Draw(e.Graphics); });
                 m_lstOfTechado.ForEach((Techado item) => { item.Draw(e.Graphics); });
                 m_lstOfTubo.ForEach((Tubo item) => { item.Draw(e.Graphics); });
                if ((((m_lstOfGota) != null)))
                {

                
                    m_Gota.Draw(g);

                }
            }
            if (figura == 22)
            {
                m_lstOfLine.ForEach((Line item) => { item.Draw(e.Graphics); });
                m_lstOfcua.ForEach((Cuadrado item) => { item.Draw(e.Graphics); });
                m_lstOfcir.ForEach((Circulo item) => { item.Draw(e.Graphics); });
                m_lstOfrfill.ForEach((RectanguloFill item) => { item.Draw(e.Graphics); });
                m_lstOflapiz.ForEach((Lapiz item) => { item.Draw(e.Graphics); });
                m_lstfillCirculo.ForEach((fillCirculo item) => { item.Draw(e.Graphics); });
                m_lstOfRojor.ForEach((RojoRectangulo item) => { item.Draw(e.Graphics); });
                m_lstOfArbol.ForEach((Arbol item) => { item.Draw(e.Graphics); });
                m_lstOfCancha.ForEach((Cancha item) => { item.Draw(e.Graphics); });
                m_lstOfEstacionamiento.ForEach((Estacionamiento item) => { item.Draw(e.Graphics); });
                m_lstOfGota.ForEach((Gota item) => { item.Draw(e.Graphics); });
                m_lstOfBasura.ForEach((Basura item) => { item.Draw(e.Graphics); });
                m_lstOfZanja.ForEach((Zanja item) => { item.Draw(e.Graphics); });
                m_lstOfPozo.ForEach((Pozo item) => { item.Draw(e.Graphics); });
                m_lstOfZona.ForEach((Zona item) => { item.Draw(e.Graphics); });
                 m_lstOfTri.ForEach((Triangulo1 item) => { item.Draw(e.Graphics); });
                 m_lstOfAnclado.ForEach((Anclado item) => { item.Draw(e.Graphics); });
                 m_lstOfTechado.ForEach((Techado item) => { item.Draw(e.Graphics); });
                 m_lstOfTubo.ForEach((Tubo item) => { item.Draw(e.Graphics); });
                if ((((m_lstOfBasura) != null)))
                {
                    m_Basura.Draw(g);
                }
            }
            if (figura == 14)
            {
                m_lstOfLine.ForEach((Line item) => { item.Draw(e.Graphics); });
                m_lstOfcua.ForEach((Cuadrado item) => { item.Draw(e.Graphics); });
                m_lstOfcir.ForEach((Circulo item) => { item.Draw(e.Graphics); });
                m_lstOfrfill.ForEach((RectanguloFill item) => { item.Draw(e.Graphics); });
                m_lstOflapiz.ForEach((Lapiz item) => { item.Draw(e.Graphics); });
                m_lstfillCirculo.ForEach((fillCirculo item) => { item.Draw(e.Graphics); });
                m_lstOfRojor.ForEach((RojoRectangulo item) => { item.Draw(e.Graphics); });
                m_lstOfArbol.ForEach((Arbol item) => { item.Draw(e.Graphics); });
                m_lstOfCancha.ForEach((Cancha item) => { item.Draw(e.Graphics); });
                m_lstOfEstacionamiento.ForEach((Estacionamiento item) => { item.Draw(e.Graphics); });
                m_lstOfGota.ForEach((Gota item) => { item.Draw(e.Graphics); });
                m_lstOfBasura.ForEach((Basura item) => { item.Draw(e.Graphics); });
                m_lstOfZanja.ForEach((Zanja item) => { item.Draw(e.Graphics); });
                m_lstOfPozo.ForEach((Pozo item) => { item.Draw(e.Graphics); });
                m_lstOfZona.ForEach((Zona item) => { item.Draw(e.Graphics); });
                 m_lstOfTri.ForEach((Triangulo1 item) => { item.Draw(e.Graphics); });
                 m_lstOfAnclado.ForEach((Anclado item) => { item.Draw(e.Graphics); });
                 m_lstOfTechado.ForEach((Techado item) => { item.Draw(e.Graphics); });
                 m_lstOfTubo.ForEach((Tubo item) => { item.Draw(e.Graphics); });
                if ((((m_lstOfZanja) != null)))
                {
                    m_Zanja.Draw(g);
                }
            }
            if (figura == 23)
            {
                m_lstOfLine.ForEach((Line item) => { item.Draw(e.Graphics); });
                m_lstOfcua.ForEach((Cuadrado item) => { item.Draw(e.Graphics); });
                m_lstOfcir.ForEach((Circulo item) => { item.Draw(e.Graphics); });
                m_lstOfrfill.ForEach((RectanguloFill item) => { item.Draw(e.Graphics); });
                m_lstOflapiz.ForEach((Lapiz item) => { item.Draw(e.Graphics); });
                m_lstfillCirculo.ForEach((fillCirculo item) => { item.Draw(e.Graphics); });
                m_lstOfRojor.ForEach((RojoRectangulo item) => { item.Draw(e.Graphics); });
                m_lstOfArbol.ForEach((Arbol item) => { item.Draw(e.Graphics); });
                m_lstOfCancha.ForEach((Cancha item) => { item.Draw(e.Graphics); });
                m_lstOfEstacionamiento.ForEach((Estacionamiento item) => { item.Draw(e.Graphics); });
                m_lstOfGota.ForEach((Gota item) => { item.Draw(e.Graphics); });
                m_lstOfBasura.ForEach((Basura item) => { item.Draw(e.Graphics); });
                m_lstOfZanja.ForEach((Zanja item) => { item.Draw(e.Graphics); });
                m_lstOfPozo.ForEach((Pozo item) => { item.Draw(e.Graphics); });
                m_lstOfZona.ForEach((Zona item) => { item.Draw(e.Graphics); });
                 m_lstOfTri.ForEach((Triangulo1 item) => { item.Draw(e.Graphics); });
                 m_lstOfAnclado.ForEach((Anclado item) => { item.Draw(e.Graphics); });
                 m_lstOfTechado.ForEach((Techado item) => { item.Draw(e.Graphics); });
                 m_lstOfTubo.ForEach((Tubo item) => { item.Draw(e.Graphics); });
                if ((((m_lstOfPozo) != null)))
                {
                    m_Pozo.Draw(g);
                }
            }
            if (figura == 24)
            {
                m_lstOfLine.ForEach((Line item) => { item.Draw(e.Graphics); });
                m_lstOfcua.ForEach((Cuadrado item) => { item.Draw(e.Graphics); });
                m_lstOfcir.ForEach((Circulo item) => { item.Draw(e.Graphics); });
                m_lstOfrfill.ForEach((RectanguloFill item) => { item.Draw(e.Graphics); });
                m_lstOflapiz.ForEach((Lapiz item) => { item.Draw(e.Graphics); });
                m_lstfillCirculo.ForEach((fillCirculo item) => { item.Draw(e.Graphics); });
                m_lstOfRojor.ForEach((RojoRectangulo item) => { item.Draw(e.Graphics); });
                m_lstOfArbol.ForEach((Arbol item) => { item.Draw(e.Graphics); });
                m_lstOfCancha.ForEach((Cancha item) => { item.Draw(e.Graphics); });
                m_lstOfEstacionamiento.ForEach((Estacionamiento item) => { item.Draw(e.Graphics); });
                m_lstOfGota.ForEach((Gota item) => { item.Draw(e.Graphics); });
                m_lstOfBasura.ForEach((Basura item) => { item.Draw(e.Graphics); });
                m_lstOfZanja.ForEach((Zanja item) => { item.Draw(e.Graphics); });
                m_lstOfPozo.ForEach((Pozo item) => { item.Draw(e.Graphics); });
                m_lstOfZona.ForEach((Zona item) => { item.Draw(e.Graphics); });
                 m_lstOfTri.ForEach((Triangulo1 item) => { item.Draw(e.Graphics); });
                 m_lstOfAnclado.ForEach((Anclado item) => { item.Draw(e.Graphics); });
                 m_lstOfTechado.ForEach((Techado item) => { item.Draw(e.Graphics); });
                 m_lstOfTubo.ForEach((Tubo item) => { item.Draw(e.Graphics); });
                if ((((m_lstOfZona) != null)))
                {
                    m_Zona.Draw(g);
                }
            }
            if (figura == 25)
            {
                m_lstOfLine.ForEach((Line item) => { item.Draw(e.Graphics); });
                m_lstOfcua.ForEach((Cuadrado item) => { item.Draw(e.Graphics); });
                m_lstOfcir.ForEach((Circulo item) => { item.Draw(e.Graphics); });
                m_lstOfrfill.ForEach((RectanguloFill item) => { item.Draw(e.Graphics); });
                m_lstOflapiz.ForEach((Lapiz item) => { item.Draw(e.Graphics); });
                m_lstfillCirculo.ForEach((fillCirculo item) => { item.Draw(e.Graphics); });
                m_lstOfRojor.ForEach((RojoRectangulo item) => { item.Draw(e.Graphics); });
                m_lstOfArbol.ForEach((Arbol item) => { item.Draw(e.Graphics); });
                m_lstOfCancha.ForEach((Cancha item) => { item.Draw(e.Graphics); });
                m_lstOfEstacionamiento.ForEach((Estacionamiento item) => { item.Draw(e.Graphics); });
                m_lstOfGota.ForEach((Gota item) => { item.Draw(e.Graphics); });
                m_lstOfBasura.ForEach((Basura item) => { item.Draw(e.Graphics); });
                m_lstOfZanja.ForEach((Zanja item) => { item.Draw(e.Graphics); });
                m_lstOfPozo.ForEach((Pozo item) => { item.Draw(e.Graphics); });
                m_lstOfZona.ForEach((Zona item) => { item.Draw(e.Graphics); });
                m_lstOfTri.ForEach((Triangulo1 item) => { item.Draw(e.Graphics); });
                m_lstOfAnclado.ForEach((Anclado item) => { item.Draw(e.Graphics); });
                m_lstOfTechado.ForEach((Techado item) => { item.Draw(e.Graphics); });
                m_lstOfTubo.ForEach((Tubo item) => { item.Draw(e.Graphics); });
                if ((((m_lstOfTri) != null)))
                {
                    m_tria.Draw(g);
                }
            }
            if (figura == 26)
            {
                m_lstOfLine.ForEach((Line item) => { item.Draw(e.Graphics); });
                m_lstOfcua.ForEach((Cuadrado item) => { item.Draw(e.Graphics); });
                m_lstOfcir.ForEach((Circulo item) => { item.Draw(e.Graphics); });
                m_lstOfrfill.ForEach((RectanguloFill item) => { item.Draw(e.Graphics); });
                m_lstOflapiz.ForEach((Lapiz item) => { item.Draw(e.Graphics); });
                m_lstfillCirculo.ForEach((fillCirculo item) => { item.Draw(e.Graphics); });
                m_lstOfRojor.ForEach((RojoRectangulo item) => { item.Draw(e.Graphics); });
                m_lstOfArbol.ForEach((Arbol item) => { item.Draw(e.Graphics); });
                m_lstOfCancha.ForEach((Cancha item) => { item.Draw(e.Graphics); });
                m_lstOfEstacionamiento.ForEach((Estacionamiento item) => { item.Draw(e.Graphics); });
                m_lstOfGota.ForEach((Gota item) => { item.Draw(e.Graphics); });
                m_lstOfBasura.ForEach((Basura item) => { item.Draw(e.Graphics); });
                m_lstOfZanja.ForEach((Zanja item) => { item.Draw(e.Graphics); });
                m_lstOfPozo.ForEach((Pozo item) => { item.Draw(e.Graphics); });
                m_lstOfZona.ForEach((Zona item) => { item.Draw(e.Graphics); });
                m_lstOfTri.ForEach((Triangulo1 item) => { item.Draw(e.Graphics); });
                m_lstOfAnclado.ForEach((Anclado item) => { item.Draw(e.Graphics); });
                m_lstOfTechado.ForEach((Techado item) => { item.Draw(e.Graphics); });
                m_lstOfTubo.ForEach((Tubo item) => { item.Draw(e.Graphics); });
                if ((((m_lstOfAnclado) != null)))
                {
                    m_anclado.Draw(g);
                }
            }
            if (figura == 27)
            {
                m_lstOfLine.ForEach((Line item) => { item.Draw(e.Graphics); });
                m_lstOfcua.ForEach((Cuadrado item) => { item.Draw(e.Graphics); });
                m_lstOfcir.ForEach((Circulo item) => { item.Draw(e.Graphics); });
                m_lstOfrfill.ForEach((RectanguloFill item) => { item.Draw(e.Graphics); });
                m_lstOflapiz.ForEach((Lapiz item) => { item.Draw(e.Graphics); });
                m_lstfillCirculo.ForEach((fillCirculo item) => { item.Draw(e.Graphics); });
                m_lstOfRojor.ForEach((RojoRectangulo item) => { item.Draw(e.Graphics); });
                m_lstOfArbol.ForEach((Arbol item) => { item.Draw(e.Graphics); });
                m_lstOfCancha.ForEach((Cancha item) => { item.Draw(e.Graphics); });
                m_lstOfEstacionamiento.ForEach((Estacionamiento item) => { item.Draw(e.Graphics); });
                m_lstOfGota.ForEach((Gota item) => { item.Draw(e.Graphics); });
                m_lstOfBasura.ForEach((Basura item) => { item.Draw(e.Graphics); });
                m_lstOfZanja.ForEach((Zanja item) => { item.Draw(e.Graphics); });
                m_lstOfPozo.ForEach((Pozo item) => { item.Draw(e.Graphics); });
                m_lstOfZona.ForEach((Zona item) => { item.Draw(e.Graphics); });
                m_lstOfTri.ForEach((Triangulo1 item) => { item.Draw(e.Graphics); });
                m_lstOfAnclado.ForEach((Anclado item) => { item.Draw(e.Graphics); });
                m_lstOfTechado.ForEach((Techado item) => { item.Draw(e.Graphics); });
                m_lstOfTubo.ForEach((Tubo item) => { item.Draw(e.Graphics); });
                if ((((m_lstOfTechado) != null)))
                {
                    m_techado.Draw(g);
                }
            }
            if (figura == 28)
            {
                m_lstOfLine.ForEach((Line item) => { item.Draw(e.Graphics); });
                m_lstOfcua.ForEach((Cuadrado item) => { item.Draw(e.Graphics); });
                m_lstOfcir.ForEach((Circulo item) => { item.Draw(e.Graphics); });
                m_lstOfrfill.ForEach((RectanguloFill item) => { item.Draw(e.Graphics); });
                m_lstOflapiz.ForEach((Lapiz item) => { item.Draw(e.Graphics); });
                m_lstfillCirculo.ForEach((fillCirculo item) => { item.Draw(e.Graphics); });
                m_lstOfRojor.ForEach((RojoRectangulo item) => { item.Draw(e.Graphics); });
                m_lstOfArbol.ForEach((Arbol item) => { item.Draw(e.Graphics); });
                m_lstOfCancha.ForEach((Cancha item) => { item.Draw(e.Graphics); });
                m_lstOfEstacionamiento.ForEach((Estacionamiento item) => { item.Draw(e.Graphics); });
                m_lstOfGota.ForEach((Gota item) => { item.Draw(e.Graphics); });
                m_lstOfBasura.ForEach((Basura item) => { item.Draw(e.Graphics); });
                m_lstOfZanja.ForEach((Zanja item) => { item.Draw(e.Graphics); });
                m_lstOfPozo.ForEach((Pozo item) => { item.Draw(e.Graphics); });
                m_lstOfZona.ForEach((Zona item) => { item.Draw(e.Graphics); });
                m_lstOfTri.ForEach((Triangulo1 item) => { item.Draw(e.Graphics); });
                m_lstOfAnclado.ForEach((Anclado item) => { item.Draw(e.Graphics); });
                m_lstOfTechado.ForEach((Techado item) => { item.Draw(e.Graphics); });
                m_lstOfTubo.ForEach((Tubo item) => { item.Draw(e.Graphics); });
                if ((((m_lstOfTubo) != null)))
                {
                    m_tubo.Draw(g);
                   
                }
            }
          
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Pantalla.SizeMode = PictureBoxSizeMode.StretchImage;
             
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Pantalla.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            figura = 15;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            figura = 16;
        }

        private void button21_Click(object sender, EventArgs e)
        {
                   
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {

                MessageBox.Show("Debe establecer tamaño de letra");
            }
            else
            {
                figura = 17;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            figura = 18;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            figura = 19;
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            figura = 20;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            figura = 21;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            figura=22;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            figura = 23;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            figura = 24;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            figura = 25;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            figura = 26;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            figura= 27;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            figura = 28;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            
        }

        private void button36_Click(object sender, EventArgs e)
        {

        }

        private void button34_Click(object sender, EventArgs e)
        {

        }

        private void button35_Click(object sender, EventArgs e)
        {

        }
    }
}