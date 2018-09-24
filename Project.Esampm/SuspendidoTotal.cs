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
   
    public partial class SuspendidoTotal : Form
    {
        List<int> list = new List<int>();
        List<int> listperio = new List<int>();
        public SuspendidoTotal()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";

            CatalogoPlanilla cat = new CatalogoPlanilla();
        
            int aux = comboBox1.SelectedIndex;
            int indexo = Convert.ToInt32(comboBox2.Text);
            for (int i = comboBox2.Items.Count - 1; i >= 0; i--)
            {


                comboBox2.SelectedValue = indexo;
           
                list.Add(indexo);
              
               
            }
            int indexborrar = 0;
            for (int i = comboBox2.Items.Count - 1; i >= 0; i--)
            {
               
                string b = "";
                b = list[indexborrar].ToString();
                Periodicidad p = new Periodicidad(dateTimePicker1.Text, Convert.ToInt32(b),textBox2.Text);
                servicio s = new servicio(textBox2.Text);
                cat.borrarSuspen(p);
                indexborrar++;
            }
            CatalogoNota not = new CatalogoNota();
            int index1 = 0;
            int index = 0;
            string a = "";


            int indexo2 = Convert.ToInt32(comboBox1.Text);
            for (int i = comboBox1.Items.Count - 1; i >= 0; i--)
            {


                comboBox1.SelectedValue = indexo2;

                listperio.Add(indexo2);
                indexo2++;

            }

            for (int i = comboBox1.Items.Count - 1; i >= 0; i--)
            {
                a = "";
                a = listperio[index].ToString();
               
                Nota n = new Nota(a, textBox1.Text, "Empresa---");
               
                not.addNota(n);
                if (index1 < comboBox1.Items.Count - 1)
                {

                    index1++;
                    index++;
                }
                else
                {
                    index1 = index1;
                }

            }
            MessageBox.Show("Descripción Guardada");
            this.Close();
        }

        private void SuspendidoTotal_Load(object sender, EventArgs e)
        {

           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";

            CatalogoPlanilla cat = new CatalogoPlanilla();

            int aux = comboBox1.SelectedIndex;
            int indexo = Convert.ToInt32(comboBox2.Text);
            for (int i = comboBox2.Items.Count - 1; i >= 0; i--)
            {


                comboBox2.SelectedValue = indexo;

                list.Add(indexo);


            }
            int indexborrar = 0;
            for (int i = comboBox2.Items.Count - 1; i >= 0; i--)
            {

                string b = "";
                b = list[indexborrar].ToString();
                Periodicidad p = new Periodicidad(dateTimePicker1.Text, Convert.ToInt32(b), textBox2.Text);
                servicio s = new servicio(textBox2.Text);
                cat.borrarSuspen(p);
                indexborrar++;
            }
            CatalogoNota not = new CatalogoNota();
            int index1 = 0;
            int index = 0;
            string a = "";


            int indexo2 = Convert.ToInt32(comboBox1.Text);
            for (int i = comboBox1.Items.Count - 1; i >= 0; i--)
            {


                comboBox1.SelectedValue = indexo2;

                listperio.Add(indexo2);
                indexo2++;

            }

            for (int i = comboBox1.Items.Count - 1; i >= 0; i--)
            {
                a = "";
                a = listperio[index].ToString();

                Nota n = new Nota(a, textBox1.Text, "Cliente---");

                not.addNota(n);
                if (index1 < comboBox1.Items.Count - 1)
                {

                    index1++;
                    index++;
                }
                else
                {
                    index1 = index1;
                }

            }
            MessageBox.Show("Descripción Guardada");
            this.Close();
        }
    }
}
