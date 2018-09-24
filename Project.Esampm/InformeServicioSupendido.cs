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
    public partial class InformeServicioSupendido : Form
    {
        public InformeServicioSupendido()
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


            PdfPTable pdfTable = new PdfPTable(11);
            pdfTable.DefaultCell.Padding = 1;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_RIGHT;
            pdfTable.DefaultCell.BorderWidth = 1;

            PdfPTable pdfleyenda = new PdfPTable(1);
            pdfleyenda.DefaultCell.Padding = 1;
            pdfleyenda.WidthPercentage = 100;
            pdfleyenda.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfleyenda.DefaultCell.BorderWidth = 1;


            PdfPCell cltitulo = new PdfPCell(new Phrase("Informe de Servicios Suspendidos"));
            cltitulo.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            cltitulo.HorizontalAlignment = Element.ALIGN_CENTER;

            PdfPCell clleyenda = new PdfPCell(new Phrase("S: Semanal   Q: Quincenal    TR: Trimensual   M: Mensual    B: Bimensual   TMT: Trimestral    ST: Semestral    A: Anual   AS: A Solicitud    U: Unica Vez"));
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
            using (FileStream stream = new FileStream(folderPath + "InformedeServiciosSupendidos" + "-" + comboBox1.Text + ".pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);

                pdfDoc.Open();

                iTextSharp.text.Image imagen1 = iTextSharp.text.Image.GetInstance(@"\\STORAGE\\Public\\Esam compartido\\Informática\\esam.jpg");
               // iTextSharp.text.Image imagen1 = iTextSharp.text.Image.GetInstance("C:\\Users\\Urukazo\\Desktop\\respaldo bueno\\esam.jpg");
              //  iTextSharp.text.Image imagen1 = iTextSharp.text.Image.GetInstance("C:\\Users\\natal\\Desktop\\Ejecutableroot\\esam.jpg");
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

                    System.Diagnostics.Process.Start("IExplore.exe", folderPath + "InformedeServiciosSupendidos" + "-" + comboBox1.Text + ".pdf");
                    // System.Diagnostics.Process.Start("NitroPDF.exe", folderPath + "Checklist" + "-" + comboBox1.Text + dateTimePicker1.Text + ".pdf");
                }
                if (comboBox5.Text == "Nitro")
                {
                    System.Diagnostics.Process.Start("NitroPDF.exe", folderPath + "InformedeServiciosSupendidos" + "-" + comboBox1.Text + dateTimePicker1.Text + ".pdf");
                }
            }
        }
        /// <summary>
        /// Evento del boton para realizar busqueda de informacion y mostrarla en un datagridview.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox4.Text == "" && comboBox2.Text == "" && comboBox1.Text == "")
            {
                CatalogoInformes clpe = new CatalogoInformes();
                List<InformeServiciosSuspendidos> listaa = new List<InformeServiciosSuspendidos>();
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                listaa = clpe.InformebuscarServiciosSuspendidosSoloFechas(dateTimePicker1.Text, dateTimePicker2.Text);
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                this.dataGridView1.DataSource = listaa;

            }
            if (comboBox4.Text == "" && comboBox2.Text != "" && comboBox1.Text == "")
            {
                CatalogoInformes clpe = new CatalogoInformes();
                List<InformeServiciosSuspendidos> listaa = new List<InformeServiciosSuspendidos>();
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                listaa = clpe.InformebuscarServiciosSuspendidosSoloCliente(dateTimePicker1.Text, dateTimePicker2.Text,comboBox2.Text);
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                this.dataGridView1.DataSource = listaa;

            }
            if (comboBox4.Text != "" && comboBox2.Text == "" && comboBox1.Text == "")
            {
                CatalogoInformes clpe = new CatalogoInformes();
                List<InformeServiciosSuspendidos> listaa = new List<InformeServiciosSuspendidos>();
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                listaa = clpe.InformebuscarServiciosSuspendidosSololugar(dateTimePicker1.Text, dateTimePicker2.Text, comboBox4.Text);
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                this.dataGridView1.DataSource = listaa;

            }
            if (comboBox4.Text != "" && comboBox2.Text != "" && comboBox1.Text == "")
            {
                CatalogoInformes clpe = new CatalogoInformes();
                List<InformeServiciosSuspendidos> listaa = new List<InformeServiciosSuspendidos>();
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                listaa = clpe.InformebuscarServiciosSuspendidosClienteLugar(dateTimePicker1.Text, dateTimePicker2.Text, comboBox2.Text,comboBox4.Text);
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                this.dataGridView1.DataSource = listaa;

            }
            if (comboBox4.Text == "" && comboBox2.Text == "" && comboBox1.Text != "")
            {
                CatalogoInformes clpe = new CatalogoInformes();
                List<InformeServiciosSuspendidos> listaa = new List<InformeServiciosSuspendidos>();
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                listaa = clpe.InformebuscarServiciosSuspendidosTipo(dateTimePicker1.Text, dateTimePicker2.Text, comboBox1.Text);
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                this.dataGridView1.DataSource = listaa;

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InformeServicioSupendido_Load(object sender, EventArgs e)
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
    }
}
