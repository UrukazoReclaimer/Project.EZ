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

namespace Project.Esampm
{
    public partial class RDispositivo : Form
    {
        List<int> list = new List<int>();
        public RDispositivo()
        {
            InitializeComponent();
        }

        private void RDispositivo_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {



            comboBox1.Text = Convert.ToString(comboBox1.SelectedValue);
            comboBox1.SelectedIndex = comboBox1.FindString(comboBox1.Text);
            int aux = comboBox1.SelectedIndex;
            int indexo = Convert.ToInt32(comboBox1.SelectedValue);
            for (int i = comboBox1.Items.Count - 1; i >= 0; i--)
            {


                comboBox1.SelectedValue = indexo;

                list.Add(indexo);
                indexo++;
            }

            CatalogoNota not = new CatalogoNota();
            int index1 = 0;
            int index = 0;
            string a = "";
            a = list[index].ToString();





            for (int i = comboBox1.Items.Count - 1; i >= 0; i--)
            {
                a = "";
                a = list[index].ToString();

                Nota n = new Nota(comboBox1.Text, textBox1.Text, "Cliente---");

                not.addNota(n);
                if (index1 < comboBox1.Items.Count - 1)
                {

                    index1++;
                    index++;
                }
                else
                {
                    index1 = index1;
                }

            }
            MessageBox.Show("Descripción Guardada");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            comboBox1.Text = Convert.ToString(comboBox1.SelectedValue);
            comboBox1.SelectedIndex = comboBox1.FindString(comboBox1.Text);
            int aux = comboBox1.SelectedIndex;
            int indexo = Convert.ToInt32(comboBox1.SelectedValue);
            for (int i = comboBox1.Items.Count - 1; i >= 0; i--)
            {


                comboBox1.SelectedValue = indexo;
                //comboBox4.Items.Add(index);
                list.Add(indexo);
                indexo++;
            }

            CatalogoNota not = new CatalogoNota();
            int index1 = 0;
            int index = 0;
            string a = "";
            a = list[index].ToString();





            for (int i = comboBox1.Items.Count - 1; i >= 0; i--)
            {
                a = "";
                a = list[index].ToString();

                Nota n = new Nota(comboBox1.Text, textBox1.Text, "Empresa---");

                not.addNota(n);
                if (index1 < comboBox1.Items.Count - 1)
                {

                    index1++;
                    index++;
                }
                else
                {
                    index1 = index1;
                }

            }
            MessageBox.Show("Descrpción Guardada");
            this.Close();

        }
    }
}
