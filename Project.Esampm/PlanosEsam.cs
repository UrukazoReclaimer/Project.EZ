using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using System.Drawing.Imaging;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Project.BussinessRules;

namespace Project.Esampm
{
    public partial class PlanosEsam : Form
    {
        
        Boolean activarpaint=false;
        public Boolean vertical = false;
        OpenFileDialog o = new OpenFileDialog();
        bool cargar;
        Graphics g;
       
     
        List<string> texto = new List<string>();
        private List<Line> m_lstOfLine = new List<Line>();
        private Line m_line;
        Boolean activarLine = false;
        Boolean MoverLine = false;
        private List<Circulo> m_lstOfCircle = new List<Circulo>();
        private Circulo m_circle;
        Boolean activarCircle = false;
        Boolean MoverCircle = false;
        private List<Lapiz> m_lstOfLapiz = new List<Lapiz>();
        private Lapiz m_lapiz;
        private LapizB m_lapizB;
        private List<LapizB> m_lstOfLapizB = new List<LapizB>();
        Boolean activarLipiz = false;
        private List<Cuadrado> m_lstOfRectangulo = new List<Cuadrado>();
        private Cuadrado m_rectangulo;
        Boolean activarRectangulo;
        Boolean MoverRectangulo = false;
        private List<RectanguloFill> m_lstOfCua = new List<RectanguloFill>();
        private RectanguloFill m_cua;
        Boolean activarRCuaFill;
        Boolean MoverRCuafill = false;
        private List<fillCirculo> m_lstOfCir = new List<fillCirculo>();
        private fillCirculo m_cir;
        Boolean activarCir;
        Boolean moverCir = false;
        private List<RojoRectangulo> m_lstOfRRojo = new List<RojoRectangulo>();
        private RojoRectangulo m_rrojo;
        Boolean activarRojo;
        Boolean MoverRojo = false;
        private List<Triangulo1> m_lstOfTri = new List<Triangulo1>();
        private Triangulo1 m_tri, objotri;
        Boolean activarTri;
        Boolean MoverTri = false;
        private List<Anclado> m_lstOfancla = new List<Anclado>();
        private Anclado m_ancla;
        Boolean activarancla;
        Boolean MoverAncla = false;
        private List<Gota> m_lstOfGota = new List<Gota>();
        private Gota m_gota;
        Boolean activarGota;
        Boolean MoverGota = false;
        private List<Caja> m_lstOfCaja = new List<Caja>();
        private Caja m_caja;
        Boolean activarCaja;
        Boolean MoverCaja = false;
        private List<Cancha> m_lstOfCancha = new List<Cancha>();
        private Cancha m_cancha;
        Boolean activarCacha;
        Boolean MoverCancha = false;
        private List<Basura> m_lstOfBasura = new List<Basura>();
        private Basura m_basura;
        Boolean activarBasura;
        Boolean MoverBasura = false;
        private List<Estacionamiento> m_lstOfEsta = new List<Estacionamiento>();
        private Estacionamiento m_esta;
        Boolean activarEsta;
        Boolean MoverEsta = false;
        private List<Techado> m_lstOfTecho = new List<Techado>();
        private Techado m_Techo;
        Boolean activarTecho;
        Boolean MoverTecho = false;
        private List<Arbol> m_lstOfArbol = new List<Arbol>();
        private Arbol m_Arbol;
        Boolean activarArbol;
        Boolean MoverArbol = false;
        private List<Pozo> m_lstOfPozo = new List<Pozo>();
        private Pozo m_Pozo;
        Boolean activarPozo;
        Boolean MoverPozo = false;
        private List<Zona> m_lstOfZona = new List<Zona>();
        private Zona m_Zona;
        Boolean activarZona;
        Boolean MoverZona = false;
        private List<Zanja> m_lstOfZanja = new List<Zanja>();
        private Zanja m_Zanja;
        Boolean activarZanja;
        Boolean MoverZanja = false;
        List<Palabras> pointFillpalabra = new List<Palabras>();
        private Palabras m_fillpalabra = new Palabras();
        Boolean activarPalabras;
        Boolean moverpalabras;
        List<Palabras> pointFillpalabraVertical = new List<Palabras>();
        private Palabras m_fillpalabraVertical = new Palabras();
        Boolean activarPalabrasVertical;
        Boolean MoverpalabrasVertical;
        Point pos;
        Boolean puntero = false;     
        int x;
        int y;
        int elx = 0;
        int ely = 0;
        int wi;
        int hei;
        int wx = 0;
        int wy = 0;
        private List<Goma> m_lstOfGoma = new List<Goma>();
        private Goma m_Goma;
        Boolean activarGoma;
        private List<NumeroPlano> m_lstOfNumeroPlano = new List<NumeroPlano>();
        private List<Actualizadopor> m_lstOfNumeroActualizado = new List<Actualizadopor>();
        int conttri = 0;
        int contcri = 0;
        int controjo = 0;
        int concua = 0;
        int contancla = 0;
        int contgota = 0;
        int contcaja = 0;
        private List<Otros> m_lstOfOtros = new List<Otros>();
        private Otros m_Otros;
        Boolean activarOtros;
        Boolean Moverotros = false;
        int contOtros = 0;
        private List<Escalera> m_lstOfEscalera = new List<Escalera>();
        private Escalera m_Escalera;
        Boolean activarEscalera;
        Boolean MoverEscalera = false;
        private List<Baño> m_lstOfBaño = new List<Baño>();
        private Baño m_baño;
        Boolean activarBaño;
        Boolean MoverBaño = false;     
        private List<Marco> m_lstOfMarco = new List<Marco>();
        private Marco m_marco;
        Boolean marco = false;
        Stack<string> atras = new Stack<string>();
        string sensor;
        Boolean ConsumoBoton=false;
       
        public PlanosEsam()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();

            catalogoTecnico tunits2 = new catalogoTecnico();
            List<Project.BussinessRules.Tecnico> tec2 = tunits2.obtenertec();
            this.comboBox4.DataSource = tec2;
            this.comboBox4.DisplayMember = "nombre";
            this.comboBox4.ValueMember = "cod";

            CatalogoCliente cunitsbu = new CatalogoCliente();
            List<cliente> unibu = cunitsbu.getclierut();
            this.comboBox5.DataSource = unibu;
            this.comboBox5.DisplayMember = "nombre";
            this.comboBox5.ValueMember = "rut";
        }

        private void PlanosEsam_Load(object sender, EventArgs e)
        {
           /*
            m_tri = new Triangulo1();
            objotri = new Triangulo1();

            */
          
           // g = pictureBox1.CreateGraphics();
           // pictureBox1.AllowDrop = true;
         
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            CatalogoCliente cunits2 = new CatalogoCliente();
            List<cliente> uni2 = cunits2.getclienrutfornom(comboBox5.Text);
            this.comboBox7.DataSource = uni2;
            this.comboBox7.DisplayMember = "rut";
            this.comboBox7.ValueMember = "rut";

            CatalogoCliente ca = new CatalogoCliente();
            List<cliente> la = ca.getclientcodfornom(comboBox5.Text);
            this.comboBox6.DataSource = la;
            this.comboBox6.DisplayMember = "cod";

            this.comboBox6.ValueMember = "cod";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (comboBox7.Text == "")
            {

                MessageBox.Show("Debe establecer plano");
            }
            else
            {
                MessageBox.Show("Plano Establecido");
                EditorPlano ped = new EditorPlano();
                ped.addPlano(textBox2.Text, textBox5.Text, textBox3.Text, comboBox6.Text, comboBox7.Text);
            }
        }

   

        public void AbrirImagen()
        {
            OpenFileDialog Abrir = new OpenFileDialog();
            Abrir.Filter = "JPEG(*.JPG)|*.JPG|BMP(*.BMP)|*.BMP";
            if (Abrir.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackgroundImage = System.Drawing.Image.FromFile(Abrir.FileName);

            }


        }

        public void GuardarImagen()
        {
            SaveFileDialog Guardar = new SaveFileDialog();
            Guardar.Filter = "JPEG(*.JPG)|*.JPG|BMP(*.BMP)|*.BMP";
            System.Drawing.Image Imagen = pictureBox1.BackgroundImage;
            Guardar.ShowDialog();

            Imagen.Save(Guardar.FileName);
//C:\Users\Urukazo\Desktop\sd.JPG

        }



        private void button12_Click(object sender, EventArgs e)
        {


            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);
            System.Drawing.Rectangle rect = pictureBox1.RectangleToScreen(pictureBox1.ClientRectangle);
            g.CopyFromScreen(rect.Location, Point.Empty, pictureBox1.Size);
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

            

            PdfPTable pdfTabletitulo = new PdfPTable(1);
            pdfTabletitulo.DefaultCell.Padding = 3;
            pdfTabletitulo.WidthPercentage = 100;
            pdfTabletitulo.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTabletitulo.DefaultCell.BorderWidth = 1;

            PdfPTable pdfCoordenadas = new PdfPTable(1);
            pdfCoordenadas.DefaultCell.Padding = 3;
            pdfCoordenadas.WidthPercentage = 100;
            pdfCoordenadas.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCoordenadas.DefaultCell.BorderWidth = 1;

            PdfPCell cltitulo = new PdfPCell(new Phrase(textBox2.Text));
            cltitulo.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            cltitulo.HorizontalAlignment = Element.ALIGN_CENTER;

            PdfPCell clcoord = new PdfPCell(new Phrase("Coordenadas:" + " " + textBox3.Text));
            clcoord.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            clcoord.HorizontalAlignment = Element.ALIGN_CENTER;
            PdfPCell cltri = new PdfPCell(new Phrase("Trampa Pegajosa:" + Convert.ToString(conttri)));
            cltri.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            cltri.HorizontalAlignment = Element.ALIGN_LEFT;
            PdfPCell clcua = new PdfPCell(new Phrase("Trampa Captura Viva:" + Convert.ToString(concua)));
            clcua.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            clcua.HorizontalAlignment = Element.ALIGN_LEFT;
            PdfPCell clcir = new PdfPCell(new Phrase("Trampa Tubo Cebadero:" + Convert.ToString(contcri)));
            clcir.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            clcir.HorizontalAlignment = Element.ALIGN_LEFT;
            PdfPCell clrojo = new PdfPCell(new Phrase("Trampa Fly Out:" + Convert.ToString(controjo)));
            clrojo.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            clrojo.HorizontalAlignment = Element.ALIGN_LEFT;
            PdfPCell clancla = new PdfPCell(new Phrase("Trampa Veneno Ancaldo:" + Convert.ToString(contancla)));
            clancla.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            clancla.HorizontalAlignment = Element.ALIGN_LEFT;
            PdfPCell clgota = new PdfPCell(new Phrase("Trampa de Agua:" + Convert.ToString(contgota)));
            clgota.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            clgota.HorizontalAlignment = Element.ALIGN_LEFT;
            PdfPCell clcaja = new PdfPCell(new Phrase("Trampa de Caja Cebadera:" + Convert.ToString(contcaja)));
            clcaja.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            clcaja.HorizontalAlignment = Element.ALIGN_LEFT;
            PdfPCell clOtros = new PdfPCell(new Phrase("Otros:" + Convert.ToString(contcaja)));
            clcaja.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            clcaja.HorizontalAlignment = Element.ALIGN_LEFT;

