using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessRules
{
    public class Check
    {
        int cod;
        string lugar;
        string ser;
        string numero;
        string oti;
        string plano;
        string certificado;
        string obs;
        string fecha;
        string periodicidad;
        string doc;
        string iden;

        public Check(int cod, string certificado, string obs,string fecha, string periodicidad, string iden)
        {
            this.Cod = cod;
            this.Certificado = certificado;
            this.Obs = obs;
            this.Fecha = fecha;
            this.Periodicidad = periodicidad;
            this.Iden = iden;
        
        }
        public Check(string certificado, string obs,string fecha ,string periodicidad , string iden)
        {
            this.Certificado = certificado;
            this.Obs = obs;
            this.Fecha = fecha;
            this.Periodicidad = periodicidad;
            this.Iden = iden;


        }

           public Check(string fecha, string numero, string lugar, string ser, string oti, string plano, string doc)
            {
                this.Fecha = fecha;
                this.Numero = numero;
                this.Lugar = lugar;
                this.Ser = ser;
                this.Plano = plano;
                this.Noti=oti;
                this.Doc = doc;



            }


           public Check(int cod)
           {
               this.Cod = cod;
               
           }


        public int Cod
        {
            get { return cod; }
            set {cod = value; }
        }

        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Lugar
        {
            get { return lugar; }
            set { lugar = value; }
        }

        public string Ser
        {
            get { return ser; }
            set { ser = value; }
        }
        public string Plano
        {
            get { return plano; }
            set { plano = value; }
        }
        public string Noti
        {
            get { return oti; }
            set { oti = value; }
        }

     

        public string Certificado
        {
            get { return certificado; }
            set { certificado = value; }
        }

        public string Doc
        {
            get { return doc; }
            set { doc = value; }
        }


        public string Obs
        {
            get { return obs; }
            set { obs = value; }
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

        public string Iden
        {
            get { return iden; }
            set { iden = value; }
        }
        
    }
}
