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
    public partial class Informe : Form
    {
        List<int> list = new List<int>();
         DataGridViewColumn var;
        List<int> lint = new List<int>();
        public Informe()
        {

         
            List<int> lista = new List<int>();

            InitializeComponent();



            catalogoTecnico tunits = new catalogoTecnico();
            List<Project.BussinessRules.Tecnico> tec = tunits.gettec();
            this.comboBox1.DataSource = tec;
            this.comboBox1.DisplayMember = "nombre";
            this.comboBox1.ValueMember = "cod";


            CatalogoVehiculo units = new CatalogoVehiculo();
            List<Project.BussinessRules.vehiculo> vei = units.getvehiculocod();
            this.comboBox2.DataSource = vei;
            this.comboBox2.DisplayMember = "descripcion";
            this.comboBox2.ValueMember = "patente";
            var = dataGridView2.Columns[0];
          
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Informe_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.CurrentRow.Cells["FECHA"].Value==null)
            {
                MessageBox.Show("No hay datos en tabla");
            }
            else
            {
                List<Inventariado> lista = new List<Inventariado>();
                textBox4.Text = comboBox1.Text;
                dateTimePicker3.Format = DateTimePickerFormat.Custom;

                dateTimePicker3.CustomFormat = "yyyy-MM-dd";
                dateTimePicker3.Text = dataGridView2.CurrentRow.Cells["FECHA"].Value.ToString();
                textBox6.Text = dataGridView2.CurrentRow.Cells["LUGARDESS"].Value.ToString();


                dateTimePicker3.Format = DateTimePickerFormat.Custom;

                dateTimePicker3.CustomFormat = "yyyy-MM-dd";
                CatalogoPlanilla ounits = new CatalogoPlanilla();
                List<Periodicidad> lu = ounits.getcodperiodiInforme(dateTimePicker3.Text, textBox6.Text, textBox4.Text);
                this.comboBox4.DataSource = lu;
                this.comboBox4.DisplayMember = "cod";
                this.comboBox4.ValueMember = "cod";


            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

            CatalogoPlanilla clp = new CatalogoPlanilla();
            List<CheckList> lista = new List<CheckList>();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            lista = clp.Informebuscarplanilla(comboBox1.Text, dateTimePicker1.Text, dateTimePicker2.Text);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            this.dataGridView2.DataSource = lista;


            dateTimePicker3.CustomFormat = "yyyy-MM-dd";
            CatalogoPlanilla ounits = new CatalogoPlanilla();
            List<Periodicidad> lu = ounits.getcodperiodiInforme(dateTimePicker3.Text, textBox6.Text, textBox4.Text);
            this.comboBox4.DataSource = lu;
            this.comboBox4.DisplayMember = "cod";
            this.comboBox4.ValueMember = "cod";

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
       
            CatalogoPlanilla catalogo = new CatalogoPlanilla();
            List<Check> lu2 = catalogo.InformebuscarplanillaCod(comboBox1.Text, dateTimePicker1.Text, dateTimePicker2.Text);
            this.comboBox7.DataSource = lu2;
            this.comboBox7.DisplayMember = "cod";
            this.comboBox7.ValueMember = "cod";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd-MM-yyyy";
           
        }
        /// <summary>
        /// Metodo que construye el informe en fomato pdf, insertando las tablas y contenido deseado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
         
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox5.Text != "")
            {

             
                PdfPTable pdfTabletitulo = new PdfPTable(1);
                pdfTabletitulo.DefaultCell.Padding = 3;
                pdfTabletitulo.WidthPercentage = 100;
                pdfTabletitulo.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfTabletitulo.DefaultCell.BorderWidth = 1;

                // PdfPTable pdfTable = new PdfPTable(dataGridView2.ColumnCount);
                PdfPTable pdfTable = new PdfPTable(8);
                pdfTable.DefaultCell.Padding = 1;
                pdfTable.WidthPercentage = 100;
                pdfTable.HorizontalAlignment = Element.ALIGN_RIGHT;
                pdfTable.DefaultCell.BorderWidth = 1;


                PdfPTable pdft = new PdfPTable(3);
                pdft.DefaultCell.Padding = 3;
                pdft.WidthPercentage = 100;
                pdft.HorizontalAlignment = Element.ALIGN_LEFT;
                pdft.DefaultCell.BorderWidth = 3;


                PdfPTable pdftec = new PdfPTable(3);
                pdftec.DefaultCell.Padding = 3;
                pdftec.WidthPercentage = 100;
                pdftec.HorizontalAlignment = Element.ALIGN_LEFT;
                pdftec.DefaultCell.BorderWidth = 1;


                PdfPTable pdfacuso = new PdfPTable(1);
                pdfacuso.DefaultCell.Padding = 1;
                pdfacuso.WidthPercentage = 100;
                pdfacuso.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfacuso.DefaultCell.BorderWidth = 1;

                PdfPTable pdfobserva = new PdfPTable(1);
                pdfobserva.DefaultCell.Padding = 1;
                pdfobserva.WidthPercentage = 100;
                pdfobserva.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfobserva.DefaultCell.BorderWidth = 1;

                PdfPTable pdfdetalle = new PdfPTable(1);
                pdfdetalle.DefaultCell.Padding = 1;
                pdfdetalle.WidthPercentage = 100;
                pdfdetalle.HorizontalAlignment = Element.ALIGN_RIGHT;
                float[] medidaCeldas = { 200.0f };
                pdfdetalle.DefaultCell.BorderWidth = 1;
                //  pdfdetalle.SetWidths(medidaCeldas);




                //Creacion de celdas con PdfPCell

                PdfPCell cltitulo = new PdfPCell(new Phrase("CHECKLIST"));
                cltitulo.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                cltitulo.HorizontalAlignment = Element.ALIGN_CENTER;
                PdfPCell clNombre = new PdfPCell(new Phrase(comboBox1.Text));
                clNombre.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                PdfPCell clfecha = new PdfPCell(new Phrase(dateTimePicker1.Text));
                clfecha.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                PdfPCell cltecve = new PdfPCell(new Phrase("Aplicador responsable y vehiculo" + ":"));
                cltecve.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                PdfPCell clVehiculo = new PdfPCell(new Phrase(comboBox2.Text));
                clVehiculo.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                PdfPCell clfechve = new PdfPCell(new Phrase("Fecha de los servicios" + ":"));
                clfechve.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                PdfPCell clcolacion = new PdfPCell(new Phrase("colacion" + comboBox3.Text));
                clcolacion.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                PdfPCell clacuso = new PdfPCell(new Phrase(textBox2.Text));
                clacuso.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                PdfPCell clobserva = new PdfPCell(new Phrase(textBox1.Text));
                clobserva.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);

                PdfPCell cldetalle = new PdfPCell(new Phrase(textBox3.Text));
                cldetalle.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);

                //Insertar celdas de contenido a las tablas

                pdfTabletitulo.AddCell(cltitulo);
                pdft.AddCell(cltecve);
                pdft.AddCell(clNombre);
                pdft.AddCell(clVehiculo);

                pdftec.AddCell(clfechve);
                pdftec.AddCell(clfecha);
                pdftec.AddCell(clcolacion);

                pdfacuso.AddCell(clacuso);
                pdfobserva.AddCell(clobserva);
                pdfdetalle.AddCell(cldetalle);


                //Agregar Titulo de Datagradview
                foreach (DataGridViewColumn column in dataGridView2.Columns)
                {
                    if (column.HeaderText != "Fecha")
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                        cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);

                        pdfTable.AddCell(cell);
                    }
                }


                // Configuramos el título de las columnas de la tabla

                dataGridView2.Columns.Remove("Fecha");



                //Insertar filas de contenido de un DataGridview
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
                
                CatalogoInformes ac = new CatalogoInformes();
                string a = "";
                if (dataGridView2.CurrentRow.Cells["Certificado"].Value == null)
                {
                    a = "N/A";
                }

                int indexaux;
                indexaux = 0;
                string aux = "";
                int indexo = Convert.ToInt32(comboBox7.SelectedValue);
                for (int i = comboBox7.Items.Count - 1; i >= 0; i--)
                {

                 //   aux = "";
                   comboBox7.SelectedIndex=indexaux;
                   indexo= Convert.ToInt32(comboBox7.SelectedValue);
              
                   // indexo = Convert.ToInt32(aux);
                    lint.Add(indexo);
                    indexaux++;
                
                   

                }


               string b = "";      
               int index1 = 0;
               index1 = 0;
               for (int i = comboBox7.Items.Count - 1; i >= 0; i--)
                    {
              
                b = lint[index1].ToString();
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                Check c = new Check(a, textBox1.Text,dateTimePicker1.Text,b, textBox5.Text);
                ac.addCheck(c);
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                index1++;
                    }


                //Exportar a PDF
                string folderPath = "C:\\check\\";
                if (!Directory.Exists(folderPath))
                {

                    Directory.CreateDirectory(folderPath);
                }

                using (FileStream stream = new FileStream(folderPath + "Checklist" + "-" + comboBox1.Text + dateTimePicker1.Text + ".pdf", FileMode.Create))
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
                    pdfDoc.Add(pdft);
                    pdfDoc.Add(pdftec);
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Add(pdfacuso);
                    pdfDoc.Add(pdfobserva);
                    Paragraph saltoDeLinea1 = new Paragraph("  ");
                    pdfDoc.Add(saltoDeLinea1);
                    pdfDoc.Add(saltoDeLinea1);
                    pdfDoc.Add(saltoDeLinea1);
                    pdfDoc.Add(saltoDeLinea1);
                    pdfDoc.Add(saltoDeLinea1);
                    pdfDoc.Add(saltoDeLinea1);
                    pdfDoc.Add(saltoDeLinea1);
                    pdfDoc.Add(saltoDeLinea1);
                    pdfDoc.Add(saltoDeLinea1);
                    pdfDoc.Add(pdfdetalle);


                    pdfDoc.Close();

                    stream.Close();
                    dataGridView2.Columns.Add(var);


                    if (comboBox5.Text == "Explorer")
                    {
                        System.Diagnostics.Process.Start("IExplore.exe", folderPath + "Checklist" + "-" + comboBox1.Text + dateTimePicker1.Text + ".pdf");
                    }

                    if (comboBox5.Text == "Nitro")
                    {

                        System.Diagnostics.Process.Start("NitroPDF.exe", folderPath + "Checklist" + "-" + comboBox1.Text + dateTimePicker1.Text + ".pdf");
                    }

                    if (comboBox5.Text == "Acrobat")
                    {
                        if (folderPath.Contains(comboBox1.Text))
                        {
                            System.Diagnostics.Process.Start("AcroRD32.exe", folderPath + "Checklist" + "-" + comboBox1.Text + dateTimePicker1.Text + ".pdf");
                        }
                        else
                        {
                            MessageBox.Show("NO");
                        }



                    }


                }
            }
            else 
            {

                MessageBox.Show("Debe Elegir Visualizador");
            }
            //this.Close();
        }

        private void dataGridView2_KeyPress(object sender, KeyPressEventArgs e)
        {
            List<Inventariado> lista = new List<Inventariado>();
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                textBox4.Text = comboBox1.Text;
                dateTimePicker3.Format = DateTimePickerFormat.Custom;
               
                dateTimePicker3.CustomFormat = "yyyy-MM-dd";
                dateTimePicker3.Text = dataGridView2.CurrentRow.Cells["FECHA"].Value.ToString();
                textBox6.Text = dataGridView2.CurrentRow.Cells["LUGARDESS"].Value.ToString();
              
            }
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
          
            dateTimePicker3.CustomFormat = "yyyy-MM-dd";
            CatalogoPlanilla ounits = new CatalogoPlanilla();
            List<Periodicidad> lu = ounits.getcodperiodiInforme(dateTimePicker3.Text, textBox6.Text, textBox4.Text);
            this.comboBox4.DataSource = lu;
            this.comboBox4.DisplayMember = "cod";
            this.comboBox4.ValueMember = "cod"; 
            
       
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                MessageBox.Show("Debe seleccionar una visita");

            }
            else
            {
                dateTimePicker3.Format = DateTimePickerFormat.Custom;

                dateTimePicker3.CustomFormat = "yyyy-MM-dd";
                CatalogoPlanilla ounits = new CatalogoPlanilla();
                List<Periodicidad> lu = ounits.getcodperiodiInforme(dateTimePicker3.Text, textBox6.Text, textBox4.Text);
                this.comboBox4.DataSource = lu;
                this.comboBox4.DisplayMember = "cod";
                this.comboBox4.ValueMember = "cod";

                comboBox4.Text = Convert.ToString(comboBox4.SelectedValue);
                comboBox4.SelectedIndex = comboBox4.FindString(comboBox4.Text);
                int aux = comboBox4.SelectedIndex;
                int indexo = Convert.ToInt32(comboBox4.SelectedValue);
                for (int i = comboBox4.Items.Count - 1; i >= 0; i--)
                {


                    comboBox4.SelectedValue = indexo;

                    list.Add(indexo);
                    indexo++;
                }

                CatalogoPlanilla catalogo = new CatalogoPlanilla();
                int index1 = 0;
                int index = 0;
                string a = "";
                a = list[index].ToString();





                for (int i = comboBox4.Items.Count - 1; i >= 0; i--)
                {
                    a = "";
                    a = list[index].ToString();

                    Periodicidad ot = new Periodicidad(Convert.ToInt32(a), textBox7.Text);

                    catalogo.modOti(ot);
                    if (index1 < comboBox4.Items.Count - 1)
                    {

                        index1++;
                        index++;
                    }
                    else
                    {
                        index1 = index1;
                    }

                }
                list.Clear();
                CatalogoPlanilla clp = new CatalogoPlanilla();
                List<CheckList> lista = new List<CheckList>();
                lista = clp.Informebuscarplanilla(comboBox1.Text, dateTimePicker1.Text, dateTimePicker2.Text);
                this.dataGridView2.DataSource = lista;
                MessageBox.Show("Operacion Realizada");
            }

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            CatalogoInformes clp = new CatalogoInformes();
            List<VisualizadorCheckcs> lista = new List<VisualizadorCheckcs>();

            dateTimePicker4.Format = DateTimePickerFormat.Custom;
            dateTimePicker4.CustomFormat = "yyyy-MM-dd";

            lista = clp.InformeCheck( textBox5.Text,dateTimePicker4.Text);        
            dateTimePicker4.Format = DateTimePickerFormat.Custom;
            dateTimePicker4.CustomFormat = "dd-MM-yyyy";
            this.dataGridView2.DataSource = lista;
           
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Check which column is selected, otherwise set NewColumn to null.
            DataGridViewColumn newColumn =  dataGridView2.Columns.GetColumnCount(DataGridViewElementStates.Selected) == 1 ?
            dataGridView2.SelectedColumns[0] : null;

            DataGridViewColumn oldColumn = dataGridView2.SortedColumn;
            ListSortDirection direction;

            // If oldColumn is null, then the DataGridView is not currently sorted.
            if (oldColumn != null)
            {
                // Sort the same column again, reversing the SortOrder.
                if (oldColumn == newColumn &&
                    dataGridView2.SortOrder == SortOrder.Ascending)
                {
                    direction = ListSortDirection.Descending;
                }
                else
                {
                    // Sort a new column and remove the old SortGlyph.
                    direction = ListSortDirection.Ascending;
                    oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
                }
            }
            else
            {
                direction = ListSortDirection.Ascending;
            }

            // If no column has been selected, display an error dialog  box.
            if (newColumn == null)
            {
                MessageBox.Show("Select a single column and try again.",
                    "Error: Invalid Selection", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                dataGridView2.Sort(newColumn, direction);
                newColumn.HeaderCell.SortGlyphDirection =
                    direction == ListSortDirection.Ascending ?
                    SortOrder.Ascending : SortOrder.Descending;
            }
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker4.Format = DateTimePickerFormat.Custom;
            dateTimePicker4.CustomFormat = "yyyy-MM-dd";
            CatalogoInformes tunits = new CatalogoInformes();
            List<Project.BussinessRules.Check> tec = tunits.InformeCheckCod(dateTimePicker4.Text);
            this.comboBox6.DataSource = tec;
            this.comboBox6.DisplayMember = "nombre";
            this.comboBox6.ValueMember = "cod";
            dateTimePicker4.Format = DateTimePickerFormat.Custom;
            dateTimePicker4.CustomFormat = "dd-MM-yyyy";
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox5.Text=comboBox6.Text;
        }


    }
}