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
    public partial class PeriocidadQuincenal : Form
    {
        Boolean registro = false;
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
        List<int> list12 = new List<int>();
        List<int> list13 = new List<int>();
        List<int> list14 = new List<int>();
        List<int> list15 = new List<int>();
        List<int> list16 = new List<int>();
        List<int> list17 = new List<int>();
        List<int> list18 = new List<int>();
        List<int> list19 = new List<int>();
        List<int> list20 = new List<int>();
        List<int> list21 = new List<int>();
        List<int> list22 = new List<int>();
        List<int> list23 = new List<int>();

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
        List<string> lista12 = new List<string>();
        List<string> lista13 = new List<string>();
        List<string> lista14 = new List<string>();
        List<string> lista15 = new List<string>();
        List<string> lista16 = new List<string>();
        List<string> lista17 = new List<string>();
        List<string> lista18 = new List<string>();
        List<string> lista19 = new List<string>();
        List<string> lista20 = new List<string>();
        List<string> lista21 = new List<string>();
        List<string> lista22 = new List<string>();
        List<string> lista23 = new List<string>();

        public PeriocidadQuincenal()
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
            List<Project.BussinessRules.Tecnico> tec12 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec13 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec14 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec15 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec16 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec17 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec18 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec19 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec20 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec21 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec22 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec23 = tunits.obtenertec();
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
            this.comboBox20.DataSource = tec10;
            this.comboBox20.DisplayMember = "nombre";
            this.comboBox20.ValueMember = "cod";
            this.comboBox21.DataSource = tec11;
            this.comboBox21.DisplayMember = "nombre";
            this.comboBox21.ValueMember = "cod";
            this.comboBox14.DataSource = tec12;
            this.comboBox14.DisplayMember = "nombre";
            this.comboBox14.ValueMember = "cod";
            this.comboBox15.DataSource = tec13;
            this.comboBox15.DisplayMember = "nombre";
            this.comboBox15.ValueMember = "cod";
            this.comboBox16.DataSource = tec14;
            this.comboBox16.DisplayMember = "nombre";
            this.comboBox16.ValueMember = "cod";
            this.comboBox17.DataSource = tec15;
            this.comboBox17.DisplayMember = "nombre";
            this.comboBox17.ValueMember = "cod";
            this.comboBox18.DataSource = tec16;
            this.comboBox18.DisplayMember = "nombre";
            this.comboBox18.ValueMember = "cod";
            this.comboBox19.DataSource = tec17;
            this.comboBox19.DisplayMember = "nombre";
            this.comboBox19.ValueMember = "cod";
            this.comboBox12.DataSource = tec18;
            this.comboBox12.DisplayMember = "nombre";
            this.comboBox12.ValueMember = "cod";
            this.comboBox13.DataSource = tec19;
            this.comboBox13.DisplayMember = "nombre";
            this.comboBox13.ValueMember = "cod";
            this.comboBox22.DataSource = tec20;
            this.comboBox22.DisplayMember = "nombre";
            this.comboBox22.ValueMember = "cod";
            this.comboBox23.DataSource = tec21;
            this.comboBox23.DisplayMember = "nombre";
            this.comboBox23.ValueMember = "cod";
            this.comboBox24.DataSource = tec22;
            this.comboBox24.DisplayMember = "nombre";
            this.comboBox24.ValueMember = "cod";
            this.comboBox25.DataSource = tec23;
            this.comboBox25.DisplayMember = "nombre";
            this.comboBox25.ValueMember = "cod";

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
            List<Project.BussinessRules.servicio> ser13 = sunits.getser();
            List<Project.BussinessRules.servicio> ser14 = sunits.getser();
            List<Project.BussinessRules.servicio> ser15 = sunits.getser();
            List<Project.BussinessRules.servicio> ser16 = sunits.getser();
            List<Project.BussinessRules.servicio> ser17 = sunits.getser();
            List<Project.BussinessRules.servicio> ser18 = sunits.getser();
            List<Project.BussinessRules.servicio> ser19 = sunits.getser();
            List<Project.BussinessRules.servicio> ser20 = sunits.getser();
            List<Project.BussinessRules.servicio> ser21 = sunits.getser();
            List<Project.BussinessRules.servicio> ser22 = sunits.getser();
            List<Project.BussinessRules.servicio> ser23 = sunits.getser();

            this.comboBox27.DataSource = ser;
            this.comboBox27.DisplayMember = "sigla";
            this.comboBox27.ValueMember = "cod";
            this.comboBox28.DataSource = ser1;
            this.comboBox28.DisplayMember = "sigla";
            this.comboBox28.ValueMember = "cod";
            this.comboBox33.DataSource = ser2;
            this.comboBox33.DisplayMember = "sigla";
            this.comboBox33.ValueMember = "cod";
            this.comboBox34.DataSource = ser23;
            this.comboBox34.DisplayMember = "sigla";
            this.comboBox34.ValueMember = "cod";
            this.comboBox39.DataSource = ser3;
            this.comboBox39.DisplayMember = "sigla";
            this.comboBox39.ValueMember = "cod";
            this.comboBox40.DataSource = ser4;
            this.comboBox40.DisplayMember = "sigla";
            this.comboBox40.ValueMember = "cod";
            this.comboBox45.DataSource = ser5;
            this.comboBox45.DisplayMember = "sigla";
            this.comboBox45.ValueMember = "cod";
            this.comboBox46.DataSource = ser6;
            this.comboBox46.DisplayMember = "sigla";
            this.comboBox46.ValueMember = "cod";
            this.comboBox29.DataSource = ser7;
            this.comboBox29.DisplayMember = "sigla";
            this.comboBox29.ValueMember = "cod";
            this.comboBox30.DataSource = ser8;
            this.comboBox30.DisplayMember = "sigla";
            this.comboBox30.ValueMember = "cod";
            this.comboBox37.DataSource = ser9;
            this.comboBox37.DisplayMember = "sigla";
            this.comboBox37.ValueMember = "cod";
            this.comboBox38.DataSource = ser10;
            this.comboBox38.DisplayMember = "sigla";
            this.comboBox38.ValueMember = "cod";
            this.comboBox41.DataSource = ser11;
            this.comboBox41.DisplayMember = "sigla";
            this.comboBox41.ValueMember = "cod";
            this.comboBox42.DataSource = ser12;
            this.comboBox42.DisplayMember = "sigla";
            this.comboBox42.ValueMember = "cod";
            this.comboBox47.DataSource = ser13;
            this.comboBox47.DisplayMember = "sigla";
            this.comboBox47.ValueMember = "cod";
            this.comboBox48.DataSource = ser14;
            this.comboBox48.DisplayMember = "sigla";
            this.comboBox48.ValueMember = "cod";
            this.comboBox31.DataSource = ser15;
            this.comboBox31.DisplayMember = "sigla";
            this.comboBox31.ValueMember = "cod";
            this.comboBox32.DataSource = ser16;
            this.comboBox32.DisplayMember = "sigla";
            this.comboBox32.ValueMember = "cod";
            this.comboBox36.DataSource = ser17;
            this.comboBox36.DisplayMember = "sigla";
            this.comboBox36.ValueMember = "cod";
            this.comboBox35.DataSource = ser18;
            this.comboBox35.DisplayMember = "sigla";
            this.comboBox35.ValueMember = "cod";
            this.comboBox43.DataSource = ser19;
            this.comboBox43.DisplayMember = "sigla";
            this.comboBox43.ValueMember = "cod";
            this.comboBox44.DataSource = ser20;
            this.comboBox44.DisplayMember = "sigla";
            this.comboBox44.ValueMember = "cod";
            this.comboBox49.DataSource = ser21;
            this.comboBox49.DisplayMember = "sigla";
            this.comboBox49.ValueMember = "cod";
            this.comboBox50.DataSource = ser22;
            this.comboBox50.DisplayMember = "sigla";
            this.comboBox50.ValueMember = "cod";



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
            List<Area> are12 = aunits.getarea();
            List<Area> are13 = aunits.getarea();
            List<Area> are14 = aunits.getarea();
            List<Area> are15 = aunits.getarea();
            List<Area> are16 = aunits.getarea();
            List<Area> are17 = aunits.getarea();
            List<Area> are18 = aunits.getarea();
            List<Area> are19 = aunits.getarea();
            List<Area> are20 = aunits.getarea();
            List<Area> are21 = aunits.getarea();
            List<Area> are22 = aunits.getarea();
            List<Area> are23 = aunits.getarea();

            this.comboBox26.DataSource = are;
            this.comboBox26.DisplayMember = "NombreArea";
            this.comboBox26.ValueMember = "cod";
            this.comboBox54.DataSource = are1;
            this.comboBox54.DisplayMember = "NombreArea";
            this.comboBox54.ValueMember = "cod";
            this.comboBox58.DataSource = are2;
            this.comboBox58.DisplayMember = "NombreArea";
            this.comboBox58.ValueMember = "cod";
            this.comboBox59.DataSource = are3;
            this.comboBox59.DisplayMember = "NombreArea";
            this.comboBox59.ValueMember = "cod";
            this.comboBox62.DataSource = are4;
            this.comboBox62.DisplayMember = "NombreArea";
            this.comboBox62.ValueMember = "cod";
            this.comboBox63.DataSource = are5;
            this.comboBox63.DisplayMember = "NombreArea";
            this.comboBox63.ValueMember = "cod";
            this.comboBox68.DataSource = are6;
            this.comboBox68.DisplayMember = "NombreArea";
            this.comboBox68.ValueMember = "cod";
            this.comboBox69.DataSource = are7;
            this.comboBox69.DisplayMember = "NombreArea";
            this.comboBox69.ValueMember = "cod";
            this.comboBox76.DataSource = are8;
            this.comboBox76.DisplayMember = "NombreArea";
            this.comboBox76.ValueMember = "cod";
            this.comboBox77.DataSource = are9;
            this.comboBox77.DisplayMember = "NombreArea";
            this.comboBox77.ValueMember = "cod";
            this.comboBox82.DataSource = are10;
            this.comboBox82.DisplayMember = "NombreArea";
            this.comboBox82.ValueMember = "cod";
            this.comboBox84.DataSource = are11;
            this.comboBox84.DisplayMember = "NombreArea";
            this.comboBox84.ValueMember = "cod";
            this.comboBox88.DataSource = are12;
            this.comboBox88.DisplayMember = "NombreArea";
            this.comboBox88.ValueMember = "cod";
            this.comboBox89.DataSource = are13;
            this.comboBox89.DisplayMember = "NombreArea";
            this.comboBox89.ValueMember = "cod";
            this.comboBox94.DataSource = are14;
            this.comboBox94.DisplayMember = "NombreArea";
            this.comboBox94.ValueMember = "cod";
            this.comboBox95.DataSource = are15;
            this.comboBox95.DisplayMember = "NombreArea";
            this.comboBox95.ValueMember = "cod";
            this.comboBox100.DataSource = are16;
            this.comboBox100.DisplayMember = "NombreArea";
            this.comboBox100.ValueMember = "cod";
            this.comboBox101.DataSource = are17;
            this.comboBox101.DisplayMember = "NombreArea";
            this.comboBox101.ValueMember = "cod";
            this.comboBox106.DataSource = are18;
            this.comboBox106.DisplayMember = "NombreArea";
            this.comboBox106.ValueMember = "cod";
            this.comboBox107.DataSource = are19;
            this.comboBox107.DisplayMember = "NombreArea";
            this.comboBox107.ValueMember = "cod";
            this.comboBox112.DataSource = are20;
            this.comboBox112.DisplayMember = "NombreArea";
            this.comboBox112.ValueMember = "cod";
            this.comboBox113.DataSource = are21;
            this.comboBox113.DisplayMember = "NombreArea";
            this.comboBox113.ValueMember = "cod";
            this.comboBox118.DataSource = are22;
            this.comboBox118.DisplayMember = "NombreArea";
            this.comboBox118.ValueMember = "cod";
            this.comboBox120.DataSource = are23;
            this.comboBox120.DisplayMember = "NombreArea";
            this.comboBox120.ValueMember = "cod";

            registro = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

      
        private void PeriocidadQuincenal_Load(object sender, EventArgs e)
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
            dateTimePicker13.Format = DateTimePickerFormat.Custom;
            dateTimePicker13.CustomFormat = "dd-MM-yyyy";
            dateTimePicker14.Format = DateTimePickerFormat.Custom;
            dateTimePicker14.CustomFormat = "dd-MM-yyyy";
            dateTimePicker15.Format = DateTimePickerFormat.Custom;
            dateTimePicker15.CustomFormat = "dd-MM-yyyy";
            dateTimePicker16.Format = DateTimePickerFormat.Custom;
            dateTimePicker16.CustomFormat = "dd-MM-yyyy";
            dateTimePicker17.Format = DateTimePickerFormat.Custom;
            dateTimePicker17.CustomFormat = "dd-MM-yyyy";
            dateTimePicker18.Format = DateTimePickerFormat.Custom;
            dateTimePicker18.CustomFormat = "dd-MM-yyyy";
            dateTimePicker19.Format = DateTimePickerFormat.Custom;
            dateTimePicker19.CustomFormat = "dd-MM-yyyy";
            dateTimePicker20.Format = DateTimePickerFormat.Custom;
            dateTimePicker20.CustomFormat = "dd-MM-yyyy";
            dateTimePicker21.Format = DateTimePickerFormat.Custom;
            dateTimePicker21.CustomFormat = "dd-MM-yyyy";
            dateTimePicker22.Format = DateTimePickerFormat.Custom;
            dateTimePicker22.CustomFormat = "dd-MM-yyyy";
            dateTimePicker23.Format = DateTimePickerFormat.Custom;
            dateTimePicker23.CustomFormat = "dd-MM-yyyy";
            dateTimePicker24.Format = DateTimePickerFormat.Custom;
            dateTimePicker24.CustomFormat = "dd-MM-yyyy";
            dateTimePicker2.Value = new DateTime(year, 1, 15);
            dateTimePicker3.Value = new DateTime(year, 2, day);
            dateTimePicker4.Value = new DateTime(year, 2, 15);
            dateTimePicker5.Value = new DateTime(year, 3, day);
            dateTimePicker6.Value = new DateTime(year, 3, 15);
            dateTimePicker7.Value = new DateTime(year, 4, day);
            dateTimePicker8.Value = new DateTime(year, 4, 15);
            dateTimePicker9.Value = new DateTime(year, 5, day);
            dateTimePicker10.Value = new DateTime(year, 5, 15);
            dateTimePicker11.Value = new DateTime(year, 6, day);
            dateTimePicker12.Value = new DateTime(year, 6, 15);
            dateTimePicker13.Value = new DateTime(year, 7, day);
            dateTimePicker14.Value = new DateTime(year, 7, 15);
            dateTimePicker15.Value = new DateTime(year, 8, day);
            dateTimePicker16.Value = new DateTime(year, 8, 15);
            dateTimePicker17.Value = new DateTime(year, 9, day);
            dateTimePicker18.Value = new DateTime(year, 9, 15);
            dateTimePicker19.Value = new DateTime(year, 10, day);
            dateTimePicker20.Value = new DateTime(year, 10, 15);
            dateTimePicker21.Value = new DateTime(year, 11, day);
            dateTimePicker22.Value = new DateTime(year, 11, 15);
            dateTimePicker23.Value = new DateTime(year, 12, day);
            dateTimePicker24.Value = new DateTime(year, 12, 15);
        }

       

      

        private void button5_Click(object sender, EventArgs e)
        {
            CatalogoPlanilla ca = new CatalogoPlanilla();
            List<Periodicidad> lu = ca.getcodfech();
            this.comboBox1.DataSource = lu;
            this.comboBox1.DisplayMember = "lugartratamiento";
         
            this.comboBox1.ValueMember = "cod";      
        
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CatalogoPlanilla ca = new CatalogoPlanilla();
            List<Periodicidad> lu = ca.getcodfech();
            this.comboBox1.DataSource = lu;
            this.comboBox1.DisplayMember = "lugartratamiento";
       
            this.comboBox1.ValueMember = "cod";
   
         
        }

        private void button11_Click(object sender, EventArgs e)
        {
            CatalogoPlanilla ca = new CatalogoPlanilla();
            List<Periodicidad> lu = ca.getcodfech();
            this.comboBox1.DataSource = lu;
            this.comboBox1.DisplayMember = "lugartratamiento";      
            this.comboBox1.ValueMember = "cod";

    

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CatalogoPlanilla ca = new CatalogoPlanilla();
            List<Periodicidad> lu = ca.getcodfech();
            this.comboBox1.DataSource = lu;
            this.comboBox1.DisplayMember = "lugartratamiento";
            this.comboBox1.ValueMember = "cod";


        
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CatalogoPlanilla ca = new CatalogoPlanilla();
            List<Periodicidad> lu = ca.getcodfech();
            this.comboBox1.DataSource = lu;
            this.comboBox1.DisplayMember = "lugartratamiento";         
            this.comboBox1.ValueMember = "cod";

    

        
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CatalogoPlanilla ca = new CatalogoPlanilla();
            List<Periodicidad> lu = ca.getcodfech();
            this.comboBox1.DataSource = lu;
            this.comboBox1.DisplayMember = "lugartratamiento";       
            this.comboBox1.ValueMember = "cod";

      

        }

        private void button12_Click(object sender, EventArgs e)
        {
            CatalogoPlanilla ca = new CatalogoPlanilla();
            List<Periodicidad> lu = ca.getcodfech();
            this.comboBox1.DataSource = lu;
            this.comboBox1.DisplayMember = "lugartratamiento";         
            this.comboBox1.ValueMember = "cod";

     

           
        }

        private void button13_Click(object sender, EventArgs e)
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
              dateTimePicker12.Value.Date <= DateTime.Now ||
              dateTimePicker13.Value.Date <= DateTime.Now ||
              dateTimePicker14.Value.Date <= DateTime.Now ||
              dateTimePicker15.Value.Date <= DateTime.Now ||
              dateTimePicker16.Value.Date <= DateTime.Now ||
              dateTimePicker17.Value.Date <= DateTime.Now ||
              dateTimePicker18.Value.Date <= DateTime.Now ||
              dateTimePicker19.Value.Date <= DateTime.Now ||
              dateTimePicker20.Value.Date <= DateTime.Now ||
              dateTimePicker21.Value.Date <= DateTime.Now ||
              dateTimePicker22.Value.Date <= DateTime.Now ||
              dateTimePicker23.Value.Date <= DateTime.Now ||
              dateTimePicker24.Value.Date <= DateTime.Now)
            {
                MessageBox.Show("No se puede guardar fechas anteriores a la fecha actual");


            }
            else
            {
             
             *///
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
                  
                    for (int j = list12.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list12[index].ToString();
                        if (lista12.Count != 0)
                        {
                           
                                dateTimePicker13.Format = DateTimePickerFormat.Custom;                             
                                dateTimePicker13.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = string.Join(",", lista12.ToArray());
                                Periodicidad pla = new Periodicidad(dateTimePicker13.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox14.SelectedValue), b, "", 0, "Q", "P", "", "Primario", "", "");
                                ca.addfecha(pla);                              
                               
                            
                            index++;
                        }
                        else
                        {
                            dateTimePicker13.Format = DateTimePickerFormat.Custom;                           
                            dateTimePicker13.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker13.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox14.SelectedValue), "N/A", "", 0, "Q", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                           
                            index++;
                        }
                    }









                    index = 0;
                  
                    for (int j = list13.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list13[index].ToString();
                        if (lista13.Count != 0)
                        {
                          
                                dateTimePicker14.Format = DateTimePickerFormat.Custom;                             
                                dateTimePicker14.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = string.Join(",", lista13.ToArray());
                                Periodicidad pla = new Periodicidad(dateTimePicker14.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox15.SelectedValue),  b, "", 0, "Q", "P", "", "Primario", "", "");
                                ca.addfecha(pla);                               
                              
                          
                            index++;
                        }
                        else
                        {
                            dateTimePicker14.Format = DateTimePickerFormat.Custom;                           
                            dateTimePicker14.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker14.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox15.SelectedValue), "N/A", "", 0, "Q", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                           
                            index++;
                        }
                    }










                    index = 0;
                   
                    for (int j = list14.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list14[index].ToString();
                        if (lista14.Count != 0)
                        {
                           
                                dateTimePicker15.Format = DateTimePickerFormat.Custom;                              
                                dateTimePicker15.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = string.Join(",", lista15.ToArray());
                                Periodicidad pla = new Periodicidad(dateTimePicker15.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox16.SelectedValue),  b, "", 0, "Q", "P", "", "Primario", "", "");
                                ca.addfecha(pla);                               
                              
                            index++;
                        }
                        else
                        {
                            dateTimePicker15.Format = DateTimePickerFormat.Custom;                           
                            dateTimePicker15.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker15.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox16.SelectedValue), "N/A", "", 0, "Q", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                            
                            index++;
                        }
                    }







                    index = 0;
                  
                    for (int j = list15.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list15[index].ToString();
                        if (lista15.Count != 0)
                        {
                           
                                dateTimePicker16.Format = DateTimePickerFormat.Custom;                                
                                dateTimePicker16.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = string.Join(",", lista15.ToArray());
                                Periodicidad pla = new Periodicidad(dateTimePicker16.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox17.SelectedValue),  b, "", 0, "Q", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                              
                            index++;
                        }
                        else
                        {
                            dateTimePicker16.Format = DateTimePickerFormat.Custom;
                           
                            dateTimePicker16.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker16.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox17.SelectedValue), "N/A", "", 0, "Q", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                          
                            index++;
                        }
                    }





                    index = 0;
                  
                    for (int j = list16.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list16[index].ToString();
                        if (lista16.Count != 0)
                        {
                           
                                dateTimePicker17.Format = DateTimePickerFormat.Custom;
                               
                                dateTimePicker17.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = string.Join(",", lista16.ToArray());
                                Periodicidad pla = new Periodicidad(dateTimePicker17.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox18.SelectedValue),  b, "", 0, "Q", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                             
                            index++;
                        }
                        else
                        {
                            dateTimePicker17.Format = DateTimePickerFormat.Custom;
                           
                            dateTimePicker17.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker17.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox18.SelectedValue), "N/A", "", 0, "Q", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                           
                            index++;
                        }
                    }








                    index = 0;
                  
                    for (int j = list17.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list17[index].ToString();
                        if (lista17.Count != 0)
                        {
                           
                                dateTimePicker18.Format = DateTimePickerFormat.Custom;
                               
                                dateTimePicker18.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = string.Join(",", lista17.ToArray());
                                Periodicidad pla = new Periodicidad(dateTimePicker18.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox19.SelectedValue),  b, "", 0, "Q", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                            
                          
                            index++;
                        }
                        else
                        {
                            dateTimePicker18.Format = DateTimePickerFormat.Custom;
                           
                            dateTimePicker18.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker18.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox19.SelectedValue), "N/A", "", 0, "Q", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                         
                            index++;
                        }
                    }










                    index = 0;
                 
                    for (int j = list18.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list18[index].ToString();
                        if (lista18.Count != 0)
                        {

                            dateTimePicker19.Format = DateTimePickerFormat.Custom;

                            dateTimePicker19.CustomFormat = "yyyy-MM-dd";
                            string b = "";
                            b = string.Join(",", lista18.ToArray());
                            Periodicidad pla = new Periodicidad(dateTimePicker19.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox12.SelectedValue),  b, "", 0, "Q", "P", "", "Primario", "", "");
                            ca.addfecha(pla);


                            index++;
                        }
                        else
                        {
                            dateTimePicker19.Format = DateTimePickerFormat.Custom;

                            dateTimePicker19.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker19.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox12.SelectedValue), "N/A", "", 0, "Q", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                            
                            index++;
                        }
                    }







                    index = 0;
                  
                    for (int j = list19.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list19[index].ToString();
                        if (lista19.Count != 0)
                        {
                           
                                dateTimePicker20.Format = DateTimePickerFormat.Custom;
                               
                                dateTimePicker20.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = string.Join(",", lista19.ToArray());
                                Periodicidad pla = new Periodicidad(dateTimePicker20.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox13.SelectedValue), b, "", 0, "Q", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                              
                           
                            index++;
                        }
                        else
                        {
                            dateTimePicker20.Format = DateTimePickerFormat.Custom;
                            
                            dateTimePicker20.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker20.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox13.SelectedValue), "N/A", "", 0, "Q", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                           
                            index++;
                        }
                    }









                    index = 0;
                   
                    for (int j = list20.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list20[index].ToString();
                        if (lista20.Count != 0)
                        {
                                dateTimePicker21.Format = DateTimePickerFormat.Custom;
                                
                                dateTimePicker21.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = string.Join(",", lista20.ToArray());
                                Periodicidad pla = new Periodicidad(dateTimePicker21.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox22.SelectedValue), b, "", 0, "Q", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                              
                            index++;
                        }
                        else
                        {
                            dateTimePicker21.Format = DateTimePickerFormat.Custom;
                           
                            dateTimePicker21.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker21.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox22.SelectedValue), "N/A", "", 0, "Q", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                          
                            index++;
                        }
                    }








                    index = 0;
                  
                    for (int j = list21.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list21[index].ToString();
                        if (lista21.Count != 0)
                        {
                            
                                dateTimePicker22.Format = DateTimePickerFormat.Custom;
                               
                                dateTimePicker22.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = string.Join(",", lista21.ToArray());
                                Periodicidad pla = new Periodicidad(dateTimePicker22.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox23.SelectedValue), b, "", 0, "Q", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                           
                            index++;
                        }
                        else
                        {
                            dateTimePicker22.Format = DateTimePickerFormat.Custom;
                           
                            dateTimePicker22.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker22.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox23.SelectedValue), "N/A", "", 0, "Q", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                          
                            index++;
                        }
                    }








                    index = 0;
                   
                    for (int j = list22.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list22[index].ToString();
                        if (lista22.Count != 0)
                        {
                           
                                dateTimePicker23.Format = DateTimePickerFormat.Custom;
                               
                                dateTimePicker23.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = string.Join(",", lista22.ToArray());
                                Periodicidad pla = new Periodicidad(dateTimePicker23.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox24.SelectedValue), b, "", 0, "Q", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                              
                            index++;
                        }
                        else
                        {
                            dateTimePicker23.Format = DateTimePickerFormat.Custom;
                           
                            dateTimePicker23.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker23.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox24.SelectedValue), "N/A", "", 0, "Q", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                           
                            index++;
                        }
                    }








                    index = 0;
                  
                    for (int j = list23.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list23[index].ToString();
                        if (lista23.Count != 0)
                        {
                              dateTimePicker24.Format = DateTimePickerFormat.Custom;
                               
                                dateTimePicker24.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = string.Join(",", lista23.ToArray());
                                Periodicidad pla = new Periodicidad(dateTimePicker24.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox25.SelectedValue),  b, "", 0, "Q", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                              
                            index++;
                        }
                        else
                        {
                            dateTimePicker24.Format = DateTimePickerFormat.Custom;
                           
                            dateTimePicker24.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker24.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox25.SelectedValue), "N/A", "", 0, "Q", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                           
                            index++;
                        }
                    }






                    //1er SEMESTREEEEE

                    index = 0;
                   
                    for (int j = list.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list[index].ToString();
                        if (lista.Count != 0)
                        {
                           
                                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                               
                                dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = string.Join(",", lista.ToArray());
                                Periodicidad pla = new Periodicidad(dateTimePicker1.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox2.SelectedValue),  b, "", 0, "Q", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                              
                            index++;
                        }
                        else
                        {
                            dateTimePicker1.Format = DateTimePickerFormat.Custom;
                           
                            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker1.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox2.SelectedValue), "N/A", "", 0, "Q", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                          
                            index++;
                        }
                    }









                    index = 0;
                    
                    for (int j = list1.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list1[index].ToString();
                        if (lista1.Count != 0)
                        {
                             dateTimePicker2.Format = DateTimePickerFormat.Custom;
                               
                                dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = string.Join(",", lista1.ToArray());
                                Periodicidad pla = new Periodicidad(dateTimePicker2.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox3.SelectedValue),  b, "", 0, "Q", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                               
                            index++;
                        }
                        else
                        {
                            dateTimePicker2.Format = DateTimePickerFormat.Custom;
                           
                            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker2.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox3.SelectedValue), "N/A", "", 0, "Q", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                          
                            index++;
                        }
                    }










                    index = 0;
                   
                    for (int j = list2.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list2[index].ToString();
                        if (lista2.Count != 0)
                        {
                             dateTimePicker3.Format = DateTimePickerFormat.Custom;
                               
                                dateTimePicker3.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = string.Join(",", lista2.ToArray());
                                Periodicidad pla = new Periodicidad(dateTimePicker3.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox4.SelectedValue),  b, "", 0, "Q", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                              
                            index++;
                        }
                        else
                        {
                            dateTimePicker3.Format = DateTimePickerFormat.Custom;
                           
                            dateTimePicker3.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker3.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox4.SelectedValue), "N/A", "", 0, "Q", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                           
                            index++;
                        }
                    }







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
                                Periodicidad pla = new Periodicidad(dateTimePicker4.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox5.SelectedValue),  b, "", 0, "Q", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                              
                            index++;
                        }
                        else
                        {
                            dateTimePicker4.Format = DateTimePickerFormat.Custom;
                           
                            dateTimePicker4.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker4.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox5.SelectedValue), "N/A", "", 0, "Q", "P", "", "Primario", "", "");
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
                                Periodicidad pla = new Periodicidad(dateTimePicker5.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox6.SelectedValue), b, "", 0, "Q", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                              
                            index++;
                        }
                        else
                        {
                            dateTimePicker5.Format = DateTimePickerFormat.Custom;
                           
                            dateTimePicker5.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker5.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox6.SelectedValue), "N/A", "", 0, "Q", "P", "", "Primario", "", "");
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
                                Periodicidad pla = new Periodicidad(dateTimePicker6.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox7.SelectedValue),  b, "", 0, "Q", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                              
                            index++;
                        }
                        else
                        {
                            dateTimePicker6.Format = DateTimePickerFormat.Custom;
                           
                            dateTimePicker6.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker6.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox7.SelectedValue), "N/A", "", 0, "Q", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                        
                            index++;
                        }
                    }










                    index = 0;
                 
                    for (int j = list6.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list6[index].ToString();
                        if (lista6.Count != 0)
                        {
                            
                                dateTimePicker7.Format = DateTimePickerFormat.Custom;
                               
                                dateTimePicker7.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = string.Join(",", lista6.ToArray());
                                Periodicidad pla = new Periodicidad(dateTimePicker7.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox8.SelectedValue),  b, "", 0, "Q", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                             
                            index++;
                        }
                        else
                        {
                            dateTimePicker7.Format = DateTimePickerFormat.Custom;
                           
                            dateTimePicker7.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker7.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox8.SelectedValue), "N/A", "", 0, "Q", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                          
                            index++;
                        }
                    }







                    index = 0;
                   
                    for (int j = list7.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list7[index].ToString();
                        if (lista7.Count != 0)
                        {
                            
                                dateTimePicker8.Format = DateTimePickerFormat.Custom;
                               
                                dateTimePicker8.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = string.Join(",", lista7.ToArray());
                                Periodicidad pla = new Periodicidad(dateTimePicker8.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox9.SelectedValue),  b, "", 0, "Q", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                               
                            index++;
                        }
                        else
                        {
                            dateTimePicker8.Format = DateTimePickerFormat.Custom;
                           
                            dateTimePicker8.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker8.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox9.SelectedValue), "N/A", "", 0, "Q", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                           
                            index++;
                        }
                    }









                    index = 0;
                  
                    for (int j = list8.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list8[index].ToString();
                        if (lista8.Count != 0)
                        {
                           
                                dateTimePicker9.Format = DateTimePickerFormat.Custom;
                               
                                dateTimePicker9.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = string.Join(",", lista8.ToArray());
                                Periodicidad pla = new Periodicidad(dateTimePicker9.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox10.SelectedValue), b, "", 0, "Q", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                               
                            index++;
                        }
                        else
                        {
                            dateTimePicker9.Format = DateTimePickerFormat.Custom;
                           
                            dateTimePicker9.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker9.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox10.SelectedValue), "N/A", "", 0, "Q", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                          
                            index++;
                        }
                    }








                    index = 0;
                   
                    for (int j = list9.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list9[index].ToString();
                        if (lista9.Count != 0)
                        {
                           
                                dateTimePicker10.Format = DateTimePickerFormat.Custom;
                               
                                dateTimePicker10.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = string.Join(",", lista9.ToArray());
                                Periodicidad pla = new Periodicidad(dateTimePicker10.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox11.SelectedValue),  b, "", 0, "Q", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                               
                            index++;
                        }
                        else
                        {
                            dateTimePicker10.Format = DateTimePickerFormat.Custom;
                           
                            dateTimePicker10.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker10.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox11.SelectedValue), "N/A", "", 0, "Q", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                           
                            index++;
                        }
                    }








                    index = 0;
                  
                    for (int j = list10.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list10[index].ToString();
                        if (lista10.Count != 0)
                        {
                            
                                dateTimePicker11.Format = DateTimePickerFormat.Custom;
                               
                                dateTimePicker11.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = string.Join(",", lista10.ToArray());
                                Periodicidad pla = new Periodicidad(dateTimePicker11.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox20.SelectedValue),  b, "", 0, "Q", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                         
                            index++;
                        }
                        else
                        {
                            dateTimePicker11.Format = DateTimePickerFormat.Custom;
                           
                            dateTimePicker11.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker11.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox20.SelectedValue), "N/A", "", 0, "Q", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                           
                            index++;
                        }
                    }






                

                    index = 0;
                   
                    for (int j = list11.Count - 1; j >= 0; j--)
                    {

                        string a = "";
                        a = list11[index].ToString();
                        if (lista11.Count != 0)
                        {
                             dateTimePicker12.Format = DateTimePickerFormat.Custom;
                               
                                dateTimePicker12.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = string.Join(",", lista11.ToArray());
                                Periodicidad pla = new Periodicidad(dateTimePicker12.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox21.SelectedValue),  b, "", 0, "Q", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                            
                          
                            index++;
                        }
                        else
                        {
                            dateTimePicker12.Format = DateTimePickerFormat.Custom;
                           
                            dateTimePicker12.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker12.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox21.SelectedValue), "N/A", "", 0, "Q", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                           ;
                            index++;
                        }
                    }





                }

                MessageBox.Show("Ingeso Completado");
            //}
                this.Close();
            
             
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox27_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox27.SelectedValue);
                comboBox27.SelectedValue = index;


                comboBox51.Items.Add(comboBox27.Text);
             
                list.Add(index);
            }
        }

        private void comboBox28_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox28.SelectedValue);
                comboBox28.SelectedValue = index;


                comboBox52.Items.Add(comboBox28.Text);
             
                list1.Add(index);
            }
        }

        private void comboBox33_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox33.SelectedValue);
                comboBox33.SelectedValue = index;


                comboBox56.Items.Add(comboBox33.Text);
             
                list2.Add(index);
            }
        }

        private void comboBox34_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox34.SelectedValue);
                comboBox34.SelectedValue = index;


                comboBox57.Items.Add(comboBox34.Text);
             
                list3.Add(index);
            }

        }

        private void comboBox39_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox39.SelectedValue);
                comboBox39.SelectedValue = index;


                comboBox66.Items.Add(comboBox39.Text);
             
                list4.Add(index);
            }
        }

        private void comboBox40_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox40.SelectedValue);
                comboBox40.SelectedValue = index;


                comboBox67.Items.Add(comboBox40.Text);
             
                list5.Add(index);
            }
        }

        private void comboBox67_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox45_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox45.SelectedValue);
                comboBox45.SelectedValue = index;


                comboBox70.Items.Add(comboBox45.Text);
             
                list6.Add(index);
            }
        }

        private void comboBox46_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox46.SelectedValue);
                comboBox46.SelectedValue = index;


                comboBox71.Items.Add(comboBox46.Text);
             
                list7.Add(index);
            }
        }

        private void comboBox29_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox29.SelectedValue);
                comboBox29.SelectedValue = index;


                comboBox74.Items.Add(comboBox29.Text);
             
                list8.Add(index);
            }
        }

        private void comboBox30_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox30.SelectedValue);
                comboBox30.SelectedValue = index;


                comboBox75.Items.Add(comboBox30.Text);
             
                list9.Add(index);
            }
        }

        private void comboBox37_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox37.SelectedValue);
                comboBox37.SelectedValue = index;


                comboBox80.Items.Add(comboBox37.Text);
             
                list10.Add(index);
            }
        }

        private void comboBox38_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox38.SelectedValue);
                comboBox38.SelectedValue = index;


                comboBox81.Items.Add(comboBox38.Text);
             
                list11.Add(index);
            }
        }

        private void comboBox41_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox41.SelectedValue);
                comboBox41.SelectedValue = index;


                comboBox86.Items.Add(comboBox41.Text);
             
                list12.Add(index);
            }
        }

        private void comboBox42_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox42.SelectedValue);
                comboBox42.SelectedValue = index;


                comboBox87.Items.Add(comboBox42.Text);
             
                list13.Add(index);
            }
        }

        private void comboBox47_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox47.SelectedValue);
                comboBox47.SelectedValue = index;


                comboBox92.Items.Add(comboBox47.Text);
             
                list14.Add(index);
            }
        }

        private void comboBox48_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox48.SelectedValue);
                comboBox48.SelectedValue = index;


                comboBox93.Items.Add(comboBox48.Text);
             
                list15.Add(index);
            }
        }

        private void comboBox31_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox31.SelectedValue);
                comboBox31.SelectedValue = index;


                comboBox98.Items.Add(comboBox31.Text);
             
                list16.Add(index);
            }
        }

        private void comboBox32_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox32.SelectedValue);
                comboBox32.SelectedValue = index;


                comboBox99.Items.Add(comboBox32.Text);
             
                list17.Add(index);
            }
        }

        private void comboBox36_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox36.SelectedValue);
                comboBox36.SelectedValue = index;


                comboBox104.Items.Add(comboBox36.Text);
             
                list18.Add(index);
            }
        }

        private void comboBox35_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox35.SelectedValue);
                comboBox35.SelectedValue = index;


                comboBox105.Items.Add(comboBox35.Text);
             
                list19.Add(index);
            }
        }

        private void comboBox43_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox43.SelectedValue);
                comboBox43.SelectedValue = index;


                comboBox110.Items.Add(comboBox43.Text);
             
                list20.Add(index);
            }
        }

        private void comboBox44_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox44.SelectedValue);
                comboBox44.SelectedValue = index;


                comboBox111.Items.Add(comboBox44.Text);
             
                list21.Add(index);
            }
        }

        private void comboBox49_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox49.SelectedValue);
                comboBox49.SelectedValue = index;


                comboBox116.Items.Add(comboBox49.Text);
             
                list22.Add(index);
            }
        }

        private void comboBox50_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox50.SelectedValue);
                comboBox50.SelectedValue = index;


                comboBox117.Items.Add(comboBox50.Text);
             
                list23.Add(index);
            }
        }

        private void comboBox26_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (registro == true)
            {

                comboBox53.Text = comboBox26.Text;
                string b = comboBox53.Text;
                comboBox53.Items.Add(comboBox26.Text);

                lista.Add(comboBox53.Text);
            }

        }

        private void comboBox54_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (registro == true)
            {


                comboBox55.Text = comboBox54.Text;
                string b = comboBox55.Text;
                comboBox55.Items.Add(comboBox54.Text);

                lista1.Add(comboBox55.Text);
            }
        }

        private void comboBox58_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (registro == true)
            {

                comboBox60.Text = comboBox58.Text;
                string b = comboBox60.Text;
                comboBox60.Items.Add(comboBox58.Text);

                lista2.Add(comboBox60.Text);
            }
        }

        private void comboBox59_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (registro == true)
            {

                comboBox61.Text = comboBox59.Text;
                string b = comboBox61.Text;
                comboBox61.Items.Add(comboBox59.Text);

                lista3.Add(comboBox61.Text);
            }
        }

        private void comboBox62_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (registro == true)
            {


                comboBox64.Text = comboBox62.Text;
                string b = comboBox64.Text;
                comboBox64.Items.Add(comboBox62.Text);

                lista4.Add(comboBox64.Text);
            }
        }

        private void comboBox63_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (registro == true)
            {
                comboBox65.Text = comboBox63.Text;
                string b = comboBox65.Text;
                comboBox65.Items.Add(comboBox63.Text);

                lista5.Add(comboBox65.Text);
            }
        }

        private void comboBox68_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (registro == true)
            {

                comboBox72.Text = comboBox68.Text;
                string b = comboBox72.Text;
                comboBox72.Items.Add(comboBox68.Text);

                lista6.Add(comboBox72.Text);
            }
        }

        private void comboBox69_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (registro == true)
            {

                comboBox73.Text = comboBox69.Text;
                string b = comboBox73.Text;
                comboBox73.Items.Add(comboBox69.Text);

                lista7.Add(comboBox73.Text);
            }
        }

        private void comboBox76_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (registro == true)
            {

                comboBox78.Text = comboBox76.Text;
                string b = comboBox78.Text;
                comboBox78.Items.Add(comboBox76.Text);

                lista8.Add(comboBox78.Text);
            }
        }

        private void comboBox77_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (registro == true)
            {


                comboBox79.Text = comboBox77.Text;
                string b = comboBox79.Text;
                comboBox79.Items.Add(comboBox77.Text);

                lista9.Add(comboBox79.Text);
            }
        }

        private void comboBox82_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (registro == true)
            {

                comboBox83.Text = comboBox82.Text;
                string b = comboBox83.Text;
                comboBox83.Items.Add(comboBox82.Text);

                lista10.Add(comboBox83.Text);
            }
        }

        private void comboBox84_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (registro == true)
            {

                comboBox85.Text = comboBox84.Text;
                string b = comboBox85.Text;
                comboBox85.Items.Add(comboBox84.Text);

                lista11.Add(comboBox85.Text);
            }
        }

        private void comboBox88_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (registro == true)
            {


                comboBox90.Text = comboBox88.Text;
                string b = comboBox90.Text;
                comboBox90.Items.Add(comboBox88.Text);

                lista12.Add(comboBox90.Text);
            }
        }

        private void comboBox89_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (registro == true)
            {

                comboBox91.Text = comboBox89.Text;
                string b = comboBox91.Text;
                comboBox91.Items.Add(comboBox89.Text);

                lista13.Add(comboBox91.Text);
            }
        }

        private void comboBox94_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (registro == true)
            {

                comboBox96.Text = comboBox94.Text;
                string b = comboBox96.Text;
                comboBox96.Items.Add(comboBox94.Text);

                lista14.Add(comboBox96.Text);
            }
        }

        private void comboBox100_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (registro == true)
            {

                comboBox102.Text = comboBox100.Text;
                string b = comboBox102.Text;
                comboBox102.Items.Add(comboBox100.Text);

                lista16.Add(comboBox102.Text);
            }
        }

        private void comboBox101_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (registro == true)
            {


                comboBox103.Text = comboBox101.Text;
                string b = comboBox103.Text;
                comboBox103.Items.Add(comboBox101.Text);

                lista17.Add(comboBox103.Text);
            }
        }

        private void comboBox106_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (registro == true)
            {


                comboBox108.Text = comboBox106.Text;
                string b = comboBox108.Text;
                comboBox108.Items.Add(comboBox106.Text);

                lista18.Add(comboBox108.Text);
            }
        }

        private void comboBox107_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (registro == true)
            {


                comboBox109.Text = comboBox107.Text;
                string b = comboBox109.Text;
                comboBox109.Items.Add(comboBox107.Text);

                lista19.Add(comboBox109.Text);
            }
        }

        private void comboBox112_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (registro == true)
            {

                comboBox114.Text = comboBox112.Text;
                string b = comboBox114.Text;
                comboBox114.Items.Add(comboBox112.Text);

                lista20.Add(comboBox114.Text);
            }
        }

        private void comboBox113_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (registro == true)
            {

                comboBox115.Text = comboBox113.Text;
                string b = comboBox115.Text;
                comboBox115.Items.Add(comboBox113.Text);

                lista21.Add(comboBox115.Text);
            }
        }

        private void comboBox118_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (registro == true)
            {

                comboBox119.Text = comboBox118.Text;
                string b = comboBox119.Text;
                comboBox119.Items.Add(comboBox118.Text);

                lista22.Add(comboBox119.Text);
            }
        }

        private void comboBox120_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (registro == true)
            {

                comboBox121.Text = comboBox120.Text;
                string b = comboBox121.Text;
                comboBox121.Items.Add(comboBox120.Text);

                lista23.Add(comboBox121.Text);
            }
        }

        private void comboBox95_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                comboBox97.Text = comboBox95.Text;
                string b = comboBox97.Text;
                comboBox97.Items.Add(comboBox95.Text);

                lista15.Add(comboBox97.Text);
            }
        }

        private void comboBox20_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
