using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessRules
{
    public class Inventariado
    {
        string cod;
        string rut;
        string tec;
        string ser;
        string consumo;
        string cli;
        string lugartratamiento;
        string area;
        DateTime fecha;
        string descripcion;
        string tipo;
        string ruta;
        string descripcionparticular;
        string nivel;


        /*
           public Inventariado(string rut,string tec, string ser,string consumo, string cli,string lugartratamiento, string area,string fecha)
         {
             this.Rut = rut;
             this.Tec = tec;
             this.Ser = ser;
             this.Consumo = consumo;
             this.Cli = cli;
             this.Lugardetratamiento = lugartratamiento;
             this.Area = area;
             this.Fecha = fecha;

         }
        */


        public Inventariado(string tec, string ruta, string tipo, string ser, string cli, string rut, string descripcion, string lugartratamiento, string area, DateTime fecha)
        {

            this.Tec = tec;
            this.Ser = ser;
            this.Cli = cli;
            this.Rut = rut;
            this.Descripcion = descripcion;
            this.Lugardetratamiento = lugartratamiento;
            this.Area = area;
            this.Fecha = fecha;
            this.Tipo = tipo;
            this.Ruta = ruta;
        }
        
        public Inventariado(string tec, string ruta, string tipo, string ser, string cli, string rut, string descripcion, string lugartratamiento, string area, DateTime fecha, string cod, string descripcionparticular, string nivel)
        {
            this.Tec = tec;
            this.Ser = ser;
            this.Cli = cli;
            this.Rut = rut;
            this.Descripcion = descripcion;
            this.Lugardetratamiento = lugartratamiento;
            this.Area = area;
            this.Fecha = fecha;
            this.Cod = cod;
            this.Tipo = tipo;
            this.Ruta = ruta;
            this.DescripcionParticular = descripcionparticular;
            this.Nivel = nivel;
            
        }





        /**
                  public Inventariado(string tec, string lugartratamiento, string area, string ser, string consumo, string cli, string rut, string fecha)
                  {
                      this.Rut = rut;
                      this.Tec = tec;
                      this.Ser = ser;
                      this.Consumo = consumo;
                      this.Cli = cli;
                      this.Lugardetratamiento = lugartratamiento;
                      this.Area = area;
                      this.Fecha = fecha;

                  }


               public string PlanoCliente
               {
                   get { return planocliente; }
                   set { planocliente = value; }

               }
               public string Plano
               {
                   get { return plano; }
                   set { plano = value; }
       
               }
         */




        public string Tec
        {
            get { return tec; }
            set { tec = value; }
        }

        public string Ruta
        {
            get { return ruta; }
            set { ruta = value; }
        }
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public string Lugardetratamiento
        {
            get { return lugartratamiento; }
            set { lugartratamiento = value; }
        }

        public string Area
        {
            get { return area; }
            set { area = value; }
        }


        public string Ser
        {
            get { return ser; }
            set { ser = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public string Cli
        {
            get { return cli; }
            set { cli = value; }
        }

        public string Rut
        {
            get { return rut; }
            set { rut = value; }

        }



        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public string Cod
        {
            get { return cod; }
            set { cod = value; }
        }
        public string DescripcionParticular
        {
            get { return descripcionparticular; }
            set { descripcionparticular = value; }
        }
        public string Nivel
        {
            get { return nivel; }
            set { nivel = value; }
        }

   
    }
}
