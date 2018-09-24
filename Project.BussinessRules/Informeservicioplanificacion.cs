using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessRules
{
    public class Informeservicioplanificacion
    {


        string cli;
        string lugar;
        string nplano;
        string mes;
        string fecha;
        string ser;
        string area;
        string estado;
        string tec;

        public Informeservicioplanificacion(string cli, string lugar, string nplano, string mes, string fecha, string ser, string area, string estado, string tec)
        {

            this.Cliente = cli;
            this.Lugar = lugar;
            this.Nplano = nplano;
            this.Mes = mes;
            this.Fecha = fecha;
            this.Servicio = ser;
            this.Area = area;
            this.Estado = estado;
            this.Tecnico = tec;
        }

        public string Cliente
        {
            get { return cli; }
            set { cli = value; }
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

        public string Mes
        {
            get { return mes; }
            set { mes = value; }

        }

        public string Fecha
        {

            get { return fecha; }
            set { fecha = value; }


        }

        public string Servicio
        {

            get { return ser; }
            set { ser = value; }

        }

        public string Area
        {

            get { return area; }
            set { area = value; }

        }
        public string Estado
        {

            get { return estado; }
            set { estado = value; }

        }

        public string Tecnico
        {
            get { return tec; }
            set { tec = value; }

        }
    }
}
