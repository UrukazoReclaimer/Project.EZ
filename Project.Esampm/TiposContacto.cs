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
    public partial class TiposContacto : Form
    {
        public TiposContacto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        

           

          
            CatalogoContacto cc = new CatalogoContacto();
            Contactocliente con = new Contactocliente(Convert.ToInt32(comboBox3.Text),comboBox4.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            cc.addContactocliente(con);
            Contactocliente con1 = new Contactocliente(Convert.ToInt32(comboBox3.Text),comboBox4.Text, textBox8.Text, textBox7.Text, textBox6.Text, textBox5.Text);
            cc.addContactocliente(con1);

            MessageBox.Show("Registro de contacto realizado");
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
