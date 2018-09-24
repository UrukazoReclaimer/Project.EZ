using iTextSharp.text;
using iTextSharp.text.pdf;
using Project.BussinessRules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Esampm
{
    public partial class PlanosEsamV2cs : Form
    {
        Boolean automatico = false;
        System.Drawing.Font myFont = new System.Drawing.Font("Arial", 8);
        Graphics g;
        string figura;
        int posx = 0;
        int posy = 0;
        private List<Line> m_lstOfLine = new List<Line>();
        private Line m_line;
        private List<Circulo> m_lstOfCircle = new List<Circulo>();
        private Circulo m_circle;
        private List<Cuadrado> m_lstOfRectangulo = new List<Cuadrado>();
        private Cuadrado m_rectangulo;
        private List<Lapiz> m_lstOfLapiz = new List<Lapiz>();
        private Lapiz m_lapiz;
        private List<Goma> m_lstOfGoma = new List<Goma>();
        private Goma m_Goma;
        private List<RectanguloFill> m_lstOfCua = new List<RectanguloFill>();
        private RectanguloFill m_cua;
        private List<fillCirculo> m_lstOfCir = new List<fillCirculo>();
        private fillCirculo m_cir;
        private List<RojoRectangulo> m_lstOfRRojo = new List<RojoRectangulo>();
        private RojoRectangulo m_rrojo;
        private List<Triangulo1> m_lstOfTri = new List<Triangulo1>();
        private Triangulo1 m_tri;
        private List<Anclado> m_lstOfancla = new List<Anclado>();
        private Anclado m_ancla;
        private List<Gota> m_lstOfGota = new List<Gota>();
        private Gota m_gota;
        private List<Otros> m_lstOfOtros = new List<Otros>();
        private Otros m_Otros;
        private List<Caja> m_lstOfCaja = new List<Caja>();
        private Caja m_caja;
        private List<Insecto> m_lstOfInsecto = new List<Insecto>();
        private Insecto m_insecto;
        private List<Basura> m_lstOfBasura = new List<Basura>();
        private Basura m_Basura;
        private List<Cancha> m_lstOfCancha = new List<Cancha>();
        private Cancha m_cancha;
        private List<Rosa> m_lstOfRosa = new List<Rosa>();
        private Rosa m_rosa;
        private List<Estacionamiento> m_lstOfEsta = new List<Estacionamiento>();
        private Estacionamiento m_esta;
        private List<Zona> m_lstOfZona = new List<Zona>();
        private Zona m_Zona;
        private List<Estanque> m_lstOfestanque = new List<Estanque>();
        private Estanque m_estanque;
        private List<Baño> m_lstOfBaño = new List<Baño>();
        private Baño m_baño;
        private List<Zanja> m_lstOfZanja = new List<Zanja>();
        private Zanja m_Zanja;
        private List<Escalera> m_lstOfEscalera = new List<Escalera>();
        private Escalera m_Escalera;
        private List<Techado> m_lstOfTecho = new List<Techado>();
        private Techado m_Techo;
        private List<Arbol> m_lstOfArbol = new List<Arbol>();
        private Arbol m_Arbol;
        private List<Pozo> m_lstOfPozo = new List<Pozo>();
        private Pozo m_Pozo;
        List<Palabras> listpalabra = new List<Palabras>();
        private Palabras m_palabra = new Palabras();
        int conttri = 0;
        int contcri = 0;
        int controjo = 0;
        int concua = 0;
        int contancla = 0;
        int contgota = 0;
        int contcaja = 0;
        int contOtros = 0;
        int continsecto = 0;
        Boolean refeescar = false;
        Boolean Establecer = false;
        Boolean cargado = false;

        OpenFileDialog o = new OpenFileDialog();
        bool cargar = false;
        int wx = 0;
        int wy = 0;
        private PlanosEsamV2cs instance;
        System.Drawing.Image imgOriginal;
        public PlanosEsamV2cs()
        {
            InitializeComponent();
           
            panel2.Visible = false;
            instance = this;
            catalogoTecnico tunits2 = new catalogoTecnico();
            List<Project.BussinessRules.Tecnico> tec2 = tunits2.obtenertec();
            this.comboBox1.DataSource = tec2;
            this.comboBox1.DisplayMember = "nombre";
            this.comboBox1.ValueMember = "cod";

            CatalogoCliente cunitsbu = new CatalogoCliente();
            List<cliente> unibu = cunitsbu.getclierut();
            this.comboBox2.DataSource = unibu;
            this.comboBox2.DisplayMember = "nombre";
            this.comboBox2.ValueMember = "rut";
        }
        private void PlanosEsamV2cs_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            g = pictureBox1.CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            panel1.Visible = false;
            panel2.Visible = true;
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            CatalogoCliente cunits2 = new CatalogoCliente();
            List<cliente> uni2 = cunits2.getclienrutfornom(comboBox2.Text);
            this.comboBox3.DataSource = uni2;
            this.comboBox3.DisplayMember = "rut";
            this.comboBox3.ValueMember = "rut";

            CatalogoCliente ca = new CatalogoCliente();
            List<cliente> la = ca.getclientcodfornom(comboBox2.Text);
            this.comboBox4.DataSource = la;
            this.comboBox4.DisplayMember = "cod";

            this.comboBox4.ValueMember = "cod";

            if (comboBox3.Text != "")
            {
                buttonEstablecer.Enabled = true;

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

            if (figura == "Lineas")
            {
                if ((e.Button == MouseButtons.Left))
                {
                    pictureBox1.Capture = true;
                    m_line = new Line();
                    m_line.Point1 = e.Location;
                    this.Invalidate();
                }
            }

            if (figura == "Lapiz")
            {
                if ((e.Button == MouseButtons.Left))
                {
                    pictureBox1.Capture = true;
                    m_lapiz = new Lapiz();
                    m_lapiz.Cx = e.Location.X;
                    this.Invalidate();
                }
            }

            if (figura == "Goma")
            {
                if ((e.Button == MouseButtons.Left))
                {
                    pictureBox1.Capture = true;
                    m_Goma = new Goma();
                    m_Goma.Cx = e.Location.X;
                    this.Invalidate();
                }
            }
            if (figura == "Circulo")
            {
                if ((e.Button == MouseButtons.Left))
                {
                    pictureBox1.Capture = true;
                    m_circle = new Circulo();
                    m_circle.Cx = e.Location.X;
                    m_circle.Cy = e.Location.Y;
                    this.Invalidate();
                }
            }
            if (figura == "Cuadrado")
            {
                if ((e.Button == MouseButtons.Left))
                {
                    pictureBox1.Capture = true;
                    m_rectangulo = new Cuadrado();
                    m_rectangulo.Cx = e.Location.X;
                    m_rectangulo.Cy = e.Location.Y;
                    this.Invalidate();
                }
            }
            if (figura == "Caja")
            {

                if ((e.Button == MouseButtons.Left))
                {
                    pictureBox1.Capture = true;
                    m_cua = new RectanguloFill();
                    m_cua.Cx = e.Location.X;
                    m_cua.Cy = e.Location.Y;
                    this.Invalidate();
                }
            }
            if (figura == "Cebadero")
            {

                if ((e.Button == MouseButtons.Left))
                {
                    pictureBox1.Capture = true;
                    m_cir = new fillCirculo();
                    m_cir.Cx = e.Location.X;
                    m_cir.Cy = e.Location.Y;
                    this.Invalidate();
                }
            }
            if (figura == "Fly Out")
            {

                if ((e.Button == MouseButtons.Left))
                {
                    pictureBox1.Capture = true;
                    m_rrojo = new RojoRectangulo();
                    m_rrojo.Cx = e.Location.X;
                    m_rrojo.Cy = e.Location.Y;
                    this.Invalidate();
                }
            }
            if (figura == "Pejagosa")
            {

                if ((e.Button == MouseButtons.Left))
                {
                    pictureBox1.Capture = true;
                    m_tri = new Triangulo1();
                    m_tri.Cx = e.Location.X;
                    m_tri.Cy = e.Location.Y;
                    this.Invalidate();
                }
            }
            if (figura == "Anclado")
            {

                if ((e.Button == MouseButtons.Left))
                {
                    pictureBox1.Capture = true;
                    m_ancla = new Anclado();
                    m_ancla.Cx = e.Location.X;
                    m_ancla.Cy = e.Location.Y;
                    this.Invalidate();
                }
            }
            if (figura == "Agua")
            {

                if ((e.Button == MouseButtons.Left))
                {
                    pictureBox1.Capture = true;
                    m_gota = new Gota();
                    m_gota.Cx = e.Location.X;
                    m_gota.Cy = e.Location.Y;
                    this.Invalidate();
                }
            }
            if (figura == "Otros")
            {

                if ((e.Button == MouseButtons.Left))
                {
                    pictureBox1.Capture = true;
                    m_Otros = new Otros();
                    m_Otros.Cx = e.Location.X;
                    m_Otros.Cy = e.Location.Y;
                    this.Invalidate();
                }
            }
            if (figura == "Caja Circulo")
            {

                if ((e.Button == MouseButtons.Left))
                {
                    pictureBox1.Capture = true;
                    m_caja = new Caja();
                    m_caja.Cx = e.Location.X;
                    m_caja.Cy = e.Location.Y;
                    this.Invalidate();
                }
            }
            if (figura == "Insecto")
            {

                if ((e.Button == MouseButtons.Left))
                {
                    pictureBox1.Capture = true;
                    m_insecto = new Insecto();
                    m_insecto.Cx = e.Location.X;
                    m_insecto.Cy = e.Location.Y;
                    this.Invalidate();
                }
            }
            if (figura == "Basura")
            {
                if ((e.Button == MouseButtons.Left))
                {
                    pictureBox1.Capture = true;
                    m_Basura = new Basura();
                    m_Basura.Cx = e.Location.X;
                    m_Basura.Cy = e.Location.Y;
                    this.Invalidate();
                }
            }
            if (figura == "Cancha")
            {
                if ((e.Button == MouseButtons.Left))
                {
                    pictureBox1.Capture = true;
                    m_cancha = new Cancha();
                    m_cancha.Cx = e.Location.X;
                    m_cancha.Cy = e.Location.Y;
                    this.Invalidate();
                }
            }
            if (figura == "Rosa")
            {
                if ((e.Button == MouseButtons.Left))
                {
                    pictureBox1.Capture = true;
                    m_rosa = new Rosa();
                    m_rosa.Cx = e.Location.X;
                    m_rosa.Cy = e.Location.Y;
                    this.Invalidate();
                }
            }
            if (figura == "Estacionamiento")
            {
                if ((e.Button == MouseButtons.Left))
                {
                    pictureBox1.Capture = true;
                    m_esta = new Estacionamiento();
                    m_esta.Cx = e.Location.X;
                    m_esta.Cy = e.Location.Y;
                    this.Invalidate();
                }
            }
            if (figura == "Madriguera")
            {
                if ((e.Button == MouseButtons.Left))
                {
                    pictureBox1.Capture = true;
                    m_Zona = new Zona();
                    m_Zona.Cx = e.Location.X;
                    m_Zona.Cy = e.Location.Y;
                    this.Invalidate();
                }
            }
            if (figura == "Estanque")
            {
                if ((e.Button == MouseButtons.Left))
                {
                    pictureBox1.Capture = true;
                    m_estanque = new Estanque();
                    m_estanque.Cx = e.Location.X;
                    m_estanque.Cy = e.Location.Y;
                    this.Invalidate();
                }
            }
            if (figura == "Baño")
            {
                if ((e.Button == MouseButtons.Left))
                {
                    pictureBox1.Capture = true;
                    m_baño = new Baño();
                    m_baño.Cx = e.Location.X;
                    m_baño.Cy = e.Location.Y;
                    this.Invalidate();
                }
            }
            if (figura == "Zanja")
            {
                if ((e.Button == MouseButtons.Left))
                {
                    pictureBox1.Capture = true;
                    m_Zanja = new Zanja();
                    m_Zanja.Cx = e.Location.X;
                    m_Zanja.Cy = e.Location.Y;
                    this.Invalidate();
                }
            }
            if (figura == "Escalera")
            {
                if ((e.Button == MouseButtons.Left))
                {
                    pictureBox1.Capture = true;
                    m_Escalera = new Escalera();
                    m_Escalera.Cx = e.Location.X;
                    m_Escalera.Cy = e.Location.Y;
                    this.Invalidate();
                }
            }
            if (figura == "Techo")
            {
                if ((e.Button == MouseButtons.Left))
                {
                    pictureBox1.Capture = true;
                    m_Techo = new Techado();
                    m_Techo.Cx = e.Location.X;
                    m_Techo.Cy = e.Location.Y;
                    this.Invalidate();
                }
            }
            if (figura == "Arbol")
            {
                if ((e.Button == MouseButtons.Left))
                {
                    pictureBox1.Capture = true;
                    m_Arbol = new Arbol();
                    m_Arbol.Cx = e.Location.X;
                    m_Arbol.Cy = e.Location.Y;
                    this.Invalidate();
                }
            }
            if (figura == "Pozo")
            {
                if ((e.Button == MouseButtons.Left))
                {
                    pictureBox1.Capture = true;
                    m_Pozo = new Pozo();
                    m_Pozo.Cx = e.Location.X;
                    m_Pozo.Cy = e.Location.Y;
                    this.Invalidate();
                }
            }
            if (figura == "Palabra")
            {
                if ((e.Button == MouseButtons.Left))
                {
                    pictureBox1.Capture = true;
                    m_palabra = new Palabras();
                    m_palabra.Cx = e.Location.X;
                    m_palabra.Cy = e.Location.Y;


                    m_palabra.TEX = textBox4.Text;
                    m_palabra.F = Convert.ToInt32(comboBox5.Text);
                    m_palabra.Point1 = e.Location;
                    listpalabra.Add(m_palabra);
                    listpalabra.ForEach((Palabras item) => { item.Draw(g); });
                    if ((((m_palabra) != null)))
                        m_palabra.Draw(g);
                    this.Invalidate();
                }
            }

            this.Invalidate();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

            label21.Text = "X:" + Convert.ToString(e.Location.X);
            label20.Text = "Y:" + Convert.ToString(e.Location.Y);

            if (figura == "Caja")
            {
                if (comboBoxPrediseñada.Text == "")
                {
                    MessageBox.Show("Asignar Tamaño");

                }
                else
                {
                    if (((m_cua == null) || (e.Button != MouseButtons.Left)))
                        return;
                    m_cua.Dx = Convert.ToInt32(comboBoxPrediseñada.Text);
                    m_cua.Dy = Convert.ToInt32(comboBoxPrediseñada.Text);
                    m_lstOfCua.ForEach((RectanguloFill item) => { item.Draw(g); });
                    if ((((m_cua) != null)))
                        m_cua.Draw(g);
                    contcaja++;
                    myFont = new System.Drawing.Font("Arial", Convert.ToInt32(comboBoxPrediseñada.Text));
                    int xnumerico = e.Location.X + m_cua.Dx;
                    int ynumerico = e.Location.Y;
                    if (automatico == true)
                    {
                        Point numericco = new Point(xnumerico, ynumerico);
                        g.DrawString(Convert.ToString(contcaja), myFont, Brushes.Black, numericco);
                    }
                    m_cua.CodPlano = textBox1.Text;
                    m_cua.Numero = contcaja;
                    m_cua.Tipo = "Trampa Captura Viva";
                    m_lstOfCua.Add(m_cua);

                    string nombre = "Trampa Captura Viva";
                    Point aux = new Point(e.Location.X, e.Location.Y);
                    CatalogoDispoitivo cat = new CatalogoDispoitivo();
                    if (Establecer == true)
                    {
                        cat.addDispositivo(0, nombre, contcaja, e.Location.X, e.Location.Y, textBox1.Text, 0);
                    }
                    this.Invalidate();
                }

            }
            if (figura == "Cebadero")
            {
                if (comboBoxPrediseñada.Text == "")
                {
                    MessageBox.Show("Asignar Tamaño");

                }
                else
                {
                    if (((m_cir == null) || (e.Button != MouseButtons.Left)))
                        return;
                    m_cir.Dx = Convert.ToInt32(comboBoxPrediseñada.Text);
                    m_cir.Dy = Convert.ToInt32(comboBoxPrediseñada.Text);
                    m_lstOfCir.ForEach((fillCirculo item) => { item.Draw(g); });
                    if ((((m_cir) != null)))
                        m_cir.Draw(g);
                    contcri++;
                    myFont = new System.Drawing.Font("Arial", Convert.ToInt32(comboBoxPrediseñada.Text));
                    int xnumerico = e.Location.X + m_cir.Dx;
                    int ynumerico = e.Location.Y;
                    if (automatico == true)
                    {
                        Point numericco = new Point(xnumerico, ynumerico);
                        g.DrawString(Convert.ToString(contcri), myFont, Brushes.Black, numericco);
                    }
                    m_cir.CodPlano = textBox1.Text;
                    m_cir.Numero = contcri;
                    m_cir.Tipo = "Tubo Cebadero";
                    m_lstOfCir.Add(m_cir);

                    string nombre = "Tubo Cebadero";
                    Point aux = new Point(e.Location.X, e.Location.Y);
                    CatalogoDispoitivo cat = new CatalogoDispoitivo();
                    if (Establecer == true)
                    {
                        cat.addDispositivo(0, nombre, contcri, e.Location.X, e.Location.Y, textBox1.Text, 0);
                    }
                    this.Invalidate();
                }

            }
            if (figura == "Fly Out")
            {
                if (comboBoxPrediseñada.Text == "")
                {
                    MessageBox.Show("Asignar Tamaño");

                }
                else
                {
                    if (((m_rrojo == null) || (e.Button != MouseButtons.Left)))
                        return;
                    m_rrojo.Dx = Convert.ToInt32(comboBoxPrediseñada.Text);
                    m_rrojo.Dy = Convert.ToInt32(comboBoxPrediseñada.Text);
                    m_lstOfRRojo.ForEach((RojoRectangulo item) => { item.Draw(g); });
                    if ((((m_rrojo) != null)))
                        m_rrojo.Draw(g);
                    controjo++;
                    myFont = new System.Drawing.Font("Arial", Convert.ToInt32(comboBoxPrediseñada.Text));
                    int xnumerico = e.Location.X + m_rrojo.Dx; ;
                    int ynumerico = e.Location.Y;
                    if (automatico == true)
                    {
                        Point numericco = new Point(xnumerico, ynumerico);
                        g.DrawString(Convert.ToString(controjo), myFont, Brushes.Black, numericco);
                    }
                    m_rrojo.CodPlano = textBox1.Text;
                    m_rrojo.Numero = controjo;
                    m_rrojo.Tipo = "Fly Out";
                    m_lstOfRRojo.Add(m_rrojo);

                    string nombre = "Fly Out";
                    Point aux = new Point(e.Location.X, e.Location.Y);
                    CatalogoDispoitivo cat = new CatalogoDispoitivo();
                    if (Establecer == true)
                    {
                        cat.addDispositivo(0, nombre, controjo, e.Location.X, e.Location.Y, textBox1.Text, 0);
                    }
                    this.Invalidate();
                }

            }
            if (figura == "Pejagosa")
            {
                if (comboBoxPrediseñada.Text == "")
                {
                    MessageBox.Show("Asignar Tamaño");

                }
                else
                {
                    if (((m_tri == null) || (e.Button != MouseButtons.Left)))
                        return;
                    m_tri.Dx = Convert.ToInt32(comboBoxPrediseñada.Text);
                    m_tri.Dy = Convert.ToInt32(comboBoxPrediseñada.Text);
                    m_lstOfTri.ForEach((Triangulo1 item) => { item.Draw(g); });
                    if ((((m_tri) != null)))
                        m_tri.Draw(g);
                    conttri++;
                    myFont = new System.Drawing.Font("Arial", Convert.ToInt32(comboBoxPrediseñada.Text));
                    int xnumerico = e.Location.X + m_tri.Dx; ;
                    int ynumerico = e.Location.Y;
                    if (automatico == true)
                    {
                        Point numericco = new Point(xnumerico, ynumerico);
                        g.DrawString(Convert.ToString(conttri), myFont, Brushes.Black, numericco);
                    }
                    m_tri.CodPlano = textBox1.Text;
                    m_tri.Numero = conttri;
                    m_tri.Tipo = "Trampa Pegajosa";
                    m_lstOfTri.Add(m_tri);

                    string nombre = "Trampa Pegajosa";
                    Point aux = new Point(e.Location.X, e.Location.Y);
                    CatalogoDispoitivo cat = new CatalogoDispoitivo();
                    if (Establecer == true)
                    {
                        cat.addDispositivo(0, nombre, conttri, e.Location.X, e.Location.Y, textBox1.Text, 0);
                    }
                    this.Invalidate();
                }

            }
            if (figura == "Anclado")
            {
                if (comboBoxPrediseñada.Text == "")
                {
                    MessageBox.Show("Asignar Tamaño");

                }
                else
                {
                    if (((m_ancla == null) || (e.Button != MouseButtons.Left)))
                        return;
                    m_ancla.Dx = Convert.ToInt32(comboBoxPrediseñada.Text);
                    m_ancla.Dy = Convert.ToInt32(comboBoxPrediseñada.Text);
                    m_lstOfancla.ForEach((Anclado item) => { item.Draw(g); });
                    if ((((m_ancla) != null)))
                        m_ancla.Draw(g);
                    contancla++;
                    myFont = new System.Drawing.Font("Arial", Convert.ToInt32(comboBoxPrediseñada.Text));
                    int xnumerico = e.Location.X + m_ancla.Dx; ;
                    int ynumerico = e.Location.Y;
                    if (automatico == true)
                    {
                        Point numericco = new Point(xnumerico, ynumerico);
                        g.DrawString(Convert.ToString(contancla), myFont, Brushes.Black, numericco);
                    }
                    m_ancla.CodPlano = textBox1.Text;
                    m_ancla.Numero = contancla;
                    m_ancla.Tipo = "Veneno Anclado";
                    m_lstOfancla.Add(m_ancla);

                    string nombre = "Veneno Anclado";
                    Point aux = new Point(e.Location.X, e.Location.Y);
                    CatalogoDispoitivo cat = new CatalogoDispoitivo();
                    if (Establecer == true)
                    {
                        cat.addDispositivo(0, nombre, contancla, e.Location.X, e.Location.Y, textBox1.Text, 0);
                    }
                    this.Invalidate();
                }

            }
            if (figura == "Agua")
            {
                if (comboBoxPrediseñada.Text == "")
                {
                    MessageBox.Show("Asignar Tamaño");

                }
                else
                {
                    if (((m_gota == null) || (e.Button != MouseButtons.Left)))
                        return;
                    m_gota.Dx = Convert.ToInt32(comboBoxPrediseñada.Text);
                    m_gota.Dy = Convert.ToInt32(comboBoxPrediseñada.Text);
                    m_lstOfGota.ForEach((Gota item) => { item.Draw(g); });
                    if ((((m_gota) != null)))
                        m_gota.Draw(g);
                    contgota++;
                    myFont = new System.Drawing.Font("Arial", Convert.ToInt32(comboBoxPrediseñada.Text));
                    int xnumerico = e.Location.X + m_gota.Dx; ;
                    int ynumerico = e.Location.Y;
                    if (automatico == true)
                    {
                        Point numericco = new Point(xnumerico, ynumerico);
                        g.DrawString(Convert.ToString(contgota), myFont, Brushes.Black, numericco);
                    }
                    m_gota.CodPlano = textBox1.Text;
                    m_gota.Numero = contgota;
                    m_gota.Tipo = "Trampa de Agua";
                    m_lstOfGota.Add(m_gota);

                    string nombre = "Trampa de Agua";
                    Point aux = new Point(e.Location.X, e.Location.Y);
                    CatalogoDispoitivo cat = new CatalogoDispoitivo();
                    if (Establecer == true)
                    {
                        cat.addDispositivo(0, nombre, contgota, e.Location.X, e.Location.Y, textBox1.Text, 0);
                    }
                    this.Invalidate();
                }

            }
            if (figura == "Otros")
            {
                if (comboBoxPrediseñada.Text == "")
                {
                    MessageBox.Show("Asignar Tamaño");

                }
                else
                {
                    if (((m_Otros == null) || (e.Button != MouseButtons.Left)))
                        return;
                    m_Otros.Dx = Convert.ToInt32(comboBoxPrediseñada.Text);
                    m_Otros.Dy = Convert.ToInt32(comboBoxPrediseñada.Text);
                    m_lstOfOtros.ForEach((Otros item) => { item.Draw(g); });
                    if ((((m_Otros) != null)))
                        m_Otros.Draw(g);
                    contOtros++;
                    myFont = new System.Drawing.Font("Arial", Convert.ToInt32(comboBoxPrediseñada.Text));
                    int xnumerico = e.Location.X + m_Otros.Dx; ;
                    int ynumerico = e.Location.Y;
                    if (automatico == true)
                    {
                        Point numericco = new Point(xnumerico, ynumerico);
                        g.DrawString(Convert.ToString(contOtros), myFont, Brushes.Black, numericco);
                    }
                    m_Otros.CodPlano = textBox1.Text;
                    m_Otros.Numero = contOtros;
                    m_Otros.Tipo = "Otros";
                    m_lstOfOtros.Add(m_Otros);

                    string nombre = "Otros";
                    Point aux = new Point(e.Location.X, e.Location.Y);
                    CatalogoDispoitivo cat = new CatalogoDispoitivo();
                    if (Establecer == true)
                    {
                        cat.addDispositivo(0, nombre, contOtros, e.Location.X, e.Location.Y, textBox1.Text, 0);
                    }
                    this.Invalidate();
                }

            }
            if (figura == "Caja Circulo")
            {
                if (comboBoxPrediseñada.Text == "")
                {
                    MessageBox.Show("Asignar Tamaño");

                }
                else
                {
                    if (((m_caja == null) || (e.Button != MouseButtons.Left)))
                        return;
                    m_caja.Dx = Convert.ToInt32(comboBoxPrediseñada.Text);
                    m_caja.Dy = Convert.ToInt32(comboBoxPrediseñada.Text);
                    m_lstOfCaja.ForEach((Caja item) => { item.Draw(g); });
                    if ((((m_caja) != null)))
                        m_caja.Draw(g);
                    concua++;
                    myFont = new System.Drawing.Font("Arial", Convert.ToInt32(comboBoxPrediseñada.Text));
                    int xnumerico = e.Location.X + m_caja.Dx; ;
                    int ynumerico = e.Location.Y;
                    if (automatico == true)
                    {
                        Point numericco = new Point(xnumerico, ynumerico);
                        g.DrawString(Convert.ToString(concua), myFont, Brushes.Black, numericco);
                    }
                    m_caja.CodPlano = textBox1.Text;
                    m_caja.Numero = concua;
                    m_caja.Tipo = "Caja Cebadera";
                    m_lstOfCaja.Add(m_caja);


                    string nombre = "Caja Cebadera";
                    Point aux = new Point(e.Location.X, e.Location.Y);
                    CatalogoDispoitivo cat = new CatalogoDispoitivo();
                    if (Establecer == true)
                    {
                        cat.addDispositivo(0, nombre, concua, e.Location.X, e.Location.Y,textBox1.Text, 0);
                    }
                    this.Invalidate();
                }

            }
            if (figura == "Insecto")
            {
                if (comboBoxPrediseñada.Text == "")
                {
                    MessageBox.Show("Asignar Tamaño");

                }
                else
                {
                    if (((m_insecto == null) || (e.Button != MouseButtons.Left)))
                        return;
                    m_insecto.Dx = Convert.ToInt32(comboBoxPrediseñada.Text);
                    m_insecto.Dy = Convert.ToInt32(comboBoxPrediseñada.Text);
                    m_lstOfInsecto.ForEach((Insecto item) => { item.Draw(g); });
                    if ((((m_insecto) != null)))
                        m_insecto.Draw(g);
                    continsecto++;
                    myFont = new System.Drawing.Font("Arial", Convert.ToInt32(comboBoxPrediseñada.Text));
                    int xnumerico = e.Location.X + m_insecto.Dx; ;
                    int ynumerico = e.Location.Y;
                    if (automatico == true)
                    {
                        Point numericco = new Point(xnumerico, ynumerico);
                        g.DrawString(Convert.ToString(continsecto), myFont, Brushes.Black, numericco);
                    }
                    m_insecto.CodPlano = textBox1.Text;
                    m_insecto.Numero = continsecto;
                    m_insecto.Tipo = "Trampa Insecto";
                    m_lstOfInsecto.Add(m_insecto);

                    string nombre = "Trampa Insecto";
                    Point aux = new Point(e.Location.X, e.Location.Y);
                    CatalogoDispoitivo cat = new CatalogoDispoitivo();
                    if (Establecer == true)
                    {
                        cat.addDispositivo(0, nombre, continsecto, e.Location.X, e.Location.Y, textBox1.Text, 0);
                    }
                    this.Invalidate();
                }

            }
          
            if (figura == "Arbol")
            {
                if (comboBoxPrediseñada.Text == "")
                {
                    MessageBox.Show("Asignar Tamaño");

                }
                else
                {
                    if (((m_Arbol == null) || (e.Button != MouseButtons.Left)))
                        return;
                    m_Arbol.Dx = Convert.ToInt32(comboBoxPrediseñada.Text);
                    m_Arbol.Dy = Convert.ToInt32(comboBoxPrediseñada.Text);
                    m_lstOfArbol.ForEach((Arbol item) => { item.Draw(g); });
                    if ((((m_Arbol) != null)))
                        m_Arbol.Draw(g);
                    m_lstOfArbol.Add(m_Arbol);
                    this.Invalidate();
                }

            }
            if (figura == "Pozo")
            {
                if (comboBoxPrediseñada.Text == "")
                {
                    MessageBox.Show("Asignar Tamaño");

                }
                else
                {
                    if (((m_Pozo == null) || (e.Button != MouseButtons.Left)))
                        return;
                    m_Pozo.Dx = Convert.ToInt32(comboBoxPrediseñada.Text);
                    m_Pozo.Dy = Convert.ToInt32(comboBoxPrediseñada.Text);
                    m_lstOfPozo.ForEach((Pozo item) => { item.Draw(g); });
                    if ((((m_Pozo) != null)))
                        m_Pozo.Draw(g);
                    m_lstOfPozo.Add(m_Pozo);
                    this.Invalidate();
                }

            }

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

            if (figura == "Lineas")
            {


                if ((e.Button == MouseButtons.Left))
                {
                    m_line.Point2 = e.Location;
                    m_line.Draw(g);
                    m_lstOfLine.Add(m_line);
                    this.Invalidate();

                }
            }

            if (figura == "Circulo")
            {

                if ((e.Button == MouseButtons.Left))
                {
                    m_circle.Point2 = e.Location;
                    m_circle.Dx = e.Location.X - m_circle.Cx;
                    m_circle.Dy = e.Location.Y - m_circle.Cy;
                    m_lstOfCircle.Add(m_circle);

                    m_circle.Draw(g);
                    this.Invalidate();

                }
            }
            if (figura == "Cuadrado")
            {


                if ((e.Button == MouseButtons.Left))
                {

                    m_rectangulo.Point2 = e.Location;
                    m_rectangulo.Dx = e.Location.X - m_rectangulo.Cx;
                    m_rectangulo.Dy = e.Location.Y - m_rectangulo.Cy;
                    m_lstOfRectangulo.Add(m_rectangulo);

                    m_rectangulo.Draw(g);
                    this.Invalidate();
                }
            }
            if (figura == "Basura")
            {


                if ((e.Button == MouseButtons.Left))
                {

                    m_Basura.Point2 = e.Location;
                    m_Basura.Dx = e.Location.X - m_Basura.Cx;
                    m_Basura.Dy = e.Location.Y - m_Basura.Cy;
                    m_lstOfBasura.Add(m_Basura);

                    m_Basura.Draw(g);
                    this.Invalidate();

                }
            }
            if (figura == "Cancha")
            {


                if ((e.Button == MouseButtons.Left))
                {

                    m_cancha.Point2 = e.Location;
                    m_cancha.Dx = e.Location.X - m_cancha.Cx;
                    m_cancha.Dy = e.Location.Y - m_cancha.Cy;
                    m_lstOfCancha.Add(m_cancha);

                    m_cancha.Draw(g);
                    this.Invalidate();

                }
            }
            if (figura == "Rosa")
            {


                if ((e.Button == MouseButtons.Left))
                {

                    m_rosa.Point2 = e.Location;
                    m_rosa.Dx = e.Location.X - m_rosa.Cx;
                    m_rosa.Dy = e.Location.Y - m_rosa.Cy;
                    m_lstOfRosa.Add(m_rosa);
                    m_rosa.Draw(g);
                    this.Invalidate();

                }
            }
            if (figura == "Estacionamiento")
            {


                if ((e.Button == MouseButtons.Left))
                {

                    m_esta.Point2 = e.Location;
                    m_esta.Dx = e.Location.X - m_esta.Cx;
                    m_esta.Dy = e.Location.Y - m_esta.Cy;

                    if ((((m_esta) != null)))
                        m_esta.Draw(g);
                    this.Invalidate();
                }
            }
            if (figura == "Madriguera")
            {


                if ((e.Button == MouseButtons.Left))
                {
                    m_Zona.Point2 = e.Location;
                    m_Zona.Dx = e.Location.X - m_Zona.Cx;
                    m_Zona.Dy = e.Location.Y - m_Zona.Cy;

                    if ((((m_Zona) != null)))
                        m_Zona.Draw(g);
                    this.Invalidate();
                }
            }
            if (figura == "Estanque")
            {


                if ((e.Button == MouseButtons.Left))
                {

                    m_estanque.Point2 = e.Location;
                    m_estanque.Dx = e.Location.X - m_estanque.Cx;
                    m_estanque.Dy = e.Location.Y - m_estanque.Cy;
                    m_lstOfestanque.Add(m_estanque);

                    m_estanque.Draw(g);
                    this.Invalidate();
                }
            }
            if (figura == "Baño")
            {


                if ((e.Button == MouseButtons.Left))
                {

                    m_baño.Point2 = e.Location;
                    m_baño.Dx = e.Location.X - m_baño.Cx;
                    m_baño.Dy = e.Location.Y - m_baño.Cy;
                    m_lstOfBaño.Add(m_baño);

                    m_baño.Draw(g);
                    this.Invalidate();
                }
            }
            if (figura == "Zanja")
            {


                if ((e.Button == MouseButtons.Left))
                {

                    m_Zanja.Point2 = e.Location;
                    m_Zanja.Dx = e.Location.X - m_Zanja.Cx;
                    m_Zanja.Dy = e.Location.Y - m_Zanja.Cy;
                    m_lstOfZanja.Add(m_Zanja);

                    m_Zanja.Draw(g);
                    this.Invalidate();
                }
            }
            if (figura == "Escalera")
            {


                if ((e.Button == MouseButtons.Left))
                {

                    m_Escalera.Point2 = e.Location;
                    m_Escalera.Dx = e.Location.X - m_Escalera.Cx;
                    m_Escalera.Dy = e.Location.Y - m_Escalera.Cy;
                    m_lstOfEscalera.Add(m_Escalera);

                    m_Escalera.Draw(g);
                    this.Invalidate();
                }
            }
            if (figura == "Techo")
            {
                if ((e.Button == MouseButtons.Left))
                {

                    m_Techo.Point2 = e.Location;
                    m_Techo.Dx = e.Location.X - m_Techo.Cx;
                    m_Techo.Dy = e.Location.Y - m_Techo.Cy;
                    m_lstOfTecho.Add(m_Techo);

                    m_Techo.Draw(g);
                    this.Invalidate();

                }
            }
            this.Invalidate();

        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            label21.Text = "X:" + Convert.ToString(e.Location.X);
            label20.Text = "Y:" + Convert.ToString(e.Location.Y);



            if (e.Button == MouseButtons.Right && figura == "Caja")
            {

                m_cua.Cx += e.X - m_cua.Cx;
                m_cua.Cy += e.Y - m_cua.Cy;
                Refresh();
                m_lstOfCua.ForEach((RectanguloFill item) => { item.Draw(g); });
                if ((((m_cua) != null)))
                    m_cua.Draw(g);
                recargar();

            }
            if (e.Button == MouseButtons.Right && figura == "Cebadero")
            {


                m_cir.Cx += e.X - m_cir.Cx;
                m_cir.Cy += e.Y - m_cir.Cy;
                Refresh();
                m_lstOfCir.ForEach((fillCirculo item) => { item.Draw(g); });
                if ((((m_cir) != null)))
                    m_cir.Draw(g);
                recargar();
            }
            if (e.Button == MouseButtons.Right && figura == "Fly Out")
            {


                m_rrojo.Cx += e.X - m_rrojo.Cx;
                m_rrojo.Cy += e.Y - m_rrojo.Cy;
                Refresh();
                m_lstOfRRojo.ForEach((RojoRectangulo item) => { item.Draw(g); });
                if ((((m_rrojo) != null)))
                    m_rrojo.Draw(g);
                recargar();

            }
            if (e.Button == MouseButtons.Right && figura == "Pejagosa")
            {


                m_tri.Cx += e.X - m_tri.Cx;
                m_tri.Cy += e.Y - m_tri.Cy;
                Refresh();
                m_lstOfTri.ForEach((Triangulo1 item) => { item.Draw(g); });
                if ((((m_tri) != null)))
                    m_tri.Draw(g);
                recargar();

            }
            if (e.Button == MouseButtons.Right && figura == "Anclado")
            {


                m_ancla.Cx += e.X - m_ancla.Cx;
                m_ancla.Cy += e.Y - m_ancla.Cy;
                Refresh();
                m_lstOfancla.ForEach((Anclado item) => { item.Draw(g); });
                if ((((m_ancla) != null)))
                    m_ancla.Draw(g);
                recargar();

            }
            if (e.Button == MouseButtons.Right && figura == "Agua")
            {


                m_gota.Cx += e.X - m_gota.Cx;
                m_gota.Cy += e.Y - m_gota.Cy;
                Refresh();
                m_lstOfGota.ForEach((Gota item) => { item.Draw(g); });
                if ((((m_gota) != null)))
                    m_gota.Draw(g);
                recargar();

            }
            if (e.Button == MouseButtons.Right && figura == "Otros")
            {


                m_Otros.Cx += e.X - m_Otros.Cx;
                m_Otros.Cy += e.Y - m_Otros.Cy;
                Refresh();
                m_lstOfOtros.ForEach((Otros item) => { item.Draw(g); });
                if ((((m_Otros) != null)))
                    m_Otros.Draw(g);
                recargar();

            }
            if (e.Button == MouseButtons.Right && figura == "Caja Circulo")
            {


                m_caja.Cx += e.X - m_caja.Cx;
                m_caja.Cy += e.Y - m_caja.Cy;
                Refresh();
                m_lstOfCaja.ForEach((Caja item) => { item.Draw(g); });
                if ((((m_caja) != null)))
                    m_caja.Draw(g);
                recargar();

            }
            if (e.Button == MouseButtons.Right && figura == "Insecto")
            {


                m_insecto.Cx += e.X - m_insecto.Cx;
                m_insecto.Cy += e.Y - m_insecto.Cy;
                Refresh();
                m_lstOfInsecto.ForEach((Insecto item) => { item.Draw(g); });
                if ((((m_insecto) != null)))
                    m_insecto.Draw(g);
                recargar();

            }


            if (figura == "Lineas")
            {
                if ((e.Button == MouseButtons.Left))
                {
                    m_line.Point2 = e.Location;
                    m_line.Draw(g);
                    m_line.DrawWhite(g);
                    posx = e.Location.X;
                    posy = e.Location.Y;
                    if (m_line.Point1 == e.Location) 
                    {
                        m_line.Draw(g);
                    
                    }


                }

            }
            if (figura == "Lapiz")
            {

                if ((e.Button == MouseButtons.Left))
                {
                    m_lapiz = new Lapiz();
                    m_lapiz.Point1 = e.Location;
                    m_lapiz.Cx = e.Location.X;
                    m_lapiz.Cy = e.Location.Y;
                    m_lapiz.DrawLapiz(g, Convert.ToInt32(comboBoxPrediseñada.Text));
                    m_lstOfLapiz.Add(m_lapiz);
                    this.Invalidate();
                }

            }
            if (figura == "Goma")
            {
                this.Cursor = Cursors.No;
                if ((e.Button == MouseButtons.Left))
                {


                    m_Goma = new Goma();
                    m_Goma.Point1 = e.Location;
                    m_Goma.Cx = e.Location.X;
                    m_Goma.Cy = e.Location.Y;
                    m_Goma.Draw(g);
                    m_lstOfGoma.Add(m_Goma);
                    this.Invalidate();
                }

            }
            if (figura == "Circulo")
            {
                if ((e.Button == MouseButtons.Left))
                {
                    m_circle.Point2 = e.Location;

                    m_circle.Dx = e.Location.X - m_circle.Cx;
                    m_circle.Dy = e.Location.Y - m_circle.Cy;

                    m_circle.Draw(g);
                    m_circle.DrawWhite(g);

                    posx = e.Location.X;
                    posy = e.Location.Y;
                    this.Invalidate();


                }

            }
            if (figura == "Cuadrado")
            {
                if ((e.Button == MouseButtons.Left))
                {
                    m_rectangulo.Point2 = e.Location;

                    m_rectangulo.Dx = e.Location.X - m_rectangulo.Cx;
                    m_rectangulo.Dy = e.Location.Y - m_rectangulo.Cy;

                    m_rectangulo.Draw(g);
                    m_rectangulo.DrawWhite(g);

                    posx = e.Location.X;
                    posy = e.Location.Y;
                    this.Invalidate();
                }

            }
            if (figura == "Basura")
            {
                if ((e.Button == MouseButtons.Left))
                {
                    m_Basura.Point2 = e.Location;

                    m_Basura.Dx = e.Location.X - m_Basura.Cx;
                    m_Basura.Dy = e.Location.Y - m_Basura.Cy;

                    m_Basura.Draw(g);

                    posx = e.Location.X;
                    posy = e.Location.Y;
                    this.Invalidate();
                }

            }
            if (figura == "Cancha")
            {
                if ((e.Button == MouseButtons.Left))
                {
                    m_cancha.Point2 = e.Location;

                    m_cancha.Dx = e.Location.X - m_cancha.Cx;
                    m_cancha.Dy = e.Location.Y - m_cancha.Cy;

                    m_cancha.Draw(g);

                    posx = e.Location.X;
                    posy = e.Location.Y;
                    this.Invalidate();
                }

            }
            if (figura == "Rosa")
            {
                if ((e.Button == MouseButtons.Left))
                {
                    m_rosa.Point2 = e.Location;

                    m_rosa.Dx = e.Location.X - m_rosa.Cx;
                    m_rosa.Dy = e.Location.Y - m_rosa.Cy;
                    m_rosa.Draw(g);
                    posx = e.Location.X;
                    posy = e.Location.Y;
                    this.Invalidate();
                }
            }
            if (figura == "Estacionamiento")
            {
                if ((e.Button == MouseButtons.Left))
                {
                    m_esta.Point2 = e.Location;

                    m_esta.Dx = e.Location.X - m_esta.Cx;
                    m_esta.Dy = e.Location.Y - m_esta.Cy;

                    m_esta.Draw(g);

                    posx = e.Location.X;
                    posy = e.Location.Y;
                    this.Invalidate();

                }

            }
            if (figura == "Madriguera")
            {
                if ((e.Button == MouseButtons.Left))
                {
                    m_Zona.Point2 = e.Location;

                    m_Zona.Dx = e.Location.X - m_Zona.Cx;
                    m_Zona.Dy = e.Location.Y - m_Zona.Cy;

                    m_Zona.Draw(g);

                    posx = e.Location.X;
                    posy = e.Location.Y;
                    this.Invalidate();
                }

            }
            if (figura == "Estanque")
            {
                if ((e.Button == MouseButtons.Left))
                {
                    m_estanque.Point2 = e.Location;

                    m_estanque.Dx = e.Location.X - m_estanque.Cx;
                    m_estanque.Dy = e.Location.Y - m_estanque.Cy;

                    m_estanque.Draw(g);

                    posx = e.Location.X;
                    posy = e.Location.Y;
                    this.Invalidate();
                }

            }
            if (figura == "Baño")
            {
                if ((e.Button == MouseButtons.Left))
                {
                    m_baño.Point2 = e.Location;

                    m_baño.Dx = e.Location.X - m_baño.Cx;
                    m_baño.Dy = e.Location.Y - m_baño.Cy;

                    m_baño.Draw(g);

                    posx = e.Location.X;
                    posy = e.Location.Y;
                    this.Invalidate();
                }

            }
            if (figura == "Zanja")
            {
                if ((e.Button == MouseButtons.Left))
                {
                    m_Zanja.Point2 = e.Location;

                    m_Zanja.Dx = e.Location.X - m_Zanja.Cx;
                    m_Zanja.Dy = e.Location.Y - m_Zanja.Cy;

                    m_Zanja.Draw(g);

                    posx = e.Location.X;
                    posy = e.Location.Y;
                    this.Invalidate();
                }

            }
            if (figura == "Escalera")
            {
                if ((e.Button == MouseButtons.Left))
                {
                    m_Escalera.Point2 = e.Location;

                    m_Escalera.Dx = e.Location.X - m_Escalera.Cx;
                    m_Escalera.Dy = e.Location.Y - m_Escalera.Cy;

                    m_Escalera.Draw(g);

                    posx = e.Location.X;
                    posy = e.Location.Y;
                    this.Invalidate();
                }

            }
            if (figura == "Techo")
            {
                if ((e.Button == MouseButtons.Left))
                {
                    m_Techo.Point2 = e.Location;

                    m_Techo.Dx = e.Location.X - m_Techo.Cx;
                    m_Techo.Dy = e.Location.Y - m_Techo.Cy;

                    m_Techo.Draw(g);

                    posx = e.Location.X;
                    posy = e.Location.Y;
                    this.Invalidate();
                }

            }
        }

        public void recargar()
        {

            if (contcaja > 0)
            {
                m_lstOfCua.ForEach((RectanguloFill item) => { item.Draw(g); });
                if ((((m_cua) != null)))
                    m_cua.Draw(g);

            }
            if (contcri > 0)
            {
                m_lstOfCir.ForEach((fillCirculo item) => { item.Draw(g); });
                if ((((m_cir) != null)))
                    m_cir.Draw(g);
            }
            if (controjo > 0)
            {
                m_lstOfRRojo.ForEach((RojoRectangulo item) => { item.Draw(g); });
                if ((((m_rrojo) != null)))
                    m_rrojo.Draw(g);
            }
            if (conttri > 0)
            {
                m_lstOfTri.ForEach((Triangulo1 item) => { item.Draw(g); });
                if ((((m_tri) != null)))
                    m_tri.Draw(g);
            }
            if (contancla > 0)
            {
                m_lstOfancla.ForEach((Anclado item) => { item.Draw(g); });
                if ((((m_ancla) != null)))
                    m_ancla.Draw(g);
            }
            if (contgota > 0)
            {
                m_lstOfGota.ForEach((Gota item) => { item.Draw(g); });
                if ((((m_gota) != null)))
                    m_gota.Draw(g);
            }
            if (contOtros > 0)
            {
                m_lstOfOtros.ForEach((Otros item) => { item.Draw(g); });
                if ((((m_Otros) != null)))
                    m_Otros.Draw(g);
            }
            if (concua > 0)
            {
                m_lstOfCaja.ForEach((Caja item) => { item.Draw(g); });
                if ((((m_caja) != null)))
                    m_caja.Draw(g);
            }
            if (continsecto > 0)
            {
                m_lstOfInsecto.ForEach((Insecto item) => { item.Draw(g); });
                if ((((m_insecto) != null)))
                    m_insecto.Draw(g);
            }
            if (m_lstOfLine.Count > 0)
            {
                m_lstOfLine.ForEach((Line item) => { item.Draw(g); });
                if ((((m_line) != null)))
                    m_line.Draw(g);
            }
            if (m_lstOfRectangulo.Count > 0)
            {
                m_lstOfRectangulo.ForEach((Cuadrado item) => { item.Draw(g); });
                if ((((m_rectangulo) != null)))
                    m_rectangulo.Draw(g);

            }
            if (m_lstOfCircle.Count > 0)
            {
                m_lstOfCircle.ForEach((Circulo item) => { item.Draw(g); });
                if ((((m_circle) != null)))
                    m_circle.Draw(g);
            }
            if (m_lstOfLapiz.Count > 0)
            {
                m_lstOfLapiz.ForEach((Lapiz item) => { item.DrawLapiz(g, Convert.ToInt32(comboBoxPrediseñada.Text)); });
                if ((((m_lapiz) != null)))
                    m_lapiz.DrawLapiz(g, Convert.ToInt32(comboBoxPrediseñada.Text));
            }


            if (m_lstOfCancha.Count > 0)
            {
                m_lstOfCancha.ForEach((Cancha item) => { item.Draw(g); });
                if ((((m_cancha) != null)))
                    m_cancha.Draw(g);
            }
            if (m_lstOfEsta.Count > 0)
            {
                m_lstOfEsta.ForEach((Estacionamiento item) => { item.Draw(g); });
                if ((((m_esta) != null)))
                    m_esta.Draw(g);
            }
            if (m_lstOfArbol.Count > 0)
            {
                m_lstOfArbol.ForEach((Arbol item) => { item.Draw(g); });
                if ((((m_Arbol) != null)))
                    m_Arbol.Draw(g);
            }
            if (m_lstOfPozo.Count > 0)
            {
                m_lstOfPozo.ForEach((Pozo item) => { item.Draw(g); });
                if ((((m_Pozo) != null)))
                    m_Pozo.Draw(g);
            }
            if (m_lstOfEscalera.Count > 0)
            {
                m_lstOfEscalera.ForEach((Escalera item) => { item.Draw(g); });
                if ((((m_Escalera) != null)))
                    m_Escalera.Draw(g);
            }
            if (m_lstOfZona.Count > 0)
            {
                m_lstOfZona.ForEach((Zona item) => { item.Draw(g); });
                if ((((m_Zona) != null)))
                    m_Zona.Draw(g);
            }
            if (m_lstOfZanja.Count > 0)
            {
                m_lstOfZanja.ForEach((Zanja item) => { item.Draw(g); });
                if ((((m_Zanja) != null)))
                    m_Zanja.Draw(g);
            }
            if (m_lstOfestanque.Count > 0)
            {
                m_lstOfestanque.ForEach((Estanque item) => { item.Draw(g); });
                if ((((m_estanque) != null)))
                    m_estanque.Draw(g);
            }
            if (m_lstOfBasura.Count > 0)
            {
                m_lstOfBasura.ForEach((Basura item) => { item.Draw(g); });
                if ((((m_Basura) != null)))
                    m_Basura.Draw(g);
            }
            if (m_lstOfBaño.Count > 0)
            {
                m_lstOfBaño.ForEach((Baño item) => { item.Draw(g); });
                if ((((m_baño) != null)))
                    m_baño.Draw(g);
            }

        }
        public void guardarbit()
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g1 = Graphics.FromImage(pictureBox1.Image);
            if (contcaja > 0)
            {
                m_lstOfCua.ForEach((RectanguloFill item) => { item.Draw(g1); });
                if ((((m_cua) != null)))
                    m_cua.Draw(g1);

            }
            if (contcri > 0)
            {
                m_lstOfCir.ForEach((fillCirculo item) => { item.Draw(g1); });
                if ((((m_cir) != null)))
                    m_cir.Draw(g1);



            }
            if (controjo > 0)
            {
                m_lstOfRRojo.ForEach((RojoRectangulo item) => { item.Draw(g1); });
                if ((((m_rrojo) != null)))
                    m_rrojo.Draw(g1);
            }
            if (conttri > 0)
            {
                m_lstOfTri.ForEach((Triangulo1 item) => { item.Draw(g1); });
                if ((((m_tri) != null)))
                    m_tri.Draw(g1);
            }
            if (contancla > 0)
            {
                m_lstOfancla.ForEach((Anclado item) => { item.Draw(g1); });
                if ((((m_ancla) != null)))
                    m_ancla.Draw(g1);
            }
            if (contgota > 0)
            {
                m_lstOfGota.ForEach((Gota item) => { item.Draw(g1); });
                if ((((m_gota) != null)))
                    m_gota.Draw(g1);
            }
            if (contOtros > 0)
            {
                m_lstOfOtros.ForEach((Otros item) => { item.Draw(g1); });
                if ((((m_Otros) != null)))
                    m_Otros.Draw(g1);
            }
            if (concua > 0)
            {
                m_lstOfCaja.ForEach((Caja item) => { item.Draw(g1); });
                if ((((m_caja) != null)))
                    m_caja.Draw(g1);
            }
            if (continsecto > 0)
            {
                m_lstOfInsecto.ForEach((Insecto item) => { item.Draw(g1); });
                if ((((m_insecto) != null)))
                    m_insecto.Draw(g1);
            }
            if (m_lstOfLine.Count > 0)
            {
                m_lstOfLine.ForEach((Line item) => { item.Draw(g1); });
                if ((((m_line) != null)))
                    m_line.Draw(g1);
            }
            if (m_lstOfRectangulo.Count > 0)
            {
                m_lstOfRectangulo.ForEach((Cuadrado item) => { item.Draw(g1); });
                if ((((m_rectangulo) != null)))
                    m_rectangulo.Draw(g1);

            }
            if (m_lstOfCircle.Count > 0)
            {
                m_lstOfCircle.ForEach((Circulo item) => { item.Draw(g1); });
                if ((((m_circle) != null)))
                    m_circle.Draw(g1);
            }
            if (m_lstOfLapiz.Count > 0)
            {
                m_lstOfLapiz.ForEach((Lapiz item) => { item.DrawLapiz(g1, Convert.ToInt32(comboBoxPrediseñada.Text)); });
                if ((((m_lapiz) != null)))
                    m_lapiz.DrawLapiz(g1, Convert.ToInt32(comboBoxPrediseñada.Text));
            }
            if (m_lstOfGoma.Count > 0)
            {
                m_lstOfGoma.ForEach((Goma item) => { item.Draw(g1); });
                if ((((m_Goma) != null)))
                    m_Goma.Draw(g1);
            }

            if (m_lstOfCancha.Count > 0)
            {
                m_lstOfCancha.ForEach((Cancha item) => { item.Draw(g1); });
                if ((((m_cancha) != null)))
                    m_cancha.Draw(g1);
            }
            if (m_lstOfEsta.Count > 0)
            {
                m_lstOfEsta.ForEach((Estacionamiento item) => { item.Draw(g1); });
                if ((((m_esta) != null)))
                    m_esta.Draw(g1);
            }
            if (m_lstOfArbol.Count > 0)
            {
                m_lstOfArbol.ForEach((Arbol item) => { item.Draw(g1); });
                if ((((m_Arbol) != null)))
                    m_Arbol.Draw(g1);
            }
            if (m_lstOfPozo.Count > 0)
            {
                m_lstOfPozo.ForEach((Pozo item) => { item.Draw(g1); });
                if ((((m_Pozo) != null)))
                    m_Pozo.Draw(g1);
            }
            if (m_lstOfEscalera.Count > 0)
            {
                m_lstOfEscalera.ForEach((Escalera item) => { item.Draw(g1); });
                if ((((m_Escalera) != null)))
                    m_Escalera.Draw(g1);
            }
            if (m_lstOfZona.Count > 0)
            {
                m_lstOfZona.ForEach((Zona item) => { item.Draw(g1); });
                if ((((m_Zona) != null)))
                    m_Zona.Draw(g1);
            }
            if (m_lstOfZanja.Count > 0)
            {
                m_lstOfZanja.ForEach((Zanja item) => { item.Draw(g1); });
                if ((((m_Zanja) != null)))
                    m_Zanja.Draw(g1);
            }
            if (m_lstOfestanque.Count > 0)
            {
                m_lstOfestanque.ForEach((Estanque item) => { item.Draw(g1); });
                if ((((m_estanque) != null)))
                    m_estanque.Draw(g1);
            }
            if (m_lstOfBasura.Count > 0)
            {
                m_lstOfBasura.ForEach((Basura item) => { item.Draw(g1); });
                if ((((m_Basura) != null)))
                    m_Basura.Draw(g1);
            }
            if (m_lstOfBaño.Count > 0)
            {
                m_lstOfBaño.ForEach((Baño item) => { item.Draw(g1); });
                if ((((m_baño) != null)))
                    m_baño.Draw(g1);
            }

            Bitmap bmp1 = new Bitmap(pictureBox1.Image);
            bmp1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            if (System.IO.File.Exists("Picturebox.bmp"))
                System.IO.File.Delete("Picturebox.bmp");

            bmp1.Save("Picturebox.bmp", System.Drawing.Imaging.ImageFormat.Bmp);

            pictureBox1.Image = bmp1;

        }
        private void buttonLinea_Click(object sender, EventArgs e)
        {
            figura = "Lineas";
        }

        private void buttonCirculo_Click(object sender, EventArgs e)
        {
            figura = "Circulo";
        }

        private void buttonRectangulo_Click(object sender, EventArgs e)
        {
            figura = "Cuadrado";
        }
        private void buttonLapiz_Click(object sender, EventArgs e)
        {
            figura = "Lapiz";
        }
        private void buttonGoma_Click(object sender, EventArgs e)
        {
            figura = "Goma";


        }


        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {




        }


        private void pictureBox1_Resize(object sender, EventArgs e)
        {



        }

        private void buttonMundo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/maps/" + "@" + textBox3.Text + "z");
        }

        private void buttonCaja_Click(object sender, EventArgs e)
        {
            figura = "Caja";
        }

        private void buttonCebadero_Click(object sender, EventArgs e)
        {
            figura = "Cebadero";
        }

        private void buttonFlyOut_Click(object sender, EventArgs e)
        {
            figura = "Fly Out";
        }

        private void buttonTPegajosa_Click(object sender, EventArgs e)
        {
            figura = "Pejagosa";
        }

        private void button31_Click(object sender, EventArgs e)
        {
            figura = "Anclado";

        //    System.Drawing.Bitmap a;
        //    a = Properties.Resources.Ancladoico;
        //    a.SetResolution(Convert.ToInt32(comboBoxPrediseñada.Text),Convert.ToInt32(comboBoxPrediseñada.Text));
        //    Icon icon = System.Drawing.Icon.FromHandle(a.GetHicon());
        //    pictureBox1.Cursor = new Cursor(icon.Handle);

        }

        private void button26_Click(object sender, EventArgs e)
        {
            figura = "Agua";
        }

        private void buttonOtros_Click(object sender, EventArgs e)
        {
            figura = "Otros";
        }

        private void buttonCirCaja_Click(object sender, EventArgs e)
        {
            figura = "Caja Circulo";
        }

        private void buttonInsecto_Click(object sender, EventArgs e)
        {
            figura = "Insecto";
        }

        private void buttonBasura_Click(object sender, EventArgs e)
        {
            figura = "Basura";
        }

        private void buttonCancha_Click(object sender, EventArgs e)
        {
            figura = "Cancha";
        }

        private void buttonEstacionamiento_Click(object sender, EventArgs e)
        {
            figura = "Estacionamiento";
        }

        private void buttonMadriguera_Click(object sender, EventArgs e)
        {
            figura = "Madriguera";
        }

        private void buttonEstanque_Click(object sender, EventArgs e)
        {
            figura = "Estanque";
        }

        private void buttonBaño_Click(object sender, EventArgs e)
        {
            figura = "Baño";
        }

        private void buttonZanja_Click(object sender, EventArgs e)
        {
            figura = "Zanja";
        }

        private void buttonEscalera_Click(object sender, EventArgs e)
        {
            figura = "Escalera";
        }

        private void buttonTechado_Click(object sender, EventArgs e)
        {
            figura = "Techo";
        }

        private void buttonArbol_Click(object sender, EventArgs e)
        {
            figura = "Arbol";
        }

        private void buttonPozo_Click(object sender, EventArgs e)
        {
            figura = "Pozo";
        }
        private void buttonPalabra_Click(object sender, EventArgs e)
        {
            figura = "Palabra";
        }

        private void buttonEstablecer_Click(object sender, EventArgs e)
        {
            textBox7.Text = textBox1.Text;
            Establecer = true;
            if (comboBox3.Text == "")
            {

                MessageBox.Show("Debe establecer plano");
            }
            else
            {
                MessageBox.Show("Plano Establecido");
                EditorPlano ped = new EditorPlano();
                ped.addPlano(textBox2.Text, textBox1.Text, textBox3.Text, comboBox4.Text, comboBox3.Text);
            }
            int unibux = 0;
            CatalogoPlanocs cunitsbuxx = new CatalogoPlanocs();
            unibux = cunitsbuxx.getNumero("Tubo Cebadero", textBox1.Text);
            contcri = unibux;
            CatalogoPlanocs cunitsbuxx1 = new CatalogoPlanocs();
            unibux = cunitsbuxx.getNumero("Fly Out", textBox1.Text);
            controjo = unibux;
            CatalogoPlanocs cunitsbuxx2 = new CatalogoPlanocs();
            unibux = cunitsbuxx.getNumero("Veneno Anclado", textBox1.Text);
            contancla = unibux;
            CatalogoPlanocs cunitsbuxx3 = new CatalogoPlanocs();
            unibux = cunitsbuxx.getNumero("Trampa de Agua", textBox1.Text);
            contgota = unibux;
            CatalogoPlanocs cunitsbuxx4 = new CatalogoPlanocs();
            unibux = cunitsbuxx.getNumero("Caja Cebadera", textBox1.Text);
            contcaja = unibux;
            CatalogoPlanocs cunitsbuxx5 = new CatalogoPlanocs();
            unibux = cunitsbuxx.getNumero("Trampa Pegajosa", textBox1.Text);
            conttri = unibux;
            CatalogoPlanocs cunitsbuxx6 = new CatalogoPlanocs();
            unibux = cunitsbuxx.getNumero("Trampa Captura Viva", textBox1.Text);
            concua = unibux;

        }


        private void buttonHistorial_Click(object sender, EventArgs e)
        {
            HistorialDispositivos hit = new HistorialDispositivos(ref instance);
            hit.textBox1.Text = textBox1.Text;

            hit.Show();
        }


        private void buttonGuardar_Click(object sender, EventArgs e)
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

        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {

            cargado = true;
            o.Filter = "Png files|*.png|jpeg files|*jpg|bitmaps|*.bmp";
            if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string archivo;
                string ruta;
                pictureBox1.Image = System.Drawing.Image.FromFile(o.FileName);
                wx = pictureBox1.Image.Width;
                wy = pictureBox1.Image.Height;

                ruta = o.FileName;
                archivo = Path.GetFileName(ruta);
                string[] separadas;

                separadas = archivo.Split('-');
                cargar = true;
                textBox1.Text = separadas[0];
                pictureBox1.Invalidate();
                wx = pictureBox1.Width;
                wy = pictureBox1.Height;
                imgOriginal = pictureBox1.Image;



            }
        }



        private void buttonBorrar_Click(object sender, EventArgs e)
        {


            pictureBox1.Refresh();

            if (comboBox8.Text == "Lineas")
            {
                if (m_lstOfLine.Count >= 1)
                {
                    m_lstOfLine.RemoveAt(m_lstOfLine.Count - 1);
                    Refresh();
                    recargar();
                    pictureBox1.Update();

                }
            }
            if (comboBox8.Text == "Circulos")
            {
                if (m_lstOfCircle.Count >= 1)
                {

                    m_lstOfCircle.RemoveAt(m_lstOfCircle.Count - 1);
                    Refresh();
                    recargar();
                    pictureBox1.Update();
                }
            }
            if (comboBox8.Text == "Cuadrados")
            {
                if (m_lstOfRectangulo.Count >= 1)
                {

                    m_lstOfRectangulo.RemoveAt(m_lstOfRectangulo.Count - 1);
                    Refresh();
                    recargar();
                    pictureBox1.Update();

                }
            }

            if (comboBox8.Text == "Zona Basureros")
            {
                if (m_lstOfBasura.Count >= 1)
                {

                    m_lstOfBasura.RemoveAt(m_lstOfBasura.Count - 1);
                    Refresh();
                    recargar();
                    pictureBox1.Update();
                }
            }
            if (comboBox8.Text == "Árbol")
            {
                if (m_lstOfArbol.Count >= 1)
                {

                    m_lstOfArbol.RemoveAt(m_lstOfArbol.Count - 1);
                    Refresh();
                    recargar();
                    pictureBox1.Update();
                }
            }
            if (comboBox8.Text == "Cancha")
            {
                if (m_lstOfCancha.Count >= 1)
                {


                    m_lstOfCancha.RemoveAt(m_lstOfCancha.Count - 1);
                    Refresh();
                    recargar();
                    pictureBox1.Update();

                }
            }
            if (comboBox8.Text == "Palabras")
            {
                if (listpalabra.Count >= 1)
                {

                    listpalabra.RemoveAt(listpalabra.Count - 1);
                    Refresh();
                    recargar();
                    pictureBox1.Update();


                }
            }

            if (comboBox8.Text == "Estacionamiento")
            {
                if (m_lstOfEsta.Count >= 1)
                {

                    m_lstOfEsta.RemoveAt(m_lstOfEsta.Count - 1);

                    Refresh();
                    recargar();
                    pictureBox1.Update();

                }
            }
            if (comboBox8.Text == "Baño")
            {
                if (m_lstOfBaño.Count >= 1)
                {
                    m_lstOfBaño.RemoveAt(m_lstOfBaño.Count - 1);
                    Refresh();
                    recargar();
                    pictureBox1.Update();
                }
            }
            if (comboBox8.Text == "Escaleras")
            {
                if (m_lstOfEscalera.Count >= 1)
                {
                    m_lstOfEscalera.RemoveAt(m_lstOfEscalera.Count - 1);
                    Refresh();
                    recargar();
                    pictureBox1.Update();
                }
            }
            if (comboBox8.Text == "Zona Madriguera")
            {
                if (m_lstOfZona.Count >= 1)
                {
                    m_lstOfZona.RemoveAt(m_lstOfZona.Count - 1);
                    Refresh();
                    recargar();
                    pictureBox1.Update();
                }
            }


            recargar();




        }

        private void buttonPuntero_Click(object sender, EventArgs e)
        {

            figura = "";
            this.Cursor = Cursors.Default;


        }

        private void buttonMover_Click(object sender, EventArgs e)
        {
            if (figura == "Caja")
            {
                RectanguloFill m_cua2 = m_lstOfCua.FirstOrDefault(x => x.CodPlano == textBox7.Text && (x.Numero == Convert.ToInt32(textBox5.Text)) && (x.Tipo == textBox6.Text));
                m_cua = m_cua2;
            }
            if (figura == "Cebadero")
            {
                fillCirculo m_cir2 = m_lstOfCir.FirstOrDefault(x => x.CodPlano == textBox7.Text && (x.Numero == Convert.ToInt32(textBox5.Text)) && (x.Tipo == textBox6.Text));
                m_cir = m_cir2;
            }
            if (figura == "Fly Out")
            {
                RojoRectangulo m_rrojo2 = m_lstOfRRojo.FirstOrDefault(x => x.CodPlano == textBox7.Text && (x.Numero == Convert.ToInt32(textBox5.Text)) && (x.Tipo == textBox6.Text));
                m_rrojo = m_rrojo2;
            }
            if (figura == "Pejagosa")
            {
                Triangulo1 m_tri2 = m_lstOfTri.FirstOrDefault(x => x.CodPlano == textBox7.Text && (x.Numero == Convert.ToInt32(textBox5.Text)) && (x.Tipo == textBox6.Text));
                m_tri = m_tri2;
            }
            if (figura == "Anclado")
            {
                Anclado m_ancla2 = m_lstOfancla.FirstOrDefault(x => x.CodPlano == textBox7.Text && (x.Numero == Convert.ToInt32(textBox5.Text)) && (x.Tipo == textBox6.Text));
                m_ancla = m_ancla2;
            }
            if (figura == "Agua")
            {
                Gota m_gota2 = m_lstOfGota.FirstOrDefault(x => x.CodPlano == textBox7.Text && (x.Numero == Convert.ToInt32(textBox5.Text)) && (x.Tipo == textBox6.Text));
                m_gota = m_gota2;
            }
            if (figura == "Otros")
            {
                Otros m_otros2 = m_lstOfOtros.FirstOrDefault(x => x.CodPlano == textBox7.Text && (x.Numero == Convert.ToInt32(textBox5.Text)) && (x.Tipo == textBox6.Text));
                m_Otros = m_otros2;
            }
            if (figura == "Caja Circulo")
            {
                Caja m_caja2 = m_lstOfCaja.FirstOrDefault(x => x.CodPlano == textBox7.Text && (x.Numero == Convert.ToInt32(textBox5.Text)) && (x.Tipo == textBox6.Text));
                m_caja = m_caja2;
            }
            if (figura == "Insecto")
            {
                Insecto m_insecto2 = m_lstOfInsecto.FirstOrDefault(x => x.CodPlano == textBox7.Text && (x.Numero == Convert.ToInt32(textBox5.Text)) && (x.Tipo == textBox6.Text));
                m_insecto = m_insecto2;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            CatalogoDispoitivo ac = new CatalogoDispoitivo();
            ac.eliminarDispositivo(textBox8.Text);
            MessageBox.Show("Dispositivo Eliminado");
            if (textBox8.Text == "Tubo Cebadero")
            {
                contcri--;
            }
            if (textBox8.Text == "Trampa Captura Viva")
            {
                concua--;
            }
            if (textBox8.Text == " Fly Out")
            {
                controjo--;
            }
            if (textBox8.Text == "Trampa Pegajosa")
            {

            }
            if (textBox8.Text == "Veneno Anclado")
            {
                contancla--;
            }
            if (textBox8.Text == "Trampa de agua")
            {
                contgota--;
            }
            if (textBox8.Text == "Otros")
            {
                contOtros--;
            }
            if (textBox8.Text == "Caja Cebadera")
            {
                contcaja--;
            }
            if (textBox8.Text == "Trampa Insecto")
            {
                continsecto--;
            }

        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            cargado = true;
            m_lstOfancla.Clear();
            m_lstOfBaño.Clear();
            m_lstOfCaja.Clear();
            m_lstOfCir.Clear();
            m_lstOfCua.Clear();
            m_lstOfGota.Clear();
            m_lstOfInsecto.Clear();
            m_lstOfRectangulo.Clear();
            m_lstOfRRojo.Clear();
            m_lstOfTri.Clear();
            m_lstOfOtros.Clear();
            o.Filter = "Png files|*.png|jpeg files|*jpg|bitmaps|*.bmp";
            if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string archivo;
                string ruta;
                pictureBox1.Image = System.Drawing.Image.FromFile(o.FileName);
                wx = pictureBox1.Image.Width;
                wy = pictureBox1.Image.Height;

                ruta = o.FileName;
                archivo = Path.GetFileName(ruta);
                string[] separadas;

                separadas = archivo.Split('-');
                cargar = true;
                Establecer = true;
                textBox1.Text = separadas[0];

                textBox2.Text = separadas[1];
                pictureBox1.Invalidate();
                wx = pictureBox1.Width;
                wy = pictureBox1.Height;
                int aux = 0;
                CatalogoPlanocs cunitcod = new CatalogoPlanocs();
                aux = cunitcod.getCODPLANOO(textBox1.Text);

                textBox7.Text = textBox1.Text;

                int unibux = 0;
                CatalogoPlanocs cunitsbuxx = new CatalogoPlanocs();
                unibux = cunitsbuxx.getNumero("Tubo Cebadero", textBox1.Text);
                contcri = unibux;
                CatalogoPlanocs cunitsbuxx1 = new CatalogoPlanocs();
                unibux = cunitsbuxx.getNumero("Fly Out", textBox1.Text);
                controjo = unibux;
                CatalogoPlanocs cunitsbuxx2 = new CatalogoPlanocs();
                unibux = cunitsbuxx.getNumero("Veneno Anclado", textBox1.Text);
                contancla = unibux;
                CatalogoPlanocs cunitsbuxx3 = new CatalogoPlanocs();
                unibux = cunitsbuxx.getNumero("Trampa de Agua", textBox1.Text);
                contgota = unibux;
                CatalogoPlanocs cunitsbuxx4 = new CatalogoPlanocs();
                unibux = cunitsbuxx.getNumero("Caja Cebadera", textBox1.Text);
                contcaja = unibux;
                CatalogoPlanocs cunitsbuxx5 = new CatalogoPlanocs();
                unibux = cunitsbuxx.getNumero("Trampa Pegajosa", textBox1.Text);
                conttri = unibux;
                CatalogoPlanocs cunitsbuxx6 = new CatalogoPlanocs();
                unibux = cunitsbuxx.getNumero("Trampa Captura Viva", textBox1.Text);
                concua = unibux;

            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                automatico = true;
            }
            else
            {

                if (checkBox2.Checked == false)
                {
                    automatico = false;
                }
            }
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            figura = "Rosa";
        }

        private void PlanosEsamV2cs_Resize(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
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
            pdfTabletitulo.DefaultCell.Padding = 4;
            pdfTabletitulo.WidthPercentage = 100;
            pdfTabletitulo.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTabletitulo.DefaultCell.BorderWidth = 1;

            PdfPTable pdft = new PdfPTable(4);
            pdft.DefaultCell.Padding = 4;
            pdft.WidthPercentage = 100;
            pdft.HorizontalAlignment = Element.ALIGN_LEFT;
            pdft.DefaultCell.BorderWidth = 4;

            PdfPCell cltitulo = new PdfPCell(new Phrase(textBox2.Text));
            cltitulo.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            cltitulo.HorizontalAlignment = Element.ALIGN_CENTER;
            PdfPCell clPlano = new PdfPCell(new Phrase("N° PLANO:" + " " + textBox1.Text));
            clPlano.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            clPlano.HorizontalAlignment = Element.ALIGN_CENTER;
            PdfPCell clTEC = new PdfPCell(new Phrase("Actualizado Por:" + " " + comboBox1.Text));
            clTEC.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            clTEC.HorizontalAlignment = Element.ALIGN_CENTER;

            PdfPCell clcoord = new PdfPCell(new Phrase("Coordenadas:" + " " + textBox3.Text));
            clcoord.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            clcoord.HorizontalAlignment = Element.ALIGN_CENTER;
            PdfPCell cltri = new PdfPCell(new Phrase("Trampa Pegajosa:" + Convert.ToString(conttri)));
            cltri.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            cltri.HorizontalAlignment = Element.ALIGN_LEFT;
            PdfPCell clcua = new PdfPCell(new Phrase("Trampa Captura Viva:" + Convert.ToString(concua)));
            clcua.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            clcua.HorizontalAlignment = Element.ALIGN_LEFT;
            PdfPCell clcir = new PdfPCell(new Phrase("Tubo Cebadero:" + Convert.ToString(contcri)));
            clcir.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            clcir.HorizontalAlignment = Element.ALIGN_LEFT;
            PdfPCell clrojo = new PdfPCell(new Phrase("Fly Out:" + Convert.ToString(controjo)));
            clrojo.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            clrojo.HorizontalAlignment = Element.ALIGN_LEFT;
            PdfPCell clancla = new PdfPCell(new Phrase("Veneno Ancaldo:" + Convert.ToString(contancla)));
            clancla.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            clancla.HorizontalAlignment = Element.ALIGN_LEFT;
            PdfPCell clgota = new PdfPCell(new Phrase("Trampa de Agua:" + Convert.ToString(contgota)));
            clgota.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            clgota.HorizontalAlignment = Element.ALIGN_LEFT;
            PdfPCell clcaja = new PdfPCell(new Phrase("Caja Cebadera:" + Convert.ToString(contcaja)));
            clcaja.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            clcaja.HorizontalAlignment = Element.ALIGN_LEFT;
            PdfPCell clOtros = new PdfPCell(new Phrase("Otros:" + Convert.ToString(contcaja)));
            clcaja.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            clcaja.HorizontalAlignment = Element.ALIGN_LEFT;
            PdfPCell clBaños = new PdfPCell(new Phrase("Baños:" + textBox9.Text));
            clBaños.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            clBaños.HorizontalAlignment = Element.ALIGN_LEFT;
            DateTime fechaHoy = DateTime.Today;
            string fecha = "";
            fecha = fechaHoy.ToString();
            PdfPCell clFecha = new PdfPCell(new Phrase("Fecha:" + fecha));
            clFecha.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            clFecha.HorizontalAlignment = Element.ALIGN_LEFT;

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
            PdfPTable pdfBaños = new PdfPTable(1);
            pdfBaños.DefaultCell.Padding = 1;
            pdfBaños.WidthPercentage = 100;
            pdfBaños.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfBaños.DefaultCell.BorderWidth = 1;

            pdfTabletitulo.AddCell(cltitulo);
            pdft.AddCell(clcoord);
            pdft.AddCell(clFecha);
            pdft.AddCell(clTEC);
            pdft.AddCell(clPlano);
            pdfTableancla.AddCell(clancla);
            pdfTablecaja.AddCell(clcaja);
            pdfTablecir.AddCell(clcir);
            pdfTablecua.AddCell(clcua);
            pdfTablegota.AddCell(clgota);
            pdfTablerojo.AddCell(clrojo);
            pdfTabletri.AddCell(cltri);
            pdfTableOtros.AddCell(clOtros);
            pdfBaños.AddCell(clBaños);
            //Exportar a PDF
            string folderPath = "C:\\check\\";
            if (!Directory.Exists(folderPath))
            {

                Directory.CreateDirectory(folderPath);
            }
            string hoy = DateTime.Now.Hour.ToString();

            using (FileStream stream = new FileStream(folderPath + textBox1.Text + "-" + textBox2.Text + ".pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);

                pdfDoc.Open();

                iTextSharp.text.Image imagen1 = iTextSharp.text.Image.GetInstance(@"\\STORAGE\\Public\\Esam compartido\\Informática\\esam.jpg");

                imagen1.BorderWidth = 0;
                imagen1.Alignment = Element.ALIGN_LEFT;
                float percentage = 0.0f;
                percentage = 150 / imagen1.Width;
                imagen1.ScalePercent(percentage * 100);
                iTextSharp.text.Image imagen2 = iTextSharp.text.Image.GetInstance(s.FileName);

                imagen2.Alignment = Element.ALIGN_CENTER;
                imagen2.ScaleAbsolute(wx, wy);

                pdfDoc.Add(imagen1);
                pdfDoc.Add(pdfTabletitulo);
                pdfDoc.Add(pdft);
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


                System.Diagnostics.Process.Start("IExplore.exe", folderPath + textBox1.Text + "-" + textBox2.Text + ".pdf");

            }

        }
        System.Drawing.Image Zoom(System.Drawing.Image img, Size size)
        {
            Bitmap bmp = new Bitmap(img, img.Width + (img.Width *60* size.Width / 400), img.Height + (img.Height *60* size.Height / 400));
            Graphics g = Graphics.FromImage(bmp);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return bmp;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value >= 0)
            {
                pictureBox1.Image = Zoom(imgOriginal, new Size(trackBar1.Value, trackBar1.Value));
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("magnify.exe");
        }

        private void buttonRestaurar_Click(object sender, EventArgs e)
        {

        }
    }
}
