using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessRules
{
    public class Planilla
    {
        int cod;
        string cli;

        string cliRut;
        int areacod;
        string consumo;
        int periodicidadCod;
        string periodicidad;
        int cliCod;
        int lugarcod;
        string numero;
        string oti;
        string descripcion;
        string estado;
        /**
              public Planilla(string cliRut, int areacod, string consumo,string oti,int numero,string descripcion, int clicod, int lugarcod)
              {
    
     
    
             this.cliRut = cliRut;
             this.Areacod = areacod;
             this.Consumo = consumo;
             this.Oti = oti;
             this.Numero = numero;
             this.Clicod = clicod;
             this.Descripcion = descripcion;
             this.LugarCod = lugarcod;
     
  
          }
         */
        //constructor usado
        /**
         public Planilla(string cliRut, int areacod, string consumo,string numero, string descripcion, int clicod, int lugarcod)
    {
    
        this.cliRut = cliRut;
        this.Areacod = areacod;
        this.Consumo = consumo; 
        this.Numero = numero;
        this.Descripcion = descripcion;
        this.Clicod = clicod;
        this.LugarCod = lugarcod;
     
     

    }
         */
        public Planilla(string cliRut, string numero, string descripcion, int clicod, int lugarcod)
        {

            this.cliRut = cliRut;

            this.Numero = numero;
            this.Descripcion = descripcion;
            this.Clicod = clicod;
            this.LugarCod = lugarcod;



        }

        public Planilla(int cod, string cliRut, string oti, int areacod, int cliCod, int lugarcod)
        {
            this.Cod = cod;
            this.cliRut = cliRut;
            this.Areacod = areacod;
            this.Clicod = cliCod;
            this.LugarCod = lugarcod;

        }


        public Planilla(string descripcion, int cod)
        {
            this.Cod = cod;
            this.Descripcion = descripcion;

        }

        //public Planilla(int tecCod, int serCod, string cliRut, string consumo, string area)
        //{
        //    this.TecCod = tecCod;
        //    this.SerCod = serCod;
        //    this.cliRut = cliRut;
        //    this.Consumo = consumo;
        //    this.Area = area;
        //    this.PeriodicidadCod = periodicidadCod;

        //}


        public Planilla(string clirut, int cod, int cliCod, int periodicidadCod)
        {

            this.CliRut = cliRut;
            this.Cod = cod;
            this.Clicod = cliCod;
            this.PeriodicidadCod = periodicidadCod;
        }

        public Planilla(string cli)
        {
            this.Cli = cli;

        }

        public Planilla(int cod)
        {
            this.Cod = cod;

        }

        public int Cod
        {
            get { return cod; }
            set { cod = value; }

        }



        public string Cli
        {
            get { return cli; }
            set { cli = value; }
        }




        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }


        public int Clicod
        {

            get { return cliCod; }
            set { cliCod = value; }
        }

        public string Periodicidad
        {
            get { return periodicidad; }
            set { periodicidad = value; }


        }


        public string CliRut
        {
            get { return cliRut; }
            set { cliRut = value; }
        }
        public int Areacod
        {
            get { return areacod; }
            set { areacod = value; }
        }


        public int PeriodicidadCod
        {
            get { return periodicidadCod; }
            set { periodicidadCod = value; }
        }

        public int LugarCod
        {
            get { return lugarcod; }
            set { lugarcod = value; }

        }

    }
}
