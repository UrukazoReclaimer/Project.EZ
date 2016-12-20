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

    public partial class PlanillaR : Form
    {
        List<int> list = new List<int>();
        List<int> list2 = new List<int>();
        List<int> list3 = new List<int>();
  
        public PlanillaR(string s) 
        { 
            InitializeComponent();
            CatalogoCliente cunits = new CatalogoCliente();
            List<cliente> uni = cunits.getclierut();
            this.comboBox3.DataSource = uni;
            this.comboBox3.DisplayMember = "nombre";
            this.comboBox3.ValueMember = "rut";


            CatalogoPlanilla ounits = new CatalogoPlanilla();
            List<LugarTratamiento> lu = ounits.allgetlugar();
            this.comboBox4.DataSource = lu;
            this.comboBox4.DisplayMember = "nombre";
            //cambie el value
            this.comboBox4.ValueMember = "rut";

            catalogoTecnico tunits = new catalogoTecnico();
            List<Project.BussinessRules.Tecnico> tec = tunits.gettec();
            this.comboBox8.DataSource = tec;
            this.comboBox8.DisplayMember = "nombre";
            this.comboBox8.ValueMember = "cod";

            CatalogoPlanilla clp = new CatalogoPlanilla();
            List<InventariadoR> lista = new List<InventariadoR>();

            lista = clp.mostrarplanillaR(s);

            this.dataGridView1.DataSource = lista;
            

            button1.Enabled = false; 
        }

        private void PlanillaR_Load(object sender, EventArgs e)
        {
                
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
           
        }

      

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            List<Inventariado> lista = new List<Inventariado>();
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["FECHAR"].Value.ToString();
                comboBox8.Text = dataGridView1.CurrentRow.Cells["TECNICOR"].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells["SERVICIOR"].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells["LUGARTRATAMIENTOR"].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells["CONSUMOR"].Value.ToString();

            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CatalogoPlanilla catalogo = new CatalogoPlanilla();
            CatalogoPlanilla ca = new CatalogoPlanilla();

            Periodicidad pe = new Periodicidad(dateTimePicker3.Text, Convert.ToInt32(comboBox7.Text), comboBox1.Text);   

                          
            CatalogoPlanilla ounitsx = new CatalogoPlanilla();
            List<Periodicidad> lu = ounitsx.getcodperiodiInforme(dateTimePicker4.Text, textBox4.Text, comboBox10.Text);
            this.comboBox5.DataSource = lu;
            this.comboBox5.DisplayMember = "cod";
            this.comboBox5.ValueMember = "cod";
            int aux = comboBox5.SelectedIndex;
            int indeaux=0;
            indeaux = 0;
            int indexo = Convert.ToInt32(comboBox9.SelectedValue);
            for (int i = comboBox9.Items.Count - 1; i >= 0; i--)
            {

/*
                comboBox9.SelectedValue = indexo;

                list.Add(indexo);
                indexo++;
 */

                comboBox9.SelectedIndex = indeaux;
                indexo = Convert.ToInt32(comboBox9.SelectedValue);
                list.Add(indexo);
                indeaux++;
            }     
            int index1 = 0;
            int index = 0;
            string a = "";          
            index1 = 0;
            index = 0;        
            for (int i = comboBox9.Items.Count - 1; i >= 0; i--)
            {
                string b = "";
                a = "";
                a = list[index].ToString();                       
                Periodicidad ot = new Periodicidad(Convert.ToInt32(a), textBox6.Text);              
                catalogo.modOti(ot);
                Periodicidad po = new Periodicidad(dateTimePicker3.Text, Convert.ToInt32(a), comboBox1.Text); 
                ca.modFecha(po);
                Periodicidad pt = new Periodicidad(Convert.ToInt32(comboBox8.SelectedValue), Convert.ToInt32(a), comboBox1.Text);
                catalogo.modTecnicoR(pt);
                if (index1 < comboBox9.Items.Count - 1)
                {

                    index1++;
                    index++;
                }
                else
                {
                    index1 = index1;
                }

            }
            list.Clear();
             index1 = 0;
             index = 0;
             int aux2 = comboBox7.SelectedIndex;
             int indexo2 = Convert.ToInt32(comboBox7.SelectedValue);
             for (int i = comboBox7.Items.Count - 1; i >= 0; i--)
             {
                 comboBox7.SelectedValue = indexo2;
             
                 list2.Add(indexo2);
                 indexo2++;
             }


             int index12 = 0;
             int index2 = 0;
             string a2 = "";
        

             index12 = 0;
             index2 = 0;
             if (comboBox1.Text != "Suspendido")
             {

                 for (int i = comboBox7.Items.Count - 1; i >= 0; i--)
                 {
                     string b2 = "";
                     a2 = "";
                     a2 = list2[index2].ToString();

                     catalogo.modEstado(pe);
                     CatalogoPlanilla pla = new CatalogoPlanilla();
                     Periodicidad p = new Periodicidad(dateTimePicker3.Text, Convert.ToInt32(a2), Convert.ToInt32(textBox5.Text), textBox6.Text);
                     pla.modConsumo(p);
                     pe = new Periodicidad(dateTimePicker3.Text, Convert.ToInt32(a2), comboBox1.Text);
                     ca.modEstado(pe);
                     if (index12 < comboBox7.Items.Count - 1)
                     {

                         index12++;
                         index2++;
                     }
                     else
                     {
                         index12 = index12;
                     }

                 }
                 list2.Clear();
                 index12 = 0;
                 index2 = 0;

             }
             else {
//------------------------------------------------------------------------
                  aux2 = comboBox9.SelectedIndex;
                  indexo2 = Convert.ToInt32(comboBox5.SelectedValue);
                 for (int i = comboBox9.Items.Count - 1; i >= 0; i--)
                 {
                     comboBox9.SelectedValue = indexo2;

                     list2.Add(indexo2);
                     indexo2++;
                 }


                 for (int i = comboBox9.Items.Count - 1; i >= 0; i--)
                 {
                     string b2 = "";
                     a2 = "";
                     a2 = list2[index2].ToString();

                     catalogo.modEstado(pe);
                     CatalogoPlanilla pla = new CatalogoPlanilla();
                     Periodicidad p = new Periodicidad(dateTimePicker3.Text, Convert.ToInt32(a2), Convert.ToInt32(textBox5.Text), textBox6.Text);
                   //  pla.modConsumo(p);
                     pe = new Periodicidad(dateTimePicker3.Text, Convert.ToInt32(a2), comboBox1.Text);
                     ca.modEstado(pe);
                     if (index12 < comboBox9.Items.Count - 1)
                     {

                         index12++;
                         index2++;
                     }
                     else
                     {
                         index12 = index12;
                     }

                 }
                 list2.Clear();
                 index12 = 0;
                 index2 = 0;
             
             
             }
                if (this.comboBox1.Text == "Realizado") 
                {

                    MessageBox.Show("Informacion Guardada");
                    graDataFiltros();
                  
                   
                }

                if (this.comboBox1.Text == "No Realizado")
                {

                    MessageBox.Show("Informacion Guardada");
                    graDataFiltros();
                  
                }

                          
            if (this.comboBox1.Text == "Suspendido")
            {
                MessageBox.Show("Se debe seleccionar el tipo de suspención");
                TipoDeSuspendido tr = new TipoDeSuspendido();
                tr.comboBox1.Text = dataGridView1.CurrentRow.Cells["CodR"].Value.ToString();
                CatalogoPlanilla ounits = new CatalogoPlanilla();
                List<Periodicidad> lu2 = ounits.getcodperiodiR(dateTimePicker3.Text, tr.comboBox1.Text);
                tr.comboBox2.DataSource = lu2;
                tr.comboBox2.DisplayMember = "cod";
                tr.comboBox2.ValueMember = "cod";
                tr.dateTimePicker1.Text = dateTimePicker3.Text;
                graDataFiltros();
                tr.Show();
                

            }
            if (this.comboBox1.Text == "R.Dispositivo") 
            {
                MessageBox.Show("Se Debe Seleccionar el tipo de Retiro a planificar");
                TipodeRetiro tr = new TipodeRetiro();
                tr.comboBox1.Text = dataGridView1.CurrentRow.Cells["CodR"].Value.ToString();
                CatalogoPlanilla ounits = new CatalogoPlanilla();
                List<Periodicidad> lu2 = ounits.getcodperiodiR(dateTimePicker3.Text, tr.comboBox1.Text);
                tr.comboBox2.DataSource = lu2;
                tr.comboBox2.DisplayMember = "cod";
                tr.comboBox2.ValueMember = "cod";
                graDataFiltros();
                tr.Show();
                

            }
            if (this.comboBox1.Text == "Replanificado")
            {
                MessageBox.Show("Ha Elegido Replanificar");
                Replanificar rep = new Replanificar();
                rep.dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["FECHAR"].Value.ToString();
                rep.comboBox1.Text = dataGridView1.CurrentRow.Cells["TECNICOR"].Value.ToString();
                rep.comboBox2.Text = dataGridView1.CurrentRow.Cells["CliR"].Value.ToString();
                rep.comboBox3.Text = dataGridView1.CurrentRow.Cells["LugarTratamientoR"].Value.ToString();
           
                rep.comboBox8.Text = dataGridView1.CurrentRow.Cells["CodR"].Value.ToString();
                rep.textBox1.Text = dataGridView1.CurrentRow.Cells["TipoR"].Value.ToString();
                graDataFiltros();
                rep.Show();
                
            }

            
           
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (!(dataGridView1.CurrentRow.Cells["NOTI"].Value == null))
            {

                dateTimePicker3.Format = DateTimePickerFormat.Custom;
                dateTimePicker3.CustomFormat = "yyyy-MM-dd";
                dateTimePicker3.Text = dataGridView1.CurrentRow.Cells["FECHAR"].Value.ToString();
                dateTimePicker4.Format = DateTimePickerFormat.Custom;
                dateTimePicker4.CustomFormat = "yyyy-MM-dd";
                dateTimePicker4.Text = dataGridView1.CurrentRow.Cells["FECHAR"].Value.ToString();                             
                comboBox8.Text = dataGridView1.CurrentRow.Cells["TECNICOR"].Value.ToString();
                comboBox10.Text = dataGridView1.CurrentRow.Cells["TECNICOR"].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells["SERVICIOR"].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells["LUGARTRATAMIENTOR"].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells["CONSUMOR"].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells["NOTI"].Value.ToString();
                comboBox6.Text = dataGridView1.CurrentRow.Cells["CODR"].Value.ToString();
                textBox1.Text = dataGridView1.CurrentRow.Cells["TipoR"].Value.ToString();
                comboBox1.Text = dataGridView1.CurrentRow.Cells["Estado"].Value.ToString();
            }
            else
            {



                dateTimePicker3.Text = dataGridView1.CurrentRow.Cells["FECHAR"].Value.ToString();
                dateTimePicker4.Format = DateTimePickerFormat.Custom;
                dateTimePicker4.CustomFormat = "yyyy-MM-dd";
                dateTimePicker4.Text = dataGridView1.CurrentRow.Cells["FECHAR"].Value.ToString();
                comboBox8.Text = dataGridView1.CurrentRow.Cells["TECNICOR"].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells["SERVICIOR"].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells["LUGARTRATAMIENTOR"].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells["CONSUMOR"].Value.ToString();
                comboBox1.Text = dataGridView1.CurrentRow.Cells["Estado"].Value.ToString();



            }

            if (textBox3.Text== "S1")
            {

                textBox5.Enabled = true;
            }
            else {
                textBox5.Enabled = false;
            }
            button1.Enabled = true; 
            CatalogoPlanilla ounits = new CatalogoPlanilla();
            CatalogoPlanilla ounits2 = new CatalogoPlanilla();
            CatalogoServicios userv = new CatalogoServicios();
            List<Periodicidad> lu = ounits.getcodperiodiInforme(dateTimePicker3.Text, textBox4.Text, comboBox8.Text);
            this.comboBox5.DataSource = lu;
            this.comboBox5.DisplayMember = "cod";
            this.comboBox5.ValueMember = "cod";
            List<servicio> lu2 = userv.getCodSer(dateTimePicker3.Text, comboBox6.Text, textBox3.Text);
            this.comboBox2.DataSource = lu2;
            this.comboBox2.DisplayMember = "cod";
           this.comboBox2.ValueMember = "cod";

           List<Periodicidad> lu3 = ounits2.getCodIndividual(dateTimePicker3.Text,comboBox6.Text, comboBox2.Text);
           this.comboBox7.DataSource = lu3;
           this.comboBox7.DisplayMember = "cod";
           this.comboBox7.ValueMember = "cod";
           List<Periodicidad> lu4 = ounits.getcodperiodiR(dateTimePicker3.Text, comboBox6.Text);
           comboBox9.DataSource = lu4;
           comboBox9.DisplayMember = "cod";
           comboBox9.ValueMember = "cod";

  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<InventariadoR> lista = new List<InventariadoR>();
            CatalogoPlanilla clp = new CatalogoPlanilla();
            
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            //   lista = clp.mostrarplanillapornombre(textBox12.Text);
            lista = clp.mostrarplanillaRporcliente(comboBox3.Text, dateTimePicker1.Text, dateTimePicker2.Text);
            this.dataGridView1.DataSource = lista;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            CatalogoPlanilla ounits = new CatalogoPlanilla();
            List<LugarTratamiento> lu = ounits.getlugar(Convert.ToString(comboBox3.SelectedValue));
            this.comboBox4.DataSource = lu;
            this.comboBox4.DisplayMember = "nombre";
            //cambie el value
            this.comboBox4.ValueMember = "rut";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            CatalogoPlanilla clp = new CatalogoPlanilla();
            List<InventariadoR> lista = new List<InventariadoR>();
            comboBox3.Text = "";
            comboBox4.Text = "";
            lista = clp.mostrarplanillaR("");

            this.dataGridView1.DataSource = lista;  
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<InventariadoR> lista = new List<InventariadoR>();
            CatalogoPlanilla clp = new CatalogoPlanilla();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            lista = clp.mostrarplanillaRporltratamiento(comboBox4.Text, dateTimePicker1.Text, dateTimePicker2.Text);
            this.dataGridView1.DataSource = lista;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            comboBox1.Items.Clear();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            CatalogoPlanilla clp = new CatalogoPlanilla();
            List<InventariadoR> lista = new List<InventariadoR>();

            lista = clp.mostrarplanillaRRealizados(comboBox3.Text);
            this.dataGridView1.DataSource = lista;   
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CatalogoPlanilla clp = new CatalogoPlanilla();
            List<InventariadoR> lista = new List<InventariadoR>();

            //lista = clp.mostrarplanillaR("");
            lista = clp.mostrarplanillaRARealizar(comboBox3.Text);
            this.dataGridView1.DataSource = lista;  
        }


        public void graData()
        {
            CatalogoPlanilla clp = new CatalogoPlanilla();
            List<InventariadoR> lista = new List<InventariadoR>();

            lista = clp.mostrarplanillaR(textBox2.Text);
            this.dataGridView1.DataSource = lista;    


        }

        public void graDataFiltros()
        {
            List<InventariadoR> lista2 = new List<InventariadoR>();
            CatalogoPlanilla clp2 = new CatalogoPlanilla();
            lista2 = clp2.mostrarplanillaRporltratamiento(comboBox4.Text, dateTimePicker1.Text, dateTimePicker2.Text);
            this.dataGridView1.DataSource = lista2;


        }
        private void button10_Click(object sender, EventArgs e)
        {
            CatalogoPlanilla clp = new CatalogoPlanilla();
            List<InventariadoR> lista = new List<InventariadoR>();
            //    lista = clp.mostrarplanillaporfecha(textBox1.Text + "-" + textBox10.Text + "-" + textBox9.Text);

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            lista = clp.mostrarplanillaRporfecha(dateTimePicker1.Text, dateTimePicker2.Text);
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            this.dataGridView1.DataSource = lista;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CatalogoPlanilla clp = new CatalogoPlanilla();
            List<InventariadoR> lista = new List<InventariadoR>();

            lista = clp.mostrarplanillaRNORealizados("");
            this.dataGridView1.DataSource = lista;   
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CatalogoPlanilla clp = new CatalogoPlanilla();
            List<InventariadoR> lista = new List<InventariadoR>();

            lista = clp.mostrarplanillaRSuspendidos("");
            this.dataGridView1.DataSource = lista;   
        }
        

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
