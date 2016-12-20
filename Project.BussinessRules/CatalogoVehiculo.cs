using Project.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessRules
{
   public class CatalogoVehiculo
    {

       public void addvehiculo(vehiculo ac)
       {
           try
           {
               DataAccess.DataBase bd = new DataAccess.DataBase();
               bd.connect();
               string sql = "insert into vehiculos values('" + ac.Patente + "','" + ac.Descripcion + "');";
               bd.CreateCommand(sql);
               bd.execute();
               bd.close();
           }
           catch (DataAccess.DataAccessException ex)
           {
               throw new BussinessRulesException(ex.Message);
           }
       }
       public void removeVehiculo(string patente)
       {

           DataAccess.DataBase db = new DataAccess.DataBase();

           db.connect();

           string sql = "delete from vehiculos WHERE patente ='" + patente + "'";

           db.CreateCommand(sql);

           db.execute();

           db.close();



       }

       public List<vehiculo> mostrarvehiculo(string s)
       {
           try
           {
               DataBase db = new DataBase();
               db.connect();

               string sql = "select * from vehiculos";
               db.CreateCommand(sql);
               List<vehiculo> tec = new List<vehiculo>();
               DbDataReader result = db.Query();

               while (result.Read())
               {

                   string patente = result.GetString(0);
                   string descripcion = result.GetString(1);
                  

                   vehiculo a = new vehiculo(patente,descripcion);
                   tec.Add(a);
               }

               result.Close();
               db.close();
               return tec;
           }
           catch (DataAccess.DataAccessException ex)
           {
               throw new BussinessRulesException(ex.Message, ex.InnerException);
           }
           catch (Exception ex)
           {
               throw new BussinessRulesException(ex.Message);
           }
       }

       public List<vehiculo> getvehiculocod()
       {

           DataAccess.DataBase bd = new DataBase();
           bd.connect();
           List<vehiculo> units = new List<vehiculo>();
           string sql = "select * from vehiculos";
           bd.CreateCommand(sql);

           DbDataReader result = bd.Query();

           while (result.Read())
           {
               vehiculo u = new vehiculo(result.GetString(0), result.GetString(1));
               units.Add(u);

           }
           result.Close();
           bd.close();
           return units;

       }


       public List<vehiculo> buscarVehiculo(string s)
       {
           try
           {
               DataBase db = new DataBase();
               db.connect();

               string sql = "select * from vehiculos where patente= '" + s + "';";
               db.CreateCommand(sql);
               List<vehiculo> tec = new List<vehiculo>();
               DbDataReader result = db.Query();

               while (result.Read())
               {

                   string patente = result.GetString(0);
                   string descripcion = result.GetString(1);


                   vehiculo a = new vehiculo(patente, descripcion);
                   tec.Add(a);
               }

               result.Close();
               db.close();
               return tec;
           }
           catch (DataAccess.DataAccessException ex)
           {
               throw new BussinessRulesException(ex.Message, ex.InnerException);
           }
           catch (Exception ex)
           {
               throw new BussinessRulesException(ex.Message);
           }
       }
    }
}
