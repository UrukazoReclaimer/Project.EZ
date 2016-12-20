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

        List<int> lista = new List<int>();
        List<int> lista1 = new List<int>();
        List<int> lista2 = new List<int>();
        List<int> lista3 = new List<int>();
        List<int> lista4 = new List<int>();
        List<int> lista5 = new List<int>();
        List<int> lista6 = new List<int>();
        List<int> lista7 = new List<int>();
        List<int> lista8 = new List<int>();
        List<int> lista9 = new List<int>();
        List<int> lista10 = new List<int>();
        List<int> lista11 = new List<int>();
        public PeriocidadMensual()
        {
            InitializeComponent();

            catalogoTecnico tunits = new catalogoTecnico();
            List<Project.BussinessRules.Tecnico> tec = tunits.gettec();
            List<Project.BussinessRules.Tecnico> tec1 = tunits.gettec();
            List<Project.BussinessRules.Tecnico> tec2 = tunits.gettec();
            List<Project.BussinessRules.Tecnico> tec3 = tunits.gettec();
            List<Project.BussinessRules.Tecnico> tec4 = tunits.gettec();
            List<Project.BussinessRules.Tecnico> tec5 = tunits.gettec();
            List<Project.BussinessRules.Tecnico> tec6 = tunits.gettec();
            List<Project.BussinessRules.Tecnico> tec7 = tunits.gettec();
            List<Project.BussinessRules.Tecnico> tec8 = tunits.gettec();
            List<Project.BussinessRules.Tecnico> tec9 = tunits.gettec();
            List<Project.BussinessRules.Tecnico> tec10 = tunits.gettec();
            List<Project.BussinessRules.Tecnico> tec11 = tunits.gettec();

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

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
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
             
             
                if (MessageBox.Show("Verificó las fechas a guardar?", "ATENCION",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {


                    CatalogoPlanilla ca = new CatalogoPlanilla();
                    List<Periodicidad> lu = ca.getcodfech();
                    this.comboBox1.DataSource = lu;
                    this.comboBox1.DisplayMember = "lugartratamiento";

                    this.comboBox1.ValueMember = "cod";


                    listBox1.Text = Convert.ToString(listBox1.SelectedValue);
                    listBox1.SelectedIndex = listBox1.FindString(listBox1.Text);
                    int index = 0;
                    int index1 = 0;

                    index = 0;
                    index1 = 0;
                    for (int j = list6.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list6[index].ToString();
                        if (lista7.Count != 0)
                        {
                            for (int i = lista7.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker7.Format = DateTimePickerFormat.Custom;
                                dateTimePicker7.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista7[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker7.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox8.SelectedValue), Convert.ToInt32(b), "", 0, "M", "P","");
                                ca.addfecha(pla);                          
                                if (index1 < lista7.Count - 1)
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
                            dateTimePicker7.Format = DateTimePickerFormat.Custom;
                            dateTimePicker7.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker7.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox8.SelectedValue), 30, "", 0, "M", "P", "");
                            ca.addfecha(pla);
                        }
                    }
                    index = 0;
                    index1 = 0;
                    for (int j = list7.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list7[index].ToString();
                        if (lista8.Count != 0)
                        {
                            for (int i = lista8.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker8.Format = DateTimePickerFormat.Custom;                               
                                dateTimePicker8.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista8[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker8.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox9.SelectedValue), Convert.ToInt32(b), "", 0, "M", "P", "");
                                ca.addfecha(pla);                               
                                if (index1 < lista8.Count - 1)
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
                            dateTimePicker8.Format = DateTimePickerFormat.Custom;                           
                            dateTimePicker8.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker8.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox9.SelectedValue), 30, "", 0, "M", "P", "");
                            ca.addfecha(pla);
                        }
                    }
                    index = 0;
                    index1 = 0;
                    for (int j = list8.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list8[index].ToString();
                        if (lista9.Count != 0)
                        {
                            for (int i = lista9.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker9.Format = DateTimePickerFormat.Custom;                              
                                dateTimePicker9.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista9[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker9.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox10.SelectedValue), Convert.ToInt32(b), "", 0, "M", "P", "");
                                ca.addfecha(pla);                             
                                if (index1 < lista9.Count - 1)
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
                            dateTimePicker9.Format = DateTimePickerFormat.Custom;                        
                            dateTimePicker9.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker9.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox10.SelectedValue), 30, "", 0, "M", "P", "");
                            ca.addfecha(pla);
                        }
                    }
                    index = 0;
                    index1 = 0;
                    for (int j = list9.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list9[index].ToString();
                        if (lista10.Count != 0)
                        {
                            for (int i = lista10.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker10.Format = DateTimePickerFormat.Custom;                               
                                dateTimePicker10.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista10[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker10.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox11.SelectedValue), Convert.ToInt32(b), "", 0, "M", "P", "");
                                ca.addfecha(pla);                              
                                if (index1 < lista10.Count - 1)
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
                            dateTimePicker10.Format = DateTimePickerFormat.Custom;                          
                            dateTimePicker10.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker10.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox11.SelectedValue), 30, "", 0, "M", "P", "");
                            ca.addfecha(pla);
                        }
                    }
                    index = 0;
                    index1 = 0;
                    for (int j = list10.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list10[index].ToString();
                        if (lista11.Count != 0)
                        {
                            for (int i = lista11.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker11.Format = DateTimePickerFormat.Custom;                             
                                dateTimePicker11.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista11[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker11.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox12.SelectedValue), Convert.ToInt32(b), "", 0, "M", "P", "");
                                ca.addfecha(pla);                             
                                if (index1 < lista11.Count - 1)
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
                            dateTimePicker11.Format = DateTimePickerFormat.Custom;                         
                            dateTimePicker11.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker11.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox12.SelectedValue), 30, "", 0, "M", "P", "");
                            ca.addfecha(pla);
                        }
                    }
                    index = 0;
                    index1 = 0;
                    for (int j = list11.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list11[index].ToString();
                        if (lista.Count != 0)
                        {
                            for (int i = lista.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker12.Format = DateTimePickerFormat.Custom;                             
                                dateTimePicker12.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker12.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox13.SelectedValue), Convert.ToInt32(b), "", 0, "M", "P", "");
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
                            dateTimePicker12.Format = DateTimePickerFormat.Custom;                         
                            dateTimePicker12.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker12.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox13.SelectedValue), 30, "", 0, "M", "P", "");
                            ca.addfecha(pla);
                        }
                    }
                    index = 0;
                    index1 = 0;


                    //PRIMER SEMEEESTRE

                    for (int j = list.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list[index].ToString();
                        if (lista1.Count != 0)
                        {
                            for (int i = lista1.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker1.Format = DateTimePickerFormat.Custom;                            
                                dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista1[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker1.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox8.SelectedValue), Convert.ToInt32(b), "", 0, "M", "P", "");
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
                            dateTimePicker1.Format = DateTimePickerFormat.Custom;                          
                            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker1.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox8.SelectedValue), 30, "", 0, "M", "P", "");
                            ca.addfecha(pla);
                        }
                    }
                    index = 0;
                    index1 = 0;
                    for (int j = list1.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list1[index].ToString();
                        if (lista2.Count != 0)
                        {
                            for (int i = lista2.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker2.Format = DateTimePickerFormat.Custom;                               
                                dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista2[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker2.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox3.SelectedValue), Convert.ToInt32(b), "", 0, "M", "P", "");
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
                            Periodicidad pla = new Periodicidad(dateTimePicker2.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox3.SelectedValue), 30, "", 0, "M", "P", "");
                            ca.addfecha(pla);
                        }
                    }
                    index = 0;
                    index1 = 0;
                    for (int j = list2.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list2[index].ToString();
                        if (lista3.Count != 0)
                        {
                            for (int i = lista3.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker3.Format = DateTimePickerFormat.Custom;                              
                                dateTimePicker3.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista3[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker3.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox4.SelectedValue), Convert.ToInt32(b), "", 0, "M", "P", "");
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
                            dateTimePicker3.Format = DateTimePickerFormat.Custom;                        
                            dateTimePicker3.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker3.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox4.SelectedValue), 30, "", 0, "M", "P", "");
                            ca.addfecha(pla);
                        }
                    }
                    index = 0;
                    index1 = 0;
                    for (int j = list3.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list3[index].ToString();
                        if (lista4.Count != 0)
                        {
                            for (int i = lista4.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker4.Format = DateTimePickerFormat.Custom;                          
                                dateTimePicker4.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista4[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker4.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox5.SelectedValue), Convert.ToInt32(b), "", 0, "M", "P", "");
                                ca.addfecha(pla);                              
                                if (index1 < lista4.Count - 1)
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
                            Periodicidad pla = new Periodicidad(dateTimePicker4.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox5.SelectedValue), 30, "", 0, "M", "P", "");
                            ca.addfecha(pla);
                        }
                    }
                    index = 0;
                    index1 = 0;
                    for (int j = list4.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list4[index].ToString();
                        if (lista5.Count != 0)
                        {
                            for (int i = lista5.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker5.Format = DateTimePickerFormat.Custom;                              
                                dateTimePicker5.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista5[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker5.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox6.SelectedValue), Convert.ToInt32(b), "", 0, "M", "P", "");
                                ca.addfecha(pla);                               
                                if (index1 < lista5.Count - 1)
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
                            dateTimePicker5.Format = DateTimePickerFormat.Custom;                         
                            dateTimePicker5.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker5.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox6.SelectedValue), 30, "", 0, "M", "P", "");
                            ca.addfecha(pla);
                        }
                    }
                    index = 0;
                    index1 = 0;
                    for (int j = list5.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list5[index].ToString();
                        if (lista6.Count != 0)
                        {
                            for (int i = lista6.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker6.Format = DateTimePickerFormat.Custom;                             
                                dateTimePicker6.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista6[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker6.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox7.SelectedValue), Convert.ToInt32(b), "", 0, "M", "P", "");
                                ca.addfecha(pla);                             
                                if (index1 < lista6.Count - 1)
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
                            dateTimePicker6.Format = DateTimePickerFormat.Custom;                         
                            dateTimePicker6.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker6.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox7.SelectedValue), 30, "", 0, "M", "P", "");
                            ca.addfecha(pla);
                        }
                    }
                    index = 0;
                    index1 = 0;







               }
                MessageBox.Show("Ingreso Completado");
            }
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

                int index = Convert.ToInt32(comboBox38.SelectedValue);
                comboBox38.SelectedValue = index;


                comboBox50.Items.Add(comboBox38.Text);
               
                lista1.Add(index);
            }

        }

        private void comboBox39_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox39.SelectedValue);
                comboBox39.SelectedValue = index;


                comboBox51.Items.Add(comboBox39.Text);
              
                lista2.Add(index);
            }
        }

        private void comboBox40_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox40.SelectedValue);
                comboBox40.SelectedValue = index;


                comboBox52.Items.Add(comboBox40.Text);
              
                lista3.Add(index);
            }
        }

        private void comboBox41_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox41.SelectedValue);
                comboBox41.SelectedValue = index;


                comboBox53.Items.Add(comboBox41.Text);
              
                lista4.Add(index);
            }
        }

        private void comboBox42_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox42.SelectedValue);
                comboBox42.SelectedValue = index;


                comboBox54.Items.Add(comboBox42.Text);
              
                lista5.Add(index);
            }
        }

        private void comboBox43_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox43.SelectedValue);
                comboBox43.SelectedValue = index;


                comboBox55.Items.Add(comboBox43.Text);
             
                lista6.Add(index);
            }
        }

        private void comboBox44_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox44.SelectedValue);
                comboBox44.SelectedValue = index;


                comboBox56.Items.Add(comboBox44.Text);
              
                lista7.Add(index);
            }
        }

        private void comboBox45_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox45.SelectedValue);
                comboBox45.SelectedValue = index;


                comboBox57.Items.Add(comboBox45.Text);
              
                lista8.Add(index);
            }
        }

        private void comboBox46_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox46.SelectedValue);
                comboBox46.SelectedValue = index;


                comboBox58.Items.Add(comboBox46.Text);
               
                lista9.Add(index);
            }
        }

        private void comboBox47_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox47.SelectedValue);
                comboBox47.SelectedValue = index;


                comboBox59.Items.Add(comboBox47.Text);
               
                lista10.Add(index);
            }
        }

        private void comboBox48_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox48.SelectedValue);
                comboBox48.SelectedValue = index;


                comboBox60.Items.Add(comboBox48.Text);
               
                lista11.Add(index);
            }
        }

        private void comboBox49_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox49.SelectedValue);
                comboBox49.SelectedValue = index;


                comboBox61.Items.Add(comboBox49.Text);
               
                lista.Add(index);
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        }

    }

