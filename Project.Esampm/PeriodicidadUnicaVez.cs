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
    public partial class PeriodicidadUnicaVez : Form
    {
        Boolean registro = false;
        Boolean registroArea = false;
        List<int> list = new List<int>();
        List<string> list1 = new List<string>();
        public PeriodicidadUnicaVez()
        {
            InitializeComponent();
            catalogoTecnico tunits = new catalogoTecnico();
            List<Project.BussinessRules.Tecnico> tec = tunits.obtenertec();

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

        private void PeriodicidadUnicaVez_Load(object sender, EventArgs e)
        {


            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            DateTime fecha = DateTime.Now.Date;
            int day = fecha.Day;
            int month = fecha.Month;
            int year = Convert.ToInt32(textBox2.Text);
            dateTimePicker1.Value = new DateTime(year, month, day);



        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            /*
            if (dateTimePicker1.Value.Date <= DateTime.Now)
            {
                MessageBox.Show("No se puede guardar fechas anteriores a la fecha actual");


            }
            else
            {
             */
             

            if (MessageBox.Show("¿Verificó la fechas a guardar?", "ATENCIÓN",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            == DialogResult.Yes)
            {

                planificar(list, list1, comboBox1, dateTimePicker1, comboBox2);
           //     planificar(list, list1, comboBox1, dateTimePicker1, comboBox7);
                MessageBox.Show("Ingreso Completado");
                this.Close();
               // }
            }
             
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

                if (comboBox6.Text == "Seleccionados")
                {
                    comboBox6.Text = "";

                }
                comboBox6.Text = comboBox5.Text;

                string b = comboBox6.Text;
                comboBox6.Items.Add(comboBox5.Text);

                list1.Add(comboBox6.Text);
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void planificar(List<int> listser, List<string> listarea, ComboBox c1, DateTimePicker fecha, ComboBox tec)
        {
            
            CatalogoPlanilla ca = new CatalogoPlanilla();
            List<Periodicidad> lu = ca.getcodfech();
            c1.DataSource = lu;
            c1.DisplayMember = "lugartratamiento";

            c1.ValueMember = "cod";


            listBox1.Text = Convert.ToString(listBox1.SelectedValue);
            listBox1.SelectedIndex = listBox1.FindString(listBox1.Text);

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
                        b = string.Join(",", list1.ToArray());
                        Periodicidad pla = new Periodicidad(fecha.Text, Convert.ToInt32(c1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(tec.SelectedValue),b, "", 0, "U", "P", "", "Primario", "", "");
                        ca.addfecha(pla);
                           
                    index++;
                }
                else
                {
                    fecha.Format = DateTimePickerFormat.Custom;

                    fecha.CustomFormat = "yyyy-MM-dd";
                    Periodicidad pla = new Periodicidad(fecha.Text, Convert.ToInt32(c1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(tec.SelectedValue), "N/A", "", 0, "U", "P", "", "Primario", "", "");
                    ca.addfecha(pla);
                    
                    index++;

                }
            }
            index = 0;
           
             
             
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
