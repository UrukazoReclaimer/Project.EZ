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
    public partial class Vacaciones : Form
    {
        public Vacaciones()
        {
            InitializeComponent();

            catalogoTecnico tunits = new catalogoTecnico();
            List<Project.BussinessRules.Tecnico> tec = tunits.gettec();
            this.comboBox1.DataSource = tec;
            this.comboBox1.DisplayMember = "nombre";
            this.comboBox1.ValueMember = "cod";
        }
        public void planificar(List<int> listser, List<int> listarea, ComboBox c1, DateTimePicker fecha, ComboBox tec)
        {
             
            CatalogoPlanilla ca = new CatalogoPlanilla();
            List<Periodicidad> lu = ca.getcodfech();
                        
            
            
            Periodicidad pla = new Periodicidad(fecha.Text, 0, 0, 0, 32, "", 0, "VACACIONES", "P", "");
            ca.addfecha(pla);

                  
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Add(comboBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
