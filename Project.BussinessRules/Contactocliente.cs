using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessRules
{
    public class Contactocliente : cliente
    {
        int id;
        int cod;
        string rut;
        string nombrecontacto;
        string telefono;
        string email;
        string tipo;


        public Contactocliente(int cod, string rut, string nombrecontacto, string telefono, string email, string tipo)
            : base(cod, rut)
        {
            COD = cod;
            RUT = rut;
            Nombrecontacto = nombrecontacto;
            Telefono = telefono;
            Email = email;
            Tipo = tipo;

        }

        public Contactocliente(int id, int codnt, string nombrecontacto, string telefono, string email, string tipo)
            : base(codnt)
        {
            Id = id;
            COD = codnt;
            Nombrecontacto = nombrecontacto;
            Telefono = telefono;
            Email = email;
            Tipo = tipo;

        }



        public int Id
        {

            get { return id; }
            set { id = value; }
        }

        public int COD
        {
            get { return cod; }
            set { cod = value; }
        }
        public string RUT
        {
            get { return rut; }
            set { rut = value; }
        }

        public string Nombrecontacto
        {

            get { return nombrecontacto; }
            set { nombrecontacto = value; }
        }

        public string Telefono
        {

            get { return telefono; }
            set { telefono = value; }
        }

        public string Email
        {

            get { return email; }
            set { email = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

    }
}

