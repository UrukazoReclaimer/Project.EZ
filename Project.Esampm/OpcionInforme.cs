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
    public partial class OpcionInforme : Form
    {
        public OpcionInforme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InformePlanificados inf = new InformePlanificados();
            inf.MdiParent = Principal.ActiveForm;
            inf.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Informe inf = new Informe();
            inf.MdiParent = Principal.ActiveForm;
            inf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InformeLugaresSinPlanificacion inf = new InformeLugaresSinPlanificacion();
            inf.MdiParent = Principal.ActiveForm;
            inf.Show(); ;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InformeServiciosPlanificados inf = new InformeServiciosPlanificados();
            inf.MdiParent = Principal.ActiveForm;
            inf.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            InformeServicioReplanificados infr = new InformeServicioReplanificados();
            infr.MdiParent = Principal.ActiveForm;
            infr.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            InformeServicioRealizados infr = new InformeServicioRealizados();
            infr.MdiParent = Principal.ActiveForm;
            infr.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            InformeServicioNoRealizados infnore = new InformeServicioNoRealizados();
            infnore.MdiParent = Principal.ActiveForm;
            infnore.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            InformeServicioSupendido infs = new InformeServicioSupendido();
            infs.MdiParent = Principal.ActiveForm;
            infs.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Graficos gr = new Graficos();
            gr.MdiParent = Principal.ActiveForm;
            gr.textBox1.Text = textBox1.Text;
            gr.Show();
        }

        private void OpcionInforme_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
          InformeSModificados gr = new InformeSModificados();
            gr.MdiParent = Principal.ActiveForm;
            gr.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            InformeDescripciones gr = new InformeDescripciones();
            gr.MdiParent = Principal.ActiveForm;
            gr.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            BonodeRendimiento gr = new BonodeRendimiento();
            gr.MdiParent = Principal.ActiveForm;
            gr.Show();
        }
    }
}
