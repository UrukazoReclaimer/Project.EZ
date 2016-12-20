using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessRules
{
  public  class vehiculo
    {

      string patente;
      string descripcion;



      public vehiculo(string patente, string descripcion) {

          this.Patente = patente;
          this.Descripcion = descripcion;
      
      }


      public string Patente {
      
        get { return patente; }
        set { patente=value; }
        
      
      }

      public string Descripcion{

          get { return descripcion; }
          set { descripcion = value; }

  
  }

    }
}
