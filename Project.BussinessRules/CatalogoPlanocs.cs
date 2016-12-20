using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessRules
{
  public  class CatalogoPlanocs
    {

      public void addplano(Plano ac)
      {
          try
          {
              DataAccess.DataBase bd = new DataAccess.DataBase();
              bd.connect();
              string sql = "insert into plano values('"+ac.Planocod+"','" + ac.CODNT+"','"+ac.Contador+"')";
              bd.CreateCommand(sql);
              bd.execute();
              bd.close();
          }
          catch (DataAccess.DataAccessException ex)
          {
              throw new BussinessRulesException(ex.Message);
          }
      }

    }
}
