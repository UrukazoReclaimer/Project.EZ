using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessRules
{
    public class Nota
    {
        string codpla;
        string cod;
        string contenido;
        string responsable;

        public Nota(string cod,string contenido, string responsable)
        {
            this.COD= cod;
            this.CONTENIDO = contenido;
            this.RESPONSABLE = responsable;
        
        }
        public Nota(string cod, string contenido, string responsable, string codpla)
        {
            this.COD = cod;
            this.CONTENIDO = contenido;
            this.RESPONSABLE = responsable;

        }

   
            public string COD
        {
            get { return cod; }
            set { cod = value; }
        }

            public string CONTENIDO
            {
                get { return contenido; }
                set { contenido = value; }
            }
            public string RESPONSABLE
            {
                get { return responsable; }
                set { responsable = value; }
            }

            public string CODPLA
            {
                get { return codpla; }
                set { codpla = value; }
            }

    }
}
