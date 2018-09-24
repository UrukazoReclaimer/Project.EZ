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
    public partial class PeriodicidadBimensual : Form
    {
        Boolean registro = false;
        List<int> list = new List<int>();
        List<int> list1 = new List<int>();
        List<int> list2 = new List<int>();
        List<int> list3 = new List<int>();
        List<int> list4 = new List<int>();
        List<int> list5 = new List<int>();
        List<int> list6 = new List<int>();

        List<string> lista = new List<string>();
        List<string> lista1 = new List<string>();
        List<string> lista2 = new List<string>();
        List<string> lista3 = new List<string>();
        List<string> lista4 = new List<string>();
        List<string> lista5 = new List<string>();
        List<string> lista6 = new List<string>();
        public PeriodicidadBimensual()
        {
            InitializeComponent();


            catalogoTecnico tunits = new catalogoTecnico();
            List<Project.BussinessRules.Tecnico> tec = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec1 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec2 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec3 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec4 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec5 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec6 = tunits.obtenertec();

            this.comboBox1.DataSource = tec;
            this.comboBox1.DisplayMember = "nombre";
            this.comboBox1.ValueMember = "cod";
            this.comboBox2.DataSource = tec1;
            this.comboBox2.DisplayMember = "nombre";
            this.comboBox2.ValueMember = "cod";
            this.comboBox3.DataSource = tec2;
            this.comboBox3.DisplayMember = "nombre";
            this.comboBox3.ValueMember = "cod";
            this.comboBox4.DataSource = tec3;
            this.comboBox4.DisplayMember = "nombre";
            this.comboBox4.ValueMember = "cod";
            this.comboBox5.DataSource = tec4;
            this.comboBox5.DisplayMember = "nombre";
            this.comboBox5.ValueMember = "cod";
            this.comboBox6.DataSource = tec5;
            this.comboBox6.DisplayMember = "nombre";
            this.comboBox6.ValueMember = "cod";

            CatalogoServicios sunits = new CatalogoServicios();
            List<Project.BussinessRules.servicio> ser = sunits.getser();
            List<Project.BussinessRules.servicio> ser1 = sunits.getser();
            List<Project.BussinessRules.servicio> ser2 = sunits.getser();
            List<Project.BussinessRules.servicio> ser3 = sunits.getser();
            List<Project.BussinessRules.servicio> ser4 = sunits.getser();
            List<Project.BussinessRules.servicio> ser5 = sunits.getser();



            this.comboBox7.DataSource = ser;
            this.comboBox7.DisplayMember = "sigla";
            this.comboBox7.ValueMember = "cod";
            this.comboBox8.DataSource = ser1;
            this.comboBox8.DisplayMember = "sigla";
            this.comboBox8.ValueMember = "cod";
            this.comboBox9.DataSource = ser2;
            this.comboBox9.DisplayMember = "sigla";
            this.comboBox9.ValueMember = "cod";
            this.comboBox10.DataSource = ser3;
            this.comboBox10.DisplayMember = "sigla";
            this.comboBox10.ValueMember = "cod";
            this.comboBox11.DataSource = ser4;
            this.comboBox11.DisplayMember = "sigla";
            this.comboBox11.ValueMember = "cod";
            this.comboBox12.DataSource = ser5;
            this.comboBox12.DisplayMember = "sigla";
            this.comboBox12.ValueMember = "cod";

            CatalogoArea aunits = new CatalogoArea();
            List<Area> are = aunits.getarea();
            List<Area> are1 = aunits.getarea();
            List<Area> are2 = aunits.getarea();
            List<Area> are3 = aunits.getarea();
            List<Area> are4 = aunits.getarea();
            List<Area> are5 = aunits.getarea();
            List<Area> are6 = aunits.getarea();

            this.comboBox19.DataSource = are;
            this.comboBox19.DisplayMember = "NombreArea";
            this.comboBox19.ValueMember = "cod";
            this.comboBox20.DataSource = are1;
            this.comboBox20.DisplayMember = "NombreArea";
            this.comboBox20.ValueMember = "cod";
            this.comboBox21.DataSource = are2;
            this.comboBox21.DisplayMember = "NombreArea";
            this.comboBox21.ValueMember = "cod";
            this.comboBox22.DataSource = are3;
            this.comboBox22.DisplayMember = "NombreArea";
            this.comboBox22.ValueMember = "cod";
            this.comboBox23.DataSource = are4;
            this.comboBox23.DisplayMember = "NombreArea";
            this.comboBox23.ValueMember = "cod";
            this.comboBox24.DataSource = are5;
            this.comboBox24.DisplayMember = "NombreArea";
            this.comboBox24.ValueMember = "cod";
            registro = true;
        }

        private void PeriodicidadBimensual_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            DateTime fecha = new DateTime();
            int day = fecha.Day;
            int month = fecha.Month;
            int year = Convert.ToInt32(textBox2.Text);
            dateTimePicker1.Value = new DateTime(year, month, day);


            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "dd-MM-yyyy";
            dateTimePicker4.Format = DateTimePickerFormat.Custom;
            dateTimePicker4.CustomFormat = "dd-MM-yyyy";
            dateTimePicker5.Format = DateTimePickerFormat.Custom;
            dateTimePicker5.CustomFormat = "dd-MM-yyyy";
            dateTimePicker6.Format = DateTimePickerFormat.Custom;
            dateTimePicker6.CustomFormat = "dd-MM-yyyy";        
            dateTimePicker2.Value = new DateTime(year, 3, day);
            dateTimePicker3.Value = new DateTime(year, 5, day);
            dateTimePicker4.Value = new DateTime(year, 7, day);
            dateTimePicker5.Value = new DateTime(year, 9, day);
            dateTimePicker6.Value = new DateTime(year, 11, day);
           
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox7.SelectedValue);
                comboBox7.SelectedValue = index;


                comboBox13.Items.Add(comboBox7.Text);
              
                list.Add(index);
            }
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox8.SelectedValue);
                comboBox8.SelectedValue = index;


                comboBox14.Items.Add(comboBox8.Text);
              
                list1.Add(index);
            }
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox9.SelectedValue);
                comboBox9.SelectedValue = index;


                comboBox15.Items.Add(comboBox9.Text);
              
                list2.Add(index);
            }
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox10.SelectedValue);
                comboBox10.SelectedValue = index;


                comboBox16.Items.Add(comboBox10.Text);
              
                list3.Add(index);
            }
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox11.SelectedValue);
                comboBox11.SelectedValue = index;


                comboBox17.Items.Add(comboBox11.Text);
              
                list4.Add(index);
            }
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox12.SelectedValue);
                comboBox12.SelectedValue = index;


                comboBox18.Items.Add(comboBox12.Text);
              
                list5.Add(index);
            }
        }

        private void comboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                comboBox25.Text = comboBox19.Text;
                string b = comboBox25.Text;
                comboBox25.Items.Add(comboBox19.Text);              
                lista.Add(comboBox25.Text);
            }
        }

        private void comboBox20_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                comboBox26.Text = comboBox20.Text;
                string b = comboBox26.Text;
                comboBox26.Items.Add(comboBox20.Text);

              
                lista1.Add(comboBox26.Text);
            }
        }

        private void comboBox21_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                comboBox27.Text = comboBox21.Text;
                string b = comboBox27.Text;
                comboBox27.Items.Add(comboBox21.Text);

                lista2.Add(comboBox27.Text);
            }
        }

        private void comboBox22_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {


                comboBox28.Text = comboBox22.Text;
                string b = comboBox28.Text;
                comboBox28.Items.Add(comboBox22.Text);



                lista3.Add(comboBox28.Text);
            }
        }

        private void comboBox23_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {


                comboBox29.Text = comboBox23.Text;
                string b = comboBox29.Text;
                comboBox29.Items.Add(comboBox23.Text);



                lista4.Add(comboBox29.Text);
            }
        }

        private void comboBox24_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {


                comboBox30.Text = comboBox24.Text;
                string b = comboBox29.Text;
                comboBox30.Items.Add(comboBox24.Text);

                lista5.Add(comboBox30.Text);
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            if (dateTimePicker1.Value.Date <= DateTime.Now ||
                dateTimePicker2.Value.Date <= DateTime.Now ||
                dateTimePicker3.Value.Date <= DateTime.Now ||
                dateTimePicker4.Value.Date <= DateTime.Now ||
                dateTimePicker5.Value.Date <= DateTime.Now ||
                dateTimePicker6.Value.Date <= DateTime.Now)
            {
                MessageBox.Show("No se puede guardar fechas anteriores a la fecha actual");


            }
            else
            {
            */
             
                if (MessageBox.Show("¿Verifico la fechas a guardar?", "ATENCION",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                   == DialogResult.Yes)
                {
                    CatalogoPlanilla ca = new CatalogoPlanilla();
                    List<Periodicidad> lu = ca.getcodfech();
                    this.comboBox31.DataSource = lu;
                    this.comboBox31.DisplayMember = "lugartratamiento";
                   
                    this.comboBox31.ValueMember = "cod";

                 

                    int index = 0;
                 




                    index = 0;
                  

                    for (int j = list3.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list3[index].ToString();
                        if (lista3.Count != 0)
                        {
                           
                                dateTimePicker4.Format = DateTimePickerFormat.Custom;
                              
                                dateTimePicker4.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = string.Join(",", lista3.ToArray());
                                Periodicidad pla = new Periodicidad(dateTimePicker4.Text, Convert.ToInt32(comboBox31.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox4.SelectedValue), b, "", 0, "B", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                             
                        
                            index++;

                        }
                        else
                        {
                            dateTimePicker4.Format = DateTimePickerFormat.Custom;
                          
                            dateTimePicker4.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker4.Text, Convert.ToInt32(comboBox31.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox4.SelectedValue), "N/A", "", 0, "B", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                         
                            index++;
                        }


                    }
                    index = 0;
                


                    for (int j = list4.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list4[index].ToString();
                        if (lista4.Count != 0)
                        {
                            
                                dateTimePicker5.Format = DateTimePickerFormat.Custom;
                              
                                dateTimePicker5.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = string.Join(",", lista4.ToArray());
                                Periodicidad pla = new Periodicidad(dateTimePicker5.Text, Convert.ToInt32(comboBox31.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox5.SelectedValue), b, "", 0, "B", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                             
                             
                            index++;

                        }
                        else
                        {
                            dateTimePicker5.Format = DateTimePickerFormat.Custom;
                          
                            dateTimePicker5.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker5.Text, Convert.ToInt32(comboBox31.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox5.SelectedValue), "N/A", "", 0, "B", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                        
                            index++;
                        }
                    }

                    index = 0;
                  


                    for (int j = list5.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list5[index].ToString();
                        if (lista5.Count != 0)
                        {
                          
                                dateTimePicker6.Format = DateTimePickerFormat.Custom;
                              
                                dateTimePicker6.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = string.Join(",", lista5.ToArray());
                                Periodicidad pla = new Periodicidad(dateTimePicker6.Text, Convert.ToInt32(comboBox31.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox6.SelectedValue), b, "", 0, "B", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                             
                            
                            index++;

                        }
                        else
                        {
                            dateTimePicker6.Format = DateTimePickerFormat.Custom;
                          
                            dateTimePicker6.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker6.Text, Convert.ToInt32(comboBox31.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox6.SelectedValue), "N/A", "", 0, "B", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                            
                            index++;
                        }
                    }
                    index = 0;
                   
                    planificar(list, lista, comboBox31, dateTimePicker1, comboBox1);
                    planificar(list1, lista1, comboBox31, dateTimePicker2, comboBox2);
                    planificar(list2, lista2, comboBox31, dateTimePicker3, comboBox3);

                }
                MessageBox.Show("Ingeso Completado");
         //  }
            this.Close();
             
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void planificar(List<int> listser, List<string> listarea, ComboBox c1, DateTimePicker fecha, ComboBox tec)
        {
            
            CatalogoPlanilla ca = new CatalogoPlanilla();
            List<Periodicidad> lu = ca.getcodfech();
            c1.DataSource = lu;
            c1.DisplayMember = "lugartratamiento";
         
            c1.ValueMember = "cod";

       
        
            int index = 0;
          
         
            for (int j = listser.Count - 1; j >= 0; j--)
            {

                string a = "";
                a = listser[index].ToString();
                if (listarea.Count != 0)
                {

                    fecha.Format = DateTimePickerFormat.Custom;

                    fecha.CustomFormat = "yyyy-MM-dd";
                    string b = "";
                    b = string.Join(",", listarea.ToArray());
                    Periodicidad pla = new Periodicidad(fecha.Text, Convert.ToInt32(c1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(tec.SelectedValue), b, "", 0, "B", "P", "", "Primario", "", "");
                    ca.addfecha(pla);


                    index++;
                }
                else
                {
                    fecha.Format = DateTimePickerFormat.Custom;

                    fecha.CustomFormat = "yyyy-MM-dd";
                    Periodicidad pla = new Periodicidad(fecha.Text, Convert.ToInt32(c1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(tec.SelectedValue), "N/A", "", 0, "B", "P", "", "Primario", "", "");
                    ca.addfecha(pla);

                    index++;

                }
            }

             
        }
          
        }

    }

