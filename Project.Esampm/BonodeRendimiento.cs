using iTextSharp.text;
using iTextSharp.text.pdf;
using Project.BussinessRules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;



namespace Project.Esampm
{
    public partial class BonodeRendimiento : Form
    {
        public BonodeRendimiento()
        {
            InitializeComponent();
            CatalogoCliente cunits = new CatalogoCliente();
            List<cliente> uni = cunits.getclierut();
            this.comboBox2.DataSource = uni;
            this.comboBox2.DisplayMember = "nombre";
            this.comboBox2.ValueMember = "rut";

            CatalogoPlanilla ounits = new CatalogoPlanilla();
            List<LugarTratamiento> lu = ounits.allgetlugar();
            this.comboBox4.DataSource = lu;
            this.comboBox4.DisplayMember = "nombre";
            this.comboBox4.ValueMember = "rut";

            catalogoTecnico tunits = new catalogoTecnico();
            List<Project.BussinessRules.Tecnico> tec = tunits.obtenertec();

            this.comboBox5.DataSource = tec;
            this.comboBox5.DisplayMember = "nombre";
            this.comboBox5.ValueMember = "cod";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox8.Text == "Solo No Conformidades")
            {
                if (comboBox2.Text != "")
                {
                    CatalogoInformes clpe = new CatalogoInformes();
                    List<InventariadoInformeNoConformidad> listaa = new List<InventariadoInformeNoConformidad>();
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                    listaa = clpe.InformebuscarNoConformidadTodoParametro(dateTimePicker1.Text, dateTimePicker2.Text, comboBox2.Text, comboBox1.Text, comboBox4.Text, comboBox3.Text);
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                    this.dataGridView1.DataSource = listaa;
                }
                else
                {
                    if (comboBox4.Text == "" && comboBox2.Text == "" && comboBox1.Text == "" && comboBox6.Text == "" && comboBox3.Text == "" && comboBox5.Text == "")
                    {
                        CatalogoInformes clpe = new CatalogoInformes();
                        List<InventariadoInformeNoConformidad> listaa = new List<InventariadoInformeNoConformidad>();
                        dateTimePicker1.Format = DateTimePickerFormat.Custom;
                        dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                        dateTimePicker2.Format = DateTimePickerFormat.Custom;
                        dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                        listaa = clpe.InformebuscarNoConformidadSoloFechas(dateTimePicker1.Text, dateTimePicker2.Text);
                        dateTimePicker1.Format = DateTimePickerFormat.Custom;
                        dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                        dateTimePicker2.Format = DateTimePickerFormat.Custom;
                        dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                        this.dataGridView1.DataSource = listaa;

                    }
                }
                if (comboBox1.Text == "" && comboBox4.Text == "" && comboBox3.Text == "" && comboBox5.Text == "" && comboBox6.Text == "" && comboBox2.Text != "")
                {

                    CatalogoInformes clpe = new CatalogoInformes();
                    List<InventariadoInformeNoConformidad> listaa = new List<InventariadoInformeNoConformidad>();
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                    listaa = clpe.InformebuscarNoConformidadSoloCLiente(dateTimePicker1.Text, dateTimePicker2.Text, comboBox2.Text);
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                    this.dataGridView1.DataSource = listaa;


                }
                if (comboBox1.Text != "" && comboBox4.Text == "" && comboBox3.Text == "" && comboBox5.Text == "" && comboBox6.Text == "" && comboBox2.Text != "")
                {

                    CatalogoInformes clpe = new CatalogoInformes();
                    List<InventariadoInformeNoConformidad> listaa = new List<InventariadoInformeNoConformidad>();
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                    listaa = clpe.InformebuscarNoConformidadSoloClienteYTipo(dateTimePicker1.Text, dateTimePicker2.Text, comboBox2.Text, comboBox1.Text);
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                    this.dataGridView1.DataSource = listaa;


                }
                if (comboBox1.Text != "" && comboBox4.Text == "" && comboBox3.Text == "" && comboBox5.Text == "" && comboBox6.Text == "" && comboBox2.Text == "")
                {

                    CatalogoInformes clpe = new CatalogoInformes();
                    List<InventariadoInformeNoConformidad> listaa = new List<InventariadoInformeNoConformidad>();
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                    listaa = clpe.InformebuscarNoConformidadSoloTipo(dateTimePicker1.Text, dateTimePicker2.Text, comboBox1.Text);
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                    this.dataGridView1.DataSource = listaa;


                }

                if (comboBox1.Text == "" && comboBox4.Text != "" && comboBox3.Text == "" && comboBox5.Text == "" && comboBox6.Text == "" && comboBox2.Text == "")
                {

                    CatalogoInformes clpe = new CatalogoInformes();
                    List<InventariadoInformeNoConformidad> listaa = new List<InventariadoInformeNoConformidad>();
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                    listaa = clpe.InformebuscarNoConformidadSoloLugar(dateTimePicker1.Text, dateTimePicker2.Text, comboBox4.Text);
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                    this.dataGridView1.DataSource = listaa;


                }

                if (comboBox1.Text == "" && comboBox4.Text != "" && comboBox3.Text == "" && comboBox5.Text == "" && comboBox6.Text == "" && comboBox2.Text != "")
                {

                    CatalogoInformes clpe = new CatalogoInformes();
                    List<InventariadoInformeNoConformidad> listaa = new List<InventariadoInformeNoConformidad>();
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                    listaa = clpe.InformebuscarNoConformidadClienteYLugar(dateTimePicker1.Text, dateTimePicker2.Text, comboBox2.Text, comboBox4.Text);
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                    this.dataGridView1.DataSource = listaa;


                }
                if (comboBox1.Text == "" && comboBox4.Text == "" && comboBox3.Text != "" && comboBox5.Text == "" && comboBox6.Text == "" && comboBox2.Text == "")
                {

                    CatalogoInformes clpe = new CatalogoInformes();
                    List<InventariadoInformeNoConformidad> listaa = new List<InventariadoInformeNoConformidad>();
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                    listaa = clpe.InformebuscarNoConformidadSoloRuta(dateTimePicker1.Text, dateTimePicker2.Text, comboBox3.Text);
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                    this.dataGridView1.DataSource = listaa;


                }

                if (comboBox1.Text == "" && comboBox4.Text == "" && comboBox3.Text == "" && comboBox5.Text != "" && comboBox6.Text == "" && comboBox2.Text == "")
                {

                    CatalogoInformes clpe = new CatalogoInformes();
                    List<InventariadoInformeNoConformidad> listaa = new List<InventariadoInformeNoConformidad>();
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                    listaa = clpe.InformebuscarNoConformidadSoloTecnicos(dateTimePicker1.Text, dateTimePicker2.Text, comboBox5.Text);
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                    this.dataGridView1.DataSource = listaa;


                }
                if (comboBox1.Text == "" && comboBox4.Text != "" && comboBox3.Text == "" && comboBox5.Text != "" && comboBox6.Text == "" && comboBox2.Text == "")
                {

                    CatalogoInformes clpe = new CatalogoInformes();
                    List<InventariadoInformeNoConformidad> listaa = new List<InventariadoInformeNoConformidad>();
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                    listaa = clpe.InformebuscarNoConformidadTecnicosYLugar(dateTimePicker1.Text, dateTimePicker2.Text, comboBox5.Text, comboBox4.Text);
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                    this.dataGridView1.DataSource = listaa;


                }

                if (comboBox1.Text == "" && comboBox4.Text == "" && comboBox3.Text == "" && comboBox5.Text == "" && comboBox6.Text != "" && comboBox2.Text == "")
                {

                    CatalogoInformes clpe = new CatalogoInformes();
                    List<InventariadoInformeNoConformidad> listaa = new List<InventariadoInformeNoConformidad>();
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                    listaa = clpe.InformebuscarNoConformidadTipoPeriodicidad(dateTimePicker1.Text, dateTimePicker2.Text, comboBox6.Text);
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                    this.dataGridView1.DataSource = listaa;


                }
            }
            else
            {
                if (comboBox8.Text == "TODO")
                {
                    if (comboBox2.Text != "")
                    {
                        CatalogoInformes clpe = new CatalogoInformes();
                        List<InventariadoInformeNoConformidad> listaa = new List<InventariadoInformeNoConformidad>();
                        dateTimePicker1.Format = DateTimePickerFormat.Custom;
                        dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                        dateTimePicker2.Format = DateTimePickerFormat.Custom;
                        dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                        listaa = clpe.InformebuscarNoConformidadTodoParametroTODO(dateTimePicker1.Text, dateTimePicker2.Text, comboBox2.Text, comboBox1.Text, comboBox4.Text, comboBox3.Text);
                        dateTimePicker1.Format = DateTimePickerFormat.Custom;
                        dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                        dateTimePicker2.Format = DateTimePickerFormat.Custom;
                        dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                        this.dataGridView1.DataSource = listaa;
                    }



                    else
                    {
                        if (comboBox4.Text == "" && comboBox2.Text == "" && comboBox1.Text == "" && comboBox6.Text == "" && comboBox3.Text == "" && comboBox5.Text == "")
                        {
                            CatalogoInformes clpe = new CatalogoInformes();
                            List<InventariadoInformeNoConformidad> listaa = new List<InventariadoInformeNoConformidad>();
                            dateTimePicker1.Format = DateTimePickerFormat.Custom;
                            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                            dateTimePicker2.Format = DateTimePickerFormat.Custom;
                            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                            listaa = clpe.InformebuscarNoConformidadSoloFechasTODO(dateTimePicker1.Text, dateTimePicker2.Text);
                            dateTimePicker1.Format = DateTimePickerFormat.Custom;
                            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                            dateTimePicker2.Format = DateTimePickerFormat.Custom;
                            dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                            this.dataGridView1.DataSource = listaa;

                        }
                    }
                    if (comboBox1.Text == "" && comboBox4.Text == "" && comboBox3.Text == "" && comboBox5.Text == "" && comboBox6.Text == "" && comboBox2.Text != "")
                    {

                        CatalogoInformes clpe = new CatalogoInformes();
                        List<InventariadoInformeNoConformidad> listaa = new List<InventariadoInformeNoConformidad>();
                        dateTimePicker1.Format = DateTimePickerFormat.Custom;
                        dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                        dateTimePicker2.Format = DateTimePickerFormat.Custom;
                        dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                        listaa = clpe.InformebuscarNoConformidadSoloCLienteTODO(dateTimePicker1.Text, dateTimePicker2.Text, comboBox2.Text);
                        dateTimePicker1.Format = DateTimePickerFormat.Custom;
                        dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                        dateTimePicker2.Format = DateTimePickerFormat.Custom;
                        dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                        this.dataGridView1.DataSource = listaa;


                    }
                    if (comboBox1.Text != "" && comboBox4.Text == "" && comboBox3.Text == "" && comboBox5.Text == "" && comboBox6.Text == "" && comboBox2.Text != "")
                    {

                        CatalogoInformes clpe = new CatalogoInformes();
                        List<InventariadoInformeNoConformidad> listaa = new List<InventariadoInformeNoConformidad>();
                        dateTimePicker1.Format = DateTimePickerFormat.Custom;
                        dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                        dateTimePicker2.Format = DateTimePickerFormat.Custom;
                        dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                        listaa = clpe.InformebuscarNoConformidadSoloClienteYTipoTODO(dateTimePicker1.Text, dateTimePicker2.Text, comboBox2.Text, comboBox1.Text);
                        dateTimePicker1.Format = DateTimePickerFormat.Custom;
                        dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                        dateTimePicker2.Format = DateTimePickerFormat.Custom;
                        dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                        this.dataGridView1.DataSource = listaa;


                    }
                    if (comboBox1.Text != "" && comboBox4.Text == "" && comboBox3.Text == "" && comboBox5.Text == "" && comboBox6.Text == "" && comboBox2.Text == "")
                    {

                        CatalogoInformes clpe = new CatalogoInformes();
                        List<InventariadoInformeNoConformidad> listaa = new List<InventariadoInformeNoConformidad>();
                        dateTimePicker1.Format = DateTimePickerFormat.Custom;
                        dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                        dateTimePicker2.Format = DateTimePickerFormat.Custom;
                        dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                        listaa = clpe.InformebuscarNoConformidadSoloTipoTODO(dateTimePicker1.Text, dateTimePicker2.Text, comboBox1.Text);
                        dateTimePicker1.Format = DateTimePickerFormat.Custom;
                        dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                        dateTimePicker2.Format = DateTimePickerFormat.Custom;
                        dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                        this.dataGridView1.DataSource = listaa;


                    }
                    if (comboBox1.Text == "" && comboBox4.Text != "" && comboBox3.Text == "" && comboBox5.Text == "" && comboBox6.Text == "" && comboBox2.Text == "")
                    {

                        CatalogoInformes clpe = new CatalogoInformes();
                        List<InventariadoInformeNoConformidad> listaa = new List<InventariadoInformeNoConformidad>();
                        dateTimePicker1.Format = DateTimePickerFormat.Custom;
                        dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                        dateTimePicker2.Format = DateTimePickerFormat.Custom;
                        dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                        listaa = clpe.InformebuscarNoConformidadSoloLugarTODO(dateTimePicker1.Text, dateTimePicker2.Text, comboBox4.Text);
                        dateTimePicker1.Format = DateTimePickerFormat.Custom;
                        dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                        dateTimePicker2.Format = DateTimePickerFormat.Custom;
                        dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                        this.dataGridView1.DataSource = listaa;


                    }
                    if (comboBox1.Text == "" && comboBox4.Text != "" && comboBox3.Text == "" && comboBox5.Text == "" && comboBox6.Text == "" && comboBox2.Text != "")
                    {

                        CatalogoInformes clpe = new CatalogoInformes();
                        List<InventariadoInformeNoConformidad> listaa = new List<InventariadoInformeNoConformidad>();
                        dateTimePicker1.Format = DateTimePickerFormat.Custom;
                        dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                        dateTimePicker2.Format = DateTimePickerFormat.Custom;
                        dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                        listaa = clpe.InformebuscarNoConformidadClienteYLugarTODO(dateTimePicker1.Text, dateTimePicker2.Text, comboBox2.Text, comboBox4.Text);
                        dateTimePicker1.Format = DateTimePickerFormat.Custom;
                        dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                        dateTimePicker2.Format = DateTimePickerFormat.Custom;
                        dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                        this.dataGridView1.DataSource = listaa;

                         



                    }
                    if (comboBox1.Text == "" && comboBox4.Text == "" && comboBox3.Text != "" && comboBox5.Text == "" && comboBox6.Text == "" && comboBox2.Text == "")
                    {

                        CatalogoInformes clpe = new CatalogoInformes();
                        List<InventariadoInformeNoConformidad> listaa = new List<InventariadoInformeNoConformidad>();
                        dateTimePicker1.Format = DateTimePickerFormat.Custom;
                        dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                        dateTimePicker2.Format = DateTimePickerFormat.Custom;
                        dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                        listaa = clpe.InformebuscarNoConformidadSoloRutaTODO(dateTimePicker1.Text, dateTimePicker2.Text, comboBox3.Text);
                        dateTimePicker1.Format = DateTimePickerFormat.Custom;
                        dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                        dateTimePicker2.Format = DateTimePickerFormat.Custom;
                        dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                        this.dataGridView1.DataSource = listaa;


                    }
                    if (comboBox1.Text == "" && comboBox4.Text == "" && comboBox3.Text == "" && comboBox5.Text != "" && comboBox6.Text == "" && comboBox2.Text == "")
                    {

                        CatalogoInformes clpe = new CatalogoInformes();
                        List<InventariadoInformeNoConformidad> listaa = new List<InventariadoInformeNoConformidad>();
                        dateTimePicker1.Format = DateTimePickerFormat.Custom;
                        dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                        dateTimePicker2.Format = DateTimePickerFormat.Custom;
                        dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                        listaa = clpe.InformebuscarNoConformidadSoloTecnicosTODO(dateTimePicker1.Text, dateTimePicker2.Text, comboBox5.Text);
                        dateTimePicker1.Format = DateTimePickerFormat.Custom;
                        dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                        dateTimePicker2.Format = DateTimePickerFormat.Custom;
                        dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                        this.dataGridView1.DataSource = listaa;


                    }
                    if (comboBox1.Text == "" && comboBox4.Text != "" && comboBox3.Text == "" && comboBox5.Text != "" && comboBox6.Text == "" && comboBox2.Text == "")
                    {

                        CatalogoInformes clpe = new CatalogoInformes();
                        List<InventariadoInformeNoConformidad> listaa = new List<InventariadoInformeNoConformidad>();
                        dateTimePicker1.Format = DateTimePickerFormat.Custom;
                        dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                        dateTimePicker2.Format = DateTimePickerFormat.Custom;
                        dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                        listaa = clpe.InformebuscarNoConformidadTecnicosYLugarTODO(dateTimePicker1.Text, dateTimePicker2.Text, comboBox5.Text, comboBox4.Text);
                        dateTimePicker1.Format = DateTimePickerFormat.Custom;
                        dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                        dateTimePicker2.Format = DateTimePickerFormat.Custom;
                        dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                        this.dataGridView1.DataSource = listaa;


                    }
                    if (comboBox1.Text == "" && comboBox4.Text == "" && comboBox3.Text == "" && comboBox5.Text == "" && comboBox6.Text != "" && comboBox2.Text == "")
                    {

                        CatalogoInformes clpe = new CatalogoInformes();
                        List<InventariadoInformeNoConformidad> listaa = new List<InventariadoInformeNoConformidad>();
                        dateTimePicker1.Format = DateTimePickerFormat.Custom;
                        dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                        dateTimePicker2.Format = DateTimePickerFormat.Custom;
                        dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                        listaa = clpe.InformebuscarNoConformidadTipoPeriodicidadTODO(dateTimePicker1.Text, dateTimePicker2.Text, comboBox6.Text);
                        dateTimePicker1.Format = DateTimePickerFormat.Custom;
                        dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                        dateTimePicker2.Format = DateTimePickerFormat.Custom;
                        dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                        this.dataGridView1.DataSource = listaa;


                    }
                }
            }
        }
        private void ExportarDataGridViewExcelPlanilla(DataGridView grd)
        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo =
                    (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);


             
                //Recorremos el DataGridView rellenando la hoja de trabajo
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    hoja_trabajo.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < grd.Rows.Count; i++)
                {
                    for (int j = 0; j < grd.Columns.Count; j++)
                    {
                        
                        Range rango = (Microsoft.Office.Interop.Excel.Range)hoja_trabajo.Cells[2,6];
                        //ESTES EEEES
                        rango.EntireColumn.NumberFormat = "@";
                        /*
                        int size = grd.Columns.Count - 1;
                        if (size < grd.Columns.Count)
                        {
                            string cadena = grd.Rows[i + 2].Cells[5].Value.ToString();
                            char dia1 = cadena[0];
                            char dia2 = cadena[1];
                            char gion1 = cadena[2];
                            char mes1 = cadena[3];
                            char mes2 = cadena[4];
                            char gion2 = cadena[5];
                            char anno1 = cadena[6];
                            char anno2 = cadena[7];
                            char anno3 = cadena[8];
                            char anno4 = cadena[9];
                            string fecha = mes1.ToString() + mes2.ToString() + gion1.ToString() + dia1.ToString() + dia2.ToString() + gion2.ToString() + anno1.ToString() + anno2.ToString() + anno3.ToString() + anno4.ToString();
                            hoja_trabajo.Cells[i + 2, j + 1] = grd.Rows[i].Cells[j].Value;
                        }
                         */
                        hoja_trabajo.Cells[i + 2, j + 1] = grd.Rows[i].Cells[j].Value;
                       
                    }
                   
                }
                libros_trabajo.SaveAs(fichero.FileName,
                    Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PdfPTable pdfTabletitulo = new PdfPTable(1);
            pdfTabletitulo.DefaultCell.Padding = 3;
            pdfTabletitulo.WidthPercentage = 100;
            pdfTabletitulo.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTabletitulo.DefaultCell.BorderWidth = 1;


            PdfPTable pdfTable = new PdfPTable(10);
            pdfTable.DefaultCell.Padding = 1;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_RIGHT;
            pdfTable.DefaultCell.BorderWidth = 1;

            PdfPTable pdfleyenda = new PdfPTable(1);
            pdfleyenda.DefaultCell.Padding = 1;
            pdfleyenda.WidthPercentage = 100;
            pdfleyenda.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfleyenda.DefaultCell.BorderWidth = 1;


            PdfPCell cltitulo = new PdfPCell(new Phrase("Informe de Bono de Rendimiento y No Conformidad"));
            cltitulo.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            cltitulo.HorizontalAlignment = Element.ALIGN_CENTER;

            PdfPCell clleyenda = new PdfPCell(new Phrase(""));
            clleyenda.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);



            pdfTabletitulo.AddCell(cltitulo);
            pdfleyenda.AddCell(clleyenda);

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {

                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);

                pdfTable.AddCell(cell);

            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {

                    string s = "N/A";
                    if (cell.Value == null)
                    {
                        pdfTable.AddCell(s);

                    }
                    else
                    {

                        pdfTable.AddCell(cell.Value.ToString());
                    }

                }
            }

            //Exportar a PDF
            string folderPath = "C:\\check\\";
            if (!Directory.Exists(folderPath))
            {

                Directory.CreateDirectory(folderPath);
            }
            string hoy = DateTime.Now.Hour.ToString();
            comboBox1.Text = hoy;
            using (FileStream stream = new FileStream(folderPath + "Informe de Bono de Rendimiento y No Conformidad" + "-" + comboBox1.Text + ".pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);

                pdfDoc.Open();

                iTextSharp.text.Image imagen1 = iTextSharp.text.Image.GetInstance(@"\\STORAGE\\Public\\Esam compartido\\Informática\\esam.jpg");
                // iTextSharp.text.Image imagen1 = iTextSharp.text.Image.GetInstance("C:\\Users\\Urukazo\\Desktop\\respaldo bueno\\esam.jpg");
                // iTextSharp.text.Image imagen1 = iTextSharp.text.Image.GetInstance("C:\\Users\\natal\\Desktop\\Ejecutableroot\\esam.jpg");
                imagen1.BorderWidth = 0;
                imagen1.Alignment = Element.ALIGN_LEFT;
                float percentage = 0.0f;
                percentage = 150 / imagen1.Width;
                imagen1.ScalePercent(percentage * 100);

                pdfDoc.Add(imagen1);
                pdfDoc.Add(pdfTabletitulo);
                pdfDoc.Add(pdfTable);
              //  pdfDoc.Add(pdfleyenda);
                pdfDoc.Close();

                stream.Close();
                if (comboBox7.Text == "Explorer")
                {

                    System.Diagnostics.Process.Start("IExplore.exe", folderPath + "Informe de Bono de Rendimiento y No Conformidad" + "-" + comboBox1.Text + ".pdf");
                    // System.Diagnostics.Process.Start("NitroPDF.exe", folderPath + "Checklist" + "-" + comboBox1.Text + dateTimePicker1.Text + ".pdf");
                }
                if (comboBox7.Text == "Nitro")
                {
                    System.Diagnostics.Process.Start("NitroPDF.exe", folderPath + "Informe de Bono de Rendimiento y No Conformidad" + "-" + comboBox1.Text + dateTimePicker1.Text + ".pdf");
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewExcelPlanilla(dataGridView1);
            MessageBox.Show("Exportación Realizada");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox8.Text == "Solo No Conformidades")
            {
                if (comboBox2.Text != "")
                {
                    CatalogoInformes clpe = new CatalogoInformes();
                    List<InventariadoInformeNoConformidad> listaa = new List<InventariadoInformeNoConformidad>();
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                    listaa = clpe.InformebuscarNoConformidadTodoParametroSEPARADAS(dateTimePicker1.Text, dateTimePicker2.Text, comboBox2.Text, comboBox1.Text, comboBox4.Text, comboBox3.Text);
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                    this.dataGridView1.DataSource = listaa;
                }
                else
                {
                    if (comboBox4.Text == "" && comboBox2.Text == "" && comboBox1.Text == "" && comboBox6.Text == "" && comboBox3.Text == "" && comboBox5.Text == "")
                    {
                        CatalogoInformes clpe = new CatalogoInformes();
                        List<InventariadoInformeNoConformidad> listaa = new List<InventariadoInformeNoConformidad>();
                        dateTimePicker1.Format = DateTimePickerFormat.Custom;
                        dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                        dateTimePicker2.Format = DateTimePickerFormat.Custom;
                        dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                        listaa = clpe.InformebuscarNoConformidadSoloFechasSEPARADAS(dateTimePicker1.Text, dateTimePicker2.Text);
                        dateTimePicker1.Format = DateTimePickerFormat.Custom;
                        dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                        dateTimePicker2.Format = DateTimePickerFormat.Custom;
                        dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                        this.dataGridView1.DataSource = listaa;

                    }
                }
                if (comboBox1.Text == "" && comboBox4.Text == "" && comboBox3.Text == "" && comboBox5.Text == "" && comboBox6.Text == "" && comboBox2.Text != "")
                {

                    CatalogoInformes clpe = new CatalogoInformes();
                    List<InventariadoInformeNoConformidad> listaa = new List<InventariadoInformeNoConformidad>();
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                    listaa = clpe.InformebuscarNoConformidadSoloCLienteSEPARADAS(dateTimePicker1.Text, dateTimePicker2.Text, comboBox2.Text);
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                    this.dataGridView1.DataSource = listaa;


                }
                if (comboBox1.Text != "" && comboBox4.Text == "" && comboBox3.Text == "" && comboBox5.Text == "" && comboBox6.Text == "" && comboBox2.Text != "")
                {

                    CatalogoInformes clpe = new CatalogoInformes();
                    List<InventariadoInformeNoConformidad> listaa = new List<InventariadoInformeNoConformidad>();
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                    listaa = clpe.InformebuscarNoConformidadSoloClienteYTipoSEPARADAS(dateTimePicker1.Text, dateTimePicker2.Text, comboBox2.Text, comboBox1.Text);
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                    this.dataGridView1.DataSource = listaa;


                }
                if (comboBox1.Text != "" && comboBox4.Text == "" && comboBox3.Text == "" && comboBox5.Text == "" && comboBox6.Text == "" && comboBox2.Text == "")
                {

                    CatalogoInformes clpe = new CatalogoInformes();
                    List<InventariadoInformeNoConformidad> listaa = new List<InventariadoInformeNoConformidad>();
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                    listaa = clpe.InformebuscarNoConformidadSoloTipoSEPARADAS(dateTimePicker1.Text, dateTimePicker2.Text, comboBox1.Text);
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                    this.dataGridView1.DataSource = listaa;


                }

                if (comboBox1.Text == "" && comboBox4.Text != "" && comboBox3.Text == "" && comboBox5.Text == "" && comboBox6.Text == "" && comboBox2.Text == "")
                {

                    CatalogoInformes clpe = new CatalogoInformes();
                    List<InventariadoInformeNoConformidad> listaa = new List<InventariadoInformeNoConformidad>();
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                    listaa = clpe.InformebuscarNoConformidadSoloLugarSEPARADAS(dateTimePicker1.Text, dateTimePicker2.Text, comboBox4.Text);
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                    this.dataGridView1.DataSource = listaa;


                }

                if (comboBox1.Text == "" && comboBox4.Text != "" && comboBox3.Text == "" && comboBox5.Text == "" && comboBox6.Text == "" && comboBox2.Text != "")
                {

                    CatalogoInformes clpe = new CatalogoInformes();
                    List<InventariadoInformeNoConformidad> listaa = new List<InventariadoInformeNoConformidad>();
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                    listaa = clpe.InformebuscarNoConformidadClienteYLugarSEPARADAS(dateTimePicker1.Text, dateTimePicker2.Text, comboBox2.Text, comboBox4.Text);
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                    this.dataGridView1.DataSource = listaa;


                }
                if (comboBox1.Text == "" && comboBox4.Text == "" && comboBox3.Text != "" && comboBox5.Text == "" && comboBox6.Text == "" && comboBox2.Text == "")
                {

                    CatalogoInformes clpe = new CatalogoInformes();
                    List<InventariadoInformeNoConformidad> listaa = new List<InventariadoInformeNoConformidad>();
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                    listaa = clpe.InformebuscarNoConformidadSoloRutaSEPARADAS(dateTimePicker1.Text, dateTimePicker2.Text, comboBox3.Text);
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                    this.dataGridView1.DataSource = listaa;


                }

                if (comboBox1.Text == "" && comboBox4.Text == "" && comboBox3.Text == "" && comboBox5.Text != "" && comboBox6.Text == "" && comboBox2.Text == "")
                {

                    CatalogoInformes clpe = new CatalogoInformes();
                    List<InventariadoInformeNoConformidad> listaa = new List<InventariadoInformeNoConformidad>();
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                    listaa = clpe.InformebuscarNoConformidadSoloTecnicosSEPARADAS(dateTimePicker1.Text, dateTimePicker2.Text, comboBox5.Text);
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                    this.dataGridView1.DataSource = listaa;


                }
                if (comboBox1.Text == "" && comboBox4.Text != "" && comboBox3.Text == "" && comboBox5.Text != "" && comboBox6.Text == "" && comboBox2.Text == "")
                {

                    CatalogoInformes clpe = new CatalogoInformes();
                    List<InventariadoInformeNoConformidad> listaa = new List<InventariadoInformeNoConformidad>();
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                    listaa = clpe.InformebuscarNoConformidadTecnicosYLugarSEPERADAS(dateTimePicker1.Text, dateTimePicker2.Text, comboBox5.Text, comboBox4.Text);
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                    this.dataGridView1.DataSource = listaa;


                }

                if (comboBox1.Text == "" && comboBox4.Text == "" && comboBox3.Text == "" && comboBox5.Text == "" && comboBox6.Text != "" && comboBox2.Text == "")
                {

                    CatalogoInformes clpe = new CatalogoInformes();
                    List<InventariadoInformeNoConformidad> listaa = new List<InventariadoInformeNoConformidad>();
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                    listaa = clpe.InformebuscarNoConformidadTipoPeriodicidadSEPARADAS(dateTimePicker1.Text, dateTimePicker2.Text, comboBox6.Text);
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                    this.dataGridView1.DataSource = listaa;


                }
            }
            if (comboBox8.Text == "TODO")
            {
                if (comboBox2.Text != "")
                {
                    CatalogoInformes clpe = new CatalogoInformes();
                    List<InventariadoInformeNoConformidad> listaa = new List<InventariadoInformeNoConformidad>();
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                    listaa = clpe.InformebuscarNoConformidadTodoParametroTODOSEPARADAS(dateTimePicker1.Text, dateTimePicker2.Text, comboBox2.Text, comboBox1.Text, comboBox4.Text, comboBox3.Text);
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                    this.dataGridView1.DataSource = listaa;
                }


            
            else
            {
                if (comboBox4.Text == "" && comboBox2.Text == "" && comboBox1.Text == "" && comboBox6.Text == "" && comboBox3.Text == "" && comboBox5.Text == "")
                {
                    CatalogoInformes clpe = new CatalogoInformes();
                    List<InventariadoInformeNoConformidad> listaa = new List<InventariadoInformeNoConformidad>();
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                    listaa = clpe.InformebuscarNoConformidadSoloFechasTODOSEPARADAS(dateTimePicker1.Text, dateTimePicker2.Text);
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                    this.dataGridView1.DataSource = listaa;

                }
            }
            if (comboBox1.Text == "" && comboBox4.Text == "" && comboBox3.Text == "" && comboBox5.Text == "" && comboBox6.Text == "" && comboBox2.Text != "")
            {

                CatalogoInformes clpe = new CatalogoInformes();
                List<InventariadoInformeNoConformidad> listaa = new List<InventariadoInformeNoConformidad>();
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                listaa = clpe.InformebuscarNoConformidadSoloCLienteTODOSEPARADAS(dateTimePicker1.Text, dateTimePicker2.Text, comboBox2.Text);
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                this.dataGridView1.DataSource = listaa;


            }
            if (comboBox1.Text != "" && comboBox4.Text == "" && comboBox3.Text == "" && comboBox5.Text == "" && comboBox6.Text == "" && comboBox2.Text != "")
            {

                CatalogoInformes clpe = new CatalogoInformes();
                List<InventariadoInformeNoConformidad> listaa = new List<InventariadoInformeNoConformidad>();
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                listaa = clpe.InformebuscarNoConformidadSoloClienteYTipoTODOSEPARADAS(dateTimePicker1.Text, dateTimePicker2.Text, comboBox2.Text, comboBox1.Text);
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                this.dataGridView1.DataSource = listaa;


            }
            if (comboBox1.Text != "" && comboBox4.Text == "" && comboBox3.Text == "" && comboBox5.Text == "" && comboBox6.Text == "" && comboBox2.Text == "")
            {

                CatalogoInformes clpe = new CatalogoInformes();
                List<InventariadoInformeNoConformidad> listaa = new List<InventariadoInformeNoConformidad>();
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                listaa = clpe.InformebuscarNoConformidadSoloTipoTODO(dateTimePicker1.Text, dateTimePicker2.Text, comboBox1.Text);
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                this.dataGridView1.DataSource = listaa;


            }
            if (comboBox1.Text == "" && comboBox4.Text != "" && comboBox3.Text == "" && comboBox5.Text == "" && comboBox6.Text == "" && comboBox2.Text == "")
            {

                CatalogoInformes clpe = new CatalogoInformes();
                List<InventariadoInformeNoConformidad> listaa = new List<InventariadoInformeNoConformidad>();
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                listaa = clpe.InformebuscarNoConformidadSoloLugarTODOSEPARADAS(dateTimePicker1.Text, dateTimePicker2.Text, comboBox4.Text);
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                this.dataGridView1.DataSource = listaa;


            }
            if (comboBox1.Text == "" && comboBox4.Text != "" && comboBox3.Text == "" && comboBox5.Text == "" && comboBox6.Text == "" && comboBox2.Text != "")
            {

                CatalogoInformes clpe = new CatalogoInformes();
                List<InventariadoInformeNoConformidad> listaa = new List<InventariadoInformeNoConformidad>();
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                listaa = clpe.InformebuscarNoConformidadClienteYLugarTODOSEPARADAS(dateTimePicker1.Text, dateTimePicker2.Text, comboBox2.Text, comboBox4.Text);
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                this.dataGridView1.DataSource = listaa;


            }
            if (comboBox1.Text == "" && comboBox4.Text == "" && comboBox3.Text != "" && comboBox5.Text == "" && comboBox6.Text == "" && comboBox2.Text == "")
            {

                CatalogoInformes clpe = new CatalogoInformes();
                List<InventariadoInformeNoConformidad> listaa = new List<InventariadoInformeNoConformidad>();
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                listaa = clpe.InformebuscarNoConformidadSoloRutaTODOSEPARADAS(dateTimePicker1.Text, dateTimePicker2.Text, comboBox3.Text);
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                this.dataGridView1.DataSource = listaa;


            }
            if (comboBox1.Text == "" && comboBox4.Text == "" && comboBox3.Text == "" && comboBox5.Text != "" && comboBox6.Text == "" && comboBox2.Text == "")
            {

                CatalogoInformes clpe = new CatalogoInformes();
                List<InventariadoInformeNoConformidad> listaa = new List<InventariadoInformeNoConformidad>();
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                listaa = clpe.InformebuscarNoConformidadSoloTecnicosTODOSEPARADAS(dateTimePicker1.Text, dateTimePicker2.Text, comboBox5.Text);
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                this.dataGridView1.DataSource = listaa;


            }
            if (comboBox1.Text == "" && comboBox4.Text != "" && comboBox3.Text == "" && comboBox5.Text != "" && comboBox6.Text == "" && comboBox2.Text == "")
            {

                CatalogoInformes clpe = new CatalogoInformes();
                List<InventariadoInformeNoConformidad> listaa = new List<InventariadoInformeNoConformidad>();
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                listaa = clpe.InformebuscarNoConformidadTecnicosYLugarTODOSEPARADAS(dateTimePicker1.Text, dateTimePicker2.Text, comboBox5.Text, comboBox4.Text);
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                this.dataGridView1.DataSource = listaa;


            }
            if (comboBox1.Text == "" && comboBox4.Text == "" && comboBox3.Text == "" && comboBox5.Text == "" && comboBox6.Text != "" && comboBox2.Text == "")
            {

                CatalogoInformes clpe = new CatalogoInformes();
                List<InventariadoInformeNoConformidad> listaa = new List<InventariadoInformeNoConformidad>();
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                listaa = clpe.InformebuscarNoConformidadTipoPeriodicidadTODOSEPARADAS(dateTimePicker1.Text, dateTimePicker2.Text, comboBox6.Text);
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                this.dataGridView1.DataSource = listaa;


            }
            }
        }

    }
}
