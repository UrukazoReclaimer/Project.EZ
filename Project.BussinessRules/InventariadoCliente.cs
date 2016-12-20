using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessRules
{
   public class InventariadoCliente
    {

       int cod;
       string ruta;
       string lugartratamiento;
       string nombre;
       string telefono;
       string correo;
       string tipo;
       string plano;
       string codid;
       string rut;
       string codlug;
       string nombrecliente;
       public InventariadoCliente(int cod, string ruta, string lugartratamiento, string nombre, string correo,string telefono, string tipo, string plano, string codid, string rut, string codlug, string nombrecliente)
       {
           COD = cod;
           RUTA = ruta;
           LUGAR = lugartratamiento;
           NOMBRE = nombre;
           CORREO = correo;
           TELEFONO = telefono;
         
           TIPO = tipo;
           PLANO = plano;
           CODID = codid;
           RUTCLIENTE = rut;
           CODLUG = codlug;
           NOMBRECLIENTE = nombrecliente;
       }


       public int COD 
       {
           get { return cod; }
           set { cod = value; }
       }

       public string RUTA
       {
           get { return ruta; }
           set { ruta = value; }
       
       }

       public string LUGAR
       {
           get { return lugartratamiento; }
           set { lugartratamiento = value; }

       }

       public string NOMBRE
       {
           get { return nombre; }
           set { nombre = value; }

       }

  

       public string CORREO
       {
           get { return correo; }
           set { correo = value; }

       }
       public string TELEFONO
       {
           get { return telefono; }
           set { telefono = value; }

       }
       public string TIPO
       {
           get { return tipo; }
           set { tipo= value; }

       }
       public string PLANO
       {
           get { return plano; }
           set { plano= value; }

       }
       public string CODID
       {
            get {return codid;}
            set { codid=value;}
       }

       public string RUTCLIENTE
       {
           get { return rut; }
           set { rut = value; } 
       }

       public string CODLUG 
       {
           get { return codlug; }
           set { codlug = value; }
       
       }

       public string NOMBRECLIENTE
       {
           get { return nombrecliente; }
           set { nombrecliente = value; }
        }
    }
}
