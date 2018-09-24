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
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            CatalogoVehiculo cv = new CatalogoVehiculo();

            vehiculo v = new vehiculo(textBox2.Text, textBox1.Text,dateTimePicker1.Text, Convert.ToInt32(textBox4.Text),dateTimePicker2.Text);
            cv.addvehiculo(v);
            MessageBox.Show("Registro Completado");
            this.graData();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            textBox1.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["Patente"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["Vencimiento_Rev_Tecnica"].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells["Km_Cambio_Aceite"].Value.ToString();
            dateTimePicker2.Text = dataGridView1.CurrentRow.Cells["Vencimiento_Extintores"].Value.ToString();
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

        private void button4_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            vehiculo vt = new vehiculo(textBox2.Text, textBox1.Text, dateTimePicker1.Text, Convert.ToInt32(textBox4.Text),dateTimePicker2.Text);
            CatalogoVehiculo ca = new CatalogoVehiculo();
            ca.modVehiculo(vt);
            this.graData();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
