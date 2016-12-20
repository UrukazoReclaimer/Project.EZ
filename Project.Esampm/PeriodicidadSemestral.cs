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
    public partial class PeriodicidadSemestral : Form
    {
        Boolean registro = false;
        List<int> list = new List<int>();
        List<int> list1 = new List<int>();

        List<int> lista = new List<int>();
        List<int> lista1 = new List<int>();
        public PeriodicidadSemestral()
        {
            InitializeComponent();
            catalogoTecnico tunits = new catalogoTecnico();
            List<Project.BussinessRules.Tecnico> tec = tunits.gettec();
            List<Project.BussinessRules.Tecnico> tec1 = tunits.gettec();
            this.comboBox2.DataSource = tec;
            this.comboBox2.DisplayMember = "nombre";
            this.comboBox2.ValueMember = "cod";
            this.comboBox3.DataSource = tec1;
            this.comboBox3.DisplayMember = "nombre";
            this.comboBox3.ValueMember = "cod";

            CatalogoServicios sunits = new CatalogoServicios();
            List<Project.BussinessRules.servicio> ser = sunits.getser();
            List<Project.BussinessRules.servicio> ser1 = sunits.getser();
            this.comboBox4.DataSource = ser;
            this.comboBox4.DisplayMember = "sigla";
            this.comboBox4.ValueMember = "cod";
            this.comboBox5.DataSource = ser1;
            this.comboBox5.DisplayMember = "sigla";
            this.comboBox5.ValueMember = "cod";

            CatalogoArea aunits = new CatalogoArea();
            List<Area> are = aunits.getarea();
            List<Area> are1 = aunits.getarea();

            this.comboBox7.DataSource = are;
            this.comboBox7.DisplayMember = "NombreArea";
            this.comboBox7.ValueMember = "cod";
            this.comboBox10.DataSource = are1;
            this.comboBox10.DisplayMember = "NombreArea";
            this.comboBox10.ValueMember = "cod";

            registro = true;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
         
        }

        private void button1_Click(object sender, EventArgs e)
        {

         

            RegistrarServicios rs = new RegistrarServicios();
            rs.Show();

            this.graData();

        

        }

        private void button2_Click(object sender, EventArgs e)
        {
           

            RegistrarServicios rs = new RegistrarServicios();
            rs.Show();

            this.graData();


        }

        private void PeriodicidadSemestral_Load(object sender, EventArgs e)
        {

        }

        public void graData()
        {
            PlanillaServicio p = new PlanillaServicio("");
            CatalogoPlanilla ac = new CatalogoPlanilla();
            List<Inventariado> lista = new List<Inventariado>();

            lista = ac.mostrarplanilla("");
            p.dataGridView1.DataSource = lista;



        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (dateTimePicker1.Value.Date <= DateTime.Now || dateTimePicker2.Value.Date <= DateTime.Now)
            {
                MessageBox.Show("No se puede guardar fechas anteriores a la fecha actual");


            }
            else
            {
             
            
                if (MessageBox.Show("Verifico la fechas a guadar?", "ATENCION",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                  == DialogResult.Yes)
                {





                    CatalogoPlanilla ca = new CatalogoPlanilla();
                    List<Periodicidad> lu = ca.getcodfech();
                    this.comboBox1.DataSource = lu;
                    this.comboBox1.DisplayMember = "lugartratamiento";

                    this.comboBox1.ValueMember = "cod";




                    listBox1.Text = Convert.ToString(listBox1.SelectedValue);
                    listBox1.SelectedIndex = listBox1.FindString(listBox1.Text);

                    int index = 0;
                    int index1 = 0;

                    index = 0;
                    index1 = 0;
                    for (int j = list1.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list1[index].ToString();
                        if (lista1.Count != 0)
                        {
                            for (int i = lista1.Count - 1; i >= 0; i--)
                            {

                                dateTimePicker2.Format = DateTimePickerFormat.Custom;

                                dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista1[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker2.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox3.SelectedValue), Convert.ToInt32(b), "", 0, "ST", "P", "");
                                ca.addfecha(pla);

                                if (index1 < lista1.Count - 1)
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
                            dateTimePicker2.Format = DateTimePickerFormat.Custom;

                            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker2.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox3.SelectedValue), 30, "", 0, "ST", "P", "");
                            ca.addfecha(pla);
                        }
                    }

                    index = 0;
                    index1 = 0;

                    for (int j = list.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list[index].ToString();
                        if (lista.Count != 0)
                        {
                            for (int i = lista.Count - 1; i >= 0; i--)
                            {

                                dateTimePicker1.Format = DateTimePickerFormat.Custom;

                                dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker1.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(b), "", 0, "ST", "P", "");
                                ca.addfecha(pla);

                                if (index1 < lista.Count - 1)
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
                            dateTimePicker1.Format = DateTimePickerFormat.Custom;

                            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker1.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox2.SelectedValue), 30, "", 0, "ST", "P", "");
                            ca.addfecha(pla);
                        }
                    }
                    index = 0;
                    index1 = 0;




                    MessageBox.Show("Ingreso Completado");
                }
                this.Close();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox4.SelectedValue);
                comboBox4.SelectedValue = index;


                comboBox6.Items.Add(comboBox4.Text);
               
                list.Add(index);
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox5.SelectedValue);
                comboBox5.SelectedValue = index;


                comboBox9.Items.Add(comboBox5.Text);
              
                list1.Add(index);
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox7.SelectedValue);
                comboBox7.SelectedValue = index;


                comboBox8.Items.Add(comboBox7.Text);
               
                lista.Add(index);
            }
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox10.SelectedValue);
                comboBox10.SelectedValue = index;


                comboBox11.Items.Add(comboBox10.Text);
                
                lista1.Add(index);
            }
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
