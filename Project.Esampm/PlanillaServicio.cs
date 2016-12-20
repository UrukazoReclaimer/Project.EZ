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

        Boolean registro = false;
        List<int> list12 = new List<int>();
        List<int> list = new List<int>();
        List<int> listcod = new List<int>();
        List<int> liststr = new List<int>();
        List<int> listdescrip = new List<int>();
        Boolean registroservicio = false;
        Boolean registroarea = false;
        public PlanillaServicio(string s)
        {

            InitializeComponent();

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
            List<Project.BussinessRules.Tecnico> tec = tunits.gettec();

            this.comboBox3.DataSource = tec;
            this.comboBox3.DisplayMember = "nombre";
            this.comboBox3.ValueMember = "cod";

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


            CatalogoCliente cunitsbu = new CatalogoCliente();
            List<cliente> unibu = cunitsbu.getclierut();
            this.comboBox18.DataSource = unibu;
            this.comboBox18.DisplayMember = "nombre";
            this.comboBox18.ValueMember = "rut";

            CatalogoCliente cabu = new CatalogoCliente();
            List<cliente> labu = cabu.getclientcodfornom(comboBox18.Text);
            this.comboBox19.DataSource = labu;
            this.comboBox19.DisplayMember = "cod";

            this.comboBox19.ValueMember = "cod";


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

            this.button3.Visible = true;


        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
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

            List<int> codperio = new List<int>();

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
            List<Periodicidad> lu = ounits.getcodperiodi(textBox2.Text, dateTimePicker1.Text, textBox4.Text);
            this.comboBox17.DataSource = lu;
            this.comboBox17.DisplayMember = "cod";
            this.comboBox17.ValueMember = "cod";

            List<Periodicidad> lu2 = ounits.getcodperiodiEstado(textBox2.Text, dateTimePicker1.Text, textBox4.Text);
            this.comboBox14.DataSource = lu2;
            this.comboBox14.DisplayMember = "estado";
            this.comboBox14.ValueMember = "estado";


        }

        private void clienteBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == null && comboBox7==null || comboBox1.Text == "Esam Ltda.")
            {
                MessageBox.Show("Seleccione Un Cliente Valido");
            }else{
                if (MessageBox.Show("Desea Guardar la planificación?", "ATENCION",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                 == DialogResult.Yes)
                {
                    TableroPeriodicidad tab = new TableroPeriodicidad();
                    CatalogoPlanilla ca = new CatalogoPlanilla();
                    Planilla pla = new Planilla(Convert.ToString(comboBox4.SelectedValue), Convert.ToString(this.comboBox1.Text), textBox8.Text, Convert.ToInt32(this.comboBox7.Text), Convert.ToInt32(this.comboBox8.Text));
                    ca.addplanilla(pla);
                    button3.Visible = true;
                    MessageBox.Show("Ingreso Completado Se abrira el Tablero de Periodicidad");
                    tab.textBox1.Text = comboBox6.Text;
                    tab.textBox2.Text = textBox3.Text;
                    tab.MdiParent = Form1.ActiveForm;
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
            tab.MdiParent = Form1.ActiveForm;
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
            if (comboBox14.Text == "P")
            {
                MessageBox.Show("La visita ya contiene cambios en Planilla R");

            }
            else
            {
                if (comboBox155.Items.Count == 0 || comboBox12.Items.Count == 0)
                {
                    MessageBox.Show("Falta Ingreso de Servicio o Areas");

                }
                else
                {

                    CatalogoPlanilla ca = new CatalogoPlanilla();
                    Periodicidad pl = new Periodicidad(dateTimePicker1.Text, Convert.ToInt32(textBox4.Text), Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(comboBox3.SelectedValue), Convert.ToInt32(comboBox10.SelectedValue));


                    dateTimePicker1.Format = DateTimePickerFormat.Custom;

                    dateTimePicker1.CustomFormat = "yyyy-MM-dd";



                    comboBox17.Text = Convert.ToString(comboBox17.SelectedValue);
                    comboBox17.SelectedIndex = comboBox17.FindString(comboBox17.Text);
                    int aux = comboBox17.SelectedIndex;
                    int indexo = Convert.ToInt32(comboBox17.SelectedValue);
                    for (int i = comboBox17.Items.Count - 1; i >= 0; i--)
                    {


                        comboBox17.SelectedValue = indexo;

                        liststr.Add(indexo);
                        string borrar;
                        borrar = indexo.ToString();
                        ca.removePeriodidicad(borrar);
                        indexo++;

                    }




                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                    pl = new Periodicidad(dateTimePicker1.Text, Convert.ToInt32(textBox4.Text), Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(comboBox3.SelectedValue), Convert.ToInt32(comboBox10.SelectedValue));

                    int index = 0;
                    int index1 = 0;
                    for (int j = list.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list[index].ToString();
                        if (list12.Count != 0)
                        {
                            for (int i = list12.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                                dateTimePicker1.CustomFormat = "yyyy-MM-dd";

                                string b = "";
                                b = list12[index1].ToString();
                                pl = new Periodicidad(dateTimePicker1.Text, Convert.ToInt32(textBox4.Text), Convert.ToInt32(a), Convert.ToInt32(comboBox3.SelectedValue), Convert.ToInt32(b), "", 0, textBox6.Text, "P", "");
                                ca.addfecha(pl);

                                if (index1 < list12.Count - 1)
                                {

                                    index1++;
                                }
                                else
                                {
                                    index1 = index1;
                                }


                            }
                            index1 = 0;
                            index++;
                        }
                        else
                        {
                            pl = new Periodicidad(dateTimePicker1.Text, Convert.ToInt32(textBox4.Text), Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(comboBox3.SelectedValue), 30, "", 0, textBox6.Text, "P", "");

                            ca.addfecha(pl);


                        }
                    }

                    MessageBox.Show("Modificacion Realizada");
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "dd-MM-yyyy";
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

                comboBox18.Text = textBox12.Text;
                CatalogoPlanilla clp = new CatalogoPlanilla();

                lista = clp.mostrarplanillabuscar(textBox12.Text, dateTimePicker2.Text, dateTimePicker3.Text);
                this.dataGridView1.DataSource = lista;

                if (textBox12.Text == "")
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
                textBox12.Text = comboBox18.Text;
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                dateTimePicker3.Format = DateTimePickerFormat.Custom;
                dateTimePicker3.CustomFormat = "yyyy-MM-dd";

                lista = clp.mostrarplanillabuscar(comboBox18.Text, dateTimePicker2.Text, dateTimePicker3.Text);
                this.dataGridView1.DataSource = lista;

                if (textBox12.Text == "")
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
                int index1 = Convert.ToInt32(comboBox10.SelectedValue);
                comboBox10.SelectedValue = index1;
                comboBox155.Items.Add(comboBox10.Text);

                list12.Add(index1);
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

            this.comboBox18.ValueMember = "rut";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            List<Inventariado> lista = new List<Inventariado>();
            CatalogoPlanilla clp = new CatalogoPlanilla();
            textBox12.Text = comboBox18.Text;
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "yyyy-MM-dd";

            lista = clp.mostrarplanillabuscar(textBox12.Text, dateTimePicker2.Text, dateTimePicker3.Text);
            this.dataGridView1.DataSource = lista;



            if (textBox12.Text == "")
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
            textBox12.Text = comboBox18.Text;
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "yyyy-MM-dd";

            lista = clp.mostrarplanillabuscar(textBox12.Text, dateTimePicker2.Text, dateTimePicker3.Text);
            this.dataGridView1.DataSource = lista;

            if (textBox12.Text == "")
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
            textBox1.Text = comboBox13.Text;
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "yyyy-MM-dd";

            lista = clp.mostrarplanillabuscarporltratamiento(textBox1.Text, dateTimePicker2.Text, dateTimePicker3.Text);
            this.dataGridView1.DataSource = lista;

            if (textBox12.Text == "")
            {

                CatalogoPlanilla clpp = new CatalogoPlanilla();
                List<Inventariado> lista1 = new List<Inventariado>();

                lista1 = clpp.mostrarplanilla("");


            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            CatalogoPlanilla ca = new CatalogoPlanilla();
            int aux = comboBox17.SelectedIndex;
            int indexo = Convert.ToInt32(comboBox17.SelectedValue);
            for (int i = comboBox17.Items.Count - 1; i >= 0; i--)
            {
                comboBox17.SelectedValue = indexo;

                liststr.Add(indexo);

                Periodicidad at = new Periodicidad(this.textBox8.Text, Convert.ToInt32(textBox4.Text), indexo);
                ca.modiObsParticulares(at);
            }
            MessageBox.Show("Observacion Guardada");
            this.graData();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            CatalogoPlanilla ca = new CatalogoPlanilla();
            Planilla at = new Planilla(this.textBox5.Text, Convert.ToInt32(textBox4.Text));
            ca.modiObs(at);
            MessageBox.Show("Observacion Guardada");
            this.graData();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            comboBox18.Text = "";
            textBox12.Text = "";
            comboBox13.Text = "";
            textBox1.Text = "";
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

                MessageBox.Show("Se debe seleccionar el tipo de suspención");
                TipoDeSuspendido tr = new TipoDeSuspendido();
                tr.comboBox1.Text = dataGridView1.CurrentRow.Cells["Cod"].Value.ToString();
                CatalogoPlanilla ounits = new CatalogoPlanilla();
                List<Periodicidad> lu2 = ounits.getcodperiodiR(dateTimePicker1.Text, textBox4.Text);
                tr.comboBox2.DataSource = lu2;
                tr.comboBox2.DisplayMember = "cod";
                tr.comboBox2.ValueMember = "cod";
                tr.dateTimePicker1.Text = dateTimePicker3.Text;
                tr.Show();
            }
            else {

                MessageBox.Show("No hay datos seleccionados");
            }
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }





    }
      
    }

