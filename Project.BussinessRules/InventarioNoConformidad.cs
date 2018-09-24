using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessRules
{
 public   class InventarioNoConformidad
    {
      string noconformidad;


      public InventarioNoConformidad(string noconformidad)
        {

            this.NoConformidad = noconformidad;       
        }
      public string NoConformidad
      {
          get { return noconformidad; }
          set { noconformidad = value; }
      }
    }
}
