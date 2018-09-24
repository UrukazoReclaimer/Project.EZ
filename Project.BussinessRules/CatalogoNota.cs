using Project.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessRules
{
    public class CatalogoNota
    {

        public void addNota(Nota ac)
        {
            try
            {
                DataAccess.DataBase bd = new DataAccess.DataBase();
                bd.connect();            
                string sql = "insert into nota values('" + ac.COD + "','" + ac.CONTENIDO + "','" + ac.RESPONSABLE + "');";
                bd.CreateCommand(sql);
                bd.execute();
                bd.close();
            }
            catch (DataAccess.DataAccessException ex)
            {
                throw new BussinessRulesException(ex.Message);
            }
        }


        public void addNotaTemp(Nota ac)
        {
            try
            {
                DataAccess.DataBase bd = new DataAccess.DataBase();
                bd.connect();              
                string sql = "insert into nota values('" + ac.COD + "','" + ac.CONTENIDO + "','" + ac.RESPONSABLE + "');";
                bd.CreateCommand(sql);
                bd.execute();
                bd.close();
            }
            catch (DataAccess.DataAccessException ex)
            {
                throw new BussinessRulesException(ex.Message);
            }
        }

        public List<Nota> mostrarContenido(string ac)
        {

            DataAccess.DataBase bd = new DataBase();
            bd.connect();
            List<Nota> units = new List<Nota>();
            string sql = "select nota.Contenido from nota,periodicidad where periodicidad_Cod=nota.periodicidad_Cod and periodicidad_Cod= '"+ac+"' group by Contenido;";
            bd.CreateCommand(sql);

            DbDataReader result = bd.Query();

            while (result.Read())
            {
                Nota u = new Nota(result.GetString(0));
                units.Add(u);

            }
            result.Close();
            bd.close();
            return units;

        }

    }
}
