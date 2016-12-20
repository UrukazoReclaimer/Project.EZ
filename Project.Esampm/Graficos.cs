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
        public Graficos()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
      
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Graficos_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CatalogoInformes clp = new CatalogoInformes();
            List<InformeGraficos> lista = new List<InformeGraficos>();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            lista = clp.InformebuscarGraficos(dateTimePicker1.Text, dateTimePicker2.Text);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            this.dataGridView2.DataSource = lista;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // chart1.Titles.Add("Grafica de porcentaje promedio de consumos");
          //  chart1.Series["Consumo"].SmartLabelStyle.Enabled = true;
        //    chart1.ChartAreas[0].AxisX.Maximum = 13;
        //    chart1.ChartAreas[0].AxisX.Minimum = 0;
        //     chart1.Series["Consumo"].Label = "Y = #VALY\nX = #VALX";
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Debe Seleccionar Formato de Grafico");

            }
            else
            {
                chart1.Series["Consumo"].Points.Clear();   
                string a = "";
                string b = "";
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    // foreach (DataGridViewCell cell in row.Cells)
                    //{

                    a = "";
                    b = "";

                    //aux.Add(row.Cells["Consumo"].Value.ToString());
                    if (comboBox1.Text == "Puntos")
                    {
                        a = row.Cells["Consumo"].Value.ToString();
                        b = row.Cells["LugardeTratamiento"].Value.ToString();                       
                        chart1.Series["Consumo"].Points.AddXY(b, Convert.ToDouble(a));                     
                       chart1.Series["Consumo"].ChartType = SeriesChartType.Point;
                    }
                    a = "";
                    b = "";
                    if (comboBox1.Text == "Burbuja")
                    {
                        a = row.Cells["Consumo"].Value.ToString();
                        b = row.Cells["LugardeTratamiento"].Value.ToString();
                        chart1.Series["Consumo"].Points.AddXY(b, Convert.ToDouble(a));
                        chart1.Series["Consumo"].ChartType = SeriesChartType.Bubble;
                    }
                    a = "";
                    b = "";
                    if (comboBox1.Text == "Linea")
                    {
                        a = row.Cells["Consumo"].Value.ToString();
                        b = row.Cells["LugardeTratamiento"].Value.ToString();
                        chart1.Series["Consumo"].Points.AddXY(b, Convert.ToDouble(a));
                        chart1.Series["Consumo"].ChartType = SeriesChartType.Line;
                    }
                    a = "";
                    b = "";
                    if (comboBox1.Text == "Ranura")
                    {
                        a = row.Cells["Consumo"].Value.ToString();
                        b = row.Cells["LugardeTratamiento"].Value.ToString();
                        chart1.Series["Consumo"].Points.AddXY(b, Convert.ToDouble(a));
                        chart1.Series["Consumo"].ChartType = SeriesChartType.Spline;
                    }
                    a = "";
                    b = "";
                    if (comboBox1.Text == "Barras")
                    {
                        a = row.Cells["Consumo"].Value.ToString();
                        b = row.Cells["LugardeTratamiento"].Value.ToString();                    
                        chart1.Series["Consumo"].Points.AddXY(b, Convert.ToDouble(a));
                        chart1.Series["Consumo"].ChartType = SeriesChartType.Bar;
                     //   chart1.DataManipulator.CopySeriesValues("consumo", "");
                      
                    }
                    a = "";
                    b = "";
                    if (comboBox1.Text == "Columnas")
                    {
                        a = row.Cells["Consumo"].Value.ToString();
                        b = row.Cells["LugardeTratamiento"].Value.ToString();
                        chart1.Series["Consumo"].Points.AddXY(b, Convert.ToDouble(a));
                        chart1.Series["Consumo"].ChartType = SeriesChartType.Column;
                    }
                    a = "";
                    b = "";
                    if (comboBox1.Text == "Area")
                    {
                        a = row.Cells["Consumo"].Value.ToString();
                        b = row.Cells["LugardeTratamiento"].Value.ToString();
                        chart1.Series["Consumo"].Points.AddXY(b, Convert.ToDouble(a));
                        chart1.Series["Consumo"].ChartType = SeriesChartType.Area;
                    }

                    a = "";
                    b = "";
                    if (comboBox1.Text == "Pie")
                    {
                        a = row.Cells["Consumo"].Value.ToString();
                        b = row.Cells["LugardeTratamiento"].Value.ToString();
                        chart1.Series["Consumo"].Points.AddXY(b, Convert.ToDouble(a));
                        chart1.Series["Consumo"].ChartType = SeriesChartType.Pie;
                    }
                    a = "";
                    b = "";
                    if (comboBox1.Text == "Dona")
                    {
                        a = row.Cells["Consumo"].Value.ToString();
                        b = row.Cells["LugardeTratamiento"].Value.ToString();
                        chart1.Series["Consumo"].Points.AddXY(b, Convert.ToDouble(a));
                        chart1.Series["Consumo"].ChartType = SeriesChartType.Doughnut;
                    }
                    a = "";
                    b = "";
                    if (comboBox1.Text == "Rango")
                    {
                        a = row.Cells["Consumo"].Value.ToString();
                        b = row.Cells["LugardeTratamiento"].Value.ToString();
                        chart1.Series["Consumo"].Points.AddXY(b, Convert.ToDouble(a));
                        chart1.Series["Consumo"].ChartType = SeriesChartType.Range;
                    }
                    a = "";
                    b = "";
                    if (comboBox1.Text == "Radar")
                    {
                        a = row.Cells["Consumo"].Value.ToString();
                        b = row.Cells["LugardeTratamiento"].Value.ToString();
                        chart1.Series["Consumo"].Points.AddXY(b, Convert.ToDouble(a));
                        chart1.Series["Consumo"].ChartType = SeriesChartType.Radar;
                    }
                    a = "";
                    b = "";
                    if (comboBox1.Text == "Piramide")
                    {
                        a = row.Cells["Consumo"].Value.ToString();
                        b = row.Cells["LugardeTratamiento"].Value.ToString();
                        chart1.Series["Consumo"].Points.AddXY(b, Convert.ToDouble(a));
                        chart1.Series["Consumo"].ChartType = SeriesChartType.Pyramid;
                    }
                 
                }
            }
     
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PdfPTable pdfTabletitulo = new PdfPTable(1);
            pdfTabletitulo.DefaultCell.Padding = 3;
            pdfTabletitulo.WidthPercentage = 100;
            pdfTabletitulo.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTabletitulo.DefaultCell.BorderWidth = 1;

           
            PdfPTable pdfTable = new PdfPTable(3);
            pdfTable.DefaultCell.Padding = 1;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_RIGHT;
            pdfTable.DefaultCell.BorderWidth = 1;



            PdfPCell cltitulo = new PdfPCell(new Phrase("Informe Promedio De Porcentaje de Consumo Consumos"));
            cltitulo.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            cltitulo.HorizontalAlignment = Element.ALIGN_CENTER;


            pdfTabletitulo.AddCell(cltitulo);


            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {

                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);

                pdfTable.AddCell(cell);

            }

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

            //Exporting to PDF
            string folderPath = "C:\\check\\";
            if (!Directory.Exists(folderPath))
            {

                Directory.CreateDirectory(folderPath);
            }
          
            using (FileStream stream = new FileStream(folderPath + "InformedeServiciosPlanificados" + "-" + dateTimePicker1.Text + ".pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                // PdfWriter.GetInstance(pdfDoc, "Checklist");
                pdfDoc.Open();

               // iTextSharp.text.Image imagen1 = iTextSharp.text.Image.GetInstance(@"\\STORAGE\\Public\\Esam compartido\\Informática\\esam.jpg");
                iTextSharp.text.Image imagen1 = iTextSharp.text.Image.GetInstance("C:\\Users\\Urukazo\\Desktop\\respaldo bueno\\esam.jpg");
                imagen1.BorderWidth = 0;
                imagen1.Alignment = Element.ALIGN_LEFT;
                float percentage = 0.0f;
                percentage = 150 / imagen1.Width;
                imagen1.ScalePercent(percentage * 100);

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
                var chartimage = new MemoryStream();
                chart1.SaveImage(chartimage, ChartImageFormat.Png);
                iTextSharp.text.Image chart_image = iTextSharp.text.Image.GetInstance(chartimage.GetBuffer() );
                pdfDoc.Add(chart_image);
                pdfDoc.Close();

                stream.Close();
                if (comboBox5.Text == "Explorer")
                {
                    System.Diagnostics.Process.Start("IExplore.exe", folderPath + "InformedeServiciosPlanificados" + "-" + dateTimePicker1.Text + ".pdf");
                    
                }
                if (comboBox5.Text == "Nitro")
                {
                    System.Diagnostics.Process.Start("NitroPDF.exe", folderPath + "InformedeServiciosPlanificados" + "-" + dateTimePicker1.Text + ".pdf");
                    
                }
            }
        }

      
    }
}
