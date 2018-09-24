using Project.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessRules
{
    public class CatalogoPlanocs
    {

        public int getNumero(string tipo,string numero)
        {
            int aux = 0;
            DataBase bd = new DataBase();
            bd.connect();
            List<Periodicidad> units = new List<Periodicidad>();
            string sql = "select count(nombre) from dispositivo where nombre='" + tipo + "' and PlanoEditor_Cod='"+numero+"';";
            bd.CreateCommand(sql);

            DbDataReader result = bd.Query();

            while (result.Read())
            {
                Periodicidad u = new Periodicidad(result.GetInt32(0));
                aux = result.GetInt32(0);
                units.Add(u);


            }
            result.Close();
            bd.close();
            return aux;

        }
        public int getCODPLANOO(string numero)
        {
            int aux = 0;
            DataBase bd = new DataBase();
            bd.connect();
            List<Periodicidad> units = new List<Periodicidad>();
            string sql = "select cod from planoeditor where numero='"+numero+"';";
            bd.CreateCommand(sql);

            DbDataReader result = bd.Query();

            while (result.Read())
            {
                Periodicidad u = new Periodicidad(result.GetInt32(0));
                aux = result.GetInt32(0);
                units.Add(u);


            }
            result.Close();
            bd.close();
            return aux;

        }
        public void addplano(Plano ac)
        {
            try
            {
                DataAccess.DataBase bd = new DataAccess.DataBase();
                bd.connect();
                string sql = "insert into plano values('" + ac.Planocod + "','" + ac.CODNT + "','" + ac.Contador + "')";
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
