using Project.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessRules
{
    public class CatalogoPermiso
    {
        public void addmotivo(Permiso ac)
        {
            try
            {
                DataAccess.DataBase bd = new DataAccess.DataBase();
                bd.connect();
                string sql = "insert into permiso values('" + ac.Cod + "','" + ac.Motivo + "');";
                bd.CreateCommand(sql);
                bd.execute();
                bd.close();
            }
            catch (DataAccess.DataAccessException ex)
            {
                throw new BussinessRulesException(ex.Message);
            }
        }





        public List<Permiso> mostrarPermiso()
        {
            try
            {
                DataBase db = new DataBase();
                db.connect();
                string sql = "select * from permiso";
                db.CreateCommand(sql);
                List<Permiso> tec = new List<Permiso>();
                DbDataReader result = db.Query();

                while (result.Read())
                {

                    int cod = result.GetInt32(0);
                    string nom = result.GetString(1);


                    Permiso a = new Permiso(cod, nom);
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
