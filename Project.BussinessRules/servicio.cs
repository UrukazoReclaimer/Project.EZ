using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessRules
{
    public class servicio
    {
        int cod;
        string nombre;
        string sigla;



        public servicio(int cod)
        {
            this.Cod = cod;



        }

        public servicio(string sigla)
        {
            this.Sigla = sigla;



        }


        public servicio(int cod, string nombre, string sigla)
        {
            this.Cod = cod;
            this.Nombre = nombre;
            this.Sigla = sigla;


        }
        public servicio(string nombre, string sigla)
        {

            this.Nombre = nombre;
            this.Sigla = sigla;
        }





        public int Cod
        {
            get { return cod; }
            set { cod = value; }
        }


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public string Sigla
        {

            get { return sigla; }
            set { sigla = value; }
        }



    }
}