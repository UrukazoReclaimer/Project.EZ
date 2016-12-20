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
    public partial class IngresarServicios : Form
    {
        public IngresarServicios()
        {
            InitializeComponent();

            CatalogoServicios clp = new CatalogoServicios();
            List<servicio> lista = new List<servicio>();

            lista = clp.mostrarservicio("");
            this.dataGridView1.DataSource = lista;

 

            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void IngresarServicios_Load(object sender, EventArgs e)
        {
          
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CatalogoServicios ca = new CatalogoServicios();
            servicio tec = new servicio(this.textBox1.Text,this.textBox3.Text);
            ca.addServicio(tec);
            this.graData();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
           CatalogoServicios ac = new CatalogoServicios();
            ac.removeServico(this.textBox1.Text);
   
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            IngresarTecnico ing = new IngresarTecnico();
            ing.Show();
        }
        public void graData()
        {
            CatalogoServicios ac = new CatalogoServicios();
            List<servicio> lista = new List<servicio>();

            lista = ac.bmostrarservicio("");
            this.dataGridView1.DataSource = lista;



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
