﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.BussinessRules;
using System.Text.RegularExpressions;
namespace Project.Esampm
{
    public partial class IngresarClientes : Form
    {
        public IngresarClientes()
        {
            InitializeComponent();



            if (comboBox2.Text ==null)
            {
                comboBox2.Text = "1";
            }
            else
            {
                if (comboBox2.Text != null)
                {
                    CatalogoCliente ca = new CatalogoCliente();
                    List<cliente> la = ca.getmaxcodcli();
                    this.comboBox2.DataSource = la;
                    this.comboBox2.DisplayMember = "cod";
              
                    this.comboBox2.ValueMember = "cod";

                }
            }

            CatalogoCliente clp = new CatalogoCliente();
            List<cliente> lista = new List<cliente>();

       
            lista = clp.mbuscarPlanilla("");
            graData();
            List<Inventariadoplano> invi = new List<Inventariadoplano>();
            invi = clp.mbuscarlugarplano("");
            graData();
            List<InventariadoCliente> invcli = new List<InventariadoCliente>();
            invcli= clp.mbuscarcontacto("");
            graData();
       

        }
        /// <summary>
        /// La funcion de este metodo es guardar el cliente nuevo y sus parametros a la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            CatalogoCliente ca = new CatalogoCliente();
            if (comboBox5.Text == "")
            {
                MessageBox.Show("Se debe ingresar un lugar de tratamiento");
            }
            else
            {
               
                validarRut(textBox2.Text);
              
                if (validarRut(textBox2.Text) == true)
                {

                    MessageBox.Show("Ingreso Valido");
                    this.textBox6.Focus();

                    LugarTratamiento cli = new LugarTratamiento(this.textBox1.Text, this.textBox2.Text, this.comboBox1.Text, this.comboBox5.Text, Convert.ToInt32(comboBox2.Text));
                    ca.addCliente(cli);

                    //------------------lugar de tratamiento

                    cli = new LugarTratamiento(Convert.ToInt32(comboBox2.Text), this.textBox2.Text, comboBox5.Text, this.comboBox6.Text, this.comboBox3.Text);
                    ca.addLugar(cli);



                  
                    List<cliente> la = ca.getmaxcodcli();
                    this.comboBox2.DataSource = la;
                    this.comboBox2.DisplayMember = "cod";                 
                    this.comboBox2.ValueMember = "cod";


                    CatalogoCliente co = new CatalogoCliente();
                    List<LugarTratamiento> lo = co.getLtracod(Convert.ToString(comboBox5.Text));
                    this.comboBox4.DataSource = lo;
                    this.comboBox4.DisplayMember = "cod";               
                    this.comboBox4.ValueMember = "cod";

                    //--------------------contacto
                    CatalogoContacto cc = new CatalogoContacto();
                    Contacto con = new Contacto(Convert.ToInt32(comboBox4.Text), textBox5.Text, textBox6.Text, textBox7.Text, textBox9.Text);
                    cc.addContacto(con);
                    //--------plano




                    CatalogoPlanocs cp = new CatalogoPlanocs();                  
                    Plano pl = new Plano(textBox8.Text, Convert.ToInt32(comboBox4.Text), Convert.ToInt32(textBox8.Text));
                    cp.addplano(pl);
                    MessageBox.Show("Ingreso Plano Hecho");

                    this.graData();

                    textBox1.Text = "";
                    textBox2.Text = "";

                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    comboBox1.Text = "";
                    textBox8.Text = "";
                    comboBox5.Text = "";
                    comboBox6.Text = "";


                }
                else
                {
                    MessageBox.Show("Teclee un dato valido", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CatalogoCliente ca = new CatalogoCliente();
            ca.removeCliente(this.textBox4.Text);
            this.graData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CatalogoCliente ca = new CatalogoCliente();
            cliente at = new cliente(this.textBox1.Text, this.textBox2.Text,comboBox1.Text,this.comboBox5.Text);
            ca.modiCli(at);
            this.graData();
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["Rut"].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells["Clasificacion"].Value.ToString();
            comboBox7.Text = dataGridView1.CurrentRow.Cells["Codigo"].Value.ToString();
            comboBox5.Text ="";
            
            textBox8.Text = "";
        
           
        }
        public bool validarRut(string rut)
        {

            bool validacion = false;
            try
            {
                rut = rut.ToUpper();
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));

                char dv = char.Parse(rut.Substring(rut.Length - 1, 1));

                int m = 0, s = 1;
                for (; rutAux != 0; rutAux /= 10)
                {
                    s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
                }
                if (dv == (char)(s != 0 ? s + 47 : 75))
                {
                    validacion = true;
                }
            }
            catch (Exception)
            {
            }
            return validacion;
        }

