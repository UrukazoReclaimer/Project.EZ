using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessRules
{
 public   class Dispositivo
    {
     int cod;
     string nombre;
     int numero;
     int x;
     int y;
     string planocod;
     int consumo;


     public Dispositivo(int cod, string nombre, int numero, int x, int y, string planocod,int consumo) 
     {
         this.Cod = cod;
         this.Nombre = nombre;
         this.Numero = numero;
         this.X = x;
         this.Y = y;
         this.PlanoCod = planocod;
         this.Consumo=consumo;
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
     public int Numero
     {

         get { return numero; }
         set { numero = value; }
     }
     public int X
     {

         get { return x; }
         set { x = value; }
     }
     public int Y
     {

         get { return y; }
         set { y = value; }
     }
     public string PlanoCod
     {

         get { return planocod; }
         set { planocod = value; }
     }
      public int Consumo
     {

         get { return consumo; }
         set { consumo = value; }
     }

    }
}
