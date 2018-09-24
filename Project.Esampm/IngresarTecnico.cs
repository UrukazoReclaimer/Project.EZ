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
using System.Text.RegularExpressions;

namespace Project.Esampm
{
    public partial class IngresarTecnico : Form 
    {
        public IngresarTecnico()
        {
            InitializeComponent();

            catalogoTecnico tunits = new catalogoTecnico();
            List<Project.BussinessRules.Tecnico> tec = tunits.obtenertec();

            this.comboBox2.DataSource = tec;
            this.comboBox2.DisplayMember = "nombre";
            this.comboBox2.ValueMember = "cod";

            catalogoTecnico clp = new catalogoTecnico();
            List<Tecnico> lista = new List<Tecnico>();

            lista = clp.mostrarTec("");
            this.dataGridView1.DataSource = lista;
        }
        public bool validarRut(string rut)
        {

            bool validacion = false;
            try
            {
                rut = rut.ToUpper();
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));

                char dv = char.Parse(rut.Substring(rut.Length - 1, 1));

                int m = 0, s = 1;
                for (; rutAux != 0; rutAux /= 10)
                {
                    s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
                }
                if (dv == (char)(s != 0 ? s + 47 : 75))
                {
                    validacion = true;
                }
            }
            catch (Exception)
            {
            }
            return validacion;
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            catalogoTecnico ca1 = new catalogoTecnico();
            List<Tecnico> la = ca1.gettecrutcondition(textBox1.Text);
            this.comboBox2.DataSource = la;
            this.comboBox2.DisplayMember = "cod";

            this.comboBox2.ValueMember = "cod";

            if (comboBox2.Items.Count >= 1)
            {

                MessageBox.Show("Tecnico Existente");

            }
            else
            {
                validarRut(textBox1.Text);
                if (validarRut(textBox1.Text) == true)
                {
                    MessageBox.Show("Ingreso Valido");
                    this.textBox1.Focus();
                    catalogoTecnico ca = new catalogoTecnico();
                    Tecnico tec = new Tecnico(this.textBox1.Text, this.textBox2.Text, this.comboBox1.Text);
                    ca.addTecnico(tec);

                    textBox1.Text = "";
                    textBox2.Text = "";



                }
                else
                {

                    MessageBox.Show("Teclee un dato valido", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.graData();
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

             textBox1.Text = dataGridView1.CurrentRow.Cells["Rut"].Value.ToString();
             textBox2.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells["Estado"].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells["Cod"].Value.ToString();
            textBox4.Enabled=false;
        }

        private void IngresarTecnico_Load(object sender, EventArgs e)
        {
            
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            catalogoTecnico ac = new catalogoTecnico();
            ac.removeTecnico(this.textBox1.Text);
            this.graData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            catalogoTecnico ca = new catalogoTecnico();
            Tecnico at = new Tecnico(int.Parse(this.textBox4.Text), this.textBox1.Text, this.textBox2.Text,this.comboBox1.Text);
            ca.modiTec(at);
            MessageBox.Show("Registro Modificado");
            this.graData();
        }
        public void graData()
        {
            catalogoTecnico ac = new catalogoTecnico();
            List<Tecnico> lista = new List<Tecnico>();

            lista = ac.mostrarTec("");
            this.dataGridView1.DataSource = lista;



        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            comboBox1.Text = "" ;
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox4.Enabled = true;
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            catalogoTecnico ca = new catalogoTecnico();
            List<Tecnico> la = ca.gettecrutcondition(textBox1.Text);
            this.comboBox2.DataSource = la;
            this.comboBox2.DisplayMember = "cod";

            this.comboBox2.ValueMember = "cod";

            if (comboBox2.Items.Count >= 1)
            {

                MessageBox.Show("Tecnico Existente");

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
