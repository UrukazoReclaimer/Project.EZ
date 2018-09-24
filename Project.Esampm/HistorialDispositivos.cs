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
    public partial class HistorialDispositivos : Form
    {
        private PlanosEsamV2cs form1 = null;
        public HistorialDispositivos()
        {
            InitializeComponent();
           
            
            CatalogoDispoitivo clp = new CatalogoDispoitivo();
            List<Dispositivo> lista = new List<Dispositivo>();

            lista = clp.mostrarplanilla(textBox1.Text);
            this.dataGridView1.DataSource = lista;
        }

        public HistorialDispositivos(ref PlanosEsamV2cs f)
        {
            InitializeComponent();
            CatalogoDispoitivo clp = new CatalogoDispoitivo();
            List<Dispositivo> lista = new List<Dispositivo>();

            lista = clp.mostrarplanilla(textBox1.Text);
            this.dataGridView1.DataSource = lista;
            form1 = f;
        }

        private void HistorialDispositivos_Load(object sender, EventArgs e)
        {

            CatalogoDispoitivo clp = new CatalogoDispoitivo();
            List<Dispositivo> lista = new List<Dispositivo>();

            lista = clp.mostrarplanilla(textBox1.Text);
            this.dataGridView1.DataSource = lista;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells["Cod"].Value.ToString();
            form1.textBox5.Text = dataGridView1.CurrentRow.Cells["Numero"].Value.ToString();
            form1.textBox6.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
            form1.textBox8.Text = dataGridView1.CurrentRow.Cells["Cod"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CatalogoDispoitivo cd = new CatalogoDispoitivo();
            Dispositivo disp = new Dispositivo(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()),
                dataGridView1.CurrentRow.Cells[1].Value.ToString(),
               Convert.ToInt32( dataGridView1.CurrentRow.Cells[2].Value.ToString()),
               Convert.ToInt32( dataGridView1.CurrentRow.Cells[3].Value.ToString()),
               Convert.ToInt32( dataGridView1.CurrentRow.Cells[4].Value.ToString()),
               dataGridView1.CurrentRow.Cells[5].Value.ToString(),
               Convert.ToInt32( dataGridView1.CurrentRow.Cells[6].Value.ToString()));
               cd.addConsumo(Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value.ToString()), Convert.ToInt32(textBox2.Text));
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CatalogoDispoitivo clp = new CatalogoDispoitivo();
            List<Dispositivo> lista = new List<Dispositivo>();

            lista = clp.mostrarDipositivoTipoNumero(comboBox1.Text,textBox3.Text,textBox1.Text);
            this.dataGridView1.DataSource = lista;

            if(textBox3.Text=="" && comboBox1.Text=="")
            {
                lista = clp.mostrarplanilla(textBox1.Text);
                this.dataGridView1.DataSource = lista;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CatalogoDispoitivo cd = new CatalogoDispoitivo();
            Dispositivo disp = new Dispositivo(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()),
                dataGridView1.CurrentRow.Cells[1].Value.ToString(),
               Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString()),
               Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value.ToString()),
               Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value.ToString()),
               dataGridView1.CurrentRow.Cells[5].Value.ToString(),
               Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value.ToString()));
            cd.modificacionNumero(Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString()), Convert.ToInt32(textBox2.Text));
        }
    }
}
