using Project.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessRules
{
    public class Permiso
    {

        int cod;
        string motivo;

        public Permiso(int cod, string motivo)
        {
            this.Cod = cod;
            this.Motivo = motivo;

        }

        public Permiso(string motivo)
        {

            this.Motivo = motivo;
        }


        public int Cod
        {
            get { return cod; }
            set { cod = value; }
        }

        public string Motivo
        {
            get { return motivo; }
            set { motivo = value; }
        }
    }
}
