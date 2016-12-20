using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessRules
{
   public class Periodicidad:Planilla
    {
       int codi;
      string fecha;
       int cod;
       int codser;
       int codtec;
       int consumo;
       string tperiodicidad;
       int codarea;
       string oti;
       string estado;
       string observaciones;
       /**
              public Periodicidad(int cod,int tecCod, int serCod,string cliRut,string consumo, string area, string fecha, int codpla)
                 : base(cod,tecCod,serCod,cliRut,consumo,area)
              {
                  this.Cod = cod;
                  this.Fecha = fecha;
                  this.Codpla = cod;
          
       
              }
         **/
       /**
       public Periodicidad(int codpla)
       {
           
           this.Codpla = codpla;


       }
       **/
       //utilizadoooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo
       public Periodicidad(string fecha, int cod, int codser, int codtec, int codarea, string oti, int consumo, string tperiodicidad, string estado, string observaciones)
           :base(cod)
       {
           
           this.Fecha = fecha;  
           this.Codpla = cod;
           this.Codser = codser;
           this.Codtec=codtec;
           this.Codarea = codarea;
           this.Oti = oti;
           this.Consumo = consumo;
           this.Tperiodicidad = tperiodicidad;
           this.Estado = estado;
           this.observaciones = observaciones;
       }

       public Periodicidad(int cod,string oti)
           : base(cod)
       {


           this.Codperi = cod;
   
           this.Oti=oti;

       }

          public Periodicidad(string fecha,int cod)
           : base(cod)
       {

           this.Fecha = fecha;
           this.Cod = cod;
   

       }


       public Periodicidad(int codtec, int cod, string estado)
           : base(cod)
       {
           this.Codtec = codtec;

           this.Codperi = cod;

           this.Estado = estado;

       }

       public Periodicidad(string fecha, int cod, string estado)
           : base(cod)
       {
           this.Fecha = fecha;

           this.Codperi = cod;

           this.Estado = estado;

       }

       public Periodicidad(string fecha, int cod, int consumo, string oti)
           : base(cod)
       {
           this.Fecha = fecha;

           this.Codperi = cod;

           this.Consumo = consumo;

           this.Oti = oti;

       }
       public Periodicidad(string fecha, int cod, int codser, int codtec, int codarea)
           : base(cod)
       {

           this.Fecha = fecha;
           this.Codpla = cod;
           this.Codser = codser;
           this.Codtec = codtec;
           this.Codarea = codarea;
          

       }

       public Periodicidad(string observaciones, int cod, int codperi)
           : base(cod)
       {

           this.Observaciones = observaciones;
           this.Cod = cod;
           this.Codperi = codperi;
          


       }
//para fecha
       /*
       public Periodicidad(string fecha, int cod, int codser, int codtec, int codarea)
           : base(cod)
       {

           this.Fecha = fecha;
           this.Codpla = cod;
           this.Codser = codser;
           this.Codtec = codtec;
           this.Codarea = codarea;
       }
       */
       public Periodicidad(string fecha, int cod, int codser, int codtec)
           : base(cod)
       {

           this.Fecha = fecha;
           this.Codpla = cod;
           this.Codser = codser;
           this.Codtec = codtec;

       }
       //getcodfech


       public Periodicidad(int codi, string fecha, int codpla)
           : base(codpla)
       {
           this.Codperi = codi;
           this.Fecha = fecha;
           this.Codpla = codpla;
         

       }
       /**
   public Periodicidad(int codi, string fecha, int codpla,int codser,int codtec)
           : base(codpla)
       {
           this.Codperi = codi;
           this.Fecha = fecha;
           this.Codpla = codpla;


       }
        */
           public Periodicidad(int cod)
           :base(cod)
       {
           
           
           this.Codpla = cod;


       }

           public Periodicidad(int cod, string estado, string oti)
               : base(cod)
           {


               this.Estado = estado;


           }



           public Periodicidad(int codi, string fecha, int codpla, int codser, int condtec)
           : base(codpla)
       {
           this.Codperi = codi;
           this.Fecha = fecha;
           this.Codpla = codpla;
           this.Codser = codser;
           this.Codtec = codtec;

       }
       public int Codperi
       {
           get { return codi; }
           set { codi=value; }
       
       }

       public string Fecha
       {
           get { return fecha;}
           set { fecha= value; }
       }
       public int Codpla
       {
           get { return cod; }
           set { cod = value; }
       
       }
      
       public int Codser 
       {
           get { return codser; }
           set { codser = value; }
       }
       public int Codtec
       {
           get { return codtec; }
           set { codtec = value; }
       }
       public int Codarea
       {
           get { return codarea; }
           set { codarea = value; }
       
       }
       public string Oti
       {
           get { return oti; }
           set { oti = value; }
       }

       public int Consumo 
       {
           get { return consumo; }
           set { consumo = value; }
       
       }

       public string Tperiodicidad
       {
           get { return tperiodicidad; }
           set { tperiodicidad = value; }

       }

       public string Estado
       {
           get { return estado; }
           set { estado = value; }
       }
       public string Observaciones
       {
           get { return observaciones; }
           set { observaciones = value; }
       }
    }
}
