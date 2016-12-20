using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessRules
{
    public class cliente
    {
       
        string nombre;
        string rut;
        string clasificacion;
        string ltratamiento;
        int cod;
    
/*
        public cliente(int cod,string nombre, string rut , string clasificacion, string ltratamiento)
        {
            this.Cod = cod;
            this.Nombre = nombre;
            this.Rut = rut;
          
            this.Clasificacion = clasificacion;
            this.LTratamiento = ltratamiento;
           



        }
*/
        public cliente(int cod, string nombre, string rut, string clasificacion, string ltratamiento)
        {
            this.Cod = cod;
            this.Nombre = nombre;
            this.Rut = rut;

            this.Clasificacion = clasificacion;
            this.LTratamiento = ltratamiento;
       



        }


        public cliente(int cod,string nombre, string rut, string clasificacion)
        {
            this.Cod = cod;
            this.Nombre = nombre;
            this.Rut = rut;


            this.Clasificacion = clasificacion;
          



        }
        public cliente(string nombre, string rut, string clasificacion, string ltratamiento)
        {
            this.Cod = cod;
            this.Nombre = nombre;
            this.Rut = rut;
           
            
            this.Clasificacion = clasificacion;
            this.LTratamiento = ltratamiento;
           
         

        }



        
        public cliente(string rut,string nombre, int cod)
        {
            this.Rut = rut;
            this.Nombre = nombre;
            this.Cod = cod;
        }

        public cliente(int cod, string rut, string ltratamiento) {

            this.Cod = cod;
            this.Rut = rut;
            this.LTratamiento = ltratamiento;
           
        
        }
        public cliente(string nombre,string rut )
        {
        
            this.Nombre = nombre;
            this.Rut = rut;
        }

        public cliente(int cod,string rut)
        {
            this.Cod = cod;
            this.Rut = rut;
           

        }

      //  public cliente(int cod, string nombre)
       // {
       //     this.Cod = cod;
       //     this.Nombre = nombre;


        //}

        public cliente(string nombre)
        {

            this.Nombre = nombre;

        }

        public cliente(int cod)
        {

            this.Cod =cod;

        }






         public int Cod
        {

            get { return cod; }
            set { cod = value; }
        }
      

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Rut
        {

            get { return rut; }
            set { rut = value; }

        }

        public string Clasificacion
        {
            get { return clasificacion; }
            set { clasificacion = value; }

        }

        public string LTratamiento
        {

            get { return ltratamiento; }
            set { ltratamiento = value; }


        }


        
    }
}

