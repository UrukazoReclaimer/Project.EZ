using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.BussinessRules;
using System.Data.Common;
using Project.DataAccess;

namespace Project.BussinessRules
{
 public class catalogoTecnico
    {

         public void addTecnico(Tecnico ac)
        {
            try
            {
                DataBase bd = new DataBase();
                bd.connect();
                string sql = "insert into tecnicos values('"+ac.Cod+"','"+ac.Rut+"','"+ac.Nombre+"','"+ac.Estado+"')";
                bd.CreateCommand(sql);
                bd.execute();
                bd.close();
            }
            catch (DataAccess.DataAccessException ex)
            {
                throw new BussinessRulesException(ex.Message);
            }
        }


         public List<Tecnico> gettec()
         {

            DataBase bd = new DataBase();
             bd.connect();
             List<Tecnico> units = new List<Tecnico>();
             string sql = "select * from tecnicos where tecnicos.Estado='Activo'";
             bd.CreateCommand(sql);

             DbDataReader result = bd.Query();

             while (result.Read())
             {
                 Tecnico u = new Tecnico(int.Parse(result.GetString(0)), result.GetString(2));
                 units.Add(u);

             }
             result.Close();
             bd.close();
             return units;
            
         }



         public void removeTecnico(string rut)
         {

             DataBase db = new DataBase();

             db.connect();

             string sql = "delete from tecnicos WHERE RUT ='" + rut + "'";

             db.CreateCommand(sql);

             db.execute();

             db.close();



         }


         public void modiTec(Tecnico ad)
         {


             try
             {

                 DataBase db = new DataBase();
                 db.connect();
                 string sql = "update tecnicos set cod='" + ad.Cod + "',rut='" + ad.Rut + "',nombre='" + ad.Nombre + "',estado='" + ad.Estado + "'where cod='" + ad.Cod + "';";

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

             
        public List<Tecnico> mostrarTec(string s)
        {
            try
            {
                DataBase db = new DataBase();
                db.connect();

                string sql = "select * from tecnicos";

                db.CreateCommand(sql);
                List<Tecnico> tec = new List<Tecnico>();
                DbDataReader result = db.Query();



                while (result.Read())
                {
                    
                    int cod = result.GetInt32(0);   
                    string rut = result.GetString(1);
                    string nombre = result.GetString(2);
                    string estado = result.GetString(3);
                    
                    
                    Tecnico  a= new Tecnico(cod,rut,nombre,estado);
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
    

