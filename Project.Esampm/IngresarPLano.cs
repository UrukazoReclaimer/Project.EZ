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
    public partial class IngresarPLano : Form
    {

        int cont;
        public IngresarPLano()
        {
            InitializeComponent();

  
            CatalogoCliente cunits = new CatalogoCliente();
            List<Project.BussinessRules.cliente> units = cunits.getclie();
            this.comboBox2.DataSource = units;
            this.comboBox2.DisplayMember = "nombre";
            this.comboBox2.ValueMember = "rut";

            

/*
            CatalogoCliente ca = new CatalogoCliente();
            List<LugarTratamiento> la = ca.getLtracod(Convert.ToString(comboBox3.SelectedValue));
            this.comboBox1.DataSource = la;
            this.comboBox1.DisplayMember = "cod";
            //cambie el value
            this.comboBox1.ValueMember = "cod";
*/
            
/*
            CatalogoCliente ounits = new CatalogoCliente();
            List<cliente> lu = ounits.getclientcod(Convert.ToString(comboBox2.SelectedValue));
            this.comboBox1.DataSource = lu;
            this.comboBox1.DisplayMember = "cod";
            //cambie el value
            this.comboBox2.ValueMember = "cod";
 */
        }
            
        private void IngresarPLano_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CatalogoPlanocs cp = new CatalogoPlanocs();
            //debe ser cod,codcli,nombre
           Plano pl = new Plano(textBox1.Text,Convert.ToInt32(comboBox1.Text), Convert.ToInt32(textBox1.Text));
           cp.addplano(pl);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            CatalogoCliente munits = new CatalogoCliente();
            List<LugarTratamiento> pu = munits.getlugar(Convert.ToString(comboBox2.SelectedValue));
            this.comboBox3.DataSource = pu;
            this.comboBox3.DisplayMember = "nombre";
            //cambie el value
            this.comboBox2.ValueMember = "rut";







        
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            CatalogoCliente ca = new CatalogoCliente();
            List<LugarTratamiento> la = ca.getLtracod(Convert.ToString(comboBox3.Text));
            this.comboBox1.DataSource = la;
            this.comboBox1.DisplayMember = "cod";
            //cambie el value
            this.comboBox1.ValueMember = "cod";
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
    }
}
