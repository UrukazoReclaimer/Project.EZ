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
    public partial class TableroPeriodicidad : Form
    {
        public TableroPeriodicidad()
        {
            InitializeComponent();
        }

        private void TableroPeriodicidad_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PeriocidadMensual pm = new PeriocidadMensual();
            pm.comboBox1.Text = textBox1.Text;
            pm.textBox2.Text = textBox2.Text;
               listBox1.Text = Convert.ToString(listBox1.SelectedValue);
            listBox1.SelectedIndex = listBox1.FindString(listBox1.Text);
            for (int i = listBox1.Items.Count - 1; i >= 0; i--)
            {
               

                if (listBox1.SelectedIndex < listBox1.Items.Count - 1)
                {
                    listBox1.SelectedIndex = listBox1.SelectedIndex + 1;

                }
                else
                {
                    listBox1.SelectedIndex = listBox1.SelectedIndex;
                }
            }
            pm.MdiParent = Principal.ActiveForm;
            pm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PeriodicidadSemanal pse = new PeriodicidadSemanal();          
            pse.comboBox1.Text = textBox1.Text;
            pse.textBox1.Text = textBox2.Text;
            listBox1.Text = Convert.ToString(listBox1.SelectedValue);
            listBox1.SelectedIndex = listBox1.FindString(listBox1.Text);
            for (int i = listBox1.Items.Count - 1; i >= 0; i--)
            {
                pse.listBox1.Items.Add(listBox1.Text);

                if (listBox1.SelectedIndex < listBox1.Items.Count - 1)
                {
                    listBox1.SelectedIndex = listBox1.SelectedIndex + 1;

                }
                else
                {
                    listBox1.SelectedIndex = listBox1.SelectedIndex;
                }
            }
            pse.MdiParent = Principal.ActiveForm;
            pse.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PeriocidadQuincenal pq = new PeriocidadQuincenal();
            pq.textBox2.Text = textBox2.Text;
            pq.comboBox1.Text = textBox1.Text;
            pq.MdiParent = Principal.ActiveForm;
      
                pq.Show();
                this.Close();
            
        }
        private void button4_Click(object sender, EventArgs e)
        {
            PeriodicidadTrimestral pt = new PeriodicidadTrimestral();
            pt.comboBox1.Text = textBox1.Text;
            pt.textBox2.Text = textBox2.Text;
            pt.MdiParent = Principal.ActiveForm;
                pt.Show();
                this.Close();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PeriodicidadSemestral ps = new PeriodicidadSemestral();
            ps.comboBox1.Text = textBox1.Text;
            ps.textBox2.Text = textBox2.Text;
            listBox1.Text = Convert.ToString(listBox1.SelectedValue);
            listBox1.SelectedIndex = listBox1.FindString(listBox1.Text);
            for (int i = listBox1.Items.Count-1; i >= 0; i--)
            {
                ps.listBox1.Items.Add(listBox1.Text);

                if (listBox1.SelectedIndex < listBox1.Items.Count - 1)
                {
                    listBox1.SelectedIndex = listBox1.SelectedIndex + 1;

                }
                else
                {
                    listBox1.SelectedIndex = listBox1.SelectedIndex;
                }
            }
            ps.MdiParent = Principal.ActiveForm;
            ps.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PeriodicidadAnual pa = new PeriodicidadAnual();
            pa.comboBox1.Text = textBox1.Text;
            pa.textBox2.Text = textBox2.Text;
            listBox1.Text = Convert.ToString(listBox1.SelectedValue);
            listBox1.SelectedIndex = listBox1.FindString(listBox1.Text);
            for (int i = listBox1.Items.Count - 1; i >= 0; i--)
            {
                pa.listBox1.Items.Add(listBox1.Text);

                if (listBox1.SelectedIndex < listBox1.Items.Count - 1)
                {
                    listBox1.SelectedIndex = listBox1.SelectedIndex + 1;

                }
                else
                {
                    listBox1.SelectedIndex = listBox1.SelectedIndex;
                }
            }
            pa.MdiParent = Principal.ActiveForm;
            pa.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PeriodicidadAsolicitud pas = new PeriodicidadAsolicitud();
            pas.comboBox1.Text = textBox1.Text;
            pas.textBox3.Text = textBox2.Text;
            pas.MdiParent = Principal.ActiveForm;
            pas.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PeriodicidadUnicaVez pu = new PeriodicidadUnicaVez();
            pu.comboBox1.Text = textBox1.Text;
            pu.textBox2.Text = textBox2.Text;
            listBox1.Text = Convert.ToString(listBox1.SelectedValue);
            listBox1.SelectedIndex = listBox1.FindString(listBox1.Text);
            for (int i = listBox1.Items.Count - 1; i >= 0; i--)
            {
                pu.listBox1.Items.Add(listBox1.Text);

                if (listBox1.SelectedIndex < listBox1.Items.Count - 1)
                {
                    listBox1.SelectedIndex = listBox1.SelectedIndex + 1;

                }
                else
                {
                    listBox1.SelectedIndex = listBox1.SelectedIndex;
                }



            }
      
            pu.MdiParent = Principal.ActiveForm;
            pu.Show();
            this.Close();
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            PeriodicidadBimensual pb = new PeriodicidadBimensual();
            pb.comboBox31.Text = textBox1.Text;
            pb.textBox2.Text = textBox2.Text;
            listBox1.Text = Convert.ToString(listBox1.SelectedValue);
            listBox1.SelectedIndex = listBox1.FindString(listBox1.Text);



            pb.MdiParent = Principal.ActiveForm;
            pb.Show();
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
           
            PeriodicidadTrimensual tri = new PeriodicidadTrimensual();
            tri.comboBox109.Text = textBox1.Text;
            tri.textBox1.Text = textBox2.Text;
            tri.MdiParent = Principal.ActiveForm;
            tri.Show();
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            LDD ldd = new LDD();
            ldd.Show();
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            periodicidadDemoliciones pt = new periodicidadDemoliciones();
            pt.comboBox1.Text = textBox1.Text;
            pt.textBox2.Text = textBox2.Text;
            pt.MdiParent = Principal.ActiveForm;
            pt.Show();
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            IngresarAuditoria pu = new IngresarAuditoria();
            pu.comboBox1.Text = textBox1.Text;
            pu.textBox2.Text = textBox2.Text;
        
            pu.MdiParent = Principal.ActiveForm;
            pu.Show();
            this.Close();
         
        }
        }
    }

