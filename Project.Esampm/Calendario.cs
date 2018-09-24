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
        int uno, dos, tres, cuatro, cinco, seis, siete, ocho;
        Boolean registro = false;
        public Calendario()
        {
            InitializeComponent();
            catalogoTecnico tunits = new catalogoTecnico();
            List<Project.BussinessRules.Tecnico> tec = tunits.obtenertec();
            this.comboBox5.DataSource = tec;
            this.comboBox5.DisplayMember = "nombre";
            this.comboBox5.ValueMember = "cod";
            catalogoTecnico tunits2 = new catalogoTecnico();
            List<Project.BussinessRules.Tecnico> tec2 = tunits2.obtenertec();
            this.comboBox3.DataSource = tec2;
            this.comboBox3.DisplayMember = "nombre";
            this.comboBox3.ValueMember = "cod";
            catalogoTecnico tunits3 = new catalogoTecnico();
            List<Project.BussinessRules.Tecnico> tec3 = tunits3.obtenertec();
            this.comboBox4.DataSource = tec3;
            this.comboBox4.DisplayMember = "nombre";
            this.comboBox4.ValueMember = "cod";
            catalogoTecnico tunits4 = new catalogoTecnico();
            List<Project.BussinessRules.Tecnico> tec4 = tunits4.obtenertec();
            this.comboBox6.DataSource = tec4;
            this.comboBox6.DisplayMember = "nombre";
            this.comboBox6.ValueMember = "cod";
            catalogoTecnico tunits5 = new catalogoTecnico();
            List<Project.BussinessRules.Tecnico> tec5 = tunits5.obtenertec();
            this.comboBox7.DataSource = tec5;
            this.comboBox7.DisplayMember = "nombre";
            this.comboBox7.ValueMember = "cod";
            catalogoTecnico tunits6 = new catalogoTecnico();
            List<Project.BussinessRules.Tecnico> tec6 = tunits6.obtenertec();
            this.comboBox8.DataSource = tec6;
            this.comboBox8.DisplayMember = "nombre";
            this.comboBox8.ValueMember = "cod";
            catalogoTecnico tunits7 = new catalogoTecnico();
            List<Project.BussinessRules.Tecnico> tec7 = tunits7.obtenertec();
            this.comboBox9.DataSource = tec7;
            this.comboBox9.DisplayMember = "nombre";
            this.comboBox9.ValueMember = "cod";
            catalogoTecnico tunits8 = new catalogoTecnico();
            List<Project.BussinessRules.Tecnico> tec8 = tunits8.obtenertec();
            this.comboBox10.DataSource = tec8;
            this.comboBox10.DisplayMember = "nombre";
            this.comboBox10.ValueMember = "cod";

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
       
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
            List<CalendarioFechas> lista8 = new List<CalendarioFechas>();
            if (uno != 0)
            lista =  clp.mostrarCalendario(uno, dateTimePicker1.Text, dateTimePicker2.Text,Convert.ToInt32(comboBox1.Text));
            if (dos != 0)
            lista2 = clp.mostrarCalendario(dos, dateTimePicker1.Text, dateTimePicker2.Text, Convert.ToInt32(comboBox1.Text));
            if (tres != 0)
            lista3 = clp.mostrarCalendario(tres, dateTimePicker1.Text, dateTimePicker2.Text, Convert.ToInt32(comboBox1.Text));
            if (cuatro != 0)
            lista4 = clp.mostrarCalendario(cuatro, dateTimePicker1.Text, dateTimePicker2.Text, Convert.ToInt32(comboBox1.Text));
            if (cinco != 0)
            lista5 = clp.mostrarCalendario(cinco, dateTimePicker1.Text, dateTimePicker2.Text, Convert.ToInt32(comboBox1.Text));
            if (seis != 0)
            lista6 = clp.mostrarCalendario(seis, dateTimePicker1.Text, dateTimePicker2.Text, Convert.ToInt32(comboBox1.Text));
            if (siete != 0)
            lista7 = clp.mostrarCalendario(siete, dateTimePicker1.Text, dateTimePicker2.Text, Convert.ToInt32(comboBox1.Text));
            if (ocho != 0)
            lista8 = clp.mostrarCalendario(ocho, dateTimePicker1.Text, dateTimePicker2.Text, Convert.ToInt32(comboBox1.Text));
            if (uno != 0)
            {
                this.dataGridView1.DataSource = lista;
                dataGridView1.Columns[2].HeaderText = comboBox5.Text;
            }
            if (dos != 0)
            {
                this.dataGridView2.DataSource = lista2;
                dataGridView2.Columns[2].HeaderText = comboBox3.Text;
            }
            if (tres != 0)
            {
                this.dataGridView3.DataSource = lista3;
                dataGridView3.Columns[2].HeaderText = comboBox4.Text;
            }
            if (cuatro != 0)
            {
                this.dataGridView4.DataSource = lista4;
                dataGridView4.Columns[2].HeaderText = comboBox6.Text;
            }
            if (cinco != 0)
            {
                this.dataGridView5.DataSource = lista5;
                dataGridView5.Columns[2].HeaderText = comboBox7.Text;
            }
            if (seis != 0)
            {
                this.dataGridView6.DataSource = lista6;
                dataGridView6.Columns[2].HeaderText = comboBox8.Text;
            }
            if (siete != 0)
            {
                this.dataGridView7.DataSource = lista7;
                dataGridView7.Columns[2].HeaderText = comboBox9.Text;
            }
            if (ocho != 0)
            {
                this.dataGridView8.DataSource = lista8;
                dataGridView8.Columns[2].HeaderText = comboBox10.Text;
            }
            if (dos != 0)
            dataGridView2.Columns.RemoveAt(0);
            if (tres != 0)
            dataGridView3.Columns.RemoveAt(0);
            if (cuatro != 0)
            dataGridView4.Columns.RemoveAt(0);
            if (cinco != 0)
            dataGridView5.Columns.RemoveAt(0);
            if (seis != 0)
            dataGridView6.Columns.RemoveAt(0);
            if (siete != 0)
            dataGridView7.Columns.RemoveAt(0);
             if (ocho != 0)
            dataGridView8.Columns.RemoveAt(0);
          
            

        }
    

      


       

        private void Calendario_Load(object sender, EventArgs e)
        {
            registro = true;
            //  SetupDataGridView();
            //PopulateDataGridView();
            uno = 0;
            dos = 0;
            tres = 0;
            cuatro = 0;
            cinco = 0;
            seis = 0;
            siete = 0;
            ocho = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            ExportarDataGridViewExcelClientesLugar(dataGridView1, dataGridView2, dataGridView3, dataGridView4, dataGridView5, dataGridView6, dataGridView7,dataGridView8);
            label2.Visible = false;
        }
        //NOTAAA ELIMINAR COLUMNAS FECHAAAAS
        private void ExportarDataGridViewExcelClientesLugar(DataGridView grd, DataGridView grd2, DataGridView grd3, DataGridView grd4, DataGridView grd5, DataGridView grd6, DataGridView grd7, DataGridView grd8)
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
                //tecnico8
                for (int i = 1; i < grd8.Columns.Count + 1; i++)
                {
                    hoja_trabajo.Cells[1, i + 22] = grd8.Columns[i - 1].HeaderText;
                    hoja_trabajo.Cells[1, i + 22].Interior.Color = Color.LightBlue;
                    hoja_trabajo.Cells[1, i + 22].BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlDouble,
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
                //tecnico8
                for (int i = 0; i < grd8.Rows.Count; i++)
                {
                    for (int j = 0; j < grd8.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[i + 2, j + 23] = grd8.Rows[i].Cells[j].Value;
                        hoja_trabajo.Cells[i + 2, j + 23].BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlDouble,
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

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                uno = Convert.ToInt32(comboBox5.SelectedValue);
                comboBox5.SelectedValue = uno;
                          
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                dos = Convert.ToInt32(comboBox3.SelectedValue);
                comboBox3.SelectedValue = dos;

            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                tres = Convert.ToInt32(comboBox4.SelectedValue);
                comboBox4.SelectedValue = tres;

            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                cuatro = Convert.ToInt32(comboBox6.SelectedValue);
                comboBox6.SelectedValue = cuatro;

            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                cinco = Convert.ToInt32(comboBox7.SelectedValue);
                comboBox7.SelectedValue = cinco;

            }
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                seis = Convert.ToInt32(comboBox8.SelectedValue);
                comboBox8.SelectedValue = seis;

            }
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                siete = Convert.ToInt32(comboBox9.SelectedValue);
                comboBox9.SelectedValue = siete;

            }
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                ocho = Convert.ToInt32(comboBox10.SelectedValue);
                comboBox10.SelectedValue = ocho;

            }
        }

    }
}
