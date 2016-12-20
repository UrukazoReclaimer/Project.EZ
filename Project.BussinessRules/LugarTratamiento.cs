using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessRules
{
   public class LugarTratamiento:cliente
    {
       int codnt;
       string nombreTrata;
       int cod;
       string rut;
       string nombrecontacto;
       string ruta;
       string tipo;
    

      //tengo que saber que xuxa le paso a esta wea XD


      // public LugarTratamiento(string nombre,string rut,string clasificacion,string ltratamiento) 
      //      :base(nombre,rut,clasificacion,ltratamiento) {   
      //     this.nombreTratamiento = nombre; 
      // }
       //cliente
       public LugarTratamiento(string nombre, string rut, string clasificacion, string ltratamiento,int cod)
           : base(cod, nombre, rut, clasificacion, ltratamiento)
       {
         
         
           this.COD = cod;
           this.Nombre = Nombre;
           this.RUT = rut;
           this.NombreTrata = ltratamiento;
          
       }

       public LugarTratamiento(int codnt,string nombre, string rut, string clasificacion, string ltratamiento, int cod)
           : base(cod, nombre, rut, clasificacion, ltratamiento)
       {
           this.CODNT = codnt;
           this.COD = cod;
           this.Nombre = nombre;
           this.RUT = rut;
          
           this.NombreTrata = ltratamiento;


       }

//ahita el problema nombre cambiarlo a rut
       public LugarTratamiento(string nombre, string rut, string clasificacion, string ltratamiento, string telefono, string email, string tipo)
           : base(nombre,rut, clasificacion, ltratamiento)
       {
           this.CODNT = codnt;
           this.COD = cod;    
           this.NombreTrata = LTratamiento;
           this.RUT = rut;
        
         
       }

       //este es usado ltratamiento
       public LugarTratamiento(int cod, string rut,string ltratamiento,string ruta,string tipo)
           : base(cod,rut,ltratamiento)
       {
           this.COD = cod;
       
           this.RUT = rut;

           this.NombreTrata = ltratamiento;

           this.Ruta = ruta;
           this.TIPO = tipo;
         
         
           
       }
       public LugarTratamiento(string ltratamiento, string ruta, int codnt)
           : base(ltratamiento,ruta,codnt)
       {
           this.CODNT = codnt;


           this.NombreTrata = ltratamiento;

           this.Ruta = ruta;

       }


/*
       public LugarTratamiento(int cod, string rut,string ltratamiento)
           : base(cod,rut,ltratamiento)
       {

           this.COD = cod;
           this.RUT = rut;
           this.NombreTrata = ltratamiento;

       }
*/
//modificado el base
       public LugarTratamiento(string ltratamiento, string rut)
           : base(ltratamiento,rut )
       {

     
           this.RUT = rut;
           this.NombreTrata = ltratamiento;

       }

       public LugarTratamiento(int cod,string ltratamiento)
           : base(cod, ltratamiento)
       {

           this.COD = cod;
           this.NombreTrata = ltratamiento;
           

       }

    

       public LugarTratamiento(string rut)
           : base(rut)
       {

         
           this.RUT = rut;

       }
//para plano
       public LugarTratamiento(int codnt)
        :base(codnt)
       {
           this.CODNT = codnt;
       }   

       

       public int CODNT
       {
           get { return codnt; }
           set { codnt = value; }
       }

      

       public int COD
       {

           get { return cod; }
           set { cod = value; }

       }
     
       public string RUT
       {
           get { return rut; }
           set { rut = value; }
       }

       public string NombreTrata
       {
           get { return nombreTrata; }
           set { nombreTrata = value; }

       }

       public string Ruta
       {
           get { return ruta; }
           set { ruta = value; }
       }

       public string TIPO
       {
           get { return tipo; }
           set { tipo = value; }
       
       
       }


    }
}
