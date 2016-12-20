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
    public partial class TipoDeSuspendido : Form
    {
        public TipoDeSuspendido()
        {
            InitializeComponent();
        }

        private void TipoDeSuspendido_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seleccionar solicitante de suspensión");

            Suspendido rd = new Suspendido();
            rd.comboBox1.DisplayMember = comboBox2.DisplayMember;
            rd.comboBox1.ValueMember = comboBox2.ValueMember;
            rd.comboBox1.DataSource = comboBox2.DataSource;
            rd.dateTimePicker1.Text = dateTimePicker1.Text;
            rd.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seleccionar solicitante de suspensión");

            SuspendidoTotal rd = new SuspendidoTotal();
 
            rd.comboBox1.Text = comboBox1.Text;
            rd.dateTimePicker1.Text = dateTimePicker1.Text;
            rd.Show();
            this.Close();
        }
    }
}
