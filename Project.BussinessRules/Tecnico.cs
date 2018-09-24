using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessRules
{
    public class Tecnico
    {
        int cod;
        string rut;
        string nombre;

        string estado;

        public Tecnico(int cod, string rut, string nombre, string estado)
        {
            this.Cod = cod;
            this.Rut = rut;
            this.Nombre = nombre;

            this.Estado = estado;


        }

        public Tecnico(string rut, string nombre, string estado)
        {

            this.Rut = rut;
            this.Nombre = nombre;

            this.Estado = estado;


        }


        public Tecnico(int cod, string nombre)
        {
            this.Cod = cod;

            this.Nombre = nombre;



        }
        public Tecnico(string rut, string nombre)
        {

            this.Rut = rut;
            this.Nombre = nombre;



        }
        public Tecnico(int cod)
        {
            this.Cod = cod;


        }
        public string Rut
        {

            get { return rut; }
            set { rut = value; }

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


        public string Estado
        {
            get { return estado; }
            set { estado = value; }

        }

    }
}
