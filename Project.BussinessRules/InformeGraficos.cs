using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessRules
{
    public class InformeGraficos
    {
        string fecha;
        string consumo;
        string lugar;
        string visitas;
        string oti;
        string año;
        string mes;
        public InformeGraficos(string fecha, string consumo, string lugar, string visitas)
        {
            this.Fecha = fecha;
            this.Consumo = consumo;
            this.Lugar = lugar;
            this.Visitas = visitas;

        }
        /*
        public InformeGraficos(string fecha, string consumo, string lugar,string visitas, string año)
        {
            this.Fecha = fecha;
            this.Consumo = consumo;
            this.Lugar = lugar;
            this.Visitas = visitas;
            this.Año = año;
        }
         */
            public InformeGraficos(string fecha, string consumo, string lugar,string visitas,string mes)
        {
            this.Fecha = fecha;
            this.Consumo = consumo;
            this.Lugar = lugar;
            this.Visitas = visitas;
            this.Mes=mes;
           
        }
        public InformeGraficos(string lugar, string oti)
        {
          
          
            this.Lugar = lugar;
            this.Oti = oti;

        }

        public string Fecha
        {

            get { return fecha; }
            set { fecha = value; }

        }
        public string Consumo
        {

            get { return consumo; }
            set { consumo = value; }

        }

        public string Lugar
        {

            get { return lugar; }
            set { lugar = value; }

        }

        public string Visitas 
        {
            get { return visitas; }
            set { visitas = value; }
        
        
        }
        public string Mes
        {
            get { return mes; }
            set { mes = value; }


        }
        public string Oti
        {
            get { return oti; }
            set { oti = value; }


        }
        public string Año 
        {
            get { return año; }
            set { año = value; }

        }
    }
}

