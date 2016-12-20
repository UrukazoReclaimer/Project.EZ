using Project.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessRules
{
   public class CatalogoArea
    {
       /*
        * Agrega un area a la tabla Area
        * 
        * */
        public void addArea(Area ac)
        {
            try
            {
                DataAccess.DataBase bd = new DataAccess.DataBase();
                bd.connect();
                string sql = "insert into area values('" + ac.Cod + "','" + ac.NombreArea + "')";
                bd.CreateCommand(sql);
                bd.execute();
                bd.close();
            }
            catch (DataAccess.DataAccessException ex)
            {
                throw new BussinessRulesException(ex.Message);
            }
        }

        /*
         * Obtiene el codigo y el nombre de los elementos de la tabla area y los guarda en una lista
         * 
         * */

        public List<Area> getarea()
        {

            DataAccess.DataBase bd = new DataAccess.DataBase();
            bd.connect();
            List<Area> units = new List<Area>();
            string sql = "select * from area";
            bd.CreateCommand(sql);

            DbDataReader result = bd.Query();

            while (result.Read())
            {
                Area u = new Area(int.Parse(result.GetString(0)), result.GetString(1));
                units.Add(u);

            }
            result.Close();
            bd.close();
            return units;

        }
        public List<Area> getcodarea(string planilla, string periodicidad)
        {

            DataAccess.DataBase bd = new DataAccess.DataBase();
            bd.connect();
            List<Area> units = new List<Area>();
            string sql = "select distinct area.Cod from area inner join periodicidad, planilla where periodicidad.Planilla_Cod='"+planilla+"' and periodicidad.Fecha='"+periodicidad+"' and periodicidad.Planilla_Cod=planilla.Cod and area.cod=periodicidad.Area_Cod;";
            bd.CreateCommand(sql);

            DbDataReader result = bd.Query();

            while (result.Read())
            {
                Area u = new Area(int.Parse(result.GetString(0)), result.GetString(1));
                units.Add(u);

            }
            result.Close();
            bd.close();
            return units;

        }


        /*
         * Elimina en elemento en la tabla Area
         * 
         * */
        public void removeArea(string nom)
        {

            DataAccess.DataBase db = new DataAccess.DataBase();

            db.connect();

            string sql = "delete from area WHERE nombrearea ='" + nom + "'";

            db.CreateCommand(sql);

            db.execute();

            db.close();



        }
        public List<Area> mostrarArea(string s)
        {
            try
            {
                DataBase db = new DataBase();
                db.connect();
                string sql = "select * from area";
                db.CreateCommand(sql);
                List<Area> tec = new List<Area>();
                DbDataReader result = db.Query();

                while (result.Read())
                {

                    int cod = result.GetInt32(0);
                    string nom = result.GetString(1);
              

                    Area a = new Area(cod, nom);
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
