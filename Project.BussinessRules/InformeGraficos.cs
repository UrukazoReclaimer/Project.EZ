using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessRules
{
   public class InformeGraficos
    {
       string fecha;
       string consumo;
       string lugar;


       public InformeGraficos(string fecha, string consumo, string lugar)
       {
           this.Fecha = fecha;
           this.Consumo = consumo;
           this.Lugar = lugar;

       }

       public string Fecha
       {

           get { return fecha; }
           set { fecha = value; }

       }
       public string Consumo
       {

           get { return consumo; }
           set { consumo = value; }

       }

       public string Lugar
       {

           get { return lugar; }
           set { lugar = value; }

       }

   
   }
}

