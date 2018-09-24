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
    public partial class Entrada : Form
    {

        public Entrada()
        {
            InitializeComponent();
          
        }

        public IngresarClientes IngresarClientes
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public IngresarTecnico IngresarTecnico
        {     
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public InformeServicioReplanificados InformeServicioReplanificados
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public IngresarVehiculo IngresarVehiculo
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Vacaciones Vacaciones
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public IngresarServicios IngresarServicios
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public IngresarArea IngresarArea
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public PlanillaServicio PlanillaServicio
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public TableroPeriodicidad TableroPeriodicidad
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Calendario Calendario
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public PlanillaR PlanillaR
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        private void Entrada_Load(object sender, EventArgs e)
        {
            

        }
        /// <summary>
        /// Evento en el boton para ingresar al formulario de ingreso y control de tecnicos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {



            IngresarTecnico ingt = new IngresarTecnico();
            //control MDI
            ingt.textBox3.Text = textBox1.Text;
            ingt.MdiParent = Principal.ActiveForm;
            ingt.Show();
        }
        /// <summary>
        /// Evento en el boton para ingresar al formulario de ingreso y control de servicios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            IngresarServicios ings = new IngresarServicios();
            //control MDI
            ings.textBox2.Text = textBox1.Text;
            ings.MdiParent = Principal.ActiveForm;
            if (textBox1.Text == "Usuario_Plano" || textBox1.Text == "Obs")
            {
                ings.button2.Enabled = false;
                ings.button1.Enabled = false;
                
            }
            ings.Show();
        }
        /// <summary>
        /// Evento en el boton para ingresar al formulario de planificacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Debe Saeleccionar año");
            }
            else
            {

                PlanillaServicio pla = new PlanillaServicio(comboBox1.Text);
                //control MDI
                pla.textBox1.Text = textBox1.Text;
                pla.MdiParent = Principal.ActiveForm;
                if (textBox1.Text == "Usuario_Plano" || textBox1.Text == "Obs")
                {
                    pla.panel1.Enabled = false;
                    pla.panel2.Enabled = false;
                    pla.button11.Enabled = false;
                    pla.button12.Enabled = false;
                }
                pla.Show();
                pla.textBox3.Text = this.comboBox1.Text;
            }

        }
        /// <summary>
        /// Evento en el boton para ingresar al formulario de ingreso y control de clientes, lugar de tratmiento y contactos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            IngresarClientes ingc = new IngresarClientes();
            //control MDI
            ingc.textBox12.Text = textBox1.Text;
            ingc.MdiParent = Principal.ActiveForm;
            if (textBox1.Text == "Usuario_Plano" || textBox1.Text == "Obs")
            {
                ingc.panel2.Enabled = false;
                ingc.panel5.Enabled = false;
                ingc.panel8.Enabled = false;
            }
            ingc.Show();
        }
        /// <summary>
        /// Evento en el boton para ingresar al formulario de ingreso y control de vehiculos
        /// </summary>
        /// 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            IngresarVehiculo iv = new IngresarVehiculo();
            //control MDI
            iv.textBox3.Text = textBox1.Text;
            iv.MdiParent = Principal.ActiveForm;
            if (textBox1.Text == "Usuario_Plano" || textBox1.Text == "Obs")
            {
                iv.button1.Enabled = false;
                iv.button2.Enabled = false;
               
            }
            iv.Show();
        }
        /// <summary>
        /// Evento en el boton para ingresar al formulario de menu de informes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {
            OpcionInforme op = new OpcionInforme();
            //control MDI
            op.textBox2.Text = textBox1.Text;
            op.textBox1.Text = comboBox1.Text;
            op.MdiParent = Principal.ActiveForm;
            op.Show();
        }
        /// <summary>
        /// Evento en el boton para ingresar al formulario de ingreso y control de areas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button9_Click(object sender, EventArgs e)
        {
            IngresarArea inga = new IngresarArea();
            //control MDI
            inga.textBox2.Text = textBox1.Text;
            inga.MdiParent = Principal.ActiveForm;
            if (textBox1.Text == "Usuario_Plano" || textBox1.Text == "Obs")
            {
                inga.button1.Enabled = false;
                inga.button2.Enabled = false;
                inga.button3.Enabled = false;
            }
            inga.Show();
        }
        /// <summary>
        /// Evento en el boton para ingresar al formulario de planilla R
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Debe Saeleccionar año");
            }
            else
            {
                PlanillaR plr = new PlanillaR(comboBox1.Text);
                //control MDI
                plr.textBox9.Text = textBox1.Text;
                plr.MdiParent = Principal.ActiveForm;
                if (textBox1.Text == "Usuario_Plano" || textBox1.Text == "Obs")
                {
                    plr.button1.Enabled = false;
                   
                }
                plr.Show();
                plr.textBox2.Text = this.comboBox1.Text;
            }
        }
        /// <summary>
        /// Evento en el boton para ingresar al formulario de ingreso y control de permisos y vacaciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button10_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Debe Saeleccionar año");
            }
            else
            {
                Vacaciones v = new Vacaciones(comboBox1.Text);
                //control MDI
                v.textBox2.Text = textBox1.Text;
                v.MdiParent = Principal.ActiveForm;
                v.Show();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Calendario cal = new Calendario();
            cal.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PlanosEsamV2cs d = new PlanosEsamV2cs();
       
            d.Show();
         /*   
            Eplano d = new Eplano();
            d.MdiParent = Principal.ActiveForm;
            d.Show();
          * */
           // Prueba p = new Prueba();
           // p.Show();
        }



        private void button1_Click_2(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Privilegios pri = new Privilegios();
            pri.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            PlanosEsamV2cs d = new PlanosEsamV2cs();
            d.button2.Enabled = false;
            d.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            PanelDeNoConformidades panel = new PanelDeNoConformidades();
            //control MDI           
            panel.MdiParent = Principal.ActiveForm;
            panel.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://esamltda.cl//");
        }
    }
}
