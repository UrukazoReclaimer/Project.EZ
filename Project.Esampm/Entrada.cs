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
    public partial class Entrada : Form
    {
        
        public Entrada()
        {
            InitializeComponent();
           
        }

        private void Entrada_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           
            IngresarTecnico ingt = new IngresarTecnico();
          
         
            ingt.MdiParent = Form1.ActiveForm;
            ingt.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IngresarServicios ings = new IngresarServicios();
            ings.MdiParent = Form1.ActiveForm;
            ings.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PlanillaServicio pla = new PlanillaServicio(comboBox1.Text);
            pla.MdiParent = Form1.ActiveForm;
            pla.Show();
            pla.textBox3.Text = this.comboBox1.Text;
            /*
            Periodo pe = new Periodo();
            pe.MdiParent = Form1.ActiveForm;
            pe.Show();
             */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IngresarClientes ingc = new IngresarClientes();
            ingc.MdiParent = Form1.ActiveForm;
            ingc.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            IngresarVehiculo iv = new IngresarVehiculo();
            iv.MdiParent = Form1.ActiveForm;
            iv.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpcionInforme op = new OpcionInforme();
            op.MdiParent = Form1.ActiveForm;
            op.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            IngresarArea inga = new IngresarArea();
            inga.MdiParent = Form1.ActiveForm;
            inga.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PlanillaR plr = new PlanillaR(comboBox1.Text);
            plr.MdiParent = Form1.ActiveForm;
            plr.Show();
            plr.textBox2.Text = this.comboBox1.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Vacaciones v = new Vacaciones();
            v.MdiParent = Form1.ActiveForm;
            v.Show();
        }
    }
}
