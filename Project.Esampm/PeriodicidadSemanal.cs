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
    public partial class PeriodicidadSemanal : Form
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

        List<int> list37 = new List<int>();
        List<int> list38 = new List<int>();
        List<int> list39 = new List<int>();
        List<int> list40 = new List<int>();
        List<int> list41 = new List<int>();
        List<int> list42 = new List<int>();
        List<int> list43 = new List<int>();
        List<int> list44 = new List<int>();
        List<int> list45 = new List<int>();
        List<int> list46 = new List<int>();
        List<int> list47 = new List<int>();
        List<int> list48 = new List<int>();
        List<int> list49 = new List<int>();
        List<int> list50 = new List<int>();
        List<int> list51 = new List<int>();
        List<int> list52 = new List<int>();
        List<int> list53 = new List<int>();
        List<int> list54 = new List<int>();
        List<int> list55 = new List<int>();
        List<int> list56 = new List<int>();
        List<int> list57 = new List<int>();
        List<int> list58 = new List<int>();
        List<int> list59 = new List<int>();
        List<int> list60 = new List<int>();




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
        List<int> lista12 = new List<int>();
        List<int> lista13 = new List<int>();
        List<int> lista14 = new List<int>();
        List<int> lista15 = new List<int>();
        List<int> lista16 = new List<int>();
        List<int> lista17 = new List<int>();
        List<int> lista18 = new List<int>();
        List<int> lista19 = new List<int>();
        List<int> lista20 = new List<int>();
        List<int> lista21 = new List<int>();
        List<int> lista22 = new List<int>();
        List<int> lista23 = new List<int>();
        List<int> lista24 = new List<int>();
        List<int> lista25 = new List<int>();
        List<int> lista26 = new List<int>();
        List<int> lista27 = new List<int>();
        List<int> lista28 = new List<int>();
        List<int> lista29 = new List<int>();
        List<int> lista30 = new List<int>();
        List<int> lista31 = new List<int>();
        List<int> lista32 = new List<int>();
        List<int> lista33 = new List<int>();
        List<int> lista34 = new List<int>();
        List<int> lista35 = new List<int>();
        List<int> lista36 = new List<int>();


        List<int> lista37 = new List<int>();
        List<int> lista38 = new List<int>();
        List<int> lista39 = new List<int>();
        List<int> lista40 = new List<int>();
        List<int> lista41 = new List<int>();
        List<int> lista42 = new List<int>();
        List<int> lista43 = new List<int>();
        List<int> lista44 = new List<int>();
        List<int> lista45 = new List<int>();
        List<int> lista46 = new List<int>();
        List<int> lista47 = new List<int>();
        List<int> lista48 = new List<int>();
        List<int> lista49 = new List<int>();
        List<int> lista50 = new List<int>();
        List<int> lista51 = new List<int>();
        List<int> lista52 = new List<int>();
        List<int> lista53 = new List<int>();
        List<int> lista54 = new List<int>();
        List<int> lista55 = new List<int>();
        List<int> lista56 = new List<int>();
        List<int> lista57 = new List<int>();
        List<int> lista58 = new List<int>();
        List<int> lista59 = new List<int>();
        List<int> lista60 = new List<int>();
        public PeriodicidadSemanal()
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
            List<Project.BussinessRules.Tecnico> tec37 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec38 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec39 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec40 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec41 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec42 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec43 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec44 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec45 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec46 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec47 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec48 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec49 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec50 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec51 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec52 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec53 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec54 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec55 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec56 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec57 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec58 = tunits.obtenertec();
            List<Project.BussinessRules.Tecnico> tec59 = tunits.obtenertec();




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
            this.comboBox20.DataSource = tec18;
            this.comboBox20.DisplayMember = "nombre";
            this.comboBox20.ValueMember = "cod";
            this.comboBox21.DataSource = tec19;
            this.comboBox21.DisplayMember = "nombre";
            this.comboBox21.ValueMember = "cod";
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
            this.comboBox26.DataSource = tec24;
            this.comboBox26.DisplayMember = "nombre";
            this.comboBox26.ValueMember = "cod";
            this.comboBox27.DataSource = tec25;
            this.comboBox27.DisplayMember = "nombre";
            this.comboBox27.ValueMember = "cod";
            this.comboBox28.DataSource = tec26;
            this.comboBox28.DisplayMember = "nombre";
            this.comboBox28.ValueMember = "cod";
            this.comboBox29.DataSource = tec27;
            this.comboBox29.DisplayMember = "nombre";
            this.comboBox29.ValueMember = "cod";
            this.comboBox30.DataSource = tec28;
            this.comboBox30.DisplayMember = "nombre";
            this.comboBox30.ValueMember = "cod";
            this.comboBox31.DataSource = tec29;
            this.comboBox31.DisplayMember = "nombre";
            this.comboBox31.ValueMember = "cod";
            this.comboBox32.DataSource = tec30;
            this.comboBox32.DisplayMember = "nombre";
            this.comboBox32.ValueMember = "cod";
            this.comboBox33.DataSource = tec31;
            this.comboBox33.DisplayMember = "nombre";
            this.comboBox33.ValueMember = "cod";
            this.comboBox34.DataSource = tec32;
            this.comboBox34.DisplayMember = "nombre";
            this.comboBox34.ValueMember = "cod";
            this.comboBox35.DataSource = tec33;
            this.comboBox35.DisplayMember = "nombre";
            this.comboBox35.ValueMember = "cod";
            this.comboBox36.DataSource = tec34;
            this.comboBox36.DisplayMember = "nombre";
            this.comboBox36.ValueMember = "cod";
            this.comboBox37.DataSource = tec35;
            this.comboBox37.DisplayMember = "nombre";
            this.comboBox37.ValueMember = "cod";
            this.comboBox38.DataSource = tec36;
            this.comboBox38.DisplayMember = "nombre";
            this.comboBox38.ValueMember = "cod";
            this.comboBox39.DataSource = tec37;
            this.comboBox39.DisplayMember = "nombre";
            this.comboBox39.ValueMember = "cod";
            this.comboBox40.DataSource = tec38;
            this.comboBox40.DisplayMember = "nombre";
            this.comboBox40.ValueMember = "cod";
            this.comboBox41.DataSource = tec39;
            this.comboBox41.DisplayMember = "nombre";
            this.comboBox41.ValueMember = "cod";
            this.comboBox42.DataSource = tec40;
            this.comboBox42.DisplayMember = "nombre";
            this.comboBox42.ValueMember = "cod";
            this.comboBox43.DataSource = tec41;
            this.comboBox43.DisplayMember = "nombre";
            this.comboBox43.ValueMember = "cod";
            this.comboBox44.DataSource = tec42;
            this.comboBox44.DisplayMember = "nombre";
            this.comboBox44.ValueMember = "cod";
            this.comboBox45.DataSource = tec43;
            this.comboBox45.DisplayMember = "nombre";
            this.comboBox45.ValueMember = "cod";
            this.comboBox46.DataSource = tec44;
            this.comboBox46.DisplayMember = "nombre";
            this.comboBox46.ValueMember = "cod";
            this.comboBox47.DataSource = tec45;
            this.comboBox47.DisplayMember = "nombre";
            this.comboBox47.ValueMember = "cod";
            this.comboBox48.DataSource = tec46;
            this.comboBox48.DisplayMember = "nombre";
            this.comboBox48.ValueMember = "cod";
            this.comboBox49.DataSource = tec47;
            this.comboBox49.DisplayMember = "nombre";
            this.comboBox49.ValueMember = "cod";
            this.comboBox50.DataSource = tec48;
            this.comboBox50.DisplayMember = "nombre";
            this.comboBox50.ValueMember = "cod";
            this.comboBox51.DataSource = tec49;
            this.comboBox51.DisplayMember = "nombre";
            this.comboBox51.ValueMember = "cod";
            this.comboBox52.DataSource = tec50;
            this.comboBox52.DisplayMember = "nombre";
            this.comboBox52.ValueMember = "cod";
            this.comboBox53.DataSource = tec51;
            this.comboBox53.DisplayMember = "nombre";
            this.comboBox53.ValueMember = "cod";
            this.comboBox54.DataSource = tec52;
            this.comboBox54.DisplayMember = "nombre";
            this.comboBox54.ValueMember = "cod";
            this.comboBox55.DataSource = tec53;
            this.comboBox55.DisplayMember = "nombre";
            this.comboBox55.ValueMember = "cod";
            this.comboBox56.DataSource = tec54;
            this.comboBox56.DisplayMember = "nombre";
            this.comboBox56.ValueMember = "cod";
            this.comboBox57.DataSource = tec55;
            this.comboBox57.DisplayMember = "nombre";
            this.comboBox57.ValueMember = "cod";
            this.comboBox58.DataSource = tec56;
            this.comboBox58.DisplayMember = "nombre";
            this.comboBox58.ValueMember = "cod";
            this.comboBox59.DataSource = tec57;
            this.comboBox59.DisplayMember = "nombre";
            this.comboBox59.ValueMember = "cod";
            this.comboBox60.DataSource = tec58;
            this.comboBox60.DisplayMember = "nombre";
            this.comboBox60.ValueMember = "cod";
            this.comboBox61.DataSource = tec59;
            this.comboBox61.DisplayMember = "nombre";
            this.comboBox61.ValueMember = "cod";


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
            List<Project.BussinessRules.servicio> ser37 = sunits.getser();
            List<Project.BussinessRules.servicio> ser38 = sunits.getser();
            List<Project.BussinessRules.servicio> ser39 = sunits.getser();
            List<Project.BussinessRules.servicio> ser40 = sunits.getser();
            List<Project.BussinessRules.servicio> ser41 = sunits.getser();
            List<Project.BussinessRules.servicio> ser42 = sunits.getser();
            List<Project.BussinessRules.servicio> ser43 = sunits.getser();
            List<Project.BussinessRules.servicio> ser44 = sunits.getser();
            List<Project.BussinessRules.servicio> ser45 = sunits.getser();
            List<Project.BussinessRules.servicio> ser46 = sunits.getser();
            List<Project.BussinessRules.servicio> ser47 = sunits.getser();
            List<Project.BussinessRules.servicio> ser48 = sunits.getser();
            List<Project.BussinessRules.servicio> ser49 = sunits.getser();
            List<Project.BussinessRules.servicio> ser50 = sunits.getser();
            List<Project.BussinessRules.servicio> ser51 = sunits.getser();
            List<Project.BussinessRules.servicio> ser52 = sunits.getser();
            List<Project.BussinessRules.servicio> ser53 = sunits.getser();
            List<Project.BussinessRules.servicio> ser54 = sunits.getser();
            List<Project.BussinessRules.servicio> ser55 = sunits.getser();
            List<Project.BussinessRules.servicio> ser56 = sunits.getser();
            List<Project.BussinessRules.servicio> ser57 = sunits.getser();
            List<Project.BussinessRules.servicio> ser58 = sunits.getser();
            List<Project.BussinessRules.servicio> ser59 = sunits.getser();


            this.comboBox62.DataSource = ser;
            this.comboBox62.DisplayMember = "sigla";
            this.comboBox62.ValueMember = "cod";
            this.comboBox63.DataSource = ser1;
            this.comboBox63.DisplayMember = "sigla";
            this.comboBox63.ValueMember = "cod";
            this.comboBox64.DataSource = ser2;
            this.comboBox64.DisplayMember = "sigla";
            this.comboBox64.ValueMember = "cod";
            this.comboBox65.DataSource = ser3;
            this.comboBox65.DisplayMember = "sigla";
            this.comboBox65.ValueMember = "cod";
            this.comboBox66.DataSource = ser3;
            this.comboBox66.DisplayMember = "sigla";
            this.comboBox66.ValueMember = "cod";
            this.comboBox67.DataSource = ser4;
            this.comboBox67.DisplayMember = "sigla";
            this.comboBox67.ValueMember = "cod";
            this.comboBox68.DataSource = ser5;
            this.comboBox68.DisplayMember = "sigla";
            this.comboBox68.ValueMember = "cod";
            this.comboBox69.DataSource = ser6;
            this.comboBox69.DisplayMember = "sigla";
            this.comboBox69.ValueMember = "cod";
            this.comboBox70.DataSource = ser7;
            this.comboBox70.DisplayMember = "sigla";
            this.comboBox70.ValueMember = "cod";
            this.comboBox71.DataSource = ser8;
            this.comboBox71.DisplayMember = "sigla";
            this.comboBox71.ValueMember = "cod";
            this.comboBox72.DataSource = ser9;
            this.comboBox72.DisplayMember = "sigla";
            this.comboBox72.ValueMember = "cod";
            this.comboBox73.DataSource = ser10;
            this.comboBox73.DisplayMember = "sigla";
            this.comboBox73.ValueMember = "cod";
            this.comboBox74.DataSource = ser11;
            this.comboBox74.DisplayMember = "sigla";
            this.comboBox74.ValueMember = "cod";
            this.comboBox75.DataSource = ser12;
            this.comboBox75.DisplayMember = "sigla";
            this.comboBox75.ValueMember = "cod";
            this.comboBox76.DataSource = ser13;
            this.comboBox76.DisplayMember = "sigla";
            this.comboBox76.ValueMember = "cod";
            this.comboBox77.DataSource = ser14;
            this.comboBox77.DisplayMember = "sigla";
            this.comboBox77.ValueMember = "cod";
            this.comboBox78.DataSource = ser15;
            this.comboBox78.DisplayMember = "sigla";
            this.comboBox78.ValueMember = "cod";
            this.comboBox79.DataSource = ser16;
            this.comboBox79.DisplayMember = "sigla";
            this.comboBox79.ValueMember = "cod";
            this.comboBox80.DataSource = ser17;
            this.comboBox80.DisplayMember = "sigla";
            this.comboBox80.ValueMember = "cod";
            this.comboBox81.DataSource = ser18;
            this.comboBox81.DisplayMember = "sigla";
            this.comboBox81.ValueMember = "cod";
            this.comboBox82.DataSource = ser19;
            this.comboBox82.DisplayMember = "sigla";
            this.comboBox82.ValueMember = "cod";
            this.comboBox83.DataSource = ser20;
            this.comboBox83.DisplayMember = "sigla";
            this.comboBox83.ValueMember = "cod";
            this.comboBox84.DataSource = ser21;
            this.comboBox84.DisplayMember = "sigla";
            this.comboBox84.ValueMember = "cod";
            this.comboBox85.DataSource = ser22;
            this.comboBox85.DisplayMember = "sigla";
            this.comboBox85.ValueMember = "cod";
            this.comboBox86.DataSource = ser23;
            this.comboBox86.DisplayMember = "sigla";
            this.comboBox86.ValueMember = "cod";
            this.comboBox87.DataSource = ser24;
            this.comboBox87.DisplayMember = "sigla";
            this.comboBox87.ValueMember = "cod";
            this.comboBox88.DataSource = ser25;
            this.comboBox88.DisplayMember = "sigla";
            this.comboBox88.ValueMember = "cod";
            this.comboBox89.DataSource = ser26;
            this.comboBox89.DisplayMember = "sigla";
            this.comboBox89.ValueMember = "cod";
            this.comboBox90.DataSource = ser27;
            this.comboBox90.DisplayMember = "sigla";
            this.comboBox90.ValueMember = "cod";
            this.comboBox91.DataSource = ser28;
            this.comboBox91.DisplayMember = "sigla";
            this.comboBox91.ValueMember = "cod";
            this.comboBox92.DataSource = ser29;
            this.comboBox92.DisplayMember = "sigla";
            this.comboBox92.ValueMember = "cod";
            this.comboBox93.DataSource = ser30;
            this.comboBox93.DisplayMember = "sigla";
            this.comboBox93.ValueMember = "cod";
            this.comboBox94.DataSource = ser31;
            this.comboBox94.DisplayMember = "sigla";
            this.comboBox94.ValueMember = "cod";
            this.comboBox95.DataSource = ser32;
            this.comboBox95.DisplayMember = "sigla";
            this.comboBox95.ValueMember = "cod";
            this.comboBox96.DataSource = ser33;
            this.comboBox96.DisplayMember = "sigla";
            this.comboBox96.ValueMember = "cod";
            this.comboBox97.DataSource = ser34;
            this.comboBox97.DisplayMember = "sigla";
            this.comboBox97.ValueMember = "cod";
            this.comboBox98.DataSource = ser35;
            this.comboBox98.DisplayMember = "sigla";
            this.comboBox98.ValueMember = "cod";
            this.comboBox99.DataSource = ser36;
            this.comboBox99.DisplayMember = "sigla";
            this.comboBox99.ValueMember = "cod";
            this.comboBox100.DataSource = ser37;
            this.comboBox100.DisplayMember = "sigla";
            this.comboBox100.ValueMember = "cod";
            this.comboBox101.DataSource = ser38;
            this.comboBox101.DisplayMember = "sigla";
            this.comboBox101.ValueMember = "cod";
            this.comboBox102.DataSource = ser39;
            this.comboBox102.DisplayMember = "sigla";
            this.comboBox102.ValueMember = "cod";
            this.comboBox103.DataSource = ser40;
            this.comboBox103.DisplayMember = "sigla";
            this.comboBox103.ValueMember = "cod";
            this.comboBox104.DataSource = ser41;
            this.comboBox104.DisplayMember = "sigla";
            this.comboBox104.ValueMember = "cod";
            this.comboBox105.DataSource = ser42;
            this.comboBox105.DisplayMember = "sigla";
            this.comboBox105.ValueMember = "cod";
            this.comboBox106.DataSource = ser43;
            this.comboBox106.DisplayMember = "sigla";
            this.comboBox106.ValueMember = "cod";
            this.comboBox107.DataSource = ser44;
            this.comboBox107.DisplayMember = "sigla";
            this.comboBox107.ValueMember = "cod";
            this.comboBox108.DataSource = ser45;
            this.comboBox108.DisplayMember = "sigla";
            this.comboBox108.ValueMember = "cod";
            this.comboBox109.DataSource = ser46;
            this.comboBox109.DisplayMember = "sigla";
            this.comboBox109.ValueMember = "cod";
            this.comboBox110.DataSource = ser47;
            this.comboBox110.DisplayMember = "sigla";
            this.comboBox110.ValueMember = "cod";
            this.comboBox111.DataSource = ser48;
            this.comboBox111.DisplayMember = "sigla";
            this.comboBox111.ValueMember = "cod";
            this.comboBox112.DataSource = ser49;
            this.comboBox112.DisplayMember = "sigla";
            this.comboBox112.ValueMember = "cod";
            this.comboBox113.DataSource = ser50;
            this.comboBox113.DisplayMember = "sigla";
            this.comboBox113.ValueMember = "cod";
            this.comboBox114.DataSource = ser51;
            this.comboBox114.DisplayMember = "sigla";
            this.comboBox114.ValueMember = "cod";
            this.comboBox115.DataSource = ser52;
            this.comboBox115.DisplayMember = "sigla";
            this.comboBox115.ValueMember = "cod";
            this.comboBox116.DataSource = ser53;
            this.comboBox116.DisplayMember = "sigla";
            this.comboBox116.ValueMember = "cod";
            this.comboBox117.DataSource = ser54;
            this.comboBox117.DisplayMember = "sigla";
            this.comboBox117.ValueMember = "cod";
            this.comboBox118.DataSource = ser55;
            this.comboBox118.DisplayMember = "sigla";
            this.comboBox118.ValueMember = "cod";
            this.comboBox119.DataSource = ser56;
            this.comboBox119.DisplayMember = "sigla";
            this.comboBox119.ValueMember = "cod";
            this.comboBox120.DataSource = ser57;
            this.comboBox120.DisplayMember = "sigla";
            this.comboBox120.ValueMember = "cod";
            this.comboBox121.DataSource = ser58;
            this.comboBox121.DisplayMember = "sigla";
            this.comboBox121.ValueMember = "cod";


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
            List<Area> are37 = aunits.getarea();
            List<Area> are38 = aunits.getarea();
            List<Area> are39 = aunits.getarea();
            List<Area> are40 = aunits.getarea();
            List<Area> are41 = aunits.getarea();
            List<Area> are42 = aunits.getarea();
            List<Area> are43 = aunits.getarea();
            List<Area> are44 = aunits.getarea();
            List<Area> are45 = aunits.getarea();
            List<Area> are46 = aunits.getarea();
            List<Area> are47 = aunits.getarea();
            List<Area> are48 = aunits.getarea();
            List<Area> are49 = aunits.getarea();
            List<Area> are50 = aunits.getarea();
            List<Area> are51 = aunits.getarea();
            List<Area> are52 = aunits.getarea();
            List<Area> are53 = aunits.getarea();
            List<Area> are54 = aunits.getarea();
            List<Area> are55 = aunits.getarea();
            List<Area> are56 = aunits.getarea();
            List<Area> are57 = aunits.getarea();
            List<Area> are58 = aunits.getarea();
            List<Area> are59 = aunits.getarea();
           

            this.comboBox122.DataSource = are;
            this.comboBox122.DisplayMember = "NombreArea";
            this.comboBox122.ValueMember = "cod";
            this.comboBox123.DataSource = are1;
            this.comboBox123.DisplayMember = "NombreArea";
            this.comboBox123.ValueMember = "cod";
            this.comboBox124.DataSource = are2;
            this.comboBox124.DisplayMember = "NombreArea";
            this.comboBox124.ValueMember = "cod";
            this.comboBox125.DataSource = are3;
            this.comboBox125.DisplayMember = "NombreArea";
            this.comboBox125.ValueMember = "cod";
            this.comboBox126.DataSource = are4;
            this.comboBox126.DisplayMember = "NombreArea";
            this.comboBox126.ValueMember = "cod";
            this.comboBox127.DataSource = are5;
            this.comboBox127.DisplayMember = "NombreArea";
            this.comboBox127.ValueMember = "cod";
            this.comboBox128.DataSource = are6;
            this.comboBox128.DisplayMember = "NombreArea";
            this.comboBox128.ValueMember = "cod";
            this.comboBox129.DataSource = are7;
            this.comboBox129.DisplayMember = "NombreArea";
            this.comboBox129.ValueMember = "cod";
            this.comboBox130.DataSource = are8;
            this.comboBox130.DisplayMember = "NombreArea";
            this.comboBox130.ValueMember = "cod";
            this.comboBox131.DataSource = are9;
            this.comboBox131.DisplayMember = "NombreArea";
            this.comboBox131.ValueMember = "cod";
            this.comboBox132.DataSource = are10;
            this.comboBox132.DisplayMember = "NombreArea";
            this.comboBox132.ValueMember = "cod";
            this.comboBox133.DataSource = are11;
            this.comboBox133.DisplayMember = "NombreArea";
            this.comboBox133.ValueMember = "cod";
            this.comboBox134.DataSource = are12;
            this.comboBox134.DisplayMember = "NombreArea";
            this.comboBox134.ValueMember = "cod";
            this.comboBox135.DataSource = are13;
            this.comboBox135.DisplayMember = "NombreArea";
            this.comboBox135.ValueMember = "cod";
            this.comboBox136.DataSource = are14;
            this.comboBox136.DisplayMember = "NombreArea";
            this.comboBox136.ValueMember = "cod";
            this.comboBox137.DataSource = are15;
            this.comboBox137.DisplayMember = "NombreArea";
            this.comboBox137.ValueMember = "cod";
            this.comboBox138.DataSource = are16;
            this.comboBox138.DisplayMember = "NombreArea";
            this.comboBox138.ValueMember = "cod";
            this.comboBox139.DataSource = are17;
            this.comboBox139.DisplayMember = "NombreArea";
            this.comboBox139.ValueMember = "cod";
            this.comboBox140.DataSource = are18;
            this.comboBox140.DisplayMember = "NombreArea";
            this.comboBox140.ValueMember = "cod";
            this.comboBox141.DataSource = are19;
            this.comboBox141.DisplayMember = "NombreArea";
            this.comboBox141.ValueMember = "cod";


            this.comboBox146.DataSource = are20;
            this.comboBox146.DisplayMember = "NombreArea";
            this.comboBox146.ValueMember = "cod";
            this.comboBox145.DataSource = are21;
            this.comboBox145.DisplayMember = "NombreArea";
            this.comboBox145.ValueMember = "cod";
            this.comboBox144.DataSource = are22;
            this.comboBox144.DisplayMember = "NombreArea";
            this.comboBox144.ValueMember = "cod";
            this.comboBox143.DataSource = are23;
            this.comboBox143.DisplayMember = "NombreArea";
            this.comboBox143.ValueMember = "cod";
            this.comboBox142.DataSource = are24;
            this.comboBox142.DisplayMember = "NombreArea";
            this.comboBox142.ValueMember = "cod";
            this.comboBox151.DataSource = are25;
            this.comboBox151.DisplayMember = "NombreArea";
            this.comboBox151.ValueMember = "cod";
            this.comboBox150.DataSource = are26;
            this.comboBox150.DisplayMember = "NombreArea";
            this.comboBox150.ValueMember = "cod";
            this.comboBox149.DataSource = are27;
            this.comboBox149.DisplayMember = "NombreArea";
            this.comboBox149.ValueMember = "cod";
            this.comboBox148.DataSource = are28;
            this.comboBox148.DisplayMember = "NombreArea";
            this.comboBox148.ValueMember = "cod";
            this.comboBox147.DataSource = are29;
            this.comboBox147.DisplayMember = "NombreArea";
            this.comboBox147.ValueMember = "cod";
            this.comboBox156.DataSource = are30;
            this.comboBox156.DisplayMember = "NombreArea";
            this.comboBox156.ValueMember = "cod";
            this.comboBox155.DataSource = are31;
            this.comboBox155.DisplayMember = "NombreArea";
            this.comboBox155.ValueMember = "cod";
            this.comboBox154.DataSource = are32;
            this.comboBox154.DisplayMember = "NombreArea";
            this.comboBox154.ValueMember = "cod";
            this.comboBox153.DataSource = are33;
            this.comboBox153.DisplayMember = "NombreArea";
            this.comboBox153.ValueMember = "cod";
            this.comboBox152.DataSource = are34;
            this.comboBox152.DisplayMember = "NombreArea";
            this.comboBox152.ValueMember = "cod";
            this.comboBox161.DataSource = are35;
            this.comboBox161.DisplayMember = "NombreArea";
            this.comboBox161.ValueMember = "cod";
            this.comboBox160.DataSource = are36;
            this.comboBox160.DisplayMember = "NombreArea";
            this.comboBox160.ValueMember = "cod";
            this.comboBox159.DataSource = are37;
            this.comboBox159.DisplayMember = "NombreArea";
            this.comboBox159.ValueMember = "cod";
            this.comboBox158.DataSource = are38;
            this.comboBox158.DisplayMember = "NombreArea";
            this.comboBox158.ValueMember = "cod";
            this.comboBox157.DataSource = are39;
            this.comboBox157.DisplayMember = "NombreArea";
            this.comboBox157.ValueMember = "cod";




            this.comboBox166.DataSource = are40;
            this.comboBox166.DisplayMember = "NombreArea";
            this.comboBox166.ValueMember = "cod";
            this.comboBox165.DataSource = are41;
            this.comboBox165.DisplayMember = "NombreArea";
            this.comboBox165.ValueMember = "cod";
            this.comboBox164.DataSource = are42;
            this.comboBox164.DisplayMember = "NombreArea";
            this.comboBox164.ValueMember = "cod";
            this.comboBox163.DataSource = are43;
            this.comboBox163.DisplayMember = "NombreArea";
            this.comboBox163.ValueMember = "cod";
            this.comboBox162.DataSource = are44;
            this.comboBox162.DisplayMember = "NombreArea";
            this.comboBox162.ValueMember = "cod";
            this.comboBox171.DataSource = are45;
            this.comboBox171.DisplayMember = "NombreArea";
            this.comboBox171.ValueMember = "cod";
            this.comboBox170.DataSource = are46;
            this.comboBox170.DisplayMember = "NombreArea";
            this.comboBox170.ValueMember = "cod";
            this.comboBox169.DataSource = are47;
            this.comboBox169.DisplayMember = "NombreArea";
            this.comboBox169.ValueMember = "cod";
            this.comboBox168.DataSource = are48;
            this.comboBox168.DisplayMember = "NombreArea";
            this.comboBox168.ValueMember = "cod";
            this.comboBox167.DataSource = are49;
            this.comboBox167.DisplayMember = "NombreArea";
            this.comboBox167.ValueMember = "cod";
            this.comboBox176.DataSource = are50;
            this.comboBox176.DisplayMember = "NombreArea";
            this.comboBox176.ValueMember = "cod";
            this.comboBox175.DataSource = are51;
            this.comboBox175.DisplayMember = "NombreArea";
            this.comboBox175.ValueMember = "cod";
            this.comboBox174.DataSource = are52;
            this.comboBox174.DisplayMember = "NombreArea";
            this.comboBox174.ValueMember = "cod";
            this.comboBox173.DataSource = are53;
            this.comboBox173.DisplayMember = "NombreArea";
            this.comboBox173.ValueMember = "cod";
            this.comboBox172.DataSource = are54;
            this.comboBox172.DisplayMember = "NombreArea";
            this.comboBox172.ValueMember = "cod";
            this.comboBox181.DataSource = are55;
            this.comboBox181.DisplayMember = "NombreArea";
            this.comboBox181.ValueMember = "cod";
            this.comboBox180.DataSource = are56;
            this.comboBox180.DisplayMember = "NombreArea";
            this.comboBox180.ValueMember = "cod";
            this.comboBox179.DataSource = are57;
            this.comboBox179.DisplayMember = "NombreArea";
            this.comboBox179.ValueMember = "cod";
            this.comboBox178.DataSource = are58;
            this.comboBox178.DisplayMember = "NombreArea";
            this.comboBox178.ValueMember = "cod";
            this.comboBox177.DataSource = are59;
            this.comboBox177.DisplayMember = "NombreArea";
            this.comboBox177.ValueMember = "cod";

            registro = true;


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PeriodicidadSemanal_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            DateTime fecha = new DateTime();
            int day = fecha.Day;
            int month = fecha.Month;
            int year = Convert.ToInt32(textBox1.Text);
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
            dateTimePicker37.Format = DateTimePickerFormat.Custom;
            dateTimePicker37.CustomFormat = "dd-MM-yyyy";
            dateTimePicker38.Format = DateTimePickerFormat.Custom;
            dateTimePicker38.CustomFormat = "dd-MM-yyyy";
            dateTimePicker39.Format = DateTimePickerFormat.Custom;
            dateTimePicker39.CustomFormat = "dd-MM-yyyy";
            dateTimePicker40.Format = DateTimePickerFormat.Custom;
            dateTimePicker40.CustomFormat = "dd-MM-yyyy";
            dateTimePicker41.Format = DateTimePickerFormat.Custom;
            dateTimePicker41.CustomFormat = "dd-MM-yyyy";
            dateTimePicker42.Format = DateTimePickerFormat.Custom;
            dateTimePicker42.CustomFormat = "dd-MM-yyyy";
            dateTimePicker43.Format = DateTimePickerFormat.Custom;
            dateTimePicker43.CustomFormat = "dd-MM-yyyy";
            dateTimePicker44.Format = DateTimePickerFormat.Custom;
            dateTimePicker44.CustomFormat = "dd-MM-yyyy";
            dateTimePicker45.Format = DateTimePickerFormat.Custom;
            dateTimePicker45.CustomFormat = "dd-MM-yyyy";
            dateTimePicker46.Format = DateTimePickerFormat.Custom;
            dateTimePicker46.CustomFormat = "dd-MM-yyyy";
            dateTimePicker47.Format = DateTimePickerFormat.Custom;
            dateTimePicker47.CustomFormat = "dd-MM-yyyy";
            dateTimePicker48.Format = DateTimePickerFormat.Custom;
            dateTimePicker48.CustomFormat = "dd-MM-yyyy";
            dateTimePicker49.Format = DateTimePickerFormat.Custom;
            dateTimePicker49.CustomFormat = "dd-MM-yyyy";
            dateTimePicker50.Format = DateTimePickerFormat.Custom;
            dateTimePicker50.CustomFormat = "dd-MM-yyyy";
            dateTimePicker51.Format = DateTimePickerFormat.Custom;
            dateTimePicker51.CustomFormat = "dd-MM-yyyy";
            dateTimePicker52.Format = DateTimePickerFormat.Custom;
            dateTimePicker52.CustomFormat = "dd-MM-yyyy";
            dateTimePicker53.Format = DateTimePickerFormat.Custom;
            dateTimePicker53.CustomFormat = "dd-MM-yyyy";
            dateTimePicker54.Format = DateTimePickerFormat.Custom;
            dateTimePicker54.CustomFormat = "dd-MM-yyyy";
            dateTimePicker55.Format = DateTimePickerFormat.Custom;
            dateTimePicker55.CustomFormat = "dd-MM-yyyy";
            dateTimePicker56.Format = DateTimePickerFormat.Custom;
            dateTimePicker56.CustomFormat = "dd-MM-yyyy";
            dateTimePicker57.Format = DateTimePickerFormat.Custom;
            dateTimePicker57.CustomFormat = "dd-MM-yyyy";
            dateTimePicker58.Format = DateTimePickerFormat.Custom;
            dateTimePicker58.CustomFormat = "dd-MM-yyyy";
            dateTimePicker59.Format = DateTimePickerFormat.Custom;
            dateTimePicker59.CustomFormat = "dd-MM-yyyy";
            dateTimePicker60.Format = DateTimePickerFormat.Custom;
            dateTimePicker60.CustomFormat = "dd-MM-yyyy";
            dateTimePicker2.Value = new DateTime(year, 1, 3);
            dateTimePicker3.Value = new DateTime(year, 1, 10);
            dateTimePicker4.Value = new DateTime(year, 1, 17);
            dateTimePicker5.Value = new DateTime(year, 1, 15);
            dateTimePicker6.Value = new DateTime(year, 2, 1);
            dateTimePicker7.Value = new DateTime(year, 2, 7);
            dateTimePicker8.Value = new DateTime(year, 2, 14);
            dateTimePicker9.Value = new DateTime(year, 2, 21);
            dateTimePicker10.Value = new DateTime(year, 2, 28);
            dateTimePicker11.Value = new DateTime(year, 3, 1);
            dateTimePicker12.Value = new DateTime(year, 3, 6);
            dateTimePicker13.Value = new DateTime(year, 3, 13);
            dateTimePicker14.Value = new DateTime(year, 3, 20);
            dateTimePicker15.Value = new DateTime(year, 3, 27);
            dateTimePicker16.Value = new DateTime(year, 4, 1);
            dateTimePicker17.Value = new DateTime(year, 4, 3);
            dateTimePicker18.Value = new DateTime(year, 4, 10);
            dateTimePicker19.Value = new DateTime(year, 4, 17);
            dateTimePicker20.Value = new DateTime(year, 4, 24);
            dateTimePicker21.Value = new DateTime(year, 5, 1);
            dateTimePicker22.Value = new DateTime(year, 5, 8);
            dateTimePicker23.Value = new DateTime(year, 5, 15);
            dateTimePicker24.Value = new DateTime(year, 5, 22);
            dateTimePicker25.Value = new DateTime(year, 5, 29);
            dateTimePicker26.Value = new DateTime(year, 6, 1);
            dateTimePicker27.Value = new DateTime(year, 6, 5);
            dateTimePicker28.Value = new DateTime(year, 6, 12);
            dateTimePicker29.Value = new DateTime(year, 6, 19);
            dateTimePicker30.Value = new DateTime(year, 6, 26);
            dateTimePicker31.Value = new DateTime(year, 7, 1);
            dateTimePicker32.Value = new DateTime(year, 7, 7);
            dateTimePicker33.Value = new DateTime(year, 7, 14);
            dateTimePicker34.Value = new DateTime(year, 7, 21);
            dateTimePicker35.Value = new DateTime(year, 7, 28);
            dateTimePicker36.Value = new DateTime(year, 8, 1);
            dateTimePicker37.Value = new DateTime(year, 8, 7);
            dateTimePicker38.Value = new DateTime(year, 8, 14);
            dateTimePicker39.Value = new DateTime(year, 8, 21);
            dateTimePicker40.Value = new DateTime(year, 8, 28);
            dateTimePicker41.Value = new DateTime(year, 9, 1);
            dateTimePicker42.Value = new DateTime(year, 9, 4);
            dateTimePicker43.Value = new DateTime(year, 9, 11);
            dateTimePicker44.Value = new DateTime(year, 9, 18);
            dateTimePicker45.Value = new DateTime(year, 9, 25);
            dateTimePicker46.Value = new DateTime(year, 10, 1);
            dateTimePicker47.Value = new DateTime(year, 10, 9);
            dateTimePicker48.Value = new DateTime(year, 10, 16);
            dateTimePicker49.Value = new DateTime(year, 10, 23);
            dateTimePicker50.Value = new DateTime(year, 10, 30);
            dateTimePicker51.Value = new DateTime(year, 11, 1);
            dateTimePicker52.Value = new DateTime(year, 11, 6);
            dateTimePicker53.Value = new DateTime(year, 11, 13);
            dateTimePicker54.Value = new DateTime(year, 11, 20);
            dateTimePicker55.Value = new DateTime(year, 11, 27);
            dateTimePicker56.Value = new DateTime(year, 12, 1);
            dateTimePicker57.Value = new DateTime(year, 12, 4);
            dateTimePicker58.Value = new DateTime(year, 12, 11);
            dateTimePicker59.Value = new DateTime(year, 12, 18);
            dateTimePicker60.Value = new DateTime(year, 12, 25);
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }
        public void graData()
        {
            PlanillaServicio p = new PlanillaServicio("");
            CatalogoPlanilla ac = new CatalogoPlanilla();
            List<Inventariado> lista = new List<Inventariado>();

            lista = ac.buscarplanilla("");
            p.dataGridView1.DataSource = lista;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            CatalogoPlanilla ca = new CatalogoPlanilla();
            List<Periodicidad> lu = ca.getcodfech();
            this.comboBox1.DataSource = lu;
            this.comboBox1.DisplayMember = "lugartratamiento";
          
            this.comboBox1.ValueMember = "cod";

            this.graData();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            CatalogoPlanilla ca = new CatalogoPlanilla();
            List<Periodicidad> lu = ca.getcodfech();
            this.comboBox1.DataSource = lu;
            this.comboBox1.DisplayMember = "lugartratamiento";
          
            this.comboBox1.ValueMember = "cod";

            this.graData();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            CatalogoPlanilla ca = new CatalogoPlanilla();
            List<Periodicidad> lu = ca.getcodfech();
            this.comboBox1.DataSource = lu;
            this.comboBox1.DisplayMember = "lugartratamiento";
          
            this.comboBox1.ValueMember = "cod";

            this.graData();


        }

        private void button12_Click(object sender, EventArgs e)
        {
            CatalogoPlanilla ca = new CatalogoPlanilla();
            List<Periodicidad> lu = ca.getcodfech();
            this.comboBox1.DataSource = lu;
            this.comboBox1.DisplayMember = "lugartratamiento";
          
            this.comboBox1.ValueMember = "cod";

            this.graData();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            CatalogoPlanilla ca = new CatalogoPlanilla();
            List<Periodicidad> lu = ca.getcodfech();
            this.comboBox1.DataSource = lu;
            this.comboBox1.DisplayMember = "lugartratamiento";
          
            this.comboBox1.ValueMember = "cod";

            this.graData();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            CatalogoPlanilla ca = new CatalogoPlanilla();
            List<Periodicidad> lu = ca.getcodfech();
            this.comboBox1.DataSource = lu;
            this.comboBox1.DisplayMember = "lugartratamiento";
          
            this.comboBox1.ValueMember = "cod";

            this.graData();


        }

        private void button9_Click(object sender, EventArgs e)
        {
            CatalogoPlanilla ca = new CatalogoPlanilla();
            List<Periodicidad> lu = ca.getcodfech();
            this.comboBox1.DataSource = lu;
            this.comboBox1.DisplayMember = "lugartratamiento";
          
            this.comboBox1.ValueMember = "cod";

            this.graData();


        }

        private void button10_Click(object sender, EventArgs e)
        {
            CatalogoPlanilla ca = new CatalogoPlanilla();
            List<Periodicidad> lu = ca.getcodfech();
            this.comboBox1.DataSource = lu;
            this.comboBox1.DisplayMember = "lugartratamiento";
          
            this.comboBox1.ValueMember = "cod";

            this.graData();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            CatalogoPlanilla ca = new CatalogoPlanilla();
            List<Periodicidad> lu = ca.getcodfech();
            this.comboBox1.DataSource = lu;
            this.comboBox1.DisplayMember = "lugartratamiento";
          
            this.comboBox1.ValueMember = "cod";

            this.graData();


        }

        private void button8_Click(object sender, EventArgs e)
        {
            CatalogoPlanilla ca = new CatalogoPlanilla();
            List<Periodicidad> lu = ca.getcodfech();
            this.comboBox1.DataSource = lu;
            this.comboBox1.DisplayMember = "lugartratamiento";
          
            this.comboBox1.ValueMember = "cod";

            this.graData();


        }

        private void button7_Click(object sender, EventArgs e)
        {
            CatalogoPlanilla ca = new CatalogoPlanilla();
            List<Periodicidad> lu = ca.getcodfech();
            this.comboBox1.DataSource = lu;
            this.comboBox1.DisplayMember = "lugartratamiento";
          
            this.comboBox1.ValueMember = "cod";

            this.graData();


        }

        private void button11_Click(object sender, EventArgs e)
        {
            CatalogoPlanilla ca = new CatalogoPlanilla();
            List<Periodicidad> lu = ca.getcodfech();
            this.comboBox1.DataSource = lu;
            this.comboBox1.DisplayMember = "lugartratamiento";
          
            this.comboBox1.ValueMember = "cod";

            this.graData();


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
               dateTimePicker34.Value.Date <= DateTime.Now ||
               dateTimePicker35.Value.Date <= DateTime.Now ||
               dateTimePicker36.Value.Date <= DateTime.Now ||
               dateTimePicker37.Value.Date <= DateTime.Now ||
               dateTimePicker38.Value.Date <= DateTime.Now ||
               dateTimePicker39.Value.Date <= DateTime.Now ||
               dateTimePicker40.Value.Date <= DateTime.Now ||
               dateTimePicker41.Value.Date <= DateTime.Now ||
               dateTimePicker42.Value.Date <= DateTime.Now ||
               dateTimePicker43.Value.Date <= DateTime.Now ||
               dateTimePicker44.Value.Date <= DateTime.Now ||
               dateTimePicker45.Value.Date <= DateTime.Now ||
               dateTimePicker46.Value.Date <= DateTime.Now ||
               dateTimePicker47.Value.Date <= DateTime.Now ||
               dateTimePicker48.Value.Date <= DateTime.Now ||
               dateTimePicker49.Value.Date <= DateTime.Now ||
               dateTimePicker50.Value.Date <= DateTime.Now ||
               dateTimePicker51.Value.Date <= DateTime.Now ||
               dateTimePicker52.Value.Date <= DateTime.Now ||
               dateTimePicker53.Value.Date <= DateTime.Now ||
               dateTimePicker54.Value.Date <= DateTime.Now ||
               dateTimePicker55.Value.Date <= DateTime.Now ||
               dateTimePicker56.Value.Date <= DateTime.Now ||
               dateTimePicker57.Value.Date <= DateTime.Now ||
               dateTimePicker58.Value.Date <= DateTime.Now ||
               dateTimePicker59.Value.Date <= DateTime.Now ||
               dateTimePicker60.Value.Date <= DateTime.Now)
            {
                MessageBox.Show("No se puede guardar fechas anteriores a la fecha actual");


            }
            else
            {
             //////
             
                if (MessageBox.Show("¿Verifico la fechas a guadar?", "ATENCION",
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

                    //Junio v1
                    for (int j = list26.Count - 1; j >= 0; j--)
                    {
                        string a = "";
                        a = list26[index].ToString();
                        if (lista26.Count != 0)
                        {
                            for (int i = lista26.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker26.Format = DateTimePickerFormat.Custom;
                                dateTimePicker26.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista26[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker26.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox27.SelectedValue), Convert.ToInt32(b), "", 0, "S", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                                if (index1 < lista26.Count - 1)
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
                            Periodicidad pla = new Periodicidad(dateTimePicker26.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox27.SelectedValue), 30, "", 0, "S", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                            index1 = 0;
                            index++;
                        }


                    }


                    index = 0;
                    index1 = 0;
                    //Junio v2
                    for (int j = list27.Count - 1; j >= 0; j--)
                    {
                        string a = "";
                        a = list27[index].ToString();
                        if (lista27.Count != 0)
                        {
                            for (int i = lista27.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker27.Format = DateTimePickerFormat.Custom;
                                dateTimePicker27.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista27[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker27.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox28.SelectedValue), Convert.ToInt32(b), "", 0, "S", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                                if (index1 < lista27.Count - 1)
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
                            Periodicidad pla = new Periodicidad(dateTimePicker27.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox28.SelectedValue), 30, "", 0, "S", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                            index1 = 0;
                            index++;
                        }


                    }


                    index = 0;
                    index1 = 0;
                    //Junio v3
                    for (int j = list28.Count - 1; j >= 0; j--)
                    {
                        string a = "";
                        a = list28[index].ToString();
                        if (lista28.Count != 0)
                        {
                            for (int i = lista28.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker28.Format = DateTimePickerFormat.Custom;
                                dateTimePicker28.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista28[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker28.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox29.SelectedValue), Convert.ToInt32(b), "", 0, "S", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                                if (index1 < lista28.Count - 1)
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
                            Periodicidad pla = new Periodicidad(dateTimePicker28.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox29.SelectedValue), 30, "", 0, "S", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                            index1 = 0;
                            index++;
                        }


                    }

                    index = 0;
                    index1 = 0;

                    //Junio v4
                    for (int j = list29.Count - 1; j >= 0; j--)
                    {
                        string a = "";
                        a = list29[index].ToString();
                        if (lista29.Count != 0)
                        {
                            for (int i = lista29.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker29.Format = DateTimePickerFormat.Custom;
                                dateTimePicker29.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista29[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker29.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox30.SelectedValue), Convert.ToInt32(b), "", 0, "S", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                                if (index1 < lista29.Count - 1)
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
                            Periodicidad pla = new Periodicidad(dateTimePicker29.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox30.SelectedValue), 30, "", 0, "S", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                            index1 = 0;
                            index++;
                        }


                    }


                    index = 0;
                    index1 = 0;
                    //Junio v5
                    for (int j = list30.Count - 1; j >= 0; j--)
                    {
                        string a = "";
                        a = list30[index].ToString();
                        if (lista30.Count != 0)
                        {
                            for (int i = lista30.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker30.Format = DateTimePickerFormat.Custom;
                                dateTimePicker30.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista30[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker30.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox31.SelectedValue), Convert.ToInt32(b), "", 0, "S", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                                if (index1 < lista30.Count - 1)
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
                            Periodicidad pla = new Periodicidad(dateTimePicker30.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox31.SelectedValue), 30, "", 0, "S", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                            index1 = 0;
                            index++;
                        }


                    }






                    index = 0;
                    index1 = 0;
                    //Julio v1
                    for (int j = list31.Count - 1; j >= 0; j--)
                    {
                        string a = "";
                        a = list31[index].ToString();
                        if (lista31.Count != 0)
                        {
                            for (int i = lista31.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker31.Format = DateTimePickerFormat.Custom;
                                dateTimePicker31.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista31[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker31.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox32.SelectedValue), Convert.ToInt32(b), "", 0, "S", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                                if (index1 < lista31.Count - 1)
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
                            Periodicidad pla = new Periodicidad(dateTimePicker31.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox32.SelectedValue), 30, "", 0, "S", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                            index1 = 0;
                            index++;
                        }


                    }

                    index = 0;
                    index1 = 0;

                    //Julio v2
                    for (int j = list32.Count - 1; j >= 0; j--)
                    {
                        string a = "";
                        a = list32[index].ToString();
                        if (lista32.Count != 0)
                        {
                            for (int i = lista32.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker32.Format = DateTimePickerFormat.Custom;
                                dateTimePicker32.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista32[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker32.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox33.SelectedValue), Convert.ToInt32(b), "", 0, "S", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                                if (index1 < lista32.Count - 1)
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
                            Periodicidad pla = new Periodicidad(dateTimePicker32.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox33.SelectedValue), 30, "", 0, "S", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                            index1 = 0;
                            index++;
                        }


                    }


                    index = 0;
                    index1 = 0;
                    //Julio v3
                    for (int j = list33.Count - 1; j >= 0; j--)
                    {
                        string a = "";
                        a = list33[index].ToString();
                        if (lista33.Count != 0)
                        {
                            for (int i = lista33.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker33.Format = DateTimePickerFormat.Custom;
                                dateTimePicker33.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista33[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker33.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox34.SelectedValue), Convert.ToInt32(b), "", 0, "S", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                                if (index1 < lista33.Count - 1)
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
                            Periodicidad pla = new Periodicidad(dateTimePicker33.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox34.SelectedValue), 30, "", 0, "S", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                            index1 = 0;
                            index++;
                        }


                    }

                    index = 0;
                    index1 = 0;

                    //Julio v4
                    for (int j = list34.Count - 1; j >= 0; j--)
                    {
                        string a = "";
                        a = list34[index].ToString();
                        if (lista34.Count != 0)
                        {
                            for (int i = lista34.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker34.Format = DateTimePickerFormat.Custom;
                                dateTimePicker34.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista34[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker34.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox35.SelectedValue), Convert.ToInt32(b), "", 0, "S", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                                if (index1 < lista34.Count - 1)
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
                            Periodicidad pla = new Periodicidad(dateTimePicker34.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox35.SelectedValue), 30, "", 0, "S", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                            index1 = 0;
                            index++;
                        }


                    }


                    index = 0;
                    index1 = 0;
                    //Julio v5
                    for (int j = list35.Count - 1; j >= 0; j--)
                    {
                        string a = "";
                        a = list35[index].ToString();
                        if (lista35.Count != 0)
                        {
                            for (int i = lista35.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker35.Format = DateTimePickerFormat.Custom;
                                dateTimePicker35.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista35[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker35.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox36.SelectedValue), Convert.ToInt32(b), "", 0, "S", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                                if (index1 < lista35.Count - 1)
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
                            Periodicidad pla = new Periodicidad(dateTimePicker35.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox36.SelectedValue), 30, "", 0, "S", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                            index1 = 0;
                            index++;
                        }


                    }







                    index = 0;
                    index1 = 0;

                    //Agosto v1
                    for (int j = list36.Count - 1; j >= 0; j--)
                    {
                        string a = "";
                        a = list36[index].ToString();
                        if (lista36.Count != 0)
                        {
                            for (int i = lista36.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker36.Format = DateTimePickerFormat.Custom;
                                dateTimePicker36.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista36[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker36.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox37.SelectedValue), Convert.ToInt32(b), "", 0, "S", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                                if (index1 < lista36.Count - 1)
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
                            Periodicidad pla = new Periodicidad(dateTimePicker36.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox37.SelectedValue), 30, "", 0, "S", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                            index1 = 0;
                            index++;
                        }


                    }


                    index = 0;
                    index1 = 0;
                    //Agosto v2
                    for (int j = list37.Count - 1; j >= 0; j--)
                    {
                        string a = "";
                        a = list37[index].ToString();
                        if (lista37.Count != 0)
                        {
                            for (int i = lista37.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker37.Format = DateTimePickerFormat.Custom;
                                dateTimePicker37.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista37[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker37.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox38.SelectedValue), Convert.ToInt32(b), "", 0, "S", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                                if (index1 < lista37.Count - 1)
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
                            dateTimePicker37.Format = DateTimePickerFormat.Custom;
                         
                            dateTimePicker37.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker37.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox38.SelectedValue), 30, "", 0, "S", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                            index1 = 0;
                            index++;
                        }


                    }

                    index = 0;
                    index1 = 0;

                    //Agosto v3
                    for (int j = list38.Count - 1; j >= 0; j--)
                    {
                        string a = "";
                        a = list38[index].ToString();
                        if (lista38.Count != 0)
                        {
                            for (int i = lista38.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker38.Format = DateTimePickerFormat.Custom;
                                dateTimePicker38.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista38[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker38.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox39.SelectedValue), Convert.ToInt32(b), "", 0, "S", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                                if (index1 < lista38.Count - 1)
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
                            dateTimePicker38.Format = DateTimePickerFormat.Custom;
                         
                            dateTimePicker38.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker38.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox39.SelectedValue), 30, "", 0, "S", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                            index1 = 0;
                            index++;
                        }


                    }


                    index = 0;
                    index1 = 0;
                    //Agosto v4
                    for (int j = list39.Count - 1; j >= 0; j--)
                    {
                        string a = "";
                        a = list39[index].ToString();
                        if (lista39.Count != 0)
                        {
                            for (int i = lista39.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker39.Format = DateTimePickerFormat.Custom;
                                dateTimePicker39.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista39[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker39.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox40.SelectedValue), Convert.ToInt32(b), "", 0, "S", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                                if (index1 < lista39.Count - 1)
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
                            dateTimePicker39.Format = DateTimePickerFormat.Custom;
                         
                            dateTimePicker39.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker39.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox40.SelectedValue), 30, "", 0, "S", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                            index1 = 0;
                            index++;
                        }


                    }


                    index = 0;
                    index1 = 0;
                    //Agosto v5
                    for (int j = list40.Count - 1; j >= 0; j--)
                    {
                        string a = "";
                        a = list40[index].ToString();
                        if (lista40.Count != 0)
                        {
                            for (int i = lista40.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker40.Format = DateTimePickerFormat.Custom;
                                dateTimePicker40.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista40[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker40.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox41.SelectedValue), Convert.ToInt32(b), "", 0, "S", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                                if (index1 < lista40.Count - 1)
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
                            dateTimePicker40.Format = DateTimePickerFormat.Custom;
                         
                            dateTimePicker40.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker40.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox41.SelectedValue), 30, "", 0, "S", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                            index1 = 0;
                            index++;
                        }


                    }





                    index = 0;
                    index1 = 0;

                    //Septiembre v1
                    for (int j = list41.Count - 1; j >= 0; j--)
                    {
                        string a = "";
                        a = list41[index].ToString();
                        if (lista41.Count != 0)
                        {
                            for (int i = lista41.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker41.Format = DateTimePickerFormat.Custom;
                                dateTimePicker41.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista41[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker41.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox42.SelectedValue), Convert.ToInt32(b), "", 0, "S", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                                if (index1 < lista41.Count - 1)
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
                            dateTimePicker41.Format = DateTimePickerFormat.Custom;
                         
                            dateTimePicker41.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker41.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox42.SelectedValue), 30, "", 0, "S", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                            index1 = 0;
                            index++;
                        }


                    }


                    index = 0;
                    index1 = 0;
                    //Septiembre v2
                    for (int j = list42.Count - 1; j >= 0; j--)
                    {
                        string a = "";
                        a = list42[index].ToString();
                        if (lista42.Count != 0)
                        {
                            for (int i = lista42.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker42.Format = DateTimePickerFormat.Custom;
                                dateTimePicker42.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista42[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker42.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox43.SelectedValue), Convert.ToInt32(b), "", 0, "S", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                                if (index1 < lista42.Count - 1)
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
                            dateTimePicker42.Format = DateTimePickerFormat.Custom;
                         
                            dateTimePicker42.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker42.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox43.SelectedValue), 30, "", 0, "S", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                            index1 = 0;
                            index++;
                        }


                    }


                    index = 0;
                    index1 = 0;
                    //Septiembre v3
                    for (int j = list43.Count - 1; j >= 0; j--)
                    {
                        string a = "";
                        a = list43[index].ToString();
                        if (lista43.Count != 0)
                        {
                            for (int i = lista43.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker43.Format = DateTimePickerFormat.Custom;
                                dateTimePicker43.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista43[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker43.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox44.SelectedValue), Convert.ToInt32(b), "", 0, "S", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                                if (index1 < lista43.Count - 1)
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
                            dateTimePicker43.Format = DateTimePickerFormat.Custom;
                         
                            dateTimePicker43.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker43.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox44.SelectedValue), 30, "", 0, "S", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                            index1 = 0;
                            index++;
                        }


                    }


                    index = 0;
                    index1 = 0;
                    //Septiembre v4
                    for (int j = list44.Count - 1; j >= 0; j--)
                    {
                        string a = "";
                        a = list44[index].ToString();
                        if (lista44.Count != 0)
                        {
                            for (int i = lista44.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker44.Format = DateTimePickerFormat.Custom;
                                dateTimePicker44.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista44[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker44.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox45.SelectedValue), Convert.ToInt32(b), "", 0, "S", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                                if (index1 < lista44.Count - 1)
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
                            dateTimePicker44.Format = DateTimePickerFormat.Custom;
                         
                            dateTimePicker44.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker44.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox45.SelectedValue), 30, "", 0, "S", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                            index1 = 0;
                            index++;
                        }


                    }

                    index = 0;
                    index1 = 0;

                    //Septiembre v5
                    for (int j = list45.Count - 1; j >= 0; j--)
                    {
                        string a = "";
                        a = list45[index].ToString();
                        if (lista45.Count != 0)
                        {
                            for (int i = lista45.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker45.Format = DateTimePickerFormat.Custom;
                                dateTimePicker45.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista45[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker45.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox46.SelectedValue), Convert.ToInt32(b), "", 0, "S", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                                if (index1 < lista45.Count - 1)
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
                            dateTimePicker45.Format = DateTimePickerFormat.Custom;
                         
                            dateTimePicker45.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker45.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox46.SelectedValue), 30, "", 0, "S", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                            index1 = 0;
                            index++;
                        }


                    }






                    index = 0;
                    index1 = 0;
                    //Octubre v1
                    for (int j = list46.Count - 1; j >= 0; j--)
                    {
                        string a = "";
                        a = list46[index].ToString();
                        if (lista46.Count != 0)
                        {
                            for (int i = lista46.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker46.Format = DateTimePickerFormat.Custom;
                                dateTimePicker46.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista46[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker46.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox47.SelectedValue), Convert.ToInt32(b), "", 0, "S", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                                if (index1 < lista46.Count - 1)
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
                            dateTimePicker46.Format = DateTimePickerFormat.Custom;
                         
                            dateTimePicker46.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker46.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox47.SelectedValue), 30, "", 0, "S", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                            index1 = 0;
                            index++;
                        }


                    }


                    index = 0;
                    index1 = 0;
                    //Octubre v2
                    for (int j = list47.Count - 1; j >= 0; j--)
                    {
                        string a = "";
                        a = list47[index].ToString();
                        if (lista47.Count != 0)
                        {
                            for (int i = lista47.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker47.Format = DateTimePickerFormat.Custom;
                                dateTimePicker47.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista47[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker47.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox48.SelectedValue), Convert.ToInt32(b), "", 0, "S", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                                if (index1 < lista47.Count - 1)
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
                            dateTimePicker47.Format = DateTimePickerFormat.Custom;
                         
                            dateTimePicker47.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker47.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox48.SelectedValue), 30, "", 0, "S", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                            index1 = 0;
                            index++;
                        }


                    }


                    index = 0;
                    index1 = 0;
                    //Octubre v3
                    for (int j = list48.Count - 1; j >= 0; j--)
                    {
                        string a = "";
                        a = list48[index].ToString();
                        if (lista48.Count != 0)
                        {
                            for (int i = lista48.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker48.Format = DateTimePickerFormat.Custom;
                                dateTimePicker48.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista48[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker48.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox49.SelectedValue), Convert.ToInt32(b), "", 0, "S", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                                if (index1 < lista48.Count - 1)
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
                            dateTimePicker48.Format = DateTimePickerFormat.Custom;
                         
                            dateTimePicker48.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker48.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox49.SelectedValue), 30, "", 0, "S", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                            index1 = 0;
                            index++;
                        }


                    }


                    index = 0;
                    index1 = 0;
                    //Octubre v4
                    for (int j = list49.Count - 1; j >= 0; j--)
                    {
                        string a = "";
                        a = list49[index].ToString();
                        if (lista49.Count != 0)
                        {
                            for (int i = lista49.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker49.Format = DateTimePickerFormat.Custom;
                                dateTimePicker49.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista49[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker49.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox50.SelectedValue), Convert.ToInt32(b), "", 0, "S", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                                if (index1 < lista49.Count - 1)
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
                            dateTimePicker49.Format = DateTimePickerFormat.Custom;
                         
                            dateTimePicker49.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker49.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox50.SelectedValue), 30, "", 0, "S", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                            index1 = 0;
                            index++;
                        }


                    }

                    index = 0;
                    index1 = 0;

                    //Octubre v5
                    for (int j = list50.Count - 1; j >= 0; j--)
                    {
                        string a = "";
                        a = list50[index].ToString();
                        if (lista50.Count != 0)
                        {
                            for (int i = lista50.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker50.Format = DateTimePickerFormat.Custom;
                                dateTimePicker50.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista50[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker50.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox51.SelectedValue), Convert.ToInt32(b), "", 0, "S", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                                if (index1 < lista50.Count - 1)
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
                            dateTimePicker50.Format = DateTimePickerFormat.Custom;
                         
                            dateTimePicker50.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker50.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox51.SelectedValue), 30, "", 0, "S", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                            index1 = 0;
                            index++;
                        }


                    }



                    index = 0;
                    index1 = 0;
                    //Noviembre v1
                    for (int j = list51.Count - 1; j >= 0; j--)
                    {
                        string a = "";
                        a = list51[index].ToString();
                        if (lista51.Count != 0)
                        {
                            for (int i = lista51.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker51.Format = DateTimePickerFormat.Custom;
                                dateTimePicker51.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista51[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker51.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox52.SelectedValue), Convert.ToInt32(b), "", 0, "S", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                                if (index1 < lista51.Count - 1)
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
                            dateTimePicker51.Format = DateTimePickerFormat.Custom;
                         
                            dateTimePicker51.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker51.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox52.SelectedValue), 30, "", 0, "S", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                            index1 = 0;
                            index++;
                        }


                    }


                    index = 0;
                    index1 = 0;
                    //Noviembre v2
                    for (int j = list52.Count - 1; j >= 0; j--)
                    {
                        string a = "";
                        a = list52[index].ToString();
                        if (lista52.Count != 0)
                        {
                            for (int i = lista52.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker52.Format = DateTimePickerFormat.Custom;
                                dateTimePicker52.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista52[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker52.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox53.SelectedValue), Convert.ToInt32(b), "", 0, "S", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                                if (index1 < lista52.Count - 1)
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
                            dateTimePicker52.Format = DateTimePickerFormat.Custom;
                         
                            dateTimePicker52.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker52.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox53.SelectedValue), 30, "", 0, "S", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                            index1 = 0;
                            index++;
                        }


                    }


                    index = 0;
                    index1 = 0;
                    //Noviembre v3
                    for (int j = list53.Count - 1; j >= 0; j--)
                    {
                        string a = "";
                        a = list53[index].ToString();
                        if (lista53.Count != 0)
                        {
                            for (int i = lista53.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker53.Format = DateTimePickerFormat.Custom;
                                dateTimePicker53.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista53[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker53.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox54.SelectedValue), Convert.ToInt32(b), "", 0, "S", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                                if (index1 < lista53.Count - 1)
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
                            dateTimePicker53.Format = DateTimePickerFormat.Custom;
                         
                            dateTimePicker53.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker53.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox54.SelectedValue), 30, "", 0, "S", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                            index1 = 0;
                            index++;
                        }


                    }


                    index = 0;
                    index1 = 0;
                    //Noviembre v4
                    for (int j = list54.Count - 1; j >= 0; j--)
                    {
                        string a = "";
                        a = list54[index].ToString();
                        if (lista54.Count != 0)
                        {
                            for (int i = lista54.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker54.Format = DateTimePickerFormat.Custom;
                                dateTimePicker54.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista54[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker54.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox55.SelectedValue), Convert.ToInt32(b), "", 0, "S", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                                if (index1 < lista54.Count - 1)
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
                            dateTimePicker54.Format = DateTimePickerFormat.Custom;
                         
                            dateTimePicker54.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker54.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox55.SelectedValue), 30, "", 0, "S", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                            index1 = 0;
                            index++;
                        }


                    }


                    index = 0;
                    index1 = 0;
                    //Noviembre v5
                    for (int j = list55.Count - 1; j >= 0; j--)
                    {
                        string a = "";
                        a = list55[index].ToString();
                        if (lista55.Count != 0)
                        {
                            for (int i = lista55.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker55.Format = DateTimePickerFormat.Custom;
                                dateTimePicker55.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista55[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker55.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox56.SelectedValue), Convert.ToInt32(b), "", 0, "S", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                                if (index1 < lista55.Count - 1)
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
                            dateTimePicker55.Format = DateTimePickerFormat.Custom;
                         
                            dateTimePicker55.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker55.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox56.SelectedValue), 30, "", 0, "S", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                            index1 = 0;
                            index++;
                        }


                    }




                    index = 0;
                    index1 = 0;

                    //Diciembre v1
                    for (int j = list56.Count - 1; j >= 0; j--)
                    {
                        string a = "";
                        a = list56[index].ToString();
                        if (lista56.Count != 0)
                        {
                            for (int i = lista56.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker56.Format = DateTimePickerFormat.Custom;
                                dateTimePicker56.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista56[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker56.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox57.SelectedValue), Convert.ToInt32(b), "", 0, "S", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                                if (index1 < lista56.Count - 1)
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
                            dateTimePicker56.Format = DateTimePickerFormat.Custom;
                         
                            dateTimePicker56.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker56.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox52.SelectedValue), 30, "", 0, "S", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                            index1 = 0;
                            index++;
                        }


                    }


                    index = 0;
                    index1 = 0;
                    //Diciembre v2
                    for (int j = list57.Count - 1; j >= 0; j--)
                    {
                        string a = "";
                        a = list57[index].ToString();
                        if (lista57.Count != 0)
                        {
                            for (int i = lista57.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker57.Format = DateTimePickerFormat.Custom;
                                dateTimePicker57.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista57[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker57.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox58.SelectedValue), Convert.ToInt32(b), "", 0, "S", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                                if (index1 < lista57.Count - 1)
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
                            dateTimePicker57.Format = DateTimePickerFormat.Custom;
                         
                            dateTimePicker57.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker57.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox58.SelectedValue), 30, "", 0, "S", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                            index1 = 0;
                            index++;
                        }


                    }

                    index = 0;
                    index1 = 0;

                    //Diciembre v3
                    for (int j = list58.Count - 1; j >= 0; j--)
                    {
                        string a = "";
                        a = list58[index].ToString();
                        if (lista58.Count != 0)
                        {
                            for (int i = lista58.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker58.Format = DateTimePickerFormat.Custom;
                                dateTimePicker58.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista58[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker58.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox59.SelectedValue), Convert.ToInt32(b), "", 0, "S", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                                if (index1 < lista58.Count - 1)
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
                            dateTimePicker58.Format = DateTimePickerFormat.Custom;
                         
                            dateTimePicker58.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker58.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox59.SelectedValue), 30, "", 0, "S", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                            index1 = 0;
                            index++;
                        }


                    }


                    index = 0;
                    index1 = 0;
                    //Diciembre v4
                    for (int j = list59.Count - 1; j >= 0; j--)
                    {
                        string a = "";
                        a = list59[index].ToString();
                        if (lista59.Count != 0)
                        {
                            for (int i = lista59.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker59.Format = DateTimePickerFormat.Custom;
                                dateTimePicker59.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista59[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker59.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox60.SelectedValue), Convert.ToInt32(b), "", 0, "S", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                                if (index1 < lista59.Count - 1)
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
                            dateTimePicker59.Format = DateTimePickerFormat.Custom;
                         
                            dateTimePicker59.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker59.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox60.SelectedValue), 30, "", 0, "S", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                            index1 = 0;
                            index++;
                        }


                    }


                    index = 0;
                    index1 = 0;
                    //Diciembre v5
                    for (int j = list60.Count - 1; j >= 0; j--)
                    {
                        string a = "";
                        a = list60[index].ToString();
                        if (lista60.Count != 0)
                        {
                            for (int i = lista60.Count - 1; i >= 0; i--)
                            {
                                dateTimePicker60.Format = DateTimePickerFormat.Custom;
                                dateTimePicker60.CustomFormat = "yyyy-MM-dd";
                                string b = "";
                                b = lista60[index1].ToString();
                                Periodicidad pla = new Periodicidad(dateTimePicker60.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox61.SelectedValue), Convert.ToInt32(b), "", 0, "S", "P", "", "Primario", "", "");
                                ca.addfecha(pla);
                               
                                if (index1 < lista60.Count - 1)
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
                            dateTimePicker60.Format = DateTimePickerFormat.Custom;
                         
                            dateTimePicker60.CustomFormat = "yyyy-MM-dd";
                            Periodicidad pla = new Periodicidad(dateTimePicker60.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(comboBox61.SelectedValue), 30, "", 0, "S", "P", "", "Primario", "", "");
                            ca.addfecha(pla);
                            index1 = 0;
                            index++;
                        }


                    }
                    planificar(list1, lista1, comboBox1, dateTimePicker1, comboBox2);
                    planificar(list2, lista2, comboBox1, dateTimePicker2, comboBox3);
                    planificar(list3, lista3, comboBox1, dateTimePicker3, comboBox4);
                    planificar(list4, lista4, comboBox1, dateTimePicker4, comboBox5);
                    planificar(list5, lista5, comboBox1, dateTimePicker5, comboBox6);
                    planificar(list6, lista6, comboBox1, dateTimePicker6, comboBox7);
                    planificar(list7, lista7, comboBox1, dateTimePicker7, comboBox8);
                    planificar(list8, lista8, comboBox1, dateTimePicker8, comboBox9);
                    planificar(list9, lista9, comboBox1, dateTimePicker9, comboBox10);
                    planificar(list10, lista10, comboBox1, dateTimePicker10, comboBox11);
                    planificar(list11, lista11, comboBox1, dateTimePicker11, comboBox12);
                    planificar(list12, lista12, comboBox1, dateTimePicker12, comboBox13);
                    planificar(list13, lista13, comboBox1, dateTimePicker13, comboBox14);
                    planificar(list14, lista14, comboBox1, dateTimePicker14, comboBox15);
                    planificar(list15, lista15, comboBox1, dateTimePicker15, comboBox16);
                    planificar(list16, lista16, comboBox1, dateTimePicker16, comboBox17);
                    planificar(list17, lista17, comboBox1, dateTimePicker17, comboBox18);
                    planificar(list18, lista18, comboBox1, dateTimePicker18, comboBox19);
                    planificar(list19, lista19, comboBox1, dateTimePicker19, comboBox20);
                    planificar(list20, lista20, comboBox1, dateTimePicker20, comboBox21);
                    planificar(list21, lista21, comboBox1, dateTimePicker21, comboBox22);
                    planificar(list22, lista22, comboBox1, dateTimePicker22, comboBox23);
                    planificar(list23, lista23, comboBox1, dateTimePicker23, comboBox24);
                    planificar(list24, lista24, comboBox1, dateTimePicker24, comboBox25);
                    planificar(list25, lista25, comboBox1, dateTimePicker25, comboBox26);
                }

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

        private void comboBox87_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox87.SelectedValue);
                comboBox87.SelectedValue = index;
              
                list26.Add(index);
            }
        }

        private void comboBox88_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox88.SelectedValue);
                comboBox88.SelectedValue = index;
              
                list27.Add(index);
            }
        }

        private void comboBox89_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox89.SelectedValue);
                comboBox89.SelectedValue = index;
              
                list28.Add(index);
            }
        }

        private void comboBox90_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox90.SelectedValue);
                comboBox90.SelectedValue = index;
              
                list29.Add(index);
            }
        }

        private void comboBox91_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox91.SelectedValue);
                comboBox91.SelectedValue = index;
              
                list30.Add(index);
            }
        }

        private void comboBox92_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox92.SelectedValue);
                comboBox92.SelectedValue = index;
              
                list31.Add(index);
            }
        }

        private void comboBox93_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox93.SelectedValue);
                comboBox93.SelectedValue = index;
              
                list32.Add(index);
            }
        }

        private void comboBox94_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox94.SelectedValue);
                comboBox94.SelectedValue = index;
              
                list33.Add(index);
            }
        }

        private void comboBox95_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox95.SelectedValue);
                comboBox95.SelectedValue = index;
              
                list34.Add(index);
            }
        }

        private void comboBox96_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox96.SelectedValue);
                comboBox96.SelectedValue = index;
              
                list35.Add(index);
            }
        }

        private void comboBox97_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox97.SelectedValue);
                comboBox97.SelectedValue = index;
              
                list36.Add(index);
            }
        }

        private void comboBox98_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox98.SelectedValue);
                comboBox98.SelectedValue = index;
              
                list37.Add(index);
            }
        }

        private void comboBox99_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox99.SelectedValue);
                comboBox99.SelectedValue = index;
              
                list38.Add(index);
            }
        }

        private void comboBox100_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox100.SelectedValue);
                comboBox100.SelectedValue = index;
              
                list39.Add(index);
            }
        }

        private void comboBox101_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox101.SelectedValue);
                comboBox101.SelectedValue = index;
              
                list40.Add(index);
            }
        }

        private void comboBox102_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox102.SelectedValue);
                comboBox102.SelectedValue = index;
              
                list41.Add(index);
            }
        }

        private void comboBox103_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox103.SelectedValue);
                comboBox103.SelectedValue = index;
              
                list42.Add(index);
            }
        }

        private void comboBox105_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox105.SelectedValue);
                comboBox105.SelectedValue = index;
              
                list43.Add(index);
            }
        }

        private void comboBox104_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox104.SelectedValue);
                comboBox104.SelectedValue = index;
              
                list44.Add(index);
            }
        }

        private void comboBox106_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox106.SelectedValue);
                comboBox106.SelectedValue = index;
              
                list45.Add(index);
            }
        }

        private void comboBox107_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox107.SelectedValue);
                comboBox107.SelectedValue = index;
              
                list46.Add(index);
            }
        }

        private void comboBox108_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox108.SelectedValue);
                comboBox108.SelectedValue = index;
              
                list47.Add(index);
            }
        }

        private void comboBox109_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox109.SelectedValue);
                comboBox109.SelectedValue = index;
              
                list48.Add(index);
            }
        }

        private void comboBox110_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox110.SelectedValue);
                comboBox110.SelectedValue = index;
              
                list49.Add(index);
            }
        }

        private void comboBox111_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox111.SelectedValue);
                comboBox11.SelectedValue = index;
              
                list50.Add(index);
            }
        }

        private void comboBox112_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox112.SelectedValue);
                comboBox112.SelectedValue = index;
              
                list51.Add(index);
            }
        }

        private void comboBox113_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox113.SelectedValue);
                comboBox113.SelectedValue = index;
              
                list52.Add(index);
            }
        }

        private void comboBox114_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox114.SelectedValue);
                comboBox114.SelectedValue = index;
              
                list53.Add(index);
            }
        }

        private void comboBox115_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox115.SelectedValue);
                comboBox115.SelectedValue = index;
              
                list54.Add(index);
            }
        }

        private void comboBox116_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox116.SelectedValue);
                comboBox116.SelectedValue = index;
              
                list55.Add(index);
            }
        }

        private void comboBox117_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox117.SelectedValue);
                comboBox117.SelectedValue = index;
              
                list56.Add(index);
            }
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox118_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox118.SelectedValue);
                comboBox118.SelectedValue = index;
              
                list57.Add(index);
            }
        }

        private void comboBox119_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox119.SelectedValue);
                comboBox119.SelectedValue = index;
              
                list58.Add(index);
            }
        }

        private void comboBox120_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox120.SelectedValue);
                comboBox120.SelectedValue = index;
              
                list59.Add(index);
            }
        }

        private void comboBox121_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox121.SelectedValue);
                comboBox121.SelectedValue = index;
              
                list60.Add(index);
            }
        }

        private void comboBox151_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox151.SelectedValue);
                comboBox151.SelectedValue = index;
              
                lista26.Add(index);
            }
        }

        private void comboBox150_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox150.SelectedValue);
                comboBox150.SelectedValue = index;
              
                lista27.Add(index);
            }
        }

        private void comboBox149_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox149.SelectedValue);
                comboBox149.SelectedValue = index;
              
                lista28.Add(index);
            }
        }

        private void comboBox148_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox148.SelectedValue);
                comboBox148.SelectedValue = index;
              
                lista29.Add(index);
            }
        }

        private void comboBox147_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox147.SelectedValue);
                comboBox147.SelectedValue = index;
              
                lista30.Add(index);
            }
        }

        private void comboBox156_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox156.SelectedValue);
                comboBox156.SelectedValue = index;
              
                lista31.Add(index);
            }
        }

        private void comboBox155_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox155.SelectedValue);
                comboBox155.SelectedValue = index;
              
                lista32.Add(index);
            }
        }

        private void comboBox154_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox154.SelectedValue);
                comboBox154.SelectedValue = index;
              
                lista33.Add(index);
            }
        }

        private void comboBox153_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox153.SelectedValue);
                comboBox153.SelectedValue = index;
              
                lista34.Add(index);
            }
        }

        private void comboBox152_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox152.SelectedValue);
                comboBox152.SelectedValue = index;
              
                lista35.Add(index);
            }
        }

        private void comboBox161_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox161.SelectedValue);
                comboBox161.SelectedValue = index;
              
                lista36.Add(index);
            }
        }

        private void comboBox160_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox160.SelectedValue);
                comboBox160.SelectedValue = index;
              
                lista37.Add(index);
            }
        }

        private void comboBox159_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox159.SelectedValue);
                comboBox159.SelectedValue = index;
              
                lista38.Add(index);
            }
        }

        private void comboBox158_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox158.SelectedValue);
                comboBox158.SelectedValue = index;
              
                lista39.Add(index);
            }
        }

        private void comboBox157_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox157.SelectedValue);
                comboBox157.SelectedValue = index;
              
                lista40.Add(index);
            }
        }

        private void comboBox166_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox166.SelectedValue);
                comboBox166.SelectedValue = index;
              
                lista41.Add(index);
            }
        }

        private void comboBox165_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox165.SelectedValue);
                comboBox165.SelectedValue = index;
              
                lista42.Add(index);
            }
        }

        private void comboBox164_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox164.SelectedValue);
                comboBox164.SelectedValue = index;
              
                lista43.Add(index);
            }
        }

        private void comboBox163_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox163.SelectedValue);
                comboBox163.SelectedValue = index;
              
                lista44.Add(index);
            }
        }

        private void comboBox162_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox162.SelectedValue);
                comboBox162.SelectedValue = index;
              
                lista45.Add(index);
            }
        }

        private void comboBox171_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox171.SelectedValue);
                comboBox171.SelectedValue = index;
              
                lista46.Add(index);
            }
        }

        private void comboBox170_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox170.SelectedValue);
                comboBox170.SelectedValue = index;
              
                lista47.Add(index);
            }
        }

        private void comboBox169_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox169.SelectedValue);
                comboBox169.SelectedValue = index;
              
                lista48.Add(index);
            }
        }

        private void comboBox168_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox168.SelectedValue);
                comboBox168.SelectedValue = index;
              
                lista49.Add(index);
            }
        }

        private void comboBox167_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox167.SelectedValue);
                comboBox167.SelectedValue = index;
              
                lista50.Add(index);
            }
        }

        private void comboBox176_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox176.SelectedValue);
                comboBox176.SelectedValue = index;
              
                lista51.Add(index);
            }
        }

        private void comboBox175_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox175.SelectedValue);
                comboBox175.SelectedValue = index;
              
                lista52.Add(index);
            }
        }

        private void comboBox174_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox174.SelectedValue);
                comboBox174.SelectedValue = index;
              
                lista53.Add(index);
            }
        }

        private void comboBox173_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox173.SelectedValue);
                comboBox173.SelectedValue = index;
              
                lista54.Add(index);
            }
        }

        private void comboBox172_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox172.SelectedValue);
                comboBox172.SelectedValue = index;
              
                lista55.Add(index);
            }
        }

        private void comboBox181_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox181.SelectedValue);
                comboBox181.SelectedValue = index;
              
                lista56.Add(index);
            }
        }

        private void comboBox180_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox180.SelectedValue);
                comboBox180.SelectedValue = index;
              
                lista57.Add(index);
            }
        }

        private void comboBox179_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox179.SelectedValue);
                comboBox179.SelectedValue = index;
              
                lista58.Add(index);
            }
        }

        private void comboBox178_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox178.SelectedValue);
                comboBox178.SelectedValue = index;
              
                lista59.Add(index);
            }
        }

        private void comboBox177_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox177.SelectedValue);
                comboBox177.SelectedValue = index;
              
                lista60.Add(index);
            }
        }

        private void comboBox28_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox122_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox122.SelectedValue);
                comboBox122.SelectedValue = index;
              
                lista1.Add(index);
            }
        }

        private void comboBox32_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox74_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox74.SelectedValue);
                comboBox74.SelectedValue = index;
              
                list13.Add(index);
            }
        }

        private void comboBox86_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox86.SelectedValue);
                comboBox86.SelectedValue = index;
              
                list25.Add(index);
            }
        }

        private void comboBox63_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox63.SelectedValue);
                comboBox63.SelectedValue = index;
              
                list2.Add(index);
            }
        }

        private void comboBox64_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox64.SelectedValue);
                comboBox64.SelectedValue = index;
              
                list3.Add(index);
            }
        }

        private void comboBox65_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox65.SelectedValue);
                comboBox65.SelectedValue = index;
              
                list4.Add(index);
            }
        }

        private void comboBox66_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox66.SelectedValue);
                comboBox66.SelectedValue = index;
              
                list5.Add(index);
            }
        }

        private void comboBox67_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox67.SelectedValue);
                comboBox67.SelectedValue = index;
              
                list6.Add(index);
            }
        }

        private void comboBox68_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox68.SelectedValue);
                comboBox68.SelectedValue = index;
              
                list7.Add(index);
            }
        }

        private void comboBox69_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox69.SelectedValue);
                comboBox69.SelectedValue = index;
              
                list8.Add(index);
            }
        }

        private void comboBox70_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox70.SelectedValue);
                comboBox70.SelectedValue = index;
              
                list9.Add(index);
            }
        }

        private void comboBox71_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox71.SelectedValue);
                comboBox71.SelectedValue = index;
              
                list10.Add(index);
            }
        }

        private void comboBox72_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox72.SelectedValue);
                comboBox72.SelectedValue = index;
              
                list11.Add(index);
            }
        }

        private void comboBox73_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox73.SelectedValue);
                comboBox73.SelectedValue = index;
              
                list12.Add(index);
            }
        }

        private void comboBox75_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox75.SelectedValue);
                comboBox75.SelectedValue = index;
              
                list14.Add(index);
            }
        }

        private void comboBox76_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox76.SelectedValue);
                comboBox76.SelectedValue = index;
              
                list15.Add(index);
            }
        }

        private void comboBox77_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox77.SelectedValue);
                comboBox77.SelectedValue = index;
              
                list16.Add(index);
            }
        }

        private void comboBox78_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox78.SelectedValue);
                comboBox78.SelectedValue = index;
              
                list17.Add(index);
            }
        }

        private void comboBox79_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox79.SelectedValue);
                comboBox79.SelectedValue = index;
              
                list18.Add(index);
            }
        }

        private void comboBox80_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox80.SelectedValue);
                comboBox80.SelectedValue = index;
              
                list19.Add(index);
            }
        }

        private void comboBox81_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox81.SelectedValue);
                comboBox81.SelectedValue = index;
              
                list20.Add(index);
            }
        }

        private void comboBox82_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox82.SelectedValue);
                comboBox82.SelectedValue = index;
              
                list21.Add(index);
            }
        }

        private void comboBox83_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox83.SelectedValue);
                comboBox83.SelectedValue = index;
              
                list22.Add(index);
            }
        }

        private void comboBox84_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox84.SelectedValue);
                comboBox84.SelectedValue = index;
              
                list23.Add(index);
            }
        }

        private void comboBox85_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox85.SelectedValue);
                comboBox85.SelectedValue = index;
              
                list24.Add(index);
            }
        }

        private void comboBox123_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox123.SelectedValue);
                comboBox123.SelectedValue = index;
              
                lista2.Add(index);
            }
        }

        private void comboBox124_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox124.SelectedValue);
                comboBox124.SelectedValue = index;
              
                lista3.Add(index);
            }
        }

        private void comboBox125_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox125.SelectedValue);
                comboBox125.SelectedValue = index;
              
                lista4.Add(index);
            }
        }

        private void comboBox126_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox126.SelectedValue);
                comboBox126.SelectedValue = index;
              
                lista5.Add(index);
            }
        }

        private void comboBox127_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox127.SelectedValue);
                comboBox127.SelectedValue = index;
              
                lista6.Add(index);
            }
        }

        private void comboBox128_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox128.SelectedValue);
                comboBox128.SelectedValue = index;
              
                lista7.Add(index);
            }
        }

        private void comboBox129_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox129.SelectedValue);
                comboBox129.SelectedValue = index;
              
                lista8.Add(index);
            }
        }

        private void comboBox130_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox130.SelectedValue);
                comboBox130.SelectedValue = index;
              
                lista9.Add(index);
            }
        }

        private void comboBox131_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox131.SelectedValue);
                comboBox131.SelectedValue = index;
              
                lista10.Add(index);
            }
        }

        private void comboBox132_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox132.SelectedValue);
                comboBox132.SelectedValue = index;
              
                lista11.Add(index);
            }
        }

        private void comboBox133_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox133.SelectedValue);
                comboBox133.SelectedValue = index;
              
                lista12.Add(index);
            }
        }

        private void comboBox134_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox134.SelectedValue);
                comboBox134.SelectedValue = index;
              
                lista13.Add(index);
            }
        }

        private void comboBox135_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox135.SelectedValue);
                comboBox135.SelectedValue = index;
              
                lista14.Add(index);
            }
        }

        private void comboBox136_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox136.SelectedValue);
                comboBox136.SelectedValue = index;
              
                lista15.Add(index);
            }
        }

        private void comboBox137_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox137.SelectedValue);
                comboBox137.SelectedValue = index;
              
                lista16.Add(index);
            }
        }

        private void comboBox138_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox138.SelectedValue);
                comboBox138.SelectedValue = index;
              
                lista17.Add(index);
            }
        }

        private void comboBox139_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox139.SelectedValue);
                comboBox139.SelectedValue = index;
              
                lista18.Add(index);
            }
        }

        private void comboBox140_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox140.SelectedValue);
                comboBox140.SelectedValue = index;
              
                lista19.Add(index);
            }
        }

        private void comboBox141_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox141.SelectedValue);
                comboBox141.SelectedValue = index;
              
                lista20.Add(index);
            }
        }

        private void comboBox146_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox146.SelectedValue);
                comboBox146.SelectedValue = index;
              
                lista21.Add(index);
            }
        }

        private void comboBox145_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox145.SelectedValue);
                comboBox145.SelectedValue = index;
              
                lista22.Add(index);
            }
        }

        private void comboBox144_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox144.SelectedValue);
                comboBox144.SelectedValue = index;
              
                lista23.Add(index);
            }
        }

        private void comboBox143_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox143.SelectedValue);
                comboBox143.SelectedValue = index;
              
                lista24.Add(index);
            }
        }

        private void comboBox142_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registro == true)
            {

                int index = Convert.ToInt32(comboBox142.SelectedValue);
                comboBox142.SelectedValue = index;
              
                lista25.Add(index);
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
                        Periodicidad pla = new Periodicidad(fecha.Text, Convert.ToInt32(c1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(tec.SelectedValue), Convert.ToInt32(b), "", 0, "S", "P", "", "Primario", "", "");
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
                    Periodicidad pla = new Periodicidad(fecha.Text, Convert.ToInt32(c1.SelectedValue), Convert.ToInt32(a), Convert.ToInt32(tec.SelectedValue), 30, "", 0, "S", "P", "", "Primario", "", "");
                    ca.addfecha(pla);
                    index1 = 0;
                    index++;

                }
            }

             */
        }
       
    }
}
