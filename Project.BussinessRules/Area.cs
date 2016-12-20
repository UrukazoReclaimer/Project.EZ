using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessRules
{
   public class Area
    {
       int cod;
       string nombreArea;



       public Area(int cod, string nombreArea) 
       
       {
           this.Cod = cod;
           this.NombreArea = nombreArea;
       
       }

       public Area(string nombreArea)
       {
           this.NombreArea = nombreArea;
       
       
       }

       public int Cod {

           get { return cod; }
           set { cod = value; }
       
       }

       public string NombreArea {

           get { return nombreArea; }
           set { nombreArea = value; }
       }

    }
}
