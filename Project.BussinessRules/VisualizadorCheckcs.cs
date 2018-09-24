using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessRules
{
    public class VisualizadorCheckcs
    {

        string ser;
        string lugartratamiento;
        string area;
        string fecha;
        string numero;
        string noti;
        string certi;
        string plano;
        string planocliente;
        string doc;
        


        public VisualizadorCheckcs(string fecha, string numero, string lugartratamiento, string ser,string area, string oti,string certi,  string plano, string doc)
        {
            this.Fecha = fecha;
            this.Numero = numero;
            this.Lugardetratamiento = lugartratamiento;
            this.Ser = ser;
            this.Are = area;
            this.Plano = plano;
            this.Noti = oti;
            this.Certificado = certi;
            this.Doc = doc;



        }

        public string Fecha
        {

            get { return fecha; }
            set { fecha = value; }


        }
        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Lugardetratamiento
        {
            get { return lugartratamiento; }
            set { lugartratamiento = value; }
        }
        public string Ser
        {
            get { return ser; }
            set { ser = value; }
        }

        public string Are
        {
            get { return area; }
            set { area = value; }
        }


        public string Noti
        {
            get { return noti; }
            set { noti = value; }
        }
        public string Certificado
        {
            get { return certi; }
            set { certi = value; }

        }
        public string Plano
        {
            get { return plano; }
            set { plano = value; }

        }

        public string PlanoCliente
        {
            get { return planocliente; }
            set { planocliente = value; }

        }

        public string Doc
        {
            get { return doc; }
            set { doc = value; }

        }
        
    }
}

