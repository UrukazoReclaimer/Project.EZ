using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessRules
{
    public class InformeServiciosReplanificados
    {
        string cliente;
        string tipolugar;
        string lugar;
        string nplano;
        string ruta;
        string fecha;
        string periodicidad;
        string servicios;
        string tecnicos;
        string observacion;


        public InformeServiciosReplanificados(string cliente, string tipolugar, string lugar, string nplano, string ruta, string fecha, string periodicidad, string servicios, string tecnicos, string observacion)
        {
            this.Cliente = cliente;
            this.TipoLugar = tipolugar;
            this.Lugar = lugar;
            this.Nplano = nplano;
            this.Ruta = ruta;
            this.Fecha = fecha;
            this.Periodicidad = periodicidad;
            this.Servicios = servicios;
            this.Tecnicos = tecnicos;
            this.Observacion = observacion;

        }

        public string Cliente
        {

            get { return cliente; }
            set { cliente = value; }

        }

        public string TipoLugar
        {

            get { return tipolugar; }
            set { tipolugar = value; }

        }

        public string Lugar
        {

            get { return lugar; }
            set { lugar = value; }

        }

        public string Nplano
        {

            get { return nplano; }
            set { nplano = value; }

        }

        public string Ruta
        {

            get { return ruta; }
            set { ruta = value; }

        }

        public string Fecha
        {

            get { return fecha; }
            set { fecha = value; }

        }

        public string Periodicidad
        {

            get { return periodicidad; }
            set { periodicidad = value; }

        }

        public string Servicios
        {

            get { return servicios; }
            set { servicios = value; }

        }

        public string Tecnicos
        {

            get { return tecnicos; }
            set { tecnicos = value; }

        }

        public string Observacion
        {

            get { return observacion; }
            set { observacion = value; }

        }

    }
}