            PdfPTable pdfTabletri = new PdfPTable(1);
            pdfTabletri.DefaultCell.Padding = 3;
            pdfTabletri.WidthPercentage = 100;
            pdfTabletri.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTabletri.DefaultCell.BorderWidth = 1;
            PdfPTable pdfTablecua = new PdfPTable(1);
            pdfTablecua.DefaultCell.Padding = 3;
            pdfTablecua.WidthPercentage = 100;
            pdfTablecua.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTablecua.DefaultCell.BorderWidth = 1;
            PdfPTable pdfTablerojo = new PdfPTable(1);
            pdfTablerojo.DefaultCell.Padding = 3;
            pdfTablerojo.WidthPercentage = 100;
            pdfTablerojo.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTablerojo.DefaultCell.BorderWidth = 1;
            PdfPTable pdfTablecir = new PdfPTable(1);
            pdfTablecir.DefaultCell.Padding = 3;
            pdfTablecir.WidthPercentage = 100;
            pdfTablecir.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTablecir.DefaultCell.BorderWidth = 1;
            PdfPTable pdfTableancla = new PdfPTable(1);
            pdfTableancla.DefaultCell.Padding = 3;
            pdfTableancla.WidthPercentage = 100;
            pdfTableancla.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTableancla.DefaultCell.BorderWidth = 1;
            PdfPTable pdfTablegota = new PdfPTable(1);
            pdfTablegota.DefaultCell.Padding = 3;
            pdfTablegota.WidthPercentage = 100;
            pdfTablegota.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTablegota.DefaultCell.BorderWidth = 1;
            PdfPTable pdfTablecaja = new PdfPTable(1);
            pdfTablecaja.DefaultCell.Padding = 3;
            pdfTablecaja.WidthPercentage = 100;
            pdfTablecaja.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTablecaja.DefaultCell.BorderWidth = 1;
            PdfPTable pdfTableOtros = new PdfPTable(1);
            pdfTableOtros.DefaultCell.Padding = 3;
            pdfTableOtros.WidthPercentage = 100;
            pdfTableOtros.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTableOtros.DefaultCell.BorderWidth = 1;

            pdfTabletitulo.AddCell(cltitulo);
            pdfCoordenadas.AddCell(clcoord);
            pdfTableancla.AddCell(clancla);
            pdfTablecaja.AddCell(clcaja);
            pdfTablecir.AddCell(clcir);
            pdfTablecua.AddCell(clcua);
            pdfTablegota.AddCell(clgota);
            pdfTablerojo.AddCell(clrojo);
            pdfTabletri.AddCell(cltri);
            pdfTableOtros.AddCell(clOtros);

