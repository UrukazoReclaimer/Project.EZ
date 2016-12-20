using Project.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessRules
{
    public  class CatalogoServicios
    {
        public void addServicio(servicio ac)
        {
            try
            {
                DataAccess.DataBase bd = new DataAccess.DataBase();
                bd.connect();
                string sql = "insert into servicio values('" + ac.Cod + "','" + ac.Nombre +"','"+ac.Sigla+ "')";
                bd.CreateCommand(sql);
                bd.execute();
                bd.close();
            }
            catch (DataAccess.DataAccessException ex)
            {
                throw new BussinessRulesException(ex.Message);
            }
        }



        public List<servicio> getser()
        {

            DataAccess.DataBase bd = new DataAccess.DataBase();
            bd.connect();
            List<servicio> units = new List<servicio>();
            string sql = "select * from servicio";
            bd.CreateCommand(sql);

            DbDataReader result = bd.Query();

            while (result.Read())
            {
                servicio u = new servicio(int.Parse(result.GetString(0)), result.GetString(1),result.GetString(2));
                units.Add(u);

            }
            result.Close();
            bd.close();
            return units;

        }

        public List<servicio> getCodSer(string fecha, string codplanilla, string sigla)
        {

            DataAccess.DataBase bd = new DataAccess.DataBase();
            bd.connect();
            List<servicio> units = new List<servicio>();
            string sql = "select servicio.cod from servicio, periodicidad where  periodicidad.Fecha='" + fecha + "' and periodicidad.Planilla_Cod='" + codplanilla + "' and servicio.Sigla='" + sigla + "';";
            bd.CreateCommand(sql);

            DbDataReader result = bd.Query();

            while (result.Read())
            {
                 servicio u = new servicio(int.Parse(result.GetString(0)));
                units.Add(u);

            }
            result.Close();
            bd.close();
            return units;

        }




        public void removeServico(string nom)
        {

            DataAccess.DataBase db = new DataAccess.DataBase();

            db.connect();

            string sql = "delete from servicio WHERE nombre ='" + nom + "'";

            db.CreateCommand(sql);

            db.execute();

            db.close();



        }

        public List<servicio> mostrarservicio(string s)
        {
            try
            {
                DataBase db = new DataBase();
                db.connect();
                string sql = "select servicio.Cod, servicio.Nombre, servicio.Sigla from servicio";
                db.CreateCommand(sql);
                List<servicio> tec = new List<servicio>();
                DbDataReader result = db.Query();

                while (result.Read())
                {

                    int cod = result.GetInt32(0);
                    string nom = result.GetString(1);
                    string sig = result.GetString(2);
                    
                    servicio a = new servicio(cod,nom,sig);
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


        public List<servicio> bmostrarservicio(string s)
        {
            try
            {
                DataBase db = new DataBase();
                db.connect();

                string sql = "select servicio.Cod, servicio.Nombre, servicio.Sigla from servicio where servicio.nombre like '%"+s+"%'";
                db.CreateCommand(sql);
                List<servicio> tec = new List<servicio>();
                DbDataReader result = db.Query();

                while (result.Read())
                {

                    int cod = result.GetInt32(0);
                    string nom = result.GetString(1);
                    string sig = result.GetString(2);
                    
                    servicio a = new servicio(cod,nom,sig);
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
