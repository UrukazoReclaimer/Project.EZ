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

            CatalogoCliente co = new CatalogoCliente();
            List<LugarTratamiento> lo = co.getLtracod(Convert.ToString(comboBox5.Text));
            this.comboBox6.DataSource = lo;
            this.comboBox6.DisplayMember = "cod";

            this.comboBox6.ValueMember = "cod";

           

          
            CatalogoContacto cc = new CatalogoContacto();
            Contacto con = new Contacto(Convert.ToInt32(comboBox6.Text), textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            cc.addContacto(con);
            Contacto con1 = new Contacto(Convert.ToInt32(comboBox6.Text),textBox8.Text, textBox7.Text, textBox6.Text, textBox5.Text);
            cc.addContacto(con1);

            MessageBox.Show("Registro de contacto realizado");
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TiposContacto_Load(object sender, EventArgs e)
        {

        }
    }
}
