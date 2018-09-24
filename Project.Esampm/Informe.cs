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
        DataGridViewColumn var2;
        List<int> lint = new List<int>();
        List<int> lintperio = new List<int>();
        List<int> lint2 = new List<int>();
        List<CheckList> lista1 = new List<CheckList>();
        List<string> listcertificado = new List<string>();
        Boolean guardar = false;
        /// <summary> 
        /// Inicializacion del formulario, llamar a metodos nesesarios para obtener informacion en los combobox
        /// </summary>
        public Informe()
        {


            List<int> lista = new List<int>();

            InitializeComponent();

            catalogoTecnico tunits = new catalogoTecnico();
            List<Project.BussinessRules.Tecnico> tec = tunits.obtenertec();
            this.comboBox1.DataSource = tec;
            this.comboBox1.DisplayMember = "nombre";
            this.comboBox1.ValueMember = "cod";

            CatalogoVehiculo units = new CatalogoVehiculo();
            List<Project.BussinessRules.vehiculo> vei = units.obtenerVehiculocod();
            this.comboBox2.DataSource = vei;
            this.comboBox2.DisplayMember = "descripcion";
            this.comboBox2.ValueMember = "patente";
            var = dataGridView2.Columns[0];
            var2 = dataGridView2.Columns[10];

            CatalogoInformes units4 = new CatalogoInformes();
            List<Check> vei4 = units4.getmaxidenticheck();
            this.comboBox8.DataSource = vei4;
            this.comboBox8.DisplayMember = "cod";
            this.comboBox8.ValueMember = "cod";


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Informe_Load(object sender, EventArgs e)
        {
          
        }
        /// <summary>
        /// Evento del datagrid para obtener informacion de la tabala en los textbox y combobox correspondientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.CurrentRow.Cells["FECHA"].Value == null)
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
                textBox6.Text = dataGridView2.CurrentRow.Cells["Lugardetratamiento"].Value.ToString();
                textBox5.Text = dataGridView2.CurrentRow.Cells["CODIGO"].Value.ToString();


                dateTimePicker3.Format = DateTimePickerFormat.Custom;

                dateTimePicker3.CustomFormat = "yyyy-MM-dd";
                CatalogoPlanilla ounits = new CatalogoPlanilla();
                List<Periodicidad> lu = ounits.obtenerCodPeriodiInformeCheck(dateTimePicker3.Text, textBox6.Text, textBox4.Text,textBox5.Text);
                this.comboBox4.DataSource = lu;
                this.comboBox4.DisplayMember = "cod";
                this.comboBox4.ValueMember = "cod";

                CatalogoPlanilla ounits2 = new CatalogoPlanilla();
                List<Check> lu2 = ounits2.InformebuscarplanillaCoddeterminada(comboBox1.Text, dateTimePicker3.Text, dataGridView2.CurrentRow.Cells["LugardeTratamiento"].Value.ToString());
                this.comboBox10.DataSource = lu2;
                this.comboBox10.DisplayMember = "cod";
                this.comboBox10.ValueMember = "cod";


            }


        }
        /// <summary>
        /// Evento del boton que realiza la funcion de buscar la informacion requerida y mostrar el resultado en el datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {

            CatalogoPlanilla clp = new CatalogoPlanilla();
            List<CheckList> lista = new List<CheckList>();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            lista1 = clp.Informebuscarplanilla(comboBox1.Text, dateTimePicker1.Text, dateTimePicker2.Text);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            this.dataGridView2.DataSource = lista1;




            dateTimePicker3.CustomFormat = "yyyy-MM-dd";
            CatalogoPlanilla ounits = new CatalogoPlanilla();
            List<Periodicidad> lu = ounits.obtenerCodPeriodiInforme(dateTimePicker3.Text, textBox6.Text, textBox4.Text);
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
            dataGridView2.AllowUserToOrderColumns = true;
            textBox1.Text = "";

        }
        /// <summary>
        /// Metodo que construye el informe en fomato pdf, insertando las tablas y contenido deseado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button1_Click(object sender, EventArgs e)
        {
           // if (guardar == false)
           // {

           //     MessageBox.Show("Debe guardar el checklist");
          //  }
         //   else
        //    {

            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                int indice = dataGridView2.CurrentRow == null ? 0
                    : dataGridView2.CurrentRow.Index + 1 == dataGridView2.Rows.Count ? 0 : dataGridView2.CurrentRow.Index + 1;

                dataGridView2.ClearSelection(); //Borra la selección actual
                dataGridView2.FirstDisplayedScrollingRowIndex = indice;
                dataGridView2.CurrentCell = dataGridView2.Rows[indice].Cells[0]; //Establece la celda activa
                dataGridView2.Rows[indice].Selected = true; //Selecciona la fila
                dateTimePicker3.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                dateTimePicker3.Format = DateTimePickerFormat.Custom;
                dateTimePicker3.CustomFormat = "yyyy-MM-dd";
                //MostrarDatos(dataGridView2.CurrentRow);
                CatalogoPlanilla ounits2 = new CatalogoPlanilla();
                List<Check> lu2 = ounits2.InformebuscarplanillaCoddeterminada(comboBox1.Text, dateTimePicker3.Text, dataGridView2.CurrentRow.Cells[2].Value.ToString());
                this.comboBox10.DataSource = lu2;
                this.comboBox10.DisplayMember = "cod";
                this.comboBox10.ValueMember = "cod";


                int indexaux;
                indexaux = 0;
                lint.Clear();
                int indexo = Convert.ToInt32(comboBox10.SelectedValue);
                //era comobobox 10 ahora el 7 PRUEBA

                for (int w = comboBox10.Items.Count - 1; w >= 0; w--)
                {


                    comboBox10.SelectedIndex = indexaux;
                    indexo = Convert.ToInt32(comboBox10.SelectedValue);


                    lint.Add(indexo);
                    indexaux++;
                }


                string b = "";
                int index1 = 0;
                index1 = 0;
                int index3 = 0;
                index3 = 0;
                string d = "";
                CatalogoInformes ac = new CatalogoInformes();
                //   for (int j = comboBox10.Items.Count; j > 0; j--)
                //   {
                CatalogoPlanilla catalogo = new CatalogoPlanilla();
                b = lint[index1].ToString();

                for (int x = 0; x < lint.Count; x++)
                {

                    b = lint[index1].ToString();
                    //d = listcertificado[index3].ToString();
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                    dateTimePicker1.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                    if (dataGridView2.CurrentRow.Cells[6].Value == null)
                    {
                        d = "N/A";

                        Check c = new Check(d, textBox1.Text, dateTimePicker1.Text, b, comboBox8.Text, comboBox1.Text);
                        ac.addCheck(c);
                    }
                    else
                    {
                        Check c = new Check(dataGridView2.CurrentRow.Cells[6].Value.ToString(), textBox1.Text, dateTimePicker1.Text, b, comboBox8.Text, comboBox1.Text);
                        ac.addCheck(c);

                    }

                    Periodicidad ot = new Periodicidad(Convert.ToInt32(b), dataGridView2.CurrentRow.Cells["NOTI"].Value.ToString());
                    catalogo.modOti(ot);
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                    index1++;
                }
                index1 = 0;
            }
            guardar = true;

            // }
            MessageBox.Show("Check Guardado");
            //---------------------------------------------------------------------------------------------------------------------
            lint.Clear();
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                int indice = dataGridView2.CurrentRow == null ? 0
                    : dataGridView2.CurrentRow.Index + 1 == dataGridView2.Rows.Count ? 0 : dataGridView2.CurrentRow.Index + 1;

                dataGridView2.ClearSelection(); //Borra la selección actual
                dataGridView2.FirstDisplayedScrollingRowIndex = indice;
                dataGridView2.CurrentCell = dataGridView2.Rows[indice].Cells[0]; //Establece la celda activa
                dataGridView2.Rows[indice].Selected = true; //Selecciona la fila
                dateTimePicker3.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                dateTimePicker3.Format = DateTimePickerFormat.Custom;
                dateTimePicker3.CustomFormat = "yyyy-MM-dd";
                //MostrarDatos(dataGridView2.CurrentRow);
                CatalogoPlanilla ounits2 = new CatalogoPlanilla();
                List<Check> lu2 = ounits2.InformebuscarplanillaCoddeterminada(comboBox1.Text, dateTimePicker3.Text, dataGridView2.CurrentRow.Cells[2].Value.ToString());
                this.comboBox10.DataSource = lu2;
                this.comboBox10.DisplayMember = "cod";
                this.comboBox10.ValueMember = "cod";


                int indexaux;
                indexaux = 0;
                lint.Clear();
                int indexo = Convert.ToInt32(comboBox10.SelectedValue);
                //era comobobox 10 ahora el 7 PRUEBA

                for (int w = comboBox10.Items.Count - 1; w >= 0; w--)
                {


                    comboBox10.SelectedIndex = indexaux;
                    indexo = Convert.ToInt32(comboBox10.SelectedValue);


                    lint.Add(indexo);
                    indexaux++;
                }


                string b = "";
                int index1 = 0;
                index1 = 0;
                int index3 = 0;
                index3 = 0;
                string d = "";
                CatalogoInformes ac = new CatalogoInformes();
                //   for (int j = comboBox10.Items.Count; j > 0; j--)
                //   {
                b = lint[index1].ToString();
             
                for (int x = 0; x < lint.Count; x++)
                {

                    b = lint[index1].ToString();
                    //d = listcertificado[index3].ToString();
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                    dateTimePicker1.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                    if (dataGridView2.CurrentRow.Cells[6].Value == null)
                    {
                        d = "N/A";

                        Check c = new Check(d, textBox1.Text, dateTimePicker1.Text, b, comboBox8.Text, comboBox1.Text);
                        ac.addCheck(c);
                    }
                    else
                    {
                        Check c = new Check(dataGridView2.CurrentRow.Cells[6].Value.ToString(), textBox1.Text, dateTimePicker1.Text, b, comboBox8.Text, comboBox1.Text);
                        ac.addCheck(c);

                    }
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                    index1++;
                }
                index1 = 0;
            }
            guardar = true;
           
            MessageBox.Show("Check Guardado");
                if (comboBox5.Text != "")
                {


                    PdfPTable pdfTabletitulo = new PdfPTable(1);
                    pdfTabletitulo.DefaultCell.Padding = 3;
                    pdfTabletitulo.WidthPercentage = 100;
                    pdfTabletitulo.HorizontalAlignment = Element.ALIGN_CENTER;
                    pdfTabletitulo.DefaultCell.BorderWidth = 1;

                    PdfPTable pdfTable = new PdfPTable(9);
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

                    //Creacion de celdas con PdfPCell
                    iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                    PdfPCell cltitulo = new PdfPCell(new Phrase("CHECKLIST"+"-"+comboBox8.Text, _standardFont));
                    cltitulo.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    cltitulo.HorizontalAlignment = Element.ALIGN_CENTER;
                    PdfPCell clNombre = new PdfPCell(new Phrase(comboBox1.Text,  _standardFont));
                    clNombre.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);              
                    PdfPCell clfecha = new PdfPCell(new Phrase(dateTimePicker1.Text, _standardFont));
                    clfecha.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    PdfPCell cltecve = new PdfPCell(new Phrase("Aplicador responsable y vehiculo" + ":", _standardFont));
                    cltecve.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    PdfPCell clVehiculo = new PdfPCell(new Phrase(comboBox2.Text, _standardFont));
                    clVehiculo.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    PdfPCell clfechve = new PdfPCell(new Phrase("Fecha de los servicios" + ":", _standardFont));
                    clfechve.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    PdfPCell clcolacion = new PdfPCell(new Phrase("colacion" + comboBox3.Text, _standardFont));
                    clcolacion.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    PdfPCell clacuso = new PdfPCell(new Phrase(textBox2.Text, _standardFont));
                    clacuso.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    PdfPCell clobserva = new PdfPCell(new Phrase(textBox1.Text, _standardFont));
                    clobserva.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    PdfPCell cldetalle = new PdfPCell(new Phrase(textBox3.Text, _standardFont));
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
                    if (dataGridView2.Columns.Contains("CODIGO"))
                    {
                        dataGridView2.Columns.Remove("CODIGO");

                    }
                    //Agregar Titulo de Datagradview
                    foreach (DataGridViewColumn column in dataGridView2.Columns)
                    {
                        if (column.HeaderText != "Fecha")
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, _standardFont));
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
                                string content=cell.Value.ToString();
                                PdfPCell clcontent = new PdfPCell(new Phrase(content, _standardFont));
                                pdfTable.AddCell(clcontent);
                              
                            }

                        }
                    }
                    //AKIIII correlativo    
                    /*
                    for (int i = 0; i < dataGridView2.RowCount; i++)
                    {
                        listcertificado.Add(dataGridView2.Rows[i].Cells["Certificado"].Value.ToString());
                    }
                     */
                    CatalogoInformes ac = new CatalogoInformes();
                    string a = "";

                    if (dataGridView2.CurrentRow.Cells["Certificado"].Value == null)
                    {
                        a = "N/A";
                    }

                    //Exportar a PDF
                    string archivo = "C:\\check\\";
                    //   string archivo = "Z:\\STORAGE\\Public\\Esam compartido\\check\\";
                    if (!Directory.Exists(archivo))
                    {

                        Directory.CreateDirectory(archivo);
                    }

                    using (FileStream stream = new FileStream(archivo + "Checklist" + "-" +comboBox8.Text +"-"+  comboBox1.Text + dateTimePicker1.Text + ".pdf", FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                        PdfWriter.GetInstance(pdfDoc, stream);

                        pdfDoc.Open();

                        iTextSharp.text.Image imagen1 = iTextSharp.text.Image.GetInstance(@"\\STORAGE\\Public\\Esam compartido\\Informática\\esam.jpg");
                       //  iTextSharp.text.Image imagen1 = iTextSharp.text.Image.GetInstance("C:\\Users\\Urukazo\\Desktop\\respaldo bueno\\esam.jpg");
                       // iTextSharp.text.Image imagen1 = iTextSharp.text.Image.GetInstance("C:\\Users\\natal\\Desktop\\Ejecutableroot\\esam.jpg");
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
                            Paragraph saltoDeLinea1 = new Paragraph("  ");
                        pdfDoc.Add(saltoDeLinea1);
                        pdfDoc.Add(saltoDeLinea1);
                        pdfDoc.Add(pdfobserva);
                    
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
                        dataGridView2.Columns.Add(var2);
                        dataGridView2.Columns["CODIGO"].DisplayIndex = 10;


                        if (comboBox5.Text == "Explorer")
                        {
                            System.Diagnostics.Process.Start("IExplore.exe", archivo + "Checklist" + "-" + comboBox8.Text + "-" + comboBox1.Text + dateTimePicker1.Text + ".pdf");
                        }

                        if (comboBox5.Text == "Nitro")
                        {

                            System.Diagnostics.Process.Start("NitroPDF.exe", archivo + "Checklist" + "-" + comboBox8.Text + "-" + comboBox1.Text + dateTimePicker1.Text + ".pdf");
                        }

                        if (comboBox5.Text == "Acrobat")
                        {
                            if (archivo.Contains(comboBox1.Text))
                            {
                                System.Diagnostics.Process.Start("AcroRD32.exe", archivo + "Checklist" + "-" + comboBox8.Text + "-" +  comboBox1.Text + dateTimePicker1.Text + ".pdf");
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
                guardar = false;

                CatalogoInformes units4 = new CatalogoInformes();
                List<Check> vei4 = units4.getmaxidenticheck();
                this.comboBox8.DataSource = vei4;
                this.comboBox8.DisplayMember = "cod";
                this.comboBox8.ValueMember = "cod";
            //}
        }

        private void dataGridView2_KeyPress(object sender, KeyPressEventArgs e)
        {
           
         

        }
        /// <summary>
        /// Evento boton realiza la funcion de ingresar el dato "OTI" en la base de datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
           int temp=0;
            if (textBox4.Text == "")
            {
                MessageBox.Show("Debe seleccionar una visita");

            }
            else
            {
                dateTimePicker3.Format = DateTimePickerFormat.Custom;

                dateTimePicker3.CustomFormat = "yyyy-MM-dd";
                CatalogoPlanilla ounits = new CatalogoPlanilla();
                List<Periodicidad> lu = ounits.obtenerCodPeriodiInformeCheck(dateTimePicker3.Text, textBox6.Text, textBox4.Text,textBox5.Text);
                this.comboBox4.DataSource = lu;
                this.comboBox4.DisplayMember = "cod";
                this.comboBox4.ValueMember = "cod";

                comboBox4.Text = Convert.ToString(comboBox4.SelectedValue);
                comboBox4.SelectedIndex = comboBox4.FindString(comboBox4.Text);
                int aux = comboBox4.SelectedIndex;
                int indexo = Convert.ToInt32(comboBox4.SelectedValue);
                for (int i = comboBox4.Items.Count - 1; i >= 0; i--)
                {

                    comboBox4.SelectedIndex = temp;
                    indexo = Convert.ToInt32(comboBox4.SelectedValue);

                    list.Add(indexo);
                    temp++;
                  //  comboBox4.SelectedValue = indexo;

                   // list.Add(indexo);
                    //indexo++;
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
              
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
         
                CatalogoPlanilla clp = new CatalogoPlanilla();
                List<CheckList> lista = new List<CheckList>();
                lista = clp.Informebuscarplanilla(comboBox1.Text, dateTimePicker1.Text, dateTimePicker2.Text);
                this.dataGridView2.DataSource = lista;

                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "dd-MM-yyyy";
          
                MessageBox.Show("Operacion Realizada");
            }

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            CatalogoPlanilla catalogo = new CatalogoPlanilla();
            List<Check> lu2 = catalogo.Informebuscarcheckcod(comboBox9.Text, comboBox6.Text);
            this.comboBox7.DataSource = lu2;
            this.comboBox7.DisplayMember = "cod";
            this.comboBox7.ValueMember = "cod";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            dataGridView2.AllowUserToOrderColumns = true;

            comboBox1.Text = comboBox9.Text;
            guardar = true;
            CatalogoInformes clp = new CatalogoInformes();
            List<VisualizadorCheckcs> lista = new List<VisualizadorCheckcs>();

            dateTimePicker4.Format = DateTimePickerFormat.Custom;
            dateTimePicker4.CustomFormat = "yyyy-MM-dd";

            lista = clp.InformeCheck(comboBox6.Text, comboBox9.Text);
            dateTimePicker4.Format = DateTimePickerFormat.Custom;
            dateTimePicker4.CustomFormat = "dd-MM-yyyy";
            this.dataGridView2.DataSource = lista;

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void graData()
        {



            this.dataGridView2.DataSource = lista1;

        }
        private void button5_Click(object sender, EventArgs e)
        {

            lista1.Sort(ordenarPornumero);
            this.dataGridView2.DataSource = "";
            graData();




        }

        private int ordenarPornumero(CheckList P1, CheckList P2)
        {
            return P1.Numero.CompareTo(P2.Numero);
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
            comboBox9.Text = ""; 



            dateTimePicker1.Text = dateTimePicker4.Text;
            dateTimePicker4.Format = DateTimePickerFormat.Custom;
            dateTimePicker4.CustomFormat = "yyyy-MM-dd";
            CatalogoInformes tunits = new CatalogoInformes();
            List<Project.BussinessRules.Check> tec = tunits.InformeCheckTec(dateTimePicker4.Text);
            this.comboBox9.DataSource = tec;
            this.comboBox9.DisplayMember = "tecnico";
            this.comboBox9.ValueMember = "tecnico";
          
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            int comparar = 0;
            if (comboBox6.Text == comboBox8.Text)
            {
                comparar = Convert.ToInt32(comboBox8.Text) + 1;
                comboBox8.Text = Convert.ToString(comparar);
            }
            // comboBox6.Text = comboBox8.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewExcel(dataGridView2);



            MessageBox.Show("Exportación Finalizada");
        }
        private void ExportarDataGridViewExcel(DataGridView grd)
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
                for (int i = 1; i < dataGridView2.Columns.Count + 1; i++)
                {
                    hoja_trabajo.Cells[1, i] = dataGridView2.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < grd.Rows.Count; i++)
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

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                int indice = dataGridView2.CurrentRow == null ? 0
                    : dataGridView2.CurrentRow.Index + 1 == dataGridView2.Rows.Count ? 0 : dataGridView2.CurrentRow.Index + 1;

                dataGridView2.ClearSelection(); //Borra la selección actual
                dataGridView2.FirstDisplayedScrollingRowIndex = indice;
                dataGridView2.CurrentCell = dataGridView2.Rows[indice].Cells[0]; //Establece la celda activa
                dataGridView2.Rows[indice].Selected = true; //Selecciona la fila
                dateTimePicker3.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                dateTimePicker3.Format = DateTimePickerFormat.Custom;
                dateTimePicker3.CustomFormat = "yyyy-MM-dd";
                //MostrarDatos(dataGridView2.CurrentRow);
                CatalogoPlanilla ounits2 = new CatalogoPlanilla();
                List<Check> lu2 = ounits2.InformebuscarplanillaCoddeterminada(comboBox1.Text, dateTimePicker3.Text, dataGridView2.CurrentRow.Cells[2].Value.ToString());
                this.comboBox10.DataSource = lu2;
                this.comboBox10.DisplayMember = "cod";
                this.comboBox10.ValueMember = "cod";


                int indexaux;
                indexaux = 0;
                lint.Clear();
                int indexo = Convert.ToInt32(comboBox10.SelectedValue);
                //era comobobox 10 ahora el 7 PRUEBA

                for (int w = comboBox10.Items.Count - 1; w >= 0; w--)
                {


                    comboBox10.SelectedIndex = indexaux;
                    indexo = Convert.ToInt32(comboBox10.SelectedValue);


                    lint.Add(indexo);
                    indexaux++;
                }


                string b = "";
                int index1 = 0;
                index1 = 0;
                int index3 = 0;
                index3 = 0;
                string d = "";
                CatalogoInformes ac = new CatalogoInformes();
                //   for (int j = comboBox10.Items.Count; j > 0; j--)
                //   {
                CatalogoPlanilla catalogo = new CatalogoPlanilla();
                b = lint[index1].ToString();

                for (int x = 0; x < lint.Count; x++)
                {

                    b = lint[index1].ToString();
                    //d = listcertificado[index3].ToString();
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                    dateTimePicker1.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                    if (dataGridView2.CurrentRow.Cells[6].Value == null)
                    {
                        d = "N/A";

                        Check c = new Check(d, textBox1.Text, dateTimePicker1.Text, b, comboBox8.Text, comboBox1.Text);
                        ac.addCheck(c);
                    }
                    else
                    {
                        Check c = new Check(dataGridView2.CurrentRow.Cells[6].Value.ToString(), textBox1.Text, dateTimePicker1.Text, b, comboBox8.Text, comboBox1.Text);
                        ac.addCheck(c);

                    }

                    Periodicidad ot = new Periodicidad(Convert.ToInt32(b), dataGridView2.CurrentRow.Cells["NOTI"].Value.ToString());
                    catalogo.modOti(ot);
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                    index1++;
                }
                index1 = 0;
            }
            guardar = true;

            // }
            MessageBox.Show("Check Guardado");
        }
        public void MostrarDatos(DataGridViewRow fila)
        {
            if (fila != null)
            {
                //Cargar valores
                MessageBox.Show(fila.Cells[2].Value.ToString());
            }
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Text = dateTimePicker4.Text;
            dateTimePicker4.Format = DateTimePickerFormat.Custom;
            dateTimePicker4.CustomFormat = "yyyy-MM-dd";
            CatalogoInformes tunits = new CatalogoInformes();
            List<Project.BussinessRules.Check> tec = tunits.InformeCheckCod(comboBox9.Text);
            this.comboBox6.DataSource = tec;
            this.comboBox6.DisplayMember = "nombre";
            this.comboBox6.ValueMember = "cod";
            dateTimePicker4.Format = DateTimePickerFormat.Custom;
            dateTimePicker4.CustomFormat = "dd-MM-yyyy";
            int comparar = 0;
            if (comboBox6.Text == comboBox8.Text)
            {
                comparar = Convert.ToInt32(comboBox8.Text) + 1;
                comboBox8.Text = Convert.ToString(comparar);
            }
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_KeyDown(object sender, KeyEventArgs e)
        {
           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      
       

    }
}