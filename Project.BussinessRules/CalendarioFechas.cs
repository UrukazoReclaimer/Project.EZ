using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessRules
{
   public class CalendarioFechas
    {
       string fecha;
       string ruta;
       string lugar;
       string servicio;


       public CalendarioFechas(string fecha,string ruta, string lugar, string servicio) 
       {
           this.Fecha = fecha;
           this.Ruta = ruta;
           this.Lugar = lugar;
           this.Servicio = servicio;
       
       }

       public string Fecha
       {

           get { return fecha; }
           set { fecha = value; }
       }

       public string Ruta
       {

           get { return ruta; }
           set { ruta = value; }
       }

       public string Lugar
       {

           get { return lugar; }
           set { lugar = value; }
       }
       public string Servicio
       {

           get { return servicio; }
           set { servicio = value; }
       }
    }
}
