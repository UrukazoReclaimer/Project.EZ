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
    public partial class Privilegios : Form
    {
        public Privilegios()
        {
            InitializeComponent();
            CatalogoUsuario clp = new CatalogoUsuario();
            List<Usuario> lista = new List<Usuario>();

            lista = clp.mostrarUsuario();
            this.dataGridView1.DataSource = lista;
        }

        private void Privilegios_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            textBox4.Text = dataGridView1.CurrentRow.Cells["COD"].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells["NOMBRE"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["CONTRASEÑA"].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells["NIVEL"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CatalogoUsuario pla = new CatalogoUsuario();
            Usuario p = new Usuario(Convert.ToInt32(textBox4.Text),textBox1.Text,textBox2.Text,comboBox2.Text);
            
            pla.modUsuario(p);
            pla.modUsuarioNivel(p);
            CatalogoUsuario clp = new CatalogoUsuario();
            List<Usuario> lista = new List<Usuario>();

            lista = clp.mostrarUsuario();
            this.dataGridView1.DataSource = lista;
        }
          
        private void button1_Click(object sender, EventArgs e)
        {
        CatalogoUsuario u = new CatalogoUsuario();
            u.addusuario(textBox1.Text, textBox2.Text,comboBox2.Text);
            MessageBox.Show("Registro Completado");

        }
    }
}
