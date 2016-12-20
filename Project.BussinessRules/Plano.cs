using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessRules
{
  public  class Plano:LugarTratamiento
    {
       string planocod;
      int codNT;
      string lugartratamiento;
      int contador;
     
      //el puro codnt wn
     

  

  public Plano(int codNT,string planocod,int cod,string lugartratamiento)
        :base(cod,lugartratamiento)
  {

      this.COD = codNT;
      this.Planocod = planocod;
  
  }

  public Plano(int codNT, string planocod)
      : base(codNT, planocod)
  {

      this.COD = codNT;
      this.Planocod = planocod;

  }

  public Plano(string planocod, int codNT, int contador) 
       :base(codNT)
  {
      this.Planocod=planocod;
      this.CODNT =codNT;
      this.Contador = contador;
  
  }

  public Plano(string planocod, int codNT)
      : base(codNT)
  {
      this.Planocod = planocod;
      this.CODNT = codNT;
    

  }

      

      public string Planocod {

          get { return planocod; }
          set { planocod = value; }
      
      }
      public int CODNT
      {
          get { return codNT; }
          set { codNT = value; }
      }

  
    public  string LUGARtratamiento
      {

          get { return lugartratamiento; }
          set { lugartratamiento = value; }

      }

    public int Contador
    
    {
        get { return contador; }
        set { contador = value; }
    
    
    }
    }
}
