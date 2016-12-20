﻿using Project.BussinessRules;
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
    public partial class PeriodicidadTrimestral : Form
    {
        Boolean registro = false;
        List<int> list = new List<int>();
        List<int> list1 = new List<int>();
        List<int> list2 = new List<int>();
        List<int> list3 = new List<int>();

        List<int> lista = new List<int>();
        List<int> lista1 = new List<int>();
        List<int> lista2 = new List<int>();
        List<int> lista3 = new List<int>();
        public PeriodicidadTrimestral()
        {
            InitializeComponent();


            catalogoTecnico tunits = new catalogoTecnico();
            List<Project.BussinessRules.Tecnico> tec = tunits.gettec();
            List<Project.BussinessRules.Tecnico> tec1 = tunits.gettec();
            List<Project.BussinessRules.Tecnico> tec2 = tunits.gettec();
            List<Project.BussinessRules.Tecnico> tec3 = tunits.gettec();
            this.comboBox2.DataSource = tec;
            this.comboBox2.DisplayMember = "nombre";
            this.comboBox2.ValueMember = "cod";
            this.comboBox4.DataSource = tec1;
            this.comboBox4.DisplayMember = "nombre";
            this.comboBox4.ValueMember = "cod";
            this.comboBox6.DataSource = tec2;
            this.comboBox6.DisplayMember = "nombre";
            this.comboBox6.ValueMember = "cod";
            this.comboBox8.DataSource = tec3;
            this.comboBox8.DisplayMember = "nombre";
            this.comboBox8.ValueMember = "cod";

            CatalogoServicios sunits = new CatalogoServicios();
            List<Project.BussinessRules.servicio> ser = sunits.getser();
            List<Project.BussinessRules.servicio> ser1 = sunits.getser();
            List<Project.BussinessRules.servicio> ser2 = sunits.getser();
            List<Project.BussinessRules.servicio> ser3 = sunits.getser();
            this.comboBox3.DataSource = ser;
            this.comboBox3.DisplayMember = "sigla";
            this.comboBox3.ValueMember = "cod";
            this.comboBox5.DataSource = ser1;
            this.comboBox5.DisplayMember = "sigla";
            this.comboBox5.ValueMember = "cod";
            this.comboBox7.DataSource = ser2;
            this.comboBox7.DisplayMember = "sigla";
            this.comboBox7.ValueMember = "cod";
            this.comboBox9.DataSource = ser3;
            this.comboBox9.DisplayMember = "sigla";
            this.comboBox9.ValueMember = "cod";



            CatalogoArea aunits = new CatalogoArea();
            List<Area> are = aunits.getarea();
            List<Area> are1 = aunits.getarea();
            List<Area> are2 = aunits.getarea();
            List<Area> are3 = aunits.getarea();

            this.comboBox12.DataSource = are;
            this.comboBox12.DisplayMember = "NombreArea";
            this.comboBox12.ValueMember = "cod";
            this.comboBox15.DataSource = are1;
            this.comboBox15.DisplayMember = "NombreArea";
            this.comboBox15.ValueMember = "cod";
            this.comboBox17.DataSource = are2;
            this.comboBox17.DisplayMember = "NombreArea";
            this.comboBox17.ValueMember = "cod";
            this.comboBox20.DataSource = are3;
            this.comboBox20.DisplayMember = "NombreArea";
            this.comboBox20.ValueMember = "cod";
            registro = true;





        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void PeriodicidadTrimestral_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            CatalogoPlanilla ca = new CatalogoPlanilla();
            List<Periodicidad> lu = ca.getcodfech();
            this.comboBox1.DataSource = lu;
            this.comboBox1.DisplayMember = "lugartratamiento";

            this.comboBox1.ValueMember = "cod";



        }

        private void button2_Click(object sender, EventArgs e)
        {

            CatalogoPlanilla ca = new CatalogoPlanilla();
            List<Periodicidad> lu = ca.getcodfech();
            this.comboBox1.DataSource = lu;
            this.comboBox1.DisplayMember = "lugartratamiento";

            this.comboBox1.ValueMember = "cod";





        }

        private void button5_Click(object sender, EventArgs e)
        {

            CatalogoPlanilla ca = new CatalogoPlanilla();
            List<Periodicidad> lu = ca.getcodfech();
            this.comboBox1.DataSource = lu;
            this.comboBox1.DisplayMember = "lugartratamiento";

            this.comboBox1.ValueMember = "cod";




        }

        private void button7_Click(object sender, EventArgs e)
        {

            CatalogoPlanilla ca = new CatalogoPlanilla();
            List<Periodicidad> lu = ca.getcodfech();
            this.comboBox1.DataSource = lu;
            this.comboBox1.DisplayMember = "lugartratamiento";

            this.comboBox1.ValueMember = "cod";




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (dateTimePicker4.Value.Date <= DateTime.Now || dateTimePicker3.Value.Date <= DateTime.Now || dateTimePicker2.Value.Date <= DateTime.Now || dateTimePicker1.Value.Date <= DateTime.Now)
            {
                MessageBox.Show("No se puede guardar fechas anteriores a la fecha actual");


            }
            else
            {
             
            
                if (MessageBox.Show("Verifico la fechas a guardar?", "ATENCION",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                  == DialogResult.Yes)
                {
                    CatalogoPlanilla ca = new CatalogoPlanilla();
                    List<Periodicidad> lu = ca.getcodfech();
                    this.comboBox1.DataSource = lu;
                    this.comboBox1.DisplayMember = "lugartratamiento";

                    this.comboBox1.ValueMember = "cod";




                    int index = 0;
                    int index1 = 0;

                    for (int j = list3.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list3[index].ToString();
                        if (lista3.Count != 0)
                        {
                            for (int i = lista3.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker1.Format = DateTimePickerFormat.Custom;

                                dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista3[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker1.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox8.SelectedValue), Convert.ToInt32(b), "", 0, "TMT", "P", "");
                                ca.addfecha(pla);

                                if (index1 < lista3.Count - 1)
                                {

                                    index1++;
                                }
                                else
                                {
                                    index1 = index1;
                                }


                            }
                            index1 = 0;
                            index++;
                        }
                        else
                        {
                            dateTimePicker1.Format = DateTimePickerFormat.Custom;

                            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker1.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox8.SelectedValue), 30, "", 0, "TMT", "P", "");
                            ca.addfecha(pla);
                        }
                    }
                    index = 0;
                    index1 = 0;


                    for (int j = list2.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list2[index].ToString();
                        if (lista2.Count != 0)
                        {
                            for (int i = lista2.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker2.Format = DateTimePickerFormat.Custom;

                                dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista2[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker2.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox6.SelectedValue), Convert.ToInt32(b), "", 0, "TMT", "P", "");
                                ca.addfecha(pla);

                                if (index1 < lista2.Count - 1)
                                {

                                    index1++;
                                }
                                else
                                {
                                    index1 = index1;
                                }


                            }
                            index1 = 0;
                            index++;
                        }
                        else
                        {
                            dateTimePicker2.Format = DateTimePickerFormat.Custom;

                            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker2.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox6.SelectedValue), 30, "", 0, "TMT", "P", "");
                            ca.addfecha(pla);
                        }
                    }
                    index = 0;
                    index1 = 0;





                    for (int j = list.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list[index].ToString();
                        if (lista.Count != 0)
                        {
                            for (int i = lista.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker4.Format = DateTimePickerFormat.Custom;

                                dateTimePicker4.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker4.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(b), "", 0, "TMT", "P", "");
                                ca.addfecha(pla);

                                if (index1 < lista.Count - 1)
                                {

                                    index1++;
                                }
                                else
                                {
                                    index1 = index1;
                                }


                            }
                            index1 = 0;
                            index++;
                        }
                        else
                        {
                            dateTimePicker4.Format = DateTimePickerFormat.Custom;

                            dateTimePicker4.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker4.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox2.SelectedValue), 30, "", 0, "TMT", "P", "");
                            ca.addfecha(pla);
                        }
                    }
                    index = 0;
                    index1 = 0;



                    for (int j = list1.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list1[index].ToString();
                        if (lista1.Count != 0)
                        {
                            for (int i = lista1.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker3.Format = DateTimePickerFormat.Custom;

                                dateTimePicker3.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista1[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker3.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox4.SelectedValue), Convert.ToInt32(b), "", 0, "TMT", "P", "");
                                ca.addfecha(pla);

                                if (index1 < lista1.Count - 1)
                                {

                                    index1++;
                                }
                                else
                                {
                                    index1 = index1;
                                }


                            }
                            index1 = 0;
                            index++;
                        }
                        else
                        {
                            dateTimePicker3.Format = DateTimePickerFormat.Custom;

                            dateTimePicker3.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker3.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox4.SelectedValue), 30, "", 0, "TMT", "P", "");
                            ca.addfecha(pla);
                        }
                    }
                    index = 0;
                    index1 = 0;

                }
                MessageBox.Show("Ingreso Completado");
                this.Close();
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox3.SelectedValue);
                comboBox3.SelectedValue = index;


                comboBox11.Items.Add(comboBox3.Text);

                list.Add(index);
            }
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox12.SelectedValue);
                comboBox12.SelectedValue = index;


                comboBox13.Items.Add(comboBox12.Text);

                lista.Add(index);
            }
        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox15.SelectedValue);
                comboBox15.SelectedValue = index;


                comboBox14.Items.Add(comboBox15.Text);

                lista1.Add(index);
            }
        }

        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox17.SelectedValue);
                comboBox17.SelectedValue = index;


                comboBox18.Items.Add(comboBox17.Text);

                lista2.Add(index);
            }
        }

        private void comboBox20_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox20.SelectedValue);
                comboBox20.SelectedValue = index;


                comboBox21.Items.Add(comboBox20.Text);

                lista3.Add(index);
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox5.SelectedValue);
                comboBox5.SelectedValue = index;


                comboBox10.Items.Add(comboBox5.Text);

                list1.Add(index);
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox7.SelectedValue);
                comboBox7.SelectedValue = index;


                comboBox16.Items.Add(comboBox7.Text);

                list2.Add(index);
            }
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox9.SelectedValue);
                comboBox9.SelectedValue = index;


                comboBox19.Items.Add(comboBox9.Text);

                list3.Add(index);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}