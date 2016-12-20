using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessRules
{
   public class Estado
    {
           int cod;
       string estado;
       int pericod;



       public Estado(string estado, int pericod)
          
       {

           this.ESTADO = estado;
           this.PERICOD = pericod;


       }
       public Estado(int cod, string estado, int pericod)
           
 {
     this.COD = cod;
     this.ESTADO=estado;
     this.PERICOD = pericod; 
     

 }

        public int COD
        {
            get { return cod; }
            set { cod = value; }
        }

          public string ESTADO
        {
            get { return estado; }
            set { estado = value; }
        }
        public int PERICOD
        {
            get { return pericod; }
            set { pericod = value; }
        }

    }


    }