            //Exportar a PDF
            string folderPath = "C:\\check\\";
            if (!Directory.Exists(folderPath))
            {

                Directory.CreateDirectory(folderPath);
            }
            string hoy = DateTime.Now.Hour.ToString();
            //  comboBox1.Text = hoy;
            using (FileStream stream = new FileStream(folderPath + textBox5.Text + "-" + textBox2.Text + ".pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.LETTER, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);

                pdfDoc.Open();

                iTextSharp.text.Image imagen1 = iTextSharp.text.Image.GetInstance(@"\\STORAGE\\Public\\Esam compartido\\Informática\\esam.jpg");             
                imagen1.BorderWidth = 0;
                imagen1.Alignment = Element.ALIGN_LEFT;
                float percentage = 0.0f;
                percentage = 150 / imagen1.Width;
                imagen1.ScalePercent(percentage * 100);

             
                iTextSharp.text.Image imagen2 = iTextSharp.text.Image.GetInstance(s.FileName);
                //  iTextSharp.text.Image imagen2 = pictureBox1.Image.;
                imagen2.BorderWidth = 0;
                imagen2.Alignment = Element.ALIGN_CENTER;
                //imagen2.ScaleAbsolute(m_marco.Dx, m_marco.Dy);
                
                float percentage2 = 0.0f;
                percentage = 150 / imagen2.Width;
                 imagen2.ScalePercent(percentage2 * 100);

                pdfDoc.Add(imagen1);
                pdfDoc.Add(pdfTabletitulo);
                pdfDoc.Add(pdfCoordenadas);
                pdfDoc.Add(imagen2);
                if (contcri > 0)
                    pdfDoc.Add(pdfTablecir);
                if (contcaja > 0)
                    pdfDoc.Add(pdfTablecaja);
                if (conttri > 0)
                    pdfDoc.Add(pdfTabletri);
                if (concua > 0)
                    pdfDoc.Add(pdfTablecua);
                if (contancla > 0)
                    pdfDoc.Add(pdfTableancla);
                if (contgota > 0)
                    pdfDoc.Add(pdfTablegota);
                if (controjo > 0)
                    pdfDoc.Add(pdfTablerojo);
                if (contOtros > 0)
                    pdfDoc.Add(pdfTableOtros);
                pdfDoc.Close();

                stream.Close();
                if (comboBox3.Text == "Explorer")
                {

                    System.Diagnostics.Process.Start("IExplore.exe", folderPath + textBox5.Text + "-" + textBox2.Text + ".pdf");
                    // System.Diagnostics.Process.Start("NitroPDF.exe", folderPath + "Checklist" + "-" + comboBox1.Text + dateTimePicker1.Text + ".pdf");
                }
                if (comboBox3.Text == "Nitro")
                {
                    System.Diagnostics.Process.Start("NitroPDF.exe", folderPath + textBox5.Text + "-" + textBox2.Text + ".pdf");
                }
            }
        }
             
        
        //------------paleta de coleres
        private void button17_Click(object sender, EventArgs e)
        {
            o.Filter = "Png files|*.png|jpeg files|*jpg|bitmaps|*.bmp";
            if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string archivo;
                string ruta;
                pictureBox1.Image = System.Drawing.Image.FromFile(o.FileName);
                wx = pictureBox1.Image.Width;
                wy = pictureBox1.Image.Height;
             //   wx = m_marco.Dx;
             //   wy = m_marco.Dy;
                ruta = o.FileName;
                archivo = Path.GetFileName(ruta);
                string[] separadas;

                separadas = archivo.Split('-');
                cargar = true;
                textBox5.Text = separadas[0];
                pictureBox1.Invalidate();
                wx = pictureBox1.Width;
                wy = pictureBox1.Height;
              
                //  g.Dispose();

            }
        }

             
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                vertical = true;

            }
            else
            {
                if (checkBox1.Checked == false)
                {
                    vertical = false;

                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
     

        private void button16_Click(object sender, EventArgs e)
        {
           
            label1.Text = "X: " + Convert.ToString(x);
            label2.Text = "y: " + Convert.ToString(y);
 
            puntero = true;
            pictureBox1.Invalidate();
      
            if (comboBox8.Text == "Lineas")
            {
                if (m_lstOfLine.Count >= 1)
                {
                    m_lstOfLine.RemoveAt(m_lstOfLine.Count -1);
                   
                 
                 
                }
            }
            if (comboBox8.Text == "Circulos")
            {
                if (m_lstOfCircle.Count >= 1)
                {
               
                    m_lstOfCircle.RemoveAt(m_lstOfCircle.Count - 1);
                 
                }
            }
            if (comboBox8.Text == "Cuadrados")
            {
                if (m_lstOfRectangulo.Count >= 1)
                {
                    
                    m_lstOfRectangulo.RemoveAt(m_lstOfRectangulo.Count - 1);
                   
                }
            }
            
            if (comboBox8.Text == "Zona Basureros")
            {
                if ( m_lstOfBasura.Count >= 1)
                {
                  
                    m_lstOfBasura.RemoveAt(m_lstOfBasura.Count - 1);
                 
                }
            }
            if (comboBox8.Text == "Árbol")
            {
                if (m_lstOfArbol.Count >= 1)
                {
                   
                    m_lstOfArbol.RemoveAt(m_lstOfArbol.Count - 1);
                  
                }
            }
            if (comboBox8.Text == "Cancha")
            {
                if (m_lstOfCancha.Count >= 1)
                {

                    
                    m_lstOfCancha.RemoveAt(m_lstOfCancha.Count - 1);
                
                    
                }
            }
            if (comboBox8.Text == "Palabras")
            {
                if (pointFillpalabra.Count >= 1)
                {
                    
                    pointFillpalabra.RemoveAt(pointFillpalabra.Count - 1);
                


                }
            }
            if (comboBox8.Text == "Palabras Vertical")
            {
                if (pointFillpalabraVertical.Count >= 1)
                {
                    
                    pointFillpalabraVertical.RemoveAt(pointFillpalabraVertical.Count - 1);
                


                }
            }
            if (comboBox8.Text == "Estacionamiento")
            {
                if ( m_lstOfEsta.Count >= 1)
                {
                    
                    m_lstOfEsta.RemoveAt(m_lstOfEsta.Count - 1);
             


                }
            }
            if (comboBox8.Text == "Baño")
            {
                if (m_lstOfBaño.Count >= 1)
                {
                    
                    m_lstOfBaño.RemoveAt(m_lstOfBaño.Count - 1);
           

                }
            }
            if (comboBox8.Text == "Escaleras")
            {
                if (m_lstOfEscalera.Count >= 1)
                {
                    
                    m_lstOfEscalera.RemoveAt(m_lstOfEscalera.Count - 1);
                


                }
            }
            if (comboBox8.Text == "Zona Madriguera")
            {
                if (m_lstOfZona.Count >= 1)
                {
                    
                    m_lstOfZona.RemoveAt(m_lstOfZona.Count - 1);
              


                }
            }
         pictureBox1.Refresh();
           
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button22_Click(object sender, EventArgs e)
        {
            if (vertical == false)
            {
                activarLine = false;
                activarCircle = false;
                activarLipiz = false;
                activarRectangulo = false;
                activarRCuaFill = false;
                activarCir = false;
                activarRojo = false;
                activarTri = false;
                activarancla = false;
                activarGota = false;
                activarCaja = false;
                activarCacha = false;
                activarBasura = false;
                activarEsta = false;
                activarTecho = false;
                activarArbol = false;
                activarPozo = false;
                activarZona = false;
                activarPalabras = true;
                activarGoma = false;
                activarZanja = false;
                activarPalabrasVertical = false;
                activarOtros = false;
                activarEscalera = false;
                activarBaño = false;
            }
            else
            {
                if (vertical == true)
                {
                    activarLine = false;
                    activarCircle = false;
                    activarLipiz = false;
                    activarRectangulo = false;
                    activarRCuaFill = false;
                    activarCir = false;
                    activarRojo = false;
                    activarTri = false;
                    activarancla = false;
                    activarGota = false;
                    activarCaja = false;
                    activarCacha = false;
                    activarBasura = false;
                    activarEsta = false;
                    activarTecho = false;
                    activarArbol = false;
                    activarPozo = false;
                    activarZona = false;
                    activarPalabras = false;
                    activarGoma = false;
                    activarZanja = false;
                    activarPalabrasVertical = true;
                    activarOtros = false;
                    activarEscalera = false;
                    activarBaño = false;
                }
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {

            activarLine = true;
            activarCircle = false;
            activarLipiz = false;
            activarRectangulo = false;
            activarRCuaFill = false;
            activarCir = false;
            activarRojo = false;
            activarTri = false;
            activarancla = false;
            activarGota = false;
            activarCaja = false;
            activarCacha = false;
            activarBasura = false;
            activarEsta = false;
            activarTecho = false;
            activarArbol = false;
            activarPozo = false;
            activarZona = false;
            activarPalabras = false;
            activarGoma = false;
            activarZanja = false;
            activarPalabrasVertical = false;
            activarOtros = false;
            activarEscalera = false;
            activarBaño = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            activarCircle = true;
            activarLine = false;
            activarLipiz = false;
            activarRectangulo = false;
            activarRCuaFill = false;
            activarCir = false;
            activarRojo = false;
            activarTri = false;
            activarancla = false;
            activarGota = false;
            activarCaja = false;
            activarCacha = false;
            activarBasura = false;
            activarEsta = false;
            activarTecho = false;
            activarArbol = false;
            activarPozo = false;
            activarZona = false;
            activarPalabras = false;
            activarGoma = false;
            activarZanja = false;
            activarPalabrasVertical = false;
            activarOtros = false;
            activarEscalera = false;
            activarBaño = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            activarLine = false;
            activarCircle = false;
            activarLipiz = false;
            activarRectangulo = true;
            activarRCuaFill = false;
            activarCir = false;
            activarRojo = false;
            activarTri = false;
            activarancla = false;
            activarGota = false;
            activarCaja = false;
            activarCacha = false;
            activarBasura = false;
            activarEsta = false;
            activarTecho = false;
            activarArbol = false;
            activarPozo = false;
            activarZona = false;
            activarPalabras = false;
            activarGoma = false;
            activarZanja = false;
            activarPalabrasVertical = false;
            activarOtros = false;
            activarEscalera = false;
            activarBaño = false;
        }
        private void button14_Click(object sender, EventArgs e)
        {
            activarRCuaFill = true;
            activarLipiz = false;
            activarLine = false;
            activarCircle = false;
            activarRectangulo = false;
            activarCir = false;
            activarRojo = false;
            activarTri = false;
            activarancla = false;
            activarGota = false;
            activarCaja = false;
            activarCacha = false;
            activarBasura = false;
            activarEsta = false;
            activarTecho = false;
            activarArbol = false;
            activarPozo = false;
            activarZona = false;
            activarPalabras = false;
            activarGoma = false;
            activarZanja = false;
            activarPalabrasVertical = false;
            activarOtros = false;
            activarEscalera = false;
            activarBaño = false;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            activarLine = false;
            activarCircle = false;
            activarLipiz = false;
            activarRectangulo = false;
            activarRCuaFill = false;
            activarCir = true;
            activarRojo = false;
            activarTri = false;
            activarancla = false;
            activarGota = false;
            activarCaja = false;
            activarCacha = false;
            activarBasura = false;
            activarEsta = false;
            activarTecho = false;
            activarArbol = false;
            activarPozo = false;
            activarZona = false;
            activarPalabras = false;
            activarGoma = false;
            activarZanja = false;
            activarPalabrasVertical = false;
            activarOtros = false;
            activarEscalera = false;
            activarBaño = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            activarLine = false;
            activarCircle = false;
            activarLipiz = false;
            activarRectangulo = false;
            activarRCuaFill = false;
            activarCir = false;
            activarRojo = true;
            activarTri = false;
            activarancla = false;
            activarGota = false;
            activarCaja = false;
            activarCacha = false;
            activarBasura = false;
            activarEsta = false;
            activarTecho = false;
            activarArbol = false;
            activarPozo = false;
            activarZona = false;
            activarPalabras = false;
            activarGoma = false;
            activarZanja = false;
            activarPalabrasVertical = false;
            activarOtros = false;
            activarEscalera = false;
            activarBaño = false;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            activarLine = false;
            activarCircle = false;
            activarLipiz = false;
            activarRectangulo = false;
            activarRCuaFill = false;
            activarCir = false;
            activarRojo = false;
            activarTri = true;
            activarancla = false;
            activarGota = false;
            activarCaja = false;
            activarCacha = false;
            activarBasura = false;
            activarEsta = false;
            activarTecho = false;
            activarArbol = false;
            activarPozo = false;
            activarZona = false;
            activarPalabras = false;
            activarGoma = false;
            activarZanja = false;
            activarPalabrasVertical = false;
            activarOtros = false;
            activarEscalera = false;
            activarBaño = false;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            activarancla = true;
            activarLine = false;
            activarCircle = false;
            activarLipiz = false;
            activarRectangulo = false;
            activarRCuaFill = false;
            activarCir = false;
            activarRojo = false;
            activarTri = false;
            activarancla = true;
            activarGota = false;
            activarCaja = false;
            activarCacha = false;
            activarBasura = false;
            activarEsta = false;
            activarTecho = false;
            activarArbol = false;
            activarPozo = false;
            activarZona = false;
            activarPalabras = false;
            activarGoma = false;
            activarZanja = false;
            activarPalabrasVertical = false;
            activarOtros = false;
            activarEscalera = false;
            activarBaño = false;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            activarLine = false;
            activarCircle = false;
            activarLipiz = false;
            activarRectangulo = false;
            activarRCuaFill = false;
            activarCir = false;
            activarRojo = false;
            activarTri = false;
            activarancla = false;
            activarGota = true;
            activarCaja = false;
            activarCacha = false;
            activarBasura = false;
            activarEsta = false;
            activarTecho = false;
            activarArbol = false;
            activarPozo = false;
            activarZona = false;
            activarPalabras = false;
            activarGoma = false;
            activarZanja = false;
            activarPalabrasVertical = false;
            activarOtros = false;
            activarEscalera = false;
            activarBaño = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            activarOtros = true;
            activarGoma = false;
            activarLine = false;
            activarCircle = false;
            activarLipiz = false;
            activarRectangulo = false;
            activarRCuaFill = false;
            activarCir = false;
            activarRojo = false;
            activarTri = false;
            activarancla = false;
            activarGota = false;
            activarCaja = false;
            activarCacha = false;
            activarBasura = false;
            activarEsta = false;
            activarTecho = false;
            activarArbol = false;
            activarPozo = false;
            activarZona = false;
            activarPalabras = false;
            activarZanja = false;
            activarPalabrasVertical = false;
            activarEscalera = false;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            activarLine = false;
            activarCircle = false;
            activarLipiz = false;
            activarRectangulo = false;
            activarRCuaFill = false;
            activarCir = false;
            activarRojo = false;
            activarTri = false;
            activarancla = false;
            activarGota = false;
            activarCaja = true;
            activarCacha = false;
            activarBasura = false;
            activarEsta = false;
            activarTecho = false;
            activarArbol = false;
            activarPozo = false;
            activarZona = false;
            activarPalabras = false;
            activarGoma = false;
            activarZanja = false;
            activarPalabrasVertical = false;
            activarOtros = false;
            activarEscalera = false;
            activarBaño = false;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            activarLine = false;
            activarCircle = false;
            activarLipiz = false;
            activarRectangulo = false;
            activarRCuaFill = false;
            activarCir = false;
            activarRojo = false;
            activarTri = false;
            activarancla = false;
            activarGota = false;
            activarCaja = false;
            activarCacha = false;
            activarBasura = true;
            activarEsta = false;
            activarTecho = false;
            activarArbol = false;
            activarPozo = false;
            activarZona = false;
            activarPalabras = false;
            activarGoma = false;
            activarZanja = false;
            activarPalabrasVertical = false;
            activarOtros = false;
            activarEscalera = false;
            activarBaño = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            activarLine = false;
            activarCircle = false;
            activarLipiz = false;
            activarRectangulo = false;
            activarRCuaFill = false;
            activarCir = false;
            activarRojo = false;
            activarTri = false;
            activarancla = false;
            activarGota = false;
            activarCaja = false;
            activarCacha = false;
            activarBasura = false;
            activarEsta = false;
            activarTecho = false;
            activarArbol = true;
            activarPozo = false;
            activarZona = false;
            activarPalabras = false;
            activarGoma = false;
            activarZanja = false;
            activarPalabrasVertical = false;
            activarOtros = false;
            activarEscalera = false;
            activarBaño = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            activarLine = false;
            activarCircle = false;
            activarLipiz = false;
            activarRectangulo = false;
            activarRCuaFill = false;
            activarCir = false;
            activarRojo = false;
            activarTri = false;
            activarancla = false;
            activarGota = false;
            activarCaja = false;
            activarCacha = true;
            activarBasura = false;
            activarEsta = false;
            activarTecho = false;
            activarArbol = false;
            activarPozo = false;
            activarZona = false;
            activarPalabras = false;
            activarGoma = false;
            activarZanja = false;
            activarPalabrasVertical = false;
            activarOtros = false;
            activarEscalera = false;
            activarBaño = false;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            activarLine = false;
            activarCircle = false;
            activarLipiz = false;
            activarRectangulo = false;
            activarRCuaFill = false;
            activarCir = false;
            activarRojo = false;
            activarTri = false;
            activarancla = false;
            activarGota = false;
            activarCaja = false;
            activarCacha = false;
            activarBasura = false;
            activarEsta = false;
            activarTecho = false;
            activarArbol = false;
            activarPozo = true;
            activarZona = false;
            activarPalabras = false;
            activarGoma = false;
            activarZanja = false;
            activarPalabrasVertical = false;
            activarOtros = false;
            activarEscalera = false;
            activarBaño = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            activarLine = false;
            activarCircle = false;
            activarLipiz = false;
            activarRectangulo = false;
            activarRCuaFill = false;
            activarCir = false;
            activarRojo = false;
            activarTri = false;
            activarancla = false;
            activarGota = false;
            activarCaja = false;
            activarCacha = false;
            activarBasura = false;
            activarEsta = true;
            activarTecho = false;
            activarArbol = false;
            activarPozo = false;
            activarZona = false;
            activarPalabras = false;
            activarGoma = false;
            activarZanja = false;
            activarPalabrasVertical = false;
            activarOtros = false;
            activarEscalera = false;
            activarBaño = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            activarOtros = false;
            activarGoma = false;
            activarLine = false;
            activarCircle = false;
            activarLipiz = false;
            activarRectangulo = false;
            activarRCuaFill = false;
            activarCir = false;
            activarRojo = false;
            activarTri = false;
            activarancla = false;
            activarGota = false;
            activarCaja = false;
            activarCacha = false;
            activarBasura = false;
            activarEsta = false;
            activarTecho = false;
            activarArbol = false;
            activarPozo = false;
            activarZona = false;
            activarPalabras = false;
            activarZanja = false;
            activarPalabrasVertical = false;
            activarEscalera = false;
            activarBaño = true;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            activarLine = false;
            activarCircle = false;
            activarLipiz = false;
            activarRectangulo = false;
            activarRCuaFill = false;
            activarCir = false;
            activarRojo = false;
            activarTri = false;
            activarancla = false;
            activarGota = false;
            activarCaja = false;
            activarCacha = false;
            activarBasura = false;
            activarEsta = false;
            activarTecho = false;
            activarArbol = false;
            activarPozo = false;
            activarZona = true;
            activarPalabras = false;
            activarGoma = false;
            activarZanja = false;
            activarPalabrasVertical = false;
            activarOtros = false;
            activarEscalera = false;
            activarBaño = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            activarGoma = false;
            activarLine = false;
            activarCircle = false;
            activarLipiz = false;
            activarRectangulo = false;
            activarRCuaFill = false;
            activarCir = false;
            activarRojo = false;
            activarTri = false;
            activarancla = false;
            activarGota = false;
            activarCaja = false;
            activarCacha = false;
            activarBasura = false;
            activarEsta = false;
            activarTecho = false;
            activarArbol = false;
            activarPozo = false;
            activarZona = false;
            activarPalabras = false;
            activarZanja = true;
            activarPalabrasVertical = false;
            activarOtros = false;
            activarEscalera = false;
            activarBaño = false;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            activarLine = false;
            activarCircle = false;
            activarLipiz = false;
            activarRectangulo = false;
            activarRCuaFill = false;
            activarCir = false;
            activarRojo = false;
            activarTri = false;
            activarancla = false;
            activarGota = false;
            activarCaja = false;
            activarCacha = false;
            activarBasura = false;
            activarEsta = false;
            activarTecho = true;
            activarArbol = false;
            activarPozo = false;
            activarZona = false;
            activarPalabras = false;
            activarGoma = false;
            activarZanja = false;
            activarPalabrasVertical = false;
            activarOtros = false;
            activarEscalera = false;
            activarBaño = false;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            activarOtros = false;
            activarGoma = false;
            activarLine = false;
            activarCircle = false;
            activarLipiz = false;
            activarRectangulo = false;
            activarRCuaFill = false;
            activarCir = false;
            activarRojo = false;
            activarTri = false;
            activarancla = false;
            activarGota = false;
            activarCaja = false;
            activarCacha = false;
            activarBasura = false;
            activarEsta = false;
            activarTecho = false;
            activarArbol = false;
            activarPozo = false;
            activarZona = false;
            activarPalabras = false;
            activarZanja = false;
            activarPalabrasVertical = false;
            activarEscalera = true;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            HistorialDispositivos hit = new HistorialDispositivos();
            hit.textBox1.Text = textBox5.Text;
            hit.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (activarpaint == true)
            {
                g = e.Graphics;
                m_lstOfLine.ForEach((Line item) => { item.Draw(g); });
                if ((((m_line) != null)))
                    m_line.Draw(g);
                m_lstOfCircle.ForEach((Circulo item) => { item.Draw(g); });
                if ((((m_circle) != null)))
                    m_circle.Draw(g);
                foreach (LapizB item in m_lstOfLapizB)
                {
                    m_lapizB = new LapizB();
                    //crea un Nuevo graphics
                    Graphics gp = e.Graphics;
                    //dibuja la linea desde la lista
                    //item.Draw(gp);
                    Pen pen = new Pen(Color.Black);
                    //    gp.FillEllipse(new SolidBrush(Color.Black), m_lapizB.Cx, m_lapizB.Cy, m_lapizB.Dx, m_lapizB.Dy);
                    m_lapizB.Draw(gp);
                }
                m_lstOfRectangulo.ForEach((Cuadrado item) => { item.Draw(g); });
                if ((((m_rectangulo) != null)))
                    m_rectangulo.Draw(g);
                m_lstOfCua.ForEach((RectanguloFill item) => { item.Draw(g); });
                if ((((m_cua) != null)))
                    m_cua.Draw(g);
                m_lstOfCir.ForEach((fillCirculo item) => { item.Draw(g); });
                if ((((m_cir) != null)))
                    m_cir.Draw(g);
                m_lstOfRRojo.ForEach((RojoRectangulo item) => { item.Draw(g); });
                if ((((m_rrojo) != null)))
                    m_rrojo.Draw(g);

                m_lstOfTri.ForEach((Triangulo1 item) => { item.Draw(g); });
                if ((((m_tri) != null)))
                {
                    m_tri.Draw(g);             
                 //   pictureBox1.Invalidate();                
                }

                m_lstOfancla.ForEach((Anclado item) => { item.Draw(g); });
                if ((((m_ancla) != null)))
                    m_ancla.Draw(g);
                m_lstOfGota.ForEach((Gota item) => { item.Draw(g); });
                if ((((m_gota) != null)))
                    m_gota.Draw(g);
                m_lstOfCaja.ForEach((Caja item) => { item.Draw(g); });
                if ((((m_caja) != null)))
                    m_caja.Draw(g);
                m_lstOfCancha.ForEach((Cancha item) => { item.Draw(g); });
                if ((((m_cancha) != null)))
                {
                    m_cancha.Draw(g);
                   

                }
                m_lstOfZanja.ForEach((Zanja item) => { item.Draw(g); });
                if ((((m_Zanja) != null)))
                    m_Zanja.Draw(g);
                m_lstOfBasura.ForEach((Basura item) => { item.Draw(g); });
                if ((((m_basura) != null)))
                    m_basura.Draw(g);
                m_lstOfEsta.ForEach((Estacionamiento item) => { item.Draw(g); });
                if ((((m_esta) != null)))
                    m_esta.Draw(g);
                m_lstOfTecho.ForEach((Techado item) => { item.Draw(g); });
                if ((((m_Techo) != null)))
                    m_Techo.Draw(g);
                m_lstOfArbol.ForEach((Arbol item) => { item.Draw(g); });
                if ((((m_Arbol) != null)))
                    m_Arbol.Draw(g);
                m_lstOfPozo.ForEach((Pozo item) => { item.Draw(g); });
                if ((((m_Pozo) != null)))
                    m_Pozo.Draw(g);
                m_lstOfZona.ForEach((Zona item) => { item.Draw(g); });
                if ((((m_Zona) != null)))
                    m_Zona.Draw(g);
                m_lstOfGoma.ForEach((Goma item) => { item.Draw(g); });
                if ((((m_Goma) != null)))
                    m_Goma.Draw(g);
                m_lstOfMarco.ForEach((Marco item) => { item.Draw(g); });
                if ((((m_marco) != null)))
                {
                    m_marco.Draw(g);
                    pictureBox1.Invalidate();


                }
                ////AQUI EL VERTICAL DRAW
                pointFillpalabra.ForEach((Palabras item) => { item.Draw(g); });
                if ((((m_fillpalabra) != null)) && comboBox1.Text != textBox1.Text)
                {
                    m_fillpalabra.Draw(g);
                }

                pointFillpalabraVertical.ForEach((Palabras item) => { item.DrawVertical(g); });
                if ((((m_fillpalabraVertical) != null)) && comboBox1.Text != textBox1.Text)
                {

                    m_fillpalabraVertical.DrawVertical(g);
                }
              
           
                m_lstOfOtros.ForEach((Otros item) => { item.Draw(g); });
                if ((((m_Otros) != null)))
                    m_Otros.Draw(g);
                m_lstOfEscalera.ForEach((Escalera item) => { item.Draw(g); });
                if ((((m_Escalera) != null)))
                {
                  
                    m_Escalera.Draw(g);
                }
                m_lstOfBaño.ForEach((Baño item) => { item.Draw(g); });
                if ((((m_baño) != null)))
                    m_baño.Draw(g);
               // pictureBox1.Invalidate();
            }
  
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            x = e.Location.X;
            y = e.Location.Y;
            label1.Text = "X: " + Convert.ToString(x);
            label2.Text = "y: " + Convert.ToString(y);

        
            if (activarRCuaFill == true)
            {

                if (comboBox2.Text == "")
                {
                    MessageBox.Show("Asignar Tamaño");

                }
                else
                {
                    if (((m_cua == null) || (e.Button != MouseButtons.Left)))
                        return;
                    m_cua.Dx = Convert.ToInt32(comboBox2.Text);
                    m_cua.Dy = Convert.ToInt32(comboBox2.Text);
                    m_lstOfCua.Add(m_cua);
                    concua++;
                    pictureBox1.Invalidate();
                    this.activarRCuaFill = false;
                    this.MoverRCuafill = true;
                    this.MoverAncla = false;
                    this.MoverArbol = false;
                    this.MoverBasura = false;
                    this.MoverCaja = false;
                    this.MoverCancha = false;
                    this.moverCir = false;
                    this.MoverCircle = false;
                    this.MoverEsta = false;
                    this.MoverGota = false;
                    this.MoverLine = false;
                    this.MoverPozo = false;
                    this.MoverRectangulo = false;
                    this.MoverRojo = false;
                    this.MoverTecho = false;
                    this.MoverTri = false;
                    this.MoverZona = false;
                    this.MoverZanja = false;
                    this.MoverBaño = false;
                    this.moverpalabras = false;
                    MoverRectangulo = false;
                    MoverCircle = false;
                    Moverotros = false;
                    this.MoverpalabrasVertical = false;
                    string nombre = "Trampa Captura Viva";
                    Point aux = new Point(e.Location.X, e.Location.Y);
                    CatalogoDispoitivo cat = new CatalogoDispoitivo();
                    cat.addDispositivo(0, nombre, concua, e.Location.X, e.Location.Y, textBox5.Text, 0);
                    //todos los bool de mover false ecepto el del este
                }
            }
            if (activarCir == true)
            {

                if (comboBox2.Text == "")
                {
                    MessageBox.Show("Asignar Tamaño");

                }
                else
                {
                    if (((m_cir == null) || (e.Button != MouseButtons.Left)))
                        return;
                    m_cir.Dx = Convert.ToInt32(comboBox2.Text);
                    m_cir.Dy = Convert.ToInt32(comboBox2.Text);
                    m_lstOfCir.Add(m_cir);
                    contcri++;
                    pictureBox1.Invalidate();
                    activarCir = false;
                    this.activarRCuaFill = false;
                    this.MoverRCuafill = false;
                    this.MoverAncla = false;
                    this.MoverArbol = false;
                    this.MoverBasura = false;
                    this.MoverCaja = false;
                    this.MoverCancha = false;
                    this.moverCir = true;
                    this.MoverCircle = false;
                    this.MoverEsta = false;
                    this.MoverGota = false;
                    this.MoverLine = false;
                    this.MoverPozo = false;
                    this.MoverRectangulo = false;
                    this.MoverRojo = false;
                    this.MoverTecho = false;
                    this.MoverTri = false;
                    this.MoverZona = false;
                    this.MoverZanja = false;
                    this.moverpalabras = false;
                    MoverRectangulo = false;
                    MoverCircle = false;
                    this.MoverBaño = false;
                    Moverotros = false;
                    this.MoverpalabrasVertical = false;
                    string nombre = "Tubo Cebadero";
                    Point aux = new Point(e.Location.X, e.Location.Y);
                    CatalogoDispoitivo cat = new CatalogoDispoitivo();
                    cat.addDispositivo(0, nombre, contcri, e.Location.X, e.Location.Y, textBox5.Text, 0);
                }
            }
            if (activarRojo == true)
            {

                if (comboBox2.Text == "")
                {
                    MessageBox.Show("Asignar Tamaño");

                }
                else
                {
                    if (((m_rrojo == null) || (e.Button != MouseButtons.Left)))
                        return;
                    m_rrojo.Dx = Convert.ToInt32(comboBox2.Text) + 4;
                    m_rrojo.Dy = Convert.ToInt32(comboBox2.Text);
                    m_lstOfRRojo.Add(m_rrojo);
                    controjo++;
                    pictureBox1.Invalidate();
                    activarRojo = false;
                    this.activarRCuaFill = false;
                    this.MoverRCuafill = false;
                    this.MoverAncla = false;
                    this.MoverArbol = false;
                    this.MoverBasura = false;
                    this.MoverCaja = false;
                    this.MoverCancha = false;
                    this.moverCir = false;
                    this.MoverCircle = false;
                    this.MoverEsta = false;
                    this.MoverGota = false;
                    this.MoverLine = false;
                    this.MoverPozo = false;
                    this.MoverRectangulo = false;
                    this.MoverRojo = true;
                    this.MoverTecho = false;
                    this.MoverTri = false;
                    this.MoverZona = false;
                    this.MoverZanja = false;
                    this.moverpalabras = false;
                    MoverRectangulo = false;
                    this.MoverBaño = false;
                    MoverCircle = false;
                    Moverotros = false;
                    this.MoverpalabrasVertical = false;
                    string nombre = "Fly Out";
                    Point aux = new Point(e.Location.X, e.Location.Y);
                    CatalogoDispoitivo cat = new CatalogoDispoitivo();
                    cat.addDispositivo(0, nombre, controjo, e.Location.X, e.Location.Y, textBox5.Text, 0);
                }
            }
            if (activarTri == true)
            {

                if (comboBox2.Text == "")
                {
                    MessageBox.Show("Asignar Tamaño");

                }
                else
                {
                    if (((m_tri == null) || (e.Button != MouseButtons.Left)))
                        return;
                    m_tri.Dx = Convert.ToInt32(comboBox2.Text);
                    m_tri.Dy = Convert.ToInt32(comboBox2.Text);
                    m_lstOfTri.Add(m_tri);
                    conttri++;
                    pictureBox1.Invalidate();
                   
                    activarTri = false;
                    this.activarRCuaFill = false;
                    this.MoverRCuafill = false;
                    this.MoverAncla = false;
                    this.MoverArbol = false;
                    this.MoverBasura = false;
                    this.MoverCaja = false;
                    this.MoverCancha = false;
                    this.moverCir = false;
                    this.MoverCircle = false;
                    this.MoverEsta = false;
                    this.MoverGota = false;
                    this.MoverLine = false;
                    this.MoverPozo = false;
                    this.MoverRectangulo = false;
                    this.MoverRojo = false;
                    this.MoverTecho = false;
                    this.MoverTri = true;
                    this.MoverZona = false;
                    this.MoverZanja = false;
                    this.moverpalabras = false;
                    MoverRectangulo = false;
                    MoverCircle = false;
                    Moverotros = false;
                    this.MoverBaño = false;
                    this.MoverpalabrasVertical = false;
                    string nombre = "Trampa Pegajosa";
                    Point aux = new Point(e.Location.X, e.Location.Y);
                    CatalogoDispoitivo cat = new CatalogoDispoitivo();
                    cat.addDispositivo(0, nombre, conttri, e.Location.X, e.Location.Y, textBox5.Text, 0);
                }
            }
            if (activarancla == true)
            {

                if (comboBox2.Text == "")
                {
                    MessageBox.Show("Asignar Tamaño");

                }
                else
                {
                    if (((m_ancla == null) || (e.Button != MouseButtons.Left)))
                        return;
                    m_ancla.Dx = Convert.ToInt32(comboBox2.Text);
                    m_ancla.Dy = Convert.ToInt32(comboBox2.Text);
                    m_lstOfancla.Add(m_ancla);
                    contancla++;
                    pictureBox1.Invalidate();
                    activarancla = false;
                    this.activarRCuaFill = false;
                    this.MoverRCuafill = false;
                    this.MoverAncla = true;
                    this.MoverArbol = false;
                    this.MoverBasura = false;
                    this.MoverCaja = false;
                    this.MoverCancha = false;
                    this.moverCir = false;
                    this.MoverCircle = false;
                    this.MoverEsta = false;
                    this.MoverGota = false;
                    this.MoverLine = false;
                    this.MoverPozo = false;
                    this.MoverRectangulo = false;
                    this.MoverRojo = false;
                    this.MoverTecho = false;
                    this.MoverTri = false;
                    this.MoverZona = false;
                    this.MoverZanja = false;
                    this.moverpalabras = false;
                    MoverRectangulo = false;
                    MoverCircle = false;
                    Moverotros = false;
                    this.MoverpalabrasVertical = false;
                    this.MoverBaño = false;
                    string nombre = "Veneno Anclado";
                    Point aux = new Point(e.Location.X, e.Location.Y);
                    CatalogoDispoitivo cat = new CatalogoDispoitivo();
                    cat.addDispositivo(0, nombre, contancla, e.Location.X, e.Location.Y, textBox5.Text, 0);
                }
            }
            if (activarGota == true)
            {

                if (comboBox2.Text == "")
                {
                    MessageBox.Show("Asignar Tamaño");

                }
                else
                {
                    if (((m_gota == null) || (e.Button != MouseButtons.Left)))
                        return;
                    m_gota.Dx = Convert.ToInt32(comboBox2.Text);
                    m_gota.Dy = Convert.ToInt32(comboBox2.Text);
                    m_lstOfGota.Add(m_gota);
                    contgota++;
                    pictureBox1.Invalidate();
                    activarGota = false;
                    this.activarRCuaFill = false;
                    this.MoverRCuafill = false;
                    this.MoverAncla = false;
                    this.MoverArbol = false;
                    this.MoverBasura = false;
                    this.MoverCaja = false;
                    this.MoverCancha = false;
                    this.moverCir = false;
                    this.MoverCircle = false;
                    this.MoverEsta = false;
                    this.MoverGota = true;
                    this.MoverLine = false;
                    this.MoverPozo = false;
                    this.MoverRectangulo = false;
                    this.MoverRojo = false;
                    this.MoverTecho = false;
                    this.MoverTri = false;
                    this.MoverZona = false;
                    this.MoverZanja = false;
                    this.moverpalabras = false;
                    MoverRectangulo = false;
                    MoverCircle = false;
                    Moverotros = false;
                    this.MoverBaño = false;
                    this.MoverpalabrasVertical = false;
                    string nombre = "Trampa de Agua";
                    Point aux = new Point(e.Location.X, e.Location.Y);
                    CatalogoDispoitivo cat = new CatalogoDispoitivo();
                    cat.addDispositivo(0, nombre, contgota, e.Location.X, e.Location.Y, textBox5.Text, 0);
                }
            }
            if (activarCaja == true)
            {

                if (comboBox2.Text == "")
                {
                    MessageBox.Show("Asignar Tamaño");

                }
                else
                {
                    if (((m_caja == null) || (e.Button != MouseButtons.Left)))
                        return;
                    m_caja.Dx = Convert.ToInt32(comboBox2.Text);
                    m_caja.Dy = Convert.ToInt32(comboBox2.Text);
                    m_lstOfCaja.Add(m_caja);
                    contcaja++;
                    pictureBox1.Invalidate();
                    activarCaja = false;
                    this.activarRCuaFill = false;
                    this.MoverRCuafill = false;
                    this.MoverAncla = false;
                    this.MoverArbol = false;
                    this.MoverBasura = false;
                    this.MoverCaja = true;
                    this.MoverCancha = false;
                    this.moverCir = false;
                    this.MoverCircle = false;
                    this.MoverEsta = false;
                    this.MoverGota = false;
                    this.MoverLine = false;
                    this.MoverPozo = false;
                    this.MoverRectangulo = false;
                    this.MoverRojo = false;
                    this.MoverTecho = false;
                    this.MoverTri = false;
                    this.MoverZona = false;
                    this.MoverZanja = false;
                    this.moverpalabras = false;
                    MoverRectangulo = false;
                    MoverCircle = false;
                    Moverotros = false;
                    this.MoverBaño = false;
                    this.MoverpalabrasVertical = false;
                    string nombre = "Caja Cebadera";
                    Point aux = new Point(e.Location.X, e.Location.Y);
                    CatalogoDispoitivo cat = new CatalogoDispoitivo();
                    cat.addDispositivo(0, nombre, contcaja, e.Location.X, e.Location.Y, textBox5.Text, 0);
                }
            }
            if (activarArbol == true)
            {

                if (comboBox2.Text == "")
                {
                    MessageBox.Show("Asignar Tamaño");

                }
                else
                {
                    if (((m_Arbol == null) || (e.Button != MouseButtons.Left)))
                        return;
                    m_Arbol.Dx = Convert.ToInt32(comboBox2.Text);
                    m_Arbol.Dy = Convert.ToInt32(comboBox2.Text);
                    m_lstOfArbol.Add(m_Arbol);
                    pictureBox1.Invalidate();
                    activarArbol = false;
                    this.activarRCuaFill = false;
                    this.MoverRCuafill = false;
                    this.MoverAncla = false;
                    this.MoverArbol = true;
                    this.MoverBasura = false;
                    this.MoverCaja = false;
                    this.MoverCancha = false;
                    this.moverCir = false;
                    this.MoverCircle = false;
                    this.MoverEsta = false;
                    this.MoverGota = false;
                    this.MoverLine = false;
                    this.MoverPozo = false;
                    this.MoverRectangulo = false;
                    this.MoverRojo = false;
                    this.MoverTecho = false;
                    this.MoverTri = false;
                    this.MoverZona = false;
                    this.MoverZanja = false;
                    this.moverpalabras = false;
                    MoverRectangulo = false;
                    MoverCircle = false;
                    Moverotros = false;
                    this.MoverBaño = false;
                    this.MoverpalabrasVertical = false;
                }
            }
            if (activarPozo == true)
            {

                if (comboBox2.Text == "")
                {
                    MessageBox.Show("Asignar Tamaño");

                }
                else
                {
                    if (((m_Pozo == null) || (e.Button != MouseButtons.Left)))
                        return;
                    m_Pozo.Dx = Convert.ToInt32(comboBox2.Text);
                    m_Pozo.Dy = Convert.ToInt32(comboBox2.Text);
                    m_lstOfPozo.Add(m_Pozo);
                    pictureBox1.Invalidate();
                    activarPozo = false;
                    this.activarRCuaFill = false;
                    this.MoverRCuafill = false;
                    this.MoverAncla = false;
                    this.MoverArbol = false;
                    this.MoverBasura = false;
                    this.MoverCaja = false;
                    this.MoverCancha = false;
                    this.moverCir = false;
                    this.MoverCircle = false;
                    this.MoverEsta = false;
                    this.MoverGota = false;
                    this.MoverLine = false;
                    this.MoverPozo = true;
                    this.MoverRectangulo = false;
                    this.MoverRojo = false;
                    this.MoverTecho = false;
                    this.MoverTri = false;
                    this.MoverZona = false;
                    this.MoverZanja = false;
                    this.moverpalabras = false;
                    MoverRectangulo = false;
                    MoverCircle = false;
                    Moverotros = false;
                    this.MoverBaño = false;
                    this.MoverpalabrasVertical = false;
                }
            }
            if (activarPalabras == true)
            {
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("Asignar Tamaño");

                }
                else
                {

                    if (((m_fillpalabra == null) || (e.Button != MouseButtons.Left)))
                        return;
                    //  m_fillpalabra.TEX = textBox1.Text;
                    // texto.Add(m_fillpalabra.TEX);
                    ///   m_fillpalabra.Draw(g, textBox1.Text, Convert.ToInt32(comboBox1.Text));
                    pointFillpalabra.Add(m_fillpalabra);
                    pictureBox1.Invalidate();
                    this.activarRCuaFill = false;
                    this.MoverRCuafill = false;
                    this.MoverAncla = false;
                    this.MoverArbol = false;
                    this.MoverBasura = false;
                    this.MoverCaja = false;
                    this.MoverCancha = false;
                    this.moverCir = false;
                    this.MoverCircle = false;
                    this.MoverEsta = false;
                    this.MoverGota = false;
                    this.MoverLine = false;
                    this.MoverPozo = false;
                    this.MoverRectangulo = false;
                    this.MoverRojo = false;
                    this.MoverTecho = false;
                    this.MoverTri = false;
                    this.MoverZona = false;
                    this.MoverZanja = false;
                    this.moverpalabras = true;
                    MoverRectangulo = false;
                    MoverCircle = false;
                    Moverotros = false;
                    this.MoverBaño = false;
                    this.MoverpalabrasVertical = false;
                    //  activarPalabras = false;
                }
            }
            if (activarPalabrasVertical == true)
            {
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("Asignar Tamaño");

                }
                else
                {

                    if (((m_fillpalabraVertical == null) || (e.Button != MouseButtons.Left)))
                        return;
                    //  m_fillpalabra.TEX = textBox1.Text;
                    // texto.Add(m_fillpalabra.TEX);
                    ///   m_fillpalabra.Draw(g, textBox1.Text, Convert.ToInt32(comboBox1.Text));
                    pointFillpalabraVertical.Add(m_fillpalabraVertical);
                    pictureBox1.Invalidate();
                    this.activarRCuaFill = false;
                    this.MoverRCuafill = false;
                    this.MoverAncla = false;
                    this.MoverArbol = false;
                    this.MoverBasura = false;
                    this.MoverCaja = false;
                    this.MoverCancha = false;
                    this.moverCir = false;
                    this.MoverCircle = false;
                    this.MoverEsta = false;
                    this.MoverGota = false;
                    this.MoverLine = false;
                    this.MoverPozo = false;
                    this.MoverRectangulo = false;
                    this.MoverRojo = false;
                    this.MoverTecho = false;
                    this.MoverTri = false;
                    this.MoverZona = false;
                    this.MoverZanja = false;
                    this.moverpalabras = false;
                    MoverRectangulo = false;
                    this.MoverBaño = false;
                    MoverCircle = false;
                    this.MoverpalabrasVertical = true;
                    Moverotros = false;
                    //  activarPalabras = false;
                }
            }
            if (activarOtros == true)
            {

                if (comboBox2.Text == "")
                {
                    MessageBox.Show("Asignar Tamaño");

                }
                else
                {
                    if (((m_Otros == null) || (e.Button != MouseButtons.Left)))
                        return;
                    m_Otros.Dx = Convert.ToInt32(comboBox2.Text);
                    m_Otros.Dy = Convert.ToInt32(comboBox2.Text);
                    m_lstOfOtros.Add(m_Otros);
                    contOtros++;
                    pictureBox1.Invalidate();
                    activarOtros = false;
                    this.activarRCuaFill = false;
                    this.MoverRCuafill = false;
                    this.MoverAncla = false;
                    this.MoverArbol = false;
                    this.MoverBasura = false;
                    this.MoverCaja = false;
                    this.MoverCancha = false;
                    this.moverCir = false;
                    this.MoverCircle = false;
                    this.MoverEsta = false;
                    this.MoverGota = false;
                    this.MoverLine = false;
                    this.MoverPozo = false;
                    this.MoverRectangulo = false;
                    this.MoverRojo = false;
                    this.MoverTecho = false;
                    this.MoverTri = false;
                    this.MoverZona = false;
                    this.MoverZanja = false;
                    this.moverpalabras = false;
                    this.MoverBaño = false;
                    MoverRectangulo = false;
                    MoverCircle = false;
                    this.MoverpalabrasVertical = false;
                    Moverotros = true;
                    string nombre = "Otros";
                    Point aux = new Point(e.Location.X, e.Location.Y);
                    CatalogoDispoitivo cat = new CatalogoDispoitivo();
                    cat.addDispositivo(0, nombre, contgota, e.Location.X, e.Location.Y, textBox5.Text, 0);
                }
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {


            // Solamente se ejecutará si se ha pulsado el botón izquierdo del ratón.
            //
            if (activarGoma == true)
            {
                if ((e.Button == MouseButtons.Left))
                {

                    pictureBox1.Capture = true;
                    m_Goma = new Goma();
                    m_Goma.Point1 = e.Location;
                    m_Goma.Cx = e.Location.X;
                    m_Goma.Cy = e.Location.Y;
                }
            }
            if (activarLine == true)
            {
                if ((e.Button == MouseButtons.Left))
                {                                    
                    sensor = "lineas";
                    atras.Push(sensor);
                    pictureBox1.Capture = true;
                    m_line = new Line();                   
                    m_line.Point1 = e.Location;
                    m_line.Point2 = e.Location;
                    m_lstOfLine.Add(m_line);
                }
            }
            if (activarCircle == true)
            {

                if ((e.Button == MouseButtons.Left))
                {
                    sensor = "Circulos";
                    atras.Push(sensor);
                    pictureBox1.Capture = true;
                    m_circle = new Circulo();
                    m_circle.Cx = e.Location.X;
                    m_circle.Cy = e.Location.Y;                 
                    puntero = true;

                }
            }
            if (activarLipiz == true)
            {

            }
            if (activarRectangulo == true)
            {

                if ((e.Button == MouseButtons.Left))
                {
                    pictureBox1.Capture = true;
                    m_rectangulo = new Cuadrado();
                    m_rectangulo.Cx = e.Location.X;
                    m_rectangulo.Cy = e.Location.Y;
                    sensor = "Cuadrado";
                    atras.Push(sensor);
                    m_lstOfRectangulo.Add(m_rectangulo);
                    puntero = true;
                }
            }
            if (activarRCuaFill == true)
            {
                if (e.Button == MouseButtons.Left)
                {

                    pictureBox1.Capture = true;
                    m_cua = new RectanguloFill();
                    m_cua.Cx = e.Location.X;
                    m_cua.Cy = e.Location.Y;
                    puntero = true;

                }
            }
            if (activarCir == true)
            {
                if (e.Button == MouseButtons.Left)
                {
                    pictureBox1.Capture = true;
                    m_cir = new fillCirculo();
                    m_cir.Cx = e.Location.X;
                    m_cir.Cy = e.Location.Y;
                    puntero = true;
                }
            }
            if (activarRojo == true)
            {
                if (e.Button == MouseButtons.Left)
                {
                    pictureBox1.Capture = true;
                    m_rrojo = new RojoRectangulo();
                    m_rrojo.Cx = e.Location.X;
                    m_rrojo.Cy = e.Location.Y;
                    puntero = true;
                }
            }
            if (activarTri == true)
            {
                if (e.Button == MouseButtons.Left)
                {
                    pictureBox1.Capture = true;
                    m_tri = new Triangulo1();
                    m_tri.Cx = e.Location.X;
                    m_tri.Cy = e.Location.Y;
                    puntero = true;
                    //  der = true;

                }

            }


            if (activarancla == true)
            {
                if (e.Button == MouseButtons.Left)
                {
                    pictureBox1.Capture = true;
                    m_ancla = new Anclado();
                    m_ancla.Cx = e.Location.X;
                    m_ancla.Cy = e.Location.Y;
                    puntero = true;
                }

            }
            if (activarGota == true)
            {
                if (e.Button == MouseButtons.Left)
                {
                    pictureBox1.Capture = true;
                    m_gota = new Gota();
                    m_gota.Cx = e.Location.X;
                    m_gota.Cy = e.Location.Y;
                    puntero = true;
                }
            }
            if (activarCaja == true)
            {
                if (e.Button == MouseButtons.Left)
                {
                    pictureBox1.Capture = true;
                    m_caja = new Caja();
                    m_caja.Cx = e.Location.X;
                    m_caja.Cy = e.Location.Y;
                    puntero = true;
                }
            }
            if (activarCacha == true)
            {
                if (e.Button == MouseButtons.Left)
                {
                    pictureBox1.Capture = true;
                    m_cancha = new Cancha();
                    m_cancha.Cx = e.Location.X;
                    m_cancha.Cy = e.Location.Y;
                    puntero = true;
                }
            }
            if (activarBaño == true)
            {
                if (e.Button == MouseButtons.Left)
                {
                    pictureBox1.Capture = true;
                    m_baño = new Baño();
                    m_baño.Cx = e.Location.X;
                    m_baño.Cy = e.Location.Y;
                    puntero = true;
                }
            }
            if (activarEscalera == true)
            {
                if (e.Button == MouseButtons.Left)
                {
                    pictureBox1.Capture = true;
                    m_Escalera = new Escalera();
                    m_Escalera.Cx = e.Location.X;
                    m_Escalera.Cy = e.Location.Y;
                    puntero = true;
                }
            }
            if (activarZanja == true)
            {
                if (e.Button == MouseButtons.Left)
                {
                    pictureBox1.Capture = true;
                    m_Zanja = new Zanja();
                    m_Zanja.Cx = e.Location.X;
                    m_Zanja.Cy = e.Location.Y;
                    puntero = true;
                }
            }
            if (activarBasura == true)
            {
                if (e.Button == MouseButtons.Left)
                {
                    pictureBox1.Capture = true;
                    m_basura = new Basura();
                    m_basura.Cx = e.Location.X;
                    m_basura.Cy = e.Location.Y;
                    puntero = true;
                }
            }
            if (activarEsta == true)
            {
                if (e.Button == MouseButtons.Left)
                {
                    pictureBox1.Capture = true;
                    m_esta = new Estacionamiento();
                    m_esta.Cx = e.Location.X;
                    m_esta.Cy = e.Location.Y;
                    puntero = true;
                }
            }
            if (activarTecho == true)
            {
                if (e.Button == MouseButtons.Left)
                {
                    pictureBox1.Capture = true;
                    m_Techo = new Techado();
                    m_Techo.Cx = e.Location.X;
                    m_Techo.Cy = e.Location.Y;
                    puntero = true;
                }
            }
            if (activarArbol == true)
            {
                if (e.Button == MouseButtons.Left)
                {
                    pictureBox1.Capture = true;
                    m_Arbol = new Arbol();
                    m_Arbol.Cx = e.Location.X;
                    m_Arbol.Cy = e.Location.Y;
                    puntero = true;
                }
            }
            if (activarPozo == true)
            {
                if (e.Button == MouseButtons.Left)
                {
                    pictureBox1.Capture = true;
                    m_Pozo = new Pozo();
                    m_Pozo.Cx = e.Location.X;
                    m_Pozo.Cy = e.Location.Y;
                    puntero = true;
                }
            }
            if (activarZona == true)
            {
                if (e.Button == MouseButtons.Left)
                {
                    pictureBox1.Capture = true;
                    m_Zona = new Zona();
                    m_Zona.Cx = e.Location.X;
                    m_Zona.Cy = e.Location.Y;
                    puntero = true;
                }
            }
            if (activarOtros == true)
            {
                if (e.Button == MouseButtons.Left)
                {
                    pictureBox1.Capture = true;
                    m_Otros = new Otros();
                    m_Otros.Cx = e.Location.X;
                    m_Otros.Cy = e.Location.Y;
                    puntero = true;
                    //  der = true;

                }


            }
            if (marco == true)
            {
                if (e.Button == MouseButtons.Left)
                {
                    pictureBox1.Capture = true;
                    m_marco = new Marco();
                    m_marco.Cx = e.Location.X;
                    m_marco.Cy = e.Location.Y;
                    m_lstOfMarco.Add(m_marco);
                    puntero = true;
                }
            }
            if (activarPalabras == true)
            {
                if (e.Button == MouseButtons.Left)
                {
                    pictureBox1.Capture = true;
                    m_fillpalabra = new Palabras();
                    m_fillpalabra.Point1 = e.Location;
                    //  m_fillpalabra.PointFF = e.Location;
                    m_fillpalabra.TEX = textBox1.Text;
                    m_fillpalabra.F = Convert.ToInt32(comboBox1.Text);
                    texto.Add(m_fillpalabra.TEX);
                    //   pointFillpalabra.Add(m_fillpalabra);
                    puntero = true;

                }

            }
            if (vertical == true)
            {
                if (activarPalabrasVertical == true)
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        pictureBox1.Capture = true;
                        m_fillpalabraVertical = new Palabras();
                        m_fillpalabraVertical.Point1 = e.Location;
                        //  m_fillpalabra.PointFF = e.Location;
                        m_fillpalabraVertical.TEX = textBox1.Text;
                        m_fillpalabraVertical.F = Convert.ToInt32(comboBox1.Text);
                        texto.Add(m_fillpalabraVertical.TEX);
                        puntero = true;

                    }

                }
            }
            pictureBox1.Invalidate();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

            //  g = pictureBox1.CreateGraphics();
            m_lapiz = new Lapiz();
            m_lapizB = new LapizB();

            if (puntero == true && e.Button == MouseButtons.Right && MoverCaja == true)
            {

                // mover el pictureBox con el raton               
                m_caja.Cx += e.X - m_caja.Cx;
                m_caja.Cy += e.Y - m_caja.Cy;
            }
            if (puntero == true && e.Button == MouseButtons.Right && MoverTri == true)
            {

                // mover el pictureBox con el raton               
                m_tri.Cx += e.X - m_tri.Cx;
                m_tri.Cy += e.Y - m_tri.Cy;

            }
            if (puntero == true && e.Button == MouseButtons.Right && Moverotros == true)
            {

                // mover el pictureBox con el raton               
                m_Otros.Cx += e.X - m_Otros.Cx;
                m_Otros.Cy += e.Y - m_Otros.Cy;

            }
            if (puntero == true && e.Button == MouseButtons.Right && MoverArbol == true)
            {

                // mover el pictureBox con el raton               
                m_Arbol.Cx += e.X - m_Arbol.Cx;
                m_Arbol.Cy += e.Y - m_Arbol.Cy;

            }
            if (puntero == true && e.Button == MouseButtons.Right && MoverRojo == true)
            {

                // mover el pictureBox con el raton               
                m_rrojo.Cx += e.X - m_rrojo.Cx;
                m_rrojo.Cy += e.Y - m_rrojo.Cy;
            }
            if (puntero == true && e.Button == MouseButtons.Right && MoverAncla == true)
            {

                // mover el pictureBox con el raton               
                m_ancla.Cx += e.X - m_ancla.Cx;
                m_ancla.Cy += e.Y - m_ancla.Cy;
            }
            if (puntero == true && e.Button == MouseButtons.Right && MoverRCuafill == true)
            {

                // mover el pictureBox con el raton               
                m_cua.Cx += e.X - m_cua.Cx;
                m_cua.Cy += e.Y - m_cua.Cy;
            }
            if (puntero == true && e.Button == MouseButtons.Right && MoverGota == true)
            {

                // mover el pictureBox con el raton               
                m_gota.Cx += e.X - m_gota.Cx;
                m_gota.Cy += e.Y - m_gota.Cy;
            }
            if (puntero == true && e.Button == MouseButtons.Right && MoverPozo == true)
            {

                // mover el pictureBox con el raton               
                m_Pozo.Cx += e.X - m_Pozo.Cx;
                m_Pozo.Cy += e.Y - m_Pozo.Cy;
            }
            if (puntero == true && e.Button == MouseButtons.Right && moverCir == true)
            {

                // mover el pictureBox con el raton               
                m_cir.Cx += e.X - m_cir.Cx;
                m_cir.Cy += e.Y - m_cir.Cy;
            }
            if (puntero == true && e.Button == MouseButtons.Right && MoverCancha == true)
            {

                // mover el pictureBox con el raton               
                m_cancha.Cx += e.X - m_cancha.Cx;
                m_cancha.Cy += e.Y - m_cancha.Cy;
            }
            if (puntero == true && e.Button == MouseButtons.Right && MoverEscalera == true)
            {

                // mover el pictureBox con el raton               
                m_Escalera.Cx += e.X - m_Escalera.Cx;
                m_Escalera.Cy += e.Y - m_Escalera.Cy;
            }
            if (puntero == true && e.Button == MouseButtons.Right && MoverBasura == true)
            {

                // mover el pictureBox con el raton               
                m_basura.Cx += e.X - m_basura.Cx;
                m_basura.Cy += e.Y - m_basura.Cy;
            }
            if (puntero == true && e.Button == MouseButtons.Right && MoverEsta == true)
            {

                // mover el pictureBox con el raton               
                m_esta.Cx += e.X - m_esta.Cx;
                m_esta.Cy += e.Y - m_esta.Cy;
            }
            if (puntero == true && e.Button == MouseButtons.Right && MoverTecho == true)
            {

                // mover el pictureBox con el raton               
                m_Techo.Cx += e.X - m_Techo.Cx;
                m_Techo.Cy += e.Y - m_Techo.Cy;
            }
            if (puntero == true && e.Button == MouseButtons.Right && MoverBaño == true)
            {

                // mover el pictureBox con el raton               
                m_baño.Cx += e.X - m_baño.Cx;
                m_baño.Cy += e.Y - m_baño.Cy;
            }
            if (puntero == true && e.Button == MouseButtons.Right && MoverZona == true)
            {

                // mover el pictureBox con el raton               
                m_Zona.Cx += e.X - m_Zona.Cx;
                m_Zona.Cy += e.Y - m_Zona.Cy;
            }
            if (puntero == true && e.Button == MouseButtons.Right && MoverZanja == true)
            {

                // mover el pictureBox con el raton               
                m_Zanja.Cx += e.X - m_Zanja.Cx;
                m_Zanja.Cy += e.Y - m_Zanja.Cy;
            }

            if (puntero == true && e.Button == MouseButtons.Right && moverpalabras == true)
            {

                // mover el pictureBox con el raton               
                m_fillpalabra.Cx += e.X - m_fillpalabra.Cx;
                m_fillpalabra.Cy += e.Y - m_fillpalabra.Cy;
            }
            if (puntero == true && e.Button == MouseButtons.Right && MoverpalabrasVertical == true)
            {

                // mover el pictureBox con el raton               
                m_fillpalabraVertical.Cx += e.X - m_fillpalabraVertical.Cx;
                m_fillpalabraVertical.Cy += e.Y - m_fillpalabraVertical.Cy;
            }
            if (puntero == true && e.Button == MouseButtons.Right && MoverRectangulo == true)
            {

                // mover el pictureBox con el raton               
                m_rectangulo.Cx += e.X - m_rectangulo.Cx;
                m_rectangulo.Cy += e.Y - m_rectangulo.Cy;
            }
            if (puntero == true && e.Button == MouseButtons.Right && MoverCircle == true)
            {

                // mover el pictureBox con el raton               
                m_circle.Cx += e.X - m_circle.Cx;
                m_circle.Cy += e.Y - m_circle.Cy;
            }

            if (activarLine == true)
            {
                if (((m_line == null) || (!pictureBox1.Capture) || (e.Button != MouseButtons.Left)))
                    return;


                m_line.Point2 = e.Location;
                this.pictureBox1.Invalidate();
                //     m_lstOfLine.Add(m_line);
                this.pictureBox1.Invalidate();
                this.MoverRCuafill = false;
                this.MoverAncla = false;
                this.MoverArbol = false;
                this.MoverBasura = false;
                this.MoverCaja = false;
                this.MoverCancha = false;
                this.moverCir = false;
                this.MoverCircle = false;
                this.MoverEsta = false;
                this.MoverGota = false;
                this.MoverLine = false;
                this.MoverPozo = false;
                this.MoverRectangulo = false;
                this.MoverRojo = false;
                this.MoverTecho = false;
                this.MoverTri = false;
                this.MoverZona = false;
                this.MoverZanja = false;
                this.moverpalabras = false;
                MoverRectangulo = false;
                MoverCircle = false;
                this.MoverEscalera = false;
                this.MoverBaño = false;
            }
            if (activarCircle == true)
            {
                if (((m_circle == null) || (!pictureBox1.Capture) || (e.Button != MouseButtons.Left)))
                    return;

                m_circle.Dx = e.Location.X - m_circle.Cx;
                m_circle.Dy = e.Location.Y - m_circle.Cy;
                //       m_lstOfCircle.Add(m_circle);
                this.pictureBox1.Invalidate();
                this.MoverRCuafill = false;
                this.MoverAncla = false;
                this.MoverArbol = false;
                this.MoverBasura = false;
                this.MoverCaja = false;
                this.MoverCancha = false;
                this.moverCir = false;
                this.MoverCircle = true;
                this.MoverEsta = false;
                this.MoverGota = false;
                this.MoverLine = false;
                this.MoverPozo = false;
                this.MoverRectangulo = false;
                this.MoverRojo = false;
                this.MoverTecho = false;
                this.MoverTri = false;
                this.MoverZona = false;
                this.MoverZanja = false;
                this.moverpalabras = false;
                MoverRectangulo = false;
                MoverCircle = true;
                this.MoverEscalera = false;
                this.MoverBaño = false;
            }
            if (activarLipiz == true)
            {
                if (((m_lapizB == null) || (!pictureBox1.Capture) || (e.Button != MouseButtons.Left)))
                    return;
                m_lapizB.Cx = e.Location.X;
                m_lapizB.Cy = e.Location.Y;
                m_lapizB.Dx = 100;
                m_lapizB.Dy = 100;
                m_lstOfLapizB.Add(m_lapizB);
                this.pictureBox1.Invalidate();
                this.MoverRCuafill = false;
                this.MoverAncla = false;
                this.MoverArbol = false;
                this.MoverBasura = false;
                this.MoverCaja = false;
                this.MoverCancha = false;
                this.moverCir = false;
                this.MoverCircle = false;
                this.MoverEsta = false;
                this.MoverGota = false;
                this.MoverLine = false;
                this.MoverPozo = false;
                this.MoverRectangulo = false;
                this.MoverRojo = false;
                this.MoverTecho = false;
                this.MoverTri = false;
                this.MoverZona = false;
                this.MoverZanja = false;
                this.moverpalabras = false;
                MoverRectangulo = false;
                MoverCircle = false;
                this.MoverEscalera = false;
                this.MoverBaño = false;
            }


            if (activarGoma == true)
            {
                if (((m_Goma == null) || (!pictureBox1.Capture) || (e.Button != MouseButtons.Left)))
                    return;
                m_Goma.Dx = e.Location.X - m_Goma.Cx;
                m_Goma.Dy = e.Location.Y - m_Goma.Cy;
                m_lstOfGoma.Add(m_Goma);
                this.pictureBox1.Invalidate();
                this.MoverRCuafill = false;
                this.MoverAncla = false;
                this.MoverArbol = false;
                this.MoverBasura = false;
                this.MoverCaja = false;
                this.MoverCancha = false;
                this.moverCir = false;
                this.MoverCircle = false;
                this.MoverEsta = false;
                this.MoverGota = true;
                this.MoverLine = false;
                this.MoverPozo = false;
                this.MoverRectangulo = false;
                this.MoverRojo = false;
                this.MoverTecho = false;
                this.MoverTri = false;
                this.MoverZona = false;
                this.MoverZanja = false;
                this.moverpalabras = false;
                MoverRectangulo = false;    
                MoverCircle = false;
                this.MoverEscalera = false;
                this.MoverBaño = false;
            }
            if (activarRectangulo == true)
            {
                if (((m_rectangulo == null) || (!pictureBox1.Capture) || (e.Button != MouseButtons.Left)))
                    return;
                m_rectangulo.Dx = e.Location.X - m_rectangulo.Cx;
                m_rectangulo.Dy = e.Location.Y - m_rectangulo.Cy;
                //  m_lstOfRectangulo.Add(m_rectangulo);
                this.pictureBox1.Invalidate();
                this.MoverRCuafill = false;
                this.MoverAncla = false;
                this.MoverArbol = false;
                this.MoverBasura = false;
                this.MoverCaja = false;
                this.MoverCancha = false;
                this.moverCir = false;
                this.MoverCircle = false;
                this.MoverEsta = false;
                this.MoverGota = false;
                this.MoverLine = false;
                this.MoverPozo = false;
                this.MoverRectangulo = true;
                this.MoverRojo = false;
                this.MoverTecho = false;
                this.MoverTri = false;
                this.MoverZona = false;
                this.MoverZanja = false;
                this.moverpalabras = false;
                MoverRectangulo = true;
                MoverCircle = false;
                this.MoverEscalera = false;
                this.MoverBaño = false;
            }
            if (activarCacha == true)
            {
                if (((m_cancha == null) || (!pictureBox1.Capture) || (e.Button != MouseButtons.Left)))
                    return;
                m_cancha.Dx = e.Location.X - m_cancha.Cx;
                m_cancha.Dy = e.Location.Y - m_cancha.Cy;
                //m_lstOfCancha.Add(m_cancha);
                MoverCancha = true;
                this.pictureBox1.Invalidate();
                this.MoverRCuafill = false;
                this.MoverAncla = false;
                this.MoverArbol = false;
                this.MoverBasura = false;
                this.MoverCaja = false;
                this.MoverCancha = true;
                this.moverCir = false;
                this.MoverCircle = false;
                this.MoverEsta = false;
                this.MoverGota = false;
                this.MoverLine = false;
                this.MoverPozo = false;
                this.MoverRectangulo = false;
                this.MoverRojo = false;
                this.MoverTecho = false;
                this.MoverTri = false;
                this.MoverZona = false;
                this.MoverZanja = false;
                this.moverpalabras = false;
                MoverRectangulo = false;
                MoverCircle = false;
                this.MoverEscalera = false;
                this.MoverBaño = false;
            }
            if (activarEscalera == true)
            {
                if (((m_Escalera == null) || (!pictureBox1.Capture) || (e.Button != MouseButtons.Left)))
                    return;
                m_Escalera.Dx = e.Location.X - m_Escalera.Cx;
                m_Escalera.Dy = e.Location.Y - m_Escalera.Cy;
               // m_lstOfEscalera.Add(m_Escalera);

                this.MoverEscalera = true;
                this.pictureBox1.Invalidate();
                this.MoverRCuafill = false;
                this.MoverAncla = false;
                this.MoverArbol = false;
                this.MoverBasura = false;
                this.MoverCaja = false;
                this.MoverCancha = false;
                this.moverCir = false;
                this.MoverCircle = false;
                this.MoverEsta = false;
                this.MoverGota = false;
                this.MoverLine = false;
                this.MoverPozo = false;
                this.MoverRectangulo = false;
                this.MoverRojo = false;
                this.MoverTecho = false;
                this.MoverTri = false;
                this.MoverZona = false;
                this.MoverZanja = false;
                this.moverpalabras = false;
                MoverRectangulo = false;
                MoverCircle = false;
                this.MoverBaño = false;
            }
            if (activarZanja == true)
            {
                if (((m_Zanja == null) || (!pictureBox1.Capture) || (e.Button != MouseButtons.Left)))
                    return;
                m_Zanja.Dx = e.Location.X - m_Zanja.Cx;
                m_Zanja.Dy = e.Location.Y - m_Zanja.Cy;
              //  m_lstOfZanja.Add(m_Zanja);
                this.pictureBox1.Invalidate();
                this.MoverRCuafill = false;
                this.MoverAncla = false;
                this.MoverArbol = false;
                this.MoverBasura = false;
                this.MoverCaja = false;
                this.MoverCancha = false;
                this.moverCir = false;
                this.MoverCircle = false;
                this.MoverEsta = false;
                this.MoverGota = false;
                this.MoverLine = false;
                this.MoverPozo = false;
                this.MoverRectangulo = false;
                this.MoverRojo = false;
                this.MoverTecho = false;
                this.MoverTri = false;
                this.MoverZona = false;
                this.MoverZanja = true;
                this.moverpalabras = false;
                MoverRectangulo = false;
                MoverCircle = false;
                this.MoverBaño = false;
                this.MoverEscalera = false;
            }
            if (activarBasura == true)
            {
                if (((m_basura == null) || (!pictureBox1.Capture) || (e.Button != MouseButtons.Left)))
                    return;
                m_basura.Dx = e.Location.X - m_basura.Cx;
                m_basura.Dy = e.Location.Y - m_basura.Cy;
              //  m_lstOfBasura.Add(m_basura);
                this.pictureBox1.Invalidate();
                MoverBasura = true;
                this.MoverRCuafill = false;
                this.MoverAncla = false;
                this.MoverArbol = false;
                this.MoverBasura = true;
                this.MoverCaja = false;
                this.MoverCancha = false;
                this.moverCir = false;
                this.MoverCircle = false;
                this.MoverEsta = false;
                this.MoverGota = false;
                this.MoverLine = false;
                this.MoverPozo = false;
                this.MoverRectangulo = false;
                this.MoverRojo = false;
                this.MoverTecho = false;
                this.MoverTri = false;
                this.MoverZona = false;
                this.MoverZanja = false;
                this.moverpalabras = false;
                this.MoverBaño = false;
                MoverRectangulo = false;
                MoverCircle = false;
                this.MoverEscalera = false;
            }
            if (activarEsta == true)
            {
                if (((m_esta == null) || (!pictureBox1.Capture) || (e.Button != MouseButtons.Left)))
                    return;
                m_esta.Dx = e.Location.X - m_esta.Cx;
                m_esta.Dy = e.Location.Y - m_esta.Cy;
             //   m_lstOfEsta.Add(m_esta);
                this.pictureBox1.Invalidate();
                MoverEsta = true;
                this.MoverRCuafill = false;
                this.MoverAncla = false;
                this.MoverArbol = false;
                this.MoverBasura = false;
                this.MoverCaja = false;
                this.MoverCancha = false;
                this.moverCir = false;
                this.MoverCircle = false;
                this.MoverEsta = true;
                this.MoverGota = false;
                this.MoverLine = false;
                this.MoverPozo = false;
                this.MoverRectangulo = false;
                this.MoverRojo = false;
                this.MoverTecho = false;
                this.MoverTri = false;
                this.MoverZona = false;
                this.MoverZanja = false;
                this.moverpalabras = false;
                MoverRectangulo = false;
                MoverCircle = false;
                this.MoverBaño = false;
                this.MoverEscalera = false;
            }
            if (activarTecho == true)
            {
                if (((m_Techo == null) || (!pictureBox1.Capture) || (e.Button != MouseButtons.Left)))
                    return;
                m_Techo.Dx = e.Location.X - m_Techo.Cx;
                m_Techo.Dy = e.Location.Y - m_Techo.Cy;
              //  m_lstOfTecho.Add(m_Techo);
                this.pictureBox1.Invalidate();
                this.MoverTecho = true;
                this.MoverRCuafill = false;
                this.MoverAncla = false;
                this.MoverArbol = false;
                this.MoverBasura = false;
                this.MoverCaja = false;
                this.MoverCancha = false;
                this.moverCir = false;
                this.MoverCircle = false;
                this.MoverEsta = false;
                this.MoverGota = false;
                this.MoverLine = false;
                this.MoverPozo = false;
                this.MoverRectangulo = false;
                this.MoverRojo = false;
                this.MoverTecho = true;
                this.MoverTri = false;
                this.MoverZona = false;
                this.MoverZanja = false;
                this.moverpalabras = false;
                MoverRectangulo = false;
                MoverCircle = false;
                this.MoverBaño = false;
                this.MoverEscalera = false;
            }
            if (activarZona == true)
            {
                if (((m_Zona == null) || (!pictureBox1.Capture) || (e.Button != MouseButtons.Left)))
                    return;
                m_Zona.Dx = e.Location.X - m_Zona.Cx;
                m_Zona.Dy = e.Location.Y - m_Zona.Cy;
               // m_lstOfZona.Add(m_Zona);
                this.pictureBox1.Invalidate();
                this.MoverRCuafill = false;
                this.MoverAncla = false;
                this.MoverArbol = false;
                this.MoverBasura = false;
                this.MoverCaja = false;
                this.MoverCancha = false;
                this.moverCir = false;
                this.MoverCircle = false;
                this.MoverEsta = false;
                this.MoverGota = false;
                this.MoverLine = false;
                this.MoverPozo = false;
                this.MoverRectangulo = false;
                this.MoverRojo = false;
                this.MoverTecho = false;
                this.MoverTri = false;
                this.MoverZona = true;
                this.MoverZanja = false;
                this.moverpalabras = false;
                MoverRectangulo = false;
                MoverCircle = false;
                this.MoverBaño = false;
                this.MoverEscalera = false;
            }
            if (activarBaño == true)
            {
                if (((m_baño == null) || (!pictureBox1.Capture) || (e.Button != MouseButtons.Left)))
                    return;
                m_baño.Dx = e.Location.X - m_baño.Cx;
                m_baño.Dy = e.Location.Y - m_baño.Cy;
              //  m_lstOfBaño.Add(m_baño);
                MoverBaño = true;
                this.pictureBox1.Invalidate();
                this.MoverRCuafill = false;
                this.MoverAncla = false;
                this.MoverArbol = false;
                this.MoverBasura = false;
                this.MoverCaja = false;
                this.MoverCancha = false;
                this.moverCir = false;
                this.MoverCircle = false;
                this.MoverEsta = false;
                this.MoverGota = false;
                this.MoverLine = false;
                this.MoverPozo = false;
                this.MoverRectangulo = false;
                this.MoverRojo = false;
                this.MoverTecho = false;
                this.MoverTri = false;
                this.MoverZona = false;
                this.MoverZanja = false;
                this.moverpalabras = false;
                this.MoverBaño = true;
                MoverRectangulo = false;
                MoverCircle = false;
                this.MoverEscalera = false;
            }
            if (marco == true)
            {
                if (((m_marco == null) || (!pictureBox1.Capture) || (e.Button != MouseButtons.Left)))
                    return;
                m_marco.Dx = e.Location.X - m_marco.Cx;
                m_marco.Dy = e.Location.Y - m_marco.Cy;
                //  m_lstOfBaño.Add(m_baño);
              
                this.pictureBox1.Invalidate();
                this.MoverRCuafill = false;
                this.MoverAncla = false;
                this.MoverArbol = false;
                this.MoverBasura = false;
                this.MoverCaja = false;
                this.MoverCancha = false;
                this.moverCir = false;
                this.MoverCircle = false;
                this.MoverEsta = false;
                this.MoverGota = false;
                this.MoverLine = false;
                this.MoverPozo = false;
                this.MoverRectangulo = false;
                this.MoverRojo = false;
                this.MoverTecho = false;
                this.MoverTri = false;
                this.MoverZona = false;
                this.MoverZanja = false;
                this.moverpalabras = false;
                this.MoverBaño = false;
                MoverRectangulo = false;
                MoverCircle = false;
                this.MoverEscalera = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            activarpaint = true;
            Figuras.Enabled = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (activarCacha == true) 
            {
                if (((m_cancha == null) || (!pictureBox1.Capture) || (e.Button != MouseButtons.Left)))
                    return;
                m_cancha.Dx = e.Location.X - m_cancha.Cx;
                m_cancha.Dy = e.Location.Y - m_cancha.Cy;
                m_lstOfCancha.Add(m_cancha);
            }
            if (activarEscalera == true)
            {
                if (((m_Escalera == null) || (!pictureBox1.Capture) || (e.Button != MouseButtons.Left)))
                    return;
                m_Escalera.Dx = e.Location.X - m_Escalera.Cx;
                m_Escalera.Dy = e.Location.Y - m_Escalera.Cy;
                m_lstOfEscalera.Add(m_Escalera);
            }
            if (activarZanja == true)
            {
                if (((m_Zanja == null) || (!pictureBox1.Capture) || (e.Button != MouseButtons.Left)))
                    return;
                m_Zanja.Dx = e.Location.X - m_Zanja.Cx;
                m_Zanja.Dy = e.Location.Y - m_Zanja.Cy;
                m_lstOfZanja.Add(m_Zanja);
            }
            if (activarBasura == true)
            {
                if (((m_basura == null) || (!pictureBox1.Capture) || (e.Button != MouseButtons.Left)))
                    return;
                m_basura.Dx = e.Location.X - m_basura.Cx;
                m_basura.Dy = e.Location.Y - m_basura.Cy;
                m_lstOfBasura.Add(m_basura);
            }
            if (activarEsta == true)
            {
                if (((m_esta == null) || (!pictureBox1.Capture) || (e.Button != MouseButtons.Left)))
                    return;
                m_esta.Dx = e.Location.X - m_esta.Cx;
                m_esta.Dy = e.Location.Y - m_esta.Cy;
                m_lstOfEsta.Add(m_esta);
            }
            if (activarTecho == true)
            {
                if (((m_Techo == null) || (!pictureBox1.Capture) || (e.Button != MouseButtons.Left)))
                    return;
                m_Techo.Dx = e.Location.X - m_Techo.Cx;
                m_Techo.Dy = e.Location.Y - m_Techo.Cy;
                m_lstOfTecho.Add(m_Techo);
            }
            if (activarZona == true)
            {
                if (((m_Zona == null) || (!pictureBox1.Capture) || (e.Button != MouseButtons.Left)))
                    return;
                m_Zona.Dx = e.Location.X - m_Zona.Cx;
                m_Zona.Dy = e.Location.Y - m_Zona.Cy;
                m_lstOfZona.Add(m_Zona);
            }
            if (activarBaño == true)
            {
                if (((m_baño == null) || (!pictureBox1.Capture) || (e.Button != MouseButtons.Left)))
                    return;
                m_baño.Dx = e.Location.X - m_baño.Cx;
                m_baño.Dy = e.Location.Y - m_baño.Cy;
                m_lstOfBaño.Add(m_baño);
            }
            if (marco == true)
            {
                if (((m_marco == null) || (!pictureBox1.Capture) || (e.Button != MouseButtons.Left)))
                    return;
                m_marco.Dx = e.Location.X - m_marco.Cx;
                m_marco.Dy = e.Location.Y - m_marco.Cy;
                m_lstOfMarco.Add(m_marco);
            }
            

        }

        private void button8_Click(object sender, EventArgs e)
        {
            marco = true;
            activarRCuaFill = false;
            activarLipiz = false;
            activarLine = false;
            activarCircle = false;
            activarRectangulo = false;
            activarCir = false;
            activarRojo = false;
            activarTri = false;
            activarancla = false;
            activarGota = false;
            activarCaja = false;
            activarCacha = false;
            activarBasura = false;
            activarEsta = false;
            activarTecho = false;
            activarArbol = false;
            activarPozo = false;
            activarZona = false;
            activarPalabras = false;
            activarGoma = false;
            activarZanja = false;
            activarPalabrasVertical = false;
            activarOtros = false;
            activarEscalera = false;
            activarBaño = false;
        }

      
        private void PlanosEsam_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (atras.Count > 0)
            {
                if (atras.Count > 0)
                {
                    if (atras.Peek() == "linea")
                    {
                        atras.Pop();
                        m_lstOfLine.RemoveAt(m_lstOfLine.Count - 1);
                        pictureBox1.Invalidate();

                    }
                }
                if (atras.Count > 0)
                {
                    if (atras.Peek() == "Cuadrado")
                    {
                        atras.Pop();
                        m_lstOfRectangulo.RemoveAt(m_lstOfRectangulo.Count - 1);
                        pictureBox1.Invalidate();

                    }
                }
                if (atras.Count > 0)
                {
                    if (atras.Peek() == "Circulos")
                    {
                        atras.Pop();
                        m_lstOfCircle.RemoveAt(m_lstOfCircle.Count - 1);
                        pictureBox1.Invalidate();

                    }
                }
                if (atras.Count > 0)
                {
                    if (atras.Peek() == "Zona Basureros")
                    {
                        atras.Pop();
                        m_lstOfBasura.RemoveAt(m_lstOfBasura.Count - 1);
                        pictureBox1.Invalidate();

                    }
                }
                if (atras.Count > 0)
                {
                    if (atras.Peek() == "Árbol")
                    {
                        atras.Pop();
                        m_lstOfArbol.RemoveAt(m_lstOfArbol.Count - 1);
                        pictureBox1.Invalidate();
                    }
                }
                if (atras.Count > 0)
                {
                    if (atras.Peek() == "Cancha")
                    {
                        atras.Pop();
                        m_lstOfCancha.RemoveAt(m_lstOfCancha.Count - 1);
                        pictureBox1.Invalidate();

                    }
                }
                if (atras.Count > 0)
                {
                    if (atras.Peek() == "Palabras")
                    {
                        atras.Pop();
                        pointFillpalabra.RemoveAt(pointFillpalabra.Count - 1);
                        pictureBox1.Invalidate();

                    }
                }
                if (atras.Count > 0)
                {
                    if (atras.Peek() == "Palabras Vertical")
                    {
                        atras.Pop();
                        pointFillpalabraVertical.RemoveAt(pointFillpalabraVertical.Count - 1);
                        pictureBox1.Invalidate();

                    }
                }
                if (atras.Count > 0)
                {
                    if (atras.Peek() == "Estacionamiento")
                    {
                        atras.Pop();
                        m_lstOfEsta.RemoveAt(m_lstOfEsta.Count - 1);
                        pictureBox1.Invalidate();

                    }
                }
                if (atras.Count > 0)
                {
                    if (atras.Peek() == "Baño")
                    {
                        atras.Pop();
                        m_lstOfBaño.RemoveAt(m_lstOfBaño.Count - 1);
                        pictureBox1.Invalidate();

                    }
                }
                if (atras.Count > 0)
                {
                    if (atras.Peek() == "Escaleras")
                    {
                        atras.Pop();
                        m_lstOfEscalera.RemoveAt(m_lstOfEscalera.Count - 1);
                        pictureBox1.Invalidate();

                    } 
                }
            }
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ConsumoBoton = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

    }
}
