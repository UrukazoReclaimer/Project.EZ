using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.BussinessRules;

namespace Project.Esampm
{
    public partial class PlanillaServicio : Form
    {
        List<int> list11 = new List<int>();
        List<int> list2 = new List<int>();
        List<int> list3 = new List<int>();

        List<int> listaservicios = new List<int>();
        List<int> listaservicios2 = new List<int>();
        List<int> listaareas = new List<int>();
        List<int> listaareas2 = new List<int>();

        Boolean registro = false;
        List<string> list12 = new List<string>();
        List<int> list = new List<int>();
        List<int> listcod = new List<int>();
        List<int> liststr = new List<int>();
        List<int> listdescrip = new List<int>();
        List<int> listmodificar = new List<int>();
        Boolean registroservicio = false;
        Boolean registroarea = false;
        public PlanillaServicio(string s)
        {

            InitializeComponent();


            CatalogoCliente cunitsbu = new CatalogoCliente();
            List<cliente> unibu = cunitsbu.getclierut();
            this.comboBox18.DataSource = unibu;
            this.comboBox18.DisplayMember = "nombre";
            this.comboBox18.ValueMember = "rut";

            CatalogoPlanilla ounits4 = new CatalogoPlanilla();
            List<LugarTratamiento> lu4 = ounits4.allgetlugar();
            this.comboBox13.DataSource = lu4;
            this.comboBox13.DisplayMember = "nombre";
            this.comboBox13.ValueMember = "rut";

            CatalogoCliente cunits = new CatalogoCliente();
            List<cliente> uni = cunits.getclierut();
            this.comboBox4.DataSource = uni;
            this.comboBox4.DisplayMember = "nombre";
            this.comboBox4.ValueMember = "rut";



            CatalogoPlanilla ounits2 = new CatalogoPlanilla();
            List<LugarTratamiento> lu3 = ounits2.allgetlugar();
            this.comboBox6.DataSource = lu3;
            this.comboBox6.DisplayMember = "nombre";

            this.comboBox6.ValueMember = "rut";




            catalogoTecnico tunits = new catalogoTecnico();
            List<Project.BussinessRules.Tecnico> tec = tunits.obtenertec();

            this.comboBox3.DataSource = tec;
            this.comboBox3.DisplayMember = "nombre";
            this.comboBox3.ValueMember = "cod";


            catalogoTecnico tunits8 = new catalogoTecnico();
            List<Project.BussinessRules.Tecnico> tec8 = tunits8.obtenertec();

            this.comboBox23.DataSource = tec8;
            this.comboBox23.DisplayMember = "nombre";
            this.comboBox23.ValueMember = "cod";

            CatalogoServicios sunits = new CatalogoServicios();
            List<Project.BussinessRules.servicio> ser = sunits.getser();
            this.comboBox2.DataSource = ser;
            this.comboBox2.DisplayMember = "sigla";
            this.comboBox2.ValueMember = "cod";

            CatalogoCliente cunits2 = new CatalogoCliente();
            List<cliente> uni2 = cunits.getclierut();
            this.comboBox5.DataSource = uni;
            this.comboBox5.DisplayMember = "nombre";
            this.comboBox5.ValueMember = "rut";


            CatalogoPlanilla ounits = new CatalogoPlanilla();
            List<LugarTratamiento> lu = ounits.getlugar(Convert.ToString(comboBox4.SelectedValue));
            this.comboBox9.DataSource = lu;
            this.comboBox9.DisplayMember = "nombre";

            this.comboBox9.ValueMember = "rut";

            CatalogoCliente ca = new CatalogoCliente();
            List<cliente> la = ca.getclientcodfornom(comboBox4.Text);
            this.comboBox11.DataSource = la;
            this.comboBox11.DisplayMember = "cod";

            this.comboBox11.ValueMember = "cod";


            CatalogoArea aunits = new CatalogoArea();
            List<Area> are = aunits.getarea();
            this.comboBox10.DataSource = are;
            this.comboBox10.DisplayMember = "NombreArea";
            this.comboBox10.ValueMember = "cod";

           
         
            
            /*
            CatalogoCliente cabu = new CatalogoCliente();
            List<cliente> labu = cabu.getclientcodfornom(comboBox18.Text);
            this.comboBox19.DataSource = labu;
            this.comboBox19.DisplayMember = "cod";

            this.comboBox19.ValueMember = "cod";
            */
            catalogoTecnico tecni = new catalogoTecnico();
            List<Project.BussinessRules.Tecnico> te = tecni.obtenertec();

            this.comboBox20.DataSource = te;
            this.comboBox20.DisplayMember = "nombre";
            this.comboBox20.ValueMember = "cod";

            CatalogoCliente co = new CatalogoCliente();
            List<LugarTratamiento> lo = co.getLtracod(Convert.ToString(comboBox13.Text));
            this.comboBox8.DataSource = lo;
            this.comboBox8.DisplayMember = "cod";

            this.comboBox8.ValueMember = "cod";

            CatalogoPlanilla clp = new CatalogoPlanilla();
            List<Inventariado> lista = new List<Inventariado>();

            lista = clp.mostrarplanilla(s);

            this.dataGridView1.DataSource = lista;
           


            registro = true;
            registroservicio = true;
            registroarea = true;

        }

