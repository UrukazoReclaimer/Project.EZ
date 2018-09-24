using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessRules
{
 public   class Usuario
    {
     int cod;
     string nombre;
     string contraseña;
     string nivel;


     public Usuario(int cod, string nombre, string contraseña) 
     {
         this.COD = cod;
         this.NOMBRE = nombre;
         this.CONTRASEÑA = contraseña;
     
     }
     public Usuario(int cod)
     {
         this.COD = cod;
        

     }

     public Usuario(int cod, string nombre, string contraseña, string nivel)
     {
         this.COD = cod;
         this.NOMBRE = nombre;
         this.CONTRASEÑA = contraseña;
         this.Nivel = nivel;
     }
     public Usuario(string nivel)
     {
         this.Nivel = nivel;


     }


     public int COD
     {
         get { return cod; }
         set { cod = value; }
     }

     public string NOMBRE
     {
         get { return nombre; }
         set { nombre = value; }
     }
     public string CONTRASEÑA
     {
         get { return contraseña; }
         set { contraseña = value; }
     }

     public string Nivel
     {
         get { return nivel; }
         set { nivel = value; }
     }


    }
}
