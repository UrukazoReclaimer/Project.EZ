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
    public partial class IngresarAuditoria : Form
    {
        public IngresarAuditoria()
        {
            InitializeComponent();
            catalogoTecnico tunits = new catalogoTecnico();
            List<Project.BussinessRules.Tecnico> tec = tunits.obtenertec();

            this.comboBox2.DataSource = tec;
            this.comboBox2.DisplayMember = "nombre";
            this.comboBox2.ValueMember = "cod";
        }

        private void IngresarAuditoria_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            DateTime fecha = DateTime.Now.Date;
            int day = fecha.Day;
            int month = fecha.Month;
            int year = Convert.ToInt32(textBox2.Text);
            dateTimePicker1.Value = new DateTime(year, month, day);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Verificó la fechas a guardar?", "ATENCIÓN",
          MessageBoxButtons.YesNo, MessageBoxIcon.Question)
          == DialogResult.Yes)
            {

                planificar(14, "N/A", comboBox1, dateTimePicker1, comboBox2);
           
                MessageBox.Show("Ingreso Completado");
                this.Close();
               
            }
        }
        public void planificar(int listser, string area, ComboBox c1, DateTimePicker fecha, ComboBox tec)
        {

            CatalogoPlanilla ca = new CatalogoPlanilla();
            List<Periodicidad> lu = ca.getcodfech();
            c1.DataSource = lu;
            c1.DisplayMember = "lugartratamiento";
            c1.ValueMember = "cod";
            string a = "";
            fecha.Format = DateTimePickerFormat.Custom;
            fecha.CustomFormat = "yyyy-MM-dd";
            string b = "";
            Periodicidad pla = new Periodicidad(fecha.Text, Convert.ToInt32(c1.SelectedValue), 14, Convert.ToInt32(tec.SelectedValue), b, "", 0, "A", "P", "", "Primario", "", "");
            ca.addfecha(pla);




        }


        
    }
}
