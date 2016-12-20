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
    public partial class IngresarVehiculo : Form
    {
        public IngresarVehiculo()
        {
            InitializeComponent();



            CatalogoVehiculo clp = new CatalogoVehiculo();
            List<vehiculo> lista = new List<vehiculo>();

            lista = clp.mostrarvehiculo("");
            this.dataGridView1.DataSource = lista;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CatalogoVehiculo cv = new CatalogoVehiculo();

            vehiculo v = new vehiculo(textBox2.Text, textBox1.Text);
            cv.addvehiculo(v);
            this.graData();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            textBox1.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["Patente"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CatalogoVehiculo ca = new CatalogoVehiculo();
            ca.removeVehiculo(this.textBox2.Text);
            this.graData();
        }



        public void graData()
        {
            CatalogoVehiculo ac = new CatalogoVehiculo();
            List<vehiculo> lista = new List<vehiculo>();

            lista = ac.mostrarvehiculo("");
            this.dataGridView1.DataSource = lista;



        }

        private void IngresarVehiculo_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox1.Clear();
        }
    }
}
