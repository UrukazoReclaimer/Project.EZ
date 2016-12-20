using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessRules
{
   public class Oti
    {
       string cod;
       string pericod;



        public Oti(string cod, string pericod )
 {
     this.COD = cod;
     this.PERICOD = pericod; 
     

 }
 

        public string COD
        {
            get { return cod; }
            set { cod = value; }
        }

        public string PERICOD
        {
            get { return pericod; }
            set { pericod = value; }
        }

    }
}
