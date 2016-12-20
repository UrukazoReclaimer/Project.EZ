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
               listBox1.Text = Convert.ToString(listBox1.SelectedValue);
            listBox1.SelectedIndex = listBox1.FindString(listBox1.Text);
            for (int i = listBox1.Items.Count - 1; i >= 0; i--)
            {
                pm.listBox1.Items.Add(listBox1.Text);

                if (listBox1.SelectedIndex < listBox1.Items.Count - 1)
                {
                    listBox1.SelectedIndex = listBox1.SelectedIndex + 1;

                }
                else
                {
                    listBox1.SelectedIndex = listBox1.SelectedIndex;
                }
            }
            pm.MdiParent = Form1.ActiveForm;
            pm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PeriodicidadSemanal pse = new PeriodicidadSemanal();
         
            pse.comboBox1.Text = textBox1.Text;
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
            pse.MdiParent = Form1.ActiveForm;
            pse.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PeriocidadQuincenal pq = new PeriocidadQuincenal();
            pq.comboBox1.Text = textBox1.Text;
            pq.MdiParent = Form1.ActiveForm;
      
                pq.Show();
            
        }
        private void button4_Click(object sender, EventArgs e)
        {
            PeriodicidadTrimestral pt = new PeriodicidadTrimestral();
            pt.comboBox1.Text = textBox1.Text;
            pt.MdiParent = Form1.ActiveForm;
                pt.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PeriodicidadSemestral ps = new PeriodicidadSemestral();
            ps.comboBox1.Text = textBox1.Text;
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
            ps.MdiParent = Form1.ActiveForm;
            ps.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PeriodicidadAnual pa = new PeriodicidadAnual();
            pa.comboBox1.Text = textBox1.Text;
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
            pa.MdiParent = Form1.ActiveForm;
            pa.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PeriodicidadAsolicitud pas = new PeriodicidadAsolicitud();
            pas.comboBox1.Text = textBox1.Text;
            pas.MdiParent = Form1.ActiveForm;
            pas.Show();
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
      
            pu.MdiParent = Form1.ActiveForm;
            pu.Show();
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            PeriodicidadBimensual pb = new PeriodicidadBimensual();
            pb.comboBox31.Text = textBox1.Text;

            listBox1.Text = Convert.ToString(listBox1.SelectedValue);
            listBox1.SelectedIndex = listBox1.FindString(listBox1.Text);



            pb.MdiParent = Form1.ActiveForm;
            pb.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
           
            PeriodicidadTrimensual tri = new PeriodicidadTrimensual();
            tri.comboBox109.Text = textBox1.Text;
            tri.MdiParent = Form1.ActiveForm;
            tri.Show();
        }
    }
}
