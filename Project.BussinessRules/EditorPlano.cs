using Project.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessRules
{
    public class EditorPlano
    {
        public void addPlano(string titulo,string numero,string coord,string clientecod, string clienterut)
        {
            try
            {
                DataAccess.DataBase bd = new DataAccess.DataBase();
                bd.connect();
                string sql = "insert into PlanoEditor values('"+0+"','" + titulo + "','"+numero+"','" + coord + "','" + clientecod + "','"+clienterut+"')";
               bd.CreateCommand(sql);
                bd.execute();
                bd.close();
            }
            catch (DataAccess.DataAccessException ex)
            {
                throw new BussinessRulesException(ex.Message);
            }
        }
        public List<Dispositivo> mostrarDatosPlano(string num)
        {
            try
            {
                DataBase db = new DataBase();
                db.connect();


                String sql = "select *  from EditorPlano where Numera='" + num + "' group by Cod;";

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
