using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessRules
{
    public class vehiculo
    {

        string patente;
        string descripcion;
        string fecha;
        int km;
        string extintores;



        public vehiculo(string patente, string descripcion, string fecha, int km, string extintores)
        {

            this.Patente = patente;
            this.Descripcion = descripcion;
            this.Fecha = fecha;
            this.KM = km;
            this.Extintores = extintores;

        }


        public string Patente
        {

            get { return patente; }
            set { patente = value; }


        }

        public string Descripcion
        {

            get { return descripcion; }
            set { descripcion = value; }


        }
        public string Fecha
        {

            get { return fecha; }
            set { fecha = value; }


        }
        public int KM
        {

            get { return km; }
            set { km = value; }


        }
        public string Extintores
        {

            get { return extintores; }
            set { extintores = value; }


        }

    }
}
