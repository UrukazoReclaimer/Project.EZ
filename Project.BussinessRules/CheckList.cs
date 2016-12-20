using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessRules
{
  public  class CheckList
    {
      
          string ser;
          string lugartratamiento;
        string area;
       DateTime fecha;
       string numero;
       string noti;
       string certi;
       string plano;
       string planocliente;
       string doc;


      /*
            public CheckList(DateTime fecha,string numero, string lugartratamiento,string ser, string noti, string certi, string plano)
       {
           this.Fecha = fecha;
           this.Numero = numero;
           this.Lugardetratamiento = lugartratamiento;
           this.Ser = ser;
           this.Noti = noti;
           this.Certificado = certi;
           this.Plano = plano;
           this.PlanoCliente = planocliente;

        
           
         

       }
       */
            public CheckList(DateTime fecha, string numero, string lugartratamiento, string ser, string oti, string plano, string doc)
            {
                this.Fecha = fecha;
                this.Numero = numero;
                this.Lugardetratamiento = lugartratamiento;
                this.Ser = ser;
                this.Plano = plano;
                this.Noti=oti;
                this.Doc = doc;



            }

          


            public DateTime Fecha 
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
           get { return doc ; }
           set { doc = value; }

       }

     
    }
}
