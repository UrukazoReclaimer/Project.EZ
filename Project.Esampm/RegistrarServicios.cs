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
    public partial class RegistrarServicios : Form
    {
        public RegistrarServicios()
        {
            InitializeComponent();
            CatalogoServicios sunits = new CatalogoServicios();
            List<Project.BussinessRules.servicio> ser = sunits.getser();
            this.comboBox1.DataSource = ser;
            this.comboBox1.DisplayMember = "sigla";
            this.comboBox1.ValueMember = "cod";

        }

        private void RegistrarServicios_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int index = comboBox1.FindString(comboBox1.Text);
            comboBox1.SelectedIndex = index;

            if (comboBox1.SelectedIndex != 0)
            {
                listBox1.Items.Add(comboBox1.Text);
            }
        }
    }
}
