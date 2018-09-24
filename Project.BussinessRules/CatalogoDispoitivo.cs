using Project.DataAccess;

using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessRules
{
  public  class CatalogoDispoitivo
    {
      public void addDispositivo(int cod, string nombre,int numero, int x,int y, string codPLano,int consumo)
      {
          try
          {
              DataAccess.DataBase bd = new DataAccess.DataBase();
              bd.connect();
              string sql = "insert into dispositivo values('" + cod + "','" + nombre + "','" + numero + "','" + x + "','" + y + "','" + codPLano + "','" + consumo + "')";
            //  string sql ="insert into dispositivo SET Cod='" + cod + "',Nombre='" + nombre + "',XY='" + xy + "',PlanoEditor_Cod'" + codPLano + "';";
           //   string sql = "update periodicidad set Estado='" + ac.Estado + "'where cod='" + ac.Codperi + "';";
                
              bd.CreateCommand(sql);
              bd.execute();
              bd.close();
          }
          catch (DataAccess.DataAccessException ex)
          {
              throw new BussinessRulesException(ex.Message);
          }
      }
      public void addConsumo(int consumo, int cod)
      {


          try
          {

              DataAccess.DataBase db = new DataBase();
              db.connect();
              string sql = "update dispositivo set consumo='" + consumo + "'where cod='" + cod + "';";

              db.CreateCommand(sql);

              db.execute();
              db.close();
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
      public void modificacionNumero(int Numero, int cod)
      {


          try
          {

              DataAccess.DataBase db = new DataBase();
              db.connect();
              string sql = "update dispositivo set Numero='" +Numero + "'where cod='" + cod + "';";

              db.CreateCommand(sql);

              db.execute();
              db.close();
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

      public List<Dispositivo> mostrarplanilla(string s)
      {
          try
          {
              DataBase db = new DataBase();
              db.connect();


              String sql = "select *  from dispositivo where PlanoEditor_Cod='"+s+"'";

              db.CreateCommand(sql);
              List<Dispositivo> tec = new List<Dispositivo>();
              DbDataReader result = db.Query();

              while (result.Read())
              {
                  int codt = result.GetInt32(0);
                  string nombre = result.GetString(1);
                  int numero = result.GetInt32(2);
                  int x = result.GetInt32(3);
                  int y = result.GetInt32(4);
                  string planocod = result.GetString(5);
                  int consumo = result.GetInt32(6);

                 Dispositivo a = new Dispositivo(codt,nombre,numero,x,y,planocod,consumo);
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
      public void eliminarDispositivo(string cod)
      {

          DataAccess.DataBase db = new DataAccess.DataBase();

          db.connect();

          string sql = "delete from dispositivo WHERE cod='" + cod + "'";

          db.CreateCommand(sql);

          db.execute();

          db.close();



      }


      public List<Dispositivo> mostrarDipositivoTipoNumero(string tipo, string num,string code)
      {
          try
          {
              DataBase db = new DataBase();
              db.connect();


              String sql = "select *  from dispositivo where Nombre='" + tipo + "' and Numero='"+num+"' and PlanoEditor_Cod='"+code+"' group by Cod;";

              db.CreateCommand(sql);
              List<Dispositivo> tec = new List<Dispositivo>();
              DbDataReader result = db.Query();

              while (result.Read())
              {
                  int codt = result.GetInt32(0);
                  string nombre = result.GetString(1);
                  int numero = result.GetInt32(2);
                  int x = result.GetInt32(3);
                  int y = result.GetInt32(4);
                  string planocod = result.GetString(5);
                  int consumo = result.GetInt32(6);

                  Dispositivo a = new Dispositivo(codt, nombre, numero, x, y, planocod, consumo);
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
