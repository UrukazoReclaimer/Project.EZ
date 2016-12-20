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
    public partial class TipodeRetiro : Form
    {
        public List<int> listcodper;
      public  int codpla;
        public TipodeRetiro()
        {
            InitializeComponent();
        }

        private void TipodeRetiro_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seleccionar solicitante del retiro");

            RDispositivo rd = new RDispositivo();
            rd.comboBox1.DisplayMember = comboBox2.DisplayMember;
            rd.comboBox1.ValueMember = comboBox2.ValueMember;
            rd.comboBox1.DataSource = comboBox2.DataSource;
            rd.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seleccionar solicitante del retiro");
            RDispositivoTemporal rdt = new RDispositivoTemporal();
            rdt.comboBox2.Text = comboBox1.Text;
            rdt.Show();
            this.Close();

        }
    }
}
