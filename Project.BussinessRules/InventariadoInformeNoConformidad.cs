using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessRules
{
   public class InventariadoInformeNoConformidad
    {
        string noti;
        string cliente;
        string codlugar;
        string lugar;
        string tecnicos;
        string fecha;      
        string servicios;                
        string tiempo;
        string conformidad;
        string fechaformat;

        public InventariadoInformeNoConformidad(string noti,string cliente,string codlugar,string lugar,string tecnicos, string fecha, string servicios, string tiempo, string conformidad, string fechaformat) 
        {
            this.NOTI = noti;
            this.CLIENTE = cliente;
            this.CODLUGAR = codlugar;
            this.LUGAR = lugar;
            this.TECNICOS = tecnicos;
            this.FECHA = fecha;
            this.SERVICIO = servicios;
            this.TIEMPO = tiempo;
            this.CONFORMIDAD = conformidad;
            this.FECHAFORMAT = fechaformat;
        
        
        }
        public string NOTI
        {
            get { return noti; }
            set { noti = value; }
        }
        public string CLIENTE
        {
            get { return cliente; }
            set { cliente = value; }
        }
        public string CODLUGAR
        {
            get { return codlugar; }
            set { codlugar = value; }
        }
        public string LUGAR
        {
            get { return lugar; }
            set { lugar = value; }
        }
        public string TECNICOS
        {
            get { return tecnicos; }
            set { tecnicos = value; }
        }
        public string FECHA
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public string SERVICIO
        {
            get { return servicios; }
            set { servicios = value; }
        }
        public string TIEMPO
        {
            get { return tiempo; }
            set { tiempo = value; }
        }
        public string CONFORMIDAD
        {
            get { return conformidad; }
            set { conformidad = value; }
        }
        public string FECHAFORMAT
        {
            get { return fechaformat; }
            set { fechaformat = value; }
        }
       

    }
}
