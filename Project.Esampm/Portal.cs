using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.BussinessRules;
namespace Project.Esampm
{
    public partial class Portal : Form
    {
        public Portal()
        {
            InitializeComponent();
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            CatalogoUsuario ca1= new CatalogoUsuario();
            List<Usuario> la3 = ca1.COMusuario(textBox1.Text, textBox2.Text);
            this.comboBox1.DataSource = la3;
            this.comboBox1.DisplayMember = "cod";
            this.comboBox1.ValueMember = "cod";

            CatalogoUsuario ca = new CatalogoUsuario();
            List<Usuario> la = ca.COMnivel(textBox1.Text, textBox2.Text);
            this.comboBox3.DataSource = la;
            this.comboBox3.DisplayMember = "Nivel";
            this.comboBox3.ValueMember = "Nivel";

          

            if (comboBox1.Text != "")
            {
                Entrada pla = new Entrada();
                //control MDI
                pla.MdiParent = Principal.ActiveForm;
                pla.comboBox1.Text=textBox3.Text ;
                pla.textBox1.Text = comboBox3.Text;
                pla.Show();
         
                if (comboBox3.Text == "Usuario_Plano" || comboBox3.Text == "Obs")
                {
                    pla.button4.Enabled = false;
                    pla.button1.Enabled = false;
                    pla.button10.Enabled = false;
                    pla.button12.Enabled = false;
                    pla.textBox1.Text = comboBox3.Text;
                }
                if (comboBox3.Text == "Usuario_Planificacion")
                {
                    pla.button4.Enabled = false;
                    pla.button1.Enabled = false;
                    pla.textBox1.Text = comboBox3.Text;
                   
                }
              
            }
            else {

                MessageBox.Show("Contraseña incorrecta");
            }

            comboBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                CatalogoUsuario ca1 = new CatalogoUsuario();
                List<Usuario> la3 = ca1.COMusuario(textBox1.Text, textBox2.Text);
                this.comboBox1.DataSource = la3;
                this.comboBox1.DisplayMember = "cod";
                this.comboBox1.ValueMember = "cod";

                CatalogoUsuario ca = new CatalogoUsuario();
                List<Usuario> la = ca.COMnivel(textBox1.Text, textBox2.Text);
                this.comboBox3.DataSource = la;
                this.comboBox3.DisplayMember = "Nivel";
                this.comboBox3.ValueMember = "Nivel";

                if (comboBox1.Text != "")
                {
                    Entrada pla = new Entrada();
                    //control MDI

                    pla.MdiParent = Principal.ActiveForm;
                    pla.comboBox1.Text = textBox3.Text;
                    pla.textBox1.Text = comboBox3.Text;
                    pla.Show();
                   
                  
                    if (comboBox3.Text == "Usuario_Plano" || comboBox3.Text == "Obs")
                    {
                        pla.button4.Enabled = false;
                        pla.button1.Enabled = false;
                        pla.button10.Enabled = false;
                        pla.button12.Enabled = false;
                        pla.comboBox1.Text = textBox3.Text;
                    }
                    if (comboBox3.Text == "Usuario_Planificacion")
                    {
                        pla.button4.Enabled = false;
                        pla.button1.Enabled = false;
                        pla.comboBox1.Text = textBox3.Text;

                    }

                }
                else
                {

                    MessageBox.Show("Contraseña incorrecta");
                }

                comboBox1.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";

            }
        }

     
    }
}
