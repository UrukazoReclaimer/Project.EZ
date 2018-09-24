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
        List<string> listfecha = new List<string>();
        public Vacaciones(string s)
        {
            InitializeComponent();

            catalogoTecnico tunits = new catalogoTecnico();
            List<Project.BussinessRules.Tecnico> tec = tunits.obtenertec();
            this.comboBox1.DataSource = tec;
            this.comboBox1.DisplayMember = "nombre";
            this.comboBox1.ValueMember = "cod";

            CatalogoPermiso tunits2 = new CatalogoPermiso();
            List<Permiso> tec2 = tunits2.mostrarPermiso();
            this.comboBox2.DataSource = tec2;
            this.comboBox2.DisplayMember = "motivo";
            this.comboBox2.ValueMember = "cod";

            CatalogoPlanilla clp = new CatalogoPlanilla();
            List<InventariadoPermiso> lista = new List<InventariadoPermiso>();

            lista = clp.mostrarplanillaPermiso(s);
            this.dataGridView1.DataSource = lista;
        }
        public void planificar( ComboBox tec)
        {
           
            //AQUIIIIIII
            CatalogoPlanilla ca = new CatalogoPlanilla();
           // List<Periodicidad> lu = ca.getcodfech();
            int index1 = 0;
            for (int i = listfecha.Count - 1; i >= 0; i--)
            {
              //  fecha.Format = DateTimePickerFormat.Custom;

               // fecha.CustomFormat = "yyyy-MM-dd";
                string b = "";
                b = listfecha[index1].ToString();                                                                                                                                //esto es el motivo 
                Periodicidad pla = new Periodicidad(b, Convert.ToInt32(comboBox15.SelectedValue), 11, Convert.ToInt32(comboBox1.SelectedValue), "N/A", "", 0, comboBox2.Text, comboBox2.Text, "", "Primario", "", "");
                ca.addfecha(pla);

                if (index1 < listfecha.Count - 1)
                {

                    index1++;
                }
              

            }

            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CatalogoPermiso cv = new CatalogoPermiso();

            Permiso v = new Permiso(comboBox2.Text);
            cv.addmotivo(v);
            graData();
            CatalogoPermiso tunits2 = new CatalogoPermiso();
            List<Permiso> tec2 = tunits2.mostrarPermiso();
            this.comboBox2.DataSource = tec2;
            this.comboBox2.DisplayMember = "motivo";
            this.comboBox2.ValueMember = "cod";

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CatalogoPlanilla ca = new CatalogoPlanilla();
            Planilla pla = new Planilla("78148350-8", "0", "DESCRIPCION", 2, 1);
            ca.addplanilla(pla);


            CatalogoPlanilla ca2 = new CatalogoPlanilla();
            List<Periodicidad> lu = ca2.getcodfech();
            this.comboBox15.DataSource = lu;
            this.comboBox15.DisplayMember = "lugartratamiento";

            this.comboBox15.ValueMember = "cod";


                if (MessageBox.Show("¿Verificó la fechas a guardar?", "ATENCIÓN",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
                {
 
                           planificar(comboBox1);
                       
                    MessageBox.Show("Ingreso Completado");
                    this.Close();
                    
                }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Vacaciones_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

            listfecha.Add(monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd"));
            comboBox3.Items.Add(monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd"));
          
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox3.Text;
        }
        public void graData()
        {
            CatalogoPermiso clp = new CatalogoPermiso();
            List<Permiso> lista = new List<Permiso>();

            lista = clp.mostrarPermiso();
            this.dataGridView1.DataSource = lista;



        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";     
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            comboBox3.Items.Remove(textBox1.Text);
            

        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    
    }
}
