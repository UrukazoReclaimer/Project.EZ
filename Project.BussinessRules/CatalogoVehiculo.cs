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
                string sql = "insert into vehiculos values('" + ac.Patente + "','" + ac.Descripcion + "','" + ac.Fecha + "','" + ac.KM + "','"+ac.Extintores+"');";
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
                    string fecha = result.GetString(2);
                    int km = result.GetInt32(3);
                    string extin = result.GetString(4);

                    vehiculo a = new vehiculo(patente, descripcion,fecha,km,extin);
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
        public List<vehiculo> mostrarvehiculoRevTec(string s)
        {
            try
            {
                DataBase db = new DataBase();
                db.connect();

                string sql = "select * from vehiculos where Fecha between curdate()-interval 12 month and curdate() + interval 2 month;";
                db.CreateCommand(sql);
                List<vehiculo> tec = new List<vehiculo>();
                DbDataReader result = db.Query();

                while (result.Read())
                {

                    string patente = result.GetString(0);
                    string descripcion = result.GetString(1);
                    string fecha = result.GetString(2);
                    int km = result.GetInt32(3);
                    string extin = result.GetString(4);

                    vehiculo a = new vehiculo(patente, descripcion, fecha, km, extin);
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
        public List<vehiculo> mostrarvehiculoExtintores(string s)
        {
            try
            {
                DataBase db = new DataBase();
                db.connect();

                string sql = "select * from vehiculos where Extintores between curdate()-interval 12 month and curdate() + interval 2 month;";
                db.CreateCommand(sql);
                List<vehiculo> tec = new List<vehiculo>();
                DbDataReader result = db.Query();

                while (result.Read())
                {

                    string patente = result.GetString(0);
                    string descripcion = result.GetString(1);
                    string fecha = result.GetString(2);
                    int km = result.GetInt32(3);
                    string extin = result.GetString(4);

                    vehiculo a = new vehiculo(patente, descripcion, fecha, km, extin);
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
        public List<vehiculo> obtenerVehiculocod()
        {

            DataAccess.DataBase bd = new DataBase();
            bd.connect();
            List<vehiculo> units = new List<vehiculo>();
            string sql = "select * from vehiculos";
            bd.CreateCommand(sql);

            DbDataReader result = bd.Query();

            while (result.Read())
            {
                vehiculo u = new vehiculo(result.GetString(0), result.GetString(1),result.GetString(2),result.GetInt32(3),result.GetString(4));
                units.Add(u);

            }
            result.Close();
            bd.close();
            return units;

        }
        public void modVehiculo(vehiculo ve)
        {

            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();
                string sql = "update Vehiculos set Descripcion='" + ve.Descripcion +"',Fecha='"+ve.Fecha+"',KM='"+ve.KM+"',Extintores='"+ve.Extintores+"' where Patente='" + ve.Patente + "';";

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
                    string fecha = result.GetString(2);
                    int km = result.GetInt32(3);
                    string extin = result.GetString(4);
                    vehiculo a = new vehiculo(patente, descripcion, fecha, km,extin);
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
