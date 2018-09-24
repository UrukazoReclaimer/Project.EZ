using iTextSharp.text;
using iTextSharp.text.pdf;
using Project.BussinessRules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Project.Esampm
{
    public partial class Graficos : Form
    {
        List<string> aux = new List<string>();
        List<string> lugares;
        Boolean Activa=false;
        
        public Graficos()
        {
            InitializeComponent();


            CatalogoCliente cunitsbu = new CatalogoCliente();
            List<cliente> unibu = cunitsbu.getclierut();
            this.comboBox8.DataSource = unibu;
            this.comboBox8.DisplayMember = "nombre";
            this.comboBox8.ValueMember = "rut"; 

            CatalogoPlanilla ounits4 = new CatalogoPlanilla();
            List<LugarTratamiento> lu4 = ounits4.allgetlugar();
            this.comboBox2.DataSource = lu4;
            this.comboBox2.DisplayMember = "nombre";
            this.comboBox2.ValueMember = "rut";

            ounits4.idioma();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Graficos_Load(object sender, EventArgs e)
        {
       lugares = new List<string>();
        }
        /// <summary>
        ///  Evento en el boton para llamar metodo InformeBuscarGraficos para traer informacion al datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (Activa == false)
            {
                CatalogoInformes clp1 = new CatalogoInformes();
                List<InformeGraficos> lista1 = new List<InformeGraficos>();
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                lista1 = clp1.InformebuscarGraficosOTI(dateTimePicker1.Text, dateTimePicker2.Text, lugares);
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                this.dataGridView1.DataSource = lista1;
            }
            else {
                if (Activa == true) 
                {
                    CatalogoInformes clp1 = new CatalogoInformes();
                    List<InformeGraficos> lista1 = new List<InformeGraficos>();
                    lista1 = clp1.InformebuscarGraficosOTIMES(textBox2.Text, textBox3.Text, lugares, textBox1.Text);                    
                    this.dataGridView1.DataSource = lista1;

                    CatalogoInformes clp2 = new CatalogoInformes();
                    List<InformeGraficos> lista2 = new List<InformeGraficos>();
                    lista2 = clp2.InformebuscarGraficosOTIMESNAME(textBox2.Text, textBox3.Text, lugares, textBox1.Text);
                    this.dataGridView3.DataSource = lista2;
                }
            }

            if (Activa == false)
            {

                if (comboBox7.Text == "Decimales")
                {
                    CatalogoInformes clp = new CatalogoInformes();
                    List<InformeGraficos> lista = new List<InformeGraficos>();
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                    lista = clp.InformebuscarGraficosFORDecimal(dateTimePicker1.Text, dateTimePicker2.Text, lugares, 1);
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                    this.dataGridView2.DataSource = lista;
                }
                else
                {
                    if (comboBox7.Text == "Enteros")
                    {
                        CatalogoInformes clp = new CatalogoInformes();
                        List<InformeGraficos> lista = new List<InformeGraficos>();
                        dateTimePicker1.Format = DateTimePickerFormat.Custom;
                        dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                        dateTimePicker2.Format = DateTimePickerFormat.Custom;
                        dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                        lista = clp.InformebuscarGraficosFORDecimal(dateTimePicker1.Text, dateTimePicker2.Text, lugares, 0);
                        dateTimePicker1.Format = DateTimePickerFormat.Custom;
                        dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                        dateTimePicker2.Format = DateTimePickerFormat.Custom;
                        dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                        this.dataGridView2.DataSource = lista;
                    }

                }
            }
            else {
                if (Activa == true) 
                {
                    if (comboBox7.Text == "Decimales")
                    {
                        CatalogoInformes clp = new CatalogoInformes();
                        List<InformeGraficos> lista = new List<InformeGraficos>();
                       
                        lista = clp.InformebuscarGraficosFORDecimalMES(textBox2.Text, textBox3.Text, lugares, 1,textBox1.Text);
                       
                        this.dataGridView2.DataSource = lista;
                    }
                    else
                    {
                        if (comboBox7.Text == "Enteros")
                        {
                            CatalogoInformes clp = new CatalogoInformes();
                            List<InformeGraficos> lista = new List<InformeGraficos>();

                            lista = clp.InformebuscarGraficosFORDecimalMES(textBox2.Text, textBox3.Text, lugares, 0, textBox1.Text);
                          
                            this.dataGridView2.DataSource = lista;
                        }

                    }
                
                }
            }
        }
        /// <summary>
        ///  Evento en el boton para cargar graficos atravez de la eleccion del formato que el usario requiera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == "")
            {
                MessageBox.Show("Debe Seleccionar Formato de Gráfico");

            }
            else
            {
                chart1.Series["Consumo"].Points.Clear();
                chart1.Series["Visitas"].Points.Clear();
                chart2.Series["Consumo"].Points.Clear();
                chart2.Series["Visitas"].Points.Clear();
                string a = "";
                string b = "";
                string c = "";
                string a2 = "";
                string b2 = "";
                string c2 = "";
                string d2 = "";
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {


                    a = "";
                    b = "";
                    c = "";

                    if (comboBox1.Text == "Puntos")
                    {
                        if (comboBox6.Text == "Consumos y Visitas")
                        {
                            //chart1.DataManipulator.Group("AVE", 1, IntervalType.Weeks, "MySeries1, MySeries2");
                            chart1.Series["Visitas"].Enabled = true;
                            a = row.Cells["Consumo"].Value.ToString();
                            b = row.Cells["LugardeTratamiento"].Value.ToString();
                            c = row.Cells["Visitas"].Value.ToString();
                            chart1.Series["Consumo"].Points.AddXY(b, Convert.ToDouble(a));
                            chart1.Series["Visitas"].Points.AddXY(b, Convert.ToDouble(c));
                            chart1.Series["Consumo"].ChartType = SeriesChartType.Point;
                            chart1.Series["Visitas"].ChartType = SeriesChartType.Point;
                        }
                        if (comboBox6.Text == "Solo Consumos")
                        {
                            chart1.Series["Visitas"].Enabled = true;
                            a = row.Cells["Consumo"].Value.ToString();
                            b = row.Cells["LugardeTratamiento"].Value.ToString();
                           // c = row.Cells["Visitas"].Value.ToString();
                            chart1.Series["Consumo"].Points.AddXY(b, Convert.ToDouble(a));
                           // chart1.Series["Visitas"].Points.AddXY(b, Convert.ToDouble(c));
                            chart1.Series["Consumo"].ChartType = SeriesChartType.Point;
                           // chart1.Series["Visitas"].ChartType = SeriesChartType.Point;
                        }
                        if (comboBox6.Text == "Solo Visitas")
                        {
                            chart1.Series["Visitas"].Enabled = true;
                           // a = row.Cells["Consumo"].Value.ToString();
                            b = row.Cells["LugardeTratamiento"].Value.ToString();
                             c = row.Cells["Visitas"].Value.ToString();
                            //chart1.Series["Consumo"].Points.AddXY(b, Convert.ToDouble(a));
                             chart1.Series["Visitas"].Points.AddXY(b, Convert.ToDouble(c));
                            //chart1.Series["Consumo"].ChartType = SeriesChartType.Point;
                             chart1.Series["Visitas"].ChartType = SeriesChartType.Point;
                        }
                     
                    }
                    a = "";
                    b = "";
                    c = "";
                    if (comboBox1.Text == "Burbuja")
                    {
                        if (comboBox6.Text == "Consumos y Visitas")
                        {
                            chart1.Series["Visitas"].Enabled = true;
                            a = row.Cells["Consumo"].Value.ToString();
                            b = row.Cells["LugardeTratamiento"].Value.ToString();
                            c = row.Cells["Visitas"].Value.ToString();
                            chart1.Series["Consumo"].Points.AddXY(b, Convert.ToDouble(a));
                            chart1.Series["Visitas"].Points.AddXY(b, Convert.ToDouble(c));
                            chart1.Series["Consumo"].ChartType = SeriesChartType.Bubble;
                            chart1.Series["Visitas"].ChartType = SeriesChartType.Bubble;
                        }
                        if (comboBox6.Text == "Solo Consumos")
                        {
                            chart1.Series["Visitas"].Enabled = true;
                            a = row.Cells["Consumo"].Value.ToString();
                            b = row.Cells["LugardeTratamiento"].Value.ToString();
                            // c = row.Cells["Visitas"].Value.ToString();
                            chart1.Series["Consumo"].Points.AddXY(b, Convert.ToDouble(a));
                            // chart1.Series["Visitas"].Points.AddXY(b, Convert.ToDouble(c));
                            chart1.Series["Consumo"].ChartType = SeriesChartType.Bubble;
                            // chart1.Series["Visitas"].ChartType = SeriesChartType.Point;
                        }
                        if (comboBox6.Text == "Solo Visitas")
                        {
                            chart1.Series["Visitas"].Enabled = true;
                            // a = row.Cells["Consumo"].Value.ToString();
                            b = row.Cells["LugardeTratamiento"].Value.ToString();
                            c = row.Cells["Visitas"].Value.ToString();
                            //chart1.Series["Consumo"].Points.AddXY(b, Convert.ToDouble(a));
                            chart1.Series["Visitas"].Points.AddXY(b, Convert.ToDouble(c));
                            //chart1.Series["Consumo"].ChartType = SeriesChartType.Point;
                            chart1.Series["Visitas"].ChartType = SeriesChartType.Bubble;
                        }
                    }
                    a = "";
                    b = "";
                    c = "";
                    if (comboBox1.Text == "Linea")
                    {
                        if (comboBox6.Text == "Consumos y Visitas")
                        {
                            chart1.Series["Visitas"].Enabled = true;
                            a = row.Cells["Consumo"].Value.ToString();
                            b = row.Cells["LugardeTratamiento"].Value.ToString();
                            c = row.Cells["Visitas"].Value.ToString();
                            chart1.Series["Consumo"].Points.AddXY(b, Convert.ToDouble(a));
                            chart1.Series["Visitas"].Points.AddXY(b, Convert.ToDouble(c));
                            chart1.Series["Consumo"].ChartType = SeriesChartType.Line;
                            chart1.Series["Visitas"].ChartType = SeriesChartType.Line;
                        }
                        if (comboBox6.Text == "Solo Consumos")
                        {
                            chart1.Series["Visitas"].Enabled = true;
                            a = row.Cells["Consumo"].Value.ToString();
                            b = row.Cells["LugardeTratamiento"].Value.ToString();
                            // c = row.Cells["Visitas"].Value.ToString();
                            chart1.Series["Consumo"].Points.AddXY(b, Convert.ToDouble(a));
                            // chart1.Series["Visitas"].Points.AddXY(b, Convert.ToDouble(c));
                            chart1.Series["Consumo"].ChartType = SeriesChartType.Line;
                            // chart1.Series["Visitas"].ChartType = SeriesChartType.Point;
                        }
                        if (comboBox6.Text == "Solo Visitas")
                        {
                            chart1.Series["Visitas"].Enabled = true;
                            // a = row.Cells["Consumo"].Value.ToString();
                            b = row.Cells["LugardeTratamiento"].Value.ToString();
                            c = row.Cells["Visitas"].Value.ToString();
                            //chart1.Series["Consumo"].Points.AddXY(b, Convert.ToDouble(a));
                            chart1.Series["Visitas"].Points.AddXY(b, Convert.ToDouble(c));
                            //chart1.Series["Consumo"].ChartType = SeriesChartType.Point;
                            chart1.Series["Visitas"].ChartType = SeriesChartType.Line;
                        }
                    }
                    a = "";
                    b = "";
                    c = "";
                    if (comboBox1.Text == "Ranura")
                    {
                        if (comboBox6.Text == "Consumos y Visitas")
                        {
                            chart1.Series["Visitas"].Enabled = true;
                            a = row.Cells["Consumo"].Value.ToString();
                            b = row.Cells["LugardeTratamiento"].Value.ToString();
                            c = row.Cells["Visitas"].Value.ToString();
                            chart1.Series["Consumo"].Points.AddXY(b, Convert.ToDouble(a));
                            chart1.Series["Visitas"].Points.AddXY(b, Convert.ToDouble(c));
                            chart1.Series["Consumo"].ChartType = SeriesChartType.Spline;
                            chart1.Series["Visitas"].ChartType = SeriesChartType.Spline;
                        }
                        if (comboBox6.Text == "Solo Consumos")
                        {
                            chart1.Series["Visitas"].Enabled = true;
                            a = row.Cells["Consumo"].Value.ToString();
                            b = row.Cells["LugardeTratamiento"].Value.ToString();
                            // c = row.Cells["Visitas"].Value.ToString();
                            chart1.Series["Consumo"].Points.AddXY(b, Convert.ToDouble(a));
                            // chart1.Series["Visitas"].Points.AddXY(b, Convert.ToDouble(c));
                            chart1.Series["Consumo"].ChartType = SeriesChartType.Spline;
                            // chart1.Series["Visitas"].ChartType = SeriesChartType.Point;
                        }
                        if (comboBox6.Text == "Solo Visitas")
                        {
                            chart1.Series["Visitas"].Enabled = true;
                            // a = row.Cells["Consumo"].Value.ToString();
                            b = row.Cells["LugardeTratamiento"].Value.ToString();
                            c = row.Cells["Visitas"].Value.ToString();
                            //chart1.Series["Consumo"].Points.AddXY(b, Convert.ToDouble(a));
                            chart1.Series["Visitas"].Points.AddXY(b, Convert.ToDouble(c));
                            //chart1.Series["Consumo"].ChartType = SeriesChartType.Point;
                            chart1.Series["Visitas"].ChartType = SeriesChartType.Spline;
                        }
                    }
                    a = "";
                    b = "";
                    c = "";
                    if (comboBox1.Text == "Barras")
                    {
                        if (comboBox6.Text == "Consumos y Visitas")
                        {

                            chart1.Series["Visitas"].Enabled = true;
                            a = row.Cells["Consumo"].Value.ToString();
                            b = row.Cells["LugardeTratamiento"].Value.ToString();
                            c = row.Cells["Visitas"].Value.ToString();
                            chart1.Series["Consumo"].Points.AddXY(b, Convert.ToDouble(a));
                            chart1.Series["Visitas"].Points.AddXY(b, Convert.ToDouble(c));
                            chart1.Series["Consumo"].ChartType = SeriesChartType.Bar;
                            chart1.Series["Visitas"].ChartType = SeriesChartType.Bar;
                        }
                        if (comboBox6.Text == "Solo Consumos")
                        {
                            chart1.Series["Visitas"].Enabled = true;
                            a = row.Cells["Consumo"].Value.ToString();
                            b = row.Cells["LugardeTratamiento"].Value.ToString();
                            // c = row.Cells["Visitas"].Value.ToString();
                            chart1.Series["Consumo"].Points.AddXY(b, Convert.ToDouble(a));
                            // chart1.Series["Visitas"].Points.AddXY(b, Convert.ToDouble(c));
                            chart1.Series["Consumo"].ChartType = SeriesChartType.Bar;
                            // chart1.Series["Visitas"].ChartType = SeriesChartType.Point;
                        }
                        if (comboBox6.Text == "Solo Visitas")
                        {
                            chart1.Series["Visitas"].Enabled = true;
                            // a = row.Cells["Consumo"].Value.ToString();
                            b = row.Cells["LugardeTratamiento"].Value.ToString();
                            c = row.Cells["Visitas"].Value.ToString();
                            //chart1.Series["Consumo"].Points.AddXY(b, Convert.ToDouble(a));
                            chart1.Series["Visitas"].Points.AddXY(b, Convert.ToDouble(c));
                            //chart1.Series["Consumo"].ChartType = SeriesChartType.Point;
                            chart1.Series["Visitas"].ChartType = SeriesChartType.Bar;
                        }


                    }
                    a = "";
                    b = "";
                    c = "";
                    if (comboBox1.Text == "Columnas")
                    {
                        if (comboBox6.Text == "Consumos y Visitas")
                        {
                            chart1.Series["Visitas"].Enabled = true;
                            a = row.Cells["Consumo"].Value.ToString();
                            b = row.Cells["LugardeTratamiento"].Value.ToString();
                            c = row.Cells["Visitas"].Value.ToString();
                            chart1.Series["Consumo"].Points.AddXY(b, Convert.ToDouble(a));
                            chart1.Series["Visitas"].Points.AddXY(b, Convert.ToDouble(c));                        
                            chart1.Series["Consumo"].ChartType = SeriesChartType.Column;
                            chart1.Series["Visitas"].ChartType = SeriesChartType.Column;

                          

                        }
                        if (comboBox6.Text == "Solo Consumos")
                        {
                            chart1.Series["Visitas"].Enabled = true;
                            a = row.Cells["Consumo"].Value.ToString();
                            b = row.Cells["LugardeTratamiento"].Value.ToString();
                            // c = row.Cells["Visitas"].Value.ToString();
                            chart1.Series["Consumo"].Points.AddXY(b, Convert.ToDouble(a));
                            // chart1.Series["Visitas"].Points.AddXY(b, Convert.ToDouble(c));
                            chart1.Series["Consumo"].ChartType = SeriesChartType.Column;
                            // chart1.Series["Visitas"].ChartType = SeriesChartType.Point;
                        }
                        if (comboBox6.Text == "Solo Visitas")
                        {
                            chart1.Series["Visitas"].Enabled = true;
                            // a = row.Cells["Consumo"].Value.ToString();
                            b = row.Cells["LugardeTratamiento"].Value.ToString();
                            c = row.Cells["Visitas"].Value.ToString();
                            //chart1.Series["Consumo"].Points.AddXY(b, Convert.ToDouble(a));
                            chart1.Series["Visitas"].Points.AddXY(b, Convert.ToDouble(c));
                            //chart1.Series["Consumo"].ChartType = SeriesChartType.Point;
                            chart1.Series["Visitas"].ChartType = SeriesChartType.Column;
                        }
                    }
                    a = "";
                    b = "";
                    c = "";
                    if (comboBox1.Text == "Area")
                    {
                        chart1.Series["Visitas"].Enabled = false;
                        a = row.Cells["Consumo"].Value.ToString();
                        b = row.Cells["LugardeTratamiento"].Value.ToString();
                     //   c = row.Cells["Visitas"].Value.ToString();
                        chart1.Series["Consumo"].Points.AddXY(b, Convert.ToDouble(a));
                   //     chart1.Series["Visitas"].Points.AddXY(b, Convert.ToDouble(c));
                        chart1.Series["Consumo"].ChartType = SeriesChartType.Area;
                       // chart1.Series["Visitas"].ChartType = SeriesChartType.Area;
                    }

                    a = "";
                    b = "";
                    c = "";
                    if (comboBox1.Text == "Pie")
                    {
                        chart1.Series["Visitas"].Enabled = false;
                        a = row.Cells["Consumo"].Value.ToString();
                        b = row.Cells["LugardeTratamiento"].Value.ToString();
                      //  c = row.Cells["Visitas"].Value.ToString();
                        chart1.Series["Consumo"].Points.AddXY(b, Convert.ToDouble(a));
                      //  chart1.Series["Visitas"].Points.AddXY(b, Convert.ToDouble(c));
                        chart1.Series["Consumo"].ChartType = SeriesChartType.Pie;
                      //  chart1.Series["Visitas"].ChartType = SeriesChartType.Pie;
                    }
                    a = "";
                    b = "";
                    c = "";
                    if (comboBox1.Text == "Dona")
                    {
                        chart1.Series["Visitas"].Enabled = false;
                        a = row.Cells["Consumo"].Value.ToString();
                        b = row.Cells["LugardeTratamiento"].Value.ToString();
                      //  c = row.Cells["Visitas"].Value.ToString();
                        chart1.Series["Consumo"].Points.AddXY(b, Convert.ToDouble(a));
                    //    chart1.Series["Visitas"].Points.AddXY(b, Convert.ToDouble(c));
                        chart1.Series["Consumo"].ChartType = SeriesChartType.Doughnut;
                       // chart1.Series["Visitas"].ChartType = SeriesChartType.Doughnut;
                    }
                    a = "";
                    b = "";
                    c = "";
                    if (comboBox1.Text == "Rango")
                    {
                        chart1.Series["Visitas"].Enabled = true;
                        a = row.Cells["Consumo"].Value.ToString();
                        b = row.Cells["LugardeTratamiento"].Value.ToString();
                        c = row.Cells["Visitas"].Value.ToString();
                        chart1.Series["Consumo"].Points.AddXY(b, Convert.ToDouble(a));
                        chart1.Series["Visitas"].Points.AddXY(b, Convert.ToDouble(c));
                        chart1.Series["Consumo"].ChartType = SeriesChartType.Range;
                        chart1.Series["Visitas"].ChartType = SeriesChartType.Range;
                    }
                    a = "";
                    b = "";
                    c = "";
                    if (comboBox1.Text == "Radar")
                    {
                        chart1.Series["Visitas"].Enabled = true;
                        a = row.Cells["Consumo"].Value.ToString();
                        b = row.Cells["LugardeTratamiento"].Value.ToString();
                        c = row.Cells["Visitas"].Value.ToString();
                        chart1.Series["Consumo"].Points.AddXY(b, Convert.ToDouble(a));
                        chart1.Series["Visitas"].Points.AddXY(b, Convert.ToDouble(c));
                        chart1.Series["Consumo"].ChartType = SeriesChartType.Radar;
                        chart1.Series["Visitas"].ChartType = SeriesChartType.Radar;
                    }
                    a = "";
                    b = "";
                    c = "";
                    if (comboBox1.Text == "Piramide")
                    {
                        chart1.Series["Visitas"].Enabled = false;
                        a = row.Cells["Consumo"].Value.ToString();
                        b = row.Cells["LugardeTratamiento"].Value.ToString();
                      //  c = row.Cells["Visitas"].Value.ToString();
                        chart1.Series["Consumo"].Points.AddXY(b, Convert.ToDouble(a));
                      //  chart1.Series["Visitas"].Points.AddXY(b, Convert.ToDouble(c));
                        chart1.Series["Consumo"].ChartType = SeriesChartType.Pyramid;
                     //   chart1.Series["Visitas"].ChartType = SeriesChartType.Pyramid;
                    }

                }

                foreach (DataGridViewRow row2 in dataGridView3.Rows)
                {                    
                    a2 = "";
                    b2 = "";
                    c2 = "";
                    if (comboBox1.Text == "Columnas")
                    {
                        if (comboBox6.Text == "Consumos y Visitas")
                        {
                            chart2.Series["Visitas"].Enabled = true;
                            a2 = row2.Cells["Consumo_Mensual"].Value.ToString();
                            b2 = row2.Cells["Mes"].Value.ToString();
                            c2= row2.Cells["Numero_Visitas"].Value.ToString();
                            d2 = row2.Cells["LugarT"].Value.ToString();
                            chart2.Series["Consumo"].Points.AddXY(d2+"-"+b2, Convert.ToDouble(a2));
                            chart2.Series["Visitas"].Points.AddXY(d2+"-"+b2, Convert.ToDouble(c2));
                           
                            chart2.Series["Consumo"].ChartType = SeriesChartType.Column;
                            chart2.Series["Visitas"].ChartType = SeriesChartType.Column;



                        }
                        if (comboBox6.Text == "Solo Consumos")
                        {
                            chart2.Series["Visitas"].Enabled = true;
                            a2 = row2.Cells["Consumo_mensual"].Value.ToString();
                            b2 = row2.Cells["LugarT"].Value.ToString();
                            // c = row.Cells["Visitas"].Value.ToString();
                            chart2.Series["Consumo"].Points.AddXY(b2, Convert.ToDouble(a2));
                            // chart1.Series["Visitas"].Points.AddXY(b, Convert.ToDouble(c));
                            chart2.Series["Consumo"].ChartType = SeriesChartType.Column;
                            // chart1.Series["Visitas"].ChartType = SeriesChartType.Point;
                        }
                        if (comboBox6.Text == "Solo Visitas")
                        {
                            chart2.Series["Visitas"].Enabled = true;
                            // a = row.Cells["Consumo"].Value.ToString();
                            b2 = row2.Cells["LugarT"].Value.ToString();
                            c2 = row2.Cells["Numero_Visitas"].Value.ToString();
                            //chart1.Series["Consumo"].Points.AddXY(b, Convert.ToDouble(a));
                            chart2.Series["Visitas"].Points.AddXY(b2, Convert.ToDouble(c2));
                            //chart1.Series["Consumo"].ChartType = SeriesChartType.Point;
                            chart2.Series["Visitas"].ChartType = SeriesChartType.Column;
                        }
                    }
                    a2 = "";
                    b2 = "";
                    c2 = "";
                    if (comboBox1.Text == "Puntos")
                    {
                        if (comboBox6.Text == "Consumos y Visitas")
                        {
                            chart2.Series["Visitas"].Enabled = true;
                            a2 = row2.Cells["Consumo_Mensual"].Value.ToString();
                            b2 = row2.Cells["Mes"].Value.ToString();
                            c2 = row2.Cells["Numero_Visitas"].Value.ToString();
                            d2 = row2.Cells["LugarT"].Value.ToString();
                            chart2.Series["Consumo"].Points.AddXY(d2 + "-" + b2, Convert.ToDouble(a2));
                            chart2.Series["Visitas"].Points.AddXY(d2 + "-" + b2, Convert.ToDouble(c2));

                            chart2.Series["Consumo"].ChartType = SeriesChartType.Point;
                            chart2.Series["Visitas"].ChartType = SeriesChartType.Point;
                        }
                        if (comboBox6.Text == "Solo Consumos")
                        {
                            chart2.Series["Visitas"].Enabled = true;
                            a2 = row2.Cells["Consumo_mensual"].Value.ToString();
                            b2 = row2.Cells["LugarT"].Value.ToString();
                            // c = row.Cells["Visitas"].Value.ToString();
                            chart2.Series["Consumo"].Points.AddXY(b2, Convert.ToDouble(a2));
                            // chart1.Series["Visitas"].Points.AddXY(b, Convert.ToDouble(c));
                            chart2.Series["Consumo"].ChartType = SeriesChartType.Point;
                            // chart1.Series["Visitas"].ChartType = SeriesChartType.Point;
                        }
                        if (comboBox6.Text == "Solo Visitas")
                        {
                            chart2.Series["Visitas"].Enabled = true;
                            // a = row.Cells["Consumo"].Value.ToString();
                            b2 = row2.Cells["LugarT"].Value.ToString();
                            c2 = row2.Cells["Numero_Visitas"].Value.ToString();
                            //chart1.Series["Consumo"].Points.AddXY(b, Convert.ToDouble(a));
                            chart2.Series["Visitas"].Points.AddXY(b2, Convert.ToDouble(c2));
                            //chart1.Series["Consumo"].ChartType = SeriesChartType.Point;
                            chart2.Series["Visitas"].ChartType = SeriesChartType.Point;
                        }

                    }
                  
                }

            }

        }
        /// <summary>
        ///  Evento en el boton para crear un documento .pdf con informacion del grafico
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            //creacion de un objeto tipo Pdftable para titulo del documento.
            PdfPTable pdfTabletitulo = new PdfPTable(1);
            pdfTabletitulo.DefaultCell.Padding = 3;
            pdfTabletitulo.WidthPercentage = 100;
            pdfTabletitulo.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTabletitulo.DefaultCell.BorderWidth = 1;

            //creacion de un objeto tipo Pdftable para la tabla de informacion del documento.
            PdfPTable pdfTable = new PdfPTable(3);
            pdfTable.DefaultCell.Padding = 1;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_RIGHT;
            pdfTable.DefaultCell.BorderWidth = 1;


            //creacion de un objeto tipo PdfCell para crear contenido dentro de una tabla especifica.
            PdfPCell cltitulo = new PdfPCell(new Phrase("Informe Promedio De Porcentaje de Consumo Consumos"));
            cltitulo.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            cltitulo.HorizontalAlignment = Element.ALIGN_CENTER;

            //se agrega el objeto Pdfcell al la tabla especificada.
            pdfTabletitulo.AddCell(cltitulo);

            //recorrer el datagridview por sus columnas
            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {

                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);

                pdfTable.AddCell(cell);

            }
            //recorrer el datagrdview por sus filas
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {

                    string s = "N/A";
                    if (cell.Value == null)
                    {
                        pdfTable.AddCell(s);

                    }
                    else
                    {

                        pdfTable.AddCell(cell.Value.ToString());
                    }

                }
            }

            //exportar a pdf en la direccion establecidad en la variable archivo
            string archivo = "C:\\check\\";
            if (!Directory.Exists(archivo))
            {

                Directory.CreateDirectory(archivo);
            }
            //se establece el nombre del documento y se admite operaciones de lectura.
            using (FileStream stream = new FileStream(archivo + "InformedeServiciosPlanificados" + "-" + dateTimePicker1.Text + ".pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                //se abre el docuemnto.
                pdfDoc.Open();

                 iTextSharp.text.Image imagen1 = iTextSharp.text.Image.GetInstance(@"\\STORAGE\\Public\\Esam compartido\\Informática\\esam.jpg");
              //  iTextSharp.text.Image imagen1 = iTextSharp.text.Image.GetInstance("C:\\Users\\Urukazo\\Desktop\\respaldo bueno\\esam.jpg");
                imagen1.BorderWidth = 0;
                imagen1.Alignment = Element.ALIGN_LEFT;
                float percentage = 0.0f;
                percentage = 150 / imagen1.Width;
                imagen1.ScalePercent(percentage * 100);
                //ingreso de tablas, saltos y graficos en el documento.
                pdfDoc.Add(imagen1);
                pdfDoc.Add(pdfTabletitulo);
                pdfDoc.Add(pdfTable);
                Paragraph saltoDeLinea1 = new Paragraph("  ");
                pdfDoc.Add(saltoDeLinea1);
                pdfDoc.Add(saltoDeLinea1);
                pdfDoc.Add(saltoDeLinea1);
                pdfDoc.Add(saltoDeLinea1);
                pdfDoc.Add(saltoDeLinea1);
                pdfDoc.Add(saltoDeLinea1);
                pdfDoc.Add(saltoDeLinea1);
                // valirable chartimagen guerda la imagen del grafico.
                var chartimagen = new MemoryStream();
                chart1.SaveImage(chartimagen, ChartImageFormat.Png);
                iTextSharp.text.Image chart_image = iTextSharp.text.Image.GetInstance(chartimagen.GetBuffer());                
                //ingreso del grafico al documento.
                pdfDoc.Add(chart_image);
                var chartimagen2 = new MemoryStream();
                chart2.SaveImage(chartimagen2, ChartImageFormat.Png);
                iTextSharp.text.Image chart_image2 = iTextSharp.text.Image.GetInstance(chartimagen2.GetBuffer());
                chart_image2.ScalePercent(100,150);              
                //ingreso del grafico al documento.
                pdfDoc.Add(chart_image2);
                //cierre del documento.
                pdfDoc.Close();
                stream.Close();
                //opciones de visualizacion.
                if (comboBox5.Text == "Explorer")
                {
                    System.Diagnostics.Process.Start("IExplore.exe", archivo + "InformedeServiciosPlanificados" + "-" + dateTimePicker1.Text + ".pdf");

                }
                if (comboBox5.Text == "Nitro")
                {
                    System.Diagnostics.Process.Start("NitroPDF.exe", archivo + "InformedeServiciosPlanificados" + "-" + dateTimePicker1.Text + ".pdf");

                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                if (comboBox2.Text != "Project.BussinessRules.LugarTratamiento")
                {
                    lugares.Add(comboBox2.Text);
                    comboBox3.Items.Add(comboBox2.Text);
                }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            lugares.Clear();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            if (Activa == true)
            {
                CatalogoPlanilla ounits = new CatalogoPlanilla();
                List<LugarTratamiento> lu = ounits.getlugar(Convert.ToString(comboBox8.SelectedValue));
                this.comboBox2.DataSource = lu;
                this.comboBox2.DisplayMember = "nombre";
                this.comboBox2.ValueMember = "rut";
            }
            */
        }

        private void comboBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }

        private void comboBox2_MouseClick(object sender, MouseEventArgs e)
        {
         
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Activa == false)
            {
                comboBox4.Enabled = true;
                comboBox9.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
                Activa = true;
            }
            else {

                if (Activa == true)
                {
                    comboBox4.Enabled = false;
                    comboBox9.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    dateTimePicker1.Enabled = true;
                    dateTimePicker2.Enabled = true;
                    Activa = false;
                }
            
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.Text == "Enero") 
            {
                textBox2.Text = "1";
            }
            if (comboBox4.Text == "Febrero")
            {
                textBox2.Text = "2";
            }
            if (comboBox4.Text == "Marzo")
            {
                textBox2.Text = "3";
            }
            if (comboBox4.Text == "Abril")
            {
                textBox2.Text = "4";
            }
            if (comboBox4.Text == "Mayo")
            {
                textBox2.Text = "5";
            }
            if (comboBox4.Text == "Junio")
            {
                textBox2.Text = "6";
            }
            if (comboBox4.Text == "Julio")
            {
                textBox2.Text = "7";
            }
            if (comboBox4.Text == "Agosto")
            {
                textBox2.Text = "8";
            }
            if (comboBox4.Text == "Septiembre")
            {
                textBox2.Text = "9";
            }
            if (comboBox4.Text == "Octubre")
            {
                textBox2.Text = "10";
            }
            if (comboBox4.Text == "Noviembre")
            {
                textBox2.Text = "11";
            }
            if (comboBox4.Text == "Diciembre")
            {
                textBox2.Text = "12";
            }
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox9.Text == "Enero")
            {
                textBox3.Text = "1";
            }
            if (comboBox9.Text == "Febrero")
            {
                textBox3.Text = "2";
            }
            if (comboBox9.Text == "Marzo")
            {
                textBox3.Text = "3";
            }
            if (comboBox9.Text == "Abril")
            {
                textBox3.Text = "4";
            }
            if (comboBox9.Text == "Mayo")
            {
                textBox3.Text = "5";
            }
            if (comboBox9.Text == "Junio")
            {
                textBox3.Text = "6";
            }
            if (comboBox9.Text == "Julio")
            {
                textBox3.Text = "7";
            }
            if (comboBox9.Text == "Agosto")
            {
                textBox3.Text = "8";
            }
            if (comboBox9.Text == "Septiembre")
            {
                textBox3.Text = "9";
            }
            if (comboBox9.Text == "Octubre")
            {
                textBox3.Text = "10";
            }
            if (comboBox9.Text == "Noviembre")
            {
                textBox3.Text = "11";
            }
            if (comboBox9.Text == "Diciembre")
            {
                textBox3.Text = "12";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }


    }
}
