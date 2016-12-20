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

        private void button1_Click(object sender, EventArgs e)
        {
            CatalogoArea ca = new CatalogoArea();
            Area are = new Area(this.textBox1.Text);
            ca.addArea(are);
            MessageBox.Show("Area Ingresada");
      
           
        }

        private void IngresarArea_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
