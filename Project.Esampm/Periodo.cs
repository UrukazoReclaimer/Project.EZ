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
    public partial class Periodo : Form
    {
        public Periodo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlanillaServicio pl = new PlanillaServicio(comboBox1.Text);

            pl.MdiParent = Principal.ActiveForm;
            pl.Show();
            pl.textBox3.Text = this.comboBox1.Text;
        }
    }
}
