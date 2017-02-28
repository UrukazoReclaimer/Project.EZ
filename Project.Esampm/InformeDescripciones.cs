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

namespace Project.Esampm
{
    public partial class InformeDescripciones : Form
    {
        public InformeDescripciones()
        {
            InitializeComponent();
            CatalogoCliente cunits = new CatalogoCliente();
            List<cliente> uni = cunits.getclierut();
            this.comboBox2.DataSource = uni;
            this.comboBox2.DisplayMember = "nombre";
            this.comboBox2.ValueMember = "rut";

            CatalogoPlanilla ounits = new CatalogoPlanilla();
            List<LugarTratamiento> lu = ounits.allgetlugar();
            this.comboBox4.DataSource = lu;
            this.comboBox4.DisplayMember = "nombre";

            this.comboBox4.ValueMember = "rut";
        }

        private void InformeDescripciones_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
              CatalogoInformes clpe2 = new CatalogoInformes();
            List<InformeDescripcionClasecs> listaaa1 = new List<InformeDescripcionClasecs>();
            if (comboBox2.Text == ""  && comboBox4.Text == "" && comboBox5.Text == "")
            {
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                listaaa1 = clpe2.InformebuscarDescripcionesSoloFechas(dateTimePicker1.Text, dateTimePicker2.Text);
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                this.dataGridView1.DataSource = listaaa1;
            }
            if (comboBox2.Text != ""  && comboBox4.Text != "" && comboBox5.Text == "")
            {
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                listaaa1 = clpe2.InformebuscarDescripcionesClienteLugar(dateTimePicker1.Text, dateTimePicker2.Text, comboBox2.Text, comboBox4.Text);
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                this.dataGridView1.DataSource = listaaa1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PdfPTable pdfTabletitulo = new PdfPTable(1);
            pdfTabletitulo.DefaultCell.Padding = 3;
            pdfTabletitulo.WidthPercentage = 100;
            pdfTabletitulo.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTabletitulo.DefaultCell.BorderWidth = 1;


            PdfPTable pdfTable = new PdfPTable(11);
            pdfTable.DefaultCell.Padding = 1;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_RIGHT;
            pdfTable.DefaultCell.BorderWidth = 1;



            PdfPCell cltitulo = new PdfPCell(new Phrase("Informe Planificaciones Con Observaciones"));
            cltitulo.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            cltitulo.HorizontalAlignment = Element.ALIGN_CENTER;


            pdfTabletitulo.AddCell(cltitulo);


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

            //Exportar a PDF
            string folderPath = "C:\\check\\";
            if (!Directory.Exists(folderPath))
            {

                Directory.CreateDirectory(folderPath);
            }
            string hoy = DateTime.Now.Hour.ToString();
            //  comboBox1.Text = hoy;
            using (FileStream stream = new FileStream(folderPath + "Informe Planificaciones Con Observaciones" + "-" + dateTimePicker1.Text + ".pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);

                pdfDoc.Open();

                iTextSharp.text.Image imagen1 = iTextSharp.text.Image.GetInstance(@"\\STORAGE\\Public\\Esam compartido\\Informática\\esam.jpg");
                //   iTextSharp.text.Image imagen1 = iTextSharp.text.Image.GetInstance("C:\\Users\\Urukazo\\Desktop\\respaldo bueno\\esam.jpg");
                imagen1.BorderWidth = 0;
                imagen1.Alignment = Element.ALIGN_LEFT;
                float percentage = 0.0f;
                percentage = 150 / imagen1.Width;
                imagen1.ScalePercent(percentage * 100);

                pdfDoc.Add(imagen1);
                pdfDoc.Add(pdfTabletitulo);
                pdfDoc.Add(pdfTable);

                pdfDoc.Close();

                stream.Close();
                if (comboBox5.Text == "Explorer")
                {

                    System.Diagnostics.Process.Start("IExplore.exe", folderPath + "Informe Planificaciones Con Observaciones" + "-" + dateTimePicker1.Text + ".pdf");
                    // System.Diagnostics.Process.Start("NitroPDF.exe", folderPath + "Checklist" + "-" + comboBox1.Text + dateTimePicker1.Text + ".pdf");
                }
                if (comboBox5.Text == "Nitro")
                {
                    System.Diagnostics.Process.Start("IExplore.exe", folderPath + "Informe Planificaciones Con Observaciones" + "-" + dateTimePicker1.Text + ".pdf");
                }
            }
        }

        }
    }

