using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessRules
{
   public class InventariadoPermiso
    {

      
        string tec;
        
        DateTime fecha;
     
        string tipo;
       

        public InventariadoPermiso(string tec,string tipo,DateTime fecha)
        {

            this.Tec = tec;          
            this.Fecha = fecha;
            this.Tipo = tipo;            
        }
        public string Tec
        {
            get { return tec; }
            set { tec = value; }
        }
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
    }
}
