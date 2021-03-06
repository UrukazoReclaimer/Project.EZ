﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessRules
{
    public class InformeRDC
    {
        string cliente;
        string tipolugar;
        string lugar;
        string nplano;
        string ruta;
        string fecha;
        string periodicidad;
        string servicios;
        string tecnico;
        string noti;
        string solicitud;
        string motivo;



        public InformeRDC(string cliente, string tipolugar, string lugar, string nplano, string ruta, string fecha, string periodicidad, string servicios, string tecnico, string noti, string solicitud, string motivo)
        {
            this.Cliente = cliente;
            this.TipoLugar = tipolugar;
            this.Lugar = lugar;
            this.Nplano = nplano;
            this.Ruta = ruta;
            this.Fecha = fecha;
            this.Periodicidad = periodicidad;
            this.Servicios = servicios;
            this.Tecnico = tecnico;
            this.Noti = noti;
            this.Solicitud = solicitud;
            this.Motivo = motivo;

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


        public string Tecnico
        {

            get { return tecnico; }
            set { tecnico = value; }

        }

        public string Noti
        {

            get { return noti; }
            set { noti = value; }

        }

        public string Solicitud
        {

            get { return solicitud; }
            set { solicitud = value; }

        }

        public string Motivo
        {

            get { return motivo; }
            set { motivo = value; }

        }
    }

}
