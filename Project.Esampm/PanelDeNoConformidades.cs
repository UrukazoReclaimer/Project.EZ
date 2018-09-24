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
    public partial class PanelDeNoConformidades : Form
    {
        public PanelDeNoConformidades()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CatalogoPlanilla ca = new CatalogoPlanilla();
            Periodicidad at = new Periodicidad(this.textBox1.Text, this.textBox2.Text, Convert.ToInt32("1"));
            ca.modiNoconformidad(at);
            MessageBox.Show("No Conformidad Guardada");
            textBox2.Text = "";
            textBox1.Text = "";
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                CatalogoPlanilla ac = new CatalogoPlanilla();
                List<InventarioNoConformidad> lista = new List<InventarioNoConformidad>();
               
              
                lista = ac.mostrarNoConformidad(textBox2.Text);

                textBox1.Text = ac.mostrarNoConformidadString(textBox2.Text);
           

            }
        }
    }
}
