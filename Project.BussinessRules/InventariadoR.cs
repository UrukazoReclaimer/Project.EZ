using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessRules
{
    public class InventariadoR
    {
        string codR;
        string rutR;
        string tecR;
        string serR;
        string consumoR;
        string cliR;
        string lugartratamientoR;
        string areaR;
        DateTime fechaR;
        string descrpcionR;
        string estadoR;
        string otiR;
        string tipor;
        string ruta;
        string nivel;
        string tiempo;


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


        public InventariadoR(string tecR, string ruta, string serR, string cliR, string rutR, string consumoR, string descripcionR, string lugartratamientoR, string areaR, DateTime fechaR, string codR, string otiR, string estadoR)
        {

            this.TecR = tecR;
            this.SerR = serR;
            this.CodR = codR;
            this.CliR = cliR;
            this.RutR = rutR;
            this.ConsumoR = consumoR;
            this.DescripcionR = descripcionR;
            this.LugardetratamientoR = lugartratamientoR;
            this.AreaR = areaR;
            this.FechaR = fechaR;
            this.OtiR = otiR;
            this.EstadoR = estadoR;
            this.RutaR = ruta;
        }

        public InventariadoR(string tecR, string ruta, string tipor, string serR, string cliR, string rutR, string consumoR, string descripcionR, string lugartratamientoR, string areaR, DateTime fechaR, string codR, string otiR, string estadoR,string nivel,string tiempo)
        {

            this.TecR = tecR;
            this.Tipor = tipor;
            this.SerR = serR;
            this.CodR = codR;
            this.CliR = cliR;
            this.RutR = rutR;
            this.ConsumoR = consumoR;
            this.DescripcionR = descripcionR;
            this.LugardetratamientoR = lugartratamientoR;
            this.AreaR = areaR;
            this.FechaR = fechaR;
            this.OtiR = otiR;
            this.EstadoR = estadoR;
            this.RutaR = ruta;
            this.Nivel = nivel;
            this.Tiempo = tiempo;
        }
        /*
        public InventariadoR(string tecR, string serR, string cliR, string rutR, string consumoR, string descripcionR, string lugartratamientoR, string areaR, string fechaR, string codR)
        {

            this.Tec = tec;
            this.Ser = ser;

            this.Cli = cli;
            this.Rut = rut;
            this.Consumo = consumo;
            this.Descripcion = descrpcion;
            this.Lugardetratamiento = lugartratamiento;
            this.Area = area;
            this.Fecha = fecha;
            this.Cod = cod;
            this.Estado = estado;
        }
        */




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




        public string TecR
        {
            get { return tecR; }
            set { tecR = value; }
        }
        public string RutaR
        {
            get { return ruta; }
            set { ruta = value; }
        }
        public string Tipor
        {
            get { return tipor; }
            set { tipor = value; }
        }

        public string LugardetratamientoR
        {
            get { return lugartratamientoR; }
            set { lugartratamientoR = value; }
        }

        public string AreaR
        {
            get { return areaR; }
            set { areaR = value; }
        }


        public string SerR
        {
            get { return serR; }
            set { serR = value; }
        }
        public string ConsumoR
        {
            get { return consumoR; }
            set { consumoR = value; }

        }
        public string DescripcionR
        {
            get { return descrpcionR; }
            set { descrpcionR = value; }
        }

        public string CliR
        {
            get { return cliR; }
            set { cliR = value; }
        }

        public string RutR
        {
            get { return rutR; }
            set { rutR = value; }

        }



        public DateTime FechaR
        {
            get { return fechaR; }
            set { fechaR = value; }
        }
        public string EstadoR
        {
            get { return estadoR; }
            set { estadoR = value; }
        }
        public string OtiR
        {
            get { return otiR; }
            set { otiR = value; }
        }

        public string CodR
        {
            get { return codR; }
            set { codR = value; }
        }
        public string Nivel
        {
            get { return nivel; }
            set { nivel = value; }
        }
        public string Tiempo
        {
            get { return tiempo; }
            set { tiempo = value; }
        }

    }
}
