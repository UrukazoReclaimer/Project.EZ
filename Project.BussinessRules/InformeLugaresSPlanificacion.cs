using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessRules
{
    public class InformeLugaresSPlanificacion
    {
        string clasificacion;
        string cliente;
        string lugar;
        string nplano;
        string estado;

        public InformeLugaresSPlanificacion(string clasificacion, string cliente, string lugar, string nplano, string estado)
        {

            this.Clasificacion = clasificacion;
            this.Cliente = cliente;
            this.Lugar = lugar;
            this.NPlano = nplano;
            this.Estado = estado;
        }

        public InformeLugaresSPlanificacion(string clasificacion, string cliente, string lugar, string nplano)
        {

            this.Clasificacion = clasificacion;
            this.Cliente = cliente;
            this.Lugar = lugar;
            this.NPlano = nplano;
     
        }

        public string Clasificacion
        {
            get { return clasificacion; }
            set { clasificacion = value; }
        }
        public string Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public string Lugar
        {
            get { return lugar; }
            set { lugar = value; }
        }

        public string NPlano
        {
            get { return nplano; }
            set { nplano = value; }
        }
          public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

    }
}
