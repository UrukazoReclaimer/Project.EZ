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
    public partial class LDD : Form
    {
        List<string> listfecha = new List<string>();
        public LDD()
        {
            InitializeComponent();
            catalogoTecnico tunits = new catalogoTecnico();
            List<Project.BussinessRules.Tecnico> tec = tunits.obtenertec();
            this.comboBox1.DataSource = tec;
            this.comboBox1.DisplayMember = "nombre";
            this.comboBox1.ValueMember = "cod";
        }

        private void button1_Click(object sender, EventArgs e)
        {

          




            if (MessageBox.Show("¿Verificó la fechas a guardar?", "ATENCIÓN",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            == DialogResult.Yes)
            {

                planificar(comboBox1);

                MessageBox.Show("Ingreso Completado");
                this.Close();

            }
        }
        public void planificar(ComboBox tec)
        {
            
            CatalogoPlanilla ca2 = new CatalogoPlanilla();
            List<Periodicidad> lu = ca2.getcodfech();
            this.comboBox15.DataSource = lu;
            this.comboBox15.DisplayMember = "lugartratamiento";

            this.comboBox15.ValueMember = "cod";
            //AQUIIIIIII
            CatalogoPlanilla ca = new CatalogoPlanilla();
            // List<Periodicidad> lu = ca.getcodfech();
            int index1 = 0;
            for (int i = listfecha.Count - 1; i >= 0; i--)
            {
                //  fecha.Format = DateTimePickerFormat.Custom;

                // fecha.CustomFormat = "yyyy-MM-dd";
                string b = "";
                b = listfecha[index1].ToString();
                Periodicidad pla = new Periodicidad(b, Convert.ToInt32(comboBox15.SelectedValue), 10, Convert.ToInt32(comboBox1.SelectedValue), "N/A", "", 0, "LDD", "P", "", "Primario", "", "");
                ca.addfecha(pla);

                if (index1 < listfecha.Count - 1)
                {

                    index1++;
                }
                else
                {
                    index1 = index1;
                }

            }
             

        }
        private void LDD_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

            listfecha.Add(monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd"));
            comboBox3.Items.Add(monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd"));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox3.Items.Remove(textBox1.Text);
            listfecha.Remove(textBox1.Text);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox3.Text;
        }
    }
}
