using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessRules
{
  public class PlanificacionRealizados
    {
         
          string cli;
      string ruta;
          string tiposer;
           string nplano;
           string fecha;
      string lugar;
      string ser;
      string tec;
         




            public PlanificacionRealizados(string cli, string ruta, string nplano, string lugar, string fecha, string ser,string tec)
       {
           this.Ciente = cli;
           this.Ruta = ruta;
           this.Nplano = nplano;
           this.Lugar = lugar;
           this.Fecha = fecha;
           this.Servicio = ser;
           this.Tecnico = tec;
           
        
           
         

       }
          
      public string Ciente
      
      {
          get { return cli; }
          set { cli = value; }
      }
      public string Ruta
      {
         get{ return ruta; }
          set{ ruta=value; }
      
      }

      public string Nplano 
      {
          get { return nplano; }
          set { nplano = value; }
      
      }

      public string Lugar 
      {
          get { return lugar; }
          set { lugar = value; }
      }



            public string Fecha 
            {

                get { return fecha; }
                set { fecha = value; }
            
            
            }

            public string Servicio 
            {

                get { return ser; }
                set { ser = value; }
            
            }

            public string Tecnico 
            {
                get { return tec; }
                set { tec = value; }
            
            }
    
    }
    
}
