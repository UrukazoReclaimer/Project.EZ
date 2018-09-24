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
    public partial class IngresarArea : Form
    {
        public IngresarArea()
        {
            InitializeComponent();
            CatalogoArea clp = new CatalogoArea();
            List<Area> lista = new List<Area>();

            lista = clp.mostrarArea("");
            this.dataGridView1.DataSource = lista;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            CatalogoArea ca = new CatalogoArea();
            Area are = new Area(this.textBox1.Text);
            ca.addArea(are);
            MessageBox.Show("Area Ingresada");
            graData();
      
           
        }
        public void graData()
        {
            CatalogoArea clp = new CatalogoArea();
            List<Area> lista = new List<Area>();


            lista = clp.mostrarArea("");
            this.dataGridView1.DataSource = lista;


        }
        private void IngresarArea_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CatalogoArea ca1 = new CatalogoArea();
            ca1.removeArea(textBox1.Text);
            MessageBox.Show("Area Eliminada");
            graData();
        }
    }
}
