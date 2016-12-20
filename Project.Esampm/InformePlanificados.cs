using iTextSharp.text;
using iTextSharp.text.pdf;
using Project.BussinessRules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project.Esampm
{
    public partial class InformePlanificados : Form
    {
        public InformePlanificados()
        {
            InitializeComponent();



       
            CatalogoCliente cunits = new CatalogoCliente();
            List<cliente> uni = cunits.getclierut();
            this.comboBox2.DataSource = uni;
            this.comboBox2.DisplayMember = "nombre";
            this.comboBox2.ValueMember = "rut";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CatalogoPlanilla cat = new CatalogoPlanilla();
            cat.idioma();

            if (comboBox2.Text != "") {

                CatalogoPlanilla clp = new CatalogoPlanilla();
                List<Informeservicioplanificacion> lista = new List<Informeservicioplanificacion>();
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                lista = clp.Informebuscarplanillarealizadosconcliente(dateTimePicker1.Text, dateTimePicker2.Text, comboBox2.Text);
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                this.dataGridView1.DataSource = lista;


            }
            else
            {

                if (comboBox4.Text == "")
                {

                    CatalogoPlanilla clp = new CatalogoPlanilla();
                    List<Informeservicioplanificacion> lista = new List<Informeservicioplanificacion>();
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                    lista = clp.Informebuscarplanillarealizadossincliente(dateTimePicker1.Text, dateTimePicker2.Text);
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                    this.dataGridView1.DataSource = lista;

                }


            }

            if (comboBox4.Text != "") { 

            CatalogoPlanilla clp = new CatalogoPlanilla();
            List<Informeservicioplanificacion> lista = new List<Informeservicioplanificacion>();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            lista = clp.Informebuscarplanillarealizadosconlugar(dateTimePicker1.Text, dateTimePicker2.Text, comboBox4.Text);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            this.dataGridView1.DataSource = lista;

            }

         
        }
    
               
    
            
   
        

        private void InformePlanificados_Load(object sender, EventArgs e)
        {

        }
        public void graData()
        {
            CatalogoPlanilla ac = new CatalogoPlanilla();
            List<Informeservicioplanificacion> lista = new List<Informeservicioplanificacion>();

       
         
            this.dataGridView1.DataSource = lista;
            


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            CatalogoPlanilla ounits = new CatalogoPlanilla();
            List<LugarTratamiento> lu = ounits.getlugar(Convert.ToString(comboBox2.SelectedValue));
            this.comboBox4.DataSource = lu;
            this.comboBox4.DisplayMember = "nombre";
       
            this.comboBox2.ValueMember = "rut";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CatalogoPlanilla cat = new CatalogoPlanilla();
            cat.idioma();
        
            PdfPTable pdfTabletitulo = new PdfPTable(1);
            pdfTabletitulo.DefaultCell.Padding = 1;
            pdfTabletitulo.WidthPercentage = 100;
            pdfTabletitulo.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTabletitulo.DefaultCell.BorderWidth = 1;

   
            PdfPTable pdfTable = new PdfPTable(9);
            pdfTable.DefaultCell.Padding = 1;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTable.DefaultCell.BorderWidth = 1;

          

            PdfPTable pdfleyenda = new PdfPTable(1);
            pdfleyenda.DefaultCell.Padding = 1;
            pdfleyenda.WidthPercentage = 100;
            pdfleyenda.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfleyenda.DefaultCell.BorderWidth = 1;

            

            PdfPCell cltitulo = new PdfPCell(new Phrase("Resumen Planificacion de Servicios"));
            cltitulo.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            cltitulo.HorizontalAlignment = Element.ALIGN_CENTER;

        

            PdfPCell clleyenda = new PdfPCell(new Phrase("P: Planificado R: Realizado NR: No Realizado S: Suspendido RDC: Retiro Dispositivo Control"));
            clleyenda.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);

            pdfTabletitulo.AddCell(cltitulo);
            pdfleyenda.AddCell(clleyenda);



            if (comboBox1.Text == "Si")
            {
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {

                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);

                    pdfTable.AddCell(cell);

                }

                foreach (DataGridViewRow row in dataGridView1.Rows)
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
            }
            else
            {

                if (comboBox1.Text == "No") {

                    dataGridView2 = dataGridView1;
                  
                    dataGridView2.Columns.Remove("Tecnicos");
        
                    pdfTable = new PdfPTable(dataGridView2.ColumnCount);
                    pdfTable.DefaultCell.Padding = 1;
                    pdfTable.WidthPercentage = 100;
                    pdfTable.HorizontalAlignment = Element.ALIGN_RIGHT;
                    pdfTable.DefaultCell.BorderWidth = 1;
                   
                
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

                  
                
                }

           


              
            }
            //Exportar a PDF
            string folderPath = "C:\\check\\";
            if (!Directory.Exists(folderPath))
            {

                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "ResuemnPanificacionServicios" + "-" + comboBox1.Text + dateTimePicker1.Text + ".pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
          
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
               
                pdfDoc.Add(pdfleyenda);
                    pdfDoc.Close();

                stream.Close();
                 if (comboBox5.Text == "Explorer")
                {
                System.Diagnostics.Process.Start("IExplore.exe", folderPath + "ResuemnPanificacionServicios" + "-" + comboBox1.Text + dateTimePicker1.Text + ".pdf");
               
                 }
                 if (comboBox5.Text == "Nitro")
                 {
                     System.Diagnostics.Process.Start("NitroPDF.exe", folderPath + "ResuemnPanificacionServicios" + "-" + comboBox1.Text + dateTimePicker1.Text + ".pdf");
                 }
            }


        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
