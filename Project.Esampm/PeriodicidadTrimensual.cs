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
    public partial class PeriodicidadTrimensual : Form
    {

        Boolean registro = false;
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
        List<int> list24 = new List<int>();
        List<int> list25 = new List<int>();
        List<int> list26 = new List<int>();
        List<int> list27 = new List<int>();
        List<int> list28 = new List<int>();
        List<int> list29 = new List<int>();
        List<int> list30 = new List<int>();
        List<int> list31 = new List<int>();
        List<int> list32 = new List<int>();
        List<int> list33 = new List<int>();
        List<int> list34 = new List<int>();
        List<int> list35 = new List<int>();
        List<int> list36 = new List<int>();



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
        List<string> lista24 = new List<string>();
        List<string> lista25 = new List<string>();
        List<string> lista26 = new List<string>();
        List<string> lista27 = new List<string>();
        List<string> lista28 = new List<string>();
        List<string> lista29 = new List<string>();
        List<string> lista30 = new List<string>();
        List<string> lista31 = new List<string>();
        List<string> lista32 = new List<string>();
        List<string> lista33 = new List<string>();
        List<string> lista34 = new List<string>();
        List<string> lista35 = new List<string>();
        List<string> lista36 = new List<string>();

        public PeriodicidadTrimensual()
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
            List<Project.BussinessRules.Tecnico> tec24 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec25 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec26 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec27 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec28 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec29 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec30 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec31 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec32 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec33 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec34 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec35 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec36 = tunits.obtenertec();

            this.comboBox15.DataSource = tec;
            this.comboBox15.DisplayMember = "nombre";
            this.comboBox15.ValueMember = "cod";
            this.comboBox1.DataSource = tec1;
            this.comboBox1.DisplayMember = "nombre";
            this.comboBox1.ValueMember = "cod";
            this.comboBox2.DataSource = tec2;
            this.comboBox2.DisplayMember = "nombre";
            this.comboBox2.ValueMember = "cod";
            this.comboBox18.DataSource = tec3;
            this.comboBox18.DisplayMember = "nombre";
            this.comboBox18.ValueMember = "cod";
            this.comboBox13.DataSource = tec4;
            this.comboBox13.DisplayMember = "nombre";
            this.comboBox13.ValueMember = "cod";
            this.comboBox12.DataSource = tec5;
            this.comboBox12.DisplayMember = "nombre";
            this.comboBox12.ValueMember = "cod";
            this.comboBox27.DataSource = tec6;
            this.comboBox27.DisplayMember = "nombre";
            this.comboBox27.ValueMember = "cod";
            this.comboBox24.DataSource = tec7;
            this.comboBox24.DisplayMember = "nombre";
            this.comboBox24.ValueMember = "cod";
            this.comboBox23.DataSource = tec8;
            this.comboBox23.DisplayMember = "nombre";
            this.comboBox23.ValueMember = "cod";
            this.comboBox36.DataSource = tec9;
            this.comboBox36.DisplayMember = "nombre";
            this.comboBox36.ValueMember = "cod";
            this.comboBox33.DataSource = tec10;
            this.comboBox33.DisplayMember = "nombre";
            this.comboBox33.ValueMember = "cod";
            this.comboBox32.DataSource = tec11;
            this.comboBox32.DisplayMember = "nombre";
            this.comboBox32.ValueMember = "cod";
            this.comboBox45.DataSource = tec12;
            this.comboBox45.DisplayMember = "nombre";
            this.comboBox45.ValueMember = "cod";
            this.comboBox42.DataSource = tec13;
            this.comboBox42.DisplayMember = "nombre";
            this.comboBox42.ValueMember = "cod";
            this.comboBox41.DataSource = tec14;
            this.comboBox41.DisplayMember = "nombre";
            this.comboBox41.ValueMember = "cod";
            this.comboBox54.DataSource = tec15;
            this.comboBox54.DisplayMember = "nombre";
            this.comboBox54.ValueMember = "cod";
            this.comboBox51.DataSource = tec16;
            this.comboBox51.DisplayMember = "nombre";
            this.comboBox51.ValueMember = "cod";
            this.comboBox50.DataSource = tec17;
            this.comboBox50.DisplayMember = "nombre";
            this.comboBox50.ValueMember = "cod";
            this.comboBox63.DataSource = tec18;
            this.comboBox63.DisplayMember = "nombre";
            this.comboBox63.ValueMember = "cod";
            this.comboBox60.DataSource = tec19;
            this.comboBox60.DisplayMember = "nombre";
            this.comboBox60.ValueMember = "cod";
            this.comboBox59.DataSource = tec20;
            this.comboBox59.DisplayMember = "nombre";
            this.comboBox59.ValueMember = "cod";
            this.comboBox72.DataSource = tec21;
            this.comboBox72.DisplayMember = "nombre";
            this.comboBox72.ValueMember = "cod";
            this.comboBox69.DataSource = tec22;
            this.comboBox69.DisplayMember = "nombre";
            this.comboBox69.ValueMember = "cod";
            this.comboBox68.DataSource = tec23;
            this.comboBox68.DisplayMember = "nombre";
            this.comboBox68.ValueMember = "cod";
            this.comboBox81.DataSource = tec24;
            this.comboBox81.DisplayMember = "nombre";
            this.comboBox81.ValueMember = "cod";
            this.comboBox78.DataSource = tec25;
            this.comboBox78.DisplayMember = "nombre";
            this.comboBox78.ValueMember = "cod";
            this.comboBox77.DataSource = tec26;
            this.comboBox77.DisplayMember = "nombre";
            this.comboBox77.ValueMember = "cod";
            this.comboBox90.DataSource = tec27;
            this.comboBox90.DisplayMember = "nombre";
            this.comboBox90.ValueMember = "cod";
            this.comboBox87.DataSource = tec28;
            this.comboBox87.DisplayMember = "nombre";
            this.comboBox87.ValueMember = "cod";
            this.comboBox86.DataSource = tec29;
            this.comboBox86.DisplayMember = "nombre";
            this.comboBox86.ValueMember = "cod";
            this.comboBox99.DataSource = tec30;
            this.comboBox99.DisplayMember = "nombre";
            this.comboBox99.ValueMember = "cod";
            this.comboBox96.DataSource = tec31;
            this.comboBox96.DisplayMember = "nombre";
            this.comboBox96.ValueMember = "cod";
            this.comboBox95.DataSource = tec32;
            this.comboBox95.DisplayMember = "nombre";
            this.comboBox95.ValueMember = "cod";
            this.comboBox108.DataSource = tec33;
            this.comboBox108.DisplayMember = "nombre";
            this.comboBox108.ValueMember = "cod";
            this.comboBox105.DataSource = tec34;
            this.comboBox105.DisplayMember = "nombre";
            this.comboBox105.ValueMember = "cod";
            this.comboBox104.DataSource = tec35;
            this.comboBox104.DisplayMember = "nombre";
            this.comboBox104.ValueMember = "cod";

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
            List<Project.BussinessRules.servicio> ser24 = sunits.getser();
            List<Project.BussinessRules.servicio> ser25 = sunits.getser();
            List<Project.BussinessRules.servicio> ser26 = sunits.getser();
            List<Project.BussinessRules.servicio> ser27 = sunits.getser();
            List<Project.BussinessRules.servicio> ser28 = sunits.getser();
            List<Project.BussinessRules.servicio> ser29 = sunits.getser();
            List<Project.BussinessRules.servicio> ser30 = sunits.getser();
            List<Project.BussinessRules.servicio> ser31 = sunits.getser();
            List<Project.BussinessRules.servicio> ser32 = sunits.getser();
            List<Project.BussinessRules.servicio> ser33 = sunits.getser();
            List<Project.BussinessRules.servicio> ser34 = sunits.getser();
            List<Project.BussinessRules.servicio> ser35 = sunits.getser();
            List<Project.BussinessRules.servicio> ser36 = sunits.getser();


            this.comboBox62.DataSource = ser;
            this.comboBox62.DisplayMember = "sigla";
            this.comboBox62.ValueMember = "cod";
            this.comboBox58.DataSource = ser1;
            this.comboBox58.DisplayMember = "sigla";
            this.comboBox58.ValueMember = "cod";
            this.comboBox57.DataSource = ser2;
            this.comboBox57.DisplayMember = "sigla";
            this.comboBox57.ValueMember = "cod";
            this.comboBox71.DataSource = ser3;
            this.comboBox71.DisplayMember = "sigla";
            this.comboBox71.ValueMember = "cod";
            this.comboBox67.DataSource = ser4;
            this.comboBox67.DisplayMember = "sigla";
            this.comboBox67.ValueMember = "cod";
            this.comboBox66.DataSource = ser5;
            this.comboBox66.DisplayMember = "sigla";
            this.comboBox66.ValueMember = "cod";
            this.comboBox80.DataSource = ser6;
            this.comboBox80.DisplayMember = "sigla";
            this.comboBox80.ValueMember = "cod";
            this.comboBox76.DataSource = ser7;
            this.comboBox76.DisplayMember = "sigla";
            this.comboBox76.ValueMember = "cod";
            this.comboBox75.DataSource = ser8;
            this.comboBox75.DisplayMember = "sigla";
            this.comboBox75.ValueMember = "cod";
            this.comboBox89.DataSource = ser9;
            this.comboBox89.DisplayMember = "sigla";
            this.comboBox89.ValueMember = "cod";
            this.comboBox85.DataSource = ser10;
            this.comboBox85.DisplayMember = "sigla";
            this.comboBox85.ValueMember = "cod";
            this.comboBox84.DataSource = ser11;
            this.comboBox84.DisplayMember = "sigla";
            this.comboBox84.ValueMember = "cod";
            this.comboBox98.DataSource = ser12;
            this.comboBox98.DisplayMember = "sigla";
            this.comboBox98.ValueMember = "cod";
            this.comboBox94.DataSource = ser13;
            this.comboBox94.DisplayMember = "sigla";
            this.comboBox94.ValueMember = "cod";
            this.comboBox93.DataSource = ser14;
            this.comboBox93.DisplayMember = "sigla";
            this.comboBox93.ValueMember = "cod";
            this.comboBox107.DataSource = ser15;
            this.comboBox107.DisplayMember = "sigla";
            this.comboBox107.ValueMember = "cod";
            this.comboBox103.DataSource = ser16;
            this.comboBox103.DisplayMember = "sigla";
            this.comboBox103.ValueMember = "cod";
            this.comboBox102.DataSource = ser17;
            this.comboBox102.DisplayMember = "sigla";
            this.comboBox102.ValueMember = "cod";


            this.comboBox14.DataSource = ser18;
            this.comboBox14.DisplayMember = "sigla";
            this.comboBox14.ValueMember = "cod";
            this.comboBox3.DataSource = ser19;
            this.comboBox3.DisplayMember = "sigla";
            this.comboBox3.ValueMember = "cod";
            this.comboBox4.DataSource = ser20;
            this.comboBox4.DisplayMember = "sigla";
            this.comboBox4.ValueMember = "cod";
            this.comboBox17.DataSource = ser21;
            this.comboBox17.DisplayMember = "sigla";
            this.comboBox17.ValueMember = "cod";
            this.comboBox11.DataSource = ser22;
            this.comboBox11.DisplayMember = "sigla";
            this.comboBox11.ValueMember = "cod";
            this.comboBox10.DataSource = ser23;
            this.comboBox10.DisplayMember = "sigla";
            this.comboBox10.ValueMember = "cod";
            this.comboBox26.DataSource = ser24;
            this.comboBox26.DisplayMember = "sigla";
            this.comboBox26.ValueMember = "cod";
            this.comboBox22.DataSource = ser25;
            this.comboBox22.DisplayMember = "sigla";
            this.comboBox22.ValueMember = "cod";
            this.comboBox21.DataSource = ser26;
            this.comboBox21.DisplayMember = "sigla";
            this.comboBox21.ValueMember = "cod";
            this.comboBox35.DataSource = ser27;
            this.comboBox35.DisplayMember = "sigla";
            this.comboBox35.ValueMember = "cod";
            this.comboBox31.DataSource = ser28;
            this.comboBox31.DisplayMember = "sigla";
            this.comboBox31.ValueMember = "cod";
            this.comboBox30.DataSource = ser29;
            this.comboBox30.DisplayMember = "sigla";
            this.comboBox30.ValueMember = "cod";
            this.comboBox44.DataSource = ser30;
            this.comboBox44.DisplayMember = "sigla";
            this.comboBox44.ValueMember = "cod";
            this.comboBox40.DataSource = ser31;
            this.comboBox40.DisplayMember = "sigla";
            this.comboBox40.ValueMember = "cod";
            this.comboBox39.DataSource = ser32;
            this.comboBox39.DisplayMember = "sigla";
            this.comboBox39.ValueMember = "cod";
            this.comboBox53.DataSource = ser33;
            this.comboBox53.DisplayMember = "sigla";
            this.comboBox53.ValueMember = "cod";
            this.comboBox49.DataSource = ser34;
            this.comboBox49.DisplayMember = "sigla";
            this.comboBox49.ValueMember = "cod";
            this.comboBox48.DataSource = ser35;
            this.comboBox48.DisplayMember = "sigla";
            this.comboBox48.ValueMember = "cod";

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
            List<Area> are24 = aunits.getarea();
            List<Area> are25 = aunits.getarea();
            List<Area> are26 = aunits.getarea();
            List<Area> are27 = aunits.getarea();
            List<Area> are28 = aunits.getarea();
            List<Area> are29 = aunits.getarea();
            List<Area> are30 = aunits.getarea();
            List<Area> are31 = aunits.getarea();
            List<Area> are32 = aunits.getarea();
            List<Area> are33 = aunits.getarea();
            List<Area> are34 = aunits.getarea();
            List<Area> are35 = aunits.getarea();
            List<Area> are36 = aunits.getarea();


            this.comboBox61.DataSource = are;
            this.comboBox61.DisplayMember = "NombreArea";
            this.comboBox61.ValueMember = "cod";
            this.comboBox56.DataSource = are1;
            this.comboBox56.DisplayMember = "NombreArea";
            this.comboBox56.ValueMember = "cod";
            this.comboBox55.DataSource = are2;
            this.comboBox55.DisplayMember = "NombreArea";
            this.comboBox55.ValueMember = "cod";
            this.comboBox70.DataSource = are3;
            this.comboBox70.DisplayMember = "NombreArea";
            this.comboBox70.ValueMember = "cod";
            this.comboBox65.DataSource = are4;
            this.comboBox65.DisplayMember = "NombreArea";
            this.comboBox65.ValueMember = "cod";
            this.comboBox64.DataSource = are5;
            this.comboBox64.DisplayMember = "NombreArea";
            this.comboBox64.ValueMember = "cod";
            this.comboBox79.DataSource = are6;
            this.comboBox79.DisplayMember = "NombreArea";
            this.comboBox79.ValueMember = "cod";
            this.comboBox74.DataSource = are7;
            this.comboBox74.DisplayMember = "NombreArea";
            this.comboBox74.ValueMember = "cod";
            this.comboBox73.DataSource = are8;
            this.comboBox73.DisplayMember = "NombreArea";
            this.comboBox73.ValueMember = "cod";
            this.comboBox88.DataSource = are9;
            this.comboBox88.DisplayMember = "NombreArea";
            this.comboBox88.ValueMember = "cod";
            this.comboBox83.DataSource = are10;
            this.comboBox83.DisplayMember = "NombreArea";
            this.comboBox83.ValueMember = "cod";
            this.comboBox82.DataSource = are11;
            this.comboBox82.DisplayMember = "NombreArea";
            this.comboBox82.ValueMember = "cod";
            this.comboBox97.DataSource = are12;
            this.comboBox97.DisplayMember = "NombreArea";
            this.comboBox97.ValueMember = "cod";
            this.comboBox92.DataSource = are13;
            this.comboBox92.DisplayMember = "NombreArea";
            this.comboBox92.ValueMember = "cod";
            this.comboBox91.DataSource = are14;
            this.comboBox91.DisplayMember = "NombreArea";
            this.comboBox91.ValueMember = "cod";
            this.comboBox106.DataSource = are15;
            this.comboBox106.DisplayMember = "NombreArea";
            this.comboBox106.ValueMember = "cod";
            this.comboBox101.DataSource = are16;
            this.comboBox101.DisplayMember = "NombreArea";
            this.comboBox101.ValueMember = "cod";
            this.comboBox100.DataSource = are17;
            this.comboBox100.DisplayMember = "NombreArea";
            this.comboBox100.ValueMember = "cod";




            this.comboBox9.DataSource = are18;
            this.comboBox9.DisplayMember = "NombreArea";
            this.comboBox9.ValueMember = "cod";
            this.comboBox5.DataSource = are19;
            this.comboBox5.DisplayMember = "NombreArea";
            this.comboBox5.ValueMember = "cod";
            this.comboBox6.DataSource = are20;
            this.comboBox6.DisplayMember = "NombreArea";
            this.comboBox6.ValueMember = "cod";
            this.comboBox16.DataSource = are21;
            this.comboBox16.DisplayMember = "NombreArea";
            this.comboBox16.ValueMember = "cod";
            this.comboBox8.DataSource = are22;
            this.comboBox8.DisplayMember = "NombreArea";
            this.comboBox8.ValueMember = "cod";
            this.comboBox7.DataSource = are23;
            this.comboBox7.DisplayMember = "NombreArea";
            this.comboBox7.ValueMember = "cod";
            this.comboBox25.DataSource = are24;
            this.comboBox25.DisplayMember = "NombreArea";
            this.comboBox25.ValueMember = "cod";
            this.comboBox20.DataSource = are25;
            this.comboBox20.DisplayMember = "NombreArea";
            this.comboBox20.ValueMember = "cod";
            this.comboBox19.DataSource = are26;
            this.comboBox19.DisplayMember = "NombreArea";
            this.comboBox19.ValueMember = "cod";
            this.comboBox34.DataSource = are27;
            this.comboBox34.DisplayMember = "NombreArea";
            this.comboBox34.ValueMember = "cod";
            this.comboBox29.DataSource = are28;
            this.comboBox29.DisplayMember = "NombreArea";
            this.comboBox29.ValueMember = "cod";
            this.comboBox28.DataSource = are29;
            this.comboBox28.DisplayMember = "NombreArea";
            this.comboBox28.ValueMember = "cod";
            this.comboBox43.DataSource = are30;
            this.comboBox43.DisplayMember = "NombreArea";
            this.comboBox43.ValueMember = "cod";
            this.comboBox38.DataSource = are31;
            this.comboBox38.DisplayMember = "NombreArea";
            this.comboBox38.ValueMember = "cod";
            this.comboBox37.DataSource = are32;
            this.comboBox37.DisplayMember = "NombreArea";
            this.comboBox37.ValueMember = "cod";
            this.comboBox52.DataSource = are33;
            this.comboBox52.DisplayMember = "NombreArea";
            this.comboBox52.ValueMember = "cod";
            this.comboBox47.DataSource = are34;
            this.comboBox47.DisplayMember = "NombreArea";
            this.comboBox47.ValueMember = "cod";
            this.comboBox46.DataSource = are35;
            this.comboBox46.DisplayMember = "NombreArea";
            this.comboBox46.ValueMember = "cod";

            registro = true;
        }

        private void PeriodicidadTrimensual_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            DateTime fecha = new DateTime();
            int day = fecha.Day;
            int month = fecha.Month;
            int year = Convert.ToInt32(textBox1.Text);
            dateTimePicker1.Value = new DateTime(year, month, 15);


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
            dateTimePicker25.Format = DateTimePickerFormat.Custom;
            dateTimePicker25.CustomFormat = "dd-MM-yyyy";
            dateTimePicker26.Format = DateTimePickerFormat.Custom;
            dateTimePicker26.CustomFormat = "dd-MM-yyyy";
            dateTimePicker27.Format = DateTimePickerFormat.Custom;
            dateTimePicker27.CustomFormat = "dd-MM-yyyy";
            dateTimePicker28.Format = DateTimePickerFormat.Custom;
            dateTimePicker28.CustomFormat = "dd-MM-yyyy";
            dateTimePicker29.Format = DateTimePickerFormat.Custom;
            dateTimePicker29.CustomFormat = "dd-MM-yyyy";
            dateTimePicker30.Format = DateTimePickerFormat.Custom;
            dateTimePicker30.CustomFormat = "dd-MM-yyyy";
            dateTimePicker31.Format = DateTimePickerFormat.Custom;
            dateTimePicker31.CustomFormat = "dd-MM-yyyy";
            dateTimePicker32.Format = DateTimePickerFormat.Custom;
            dateTimePicker32.CustomFormat = "dd-MM-yyyy";
            dateTimePicker33.Format = DateTimePickerFormat.Custom;
            dateTimePicker33.CustomFormat = "dd-MM-yyyy";
            dateTimePicker34.Format = DateTimePickerFormat.Custom;
            dateTimePicker34.CustomFormat = "dd-MM-yyyy";
            dateTimePicker35.Format = DateTimePickerFormat.Custom;
            dateTimePicker35.CustomFormat = "dd-MM-yyyy";
            dateTimePicker36.Format = DateTimePickerFormat.Custom;
            dateTimePicker36.CustomFormat = "dd-MM-yyyy";

            dateTimePicker2.Value = new DateTime(year, 1, 1);
            dateTimePicker3.Value = new DateTime(year, 1, 30);
            dateTimePicker4.Value = new DateTime(year, 2, 28);
            dateTimePicker5.Value = new DateTime(year, 2, 15);
            dateTimePicker6.Value = new DateTime(year, 2, 1);
            dateTimePicker7.Value = new DateTime(year, 3, 28);
            dateTimePicker8.Value = new DateTime(year, 3, 14);
            dateTimePicker9.Value = new DateTime(year, 3, 1);
            dateTimePicker10.Value = new DateTime(year, 4, 25);
            dateTimePicker11.Value = new DateTime(year, 4, 18);
            dateTimePicker12.Value = new DateTime(year, 4, 4);
            dateTimePicker13.Value = new DateTime(year, 5, 30);
            dateTimePicker14.Value = new DateTime(year, 5, 16);
            dateTimePicker15.Value = new DateTime(year, 5, 2);
            dateTimePicker16.Value = new DateTime(year, 6, 27);
            dateTimePicker17.Value = new DateTime(year, 6, 20);
            dateTimePicker18.Value = new DateTime(year, 6, 6);
            dateTimePicker19.Value = new DateTime(year, 7, 25);
            dateTimePicker20.Value = new DateTime(year, 7, 18);
            dateTimePicker21.Value = new DateTime(year, 7, 4);
            dateTimePicker22.Value = new DateTime(year, 8, 29);
            dateTimePicker23.Value = new DateTime(year, 8, 15);
            dateTimePicker24.Value = new DateTime(year, 8, 1);
            dateTimePicker25.Value = new DateTime(year, 9, 26);
            dateTimePicker26.Value = new DateTime(year, 9, 19);
            dateTimePicker27.Value = new DateTime(year, 9, 5);
            dateTimePicker28.Value = new DateTime(year, 10, 31);
            dateTimePicker29.Value = new DateTime(year, 10, 17);
            dateTimePicker30.Value = new DateTime(year, 10, 3);
            dateTimePicker31.Value = new DateTime(year, 11, 28);
            dateTimePicker32.Value = new DateTime(year, 11, 21);
            dateTimePicker33.Value = new DateTime(year, 11, 7);
            dateTimePicker34.Value = new DateTime(year, 12, 26);
            dateTimePicker35.Value = new DateTime(year, 12, 19);
            dateTimePicker36.Value = new DateTime(year, 12, 5);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            if (dateTimePicker2.Value.Date <= DateTime.Now ||
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
                dateTimePicker24.Value.Date <= DateTime.Now ||
                dateTimePicker25.Value.Date <= DateTime.Now ||
                dateTimePicker26.Value.Date <= DateTime.Now ||
                dateTimePicker27.Value.Date <= DateTime.Now ||
                dateTimePicker28.Value.Date <= DateTime.Now ||
                dateTimePicker29.Value.Date <= DateTime.Now ||
                dateTimePicker30.Value.Date <= DateTime.Now ||
                dateTimePicker31.Value.Date <= DateTime.Now ||
                dateTimePicker32.Value.Date <= DateTime.Now ||
                dateTimePicker33.Value.Date <= DateTime.Now ||
                dateTimePicker34.Value.Date <= DateTime.Now)
            {
                MessageBox.Show("No se puede guardar fechas anteriores a la fecha actual");


            }
            else
            {
              
            //// 
            if (MessageBox.Show("¿Verifico la fechas a guadar?", "ATENCION",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question)
              == DialogResult.Yes)
            {



                CatalogoPlanilla ca = new CatalogoPlanilla();
                List<Periodicidad> lu = ca.getcodfech();
                this.comboBox109.DataSource = lu;
                this.comboBox109.DisplayMember = "lugartratamiento";

                this.comboBox109.ValueMember = "cod";



                int index = 0;
                int index1 = 0;


                for (int j = list1.Count - 1; j >= 0; j--)
                {
                    string a = "";
                    a = list1[index].ToString();
                    if (lista1.Count != 0)
                    {
                        for (int i = lista1.Count - 1; i >= 0; i--)
                        {
                            dateTimePicker21.Format = DateTimePickerFormat.Custom;
                            dateTimePicker21.CustomFormat = "yyyy-MM-dd";
                            string b = "";
                            b = lista1[index1].ToString();
                            Periodicidad pla = new Periodicidad(dateTimePicker21.Text, Convert.ToInt32(comboBox109.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox63.SelectedValue), Convert.ToInt32(b), "", 0, "TR", "P", "", "Primario", "", "");
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
                        dateTimePicker21.Format = DateTimePickerFormat.Custom;
                        dateTimePicker21.CustomFormat = "yyyy-MM-dd";
                        Periodicidad pla = new Periodicidad(dateTimePicker21.Text, Convert.ToInt32(comboBox109.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox63.SelectedValue), 30, "", 0, "TR", "P", "", "Primario", "", "");
                        ca.addfecha(pla);
                        index1 = 0;
                        index++;
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
                            dateTimePicker20.Format = DateTimePickerFormat.Custom;
                            dateTimePicker20.CustomFormat = "yyyy-MM-dd";
                            string b = "";
                            b = lista2[index1].ToString();
                            Periodicidad pla = new Periodicidad(dateTimePicker20.Text, Convert.ToInt32(comboBox109.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox60.SelectedValue), Convert.ToInt32(b), "", 0, "TR", "P", "", "Primario", "", "");
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
                        dateTimePicker20.Format = DateTimePickerFormat.Custom;

                        dateTimePicker20.CustomFormat = "yyyy-MM-dd";
                        Periodicidad pla = new Periodicidad(dateTimePicker20.Text, Convert.ToInt32(comboBox109.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox60.SelectedValue), 30, "", 0, "TR", "P", "", "Primario", "", "");
                        ca.addfecha(pla);
                        index1 = 0;
                        index++;
                    }

                }












                index = 0;
                index1 = 0;

                for (int j = list3.Count - 1; j >= 0; j--)
                {
                    string a = "";
                    a = list3[index].ToString();
                    if (lista3.Count != 0)
                    {
                        for (int i = lista3.Count - 1; i >= 0; i--)
                        {
                            dateTimePicker19.Format = DateTimePickerFormat.Custom;
                            dateTimePicker19.CustomFormat = "yyyy-MM-dd";
                            string b = "";
                            b = lista3[index1].ToString();
                            Periodicidad pla = new Periodicidad(dateTimePicker19.Text, Convert.ToInt32(comboBox109.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox59.SelectedValue), Convert.ToInt32(b), "", 0, "TR", "P", "", "Primario", "", "");
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
                        dateTimePicker19.Format = DateTimePickerFormat.Custom;

                        dateTimePicker19.CustomFormat = "yyyy-MM-dd";
                        Periodicidad pla = new Periodicidad(dateTimePicker19.Text, Convert.ToInt32(comboBox109.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox59.SelectedValue), 30, "", 0, "TR", "P", "", "Primario", "", "");
                        ca.addfecha(pla);
                        index1 = 0;
                        index++;
                    }

                }







                index = 0;
                index1 = 0;


                for (int j = list4.Count - 1; j >= 0; j--)
                {
                    string a = "";
                    a = list4[index].ToString();
                    if (lista4.Count != 0)
                    {
                        for (int i = lista4.Count - 1; i >= 0; i--)
                        {
                            dateTimePicker24.Format = DateTimePickerFormat.Custom;
                            dateTimePicker24.CustomFormat = "yyyy-MM-dd";
                            string b = "";
                            b = lista4[index1].ToString();
                            Periodicidad pla = new Periodicidad(dateTimePicker24.Text, Convert.ToInt32(comboBox109.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox72.SelectedValue), Convert.ToInt32(b), "", 0, "TR", "P", "", "Primario", "", "");
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
                        dateTimePicker24.Format = DateTimePickerFormat.Custom;

                        dateTimePicker24.CustomFormat = "yyyy-MM-dd";
                        Periodicidad pla = new Periodicidad(dateTimePicker24.Text, Convert.ToInt32(comboBox109.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox72.SelectedValue), 30, "", 0, "TR", "P", "", "Primario", "", "");
                        ca.addfecha(pla);
                        index1 = 0;
                        index++;
                    }

                }

                index = 0;
                index1 = 0;


                for (int j = list5.Count - 1; j >= 0; j--)
                {
                    string a = "";
                    a = list5[index].ToString();
                    if (lista5.Count != 0)
                    {
                        for (int i = lista5.Count - 1; i >= 0; i--)
                        {
                            dateTimePicker23.Format = DateTimePickerFormat.Custom;
                            dateTimePicker23.CustomFormat = "yyyy-MM-dd";
                            string b = "";
                            b = lista5[index1].ToString();
                            Periodicidad pla = new Periodicidad(dateTimePicker23.Text, Convert.ToInt32(comboBox109.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox69.SelectedValue), Convert.ToInt32(b), "", 0, "TR", "P", "", "Primario", "", "");
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
                        dateTimePicker23.Format = DateTimePickerFormat.Custom;

                        dateTimePicker23.CustomFormat = "yyyy-MM-dd";
                        Periodicidad pla = new Periodicidad(dateTimePicker23.Text, Convert.ToInt32(comboBox109.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox69.SelectedValue), 30, "", 0, "TR", "P", "", "Primario", "", "");
                        ca.addfecha(pla);
                        index1 = 0;
                        index++;
                    }

                }

                index = 0;
                index1 = 0;


                for (int j = list6.Count - 1; j >= 0; j--)
                {
                    string a = "";
                    a = list6[index].ToString();
                    if (lista6.Count != 0)
                    {
                        for (int i = lista6.Count - 1; i >= 0; i--)
                        {
                            dateTimePicker22.Format = DateTimePickerFormat.Custom;
                            dateTimePicker22.CustomFormat = "yyyy-MM-dd";
                            string b = "";
                            b = lista6[index1].ToString();
                            Periodicidad pla = new Periodicidad(dateTimePicker22.Text, Convert.ToInt32(comboBox109.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox68.SelectedValue), Convert.ToInt32(b), "", 0, "TR", "P", "", "Primario", "", "");
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
                        dateTimePicker22.Format = DateTimePickerFormat.Custom;

                        dateTimePicker22.CustomFormat = "yyyy-MM-dd";
                        Periodicidad pla = new Periodicidad(dateTimePicker22.Text, Convert.ToInt32(comboBox109.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox68.SelectedValue), 30, "", 0, "TR", "P", "", "Primario", "", "");
                        ca.addfecha(pla);
                        index1 = 0;
                        index++;
                    }

                }

                index = 0;
                index1 = 0;


                for (int j = list7.Count - 1; j >= 0; j--)
                {
                    string a = "";
                    a = list7[index].ToString();
                    if (lista7.Count != 0)
                    {
                        for (int i = lista7.Count - 1; i >= 0; i--)
                        {
                            dateTimePicker27.Format = DateTimePickerFormat.Custom;
                            dateTimePicker27.CustomFormat = "yyyy-MM-dd";
                            string b = "";
                            b = lista7[index1].ToString();
                            Periodicidad pla = new Periodicidad(dateTimePicker27.Text, Convert.ToInt32(comboBox109.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox81.SelectedValue), Convert.ToInt32(b), "", 0, "TR", "P", "", "Primario", "", "");
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
                        dateTimePicker27.Format = DateTimePickerFormat.Custom;

                        dateTimePicker27.CustomFormat = "yyyy-MM-dd";
                        Periodicidad pla = new Periodicidad(dateTimePicker27.Text, Convert.ToInt32(comboBox109.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox81.SelectedValue), 30, "", 0, "TR", "P", "", "Primario", "", "");
                        ca.addfecha(pla);
                        index1 = 0;
                        index++;
                    }

                }



                index = 0;
                index1 = 0;


                for (int j = list8.Count - 1; j >= 0; j--)
                {
                    string a = "";
                    a = list8[index].ToString();
                    if (lista8.Count != 0)
                    {
                        for (int i = lista8.Count - 1; i >= 0; i--)
                        {
                            dateTimePicker26.Format = DateTimePickerFormat.Custom;
                            dateTimePicker26.CustomFormat = "yyyy-MM-dd";
                            string b = "";
                            b = lista8[index1].ToString();
                            Periodicidad pla = new Periodicidad(dateTimePicker26.Text, Convert.ToInt32(comboBox109.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox78.SelectedValue), Convert.ToInt32(b), "", 0, "TR", "P", "", "Primario", "", "");
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
                        dateTimePicker26.Format = DateTimePickerFormat.Custom;

                        dateTimePicker26.CustomFormat = "yyyy-MM-dd";
                        Periodicidad pla = new Periodicidad(dateTimePicker26.Text, Convert.ToInt32(comboBox109.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox78.SelectedValue), 30, "", 0, "TR", "P", "", "Primario", "", "");
                        ca.addfecha(pla);
                        index1 = 0;
                        index++;
                    }

                }



                index = 0;
                index1 = 0;


                for (int j = list9.Count - 1; j >= 0; j--)
                {
                    string a = "";
                    a = list9[index].ToString();
                    if (lista9.Count != 0)
                    {
                        for (int i = lista9.Count - 1; i >= 0; i--)
                        {
                            dateTimePicker25.Format = DateTimePickerFormat.Custom;
                            dateTimePicker25.CustomFormat = "yyyy-MM-dd";
                            string b = "";
                            b = lista9[index1].ToString();
                            Periodicidad pla = new Periodicidad(dateTimePicker25.Text, Convert.ToInt32(comboBox109.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox77.SelectedValue), Convert.ToInt32(b), "", 0, "TR", "P", "", "Primario", "", "");
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
                        dateTimePicker25.Format = DateTimePickerFormat.Custom;

                        dateTimePicker25.CustomFormat = "yyyy-MM-dd";
                        Periodicidad pla = new Periodicidad(dateTimePicker25.Text, Convert.ToInt32(comboBox109.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox77.SelectedValue), 30, "", 0, "TR", "P", "", "Primario", "", "");
                        ca.addfecha(pla);
                        index1 = 0;
                        index++;
                    }

                }

                index = 0;
                index1 = 0;


                for (int j = list10.Count - 1; j >= 0; j--)
                {
                    string a = "";
                    a = list10[index].ToString();
                    if (lista10.Count != 0)
                    {
                        for (int i = lista10.Count - 1; i >= 0; i--)
                        {
                            dateTimePicker30.Format = DateTimePickerFormat.Custom;
                            dateTimePicker30.CustomFormat = "yyyy-MM-dd";
                            string b = "";
                            b = lista10[index1].ToString();
                            Periodicidad pla = new Periodicidad(dateTimePicker30.Text, Convert.ToInt32(comboBox109.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox90.SelectedValue), Convert.ToInt32(b), "", 0, "TR", "P", "", "Primario", "", "");
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
                        dateTimePicker30.Format = DateTimePickerFormat.Custom;

                        dateTimePicker30.CustomFormat = "yyyy-MM-dd";
                        Periodicidad pla = new Periodicidad(dateTimePicker30.Text, Convert.ToInt32(comboBox109.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox90.SelectedValue), 30, "", 0, "TR", "P", "", "Primario", "", "");
                        ca.addfecha(pla);
                        index1 = 0;
                        index++;
                    }

                }


                index = 0;
                index1 = 0;


                for (int j = list11.Count - 1; j >= 0; j--)
                {
                    string a = "";
                    a = list11[index].ToString();
                    if (lista11.Count != 0)
                    {
                        for (int i = lista11.Count - 1; i >= 0; i--)
                        {
                            dateTimePicker29.Format = DateTimePickerFormat.Custom;
                            dateTimePicker29.CustomFormat = "yyyy-MM-dd";
                            string b = "";
                            b = lista11[index1].ToString();
                            Periodicidad pla = new Periodicidad(dateTimePicker29.Text, Convert.ToInt32(comboBox109.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox87.SelectedValue), Convert.ToInt32(b), "", 0, "TR", "P", "", "Primario", "", "");
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
                        dateTimePicker29.Format = DateTimePickerFormat.Custom;

                        dateTimePicker29.CustomFormat = "yyyy-MM-dd";
                        Periodicidad pla = new Periodicidad(dateTimePicker29.Text, Convert.ToInt32(comboBox109.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox87.SelectedValue), 30, "", 0, "TR", "P", "", "Primario", "", "");
                        ca.addfecha(pla);
                        index1 = 0;
                        index++;
                    }

                }

                index = 0;
                index1 = 0;


                for (int j = list12.Count - 1; j >= 0; j--)
                {
                    string a = "";
                    a = list12[index].ToString();
                    if (lista12.Count != 0)
                    {
                        for (int i = lista12.Count - 1; i >= 0; i--)
                        {
                            dateTimePicker28.Format = DateTimePickerFormat.Custom;
                            dateTimePicker28.CustomFormat = "yyyy-MM-dd";
                            string b = "";
                            b = lista12[index1].ToString();
                            Periodicidad pla = new Periodicidad(dateTimePicker28.Text, Convert.ToInt32(comboBox109.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox86.SelectedValue), Convert.ToInt32(b), "", 0, "TR", "P", "", "Primario", "", "");
                            ca.addfecha(pla);

                            if (index1 < lista12.Count - 1)
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
                        dateTimePicker28.Format = DateTimePickerFormat.Custom;

                        dateTimePicker28.CustomFormat = "yyyy-MM-dd";
                        Periodicidad pla = new Periodicidad(dateTimePicker28.Text, Convert.ToInt32(comboBox109.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox86.SelectedValue), 30, "", 0, "TR", "P", "", "Primario", "", "");
                        ca.addfecha(pla);
                        index1 = 0;
                        index++;
                    }

                }

                index = 0;
                index1 = 0;


                for (int j = list13.Count - 1; j >= 0; j--)
                {
                    string a = "";
                    a = list13[index].ToString();
                    if (lista13.Count != 0)
                    {
                        for (int i = lista13.Count - 1; i >= 0; i--)
                        {
                            dateTimePicker33.Format = DateTimePickerFormat.Custom;
                            dateTimePicker33.CustomFormat = "yyyy-MM-dd";
                            string b = "";
                            b = lista13[index1].ToString();
                            Periodicidad pla = new Periodicidad(dateTimePicker33.Text, Convert.ToInt32(comboBox109.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox99.SelectedValue), Convert.ToInt32(b), "", 0, "TR", "P", "", "Primario", "", "");
                            ca.addfecha(pla);

                            if (index1 < lista13.Count - 1)
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
                        dateTimePicker33.Format = DateTimePickerFormat.Custom;

                        dateTimePicker33.CustomFormat = "yyyy-MM-dd";
                        Periodicidad pla = new Periodicidad(dateTimePicker33.Text, Convert.ToInt32(comboBox109.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox99.SelectedValue), 30, "", 0, "TR", "P", "", "Primario", "", "");
                        ca.addfecha(pla);
                        index1 = 0;
                        index++;
                    }

                }

                index = 0;
                index1 = 0;


                for (int j = list14.Count - 1; j >= 0; j--)
                {
                    string a = "";
                    a = list14[index].ToString();
                    if (lista14.Count != 0)
                    {
                        for (int i = lista14.Count - 1; i >= 0; i--)
                        {
                            dateTimePicker32.Format = DateTimePickerFormat.Custom;
                            dateTimePicker32.CustomFormat = "yyyy-MM-dd";
                            string b = "";
                            b = lista14[index1].ToString();
                            Periodicidad pla = new Periodicidad(dateTimePicker32.Text, Convert.ToInt32(comboBox109.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox96.SelectedValue), Convert.ToInt32(b), "", 0, "TR", "P", "", "Primario", "", "");
                            ca.addfecha(pla);

                            if (index1 < lista14.Count - 1)
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
                        dateTimePicker32.Format = DateTimePickerFormat.Custom;

                        dateTimePicker32.CustomFormat = "yyyy-MM-dd";
                        Periodicidad pla = new Periodicidad(dateTimePicker32.Text, Convert.ToInt32(comboBox109.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox96.SelectedValue), 30, "", 0, "TR", "P", "", "Primario", "", "");
                        ca.addfecha(pla);
                        index1 = 0;
                        index++;
                    }

                }

                index = 0;
                index1 = 0;


                for (int j = list15.Count - 1; j >= 0; j--)
                {
                    string a = "";
                    a = list15[index].ToString();
                    if (lista15.Count != 0)
                    {
                        for (int i = lista15.Count - 1; i >= 0; i--)
                        {
                            dateTimePicker31.Format = DateTimePickerFormat.Custom;
                            dateTimePicker31.CustomFormat = "yyyy-MM-dd";
                            string b = "";
                            b = lista15[index1].ToString();
                            Periodicidad pla = new Periodicidad(dateTimePicker31.Text, Convert.ToInt32(comboBox109.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox95.SelectedValue), Convert.ToInt32(b), "", 0, "TR", "P", "", "Primario", "", "");
                            ca.addfecha(pla);

                            if (index1 < lista15.Count - 1)
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
                        dateTimePicker31.Format = DateTimePickerFormat.Custom;

                        dateTimePicker31.CustomFormat = "yyyy-MM-dd";
                        Periodicidad pla = new Periodicidad(dateTimePicker31.Text, Convert.ToInt32(comboBox109.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox95.SelectedValue), 30, "", 0, "TR", "P", "", "Primario", "", "");
                        ca.addfecha(pla);
                        index1 = 0;
                        index++;
                    }

                }


                index = 0;
                index1 = 0;


                for (int j = list16.Count - 1; j >= 0; j--)
                {
                    string a = "";
                    a = list16[index].ToString();
                    if (lista16.Count != 0)
                    {
                        for (int i = lista16.Count - 1; i >= 0; i--)
                        {
                            dateTimePicker36.Format = DateTimePickerFormat.Custom;
                            dateTimePicker36.CustomFormat = "yyyy-MM-dd";
                            string b = "";
                            b = lista16[index1].ToString();
                            Periodicidad pla = new Periodicidad(dateTimePicker36.Text, Convert.ToInt32(comboBox109.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox108.SelectedValue), Convert.ToInt32(b), "", 0, "TR", "P", "", "Primario", "", "");
                            ca.addfecha(pla);

                            if (index1 < lista16.Count - 1)
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
                        dateTimePicker36.Format = DateTimePickerFormat.Custom;

                        dateTimePicker36.CustomFormat = "yyyy-MM-dd";
                        Periodicidad pla = new Periodicidad(dateTimePicker36.Text, Convert.ToInt32(comboBox109.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox108.SelectedValue), 30, "", 0, "TR", "P", "", "Primario", "", "");
                        ca.addfecha(pla);
                        index1 = 0;
                        index++;
                    }

                }


                index = 0;
                index1 = 0;


                for (int j = list17.Count - 1; j >= 0; j--)
                {
                    string a = "";
                    a = list17[index].ToString();
                    if (lista17.Count != 0)
                    {
                        for (int i = lista17.Count - 1; i >= 0; i--)
                        {
                            dateTimePicker35.Format = DateTimePickerFormat.Custom;
                            dateTimePicker35.CustomFormat = "yyyy-MM-dd";
                            string b = "";
                            b = lista17[index1].ToString();
                            Periodicidad pla = new Periodicidad(dateTimePicker35.Text, Convert.ToInt32(comboBox109.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox105.SelectedValue), Convert.ToInt32(b), "", 0, "TR", "P", "", "Primario", "", "");
                            ca.addfecha(pla);

                            if (index1 < lista17.Count - 1)
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
                        dateTimePicker35.Format = DateTimePickerFormat.Custom;

                        dateTimePicker35.CustomFormat = "yyyy-MM-dd";
                        Periodicidad pla = new Periodicidad(dateTimePicker35.Text, Convert.ToInt32(comboBox109.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox105.SelectedValue), 30, "", 0, "TR", "P", "", "Primario", "", "");
                        ca.addfecha(pla);
                        index1 = 0;
                        index++;
                    }

                }


                index = 0;
                index1 = 0;


                for (int j = list18.Count - 1; j >= 0; j--)
                {
                    string a = "";
                    a = list18[index].ToString();
                    if (lista18.Count != 0)
                    {
                        for (int i = lista17.Count - 1; i >= 0; i--)
                        {
                            dateTimePicker34.Format = DateTimePickerFormat.Custom;
                            dateTimePicker34.CustomFormat = "yyyy-MM-dd";
                            string b = "";
                            b = lista18[index1].ToString();
                            Periodicidad pla = new Periodicidad(dateTimePicker34.Text, Convert.ToInt32(comboBox109.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox104.SelectedValue), Convert.ToInt32(b), "", 0, "TR", "P", "", "Primario", "", "");
                            ca.addfecha(pla);

                            if (index1 < lista18.Count - 1)
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
                        dateTimePicker34.Format = DateTimePickerFormat.Custom;

                        dateTimePicker34.CustomFormat = "yyyy-MM-dd";
                        Periodicidad pla = new Periodicidad(dateTimePicker34.Text, Convert.ToInt32(comboBox109.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox104.SelectedValue), 30, "", 0, "TR", "P", "", "Primario", "", "");
                        ca.addfecha(pla);
                        index1 = 0;
                        index++;
                    }

                }
            }
            planificar(list19, lista19, comboBox109, dateTimePicker2, comboBox15);
            planificar(list20, lista20, comboBox109, dateTimePicker1, comboBox1);
            planificar(list21, lista21, comboBox109, dateTimePicker3, comboBox2);
            planificar(list22, lista22, comboBox109, dateTimePicker6, comboBox18);
            planificar(list23, lista23, comboBox109, dateTimePicker5, comboBox13);
            planificar(list24, lista24, comboBox109, dateTimePicker4, comboBox12);
            planificar(list25, lista25, comboBox109, dateTimePicker9, comboBox27);
            planificar(list26, lista26, comboBox109, dateTimePicker8, comboBox24);
            planificar(list27, lista26, comboBox109, dateTimePicker7, comboBox23);
            planificar(list28, lista28, comboBox109, dateTimePicker12, comboBox36);
            planificar(list29, lista29, comboBox109, dateTimePicker11, comboBox33);
            planificar(list30, lista30, comboBox109, dateTimePicker10, comboBox32);
            planificar(list31, lista31, comboBox109, dateTimePicker15, comboBox45);
            planificar(list32, lista32, comboBox109, dateTimePicker14, comboBox42);
            planificar(list33, lista33, comboBox109, dateTimePicker13, comboBox41);
            planificar(list34, lista34, comboBox109, dateTimePicker18, comboBox54);
            planificar(list35, lista35, comboBox109, dateTimePicker17, comboBox51);
            planificar(list36, lista36, comboBox109, dateTimePicker16, comboBox50);
            MessageBox.Show("Ingreso Completado");
            //   }
            this.Close();
             */
        }

        private void comboBox62_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox62.SelectedValue);
                comboBox62.SelectedValue = index;

                list1.Add(index);
            }
        }

        private void comboBox58_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox58.SelectedValue);
                comboBox58.SelectedValue = index;

                list2.Add(index);
            }
        }

        private void comboBox57_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox57.SelectedValue);
                comboBox57.SelectedValue = index;

                list3.Add(index);
            }
        }

        private void comboBox71_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox71.SelectedValue);
                comboBox71.SelectedValue = index;

                list4.Add(index);
            }
        }

        private void comboBox67_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox67.SelectedValue);
                comboBox67.SelectedValue = index;

                list5.Add(index);
            }
        }

        private void comboBox66_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox66.SelectedValue);
                comboBox66.SelectedValue = index;

                list6.Add(index);
            }
        }

        private void comboBox80_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox80.SelectedValue);
                comboBox80.SelectedValue = index;

                list7.Add(index);
            }
        }

        private void comboBox76_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox76.SelectedValue);
                comboBox76.SelectedValue = index;

                list8.Add(index);
            }
        }

        private void comboBox75_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox75.SelectedValue);
                comboBox75.SelectedValue = index;

                list9.Add(index);
            }
        }

        private void comboBox89_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox89.SelectedValue);
                comboBox89.SelectedValue = index;

                list10.Add(index);
            }
        }

        private void comboBox85_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox85.SelectedValue);
                comboBox85.SelectedValue = index;

                list11.Add(index);
            }
        }

        private void comboBox84_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox84.SelectedValue);
                comboBox84.SelectedValue = index;

                list12.Add(index);
            }
        }

        private void comboBox98_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox98.SelectedValue);
                comboBox98.SelectedValue = index;

                list13.Add(index);
            }
        }

        private void comboBox94_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox94.SelectedValue);
                comboBox94.SelectedValue = index;

                list14.Add(index);
            }
        }

        private void comboBox93_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox93.SelectedValue);
                comboBox93.SelectedValue = index;

                list15.Add(index);
            }
        }

        private void comboBox107_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox107.SelectedValue);
                comboBox107.SelectedValue = index;

                list16.Add(index);
            }
        }

        private void comboBox103_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox103.SelectedValue);
                comboBox103.SelectedValue = index;

                list17.Add(index);
            }
        }

        private void comboBox102_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox102.SelectedValue);
                comboBox102.SelectedValue = index;

                list18.Add(index);
            }
        }

        private void comboBox61_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

             

                lista1.Add(comboBox61.Text);
            }
        }

        private void comboBox56_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {



                lista2.Add(comboBox56.Text);
            }
        }

        private void comboBox55_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {



                lista3.Add(comboBox55.Text);
            }
        }

        private void comboBox70_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {



                lista4.Add(comboBox70.Text);
            }
        }

        private void comboBox65_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {



                lista5.Add(comboBox65.Text);
            }
        }

        private void comboBox64_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {



                lista6.Add(comboBox64.Text);
            }
        }

        private void comboBox79_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {



                lista7.Add(comboBox79.Text);
            }
        }

        private void comboBox74_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {



                lista8.Add(comboBox74.Text);
            }
        }

        private void comboBox73_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {



                lista9.Add(comboBox73.Text);
            }
        }

        private void comboBox88_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {


                lista10.Add(comboBox88.Text);
            }
        }

        private void comboBox83_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {



                lista11.Add(comboBox83.Text);
            }
        }

        private void comboBox82_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {



                lista12.Add(comboBox82.Text);
            }
        }

        private void comboBox97_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {



                lista13.Add(comboBox97.Text);
            }
        }

        private void comboBox92_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {


                lista14.Add(comboBox92.Text);
            }
        }

        private void comboBox91_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {



                lista15.Add(comboBox91.Text);
            }
        }

        private void comboBox106_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {



                lista16.Add(comboBox106.Text);
            }
        }

        private void comboBox101_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {



                lista17.Add(comboBox101.Text);
            }
        }

        private void comboBox100_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {



                lista18.Add(comboBox100.Text);
            }
        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox14.SelectedValue);
                comboBox14.SelectedValue = index;

                list19.Add(index);
            }
        }

        private void comboBox109_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

              
             
                lista9.Add(comboBox9.Text);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox3.SelectedValue);
                comboBox3.SelectedValue = index;

                list20.Add(index);
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

              

                lista20.Add(comboBox5.Text);
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox4.SelectedValue);
                comboBox4.SelectedValue = index;

                list21.Add(index);
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                

                lista21.Add(comboBox6.Text);
            }
        }

        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox17.SelectedValue);
                comboBox17.SelectedValue = index;

                list22.Add(index);
            }
        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                

                lista22.Add(comboBox16.Text);
            }
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox11.SelectedValue);
                comboBox11.SelectedValue = index;

                list23.Add(index);
            }
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {


                lista23.Add(comboBox8.Text);
            }
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox10.SelectedValue);
                comboBox10.SelectedValue = index;

                list24.Add(index);
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {



                lista24.Add(comboBox7.Text);
            }
        }

        private void comboBox26_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox26.SelectedValue);
                comboBox26.SelectedValue = index;

                list25.Add(index);
            }
        }

        private void comboBox25_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {


                lista25.Add(comboBox25.Text);
            }
        }

        private void comboBox22_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox22.SelectedValue);
                comboBox22.SelectedValue = index;

                list26.Add(index);
            }
        }

        private void comboBox20_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {


                lista26.Add(comboBox20.Text);
            }
        }

        private void comboBox21_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox21.SelectedValue);
                comboBox21.SelectedValue = index;

                list27.Add(index);
            }
        }

        private void comboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {


                lista27.Add(comboBox19.Text);
            }
        }

        private void comboBox35_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox35.SelectedValue);
                comboBox35.SelectedValue = index;

                list28.Add(index);
            }
        }

        private void comboBox34_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {


                lista28.Add(comboBox34.Text);
            }
        }

        private void comboBox31_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox31.SelectedValue);
                comboBox31.SelectedValue = index;

                list29.Add(index);
            }
        }

        private void comboBox29_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {


                lista29.Add(comboBox29.Text);
            }
        }

        private void comboBox30_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox30.SelectedValue);
                comboBox30.SelectedValue = index;

                list30.Add(index);
            }
        }

        private void comboBox28_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {



                lista30.Add(comboBox28.Text);
            }
        }

        private void comboBox44_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox44.SelectedValue);
                comboBox44.SelectedValue = index;

                list31.Add(index);
            }
        }

        private void comboBox43_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {



                lista31.Add(comboBox43.Text);
            }
        }

        private void comboBox40_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox40.SelectedValue);
                comboBox40.SelectedValue = index;

                list32.Add(index);
            }
        }

        private void comboBox38_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {



                lista32.Add(comboBox38.Text);
            }
        }

        private void comboBox39_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox39.SelectedValue);
                comboBox39.SelectedValue = index;

                list33.Add(index);
            }
        }

        private void comboBox37_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {



                lista33.Add(comboBox37.Text);
            }
        }

        private void comboBox53_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox53.SelectedValue);
                comboBox53.SelectedValue = index;

                list34.Add(index);
            }
        }

        private void comboBox52_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {


                lista34.Add(comboBox52.Text);
            }
        }

        private void comboBox49_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox49.SelectedValue);
                comboBox49.SelectedValue = index;

                list35.Add(index);
            }
        }

        private void comboBox47_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {


                lista35.Add(comboBox47.Text);
            }
        }

        private void comboBox48_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox48.SelectedValue);
                comboBox48.SelectedValue = index;

                list36.Add(index);
            }
        }

        private void comboBox46_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

               

                lista36.Add(comboBox46.Text);
            }
        }

        public void planificar(List<int> listser, List<int> listarea, ComboBox c1, DateTimePicker fecha, ComboBox tec)
        {
            /*
            CatalogoPlanilla ca = new CatalogoPlanilla();
            List<Periodicidad> lu = ca.getcodfech();
            c1.DataSource = lu;
            c1.DisplayMember = "lugartratamiento";

            c1.ValueMember = "cod";



            int index = 0;
            int index1 = 0;

            for (int j = listser.Count - 1; j >= 0; j--)
            {

                string a = "";
                a = listser[index].ToString();
                if (listarea.Count != 0)
                {
                    for (int i = listarea.Count - 1; i >= 0; i--)
                    {
                        fecha.Format = DateTimePickerFormat.Custom;

                        fecha.CustomFormat = "yyyy-MM-dd";
                        string b = "";
                        b = listarea[index1].ToString();
                        Periodicidad pla = new Periodicidad(fecha.Text, Convert.ToInt32(c1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(tec.SelectedValue), Convert.ToInt32(b), "", 0, "TR", "P", "", "Primario", "", "");
                        ca.addfecha(pla);

                        if (index1 < listarea.Count - 1)
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
                    fecha.Format = DateTimePickerFormat.Custom;

                    fecha.CustomFormat = "yyyy-MM-dd";
                    Periodicidad pla = new Periodicidad(fecha.Text, Convert.ToInt32(c1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(tec.SelectedValue), 30, "", 0, "TR", "P", "", "Primario", "", "");
                    ca.addfecha(pla);
                    index1 = 0;
                    index++;

                }
            }
             */

        }

             
    }
}

