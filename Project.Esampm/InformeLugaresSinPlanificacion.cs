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
    public partial class InformeLugaresSinPlanificacion : Form
    {
        public InformeLugaresSinPlanificacion()
        {
            InitializeComponent();


        }
        /// <summary>
        /// Evento del boton que realiza la funcion de buscar la informacion deseada y mostrar el resultado en el datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            CatalogoPlanilla clpe = new CatalogoPlanilla();
            List<InformeLugaresSPlanificacion> listaa = new List<InformeLugaresSPlanificacion>();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            listaa = clpe.InformebuscarLugaresSPlanificacion(comboBox1.Text,dateTimePicker1.Text,dateTimePicker2.Text);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            this.dataGridView1.DataSource = listaa;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Evento del boton que realiza la funcion de generar informe.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            PdfPTable pdfTabletitulo = new PdfPTable(1);
            pdfTabletitulo.DefaultCell.Padding = 3;
            pdfTabletitulo.WidthPercentage = 100;
            pdfTabletitulo.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTabletitulo.DefaultCell.BorderWidth = 1;

            PdfPTable pdfTable = new PdfPTable(5);
            pdfTable.DefaultCell.Padding = 1;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_RIGHT;
            pdfTable.DefaultCell.BorderWidth = 1;


            PdfPTable pdfleyenda = new PdfPTable(1);
            pdfleyenda.DefaultCell.Padding = 1;
            pdfleyenda.WidthPercentage = 100;
            pdfleyenda.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfleyenda.DefaultCell.BorderWidth = 1;

            PdfPCell cltitulo = new PdfPCell(new Phrase("Lugares sin Planificación"));
            cltitulo.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            cltitulo.HorizontalAlignment = Element.ALIGN_CENTER;

            PdfPCell clleyenda = new PdfPCell(new Phrase("S:Bioseguridad S1:Desratización S2:Sanitizacion S3:Desinsectación S4:Monitoreo de Insectos S5:Monitoreo de Aves S6:Retio de Dispositivos Control S7:Infraestructura MIP:Manejo Integral de Plagas LLD:Limpieza,Lavado y Desinfección S1(idc):Desratización(IDC)"));
            clleyenda.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);


            pdfTabletitulo.AddCell(cltitulo);
            pdfleyenda.AddCell(clleyenda);

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
            comboBox1.Text = hoy;
            using (FileStream stream = new FileStream(folderPath + "LugaressinPlanificacion" + "-" + comboBox1.Text + ".pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);

                pdfDoc.Open();

                iTextSharp.text.Image imagen1 = iTextSharp.text.Image.GetInstance(@"\\STORAGE\\Public\\Esam compartido\\Informática\\esam.jpg");
             //   iTextSharp.text.Image imagen1 = iTextSharp.text.Image.GetInstance("C:\\Users\\Urukazo\\Desktop\\respaldo bueno\\esam.jpg");
               // iTextSharp.text.Image imagen1 = iTextSharp.text.Image.GetInstance("C:\\Users\\natal\\Desktop\\Ejecutableroot\\esam.jpg");
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
                    System.Diagnostics.Process.Start("IExplore.exe", folderPath + "LugaressinPlanificacion" + "-" + comboBox1.Text + ".pdf");
                }
                if (comboBox5.Text == "Nitro")
                {
                    System.Diagnostics.Process.Start("NitroPDF.exe", folderPath + "LugaressinPlanificacion" + "-" + comboBox1.Text + ".pdf");
                }
                if (comboBox5.Text == "Acrobat")
                {
                    System.Diagnostics.Process.Start("AcroRd32.exe", folderPath + "LugaressinPlanificacion" + "-" + comboBox1.Text + ".pdf");
                }
            }


        }

        private void InformeLugaresSinPlanificacion_Load(object sender, EventArgs e)
        {

        }
        private void ExportarDataGridViewExcelPlanilla(DataGridView grd)
        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo =
                    (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                //Recorremos el DataGridView rellenando la hoja de trabajo
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    hoja_trabajo.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < grd.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < grd.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[i + 2, j + 1] = grd.Rows[i].Cells[j].Value;
                    }
                }
                libros_trabajo.SaveAs(fichero.FileName,
                    Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewExcelPlanilla(dataGridView1);
            MessageBox.Show("Exportación Realizada");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CatalogoPlanilla clpe = new CatalogoPlanilla();
            List<InformeLugaresSPlanificacion> listaa = new List<InformeLugaresSPlanificacion>();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            listaa = clpe.InformebuscarLugaresSPlanificacion(comboBox1.Text, dateTimePicker1.Text, dateTimePicker2.Text);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            this.dataGridView1.DataSource = listaa;
        }
    }
}