        private void PlanillaServico_Load(object sender, EventArgs e)
        {
            Refresh();

        //    this.button3.Visible = true;


        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox6.Enabled = true;
            CatalogoPlanilla ounits = new CatalogoPlanilla();
            List<LugarTratamiento> lu = ounits.getlugar(Convert.ToString(comboBox4.SelectedValue));
            this.comboBox6.DataSource = lu;
            this.comboBox6.DisplayMember = "nombre";

            this.comboBox4.ValueMember = "rut";

            CatalogoCliente ca = new CatalogoCliente();
            List<cliente> la = ca.getclientcodfornom(comboBox4.Text);
            this.comboBox7.DataSource = la;
            this.comboBox7.DisplayMember = "cod";

            this.comboBox7.ValueMember = "cod";


        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            list12.Clear();
            comboBox155.Items.Clear();
            list.Clear();
            comboBox12.Items.Clear();
            comboBox10.Enabled = false;
            comboBox2.Enabled = false;
            comboBox155.Visible = false;
            comboBox12.Visible = false; 
            List<int> codperio = new List<int>();
           

                listaservicios.Clear();
                listaareas.Clear();
            
            comboBox2.Text = dataGridView1.CurrentRow.Cells["SERVICIO"].Value.ToString();
            comboBox3.Text = dataGridView1.CurrentRow.Cells["TECNICO"].Value.ToString();
            comboBox5.Text = dataGridView1.CurrentRow.Cells["CLIENTE"].Value.ToString();
            comboBox9.Text = dataGridView1.CurrentRow.Cells["LUGARTRATAMIENTO"].Value.ToString();
            comboBox10.Text = dataGridView1.CurrentRow.Cells["AREA"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["FECHA"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["RUT"].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells["COD"].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells["TIPO"].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells["DescripcionParticular"].Value.ToString();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            CatalogoPlanilla ounits = new CatalogoPlanilla();
            List<Periodicidad> lu = ounits.obetenerCodPeriodi(textBox2.Text, dateTimePicker1.Text, textBox4.Text);
            this.comboBox17.DataSource = lu;
            this.comboBox17.DisplayMember = "cod";
            this.comboBox17.ValueMember = "cod";

            CatalogoServicios servcat = new CatalogoServicios();
            List<servicio> ser = servcat.obetenerCodser(comboBox2.Text);
            this.comboBox15.DataSource = ser;
            this.comboBox15.DisplayMember = "cod";
            this.comboBox15.ValueMember = "cod";

            List<Periodicidad> lu2 = ounits.obtenerCodPeriodiEstado(textBox2.Text, dateTimePicker1.Text, textBox4.Text);
            this.comboBox14.DataSource = lu2;
            this.comboBox14.DisplayMember = "estado";
            this.comboBox14.ValueMember = "estado";

            int temp = 0;
            int aux2 = comboBox17.SelectedIndex;
            int indexo2 = Convert.ToInt32(comboBox17.SelectedValue);
            for (int i = comboBox17.Items.Count - 1; i >= 0; i--)
            {
                comboBox17.SelectedIndex = temp;
                indexo2 = Convert.ToInt32(comboBox17.SelectedValue);

                CatalogoPlanilla ounits7 = new CatalogoPlanilla();
                List<Periodicidad> lu7 = ounits7.obtenercodservicio(Convert.ToString(indexo2));
                this.comboBox21.DataSource = lu7;
                this.comboBox21.DisplayMember = "cod";
                this.comboBox21.ValueMember = "cod";
                listaservicios.Add(Convert.ToInt32(comboBox21.Text));
                temp++;
            }

            temp = 0;
            aux2 = 0;
            indexo2 = 0;

            for (int i = comboBox17.Items.Count - 1; i >= 0; i--)
            {
                comboBox17.SelectedIndex = temp;
                indexo2 = Convert.ToInt32(comboBox17.SelectedValue);

                CatalogoPlanilla ounits7 = new CatalogoPlanilla();
                List<Periodicidad> lu7 = ounits7.obtenercodarea(Convert.ToString(indexo2));
                this.comboBox22.DataSource = lu7;
                this.comboBox22.DisplayMember = "cod";
                this.comboBox22.ValueMember = "cod";
                listaareas.Add(Convert.ToInt32(comboBox22.Text));
                temp++;
            }
            temp = 0;
            aux2 = 0;
            indexo2 = 0;
/*
            CatalogoPlanilla ounits7 = new CatalogoPlanilla();
            List<Periodicidad> lu7 = ounits.obtenercodservicio(comboBox17.Text);
            this.comboBox21.DataSource = lu7;
            this.comboBox21.DisplayMember = "cod";
            this.comboBox21.ValueMember = "cod";
            listaservicios.Add(Convert.ToInt32(comboBox21.Text));
        */   
         //   */

        }

        private void clienteBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CatalogoPlanilla existe = new CatalogoPlanilla();
            List<Periodicidad> listaExiste = existe.existeClienteRegistrado(textBox3.Text,comboBox6.Text);
            this.comboBox24.DataSource = listaExiste;
            this.comboBox24.DisplayMember = "cod";
            this.comboBox24.ValueMember = "cod";

            if (comboBox1.Text == null && comboBox7 == null || comboBox1.Text == "Esam Ltda.")
            {
                MessageBox.Show("Seleccione Un Cliente Válido");
            }
            else
            {
                if (MessageBox.Show("¿Desea Guardar la planificación?", "ATENCIÓN",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                 == DialogResult.Yes)
                {
                    if (comboBox24.Text != "")
                    {
                        MessageBox.Show("Ya existe un cliente registrado este año, por favor verifique información");
                    }
                        TableroPeriodicidad tab = new TableroPeriodicidad();
                        CatalogoPlanilla ca = new CatalogoPlanilla();
                        Planilla pla = new Planilla(Convert.ToString(comboBox4.SelectedValue), Convert.ToString(this.comboBox1.Text), textBox8.Text, Convert.ToInt32(this.comboBox7.Text), Convert.ToInt32(this.comboBox8.Text));
                        ca.addplanilla(pla);
                        button3.Visible = true;
                        MessageBox.Show("Ingreso Completado Se abrirá el Tablero de Periodicidad");
                        tab.textBox1.Text = comboBox6.Text;
                        tab.textBox2.Text = textBox3.Text;
                        tab.MdiParent = Principal.ActiveForm;
                        tab.Show();
                    
                  
                }

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            CatalogoCliente ca = new CatalogoCliente();
            List<LugarTratamiento> la = ca.getLtracod(Convert.ToString(comboBox6.Text));
            this.comboBox8.DataSource = la;
            this.comboBox8.DisplayMember = "cod";

            this.comboBox8.ValueMember = "cod";

        }

        private void button3_Click(object sender, EventArgs e)
        {

            TableroPeriodicidad tab = new TableroPeriodicidad();
            tab.textBox1.Text = comboBox6.Text;
            tab.MdiParent = Principal.ActiveForm;
            tab.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (registro == true)
            {

            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            IngresarArea inga = new IngresarArea();
            inga.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Informe_Click(object sender, EventArgs e)
        {
            Informe inf = new Informe();
            inf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlanillaServicio pl = new PlanillaServicio("");
            this.Close();
            pl.Show();


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void dateTimePicker1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            CatalogoPlanilla clp = new CatalogoPlanilla();
            List<Inventariado> lista = new List<Inventariado>();


            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "yyyy-MM-dd";
            lista = clp.mostrarplanillaporfecha(dateTimePicker2.Text, dateTimePicker3.Text);
            dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            dateTimePicker3.CustomFormat = "dd-MM-yyyy";
            this.dataGridView1.DataSource = lista;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (textBox9.Text == "")
            {
                MessageBox.Show("Debe agregar Nota");

            }
            else
            {
                if (comboBox14.Text != "P")
                {
                    MessageBox.Show("La visita ya contiene cambios en Planilla R");

                }
                else
                {
                    if (comboBox155.Visible==false || comboBox12.Visible==false)
                    {
                        CatalogoPlanilla ca = new CatalogoPlanilla();
                    


                        int temp = 0;
                        comboBox17.Text = Convert.ToString(comboBox17.SelectedValue);
                        comboBox17.SelectedIndex = comboBox17.FindString(comboBox17.Text);
                        int aux = comboBox17.SelectedIndex;
                        int indexo = Convert.ToInt32(comboBox17.SelectedValue);
                        for (int i = comboBox17.Items.Count - 1; i >= 0; i--)
                        {

                            comboBox17.SelectedIndex = temp;
                            indexo = Convert.ToInt32(comboBox17.SelectedValue);

                            liststr.Add(indexo);
                            string borrar;
                            borrar = indexo.ToString();
                            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                            ca.modiFecha(dateTimePicker1.Text,indexo);
                            ca.modiTecnico(Convert.ToInt32(comboBox3.SelectedValue),indexo);
                            temp++;

                        }

                    }
                    else
                    {

                        CatalogoPlanilla ca = new CatalogoPlanilla();
                        Periodicidad pl = new Periodicidad(dateTimePicker1.Text, Convert.ToInt32(textBox4.Text), Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(comboBox3.SelectedValue), comboBox10.Text);


                        dateTimePicker1.Format = DateTimePickerFormat.Custom;

                        dateTimePicker1.CustomFormat = "yyyy-MM-dd";


                        int temp = 0;
                        comboBox17.Text = Convert.ToString(comboBox17.SelectedValue);
                        comboBox17.SelectedIndex = comboBox17.FindString(comboBox17.Text);
                        int aux = comboBox17.SelectedIndex;
                        int indexo = Convert.ToInt32(comboBox17.SelectedValue);
                        for (int i = comboBox17.Items.Count - 1; i >= 0; i--)
                        {

                            comboBox17.SelectedIndex = temp;
                            indexo = Convert.ToInt32(comboBox17.SelectedValue);

                            liststr.Add(indexo);
                            string borrar;
                            borrar = indexo.ToString();
                            ca.borrarPeriodidicad(borrar);
                            temp++;

                        }
                       



                        dateTimePicker1.Format = DateTimePickerFormat.Custom;
                        dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                        pl = new Periodicidad(dateTimePicker1.Text, Convert.ToInt32(textBox4.Text), Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(comboBox3.SelectedValue),  comboBox10.Text);

                        int index = 0;
                        int index1 = 0;
                        for (int j = list.Count - 1; j >= 0; j--)
                        {

                            string a = "";
                            a = list[index].ToString();
                            if (list12.Count != 0)
                            {
                               
                                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                                    dateTimePicker1.CustomFormat = "yyyy-MM-dd";

                                    //lo mismo que la periodicidad
                                    string b = "";
                                    b = string.Join(",", list12.ToArray());
                                    pl = new Periodicidad(dateTimePicker1.Text, Convert.ToInt32(textBox4.Text), Convert.ToInt32(a), Convert.ToInt32(comboBox3.SelectedValue), b, "", 0, textBox6.Text, "P", "", "Primario", "", "");
                                    ca.addfecha(pl);

                                    CatalogoPlanilla lumax = new CatalogoPlanilla();
                                    List<Periodicidad> max = lumax.getmaxcodperi();
                                    this.comboBox16.DataSource = max;
                                    this.comboBox16.DisplayMember = "cod";
                                    this.comboBox16.ValueMember = "cod";

                                    listmodificar.Add(Convert.ToInt32(comboBox16.Text));
                                    if (index1 < list12.Count - 1)
                                    {

                                        index1++;
                                    }
                                    else
                                    {
                                        index1 = index1;
                                    }


                                
                                index1 = 0;
                                index++;
                            }
                            else
                            {
                                pl = new Periodicidad(dateTimePicker1.Text, Convert.ToInt32(textBox4.Text), Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(comboBox3.SelectedValue), "N/A", "", 0, textBox6.Text, "P", "", "Primario", "", "");

                                ca.addfecha(pl);

                              //  listmodificar.Add(Convert.ToInt32(comboBox16.Text));

                            }
                        }

                        MessageBox.Show("Modificación Realizada");
                        dateTimePicker1.Format = DateTimePickerFormat.Custom;
                        dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                    }
                }
               
               /*
                CatalogoPlanilla lumax = new CatalogoPlanilla();
                List<Periodicidad> max = lumax.getmaxcodperi();
                this.comboBox16.DataSource = max;
                this.comboBox16.DisplayMember = "cod";
                this.comboBox16.ValueMember = "cod";
                */
        
                    CatalogoNota not = new CatalogoNota();
                    int ind1 = 0;
                    int ind = 0;
                    string v = "";
                int indexmodificar;
                indexmodificar=0;

                    for (int i = listmodificar.Count - 1; i >= 0; i--)
                    {
                        
                         v = listmodificar[indexmodificar].ToString();
                        Nota n = new Nota(v, textBox9.Text, "NModificado--");
                        not.addNota(n);
                        if (ind1 < comboBox17.Items.Count - 1)
                        {
                            ind++;
                            ind1++;
                            indexmodificar++;
                        }
                        else
                        {
                            ind1 = ind1;
                        }

                    }

                    MessageBox.Show("Nota Guardada");


                    textBox9.Text="";
                    if (comboBox10.Enabled == false)
                    {

                        list12.Clear();
                        comboBox155.Items.Clear();
                        list.Clear();
                        comboBox12.Items.Clear();
                        comboBox10.Enabled = true;
                        comboBox2.Enabled = true;
                        comboBox155.Visible = true;
                        comboBox12.Visible = true;
                    }
                    else
                    {
                        if (comboBox10.Enabled == true)
                        {

                            list12.Clear();
                            comboBox155.Items.Clear();
                            list.Clear();
                            comboBox12.Items.Clear();
                            comboBox10.Enabled = false;
                            comboBox2.Enabled = false;
                            comboBox155.Visible = false;
                            comboBox12.Visible = false;
                        }


                    }

            }
             
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            List<Inventariado> lista = new List<Inventariado>();
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

             
                CatalogoPlanilla clp = new CatalogoPlanilla();

                lista = clp.mostrarplanillabuscar(comboBox18.Text, dateTimePicker2.Text, dateTimePicker3.Text);
                this.dataGridView1.DataSource = lista;

                if (comboBox18.Text == "")
                {

                    CatalogoPlanilla clpp = new CatalogoPlanilla();
                    List<Inventariado> lista1 = new List<Inventariado>();

                    lista1 = clpp.mostrarplanilla("");


                }

            }

        }
        public void graData()
        {



            CatalogoPlanilla clp = new CatalogoPlanilla();
            List<Inventariado> lista = new List<Inventariado>();

            lista = clp.mostrarplanilla(textBox3.Text);
            this.dataGridView1.DataSource = lista;

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            List<Inventariado> lista = new List<Inventariado>();
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                MessageBox.Show("hola");

                CatalogoPlanilla clp = new CatalogoPlanilla();
                comboBox18.Text = comboBox18.Text;
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                dateTimePicker3.Format = DateTimePickerFormat.Custom;
                dateTimePicker3.CustomFormat = "yyyy-MM-dd";

                lista = clp.mostrarplanillabuscar(comboBox18.Text, dateTimePicker2.Text, dateTimePicker3.Text);
                this.dataGridView1.DataSource = lista;

                if (comboBox18.Text == "")
                {

                    CatalogoPlanilla clpp = new CatalogoPlanilla();
                    List<Inventariado> lista1 = new List<Inventariado>();

                    lista1 = clpp.mostrarplanilla("");


                }

            }
        }

        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registroarea == true)
            {
                

                comboBox155.Text = comboBox10.Text;

                string b = comboBox10.Text;
                comboBox155.Items.Add(comboBox10.Text);

                list12.Add(comboBox155.Text);
            }
        }
        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (registroservicio == true)
            {

                int index = Convert.ToInt32(comboBox2.SelectedValue);
                comboBox2.SelectedValue = index;
                comboBox12.Items.Add(comboBox2.Text);

                list.Add(index);
            }
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void comboBox155_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            list12.Clear();
            comboBox155.Items.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            list.Clear();
            comboBox12.Items.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CatalogoPlanilla clp = new CatalogoPlanilla();
            List<Inventariado> lista = new List<Inventariado>();

            lista = clp.mostrarplanilla(textBox3.Text);

            this.dataGridView1.DataSource = lista;
        }

