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
    public partial class Replanificar : Form
    {
        Boolean registro = false;
        List<int> list = new List<int>();
        List<int> lista = new List<int>();
        public Replanificar()
        {
            InitializeComponent();
            catalogoTecnico tunits = new catalogoTecnico();
            List<Project.BussinessRules.Tecnico> tec = tunits.gettec();         
            this.comboBox1.DataSource = tec;
            this.comboBox1.DisplayMember = "nombre";
            this.comboBox1.ValueMember = "cod";
            CatalogoServicios sunits = new CatalogoServicios();
            List<Project.BussinessRules.servicio> ser = sunits.getser();
            this.comboBox4.DataSource = ser;
            this.comboBox4.DisplayMember = "sigla";
            this.comboBox4.ValueMember = "cod";
            CatalogoArea aunits = new CatalogoArea();
            List<Area> are = aunits.getarea();
            this.comboBox5.DataSource = are;
            this.comboBox5.DisplayMember = "NombreArea";
            this.comboBox5.ValueMember = "cod";

            registro = true;
        }


        public void graData()
        {
            CatalogoPlanilla clp = new CatalogoPlanilla();
            List<InventariadoR> lista = new List<InventariadoR>();
            PlanillaR plr = new PlanillaR("");
            lista = clp.mostrarplanillaR("");
            plr.dataGridView1.DataSource = lista;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Verifico la fechas a guadar?", "ATENCION",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question)
              == DialogResult.Yes)
            {
                CatalogoPlanilla ca = new CatalogoPlanilla();

                int index = 0;
                int index1 = 0;

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
                            // Display the date as "Mon 26 Feb 2001".
                            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                            string b = "";
                            b = lista[index1].ToString();
                            Periodicidad pla = new Periodicidad(dateTimePicker1.Text, Convert.ToInt32(comboBox8.Text), Convert.ToInt32(a), Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(b), "", 0, textBox1.Text, "P", "");
                            ca.addfecha(pla);
                            //cambair que vuela el codigo de la planilla
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
                        // Display the date as "Mon 26 Feb 2001".
                        dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                        Periodicidad pla = new Periodicidad(dateTimePicker1.Text, Convert.ToInt32(comboBox8.Text), Convert.ToInt32(a), Convert.ToInt32(comboBox1.SelectedValue), 30, "", 0, textBox1.Text, "P", "");
                        ca.addfecha(pla);
                    }
                }
                index = 0;
                index1 = 0;
            }



            MessageBox.Show("Replanificacion Guardada");
            this.Close();
            graData();
        
    }

        private void Replanificar_Load(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox4.SelectedValue);
                comboBox4.SelectedValue = index;


                comboBox6.Items.Add(comboBox4.Text);
                //comboBox4.Items.Add(index);
                list.Add(index);
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox5.SelectedValue);
                comboBox5.SelectedValue = index;


                comboBox7.Items.Add(comboBox5.Text);
                //comboBox4.Items.Add(index);
                lista.Add(index);
            }
        }
    }
}
