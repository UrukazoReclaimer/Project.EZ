using Project.BussinessRules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project.Esampm
{
    public partial class Calendario : Form
    {
        List<string> fecha = new List<string>();
        private DataGridView songsDataGridView = new DataGridView();
        public Calendario()
        {
            InitializeComponent();
            catalogoTecnico tunits = new catalogoTecnico();
            List<Project.BussinessRules.Tecnico> tec = tunits.obtenertec();

            this.comboBox5.DataSource = tec;
            this.comboBox5.DisplayMember = "nombre";
            this.comboBox5.ValueMember = "cod";
            /*
                        catalogoTecnico clp = new catalogoTecnico();
                        List<Tecnico> lista = new List<Tecnico>();

                        lista = clp.mostrarTec("");
                        this.songsDataGridView.DataSource = lista;
                        this.songsDataGridView.DataSource = lista;
              */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            DateTime fecha1 = dateTimePicker1.Value.Date;
            DateTime fecha2 = dateTimePicker2.Value.Date;

            fecha.Clear();

            long ticksDiarios = 86400L * 1000L * 10000L;


            for (long ticks = fecha1.Ticks; ticks <= fecha2.Ticks; ticks += ticksDiarios)
            {
                // Creamos una nueva estructura DateTime.
                //      
                DateTime fechas = new DateTime(ticks);

                fecha.Add(fechas.ToShortDateString());
            }

            int index = 0;
            int contador=0;
            for (int j = fecha.Count - 1; j >= 0; j--)
            {
                string a = "";
                a = fecha[index].ToString();
                //dataGridView1.Rows[contador].Cells[0].Value = a;
                dataGridView1.Rows.Insert(contador, a);
                index++;
                contador ++;
            }
            index = 0;
             * */
       
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            CatalogoCalendario clp = new CatalogoCalendario();
            List<CalendarioFechas> lista = new List<CalendarioFechas>();
            List<CalendarioFechas> lista2 = new List<CalendarioFechas>();
            List<CalendarioFechas> lista3 = new List<CalendarioFechas>();
            List<CalendarioFechas> lista4 = new List<CalendarioFechas>();
            List<CalendarioFechas> lista5 = new List<CalendarioFechas>();
            List<CalendarioFechas> lista6 = new List<CalendarioFechas>();
            List<CalendarioFechas> lista7 = new List<CalendarioFechas>();

            lista = clp.mostrarCalendario(8, dateTimePicker1.Text, dateTimePicker2.Text,Convert.ToInt32(comboBox1.Text));
            lista2 = clp.mostrarCalendario(5, dateTimePicker1.Text, dateTimePicker2.Text, Convert.ToInt32(comboBox1.Text));
            lista3 = clp.mostrarCalendario(4, dateTimePicker1.Text, dateTimePicker2.Text, Convert.ToInt32(comboBox1.Text));
            lista4 = clp.mostrarCalendario(6, dateTimePicker1.Text, dateTimePicker2.Text, Convert.ToInt32(comboBox1.Text));
            lista5 = clp.mostrarCalendario(10, dateTimePicker1.Text, dateTimePicker2.Text, Convert.ToInt32(comboBox1.Text));
            lista6 = clp.mostrarCalendario(11, dateTimePicker1.Text, dateTimePicker2.Text, Convert.ToInt32(comboBox1.Text));
            lista7 = clp.mostrarCalendario(9, dateTimePicker1.Text, dateTimePicker2.Text, Convert.ToInt32(comboBox1.Text));
            this.dataGridView1.DataSource = lista;
            this.dataGridView2.DataSource = lista2;
            this.dataGridView3.DataSource = lista3;
            this.dataGridView4.DataSource = lista4;
            this.dataGridView5.DataSource = lista5;
            this.dataGridView6.DataSource = lista6;
            this.dataGridView7.DataSource = lista7;
            
            dataGridView2.Columns.RemoveAt(0);
            dataGridView3.Columns.RemoveAt(0);
            dataGridView4.Columns.RemoveAt(0);
            dataGridView5.Columns.RemoveAt(0);
            dataGridView6.Columns.RemoveAt(0);
            dataGridView7.Columns.RemoveAt(0);
            

        }
        private void PopulateDataGridView()
        {
            /*
                        string[] row0 = { "11/22/1968", "29", "Revolution 9", 
                    "Beatles", "The Beatles [White Album]" };
                        string[] row1 = { "1960", "6", "Fools Rush In", 
                    "Frank Sinatra", "Nice 'N' Easy" };
                        string[] row2 = { "11/11/1971", "1", "One of These Days", 
                    "Pink Floyd", "Meddle" };
                        string[] row3 = { "1988", "7", "Where Is My Mind?", 
                    "Pixies", "Surfer Rosa" };
                        string[] row4 = { "5/1981", "9", "Can't Find My Mind", 
                    "Cramps", "Psychedelic Jungle" };
                        string[] row5 = { "6/10/2003", "13", 
                    "Scatterbrain. (As Dead As Leaves.)", 
                    "Radiohead", "Hail to the Thief" };
                        string[] row6 = { "6/30/1992", "3", "Dress", "P J Harvey", "Dry" };
            */

            string[] row = { };
            string[] row1 = { };
            string[] row2 = { };
            string[] row3 = { };
            string[] row4 = { };
            string[] row5 = { };
            string[] row6 = { };
            /*       
                  songsDataGridView.Rows.Add(row0);
                  songsDataGridView.Rows.Add(row1);
                  songsDataGridView.Rows.Add(row2);
                  songsDataGridView.Rows.Add(row3);
                  songsDataGridView.Rows.Add(row4);
                  songsDataGridView.Rows.Add(row5);
                  songsDataGridView.Rows.Add(row6);

                  songsDataGridView.Columns[0].DisplayIndex = 3;
                  songsDataGridView.Columns[1].DisplayIndex = 4;
                  songsDataGridView.Columns[2].DisplayIndex = 0;
                  songsDataGridView.Columns[3].DisplayIndex = 1;
                  songsDataGridView.Columns[4].DisplayIndex = 2;
             */
            int contador = 0;
            for (int j = fecha.Count - 1; j >= 0; j--)
            {



            }
        }

        private void SetupDataGridView()
        {
            this.Controls.Add(songsDataGridView);

            songsDataGridView.ColumnCount = 20;

            //      songsDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            //      songsDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //      songsDataGridView.ColumnHeadersDefaultCellStyle.Font =
            new Font(songsDataGridView.Font, FontStyle.Bold);

            songsDataGridView.Name = "songsDataGridView";
            songsDataGridView.Location = new Point(38, 180);
            songsDataGridView.Size = new Size(500, 250);
            songsDataGridView.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            songsDataGridView.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            songsDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            songsDataGridView.GridColor = Color.Black;
            songsDataGridView.RowHeadersVisible = false;
            songsDataGridView.Columns[0].Name = "Fecha";
            /*
            songsDataGridView.Columns[0].Name = "Release Date";
            songsDataGridView.Columns[1].Name = "Track";
            songsDataGridView.Columns[2].Name = "Title";
            songsDataGridView.Columns[3].Name = "Artist";
            songsDataGridView.Columns[4].Name = "Album";
            songsDataGridView.Columns[4].DefaultCellStyle.Font =
                new Font(songsDataGridView.DefaultCellStyle.Font, FontStyle.Italic);
            */
            /*
            songsDataGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            songsDataGridView.MultiSelect = false;
            songsDataGridView.Dock = DockStyle.None;

            songsDataGridView.CellFormatting += new
                DataGridViewCellFormattingEventHandler(
                songsDataGridView_CellFormatting);
              */
        }


        private void songsDataGridView_CellFormatting(object sender,
    System.Windows.Forms.DataGridViewCellFormattingEventArgs e)
        {
            if (e != null)
            {
                if (this.songsDataGridView.Columns[e.ColumnIndex].Name == "Release Date")
                {
                    if (e.Value != null)
                    {
                        try
                        {
                            e.Value = DateTime.Parse(e.Value.ToString())
                                .ToLongDateString();
                            e.FormattingApplied = true;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("{0} is not a valid date.", e.Value.ToString());
                        }
                    }
                }
            }
        }

        private void Calendario_Load(object sender, EventArgs e)
        {

            //  SetupDataGridView();
            //PopulateDataGridView();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            ExportarDataGridViewExcelClientesLugar(dataGridView1, dataGridView2, dataGridView3, dataGridView4, dataGridView5, dataGridView6, dataGridView7);
            label2.Visible = false;
        }
        //NOTAAA ELIMINAR COLUMNAS FECHAAAAS
        private void ExportarDataGridViewExcelClientesLugar(DataGridView grd, DataGridView grd2, DataGridView grd3, DataGridView grd4, DataGridView grd5, DataGridView grd6, DataGridView grd7)
        {
         
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                aplicacion.DisplayAlerts = false;
                libros_trabajo = aplicacion.Workbooks.Add();
              
                hoja_trabajo =
                    (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                //Recorremos el DataGridView rellenando la hoja de trabajo
               // MessageBox.Show("Procesando Calendario, por favor espere");
                //tecnico1
                for (int i = 1; i < grd.Columns.Count + 1; i++)
                {
                    hoja_trabajo.Cells[1, i] = grd.Columns[i - 1].HeaderText;
                    //   hoja_trabajo.Cells.Font.Color = Color.Blue;
                    hoja_trabajo.Cells[1, i].Interior.Color = Color.LightBlue;
                    hoja_trabajo.Cells.ColumnWidth = 30;
                    //   hoja_trabajo.Cells.BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic); 
                    hoja_trabajo.Cells[1, i].BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlDouble,
                     Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexNone,
                         Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexNone);
                }
                //tecnico2
                for (int i = 1; i < grd2.Columns.Count + 1; i++)
                {
                    hoja_trabajo.Cells[1, i + 4] = grd2.Columns[i - 1].HeaderText;
                    hoja_trabajo.Cells[1, i + 4].Interior.Color = Color.LightBlue;
                    hoja_trabajo.Cells[1, i + 4].BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlDouble,
             Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexNone,
                 Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexNone);
                }
                //tecnico3
                for (int i = 1; i < grd3.Columns.Count + 1; i++)
                {
                    hoja_trabajo.Cells[1, i + 7] = grd3.Columns[i - 1].HeaderText;
                    hoja_trabajo.Cells[1, i + 7].Interior.Color = Color.LightBlue;
                    hoja_trabajo.Cells[1, i + 7].BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlDouble,
             Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexNone,
                 Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexNone);
                }
                //tecnico4
                for (int i = 1; i < grd4.Columns.Count + 1; i++)
                {
                    hoja_trabajo.Cells[1, i + 10] = grd4.Columns[i - 1].HeaderText;
                    hoja_trabajo.Cells[1, i + 10].Interior.Color = Color.LightBlue;
                    hoja_trabajo.Cells[1, i + 10].BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlDouble,
             Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexNone,
                 Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexNone);
                }
                //tecnico5
                for (int i = 1; i < grd5.Columns.Count + 1; i++)
                {
                    hoja_trabajo.Cells[1, i + 13] = grd5.Columns[i - 1].HeaderText;
                    hoja_trabajo.Cells[1, i + 13].Interior.Color = Color.LightBlue;
                    hoja_trabajo.Cells[1, i + 13].BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlDouble,
             Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexNone,
                 Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexNone);
                }
                //tecnico6
                for (int i = 1; i < grd6.Columns.Count + 1; i++)
                {
                    hoja_trabajo.Cells[1, i + 16] = grd6.Columns[i - 1].HeaderText;
                    hoja_trabajo.Cells[1, i + 16].Interior.Color = Color.LightBlue;
                    hoja_trabajo.Cells[1, i + 16].BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlDouble,
             Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexNone,
                 Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexNone);
                }
                //tecnico7
                for (int i = 1; i < grd7.Columns.Count + 1; i++)
                {
                    hoja_trabajo.Cells[1, i + 19] = grd7.Columns[i - 1].HeaderText;
                    hoja_trabajo.Cells[1, i + 19].Interior.Color = Color.LightBlue;
                    hoja_trabajo.Cells[1, i + 19].BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlDouble,
             Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexNone,
                 Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexNone);
                }
                //tecnico1
                for (int i = 0; i < grd.Rows.Count ; i++)
                {
                    for (int j = 0; j < grd.Columns.Count; j++)
                    {
                        
                        hoja_trabajo.Cells[i + 2, j + 1] = grd.Rows[i].Cells[j].Value;
                        hoja_trabajo.Cells[i + 2, j + 1].BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlDouble,
          Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexNone,
              Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexNone);
                       
                    }
                }
                //tecnico2
                for (int i = 0; i < grd2.Rows.Count; i++)
                {
                    for (int j = 0; j < grd2.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[i + 2, j + 5] = grd2.Rows[i].Cells[j].Value;
                        hoja_trabajo.Cells[i + 2, j + 5].BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlDouble,
        Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexNone,
            Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexNone);
                      
                    }
                }
                //tecnico3
                for (int i = 0; i < grd3.Rows.Count ; i++)
                {
                    for (int j = 0; j < grd3.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[i + 2, j + 8] = grd3.Rows[i].Cells[j].Value;
                        hoja_trabajo.Cells[i + 2, j + 8].BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlDouble,
        Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexNone,
            Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexNone);
                       
                    }
                }
                //tecnico4
                for (int i = 0; i < grd4.Rows.Count ; i++)
                {
                    for (int j = 0; j < grd4.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[i + 2, j + 11] = grd4.Rows[i].Cells[j].Value;
                        hoja_trabajo.Cells[i + 2, j + 11].BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlDouble,
          Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexNone,
              Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexNone);
                      
                    }
                }
                //tecnico5
                for (int i = 0; i < grd5.Rows.Count ; i++)
                {
                    for (int j = 0; j < grd5.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[i + 2, j + 14] = grd5.Rows[i].Cells[j].Value;
                        hoja_trabajo.Cells[i + 2, j + 14].BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlDouble,
        Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexNone,
            Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexNone);
                       
                    }
                }
                //tecnico6
                for (int i = 0; i < grd6.Rows.Count ; i++)
                {
                    for (int j = 0; j < grd6.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[i + 2, j + 17] = grd6.Rows[i].Cells[j].Value;
                        hoja_trabajo.Cells[i + 2, j + 17].BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlDouble,
        Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexNone,
            Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexNone);
                      
                    }
                }
                //tecnico7
                for (int i = 0; i < grd7.Rows.Count ; i++)
                {
                    for (int j = 0; j < grd7.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[i + 2, j + 20] = grd7.Rows[i].Cells[j].Value;
                        hoja_trabajo.Cells[i + 2, j + 20].BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlDouble,
        Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexNone,
            Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexNone);
                      
                    }
                }
                libros_trabajo.SaveAs(fichero.FileName,
                    Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
            MessageBox.Show("Exportación Finalizada");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
