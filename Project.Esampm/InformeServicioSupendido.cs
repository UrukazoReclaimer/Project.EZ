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
    public partial class InformeServicioSupendido : Form
    {
        public InformeServicioSupendido()
        {

            InitializeComponent();
            CatalogoCliente cunits = new CatalogoCliente();
            List<cliente> uni = cunits.getclierut();
            this.comboBox2.DataSource = uni;
            this.comboBox2.DisplayMember = "nombre";
            this.comboBox2.ValueMember = "rut";

            CatalogoPlanilla ounits = new CatalogoPlanilla();
            List<LugarTratamiento> lu = ounits.allgetlugar();
            this.comboBox4.DataSource = lu;
            this.comboBox4.DisplayMember = "nombre";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox4.Text == "" && comboBox2.Text == "" && comboBox1.Text == "")
            {
                CatalogoInformes clpe = new CatalogoInformes();
                List<InformeServiciosSuspendidos> listaa = new List<InformeServiciosSuspendidos>();
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                listaa = clpe.InformebuscarServiciosSuspendidosSoloFechas(dateTimePicker1.Text, dateTimePicker2.Text);
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                this.dataGridView1.DataSource = listaa;

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InformeServicioSupendido_Load(object sender, EventArgs e)
        {

        }
    }
}
