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

    public partial class PlanillaR : Form
    {
        List<int> list = new List<int>();
        List<int> listtec = new List<int>();
        List<int> list2 = new List<int>();
        List<int> list3 = new List<int>();
        int servicio=0;
        Boolean press = false;
        public PlanillaR(string s)
        {
            InitializeComponent();
            CatalogoCliente cunits = new CatalogoCliente();
            List<cliente> uni = cunits.getclierut();
            this.comboBox3.DataSource = uni;
            this.comboBox3.DisplayMember = "nombre";
            this.comboBox3.ValueMember = "rut";


            CatalogoPlanilla ounits = new CatalogoPlanilla();
            List<LugarTratamiento> lu = ounits.allgetlugar();
            this.comboBox4.DataSource = lu;
            this.comboBox4.DisplayMember = "nombre";
            this.comboBox4.ValueMember = "rut";

            catalogoTecnico tunits = new catalogoTecnico();
            List<Project.BussinessRules.Tecnico> tec = tunits.obtenertec();
            this.comboBox8.DataSource = tec;
            this.comboBox8.DisplayMember = "nombre";
            this.comboBox8.ValueMember = "cod";

            CatalogoPlanilla clp = new CatalogoPlanilla();
            List<InventariadoR> lista = new List<InventariadoR>();

            lista = clp.mostrarplanillaR(s);

            this.dataGridView1.DataSource = lista;


            button1.Enabled = false;
        }

        private void PlanillaR_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }



        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            List<Inventariado> lista = new List<Inventariado>();
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["FECHAR"].Value.ToString();
                comboBox8.Text = dataGridView1.CurrentRow.Cells["TECNICOR"].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells["SERVICIOR"].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells["LUGARTRATAMIENTOR"].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells["CONSUMOR"].Value.ToString();


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CatalogoPlanilla catalogo = new CatalogoPlanilla();
            CatalogoPlanilla ca = new CatalogoPlanilla();

            Periodicidad pe = new Periodicidad(dateTimePicker3.Text, Convert.ToInt32(comboBox7.Text), comboBox1.Text);


            CatalogoPlanilla ounitsx = new CatalogoPlanilla();
            List<Periodicidad> lu = ounitsx.obtenerCodPeriodiInforme(dateTimePicker4.Text, textBox4.Text, comboBox10.Text);
            this.comboBox5.DataSource = lu;
            this.comboBox5.DisplayMember = "cod";
            this.comboBox5.ValueMember = "cod";
            int aux = comboBox5.SelectedIndex;
            int indeaux = 0;
            indeaux = 0;
            int indexo = Convert.ToInt32(comboBox9.SelectedValue);
            for (int i = comboBox9.Items.Count - 1; i >= 0; i--)
            {

                /*
                                comboBox9.SelectedValue = indexo;

                                list.Add(indexo);
                                indexo++;
                 */

                comboBox9.SelectedIndex = indeaux;
                indexo = Convert.ToInt32(comboBox9.SelectedValue);
                list.Add(indexo);
                indeaux++;
            }


            int indeauxtec = 0;
            indeauxtec = 0;
            int indexotec = Convert.ToInt32(comboBox14.SelectedValue);
            for (int i = comboBox14.Items.Count - 1; i >= 0; i--)
            {          
                comboBox14.SelectedIndex = indeauxtec;
                indexotec = Convert.ToInt32(comboBox14.SelectedValue);
                listtec.Add(indexotec);
                indeauxtec++;
            }





            int index1 = 0;
            int index = 0;
            string a = "";
            index1 = 0;
            index = 0;
            for (int i = comboBox9.Items.Count - 1; i >= 0; i--)
            {
                string b = "";
                a = "";
                //el list debe haber un list de comobobox 14 o algo asi como el que tiene comobox9 para modtecnicoR
                a = list[index].ToString();
                Periodicidad ot = new Periodicidad(Convert.ToInt32(a), textBox6.Text);
                catalogo.modOti(ot);
                Periodicidad po = new Periodicidad(dateTimePicker3.Text, Convert.ToInt32(a), comboBox1.Text);
                ca.modFecha(po);
              //  Periodicidad pt = new Periodicidad(Convert.ToInt32(comboBox8.SelectedValue), Convert.ToInt32(a), comboBox1.Text);
               // catalogo.modTecnicoR(pt);
                if (index1 < comboBox9.Items.Count - 1)
                {

                    index1++;
                    index++;
                }
                else
                {
                    index1 = index1;
                }

            }
            int index1tec = 0;
            int indextec = 0;
            string atec = "";
            index1tec = 0;
            indextec = 0;
            //aqui lo del comentario anterior
            for (int i = comboBox14.Items.Count - 1; i >= 0; i--)
            {
                string b = "";
                atec = "";              
                atec = listtec[indextec].ToString();
                Periodicidad pt = new Periodicidad(Convert.ToInt32(comboBox8.SelectedValue), Convert.ToInt32(atec), comboBox1.Text);
                catalogo.modTecnicoR(pt);
                if (index1tec < comboBox14.Items.Count - 1)
                {

                    index1tec++;
                    indextec++;
                }
                else
                {
                    index1tec = index1tec;
                }
            }

            listtec.Clear();
            index1tec = 0;
            index = 0;
            list.Clear();
            index1 = 0;
            index = 0;





            int temp = 0;
            int aux2 = comboBox7.SelectedIndex;
            int indexo2 = Convert.ToInt32(comboBox7.SelectedValue);
            for (int i = comboBox7.Items.Count - 1; i >= 0; i--)
            {
                comboBox7.SelectedIndex = temp;
                indexo2 = Convert.ToInt32(comboBox7.SelectedValue);

                list2.Add(indexo2);
                temp++;
            }


            int index12 = 0;
            int index2 = 0;
            string a2 = "";
            temp = 0;

            index12 = 0;
            index2 = 0;

           // if (comboBox1.Text != "Suspendido")
           // {

                for (int i = comboBox7.Items.Count - 1; i >= 0; i--)
                {
                    string b2 = "";
                    a2 = "";
                    a2 = list2[index2].ToString();

                    catalogo.modEstado(pe);
                    CatalogoPlanilla pla = new CatalogoPlanilla();
                    Periodicidad p = new Periodicidad(dateTimePicker3.Text, Convert.ToInt32(a2), Convert.ToInt32(textBox5.Text), textBox6.Text);
                    Periodicidad p2 = new Periodicidad(dateTimePicker3.Text, Convert.ToInt32(a2), textBox8.Text, textBox6.Text);
                    pla.modConsumo(p);
                    pla.modTiempo(p2);
                    pe = new Periodicidad(dateTimePicker3.Text, Convert.ToInt32(a2), comboBox1.Text);
                    ca.modEstado(pe);
                    if (index12 < comboBox7.Items.Count - 1)
                    {

                        index12++;
                        index2++;
                    }
                    else
                    {
                        index12 = index12;
                    }

                }
                list2.Clear();
                index12 = 0;
                index2 = 0;

     
            if (this.comboBox1.Text == "Realizado")
            {

                MessageBox.Show("Información Guardada");
                graDataFiltros();


            }

            if (this.comboBox1.Text == "No Realizado")
            {
                if (textBox7.Text == "")
                {
                    MessageBox.Show("Debe Agregar Motivo");
                }
                else
                {
                    CatalogoNota not = new CatalogoNota();
                    int ind1 = 0;
                    int ind = 0;
                    string v = "";

                    for (int i = comboBox9.Items.Count - 1; i >= 0; i--)
                    {
//combobox 9
                        Nota n = new Nota(comboBox7.Text, textBox7.Text, "Norealizadon---");
                        not.addNota(n);
                        if (ind1 < comboBox9.Items.Count - 1)
                        {
                            ind++;
                            ind++;
                        }
                        else
                        {
                            ind1 = ind1;
                        }

                    }

                    MessageBox.Show("Información Guardada");
                    graDataFiltros();
                }
            }


            if (this.comboBox1.Text == "Suspendido")
            {


                MessageBox.Show("Se debe seleccionar el tipo de suspensión");
                TipoDeSuspendido tr = new TipoDeSuspendido();
                tr.comboBox1.Text = dataGridView1.CurrentRow.Cells["CodR"].Value.ToString();
                CatalogoPlanilla ounits = new CatalogoPlanilla();
                List<Periodicidad> lu2 = ounits.obtenercodperiodiR(dateTimePicker3.Text, tr.comboBox1.Text);
                tr.comboBox2.DataSource = lu2;
                tr.comboBox2.DisplayMember = "cod";
                tr.comboBox2.ValueMember = "cod";
              //  tr.comboBox1.DisplayMember = comboBox6.DisplayMember;
              //  tr.comboBox1.ValueMember = comboBox6.ValueMember;
              //  tr.comboBox1.DataSource = comboBox6.DataSource;
              //  tr.dateTimePicker1.Text = dateTimePicker3.Text;
                tr.comboBox1.Text = comboBox6.Text;
                tr.textBox1.Text = comboBox12.Text;
                tr.dateTimePicker1.Text = dateTimePicker3.Text;
                graDataFiltros();
                tr.Show();


            }
            if (this.comboBox1.Text == "R.Dispositivo")
            {
                MessageBox.Show("Se Debe Seleccionar el tipo de Retiro a planificar");
                TipodeRetiro tr = new TipodeRetiro();
                tr.comboBox1.Text = dataGridView1.CurrentRow.Cells["CodR"].Value.ToString();
                CatalogoPlanilla ounits = new CatalogoPlanilla();
                List<Periodicidad> lu2 = ounits.obtenercodperiodiR(dateTimePicker3.Text, tr.comboBox1.Text);
                tr.comboBox2.DataSource = lu2;
                tr.comboBox2.DisplayMember = "cod";
                tr.comboBox2.ValueMember = "cod";
                tr.comboBox1.Text = comboBox6.Text;
                tr.textBox1.Text = comboBox12.Text;
                tr.dateTimePicker1.Text = dateTimePicker3.Text;
                graDataFiltros();
                tr.Show();


            }
            if (this.comboBox1.Text == "Replanificado")
            {
                if (textBox7.Text == "")
                {
                    MessageBox.Show("Debe Agregar Motivo");
                }
                else
                {

                    CatalogoNota not = new CatalogoNota();
                    int ind1 = 0;
                    int ind = 0;
                    string v = "";

                    for (int i = comboBox9.Items.Count - 1; i >= 0; i--)
                    {

                        Nota n = new Nota(comboBox9.Text, textBox7.Text, "Replanificado--");
                        not.addNota(n);
                        if (ind1 < comboBox9.Items.Count - 1)
                        {
                            ind++;
                            ind++;
                        }
                        else
                        {
                            ind1 = ind1;
                        }

                    }

                    MessageBox.Show("Información Guardada");
                   
                }
                MessageBox.Show("Ha Elegido Replanificar");
                Replanificar rep = new Replanificar();
                rep.dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["FECHAR"].Value.ToString();
                rep.comboBox1.Text = dataGridView1.CurrentRow.Cells["TECNICOR"].Value.ToString();
                rep.comboBox2.Text = dataGridView1.CurrentRow.Cells["CliR"].Value.ToString();
                rep.comboBox3.Text = dataGridView1.CurrentRow.Cells["LugarTratamientoR"].Value.ToString();
                rep.comboBox4.Text = dataGridView1.CurrentRow.Cells["ServicioR"].Value.ToString();
                rep.comboBox5.Text = dataGridView1.CurrentRow.Cells["AreaR"].Value.ToString();
                rep.comboBox8.Text = dataGridView1.CurrentRow.Cells["CodR"].Value.ToString();
                rep.textBox1.Text = dataGridView1.CurrentRow.Cells["TipoR"].Value.ToString();
                rep.comboBox9.Text = dataGridView1.CurrentRow.Cells["NOTI"].Value.ToString();
                rep.list.Add(Convert.ToInt32(comboBox2.SelectedValue));
                graDataFiltros();
                rep.Show();

            }



        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (press == false)
            {
                List<InventariadoR> lista = new List<InventariadoR>();
                CatalogoPlanilla clp = new CatalogoPlanilla();

                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                //   lista = clp.mostrarplanillapornombre(textBox12.Text);
                lista = clp.mostrarplanillaRporcliente(comboBox3.Text, dateTimePicker1.Text, dateTimePicker2.Text);
                this.dataGridView1.DataSource = lista;
            }
            if (press == true)
            {
                List<InventariadoR> lista = new List<InventariadoR>();
                CatalogoPlanilla clp = new CatalogoPlanilla();

                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                //   lista = clp.mostrarplanillapornombre(textBox12.Text);
                lista = clp.mostrarplanillaRporclienteConSecundarios(comboBox3.Text, dateTimePicker1.Text, dateTimePicker2.Text);
                this.dataGridView1.DataSource = lista;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            CatalogoPlanilla ounits = new CatalogoPlanilla();
            List<LugarTratamiento> lu = ounits.getlugar(Convert.ToString(comboBox3.SelectedValue));
            this.comboBox4.DataSource = lu;
            this.comboBox4.DisplayMember = "nombre";
            //cambie el value
            this.comboBox4.ValueMember = "rut";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            CatalogoPlanilla clp = new CatalogoPlanilla();
            List<InventariadoR> lista = new List<InventariadoR>();
            comboBox3.Text = "";
            comboBox4.Text = "";
            lista = clp.mostrarplanillaR(textBox2.Text);

            this.dataGridView1.DataSource = lista;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (press == false)
            {
                List<InventariadoR> lista = new List<InventariadoR>();
                CatalogoPlanilla clp = new CatalogoPlanilla();

                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                lista = clp.mostrarplanillaRporltratamiento(comboBox4.Text, dateTimePicker1.Text, dateTimePicker2.Text);
                this.dataGridView1.DataSource = lista;
            }
            if (press == true) 
            {
                List<InventariadoR> lista = new List<InventariadoR>();
                CatalogoPlanilla clp = new CatalogoPlanilla();

                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                lista = clp.mostrarplanillaRporltratamientoConSecundarios(comboBox4.Text, dateTimePicker1.Text, dateTimePicker2.Text);
                this.dataGridView1.DataSource = lista;
            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            comboBox1.Items.Clear();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            CatalogoPlanilla clp = new CatalogoPlanilla();
            List<InventariadoR> lista = new List<InventariadoR>();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            lista = clp.mostrarplanillaRRealizados(dateTimePicker1.Text, dateTimePicker2.Text);
            this.dataGridView1.DataSource = lista;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CatalogoPlanilla clp = new CatalogoPlanilla();
            List<InventariadoR> lista = new List<InventariadoR>();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            //lista = clp.mostrarplanillaR("");
            lista = clp.mostrarplanillaRARealizar(dateTimePicker1.Text,dateTimePicker2.Text);
            this.dataGridView1.DataSource = lista;
        }


        public void graData()
        {
            CatalogoPlanilla clp = new CatalogoPlanilla();
            List<InventariadoR> lista = new List<InventariadoR>();

            lista = clp.mostrarplanillaR(textBox2.Text);
            this.dataGridView1.DataSource = lista;


        }

        public void graDataFiltros()
        {
            List<InventariadoR> lista2 = new List<InventariadoR>();
            CatalogoPlanilla clp2 = new CatalogoPlanilla();
            lista2 = clp2.mostrarplanillaRporltratamiento(comboBox4.Text, dateTimePicker1.Text, dateTimePicker2.Text);
            this.dataGridView1.DataSource = lista2;


        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (press == false)
            {
                CatalogoPlanilla clp = new CatalogoPlanilla();
                List<InventariadoR> lista = new List<InventariadoR>();
                //    lista = clp.mostrarplanillaporfecha(textBox1.Text + "-" + textBox10.Text + "-" + textBox9.Text);

                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                lista = clp.mostrarplanillaRporfecha(dateTimePicker1.Text, dateTimePicker2.Text);
                dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                this.dataGridView1.DataSource = lista;
            }
            if (press == true)
            {
                CatalogoPlanilla clp = new CatalogoPlanilla();
                List<InventariadoR> lista = new List<InventariadoR>();
                //    lista = clp.mostrarplanillaporfecha(textBox1.Text + "-" + textBox10.Text + "-" + textBox9.Text);

                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                lista = clp.mostrarplanillaRporfechaConSecundarios(dateTimePicker1.Text, dateTimePicker2.Text);
                dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                this.dataGridView1.DataSource = lista;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CatalogoPlanilla clp = new CatalogoPlanilla();
            List<InventariadoR> lista = new List<InventariadoR>();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            lista = clp.mostrarplanillaRNORealizados(dateTimePicker1.Text, dateTimePicker2.Text);
            this.dataGridView1.DataSource = lista;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CatalogoPlanilla clp = new CatalogoPlanilla();
            List<InventariadoR> lista = new List<InventariadoR>();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            lista = clp.mostrarplanillaRSuspendidos(dateTimePicker1.Text, dateTimePicker2.Text);
            this.dataGridView1.DataSource = lista;
        }


        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
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

        private void button11_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewExcelPlanilla(dataGridView1);
            MessageBox.Show("Exportacion Realizada");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "No Realizado")
            {
                textBox7.Enabled = true;

            }
            if (comboBox1.Text == "Replanificado")
            {
                textBox7.Enabled = true;

            }
            if (comboBox1.Text == "Realizado")
            {
                textBox7.Enabled = false;

            }
            if (comboBox1.Text == "Suspendido")
            {
                textBox7.Enabled = false;

            }
            if (comboBox1.Text == "P")
            {
                textBox7.Enabled = false;

            }
            if (comboBox1.Text == "R.Dispositivo")
            {
                textBox7.Enabled = false;

            }
            

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Glosario gl = new Glosario();
            gl.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox11.Text = "";
            if (!(dataGridView1.CurrentRow.Cells["NOTI"].Value == null) || !(dataGridView1.CurrentRow.Cells["Tiempo(MIN)"].Value == null))
            {

                dateTimePicker3.Format = DateTimePickerFormat.Custom;
                dateTimePicker3.CustomFormat = "yyyy-MM-dd";
                dateTimePicker3.Text = dataGridView1.CurrentRow.Cells["FECHAR"].Value.ToString();
                dateTimePicker4.Format = DateTimePickerFormat.Custom;
                dateTimePicker4.CustomFormat = "yyyy-MM-dd";
                dateTimePicker4.Text = dataGridView1.CurrentRow.Cells["FECHAR"].Value.ToString();
                comboBox8.Text = dataGridView1.CurrentRow.Cells["TECNICOR"].Value.ToString();
                comboBox10.Text = dataGridView1.CurrentRow.Cells["TECNICOR"].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells["SERVICIOR"].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells["LUGARTRATAMIENTOR"].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells["CONSUMOR"].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells["NOTI"].Value.ToString();
                comboBox6.Text = dataGridView1.CurrentRow.Cells["CODR"].Value.ToString();
                textBox1.Text = dataGridView1.CurrentRow.Cells["TipoR"].Value.ToString();
                comboBox1.Text = dataGridView1.CurrentRow.Cells["Estado"].Value.ToString();
                textBox8.Text = dataGridView1.CurrentRow.Cells["Tiempo"].Value.ToString();
                textBox7.Text = "";
            }
            else
            {



                dateTimePicker3.Text = dataGridView1.CurrentRow.Cells["FECHAR"].Value.ToString();
                dateTimePicker4.Format = DateTimePickerFormat.Custom;
                dateTimePicker4.CustomFormat = "yyyy-MM-dd";
                dateTimePicker4.Text = dataGridView1.CurrentRow.Cells["FECHAR"].Value.ToString();
                comboBox8.Text = dataGridView1.CurrentRow.Cells["TECNICOR"].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells["SERVICIOR"].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells["LUGARTRATAMIENTOR"].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells["CONSUMOR"].Value.ToString();
                comboBox1.Text = dataGridView1.CurrentRow.Cells["Estado"].Value.ToString();
                textBox7.Text = "";


            }

            if (textBox3.Text == "S1")
            {

                textBox5.Enabled = true;
            }
            else
            {
                textBox5.Enabled = false;
            }
            button1.Enabled = true;
            CatalogoPlanilla ounits = new CatalogoPlanilla();
            CatalogoPlanilla ounits2 = new CatalogoPlanilla();
            CatalogoServicios userv = new CatalogoServicios();
            List<Periodicidad> lu = ounits.obtenerCodPeriodiInforme(dateTimePicker3.Text, textBox4.Text, comboBox8.Text);
            this.comboBox5.DataSource = lu;
            this.comboBox5.DisplayMember = "cod";
            this.comboBox5.ValueMember = "cod";
            List<servicio> lu2 = userv.getCodSer(dateTimePicker3.Text, comboBox6.Text, textBox3.Text);
            this.comboBox2.DataSource = lu2;
            this.comboBox2.DisplayMember = "cod";
            this.comboBox2.ValueMember = "cod";

            List<Periodicidad> lu3 = ounits2.obtenerCodIndividual(dateTimePicker3.Text, comboBox6.Text, comboBox2.Text);
            this.comboBox7.DataSource = lu3;
            this.comboBox7.DisplayMember = "cod";
            this.comboBox7.ValueMember = "cod";
            List<Periodicidad> lu4 = ounits.obtenercodperiodiR(dateTimePicker3.Text, comboBox6.Text);
            comboBox9.DataSource = lu4;
            comboBox9.DisplayMember = "cod";
            comboBox9.ValueMember = "cod";
            CatalogoNota ctnota = new CatalogoNota();
            List<Nota> lu6 = ctnota.mostrarContenido(comboBox7.Text);
            comboBox11.DataSource = lu6;
            comboBox11.DisplayMember = "contenido";
            comboBox11.ValueMember = "contenido";
            textBox7.Text = comboBox11.Text;
            List<Periodicidad> lu7 = ounits.obtenercodperiodiRPrimario(dateTimePicker3.Text, comboBox6.Text);
            comboBox14.DataSource = lu7;
            comboBox14.DisplayMember = "cod";
            comboBox14.ValueMember = "cod";

            CatalogoServicios servcat = new CatalogoServicios();
            List<servicio> ser = servcat.obetenerCodser(textBox3.Text);
            this.comboBox12.DataSource = ser;
            this.comboBox12.DisplayMember = "cod";
            this.comboBox12.ValueMember = "cod";

            comboBox13.Text = dataGridView1.CurrentRow.Cells["ServicioR"].Value.ToString();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((string)this.dataGridView1.Rows[e.RowIndex].Cells["Nivel"].Value == "Secundario")
            {

                foreach (DataGridViewCell celda in this.dataGridView1.Rows[e.RowIndex].Cells)
                {
                    celda.Style.BackColor = Color.LightBlue;
                    celda.Style.ForeColor = Color.Black;
                }
            }
            if ((string)this.dataGridView1.Rows[e.RowIndex].Cells["ServicioR"].Value == "A")
            {

                foreach (DataGridViewCell celda in this.dataGridView1.Rows[e.RowIndex].Cells)
                {
                    celda.Style.BackColor = Color.Yellow;
                    celda.Style.ForeColor = Color.Black;
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {

            CatalogoPlanilla clp = new CatalogoPlanilla();
            List<InventariadoR> lista = new List<InventariadoR>();
            //    lista = clp.mostrarplanillaporfecha(textBox1.Text + "-" + textBox10.Text + "-" + textBox9.Text);

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            lista = clp.mostrarplanillaRporfecha(dateTimePicker1.Text, dateTimePicker2.Text);
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            this.dataGridView1.DataSource = lista;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                press = true;
            }
            else {

                if (checkBox1.Checked == false) 
                {
                    press = false;
                }
            }
        }    
    }
}
