using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessRules
{
    public class Inventariadoplano
    {

        int cod;
        string nomtratamiento;
        string rut;
        string codplano;
        string ruta;
        string tipo;
        string codlug;
        string nombre;

        public Inventariadoplano(int cod, string nomtratamiento, string rut, string codplano, string ruta, string codlug, string tipo,string nombre)
        {
            Cod = cod;
            Nomtrata = nomtratamiento;
            Rut = rut;
            Codplano = codplano;
            RUTA = ruta;
            CODLUG = codlug;
            TIPOLUGAR = tipo;
            NOMBRECLIENTE = nombre;
        }

        public int Cod
        {
            get { return cod; }
            set { cod = value; }
        }

        public string Nomtrata
        {
            get { return nomtratamiento; }
            set { nomtratamiento = value; }
        }
        public string Rut
        {
            get { return rut; }
            set { rut = value; }

        }


        public string Codplano
        {
            get { return codplano; }
            set { codplano = value; }
        }
        public string RUTA
        {
            get { return ruta; }
            set { ruta = value; }

        }
        public string CODLUG
        {
            get { return codlug; }
            set { codlug = value; }

        }
                                          
        public string TIPOLUGAR
        {
            get { return tipo; }
            set { tipo = value; }

        }
        public string NOMBRECLIENTE
        {
            get { return nombre; }
            set { nombre = value; }

        }
    }
}
