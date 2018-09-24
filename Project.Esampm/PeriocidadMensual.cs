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
    public partial class PeriocidadMensual : Form
    {
        Boolean registro = false;
        Boolean registroArea = false;
        List<int> list = new List<int>();
        List<int> list1 = new List<int>();
        List<int> list2 = new List<int>();
        List<int> list3 = new List<int>();
        List<int> list4 = new List<int>();
        List<int> list5 = new List<int>();
        List<int> list6 = new List<int>();
        List<int> list7 = new List<int>();
        List<int> list8 = new List<int>();
        List<int> list9 = new List<int>();
        List<int> list10 = new List<int>();
        List<int> list11 = new List<int>();

        List<string> lista = new List<string>();
        List<string> lista1 = new List<string>();
        List<string> lista2 = new List<string>();
        List<string> lista3 = new List<string>();
        List<string> lista4 = new List<string>();
        List<string> lista5 = new List<string>();
        List<string> lista6 = new List<string>();
        List<string> lista7 = new List<string>();
        List<string> lista8 = new List<string>();
        List<string> lista9 = new List<string>();
        List<string> lista10 = new List<string>();
        List<string> lista11 = new List<string>();
        public PeriocidadMensual()
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
            List<Project.BussinessRules.Tecnico> tec7 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec8 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec9 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec10 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec11 = tunits.obtenertec();

            this.comboBox2.DataSource = tec;
            this.comboBox2.DisplayMember = "nombre";
            this.comboBox2.ValueMember = "cod";
            this.comboBox3.DataSource = tec1;
            this.comboBox3.DisplayMember = "nombre";
            this.comboBox3.ValueMember = "cod";
            this.comboBox4.DataSource = tec2;
            this.comboBox4.DisplayMember = "nombre";
            this.comboBox4.ValueMember = "cod";
            this.comboBox5.DataSource = tec3;
            this.comboBox5.DisplayMember = "nombre";
            this.comboBox5.ValueMember = "cod";
            this.comboBox6.DataSource = tec4;
            this.comboBox6.DisplayMember = "nombre";
            this.comboBox6.ValueMember = "cod";
            this.comboBox7.DataSource = tec5;
            this.comboBox7.DisplayMember = "nombre";
            this.comboBox7.ValueMember = "cod";
            this.comboBox8.DataSource = tec6;
            this.comboBox8.DisplayMember = "nombre";
            this.comboBox8.ValueMember = "cod";
            this.comboBox9.DataSource = tec7;
            this.comboBox9.DisplayMember = "nombre";
            this.comboBox9.ValueMember = "cod";
            this.comboBox10.DataSource = tec8;
            this.comboBox10.DisplayMember = "nombre";
            this.comboBox10.ValueMember = "cod";
            this.comboBox11.DataSource = tec9;
            this.comboBox11.DisplayMember = "nombre";
            this.comboBox11.ValueMember = "cod";
            this.comboBox12.DataSource = tec10;
            this.comboBox12.DisplayMember = "nombre";
            this.comboBox12.ValueMember = "cod";
            this.comboBox13.DataSource = tec11;
            this.comboBox13.DisplayMember = "nombre";
            this.comboBox13.ValueMember = "cod";

            CatalogoServicios sunits = new CatalogoServicios();
            List<Project.BussinessRules.servicio> ser = sunits.getser();
            List<Project.BussinessRules.servicio> ser1 = sunits.getser();
            List<Project.BussinessRules.servicio> ser2 = sunits.getser();
            List<Project.BussinessRules.servicio> ser3 = sunits.getser();
            List<Project.BussinessRules.servicio> ser4 = sunits.getser();
            List<Project.BussinessRules.servicio> ser5 = sunits.getser();
            List<Project.BussinessRules.servicio> ser6 = sunits.getser();
            List<Project.BussinessRules.servicio> ser7 = sunits.getser();
            List<Project.BussinessRules.servicio> ser8 = sunits.getser();
            List<Project.BussinessRules.servicio> ser9 = sunits.getser();
            List<Project.BussinessRules.servicio> ser10 = sunits.getser();
            List<Project.BussinessRules.servicio> ser11 = sunits.getser();
            List<Project.BussinessRules.servicio> ser12 = sunits.getser();

            this.comboBox14.DataSource = ser;
            this.comboBox14.DisplayMember = "sigla";
            this.comboBox14.ValueMember = "cod";
            this.comboBox15.DataSource = ser1;
            this.comboBox15.DisplayMember = "sigla";
            this.comboBox15.ValueMember = "cod";
            this.comboBox16.DataSource = ser2;
            this.comboBox16.DisplayMember = "sigla";
            this.comboBox16.ValueMember = "cod";
            this.comboBox17.DataSource = ser3;
            this.comboBox17.DisplayMember = "sigla";
            this.comboBox17.ValueMember = "cod";
            this.comboBox18.DataSource = ser4;
            this.comboBox18.DisplayMember = "sigla";
            this.comboBox18.ValueMember = "cod";
            this.comboBox19.DataSource = ser5;
            this.comboBox19.DisplayMember = "sigla";
            this.comboBox19.ValueMember = "cod";
            this.comboBox20.DataSource = ser6;
            this.comboBox20.DisplayMember = "sigla";
            this.comboBox20.ValueMember = "cod";
            this.comboBox21.DataSource = ser7;
            this.comboBox21.DisplayMember = "sigla";
            this.comboBox21.ValueMember = "cod";
            this.comboBox22.DataSource = ser8;
            this.comboBox22.DisplayMember = "sigla";
            this.comboBox22.ValueMember = "cod";
            this.comboBox23.DataSource = ser9;
            this.comboBox23.DisplayMember = "sigla";
            this.comboBox23.ValueMember = "cod";
            this.comboBox24.DataSource = ser10;
            this.comboBox24.DisplayMember = "sigla";
            this.comboBox24.ValueMember = "cod";
            this.comboBox25.DataSource = ser11;
            this.comboBox25.DisplayMember = "sigla";
            this.comboBox25.ValueMember = "cod";

            CatalogoArea aunits = new CatalogoArea();
            List<Area> are = aunits.getarea();
            List<Area> are1 = aunits.getarea();
            List<Area> are2 = aunits.getarea();
            List<Area> are3 = aunits.getarea();
            List<Area> are4 = aunits.getarea();
            List<Area> are5 = aunits.getarea();
            List<Area> are6 = aunits.getarea();
            List<Area> are7 = aunits.getarea();
            List<Area> are8 = aunits.getarea();
            List<Area> are9 = aunits.getarea();
            List<Area> are10 = aunits.getarea();
            List<Area> are11 = aunits.getarea();
            this.comboBox38.DataSource = are;
            this.comboBox38.DisplayMember = "NombreArea";
            this.comboBox38.ValueMember = "cod";
            this.comboBox39.DataSource = are1;
            this.comboBox39.DisplayMember = "NombreArea";
            this.comboBox39.ValueMember = "cod";
            this.comboBox40.DataSource = are2;
            this.comboBox40.DisplayMember = "NombreArea";
            this.comboBox40.ValueMember = "cod";
            this.comboBox41.DataSource = are3;
            this.comboBox41.DisplayMember = "NombreArea";
            this.comboBox41.ValueMember = "cod";
            this.comboBox42.DataSource = are4;
            this.comboBox42.DisplayMember = "NombreArea";
            this.comboBox42.ValueMember = "cod";
            this.comboBox43.DataSource = are5;
            this.comboBox43.DisplayMember = "NombreArea";
            this.comboBox43.ValueMember = "cod";
            this.comboBox44.DataSource = are6;
            this.comboBox44.DisplayMember = "NombreArea";
            this.comboBox44.ValueMember = "cod";
            this.comboBox45.DataSource = are7;
            this.comboBox45.DisplayMember = "NombreArea";
            this.comboBox45.ValueMember = "cod";
            this.comboBox46.DataSource = are8;
            this.comboBox46.DisplayMember = "NombreArea";
            this.comboBox46.ValueMember = "cod";
            this.comboBox47.DataSource = are9;
            this.comboBox47.DisplayMember = "NombreArea";
            this.comboBox47.ValueMember = "cod";
            this.comboBox48.DataSource = are10;
            this.comboBox48.DisplayMember = "NombreArea";
            this.comboBox48.ValueMember = "cod";
            this.comboBox49.DataSource = are11;
            this.comboBox49.DisplayMember = "NombreArea";
            this.comboBox49.ValueMember = "cod";

            registro = true;
      




        }

        private void PeriocidadMensual_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            DateTime fecha= new DateTime();
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
            dateTimePicker7.Format = DateTimePickerFormat.Custom;
            dateTimePicker7.CustomFormat = "dd-MM-yyyy";
            dateTimePicker8.Format = DateTimePickerFormat.Custom;
            dateTimePicker8.CustomFormat = "dd-MM-yyyy";
            dateTimePicker9.Format = DateTimePickerFormat.Custom;
            dateTimePicker9.CustomFormat = "dd-MM-yyyy";
            dateTimePicker10.Format = DateTimePickerFormat.Custom;
            dateTimePicker10.CustomFormat = "dd-MM-yyyy";
            dateTimePicker11.Format = DateTimePickerFormat.Custom;
            dateTimePicker11.CustomFormat = "dd-MM-yyyy";
            dateTimePicker12.Format = DateTimePickerFormat.Custom;
            dateTimePicker12.CustomFormat = "dd-MM-yyyy";
            dateTimePicker2.Value = new DateTime(year, 2, day);
            dateTimePicker3.Value = new DateTime(year, 3, day);
            dateTimePicker4.Value = new DateTime(year, 4, day);
            dateTimePicker5.Value = new DateTime(year, 5, day);
            dateTimePicker6.Value = new DateTime(year, 6, day);
            dateTimePicker7.Value = new DateTime(year, 7, day);
            dateTimePicker8.Value = new DateTime(year, 8, day);
            dateTimePicker9.Value = new DateTime(year, 9, day);
            dateTimePicker10.Value = new DateTime(year, 10, day);
            dateTimePicker11.Value = new DateTime(year, 11, day);
            dateTimePicker12.Value = new DateTime(year, 12, day);

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            if (dateTimePicker1.Value.Date <= DateTime.Now ||
               dateTimePicker2.Value.Date <= DateTime.Now ||
              dateTimePicker3.Value.Date <= DateTime.Now ||
              dateTimePicker4.Value.Date <= DateTime.Now ||
              dateTimePicker5.Value.Date <= DateTime.Now ||
              dateTimePicker6.Value.Date <= DateTime.Now ||
              dateTimePicker7.Value.Date <= DateTime.Now ||
              dateTimePicker8.Value.Date <= DateTime.Now ||
              dateTimePicker9.Value.Date <= DateTime.Now ||
              dateTimePicker10.Value.Date <= DateTime.Now ||
              dateTimePicker11.Value.Date <= DateTime.Now ||
              dateTimePicker12.Value.Date <= DateTime.Now)
            {
                MessageBox.Show("No se puede guardar fechas anteriores a la fecha actual");


            }
             
            else
            {
             *//////
             
                if (MessageBox.Show("¿Verificó las fechas a guardar?", "ATENCION",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {


                    CatalogoPlanilla ca = new CatalogoPlanilla();
                    List<Periodicidad> lu = ca.getcodfech();
                    this.comboBox1.DataSource = lu;
                    this.comboBox1.DisplayMember = "lugartratamiento";

                    this.comboBox1.ValueMember = "cod";


                   
                    int index = 0;
                  

                    index = 0;
                   
                    for (int j = list6.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list6[index].ToString();
                        if (lista7.Count != 0)
                        {
                           
                                dateTimePicker7.Format = DateTimePickerFormat.Custom;
                                dateTimePicker7.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = string.Join(",", lista11.ToArray());
                                Periodicidad pla = new Periodicidad(dateTimePicker7.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox8.SelectedValue), b, "", 0, "M", "P", "", "Primario", "","");
                                ca.addfecha(pla);                          
                              
                            index++;
                        }
                        else
                        {
                            dateTimePicker7.Format = DateTimePickerFormat.Custom;
                            dateTimePicker7.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker7.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox8.SelectedValue), "N/A", "", 0, "M", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                          
                            index++;
                        }
                    }
                    index = 0;
                   
                    for (int j = list7.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list7[index].ToString();
                        if (lista8.Count != 0)
                        {
                              dateTimePicker8.Format = DateTimePickerFormat.Custom;                               
                                dateTimePicker8.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = string.Join(",", lista11.ToArray());
                                Periodicidad pla = new Periodicidad(dateTimePicker8.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox9.SelectedValue), b, "", 0, "M", "P", "", "Primario", "", "");
                                ca.addfecha(pla);                                                                                                              
                            index++;
                        }
                        else
                        {
                            dateTimePicker8.Format = DateTimePickerFormat.Custom;                           
                            dateTimePicker8.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker8.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox9.SelectedValue), "N/A", "", 0, "M", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                           
                            index++;
                        }
                    }
                    index = 0;
                   
                    for (int j = list8.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list8[index].ToString();
                        if (lista9.Count != 0)
                        {
                           
                                dateTimePicker9.Format = DateTimePickerFormat.Custom;                              
                                dateTimePicker9.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = string.Join(",", lista11.ToArray());
                                Periodicidad pla = new Periodicidad(dateTimePicker9.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox10.SelectedValue), b, "", 0, "M", "P", "", "Primario", "", "");
                                ca.addfecha(pla);                             
                              
                            index++;
                        }
                        else
                        {
                            dateTimePicker9.Format = DateTimePickerFormat.Custom;                        
                            dateTimePicker9.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker9.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox10.SelectedValue), "N/A", "", 0, "M", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                            
                            index++;
                        }
                    }
                    index = 0;
                  
                    for (int j = list9.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list9[index].ToString();
                        if (lista10.Count != 0)
                        {
                          
                                dateTimePicker10.Format = DateTimePickerFormat.Custom;                               
                                dateTimePicker10.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = string.Join(",", lista11.ToArray());
                                Periodicidad pla = new Periodicidad(dateTimePicker10.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox11.SelectedValue),b, "", 0, "M", "P", "", "Primario", "", "");
                                ca.addfecha(pla);                              
 
                            index++;
                        }
                        else
                        {
                            dateTimePicker10.Format = DateTimePickerFormat.Custom;                          
                            dateTimePicker10.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker10.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox11.SelectedValue), "N/A", "", 0, "M", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                          
                            index++;
                        }
                    }
                    index = 0;
                 
                    for (int j = list10.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list10[index].ToString();
                        if (lista11.Count != 0)
                        {
                            
                                dateTimePicker11.Format = DateTimePickerFormat.Custom;                             
                                dateTimePicker11.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = string.Join(",", lista11.ToArray());
                                Periodicidad pla = new Periodicidad(dateTimePicker11.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox12.SelectedValue), b, "", 0, "M", "P", "", "Primario", "", "");
                                ca.addfecha(pla);                             
                               
                            index++;
                        }
                        else
                        {
                            dateTimePicker11.Format = DateTimePickerFormat.Custom;                         
                            dateTimePicker11.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker11.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox12.SelectedValue), "N/A", "", 0, "M", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                           
                            index++;
                        }
                    }
                    index = 0;
                 
                    for (int j = list11.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list11[index].ToString();
                        if (lista.Count != 0)
                        {
                           
                                dateTimePicker12.Format = DateTimePickerFormat.Custom;                             
                                dateTimePicker12.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = string.Join(",", lista11.ToArray());
                                Periodicidad pla = new Periodicidad(dateTimePicker12.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox13.SelectedValue), b, "", 0, "M", "P", "", "Primario", "", "");
                                ca.addfecha(pla);                            
                              
                            index++;
                        }
                        else
                        {
                            dateTimePicker12.Format = DateTimePickerFormat.Custom;                         
                            dateTimePicker12.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker12.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox13.SelectedValue), "N/A", "", 0, "M", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                          
                            index++;
                        }
                    }
                    index = 0;
                    


                    //PRIMER SEMEEESTRE

                    for (int j = list.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list[index].ToString();
                        if (lista1.Count != 0)
                        {
                          
                                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                                dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = string.Join(",", lista11.ToArray());
                                Periodicidad pla = new Periodicidad(dateTimePicker1.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox2.SelectedValue), b, "", 0, "M", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                            index++;
                        }
                        else
                        {
                            dateTimePicker1.Format = DateTimePickerFormat.Custom;
                            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker1.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox2.SelectedValue), "N/A", "", 0, "M", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                         
                            index++;
                        }
                    }
                    index = 0;
                   
                    for (int j = list1.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list1[index].ToString();
                        if (lista2.Count != 0)
                        {
                           
                                dateTimePicker2.Format = DateTimePickerFormat.Custom;                               
                                dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = string.Join(",", lista11.ToArray());
                                Periodicidad pla = new Periodicidad(dateTimePicker2.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox3.SelectedValue), b, "", 0, "M", "P", "", "Primario", "", "");
                                ca.addfecha(pla);                              
                               
                            index++;
                        }
                        else
                        {
                            dateTimePicker2.Format = DateTimePickerFormat.Custom;                         
                            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker2.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox3.SelectedValue), "N/A", "", 0, "M", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                          
                            index++;
                        }
                    }
                    index = 0;
                 
                    for (int j = list2.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list2[index].ToString();
                        if (lista3.Count != 0)
                        {
                          
                                dateTimePicker3.Format = DateTimePickerFormat.Custom;                              
                                dateTimePicker3.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = string.Join(",", lista11.ToArray());
                                Periodicidad pla = new Periodicidad(dateTimePicker3.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox4.SelectedValue), b, "", 0, "M", "P", "", "Primario", "", "");
                                ca.addfecha(pla);                              
                               
                            index++;
                        }
                        else
                        {
                            dateTimePicker3.Format = DateTimePickerFormat.Custom;                        
                            dateTimePicker3.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker3.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox4.SelectedValue), "N/A", "", 0, "M", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                         
                            index++;
                        }
                    }
                    index = 0;
                  
                    for (int j = list3.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list3[index].ToString();
                        if (lista4.Count != 0)
                        {
                            
                                dateTimePicker4.Format = DateTimePickerFormat.Custom;                          
                                dateTimePicker4.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = string.Join(",", lista11.ToArray());
                                Periodicidad pla = new Periodicidad(dateTimePicker4.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox5.SelectedValue), b, "", 0, "M", "P", "", "Primario", "", "");
                                ca.addfecha(pla);                              
                               
                            index++;
                        }
                        else
                        {
                            dateTimePicker4.Format = DateTimePickerFormat.Custom;                         
                            dateTimePicker4.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker4.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox5.SelectedValue), "N/A", "", 0, "M", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                           
                            index++;
                        }
                    }
                    index = 0;
                  
                    for (int j = list4.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list4[index].ToString();
                        if (lista5.Count != 0)
                        {
                          
                                dateTimePicker5.Format = DateTimePickerFormat.Custom;                              
                                dateTimePicker5.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = string.Join(",", lista11.ToArray());
                                Periodicidad pla = new Periodicidad(dateTimePicker5.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox6.SelectedValue), b, "", 0, "M", "P", "", "Primario", "", "");
                                ca.addfecha(pla);                               
                              
                            index++;
                        }
                        else
                        {
                            dateTimePicker5.Format = DateTimePickerFormat.Custom;                         
                            dateTimePicker5.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker5.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox6.SelectedValue), "N/A", "", 0, "M", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                          
                            index++;
                        }
                    }
                    index = 0;
                  
                    for (int j = list5.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list5[index].ToString();
                        if (lista6.Count != 0)
                        {
                           
                                dateTimePicker6.Format = DateTimePickerFormat.Custom;                             
                                dateTimePicker6.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = string.Join(",", lista11.ToArray());
                                Periodicidad pla = new Periodicidad(dateTimePicker6.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox7.SelectedValue), b, "", 0, "M", "P", "", "Primario", "", "");
                                ca.addfecha(pla);                             
                              
                            index++;
                        }
                        else
                        {
                            dateTimePicker6.Format = DateTimePickerFormat.Custom;                         
                            dateTimePicker6.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker6.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox7.SelectedValue), "N/A", "", 0, "M", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                          
                            index++;
                        }
                    }
                    index = 0;
                   







               }
                MessageBox.Show("Ingreso Completado");
            //}
            this.Close();
        
            
           
        }

     
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox14.SelectedValue);
                comboBox14.SelectedValue = index;


                comboBox26.Items.Add(comboBox14.Text);
             
                list.Add(index);
            }
        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox15.SelectedValue);
                comboBox15.SelectedValue = index;


                comboBox27.Items.Add(comboBox15.Text);
               
                list1.Add(index);
            }
        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox16.SelectedValue);
                comboBox16.SelectedValue = index;


                comboBox28.Items.Add(comboBox16.Text);
              
                list2.Add(index);
            }
        }

        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox17.SelectedValue);
                comboBox17.SelectedValue = index;


                comboBox29.Items.Add(comboBox17.Text);
             
                list3.Add(index);
            }
        }

        private void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {
              if (registro == true)
            {

                int index = Convert.ToInt32(comboBox18.SelectedValue);
                comboBox18.SelectedValue = index;


                comboBox30.Items.Add(comboBox18.Text);
               
                list4.Add(index);
            }
        }

        private void comboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (registro == true)
            {

                int index = Convert.ToInt32(comboBox19.SelectedValue);
                comboBox19.SelectedValue = index;


                comboBox31.Items.Add(comboBox19.Text);
                
                list5.Add(index);
            }
        }

        private void comboBox20_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox20.SelectedValue);
                comboBox20.SelectedValue = index;


                comboBox32.Items.Add(comboBox20.Text);
              
                list6.Add(index);
            }
        }

        private void comboBox21_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox21.SelectedValue);
                comboBox21.SelectedValue = index;


                comboBox33.Items.Add(comboBox21.Text);
               
                list7.Add(index);
            }
        }

        private void comboBox22_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox22.SelectedValue);
                comboBox22.SelectedValue = index;


                comboBox34.Items.Add(comboBox22.Text);
            
                list8.Add(index);
            }
        }

        private void comboBox23_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox23.SelectedValue);
                comboBox23.SelectedValue = index;


                comboBox35.Items.Add(comboBox23.Text);
             
                list9.Add(index);
            }
        }

        private void comboBox24_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox24.SelectedValue);
                comboBox24.SelectedValue = index;


                comboBox36.Items.Add(comboBox24.Text);
               
                list10.Add(index);
            }
        }

        private void comboBox25_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox25.SelectedValue);
                comboBox25.SelectedValue = index;


                comboBox37.Items.Add(comboBox25.Text);
             
                list11.Add(index);
            }

        }




        private void comboBox38_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                if (comboBox50.Text == "Seleccionados")
                {
                    comboBox50.Text = "";

                }
                comboBox50.Text = comboBox38.Text;
                string b = comboBox50.Text;
                comboBox50.Items.Add(comboBox38.Text);

                lista1.Add(comboBox50.Text);
            }

        }

        private void comboBox39_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                if (comboBox51.Text == "Seleccionados")
                {
                    comboBox51.Text = "";

                }
                comboBox51.Text = comboBox39.Text;
                string b = comboBox51.Text;
                comboBox51.Items.Add(comboBox39.Text);

                lista2.Add(comboBox51.Text);
              
               
            }
        }

        private void comboBox40_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                if (comboBox52.Text == "Seleccionados")
                {
                    comboBox52.Text = "";

                }
                comboBox52.Text = comboBox40.Text;
                string b = comboBox52.Text;
                comboBox52.Items.Add(comboBox40.Text);

                lista3.Add(comboBox52.Text);
            }
        }

        private void comboBox41_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                if (comboBox53.Text == "Seleccionados")
                {
                    comboBox53.Text = "";

                }
                comboBox53.Text = comboBox41.Text;
                string b = comboBox53.Text;
                comboBox53.Items.Add(comboBox41.Text);

                lista4.Add(comboBox53.Text);
            }
        }

        private void comboBox42_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {
                if (comboBox54.Text == "Seleccionados")
                {
                    comboBox54.Text = "";

                }
                comboBox54.Text = comboBox42.Text;
                string b = comboBox54.Text;
                comboBox54.Items.Add(comboBox42.Text);

                lista5.Add(comboBox54.Text);
            }
        }

        private void comboBox43_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                if (comboBox55.Text == "Seleccionados")
                {
                    comboBox55.Text = "";

                }
                comboBox55.Text = comboBox43.Text;
                string b = comboBox55.Text;
                comboBox55.Items.Add(comboBox43.Text);

                lista6.Add(comboBox55.Text);
            }
        }

        private void comboBox44_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                if (comboBox56.Text == "Seleccionados")
                {
                    comboBox56.Text = "";

                }
                comboBox56.Text = comboBox44.Text;
                string b = comboBox56.Text;
                comboBox56.Items.Add(comboBox44.Text);

                lista7.Add(comboBox56.Text);
            }
        }

        private void comboBox45_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                if (comboBox57.Text == "Seleccionados")
                {
                    comboBox57.Text = "";

                }
                comboBox57.Text = comboBox45.Text;
                string b = comboBox57.Text;
                comboBox57.Items.Add(comboBox45.Text);

                lista8.Add(comboBox57.Text);
            }
        }

        private void comboBox46_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                if (comboBox58.Text == "Seleccionados")
                {
                    comboBox58.Text = "";

                }
                comboBox58.Text = comboBox46.Text;
                string b = comboBox58.Text;
                comboBox58.Items.Add(comboBox46.Text);

                lista9.Add(comboBox58.Text);
            }
        }

        private void comboBox47_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                if (comboBox59.Text == "Seleccionados")
                {
                    comboBox59.Text = "";

                }
                comboBox59.Text = comboBox47.Text;
                string b = comboBox59.Text;
                comboBox59.Items.Add(comboBox47.Text);

                lista10.Add(comboBox59.Text);
            }
        }

        private void comboBox48_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                 if (comboBox60.Text == "Seleccionados")
                {
                    comboBox60.Text = "";

                }
                comboBox60.Text = comboBox48.Text;
                string b = comboBox60.Text;
                comboBox60.Items.Add(comboBox48.Text);

                lista11.Add(comboBox60.Text);
            
            }
        }

        private void comboBox49_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {


                if (comboBox61.Text == "Seleccionados")
                {
                    comboBox61.Text = "";

                }
                comboBox61.Text = comboBox49.Text;
                string b = comboBox61.Text;
                comboBox61.Items.Add(comboBox49.Text);

                lista.Add(comboBox61.Text);
               
                
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox50_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox37_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox73_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        }

    }