        private void comboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {
            CatalogoPlanilla ounits = new CatalogoPlanilla();
            List<LugarTratamiento> lu = ounits.getlugar(Convert.ToString(comboBox18.SelectedValue));
            this.comboBox13.DataSource = lu;
            this.comboBox13.DisplayMember = "nombre";

            this.comboBox13.ValueMember = "rut";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            List<Inventariado> lista = new List<Inventariado>();
            CatalogoPlanilla clp = new CatalogoPlanilla();
         
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "yyyy-MM-dd";

            lista = clp.mostrarplanillabuscar(comboBox18.Text, dateTimePicker2.Text, dateTimePicker3.Text);
            this.dataGridView1.DataSource = lista;



            if (comboBox18.Text == "")
            {

                CatalogoPlanilla clpp = new CatalogoPlanilla();
                List<Inventariado> lista1 = new List<Inventariado>();

                lista1 = clpp.mostrarplanilla("");


            }
        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            List<Inventariado> lista = new List<Inventariado>();
            CatalogoPlanilla clp = new CatalogoPlanilla();
          
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "yyyy-MM-dd";

            lista = clp.mostrarplanillabuscar(comboBox18.Text, dateTimePicker2.Text, dateTimePicker3.Text);
            this.dataGridView1.DataSource = lista;

            if (comboBox18.Text == "")
            {

                CatalogoPlanilla clpp = new CatalogoPlanilla();
                List<Inventariado> lista1 = new List<Inventariado>();

                lista1 = clpp.mostrarplanilla("");


            }
             
        }

