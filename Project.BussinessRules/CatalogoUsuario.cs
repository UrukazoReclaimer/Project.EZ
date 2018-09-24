using Project.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessRules
{
   public class CatalogoUsuario
    {
        
        public void addusuario(string nom, string contraseña, string niv)
        {
            try
            {
                DataAccess.DataBase bd = new DataAccess.DataBase();
                bd.connect();
                string sql = "insertar";
                bd.CreateCommandPA(sql);
                bd.createParameter("@nom",System.Data.DbType.String,nom);
                bd.createParameter("@contra", System.Data.DbType.String, contraseña);
                bd.createParameter("@niv", System.Data.DbType.String, niv);
                bd.execute();
                bd.close();
            }
            catch (DataAccess.DataAccessException ex)
            {
                throw new BussinessRulesException(ex.Message);
            } DataAccess.DataBase cmd = new DataBase();


           
        }
        public List<Usuario> COMusuario(string nom, string contraseña)
        {
            DataAccess.DataBase bd = new DataBase();
            bd.connect();
            List<Usuario> units = new List<Usuario>();
            string sql = "select usuario.COD from  usuario where usuario.Nombre='" + nom + "' and usuario.Contraseña='" + contraseña + "';";
            bd.CreateCommand(sql);

            DbDataReader result = bd.Query();

            while (result.Read())
            {
                Usuario u = new Usuario(result.GetInt32(0));
                units.Add(u);

            }
            result.Close();
            bd.close();
            return units;



        }
        public List<Usuario> COMnivel(string nom, string contraseña)
        {
            DataAccess.DataBase bd = new DataBase();
            bd.connect();
            List<Usuario> units = new List<Usuario>();
            string sql = "select usuario.Nivel from  usuario where usuario.Nombre='" + nom + "' and usuario.Contraseña='" + contraseña + "';";
            bd.CreateCommand(sql);

            DbDataReader result = bd.Query();

            while (result.Read())
            {
                Usuario u = new Usuario(result.GetString(0));
                units.Add(u);

            }
            result.Close();
            bd.close();
            return units;



        }
        public List<Usuario> mostrarUsuario()
        {
            try
            {
                DataBase db = new DataBase();
                db.connect();
                String sql = "select usuario.cod, usuario.nombre, usuario.contraseña, usuario.nivel from usuario";
                db.CreateCommand(sql);
                List<Usuario> tec = new List<Usuario>();
                DbDataReader result = db.Query();

                while (result.Read())
                {
                    int cod = result.GetInt32(0);
                    string nom = result.GetString(1);
                    string contra = result.GetString(2);
                    string niv = result.GetString(3);
                   

                    Usuario a = new Usuario(cod, nom, contra, niv);
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

        public void modUsuario(Usuario ac)
        {

            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();
                string sql = "update Usuario set Contraseña='" + ac.CONTRASEÑA +"'where cod='" + ac.COD + "';";

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

        public void modUsuarioNivel(Usuario ac)
        {

            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();
                string sql = "update Usuario set Nivel='" + ac.Nivel + "'where cod='" + ac.COD + "';";

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
    }
}