        private void IngresarClientes_Load(object sender, EventArgs e)
        {
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IngresarLugarTratamiento inh = new IngresarLugarTratamiento();

            inh.Show();
        }

        public void graData()
        {
            CatalogoCliente ac = new CatalogoCliente();
            List<cliente> lista = new List<cliente>();
            List<Inventariadoplano> invi = new List<Inventariadoplano>();
            lista = ac.mbuscarPlanilla("");
            invi = ac.mbuscarlugarplano("");
            List<InventariadoCliente> invcli = new List<InventariadoCliente>();
            invcli = ac.mbuscarcontacto("");
            this.dataGridView1.DataSource = lista;
            this.dataGridView2.DataSource = invi;
            this.dataGridView3.DataSource = invcli;
          


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            IngresarPLano ingpl = new IngresarPLano();
            ingpl.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {


            TiposContacto tip = new TiposContacto();

            CatalogoCliente co = new CatalogoCliente();
            List<cliente> lo = co.getclientcodfornom(textBox1.Text);
            tip.comboBox3.DataSource = lo;
            tip.comboBox3.DisplayMember = "cod";
           
            tip.comboBox3.ValueMember = "cod";

            tip.comboBox4.Text = textBox2.Text;
            tip.comboBox1.Text = textBox1.Text;
            tip.comboBox2.Text = textBox1.Text;
    
            tip.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        { CatalogoCliente ac = new CatalogoCliente();
            List<cliente> lista = new List<cliente>();
         
            lista = ac.mbuscarPlanilla(textBox4.Text);
            textBox4.Text = "";
            this.dataGridView1.DataSource = lista;
           

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            

    if (e.KeyChar == Convert.ToChar(Keys.Enter))
    {
        CatalogoCliente ac = new CatalogoCliente();
        List<cliente> lista = new List<cliente>();
        List<Inventariadoplano> invi = new List<Inventariadoplano>();
        List<InventariadoCliente> invcon = new List<InventariadoCliente>();
        invi = ac.mbuscarlugarplano(textBox4.Text);        
        lista = ac.mbuscarPlanilla(textBox4.Text);
        invcon = ac.mbuscarcontacto(textBox4.Text);
        textBox4.Text = "";
        this.dataGridView1.DataSource = lista;
        this.dataGridView2.DataSource = invi;
        this.dataGridView3.DataSource = invcon;  
        
    }

        }
        /// <summary>
        /// La funcion CellContentCliecj del datagridview es realizar una funcion al momento de hacer click en una fila d la tabla.
        /// en este caso rellena los texbox y combobox con la respectiva informacion seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            comboBox7.Text = dataGridView1.CurrentRow.Cells["Codigo"].Value.ToString();
            comboBox5.Text = dataGridView2.CurrentRow.Cells["NombreLugar"].Value.ToString();
            textBox2.Text = dataGridView2.CurrentRow.Cells["RutCliente"].Value.ToString();
            textBox8.Text = dataGridView2.CurrentRow.Cells["Plano"].Value.ToString();
            comboBox6.Text = dataGridView2.CurrentRow.Cells["RUTA"].Value.ToString();
          
     
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            CatalogoCliente ca = new CatalogoCliente();
         LugarTratamiento   cli = new LugarTratamiento(Convert.ToInt32(comboBox7.Text), this.textBox2.Text, comboBox5.Text, this.comboBox6.Text,this.comboBox3.Text);
            ca.addLugar(cli);
        
            List<cliente> la = ca.getmaxcodcli();
            this.comboBox2.DataSource = la;
            this.comboBox2.DisplayMember = "cod";
         
            this.comboBox2.ValueMember = "cod";


            CatalogoCliente co = new CatalogoCliente();
            List<LugarTratamiento> lo = co.getLtracod(Convert.ToString(comboBox5.Text));
            this.comboBox4.DataSource = lo;
            this.comboBox4.DisplayMember = "cod";
           
            this.comboBox4.ValueMember = "cod";

            //--------------------contacto
            CatalogoContacto cc = new CatalogoContacto();
            Contacto con = new Contacto(Convert.ToInt32(comboBox4.Text), textBox5.Text, textBox6.Text, textBox7.Text, textBox9.Text);
            cc.addContacto(con);
            //--------plano




            CatalogoPlanocs cp = new CatalogoPlanocs();
            Plano pl = new Plano(textBox8.Text, Convert.ToInt32(comboBox4.Text));
            cp.addplano(pl);
            MessageBox.Show("Ingreso de Nuevo lugar y Plano Hecho");

            this.graData();

            textBox1.Text = "";
            textBox2.Text = "";
          
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        
            comboBox5.Text = dataGridView2.CurrentRow.Cells["NombreLugar"].Value.ToString();
            textBox2.Text = dataGridView2.CurrentRow.Cells["RutCliente"].Value.ToString();
            textBox8.Text = dataGridView2.CurrentRow.Cells["Plano"].Value.ToString();
            comboBox6.Text = dataGridView2.CurrentRow.Cells["RUTA"].Value.ToString();
            comboBox5.Text = dataGridView3.CurrentRow.Cells["LUGAR"].Value.ToString();       
            comboBox6.Text = dataGridView3.CurrentRow.Cells["RutaOrigen"].Value.ToString();
            textBox5.Text = dataGridView3.CurrentRow.Cells["NombreContacto"].Value.ToString();
            textBox6.Text = dataGridView3.CurrentRow.Cells["Telefono"].Value.ToString();
            textBox7.Text = dataGridView3.CurrentRow.Cells["Correo"].Value.ToString();
            textBox8.Text = dataGridView3.CurrentRow.Cells["PlanodeLugar"].Value.ToString();
            textBox3.Text = dataGridView3.CurrentRow.Cells["CODID"].Value.ToString();
            textBox1.Text = dataGridView3.CurrentRow.Cells["NOMBRECLIENTE"].Value.ToString();
            textBox2.Text = dataGridView3.CurrentRow.Cells["RUTCLIENTE"].Value.ToString();
            textBox10.Text = dataGridView3.CurrentRow.Cells["CODLUG"].Value.ToString();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            CatalogoContacto ca = new CatalogoContacto();
            CatalogoCliente cc = new CatalogoCliente();
            Contacto at = new Contacto(textBox5.Text, textBox6.Text, textBox7.Text, textBox9.Text,Convert.ToInt32(textBox3.Text));
            ca.modicontacto(at);
      
            this.graData();
        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            comboBox6.Items.Add(comboBox6.Text);

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            CatalogoCliente ca = new CatalogoCliente();
            List<cliente> la = ca.getclierutcondition(textBox2.Text);
            this.comboBox8.DataSource = la;
            this.comboBox8.DisplayMember = "cod";
         
            this.comboBox8.ValueMember = "cod";

            if (comboBox8.Items.Count >= 1)
            {

                MessageBox.Show("Cliente Existente");

            }
            
           
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            CatalogoCliente cc = new CatalogoCliente();
            LugarTratamiento lu = new LugarTratamiento(comboBox5.Text, comboBox6.Text, Convert.ToInt32(textBox10.Text));
            cc.modLugar(lu);
            this.graData();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text="";
            comboBox5.Text="";
            textBox8.Clear();
            comboBox6.Text = "" ;
            comboBox3.Text="";
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
