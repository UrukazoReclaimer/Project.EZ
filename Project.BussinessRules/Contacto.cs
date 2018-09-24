using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessRules
{
    public class Contacto : LugarTratamiento
    {
        int id;
        int codnt;

        string nombrecontacto;
        string telefono;
        string email;
        string tipo;


        public Contacto(int codnt, string nombrecontacto, string telefono, string email, string tipo)
            : base(codnt)
        {
            CODNT = codnt;
            Nombrecontacto = nombrecontacto;
            Telefono = telefono;
            Email = email;
            Tipo = tipo;

        }

        public Contacto(string nombrecontacto, string telefono, string email, string tipo, int id)
            : base(id)
        {

            Id = id;
            Nombrecontacto = nombrecontacto;
            Telefono = telefono;
            Email = email;
            Tipo = tipo;

        }

        public Contacto(int id, int codnt, string nombrecontacto, string telefono, string email, string tipo)
            : base(codnt)
        {
            Id = id;
            CODNT = codnt;
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

        public int CODNT
        {
            get { return codnt; }
            set { codnt = value; }
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
