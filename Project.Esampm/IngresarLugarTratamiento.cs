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
    public partial class IngresarLugarTratamiento : Form
    {
        public IngresarLugarTratamiento()
        {
            InitializeComponent();
            CatalogoCliente cunits = new CatalogoCliente();
            List<Project.BussinessRules.cliente> units = cunits.getclie();
            this.comboBox1.DataSource = units;
            this.comboBox1.DisplayMember = "nombre";
            this.comboBox1.ValueMember = "rut";

            CatalogoCliente ounits = new CatalogoCliente();
            List<cliente> lu = ounits.getclientcod(Convert.ToString(comboBox1.SelectedValue));
            this.comboBox2.DataSource = lu;
            this.comboBox2.DisplayMember = "cod";
            //cambie el value
            this.comboBox1.ValueMember = "cod";
        }

        private void IngresarLugarTratamiento_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CatalogoCliente ca = new CatalogoCliente();
            LugarTratamiento cli = new LugarTratamiento(Convert.ToInt32(comboBox2.Text),Convert.ToString(this.comboBox1.SelectedValue),this.comboBox5.Text,comboBox6.Text, this.comboBox3.Text);
            ca.addLugar(cli);

            CatalogoCliente co = new CatalogoCliente();
            List<LugarTratamiento> lo = ca.getLtracod(Convert.ToString(comboBox5.Text));
            this.comboBox4.DataSource = lo;
            this.comboBox4.DisplayMember = "cod";
            //cambie el value
            this.comboBox4.ValueMember = "cod";

            //---------------------------contacto

            CatalogoContacto cc = new CatalogoContacto();
            Contacto con = new Contacto(Convert.ToInt32(comboBox4.Text), textBox2.Text, textBox3.Text, textBox4.Text, comboBox3.Text);
            cc.addContacto(con);

            //----------------------------plano
            CatalogoPlanocs cp = new CatalogoPlanocs();
            //debe ser cod,codcli,nombre
            Plano pl = new Plano(textBox5.Text, Convert.ToInt32(comboBox4.Text), Convert.ToInt32(textBox5.Text));
            cp.addplano(pl);
            MessageBox.Show("Ingreso Valido");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            CatalogoCliente ounits = new CatalogoCliente();
            List<cliente> lu = ounits.getclientcod(Convert.ToString(comboBox1.SelectedValue));
            this.comboBox2.DataSource = lu;
            this.comboBox2.DisplayMember = "cod";
            //cambie el value
            this.comboBox1.ValueMember = "rut";
             
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            CatalogoPlanocs cp = new CatalogoPlanocs();
            //debe ser cod,codcli,nombre
            Plano pl = new Plano(textBox5.Text, Convert.ToInt32(comboBox4.Text), Convert.ToInt32(textBox5.Text));
            cp.addplano(pl);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            TiposContacto tip = new TiposContacto();
         


            tip.comboBox1.Text = comboBox5.Text;
            tip.comboBox2.Text = comboBox5.Text;

   
            tip.Show();
        }
    }
}
