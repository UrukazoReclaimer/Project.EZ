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
    public partial class PeriodicidadAnual : Form
    {
        Boolean registro = false;
        Boolean registroArea = false;
        List<int> list = new List<int>();
        List<int> list1 = new List<int>();
        public PeriodicidadAnual()
        {


            InitializeComponent();
            catalogoTecnico tunits = new catalogoTecnico();
            List<Project.BussinessRules.Tecnico> tec = tunits.gettec();
        
            this.comboBox2.DataSource = tec;
            this.comboBox2.DisplayMember = "nombre";
            this.comboBox2.ValueMember = "cod";
          
            CatalogoServicios sunits = new CatalogoServicios();
            List<Project.BussinessRules.servicio> ser = sunits.getser();
        
            this.comboBox3.DataSource = ser;
            this.comboBox3.DisplayMember = "sigla";
            this.comboBox3.ValueMember = "cod";

            CatalogoArea aunits = new CatalogoArea();
            List<Area> are = aunits.getarea();
            this.comboBox5.DataSource = are;
            this.comboBox5.DisplayMember = "NombreArea";
            this.comboBox5.ValueMember = "cod";
            registro = true;
            registroArea = true;
        

        }

        private void PeriodicidadAnual_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
           
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
             if (dateTimePicker1.Value.Date <= DateTime.Now)
            {
                MessageBox.Show("No se puede guardar fechas anteriores a la fecha actual");


            }
            else
            {
             
             
                if (MessageBox.Show("Desa Guardar Periodicidad Anual en la Fecha:" + dateTimePicker1.Text + "?", "ATENCION",
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
             //       this.graData();
                    int index = 0;
                    int index1 = 0;

                    for (int j = list.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list[index].ToString();
                        if (list1.Count != 0)
                        {
                            for (int i = list1.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                               
                                dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = list1[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker1.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(b), "", 0, "A", "P", "");
                                ca.addfecha(pla);
                             
                                if (index1 < list1.Count - 1)
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
                            Periodicidad pla = new Periodicidad(dateTimePicker1.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox2.SelectedValue), 30, "", 0, "A", "P", "");
                            ca.addfecha(pla);


                        }
                    }

                    MessageBox.Show("Ingreso Completado");
                }
                this.Close();
             
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        /*
        public void graData()
        {
            PlanillaServicio p = new PlanillaServicio("");
            CatalogoPlanilla ac = new CatalogoPlanilla();
            List<Inventariado> lista = new List<Inventariado>();

            lista = ac.buscarplanilla("");
            p.dataGridView1.DataSource= lista;



        }
         */

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox3.SelectedValue);
                comboBox3.SelectedValue = index;


                comboBox4.Items.Add(comboBox3.Text);
               
                list.Add(index);
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registroArea == true)
            {

                int index1 = Convert.ToInt32(comboBox5.SelectedValue);
                comboBox5.SelectedValue = index1;


                comboBox6.Items.Add(comboBox5.Text);
               
                list1.Add(index1);
            }
        }
    }
}
