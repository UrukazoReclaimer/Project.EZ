using Project.BussinessRules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Esampm
{
    public partial class Principal : Form
    {
       
        public Principal()
        {
            InitializeComponent();
            CatalogoVehiculo clp = new CatalogoVehiculo();
            List<vehiculo> lista = new List<vehiculo>();

            lista = clp.mostrarvehiculoRevTec("");
            this.dataGridView1.DataSource = lista;
            if (lista.Count > 0) 
            {
                label4.Visible = true;
                dataGridView1.Visible = true;
            
            }
            CatalogoVehiculo clp2 = new CatalogoVehiculo();
            List<vehiculo> lista2 = new List<vehiculo>();

            lista2 = clp2.mostrarvehiculoExtintores("");
            this.dataGridView2.DataSource = lista2;
            if (lista2.Count > 0)
            {
                label5.Visible = true;
                dataGridView2.Visible = true;

            }
          
        }

        public Entrada Accede
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        ///  Evento en el boton para ingresar al formulario de menu principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            /*
            pictureBox2.Visible = false;
            Entrada f = new Entrada();
            //al hacer click en el boton desaparece el label
            label1.Visible = false;
            f.MdiParent = this;
            f.Show();

            */
            pictureBox2.Visible = false;
           Portal f = new Portal();
            //al hacer click en el boton desaparece el label
            label1.Visible = false;
            label2.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            DateTime fechaHoy = DateTime.Now;
            f.textBox3.Text = fechaHoy.Year.ToString();
            f.MdiParent = this;

            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = Convert.ToString(DateTime.Now);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    

    }
}