        private void button10_Click(object sender, EventArgs e)
        {
            List<Inventariado> lista = new List<Inventariado>();
            CatalogoPlanilla clp = new CatalogoPlanilla();
          
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "yyyy-MM-dd";

            lista = clp.mostrarplanillabuscarporltratamiento(comboBox13.Text, dateTimePicker2.Text, dateTimePicker3.Text);
            this.dataGridView1.DataSource = lista;

            if (comboBox13.Text == "")
            {

                CatalogoPlanilla clpp = new CatalogoPlanilla();
                List<Inventariado> lista1 = new List<Inventariado>();

                lista1 = clpp.mostrarplanilla("");


            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            CatalogoPlanilla ca = new CatalogoPlanilla();
            int aux = 0;
            aux = 0;
            int indexo = Convert.ToInt32(comboBox17.SelectedValue);
            for (int i = comboBox17.Items.Count - 1; i >= 0; i--)
            {
                comboBox17.SelectedIndex = aux;
                indexo=Convert.ToInt32(comboBox17.SelectedValue);

                liststr.Add(indexo);
                aux++;
                Periodicidad at = new Periodicidad(this.textBox8.Text, Convert.ToInt32(textBox4.Text), indexo);
                ca.modiObsParticulares(at);
               
            }
            MessageBox.Show("Observación Guardada");
            this.graData();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            CatalogoPlanilla ca = new CatalogoPlanilla();
            Planilla at = new Planilla(this.textBox5.Text, Convert.ToInt32(textBox4.Text));
            ca.modiObs(at);
            MessageBox.Show("Observación Guardada");
            this.graData();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            comboBox18.Text = "";
          
            comboBox13.Text = "";
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            comboBox3.Text = "";
            comboBox5.Text = "";
            comboBox9.Text = "";
            comboBox10.Text = "";
            comboBox2.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (comboBox17.Text != "")
            {
                int indexo2 = Convert.ToInt32(comboBox17.SelectedValue);
                for (int i = comboBox17.Items.Count - 1; i >= 0; i--)
                {
                    comboBox17.SelectedValue = indexo2;

                    list2.Add(indexo2);
                    indexo2++;
                }

                CatalogoPlanilla catalogo = new CatalogoPlanilla();
                CatalogoPlanilla ca = new CatalogoPlanilla();

                Periodicidad pe = new Periodicidad(dateTimePicker1.Text, Convert.ToInt32(comboBox17.Text), "Suspendido");
                int index12 = 0;
                int index2 = 0;
                string a2 = "";


                index12 = 0;
                index2 = 0;


                for (int i = comboBox17.Items.Count - 1; i >= 0; i--)
                {
                    string b2 = "";
                    a2 = "";
                    a2 = list2[index2].ToString();
                    CatalogoPlanilla pla = new CatalogoPlanilla();
                    catalogo.modEstado(pe);
                    pe = new Periodicidad(dateTimePicker1.Text, Convert.ToInt32(a2), "Suspendido");
                    ca.modEstado(pe);
                    if (index12 < comboBox17.Items.Count - 1)
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

                MessageBox.Show("Se debe seleccionar el tipo de suspensión");
                TipoDeSuspendido tr = new TipoDeSuspendido();
                tr.comboBox1.Text = dataGridView1.CurrentRow.Cells["Cod"].Value.ToString();
                CatalogoPlanilla ounits = new CatalogoPlanilla();
                List<Periodicidad> lu2 = ounits.obtenercodperiodiR(dateTimePicker1.Text, textBox4.Text);
                tr.comboBox2.DataSource = lu2;
                tr.comboBox2.DisplayMember = "cod";
                tr.comboBox2.ValueMember = "cod";
                tr.dateTimePicker1.Text = dateTimePicker3.Text;
                tr.Show();
            }
            else
            {

                MessageBox.Show("No hay datos seleccionados");
            }
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }
/// <summary>
/// aqui referencia de color
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if ((string)this.dataGridView1.Rows[e.RowIndex].Cells["SERVICIO"].Value == "PP")
            {

                foreach (DataGridViewCell celda in this.dataGridView1.Rows[e.RowIndex].Cells)
                {
                    celda.Style.BackColor = Color.Red;
                    celda.Style.ForeColor = Color.White;
                }
            }
            if ((string)this.dataGridView1.Rows[e.RowIndex].Cells["TIPO"].Value == "DC")
            {

                foreach (DataGridViewCell celda in this.dataGridView1.Rows[e.RowIndex].Cells)
                {
                    celda.Style.BackColor = Color.LightGreen;
                    celda.Style.ForeColor = Color.Black;
                }
            }
            if ((string)this.dataGridView1.Rows[e.RowIndex].Cells["Nivel"].Value == "Secundario")
            {

                foreach (DataGridViewCell celda in this.dataGridView1.Rows[e.RowIndex].Cells)
                {
                    celda.Style.BackColor = Color.LightBlue;
                    celda.Style.ForeColor = Color.Black;
                }
            }
            if ((string)this.dataGridView1.Rows[e.RowIndex].Cells["Servicio"].Value == "Auditoria")
            {

                foreach (DataGridViewCell celda in this.dataGridView1.Rows[e.RowIndex].Cells)
                {
                    celda.Style.BackColor = Color.Yellow;
                    celda.Style.ForeColor = Color.Black;
                }
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewExcelPlanilla(dataGridView1);
            MessageBox.Show("Exportación Realizada");
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

        private void button16_Click(object sender, EventArgs e)
        {
            Calendario cl = new Calendario();
            cl.Show();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            CatalogoPlanilla ac = new CatalogoPlanilla();
            ac.eliminarPermiso("11",comboBox17.Text);
            MessageBox.Show("Permiso Eliminado");
            this.graData();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            List<Inventariado> lista = new List<Inventariado>();
            CatalogoPlanilla clp = new CatalogoPlanilla();
            
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "yyyy-MM-dd";

            lista = clp.mostrarplanillabuscarTecnico(comboBox20.Text, dateTimePicker2.Text, dateTimePicker3.Text);
            this.dataGridView1.DataSource = lista;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            planificar(listaservicios2, listaareas2, textBox4, dateTimePicker1, comboBox23);
            listaservicios2.Clear();
            listaareas2.Clear();
            MessageBox.Show("Ingreso Completado");

            panel4.Visible = false;
        }

        public void planificar(List<int> listser, List<int> listarea, TextBox c1, DateTimePicker fecha, ComboBox tec)
        {
            

            CatalogoPlanilla ca = new CatalogoPlanilla();
            int index = 0;
         

            for (int j = listser.Count - 1; j >= 0; j--)
            {

                string a = "";
                a = listser[index].ToString();
                if (listarea.Count != 0)
                {

                    fecha.Format = DateTimePickerFormat.Custom;

                    fecha.CustomFormat = "yyyy-MM-dd";
                    string b = "";

                    Periodicidad pla = new Periodicidad(fecha.Text, Convert.ToInt32(c1.Text), Convert.ToInt32(a), Convert.ToInt32(tec.SelectedValue), b, "", 0, textBox6.Text, "P", "", "Secundario", "", "");
                    ca.addfecha(pla);


                    index++;

                }
                else
                {
                    fecha.Format = DateTimePickerFormat.Custom;

                    fecha.CustomFormat = "yyyy-MM-dd";
                    Periodicidad pla = new Periodicidad(fecha.Text, Convert.ToInt32(c1.Text), Convert.ToInt32(a), Convert.ToInt32(tec.SelectedValue), "N/A", "", 0, textBox6.Text, "P", "", "Secundario", "", "");
                    ca.addfecha(pla);

                    index++;

                }
            }
            index = 0;
          
             
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (comboBox10.Enabled == false)
            {

                list12.Clear();
                comboBox155.Items.Clear();
                list.Clear();
                comboBox12.Items.Clear();
                comboBox10.Enabled = true;
                comboBox2.Enabled = true;
                comboBox155.Visible = true;
                comboBox12.Visible = true;
            }
            else {
                if (comboBox10.Enabled == true)
                {

                    list12.Clear();
                    comboBox155.Items.Clear();
                    list.Clear();
                    comboBox12.Items.Clear();
                    comboBox10.Enabled = false;
                    comboBox2.Enabled = false;
                    comboBox155.Visible = false;
                    comboBox12.Visible = false;
                }
            
            
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            list12.Clear();
            comboBox155.Items.Clear();
            list.Clear();
            listaservicios2.Clear();
            listaareas2.Clear();
            comboBox12.Items.Clear();
            comboBox10.Enabled = false;
            comboBox2.Enabled = false;
            comboBox155.Visible = false;
            comboBox12.Visible = false;
            List<int> codperio = new List<int>();


            listaservicios.Clear();
            listaareas.Clear();

            comboBox2.Text = dataGridView1.CurrentRow.Cells["SERVICIO"].Value.ToString();
            comboBox3.Text = dataGridView1.CurrentRow.Cells["TECNICO"].Value.ToString();
            comboBox5.Text = dataGridView1.CurrentRow.Cells["CLIENTE"].Value.ToString();
            comboBox9.Text = dataGridView1.CurrentRow.Cells["LUGARTRATAMIENTO"].Value.ToString();
            comboBox10.Text = dataGridView1.CurrentRow.Cells["AREA"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["FECHA"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["RUT"].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells["COD"].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells["TIPO"].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells["DescripcionParticular"].Value.ToString();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            CatalogoPlanilla ounits = new CatalogoPlanilla();
            List<Periodicidad> lu = ounits.obetenerCodPeriodi(textBox2.Text, dateTimePicker1.Text, textBox4.Text);
            this.comboBox17.DataSource = lu;
            this.comboBox17.DisplayMember = "cod";
            this.comboBox17.ValueMember = "cod";

            CatalogoServicios servcat = new CatalogoServicios();
            List<servicio> ser = servcat.obetenerCodser(comboBox2.Text);
            this.comboBox15.DataSource = ser;
            this.comboBox15.DisplayMember = "cod";
            this.comboBox15.ValueMember = "cod";
//qui
            CatalogoPlanilla servcat2 = new CatalogoPlanilla();
            List<Tecnico> Tec2 = servcat2.obtenercodTec(comboBox3.Text);
            this.comboBox25.DataSource = Tec2;
            this.comboBox25.DisplayMember = "cod";
            this.comboBox25.ValueMember = "cod";


            List<Periodicidad> lu2 = ounits.obtenerCodPeriodiEstado(textBox2.Text, dateTimePicker1.Text, textBox4.Text);
            this.comboBox14.DataSource = lu2;
            this.comboBox14.DisplayMember = "estado";
            this.comboBox14.ValueMember = "estado";
//aqui
            CatalogoPlanilla ounits4 = new CatalogoPlanilla();
            List<Periodicidad> lu4 = ounits4.obetenerCodPeriodiSoloTEC(textBox2.Text, dateTimePicker1.Text, textBox4.Text,comboBox25.Text);
            this.comboBox26.DataSource = lu4;
            this.comboBox26.DisplayMember = "cod";
            this.comboBox26.ValueMember = "cod";


            int temp2 = 0;
            int aux3 = comboBox26.SelectedIndex;
            int indexo3 = Convert.ToInt32(comboBox26.SelectedValue);
            for (int i = comboBox26.Items.Count - 1; i >= 0; i--)
            {
                comboBox26.SelectedIndex = temp2;
                indexo3 = Convert.ToInt32(comboBox26.SelectedValue);

                CatalogoPlanilla ounits7 = new CatalogoPlanilla();
                List<Periodicidad> lu7 = ounits7.obtenercodservicio(Convert.ToString(indexo3));
                this.comboBox21.DataSource = lu7;
                this.comboBox21.DisplayMember = "cod";
                this.comboBox21.ValueMember = "cod";
                listaservicios2.Add(Convert.ToInt32(comboBox21.Text));
                temp2++;
            }

          
          
            temp2 = 0;
            aux3 = 0;
            indexo3 = 0;



            int temp = 0;
            int aux2 = comboBox17.SelectedIndex;
            int indexo2 = Convert.ToInt32(comboBox17.SelectedValue);
            for (int i = comboBox17.Items.Count - 1; i >= 0; i--)
            {
                comboBox17.SelectedIndex = temp;
                indexo2 = Convert.ToInt32(comboBox17.SelectedValue);

                CatalogoPlanilla ounits7 = new CatalogoPlanilla();
                List<Periodicidad> lu7 = ounits7.obtenercodservicio(Convert.ToString(indexo2));
                this.comboBox21.DataSource = lu7;
                this.comboBox21.DisplayMember = "cod";
                this.comboBox21.ValueMember = "cod";
                listaservicios.Add(Convert.ToInt32(comboBox21.Text));
                temp++;
            }

            temp = 0;
            aux2 = 0;
            indexo2 = 0;

           
            /*
                        CatalogoPlanilla ounits7 = new CatalogoPlanilla();
                        List<Periodicidad> lu7 = ounits.obtenercodservicio(comboBox17.Text);
                        this.comboBox21.DataSource = lu7;
                        this.comboBox21.DisplayMember = "cod";
                        this.comboBox21.ValueMember = "cod";
                        listaservicios.Add(Convert.ToInt32(comboBox21.Text));
                    */   


        }

        private void button20_Click(object sender, EventArgs e)
        {
            CatalogoPlanilla ac = new CatalogoPlanilla();
            int cont = 0; ;
            for (int i = 0; i <= comboBox26.Items.Count-1; i++)
            {
                comboBox26.SelectedIndex = cont;
                ac.eliminarTecSecundario(dataGridView1.CurrentRow.Cells["Nivel"].Value.ToString(), comboBox26.Text);
                cont++;
            }
            MessageBox.Show("Eliminado");
        }

    }
}
