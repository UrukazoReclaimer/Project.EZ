using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.BussinessRules;
using Project.DataAccess;
using System.Data.Common;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;


namespace Project.BussinessRules
{
    public class CatalogoPlanilla
    {




        public void addplanilla(Planilla ac)
        {
            try
            {
                DataAccess.DataBase bd = new DataAccess.DataBase();
                bd.connect();
                string sql = "insert into planilla values('" + ac.Cod + "','" + ac.CliRut + "','" + ac.Cod + "','" + ac.Descripcion + "','" + ac.Clicod + "','" + ac.LugarCod + "')";
                bd.CreateCommand(sql);
                bd.execute();
                bd.close();
            }
            catch (DataAccess.DataAccessException ex)
            {
                throw new BussinessRulesException(ex.Message);
            }
        }

        public void idioma()
        {
            try
            {
                DataAccess.DataBase bd = new DataAccess.DataBase();
                bd.connect();
                string sql = "SET lc_time_names = 'es_CL';";
                bd.CreateCommand(sql);
                bd.execute();
                bd.close();
            }
            catch (DataAccess.DataAccessException ex)
            {
                throw new BussinessRulesException(ex.Message);
            }
        }    
        public void borrarPlanilla(string cliente, string area)
        {

            DataAccess.DataBase db = new DataAccess.DataBase();

            db.connect();

            string sql = "delete from planilla WHERE  =Cliente_Rut'" + cliente + "',and Area=" + area;

            db.CreateCommand(sql);

            db.execute();

            db.close();



        }
        public void borrarPeriodidicad(string cod)
        {

            DataAccess.DataBase db = new DataAccess.DataBase();

            db.connect();

            string sql = "delete from periodicidad WHERE  periodicidad.cod='" + cod + "';";

            db.CreateCommand(sql);

            db.execute();

            db.close();



        }

        public void modEstado(Periodicidad ac)
        {

            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();                
                string sql = "update periodicidad set Estado='" + ac.Estado + "'where cod='" + ac.Codperi + "';";

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
     

        public void modFecha(Periodicidad ac)
        {

            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();
                string sql = "update periodicidad set Fecha='" + ac.Fecha + "'where cod='" + ac.Codperi + "';";

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


        public void modTecnicoR(Periodicidad ac)
        {

            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();
                string sql = "update periodicidad set Tecnicos_Cod='" + ac.Codtec + "'where cod='" + ac.Codperi + "';";

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

        public void modOti(Periodicidad ac)
        {

            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();
                string sql = "update periodicidad set Oti='" + ac.Oti + "'where cod='" + ac.Codperi + "';";

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


        public void modConsumo(Periodicidad ac)
        {

            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();
                string sql = "update periodicidad set consumo='" + ac.Consumo + "'where cod='" + ac.Codperi + "'and fecha='" + ac.Fecha + "'and oti='" + ac.Oti + "';";

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

        public void modTiempo(Periodicidad ac)
        {

            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();
                string sql = "update periodicidad set tiempo='" + ac.Tiempo + "'where cod='" + ac.Codperi + "'and fecha='" + ac.Fecha + "'and oti='" + ac.Oti + "';";

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


        public List<Periodicidad> getfech(string s)
        {

            DataBase bd = new DataBase();
            bd.connect();
            List<Periodicidad> units = new List<Periodicidad>();           
            string sql = "select periodicidad.Cod,periodicidad.Fecha,periodicidad.planilla_Cod from planilla,periodicidad,cliente,lugartratamiento  where planilla.Cod=periodicidad.planilla_Cod and lugartratamiento.CodNT=cliente.Cod  and cliente.Rut=planilla.Cliente_Rut and cliente.LugardeTratamiento='" + s + "';";
            bd.CreateCommand(sql);

            DbDataReader result = bd.Query();

            while (result.Read())
            {
                Periodicidad u = new Periodicidad(result.GetInt32(0), result.GetString(1), result.GetInt32(2));
                units.Add(u);

            }
            result.Close();
            bd.close();
            return units;

        }

        public List<Periodicidad> getmaxcodperi()
        {

            DataBase bd = new DataBase();
            bd.connect();
            List<Periodicidad> units = new List<Periodicidad>();
            string sql = "select max(Cod) from periodicidad;";
            bd.CreateCommand(sql);

            DbDataReader result = bd.Query();

            while (result.Read())
            {
                Periodicidad u = new Periodicidad(result.GetInt32(0));
                units.Add(u);

            }
            result.Close();
            bd.close();
            return units;

        }



        public List<Periodicidad> getcodfech()
        {

            DataBase bd = new DataBase();
            bd.connect();
            List<Periodicidad> units = new List<Periodicidad>();
            
            string sql = "select ifnull(MAX(planilla.cod),0) from planilla inner join lugartratamiento where planilla.Cliente_Rut=Lugartratamiento.cliente_rut ;";           
            bd.CreateCommand(sql);

            DbDataReader result = bd.Query();

            while (result.Read())
            {
                if (result.GetInt32(0) != 0)
                {
                    Periodicidad u = new Periodicidad(result.GetInt32(0));
                    units.Add(u);
                }
                else
                {
                    
                }

            }
            result.Close();
            bd.close();
            return units;

        }




        public void addfecha(Periodicidad ac)
        {
            try
            {
                DataAccess.DataBase bd = new DataAccess.DataBase();
                bd.connect();
                string sql = "insert into periodicidad values('" + ac.Codperi + "','" + ac.Fecha + "','" + ac.Cod + "','" + ac.Codser + "','" + ac.Codtec + "','" + ac.Codarea + "','" + ac.Oti + "','" + ac.Consumo + "','" + ac.Tperiodicidad + "','" + ac.Estado + "','" + ac.Observaciones + "','" + ac.Nivel + "','" + ac.Tiempo + "','" + ac.NoConformidad + "')";
                bd.CreateCommand(sql);
                bd.execute();
                bd.close();
            }
            catch (DataAccess.DataAccessException ex)
            {
                throw new BussinessRulesException(ex.Message);
            }
        }

        public void updateperiodicidad(Periodicidad ac)
        {

            try
            {

                DataBase db = new DataBase();
                db.connect();
                string sql = "update periodicidad  set periodicidad.Tecnicos_Cod='" + ac.Codtec + "' Where periodicidad.Planilla_Cod='" + ac.Codpla + "' and periodicidad.Fecha= '" + ac.Fecha + "' ;";

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


        public void modoti(Periodicidad ac)
        {

            try
            {

                DataBase db = new DataBase();
                db.connect();
                string sql = "update periodicidad  set periodicidad.Oti='" + ac.Oti + "' Where periodicidad.cod='" + ac.Cod + "' and periodicidad.Fecha= '" + ac.Fecha + "' ;";

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

        public void addfechanull(Periodicidad ac)
        {
            try
            {
                DataAccess.DataBase bd = new DataAccess.DataBase();
                bd.connect();
                string sql = "insert into periodicidad values('" + ac.Codperi + "','" + ac.Fecha + "','" + ac.Cod + "','" + ac.Codser + "','" + ac.Codtec + "','" + 3 + "')";
                bd.CreateCommand(sql);
                bd.execute();
                bd.close();
            }
            catch (DataAccess.DataAccessException ex)
            {
                throw new BussinessRulesException(ex.Message);
            }
        }


        public List<Inventariado> mostrarplanilla(string s)
        {
            try
            {
                DataBase db = new DataBase();
                db.connect();


                String sql = "select tecnicos.Nombre,lugartratamiento.ruta,periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla order by servicio.Sigla asc), cliente.Nombre,cliente.rut, lugartratamiento.NombreTratamiento , periodicidad.Area_Cod, date_format(periodicidad.Fecha,'%Y/%m/%d'), planilla.Descripcion, planilla.cod, periodicidad.DescripcionParticular,periodicidad.nivel from tecnicos, servicio, cliente, periodicidad, lugartratamiento inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod  and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and periodicidad.Estado not like '%Replanificado%' and periodicidad.Estado not like '%Suspendido%' and year(Fecha)= '" + s + "' group by periodicidad.Fecha, lugartratamiento.NombreTratamiento,planilla.Cod,TipoPeridodicidad,tecnicos.nombre;";

                db.CreateCommand(sql);
                List<Inventariado> tec = new List<Inventariado>();
                DbDataReader result = db.Query();

                while (result.Read())
                {
                    string codtec = result.GetString(0);
                    string ruta = result.GetString(1);
                    string tipo = result.GetString(2);
                    string codser = result.GetString(3);
                    string codcli = result.GetString(4);
                    string codrut = result.GetString(5);
                    string codlugar = result.GetString(6);
                    string area = result.GetString(7);
                    DateTime fecha = result.GetDateTime(8);
                    string descrip = result.GetString(9);
                    string codpla = result.GetString(10);
                    string descripparticular = result.GetString(11);
                    string nivel = result.GetString(12);

                    Inventariado a = new Inventariado(codtec, ruta, tipo, codser, codcli, codrut, descrip, codlugar, area, fecha, codpla, descripparticular,nivel);
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

        public void eliminarPermiso(string codser, string cod)
        {

            DataAccess.DataBase db = new DataAccess.DataBase();

            db.connect();

            string sql = "delete from periodicidad WHERE periodicidad.Servicio_Cod='"+codser+"' and periodicidad.cod ='" + cod + "'";

            db.CreateCommand(sql);

            db.execute();

            db.close();



        }
        public void eliminarTecSecundario(string nivel, string cod)
        {

            DataAccess.DataBase db = new DataAccess.DataBase();

            db.connect();

            string sql = "delete from periodicidad WHERE periodicidad.Nivel='" + nivel + "' and periodicidad.cod ='" + cod + "'";

            db.CreateCommand(sql);

            db.execute();

            db.close();



        }
        public List<InventariadoPermiso> mostrarplanillaPermiso(string s)
        {
            try
            {
                DataBase db = new DataBase();
                db.connect();


                String sql = "select tecnicos.Nombre,periodicidad.TipoPeridodicidad, date_format(periodicidad.Fecha,'%Y/%m/%d') from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and year(Fecha)= '"+s+"' and servicio.Sigla='PP' group by periodicidad.Fecha, lugartratamiento.NombreTratamiento,planilla.Cod,TipoPeridodicidad;";

                db.CreateCommand(sql);
                List<InventariadoPermiso> tec = new List<InventariadoPermiso>();
                DbDataReader result = db.Query();

                while (result.Read())
                {
                    string codtec = result.GetString(0);                 
                    string tipo = result.GetString(1);                                   
                    DateTime fecha = result.GetDateTime(2);
                  
                    InventariadoPermiso a = new InventariadoPermiso(codtec, tipo,fecha);
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

        public List<Inventariado> mostrarPlanillaPorFechaCalendario(string s)
        {
            try
            {
                DataBase db = new DataBase();
                db.connect();


                String sql = "select tecnicos.Nombre,lugartratamiento.ruta,periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla order by servicio.Sigla asc), cliente.Nombre,cliente.rut, lugartratamiento.NombreTratamiento , group_concat(distinct area.NombreArea), date_format(periodicidad.Fecha,'%Y/%m/%d'), planilla.Descripcion, planilla.cod, periodicidad.DescripcionParticular, periodicidad.nivel from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and periodicidad.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and fecha= '" + s + "' group by periodicidad.Fecha, lugartratamiento.NombreTratamiento,planilla.Cod;";

                db.CreateCommand(sql);
                List<Inventariado> tec = new List<Inventariado>();
                DbDataReader result = db.Query();

                while (result.Read())
                {
                    string codtec = result.GetString(0);
                    string ruta = result.GetString(1);
                    string tipo = result.GetString(2);
                    string codser = result.GetString(3);
                    string codcli = result.GetString(4);
                    string codrut = result.GetString(5);
                    string codlugar = result.GetString(6);
                    string area = result.GetString(7);
                    DateTime fecha = result.GetDateTime(8);
                    string descrip = result.GetString(9);
                    string codpla = result.GetString(10);
                    string descripparticular = result.GetString(11);


                    string nivel = result.GetString(12);

                    Inventariado a = new Inventariado(codtec, ruta, tipo, codser, codcli, codrut, descrip, codlugar, area, fecha, codpla, descripparticular, nivel);
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


        public List<Inventariado> mostrarplanillabuscar(string s, string y, string z)
        {
            try
            {
                DataBase db = new DataBase();
                db.connect();
                String sql = "select tecnicos.Nombre,lugartratamiento.ruta,periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla order by servicio.Sigla asc), cliente.Nombre,cliente.rut, lugartratamiento.NombreTratamiento , periodicidad.area_cod, periodicidad.Fecha, planilla.Descripcion, planilla.cod , periodicidad.DescripcionParticular, periodicidad.nivel from tecnicos, servicio, cliente,periodicidad, lugartratamiento inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and periodicidad.Estado not like '%Replanificado%' and periodicidad.Estado not like '%Suspendido%' and cliente.Nombre like '%" + s + "%' and periodicidad.Fecha between '" + y + "'and '" + z + "' group by periodicidad.Fecha, planilla.Cod,lugartratamiento.NombreTratamiento,TipoPeridodicidad, tecnicos.nombre;";

                db.CreateCommand(sql);
                List<Inventariado> tec = new List<Inventariado>();
                DbDataReader result = db.Query();

                while (result.Read())
                {
                    string codtec = result.GetString(0);
                    string ruta = result.GetString(1);
                    string tipo = result.GetString(2);
                    string codser = result.GetString(3);
                    string codcli = result.GetString(4);
                    string codrut = result.GetString(5);
                    string codlugar = result.GetString(6);
                    string area = result.GetString(7);
                    DateTime fecha = result.GetDateTime(8);
                    string descrip = result.GetString(9);
                    string codpla = result.GetString(10);
                    string descripparticular = result.GetString(11);

                    string nivel = result.GetString(12);

                    Inventariado a = new Inventariado(codtec, ruta, tipo, codser, codcli, codrut, descrip, codlugar, area, fecha, codpla, descripparticular, nivel);
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

        public List<Inventariado> mostrarplanillabuscarTecnico(string s, string y, string z)
        {
            try
            {
                DataBase db = new DataBase();
                db.connect();
                String sql = "select tecnicos.Nombre,lugartratamiento.ruta,periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla order by servicio.Sigla asc), cliente.Nombre,cliente.rut, lugartratamiento.NombreTratamiento , periodicidad.area_cod, periodicidad.Fecha, planilla.Descripcion, planilla.cod , periodicidad.DescripcionParticular,periodicidad.nivel from tecnicos, servicio, cliente,periodicidad, lugartratamiento inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and periodicidad.Estado not like '%Replanificado%' and periodicidad.Estado not like '%Suspendido%' and tecnicos.nombre='" + s + "' and periodicidad.Fecha between '" + y + "'and '" + z + "' group by periodicidad.Fecha, planilla.Cod,lugartratamiento.NombreTratamiento,TipoPeridodicidad;";

                db.CreateCommand(sql);
                List<Inventariado> tec = new List<Inventariado>();
                DbDataReader result = db.Query();

                while (result.Read())
                {
                    string codtec = result.GetString(0);
                    string ruta = result.GetString(1);
                    string tipo = result.GetString(2);
                    string codser = result.GetString(3);
                    string codcli = result.GetString(4);
                    string codrut = result.GetString(5);
                    string codlugar = result.GetString(6);
                    string area = result.GetString(7);
                    DateTime fecha = result.GetDateTime(8);
                    string descrip = result.GetString(9);
                    string codpla = result.GetString(10);
                    string descripparticular = result.GetString(11);

                    string nivel = result.GetString(12);

                    Inventariado a = new Inventariado(codtec, ruta, tipo, codser, codcli, codrut, descrip, codlugar, area, fecha, codpla, descripparticular, nivel);
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



        public List<Inventariado> mostrarplanillabuscarporltratamiento(string s, string y, string z)
        {
            try
            {
                DataBase db = new DataBase();
                db.connect();


                String sql = "select tecnicos.Nombre,lugartratamiento.ruta,periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla order by servicio.Sigla asc), cliente.Nombre,cliente.rut, lugartratamiento.NombreTratamiento , periodicidad.area_cod, periodicidad.Fecha, planilla.Descripcion, planilla.cod , periodicidad.DescripcionParticular, periodicidad.nivel from tecnicos, servicio, cliente, periodicidad, lugartratamiento inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and periodicidad.Estado not like '%Replanificado%' and periodicidad.Estado not like '%Suspendido%' and  lugartratamiento.nombretratamiento = '" + s + "' and periodicidad.Fecha between '" + y + "'and '" + z + "' group by periodicidad.Fecha,planilla.cod, lugartratamiento.NombreTratamiento, TipoPeridodicidad, tecnicos.nombre;";

                db.CreateCommand(sql);
                List<Inventariado> tec = new List<Inventariado>();
                DbDataReader result = db.Query();

                while (result.Read())
                {
                    string codtec = result.GetString(0);
                    string ruta = result.GetString(1);
                    string tipo = result.GetString(2);
                    string codser = result.GetString(3);
                    string codcli = result.GetString(4);
                    string codrut = result.GetString(5);
                    string codlugar = result.GetString(6);
                    string area = result.GetString(7);
                    DateTime fecha = result.GetDateTime(8);
                    string descrip = result.GetString(9);
                    string codpla = result.GetString(10);
                    string descripparticular = result.GetString(11);
                    string nivel = result.GetString(12);

                    Inventariado a = new Inventariado(codtec, ruta, tipo, codser, codcli, codrut, descrip, codlugar, area, fecha, codpla, descripparticular, nivel);
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

        public List<InventariadoR> mostrarplanillaR(string s)
        {
            try
            {
                DataBase db = new DataBase();
                db.connect();             
                String sql = "select tecnicos.Nombre,lugartratamiento.ruta,periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), cliente.Nombre,cliente.rut, periodicidad.consumo, lugartratamiento.NombreTratamiento , periodicidad.area_cod, date_format(periodicidad.Fecha,'%Y/%m/%d'), planilla.Descripcion, planilla.cod, periodicidad.oti, periodicidad.Estado, periodicidad.nivel, periodicidad.Tiempo from tecnicos, servicio, cliente, periodicidad, lugartratamiento inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod  and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and periodicidad.nivel='Primario' and year(Fecha)= '" + s + "' group by periodicidad.Fecha, periodicidad.oti,lugartratamiento.NombreTratamiento , tecnicos.Nombre, servicio.Sigla, cliente.Nombre,cliente.rut, periodicidad.consumo, planilla.cod;";
                db.CreateCommand(sql);
                List<InventariadoR> tec = new List<InventariadoR>();
                DbDataReader result = db.Query();

                while (result.Read())
                {
                    string codtec = result.GetString(0);
                    string ruta = result.GetString(1);
                    string codtipo = result.GetString(2);
                    string codser = result.GetString(3);
                    string codcli = result.GetString(4);
                    string codrut = result.GetString(5);
                    string codcon = result.GetString(6);
                    string codlugar = result.GetString(7);
                    string area = result.GetString(8);
                    DateTime fecha = result.GetDateTime(9);
                    string descrip = result.GetString(10);
                    string codpla = result.GetString(11);
                    string oti = result.GetString(12);
                    string estado = result.GetString(13);
                    string nivel = result.GetString(14);
                    string tiempo = result.GetString(15);

                    InventariadoR a = new InventariadoR(codtec, ruta, codtipo, codser, codcli, codrut, codcon, descrip, codlugar, area, fecha, codpla, oti, estado, nivel, tiempo);
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
        public List<InventariadoR> mostrarplanillaRConSecundarios(string s)
        {
            try
            {
                DataBase db = new DataBase();
                db.connect();
                String sql = "select tecnicos.Nombre,lugartratamiento.ruta,periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), cliente.Nombre,cliente.rut, periodicidad.consumo, lugartratamiento.NombreTratamiento , periodicidad.area_cod, date_format(periodicidad.Fecha,'%Y/%m/%d'), planilla.Descripcion, planilla.cod, periodicidad.oti, periodicidad.Estado, periodicidad.nivel, periodicidad.Tiempo from tecnicos, servicio, cliente, periodicidad, lugartratamiento inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod  and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and year(Fecha)= '" + s + "' group by periodicidad.Fecha, periodicidad.oti,lugartratamiento.NombreTratamiento , tecnicos.Nombre, servicio.Sigla, cliente.Nombre,cliente.rut, periodicidad.consumo, planilla.cod;";
                db.CreateCommand(sql);
                List<InventariadoR> tec = new List<InventariadoR>();
                DbDataReader result = db.Query();

                while (result.Read())
                {
                    string codtec = result.GetString(0);
                    string ruta = result.GetString(1);
                    string codtipo = result.GetString(2);
                    string codser = result.GetString(3);
                    string codcli = result.GetString(4);
                    string codrut = result.GetString(5);
                    string codcon = result.GetString(6);
                    string codlugar = result.GetString(7);
                    string area = result.GetString(8);
                    DateTime fecha = result.GetDateTime(9);
                    string descrip = result.GetString(10);
                    string codpla = result.GetString(11);
                    string oti = result.GetString(12);
                    string estado = result.GetString(13);
                    string nivel = result.GetString(14);
                    string tiempo = result.GetString(15);

                    InventariadoR a = new InventariadoR(codtec, ruta, codtipo, codser, codcli, codrut, codcon, descrip, codlugar, area, fecha, codpla, oti, estado, nivel, tiempo);
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

        public List<InventariadoR> mostrarplanillaRRealizados(string ini, string fin)
        {
            try
            {
                DataBase db = new DataBase();
                db.connect();
                String sql = "select tecnicos.Nombre,lugartratamiento.ruta,periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), cliente.Nombre,cliente.rut, periodicidad.consumo, lugartratamiento.NombreTratamiento , periodicidad.area_cod, date_format(periodicidad.Fecha,'%Y/%m/%d'), planilla.Descripcion, planilla.cod, periodicidad.oti, periodicidad.Estado, periodicidad.nivel , periodicidad.Tiempo from tecnicos, servicio, cliente, periodicidad, lugartratamiento inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod  and periodicidad.servicio_Cod=servicio.Cod and  periodicidad.nivel='Primario' and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and periodicidad.Estado='Realizado' and fecha between '" + ini + "' and '" + fin + "'  group by periodicidad.Fecha, periodicidad.oti,lugartratamiento.NombreTratamiento , tecnicos.Nombre, servicio.Sigla, cliente.Nombre,cliente.rut, periodicidad.consumo;";
                db.CreateCommand(sql);
                List<InventariadoR> tec = new List<InventariadoR>();
                DbDataReader result = db.Query();

                while (result.Read())
                {
                    string codtec = result.GetString(0);
                    string ruta = result.GetString(1);
                    string codtipo = result.GetString(2);
                    string codser = result.GetString(3);
                    string codcli = result.GetString(4);
                    string codrut = result.GetString(5);
                    string codcon = result.GetString(6);
                    string codlugar = result.GetString(7);
                    string area = result.GetString(8);
                    DateTime fecha = result.GetDateTime(9);
                    string descrip = result.GetString(10);
                    string codpla = result.GetString(11);
                    string oti = result.GetString(12);
                    string estado = result.GetString(13);
                    string nivel = result.GetString(14);
                    string tiempo = result.GetString(15);
                    InventariadoR a = new InventariadoR(codtec, ruta, codtipo, codser, codcli, codrut, codcon, descrip, codlugar, area, fecha, codpla, oti, estado, nivel, tiempo);
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


        public List<InventariadoR> mostrarplanillaRARealizar(string ini, string fin)
        {
            try
            {
                DataBase db = new DataBase();
                db.connect();
                String sql = "select tecnicos.Nombre,lugartratamiento.ruta,periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), cliente.Nombre,cliente.rut, periodicidad.consumo, lugartratamiento.NombreTratamiento , periodicidad.area_cod, date_format(periodicidad.Fecha,'%Y/%m/%d'), planilla.Descripcion, planilla.cod, periodicidad.oti, periodicidad.Estado, periodicidad.nivel , periodicidad.Tiempo from tecnicos, servicio, cliente, periodicidad, lugartratamiento inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod  and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and periodicidad.nivel='Primario' and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and periodicidad.Estado='P' and fecha between '" + ini + "' and '" + fin + "' group by periodicidad.Fecha, periodicidad.oti,lugartratamiento.NombreTratamiento , tecnicos.Nombre, servicio.Sigla, cliente.Nombre,cliente.rut, periodicidad.consumo";
                db.CreateCommand(sql);
                List<InventariadoR> tec = new List<InventariadoR>();
                DbDataReader result = db.Query();

                while (result.Read())
                {
                    string codtec = result.GetString(0);
                    string ruta = result.GetString(1);
                    string codtipo = result.GetString(2);
                    string codser = result.GetString(3);
                    string codcli = result.GetString(4);
                    string codrut = result.GetString(5);
                    string codcon = result.GetString(6);
                    string codlugar = result.GetString(7);
                    string area = result.GetString(8);
                    DateTime fecha = result.GetDateTime(9);
                    string descrip = result.GetString(10);
                    string codpla = result.GetString(11);
                    string oti = result.GetString(12);
                    string estado = result.GetString(13);
                    string nivel = result.GetString(14);
                    string tiempo = result.GetString(15);
                    InventariadoR a = new InventariadoR(codtec, ruta, codtipo, codser, codcli, codrut, codcon, descrip, codlugar, area, fecha, codpla, oti, estado, nivel, tiempo);
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


        public List<InventariadoR> mostrarplanillaRNORealizados(string ini, string fin)
        {
            try
            {
                DataBase db = new DataBase();
                db.connect();
                String sql = "select tecnicos.Nombre,lugartratamiento.ruta,periodicidad.TipoPeridodicidad,  servicio.Sigla, cliente.Nombre,cliente.rut, periodicidad.consumo, lugartratamiento.NombreTratamiento , periodicidad.area_cod, date_format(periodicidad.Fecha,'%Y/%m/%d'), planilla.Descripcion, planilla.cod, periodicidad.oti, periodicidad.Estado, periodicidad.nivel , periodicidad.Tiempo from estado, tecnicos, servicio, cliente, periodicidad, lugartratamiento inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod  and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and periodicidad.nivel='Primario' and  planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod  and periodicidad.estado='No Realizado'and fecha between '" + ini + "' and '" + fin + "' group by periodicidad.Fecha, periodicidad.oti,lugartratamiento.NombreTratamiento , tecnicos.Nombre, servicio.Sigla, cliente.Nombre,cliente.rut, periodicidad.consumo";
                db.CreateCommand(sql);
                List<InventariadoR> tec = new List<InventariadoR>();
                DbDataReader result = db.Query();

                while (result.Read())
                {
                    string codtec = result.GetString(0);
                    string ruta = result.GetString(1);
                    string codtipo = result.GetString(2);
                    string codser = result.GetString(3);
                    string codcli = result.GetString(4);
                    string codrut = result.GetString(5);
                    string codcon = result.GetString(6);
                    string codlugar = result.GetString(7);
                    string area = result.GetString(8);
                    DateTime fecha = result.GetDateTime(9);
                    string descrip = result.GetString(10);
                    string codpla = result.GetString(11);
                    string oti = result.GetString(12);
                    string estado = result.GetString(13);

                    string nivel = result.GetString(14);
                    string tiempo = result.GetString(15);
                    InventariadoR a = new InventariadoR(codtec, ruta, codtipo, codser, codcli, codrut, codcon, descrip, codlugar, area, fecha, codpla, oti, estado, nivel, tiempo);
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





        public List<InventariadoR> mostrarplanillaRSuspendidos(string ini , string fin)
        {
            try
            {
                DataBase db = new DataBase();
                db.connect();
                String sql = "select tecnicos.Nombre,lugartratamiento.ruta,periodicidad.TipoPeridodicidad,  servicio.Sigla, cliente.Nombre,cliente.rut, periodicidad.consumo, lugartratamiento.NombreTratamiento , periodicidad.area_cod, date_format(periodicidad.Fecha,'%Y/%m/%d'), planilla.Descripcion, planilla.cod, periodicidad.oti, periodicidad.Estado, periodicidad.nivel , periodicidad.Tiempo from estado, tecnicos, servicio, cliente, periodicidad, lugartratamiento inner join planilla where  periodicidad.tecnicos_Cod=tecnicos.Cod  and  periodicidad.nivel='Primario' and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod  and periodicidad.estado='Suspendido' and fecha between '" + ini + "' and '" + fin + "' group by periodicidad.Fecha, periodicidad.oti,lugartratamiento.NombreTratamiento , tecnicos.Nombre, servicio.Sigla, cliente.Nombre,cliente.rut, periodicidad.consumo;";
                db.CreateCommand(sql);
                List<InventariadoR> tec = new List<InventariadoR>();
                DbDataReader result = db.Query();

                while (result.Read())
                {
                    string codtec = result.GetString(0);
                    string ruta = result.GetString(1);
                    string codtipo = result.GetString(2);
                    string codser = result.GetString(3);
                    string codcli = result.GetString(4);
                    string codrut = result.GetString(5);
                    string codcon = result.GetString(6);
                    string codlugar = result.GetString(7);
                    string area = result.GetString(8);
                    DateTime fecha = result.GetDateTime(9);
                    string descrip = result.GetString(10);
                    string codpla = result.GetString(11);
                    string oti = result.GetString(12);
                    string estado = result.GetString(13);


                    string nivel = result.GetString(14);
                    string tiempo = result.GetString(15);
                    InventariadoR a = new InventariadoR(codtec, ruta, codtipo, codser, codcli, codrut, codcon, descrip, codlugar, area, fecha, codpla, oti, estado, nivel, tiempo);
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







        public List<InventariadoR> mostrarplanillaRporcliente(string s, string y, string z)
        {
            try
            {
                DataBase db = new DataBase();
                db.connect();



                String sql = "select tecnicos.Nombre,lugartratamiento.ruta,periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), cliente.Nombre,cliente.rut, periodicidad.consumo, lugartratamiento.NombreTratamiento , periodicidad.area_cod, date_format(periodicidad.Fecha,'%Y/%m/%d'), planilla.Descripcion, planilla.cod, periodicidad.oti, periodicidad.estado,periodicidad.nivel  , periodicidad.Tiempo from tecnicos, servicio, cliente,periodicidad, lugartratamiento inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod  and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and  periodicidad.nivel='Primario'and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and cliente.nombre like '%" + s + "%' and periodicidad.Fecha between '" + y + "'and '" + z + "' group by periodicidad.Fecha, periodicidad.oti,lugartratamiento.NombreTratamiento , tecnicos.Nombre, servicio.Sigla, cliente.Nombre,cliente.rut;";
                db.CreateCommand(sql);
                List<InventariadoR> tec = new List<InventariadoR>();
                DbDataReader result = db.Query();

                while (result.Read())
                {
                    string codtec = result.GetString(0);
                    string ruta = result.GetString(1);
                    string codtipo = result.GetString(2);
                    string codser = result.GetString(3);
                    string codcli = result.GetString(4);
                    string codrut = result.GetString(5);
                    string codcon = result.GetString(6);
                    string codlugar = result.GetString(7);
                    string area = result.GetString(8);
                    DateTime fecha = result.GetDateTime(9);
                    string descrip = result.GetString(10);
                    string codpla = result.GetString(11);
                    string oti = result.GetString(12);
                    string estado = result.GetString(13);

                    string nivel = result.GetString(14);
                    string tiempo = result.GetString(15);
                    InventariadoR a = new InventariadoR(codtec, ruta, codtipo, codser, codcli, codrut, codcon, descrip, codlugar, area, fecha, codpla, oti, estado, nivel, tiempo);
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
        public List<InventariadoR> mostrarplanillaRporclienteConSecundarios(string s, string y, string z)
        {
            try
            {
                DataBase db = new DataBase();
                db.connect();



                String sql = "select tecnicos.Nombre,lugartratamiento.ruta,periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), cliente.Nombre,cliente.rut, periodicidad.consumo, lugartratamiento.NombreTratamiento , periodicidad.area_cod, date_format(periodicidad.Fecha,'%Y/%m/%d'), planilla.Descripcion, planilla.cod, periodicidad.oti, periodicidad.estado,periodicidad.nivel  , periodicidad.Tiempo from tecnicos, servicio, cliente,periodicidad, lugartratamiento inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod  and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and cliente.nombre like '%" + s + "%' and periodicidad.Fecha between '" + y + "'and '" + z + "' group by periodicidad.Fecha, periodicidad.oti,lugartratamiento.NombreTratamiento , tecnicos.Nombre, servicio.Sigla, cliente.Nombre,cliente.rut;";
                db.CreateCommand(sql);
                List<InventariadoR> tec = new List<InventariadoR>();
                DbDataReader result = db.Query();

                while (result.Read())
                {
                    string codtec = result.GetString(0);
                    string ruta = result.GetString(1);
                    string codtipo = result.GetString(2);
                    string codser = result.GetString(3);
                    string codcli = result.GetString(4);
                    string codrut = result.GetString(5);
                    string codcon = result.GetString(6);
                    string codlugar = result.GetString(7);
                    string area = result.GetString(8);
                    DateTime fecha = result.GetDateTime(9);
                    string descrip = result.GetString(10);
                    string codpla = result.GetString(11);
                    string oti = result.GetString(12);
                    string estado = result.GetString(13);

                    string nivel = result.GetString(14);
                    string tiempo = result.GetString(15);
                    InventariadoR a = new InventariadoR(codtec, ruta, codtipo, codser, codcli, codrut, codcon, descrip, codlugar, area, fecha, codpla, oti, estado, nivel, tiempo);
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

        public List<InventariadoR> mostrarplanillaRporltratamiento(string s, string y, string z)
        {
            try
            {
                DataBase db = new DataBase();
                db.connect();
                String sql = "select tecnicos.Nombre,lugartratamiento.ruta,periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), cliente.Nombre,cliente.rut, periodicidad.consumo, lugartratamiento.NombreTratamiento , periodicidad.area_cod, date_format(periodicidad.Fecha,'%Y/%m/%d'), planilla.Descripcion, planilla.cod, periodicidad.oti, periodicidad.estado, periodicidad.nivel , periodicidad.Tiempo from tecnicos, servicio, cliente, periodicidad, lugartratamiento inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod  and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and  periodicidad.nivel='Primario' and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and lugartratamiento.nombretratamiento = '" + s + "' and periodicidad.Fecha between '" + y + "'and '" + z + "' group by periodicidad.Fecha, periodicidad.oti,lugartratamiento.NombreTratamiento , tecnicos.Nombre, servicio.Sigla, cliente.Nombre,cliente.rut;";
                db.CreateCommand(sql);
                List<InventariadoR> tec = new List<InventariadoR>();
                DbDataReader result = db.Query();

                while (result.Read())
                {
                    string codtec = result.GetString(0);
                    string ruta = result.GetString(1);
                    string codtipo = result.GetString(2);
                    string codser = result.GetString(3);
                    string codcli = result.GetString(4);
                    string codrut = result.GetString(5);
                    string codcon = result.GetString(6);
                    string codlugar = result.GetString(7);
                    string area = result.GetString(8);
                    DateTime fecha = result.GetDateTime(9);
                    string descrip = result.GetString(10);
                    string codpla = result.GetString(11);
                    string oti = result.GetString(12);
                    string estado = result.GetString(13);

                    string nivel = result.GetString(14);
                    string tiempo = result.GetString(15);
                    InventariadoR a = new InventariadoR(codtec, ruta, codtipo, codser, codcli, codrut, codcon, descrip, codlugar, area, fecha, codpla, oti, estado, nivel, tiempo);
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
        public List<InventariadoR> mostrarplanillaRporltratamientoConSecundarios(string s, string y, string z)
        {
            try
            {
                DataBase db = new DataBase();
                db.connect();
                String sql = "select tecnicos.Nombre,lugartratamiento.ruta,periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), cliente.Nombre,cliente.rut, periodicidad.consumo, lugartratamiento.NombreTratamiento , periodicidad.area_cod, date_format(periodicidad.Fecha,'%Y/%m/%d'), planilla.Descripcion, planilla.cod, periodicidad.oti, periodicidad.estado, periodicidad.nivel , periodicidad.Tiempo from tecnicos, servicio, cliente, periodicidad, lugartratamiento inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod  and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and lugartratamiento.nombretratamiento = '" + s + "' and periodicidad.Fecha between '" + y + "'and '" + z + "' group by periodicidad.Fecha, periodicidad.oti,lugartratamiento.NombreTratamiento , tecnicos.Nombre, servicio.Sigla, cliente.Nombre,cliente.rut;";
                db.CreateCommand(sql);
                List<InventariadoR> tec = new List<InventariadoR>();
                DbDataReader result = db.Query();

                while (result.Read())
                {
                    string codtec = result.GetString(0);
                    string ruta = result.GetString(1);
                    string codtipo = result.GetString(2);
                    string codser = result.GetString(3);
                    string codcli = result.GetString(4);
                    string codrut = result.GetString(5);
                    string codcon = result.GetString(6);
                    string codlugar = result.GetString(7);
                    string area = result.GetString(8);
                    DateTime fecha = result.GetDateTime(9);
                    string descrip = result.GetString(10);
                    string codpla = result.GetString(11);
                    string oti = result.GetString(12);
                    string estado = result.GetString(13);

                    string nivel = result.GetString(14);
                    string tiempo = result.GetString(15);
                    InventariadoR a = new InventariadoR(codtec, ruta, codtipo, codser, codcli, codrut, codcon, descrip, codlugar, area, fecha, codpla, oti, estado, nivel, tiempo);
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



        public List<InventariadoR> mostrarplanillaRporfecha(string s, string y)
        {
            try
            {
                DataBase db = new DataBase();
                db.connect();
                String sql = "select tecnicos.Nombre,lugartratamiento.ruta,periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), cliente.Nombre,cliente.rut, periodicidad.consumo, lugartratamiento.NombreTratamiento , periodicidad.area_cod, date_format(periodicidad.Fecha,'%Y/%m/%d'), planilla.Descripcion, planilla.cod, periodicidad.oti, periodicidad.estado, periodicidad.nivel, periodicidad.Tiempo from tecnicos, servicio, cliente, periodicidad, lugartratamiento inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and  periodicidad.nivel='Primario' and lugartratamiento.cliente_Cod=cliente.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and periodicidad.Fecha between '" + s + "' and '" + y + "'group by periodicidad.Fecha, periodicidad.oti,lugartratamiento.NombreTratamiento , tecnicos.Nombre, servicio.Sigla, cliente.Nombre,cliente.rut;";
                db.CreateCommand(sql);
                List<InventariadoR> tec = new List<InventariadoR>();
                DbDataReader result = db.Query();

                while (result.Read())
                {
                    string codtec = result.GetString(0);
                    string ruta = result.GetString(1);
                    string codtipo = result.GetString(2);
                    string codser = result.GetString(3);
                    string codcli = result.GetString(4);
                    string codrut = result.GetString(5);
                    string codcon = result.GetString(6);
                    string codlugar = result.GetString(7);
                    string area = result.GetString(8);
                    DateTime fecha = result.GetDateTime(9);
                    string descrip = result.GetString(10);
                    string codpla = result.GetString(11);
                    string oti = result.GetString(12);
                    string estado = result.GetString(13);
                    string nivel = result.GetString(14);
                    string tiempo = result.GetString(15);
                    InventariadoR a = new InventariadoR(codtec, ruta, codtipo, codser, codcli, codrut, codcon, descrip, codlugar, area, fecha, codpla, oti, estado, nivel,tiempo);
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
     

        public List<InventariadoR> mostrarplanillaRporfechaConSecundarios(string s, string y)
        {
            try
            {
                DataBase db = new DataBase();
                db.connect();
                String sql = "select tecnicos.Nombre,lugartratamiento.ruta,periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), cliente.Nombre,cliente.rut, periodicidad.consumo, lugartratamiento.NombreTratamiento , periodicidad.area_cod, date_format(periodicidad.Fecha,'%Y/%m/%d'), planilla.Descripcion, planilla.cod, periodicidad.oti, periodicidad.estado, periodicidad.nivel, periodicidad.Tiempo from tecnicos, servicio, cliente, periodicidad, lugartratamiento inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and periodicidad.Fecha between '" + s + "' and '" + y + "'group by periodicidad.Fecha, periodicidad.oti,lugartratamiento.NombreTratamiento , tecnicos.Nombre, servicio.Sigla, cliente.Nombre,cliente.rut;";
                db.CreateCommand(sql);
                List<InventariadoR> tec = new List<InventariadoR>();
                DbDataReader result = db.Query();

                while (result.Read())
                {
                    string codtec = result.GetString(0);
                    string ruta = result.GetString(1);
                    string codtipo = result.GetString(2);
                    string codser = result.GetString(3);
                    string codcli = result.GetString(4);
                    string codrut = result.GetString(5);
                    string codcon = result.GetString(6);
                    string codlugar = result.GetString(7);
                    string area = result.GetString(8);
                    DateTime fecha = result.GetDateTime(9);
                    string descrip = result.GetString(10);
                    string codpla = result.GetString(11);
                    string oti = result.GetString(12);
                    string estado = result.GetString(13);
                    string nivel = result.GetString(14);
                    string tiempo = result.GetString(15);
                    InventariadoR a = new InventariadoR(codtec, ruta, codtipo, codser, codcli, codrut, codcon, descrip, codlugar, area, fecha, codpla, oti, estado, nivel, tiempo);
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






        public List<Inventariado> mostrarplanillaporfecha(string s, string y)
        {
            try
            {
                DataBase db = new DataBase();
                db.connect();
                String sql = "select tecnicos.Nombre,lugartratamiento.ruta,periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla order by servicio.Sigla asc), cliente.Nombre,cliente.rut, lugartratamiento.NombreTratamiento , periodicidad.area_cod, date_format(periodicidad.Fecha,'%Y/%m/%d'), planilla.Descripcion, planilla.cod, periodicidad.DescripcionParticular,periodicidad.nivel from tecnicos, servicio, cliente,periodicidad, lugartratamiento inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and periodicidad.Estado not like '%Replanificado%'and periodicidad.Estado not like '%Suspendido%' and periodicidad.Fecha between '" + s + "' and '" + y + "' group by periodicidad.Fecha, lugartratamiento.NombreTratamiento,TipoPeridodicidad, tecnicos.nombre";
                db.CreateCommand(sql);
                List<Inventariado> tec = new List<Inventariado>();
                DbDataReader result = db.Query();

                while (result.Read())
                {
                    string codtec = result.GetString(0);
                    string ruta = result.GetString(1);
                    string tipo = result.GetString(2);
                    string codser = result.GetString(3);
                    string codcli = result.GetString(4);
                    string codrut = result.GetString(5);
                    string codlugar = result.GetString(6);
                    string area = result.GetString(7);
                    DateTime fecha = result.GetDateTime(8);
                    string descrip = result.GetString(9);
                    string codpla = result.GetString(10);
                    string descripparticular = result.GetString(11);

                    string nivel = result.GetString(12);

                    Inventariado a = new Inventariado(codtec, ruta, tipo, codser, codcli, codrut, descrip, codlugar, area, fecha, codpla, descripparticular, nivel);
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


        public List<Inventariado> mostrarplanillapornombre(string s)
        {
            try
            {
                DataBase db = new DataBase();
                db.connect();            
                string sql = " select tecnicos.Nombre,lugartratamiento.ruta,periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), cliente.Nombre,cliente.rut, lugartratamiento.NombreTratamiento , group_concat(distinct area.NombreArea), periodicidad.Fecha, planilla.Descripcion, planilla.cod, periodicidad.DescripcionParticular, periodicidad.nivel from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and periodicidad.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and cliente.Nombre like '%" + s + "%' group by periodicidad.Fecha, lugartratamiento.NombreTratamiento;";
                db.CreateCommand(sql);
                List<Inventariado> tec = new List<Inventariado>();
                DbDataReader result = db.Query();




                while (result.Read())
                {
                    string codtec = result.GetString(0);
                    string ruta = result.GetString(1);
                    string tipo = result.GetString(2);
                    string codser = result.GetString(3);
                    string codcli = result.GetString(4);
                    string codrut = result.GetString(5);
                    string codlugar = result.GetString(6);
                    string area = result.GetString(7);
                    DateTime fecha = result.GetDateTime(8);
                    string descrip = result.GetString(9);
                    string codpla = result.GetString(10);
                    string descripparticular = result.GetString(11);

                    string nivel = result.GetString(12);

                    Inventariado a = new Inventariado(codtec, ruta, tipo, codser, codcli, codrut, descrip, codlugar, area, fecha, codpla, descripparticular, nivel);
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



        public List<LugarTratamiento> getlugar(string s)
        {

            DataBase bd = new DataBase();
            bd.connect();
            List<LugarTratamiento> units = new List<LugarTratamiento>();
            
            string sql = "select * from lugartratamiento where cliente_rut='" + s + "' order by lugartratamiento.nombretratamiento;";
            bd.CreateCommand(sql);

            DbDataReader result = bd.Query();

            while (result.Read())
            {
                LugarTratamiento u = new LugarTratamiento(result.GetString(1), result.GetString(3));
                units.Add(u);

            }
            result.Close();
            bd.close();
            return units;

        }

        public List<LugarTratamiento> allgetlugar()
        {

            DataBase bd = new DataBase();
            bd.connect();
            List<LugarTratamiento> units = new List<LugarTratamiento>();
          
            string sql = "select * from lugartratamiento order by lugartratamiento.nombretratamiento;";
            bd.CreateCommand(sql);

            DbDataReader result = bd.Query();

            while (result.Read())
            {
                LugarTratamiento u = new LugarTratamiento(result.GetString(1), result.GetString(3));
                units.Add(u);

            }
            result.Close();
            bd.close();
            return units;

        }



        public List<LugarTratamiento> getlugarforcli(string s)
        {

            DataBase bd = new DataBase();
            bd.connect();
            List<LugarTratamiento> units = new List<LugarTratamiento>();
           
            string sql = "select * from lugartratamiento where cliente_rut='" + s + "';";
            bd.CreateCommand(sql);

            DbDataReader result = bd.Query();

            while (result.Read())
            {
                LugarTratamiento u = new LugarTratamiento(result.GetString(1), result.GetString(3));
                units.Add(u);

            }
            result.Close();
            bd.close();
            return units;

        }


        public List<CheckList> Informebuscarplanilla(string s, string y, string z)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();
               
             //   string sql = "select  date_format(periodicidad.Fecha,'%Y/%m/%d'), planilla.numero, lugartratamiento.NombreTratamiento, group_concat(distinct servicio.Sigla),group_concat(distinct area.NombreArea), periodicidad.oti, plano.codplano, planilla.descripcion, periodicidad.DescripcionParticular, planilla.cod  from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento, plano inner join planilla where lugartratamiento.Cod=plano.lugartratamiento_Cod and periodicidad.tecnicos_Cod=tecnicos.Cod and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and periodicidad.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and periodicidad.estado!='Reaplanificado' and periodicidad.estado!='Suspendido' and planilla.lugartratamiento_Cod=lugartratamiento.Cod and tecnicos.Nombre='" + s + "' and periodicidad.Fecha between'" + y + "'and '" + z + "' group by fecha, NombreTratamiento, planilla.cod;";
                string sql = "select  date_format(periodicidad.Fecha,'%Y/%m/%d'), planilla.numero,  if(servicio.cod='11',periodicidad.TipoPeridodicidad,NombreTratamiento), group_concat(distinct servicio.Sigla),periodicidad.area_cod, periodicidad.oti, plano.codplano, planilla.descripcion, periodicidad.DescripcionParticular, planilla.cod  from tecnicos, servicio, cliente, periodicidad, lugartratamiento, plano inner join planilla where lugartratamiento.Cod=plano.lugartratamiento_Cod and periodicidad.tecnicos_Cod=tecnicos.Cod and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.cod=periodicidad.planilla_Cod and periodicidad.estado!='Reaplanificado' and periodicidad.estado!='Suspendido' and periodicidad.estado!='Replanificado' and planilla.lugartratamiento_Cod=lugartratamiento.Cod and tecnicos.Nombre='" + s + "' and periodicidad.Fecha between'" + y + "'and '" + z + "' group by fecha, NombreTratamiento, planilla.cod;";
                db.CreateCommand(sql);
                List<CheckList> ap = new List<CheckList>();
                DbDataReader result = db.Query();

                while (result.Read())
                {
                    DateTime codfech = result.GetDateTime(0);
                    string codnumero = result.GetString(1);
                    string codlugar = result.GetString(2);
                    string codservicio = result.GetString(3);
                    string codarea = result.GetString(4);
                    string codoti = result.GetString(5);                  
                    string codplano = result.GetString(6);
                    string doc = result.GetString(7) + "  " + result.GetString(8);
                    string cod = result.GetString(9);
                    CheckList a = new CheckList(codfech, codnumero, codlugar, codservicio,codarea, codoti, codplano, doc,cod);
                    ap.Add(a);

                }
                result.Close();
                db.close();
                return ap;

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


        public List<Check> InformebuscarplanillaCod(string s, string y, string z)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();              
                string sql = "select periodicidad.cod from tecnicos, servicio, cliente, periodicidad, lugartratamiento, plano inner join planilla where lugartratamiento.Cod=plano.lugartratamiento_Cod and periodicidad.tecnicos_Cod=tecnicos.Cod and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.cod=periodicidad.planilla_Cod and periodicidad.estado!='Reaplanificado' and periodicidad.estado!='Suspendido' and planilla.lugartratamiento_Cod=lugartratamiento.Cod and tecnicos.Nombre='" + s + "' and periodicidad.Fecha between'" + y + "'and '" + z + "'";
                db.CreateCommand(sql);
                List<Check> ap = new List<Check>();
                DbDataReader result = db.Query();

                while (result.Read())
                {

                    int codnumero = result.GetInt32(0);                
                    Check a = new Check(codnumero);
                    ap.Add(a);

                }
                result.Close();
                db.close();
                return ap;

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

        public List<Check> Informebuscarcheckcod(string tecnico, string iden)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();
                string sql = "select checkl.periodicidad_Cod from checkl where checkl.Tecnico='"+tecnico+"' and checkl.identificador='"+iden+"'";
                db.CreateCommand(sql);
                List<Check> ap = new List<Check>();
                DbDataReader result = db.Query();

                while (result.Read())
                {

                    int codnumero = result.GetInt32(0);
                    Check a = new Check(codnumero);
                    ap.Add(a);

                }
                result.Close();
                db.close();
                return ap;

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

        public List<Check> InformebuscarplanillaCoddeterminada(string s, string y,string w)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();
                string sql = "select periodicidad.cod from tecnicos, servicio, cliente, periodicidad, lugartratamiento, plano inner join planilla where lugartratamiento.Cod=plano.lugartratamiento_Cod and periodicidad.tecnicos_Cod=tecnicos.Cod and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.cod=periodicidad.planilla_Cod and periodicidad.estado!='Reaplanificado' and periodicidad.estado!='Suspendido' and planilla.lugartratamiento_Cod=lugartratamiento.Cod and tecnicos.Nombre='" + s + "' and periodicidad.Fecha='" + y + "'and lugartratamiento.NombreTratamiento='" + w + "';";
                db.CreateCommand(sql);
                List<Check> ap = new List<Check>();
                DbDataReader result = db.Query();

                while (result.Read())
                {

                    int codnumero = result.GetInt32(0);
                    Check a = new Check(codnumero);
                    ap.Add(a);

                }
                result.Close();
                db.close();
                return ap;

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



        public List<Informeservicioplanificacion> Informebuscarplanillarealizadosconlugar(string ini, string fin, string lugar)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();               
                string sql = "select  cliente.Nombre,lugartratamiento.NombreTratamiento,plano.CodPlano,DATE_FORMAT(fecha, '%M'), DATE_FORMAT(fecha, '%d-%m-%Y'), servicio.Sigla, periodicidad.area_cod, periodicidad.Estado,tecnicos.Nombre from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento, plano inner join planilla where lugartratamiento.Cod=plano.lugartratamiento_Cod and periodicidad.tecnicos_Cod=tecnicos.Cod and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod  and periodicidad.Fecha between'" + ini + "'and '" + fin + "' and lugartratamiento.NombreTratamiento='" + lugar + "'group by periodicidad.Fecha, periodicidad.oti,lugartratamiento.NombreTratamiento , tecnicos.Nombre, servicio.Sigla, cliente.Nombre,cliente.rut, periodicidad.consumo;";
                db.CreateCommand(sql);
                List<Informeservicioplanificacion> ap = new List<Informeservicioplanificacion>();
                DbDataReader result = db.Query();
                while (result.Read())
                {
                    string cli = result.GetString(0);
                    string lug = result.GetString(1);
                    string plano = result.GetString(2);
                    string mes = result.GetString(3);
                    string fecha = result.GetString(4);
                    string servicio = result.GetString(5);
                    string area = result.GetString(6);
                    string estado = result.GetString(7);
                    string tec = result.GetString(8);                   
                    Informeservicioplanificacion a = new Informeservicioplanificacion(cli, lug, plano, mes, fecha, servicio, area, estado, tec);
                    ap.Add(a);

                }
                result.Close();
                db.close();
                return ap;

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


        public List<Informeservicioplanificacion> Informebuscarplanillarealizadossincliente(string ini, string fin)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();               
                string sql = "select  cliente.Nombre,lugartratamiento.NombreTratamiento,plano.CodPlano,DATE_FORMAT(fecha, '%M'), DATE_FORMAT(fecha, '%d-%m-%Y'),servicio.Sigla, periodicidad.area_cod, periodicidad.Estado,tecnicos.Nombre from tecnicos, servicio, cliente, periodicidad, lugartratamiento, plano inner join planilla where lugartratamiento.Cod=plano.lugartratamiento_Cod and periodicidad.tecnicos_Cod=tecnicos.Cod and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod  and periodicidad.Fecha between'" + ini + "'and '" + fin + "'group by periodicidad.Fecha,tecnicos.Nombre, periodicidad.oti,lugartratamiento.NombreTratamiento , servicio.Sigla, cliente.Nombre,cliente.rut, periodicidad.consumo ;";
                db.CreateCommand(sql);
                List<Informeservicioplanificacion> ap = new List<Informeservicioplanificacion>();
                DbDataReader result = db.Query();


                while (result.Read())
                {
                    string cli = result.GetString(0);
                    string lug = result.GetString(1);
                    string plano = result.GetString(2);
                    string mes = result.GetString(3);
                    string fecha = result.GetString(4);
                    string servicio = result.GetString(5);
                    string area = result.GetString(6);
                    string estado = result.GetString(7);
                    string tec = result.GetString(8);                    
                    Informeservicioplanificacion a = new Informeservicioplanificacion(cli, lug, plano, mes, fecha, servicio, area, estado, tec);
                    ap.Add(a);

                }
                result.Close();
                db.close();
                return ap;

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



        public List<Informeservicioplanificacion> Informebuscarplanillarealizadosconcliente(string ini, string fin, string cliente)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();              
                string sql = "select  cliente.Nombre,lugartratamiento.NombreTratamiento,plano.CodPlano,DATE_FORMAT(fecha, '%M'), DATE_FORMAT(fecha, '%d-%m-%Y'),servicio.Sigla, periodicidad.area_cod, periodicidad.Estado,tecnicos.Nombre from tecnicos, servicio, cliente, periodicidad, lugartratamiento, plano inner join planilla where lugartratamiento.Cod=plano.lugartratamiento_Cod and periodicidad.tecnicos_Cod=tecnicos.Cod and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod  and periodicidad.Fecha between'" + ini + "'and '" + fin + "' and cliente.nombre='" + cliente + "'group by periodicidad.Fecha, periodicidad.oti,lugartratamiento.NombreTratamiento , tecnicos.Nombre, servicio.Sigla, cliente.Nombre,cliente.rut, periodicidad.consumo  ;";
                db.CreateCommand(sql);
                List<Informeservicioplanificacion> ap = new List<Informeservicioplanificacion>();
                DbDataReader result = db.Query();


                while (result.Read())
                {
                    string cli = result.GetString(0);
                    string lug = result.GetString(1);
                    string plano = result.GetString(2);
                    string mes = result.GetString(3);
                    string fecha = result.GetString(4);
                    string servicio = result.GetString(5);
                    string area = result.GetString(6);
                    string estado = result.GetString(7);
                    string tec = result.GetString(8);                   
                    Informeservicioplanificacion a = new Informeservicioplanificacion(cli, lug, plano, mes, fecha, servicio, area, estado, tec);
                    ap.Add(a);

                }
                result.Close();
                db.close();
                return ap;

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




        public List<InformeLugaresSPlanificacion> InformebuscarLugaresSPlanificacion(string clasi, string ini, string fin)
        {
            try
            {
                DataAccess.DataBase db = new DataBase();
                db.connect();
                string sql = "Select cliente.Clasificacion,cliente.Nombre, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Estado  from  periodicidad inner join lugartratamiento on lugartratamiento.Cod not in (select planilla.LugarTratamiento_Cod from planilla, periodicidad where fecha between '"+ini+"' and '"+fin+"' and periodicidad.Planilla_Cod=planilla.Cod) inner join cliente on cliente.Clasificacion='"+clasi+"' and cliente.Cod=lugartratamiento.Cliente_Cod  inner join plano on plano.LugarTratamiento_Cod=lugartratamiento.Cod group by plano.CodPlano order by NombreTratamiento;";
                db.CreateCommand(sql);
                List<InformeLugaresSPlanificacion> ap = new List<InformeLugaresSPlanificacion>();
                DbDataReader result = db.Query();
                while (result.Read())
                {
                    string cla = result.GetString(0);
                    string nom = result.GetString(1);
                    string lug = result.GetString(2);
                    string plano = result.GetString(3);
                    string estado = result.GetString(4);                 
                    InformeLugaresSPlanificacion a = new InformeLugaresSPlanificacion(cla, nom, lug, plano,estado);
                    ap.Add(a);
                }
                result.Close();
                db.close();
                return ap;

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


        public List<InformeLugaresSPlanificacion> InformebuscarLugaresSPlanificacionAño(string ini, string clasi)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();
                string sql = " Select cliente.Clasificacion,cliente.Nombre, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Estado  from  periodicidad inner join lugartratamiento on lugartratamiento.Cod not in (select planilla.LugarTratamiento_Cod from planilla, periodicidad where year(fecha)='"+ini+"' and periodicidad.Planilla_Cod=planilla.Cod) inner join cliente on cliente.Clasificacion='"+clasi+"' and cliente.Cod=lugartratamiento.Cliente_Cod  inner join plano on plano.LugarTratamiento_Cod=lugartratamiento.Cod group by plano.CodPlano order by NombreTratamiento;";
                db.CreateCommand(sql);
                List<InformeLugaresSPlanificacion> ap = new List<InformeLugaresSPlanificacion>();
                DbDataReader result = db.Query();



                while (result.Read())
                {
                    string cla = result.GetString(0);
                    string nom = result.GetString(1);
                    string lug = result.GetString(2);
                    string plano = result.GetString(3);
                    string estado = result.GetString(4);



                    InformeLugaresSPlanificacion a = new InformeLugaresSPlanificacion(cla, nom, lug, plano, estado);
                    ap.Add(a);

                }
                result.Close();
                db.close();
                return ap;

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
        public List<Periodicidad> obtenerCodIndividual(string fecha, string codplanilla, string codservicio)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();              
                string sql = "select periodicidad.Cod from periodicidad, servicio  inner join cliente where periodicidad.Fecha='" + fecha + "' and periodicidad.Planilla_Cod='" + codplanilla + "' and periodicidad.Servicio_Cod='" + codservicio + "' group by periodicidad.cod;";
                db.CreateCommand(sql);
                List<Periodicidad> ap = new List<Periodicidad>();
                DbDataReader result = db.Query();


                while (result.Read())
                {
                    int cod = result.GetInt32(0);


                    Periodicidad a = new Periodicidad(cod);
                    ap.Add(a);

                }
                result.Close();
                db.close();
                return ap;

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



        public List<Inventariado> buscarplanilla(string s)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();              
                string sql = "select tecnicos.Nombre,lugartratamiento.ruta,periodicidad.TipoPeridodicidad, servicio.Nombre, cliente.Nombre,area.NombreArea, periodicidad.Fecha, planilla.Descripcion, periodicidad.DescripcionParticular, periodicidad.nivel from tecnicos, servicio, cliente, area, periodicidad inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and periodicidad.Area_Cod=area.Cod and periodicidad.Cod=planilla.Cod and periodicidad.planilla_Cod like '" + s + "'";
                db.CreateCommand(sql);
                List<Inventariado> ap = new List<Inventariado>();
                DbDataReader result = db.Query();

                while (result.Read())
                {
                    string codtec = result.GetString(0);
                    string ruta = result.GetString(1);
                    string tipo = result.GetString(2);
                    string codser = result.GetString(3);
                    string codcli = result.GetString(4);
                    string codrut = result.GetString(5);
                    string codlugar = result.GetString(6);
                    string area = result.GetString(7);
                    DateTime fecha = result.GetDateTime(8);
                    string descrip = result.GetString(9);
                    string codpla = result.GetString(10);
                    string descripparticular = result.GetString(11);
                    string nivel = result.GetString(12);

                    Inventariado a = new Inventariado(codtec, ruta, tipo, codser, codcli, codrut, descrip, codlugar, area, fecha, codpla, descripparticular, nivel);
                    ap.Add(a);

                }
                result.Close();
                db.close();
                return ap;

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
        public List<Periodicidad> obetenerCodPeriodi(string rut, string fecha, string cod)
        {

            DataBase bd = new DataBase();
            bd.connect();
            List<Periodicidad> units = new List<Periodicidad>();
            
            string sql = "select periodicidad.Cod from periodicidad  inner join cliente where cliente.Rut='" + rut + "'and periodicidad.Fecha='" + fecha + "' and periodicidad.Planilla_Cod='" + cod + "';";
            bd.CreateCommand(sql);

            DbDataReader result = bd.Query();

            while (result.Read())
            {
                Periodicidad u = new Periodicidad(result.GetInt32(0));
                units.Add(u);

            }
            result.Close();
            bd.close();
            return units;

        }
        public List<Periodicidad> obetenerCodPeriodiSoloTEC(string rut, string fecha, string cod,string tec)
        {

            DataBase bd = new DataBase();
            bd.connect();
            List<Periodicidad> units = new List<Periodicidad>();

            string sql = "select periodicidad.Cod from periodicidad, tecnicos  inner join cliente where cliente.Rut='" + rut + "'and periodicidad.Fecha='" + fecha + "' and periodicidad.Planilla_Cod='" + cod + "'and tecnicos.Cod='"+tec+"' and periodicidad.Tecnicos_Cod=tecnicos.Cod;";
            bd.CreateCommand(sql);

            DbDataReader result = bd.Query();

            while (result.Read())
            {
                Periodicidad u = new Periodicidad(result.GetInt32(0));
                units.Add(u);

            }
            result.Close();
            bd.close();
            return units;

        }

        public List<Periodicidad> obtenerCodPeriodiEstado(string rut, string fecha, string cod)
        {

            DataBase bd = new DataBase();
            bd.connect();
            List<Periodicidad> units = new List<Periodicidad>();
            
            string sql = "select periodicidad.cod, periodicidad.estado, periodicidad.oti  from periodicidad  inner join cliente where cliente.Rut='" + rut + "'and periodicidad.Fecha='" + fecha + "' and periodicidad.Planilla_Cod='" + cod + "';";
            bd.CreateCommand(sql);
            DbDataReader result = bd.Query();
            while (result.Read())
            {
                Periodicidad u = new Periodicidad(result.GetInt32(0), result.GetString(1), result.GetString(2));
                units.Add(u);

            }
            result.Close();
            bd.close();
            return units;

        }



        public List<Periodicidad> obtenerCodPeriodiInforme(string fecha, string lugar, string tecnico)
        {
            DataBase bd = new DataBase();
            bd.connect();
            List<Periodicidad> units = new List<Periodicidad>();

            string sql = "select  date_format(periodicidad.Fecha,'%Y/%m/%d'), periodicidad.Cod, lugartratamiento.NombreTratamiento,tecnicos.Nombre  from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento, plano inner join planilla where lugartratamiento.Cod=plano.lugartratamiento_Cod and periodicidad.tecnicos_Cod=tecnicos.Cod and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and periodicidad.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and tecnicos.Nombre='" + tecnico + "' and periodicidad.Fecha='" + fecha + "' and lugartratamiento.NombreTratamiento='" + lugar + "' group by periodicidad.Cod";
            bd.CreateCommand(sql);

            DbDataReader result = bd.Query();

            while (result.Read())
            {
                Periodicidad u = new Periodicidad(result.GetInt32(1));
                units.Add(u);

            }
            result.Close();
            bd.close();
            return units;

        }


        public List<Periodicidad> obtenerCodPeriodiInformeCheck(string fecha, string lugar, string tecnico, string cod)
        {
            DataBase bd = new DataBase();
            bd.connect();
            List<Periodicidad> units = new List<Periodicidad>();

            string sql = "select  date_format(periodicidad.Fecha,'%Y/%m/%d'), periodicidad.Cod, lugartratamiento.NombreTratamiento,tecnicos.Nombre  from tecnicos, servicio, cliente, periodicidad, lugartratamiento, plano inner join planilla where lugartratamiento.Cod=plano.lugartratamiento_Cod and periodicidad.tecnicos_Cod=tecnicos.Cod and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and tecnicos.Nombre='" + tecnico + "' and periodicidad.Fecha='" + fecha + "' and lugartratamiento.NombreTratamiento='" + lugar + "' and planilla.Cod='" + cod + "'  group by periodicidad.Cod";
            bd.CreateCommand(sql);

            DbDataReader result = bd.Query();

            while (result.Read())
            {
                Periodicidad u = new Periodicidad(result.GetInt32(1));
                units.Add(u);

            }
            result.Close();
            bd.close();
            return units;

        }
        public List<Periodicidad> obtenercodperiodiR(string fecha, string cod)
        {
            DataBase bd = new DataBase();
            bd.connect();
            List<Periodicidad> units = new List<Periodicidad>();
          
            string sql = "select periodicidad.Cod from periodicidad  inner join cliente where periodicidad.Fecha='" + fecha + "' and periodicidad.Planilla_Cod='" + cod + "' group by periodicidad.cod;";
            bd.CreateCommand(sql);

            DbDataReader result = bd.Query();

            while (result.Read())
            {
                Periodicidad u = new Periodicidad(result.GetInt32(0));
                units.Add(u);

            }
            result.Close();
            bd.close();
            return units;
        }
        public List<Periodicidad> obtenercodperiodiRPrimario(string fecha, string cod)
        {
            DataBase bd = new DataBase();
            bd.connect();
            List<Periodicidad> units = new List<Periodicidad>();

            string sql = "select periodicidad.Cod from periodicidad  inner join cliente where periodicidad.Fecha='" + fecha + "' and periodicidad.Planilla_Cod='" + cod + "'and periodicidad.Nivel='Primario' group by periodicidad.cod;";
            bd.CreateCommand(sql);

            DbDataReader result = bd.Query();

            while (result.Read())
            {
                Periodicidad u = new Periodicidad(result.GetInt32(0));
                units.Add(u);
            }
            result.Close();
            bd.close();
            return units;
        }

        public List<Periodicidad> obtenercodperiodiwherePlanilla(string codpla)
        {

            DataBase bd = new DataBase();
            bd.connect();
            List<Periodicidad> units = new List<Periodicidad>();
          
            string sql = "select periodicidad.Cod from periodicidad inner join planilla where planilla.cod = '" + codpla + "' and periodicidad.Planilla_Cod=planilla.Cod;";
            bd.CreateCommand(sql);

            DbDataReader result = bd.Query();

            while (result.Read())
            {
                Periodicidad u = new Periodicidad(result.GetInt32(0));
                units.Add(u);

            }
            result.Close();
            bd.close();
            return units;

        }



        public void agregarEstdo(Estado ac)
        {
            try
            {
                DataAccess.DataBase bd = new DataAccess.DataBase();
                bd.connect();
                string sql = "insert into Estado values('" + ac.COD + "','" + ac.ESTADO + "','" + ac.PERICOD + "')";
                bd.CreateCommand(sql);
                bd.execute();
                bd.close();
            }
            catch (DataAccess.DataAccessException ex)
            {
                throw new BussinessRulesException(ex.Message);
            }
        }



        public void modObs(Periodicidad ac)
        {
            try
            {
                DataAccess.DataBase db = new DataBase();
                db.connect();
                string sql = "update periodicidad set Oti='" + ac.Oti + "'where cod='" + ac.Codperi + "';";

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

        public void modiObs(Planilla ad)
        {


            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();
                string sql = "update planilla set Descripcion='" + ad.Descripcion + "'where cod='" + ad.Cod + "';";

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

        public void modiObsParticulares(Periodicidad ad)
        {


            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();
                string sql = "update periodicidad set DescripcionParticular='" + ad.Observaciones + "'where cod='" + ad.Codperi + "';";

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

        public void borrarSuspen(Periodicidad ad)
        {


            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();
                string sql = "delete from periodicidad where Planilla_Cod='" + ad.Codperi + "'and periodicidad.servicio_cod='"+ad.Estado+"' and periodicidad.Fecha >'" + ad.Fecha + "';";

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

        public void borrarRDips(Periodicidad ad)
        {


            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();
                string sql = "delete from periodicidad where Planilla_Cod='" + ad.Codperi + "' and periodicidad.Fecha >'" + ad.Fecha + "';";

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

        public List<Periodicidad> obtenercodservicio(string codperiodicidad)
        {

            DataBase bd = new DataBase();
            bd.connect();
            List<Periodicidad> units = new List<Periodicidad>();

            string sql = "select servicio_cod from periodicidad where periodicidad.cod='"+codperiodicidad+"'";
            bd.CreateCommand(sql);

            DbDataReader result = bd.Query();

            while (result.Read())
            {
                Periodicidad u = new Periodicidad(result.GetInt32(0));
                units.Add(u);

            }
            result.Close();
            bd.close();
            return units;

        }
        public List<Periodicidad> obtenercodarea(string codperiodicidad)
        {
            DataBase bd = new DataBase();
            bd.connect();
            List<Periodicidad> units = new List<Periodicidad>();

            string sql = "select area_cod from periodicidad where periodicidad.cod='" + codperiodicidad + "'";
            bd.CreateCommand(sql);

            DbDataReader result = bd.Query();

            while (result.Read())
            {
                Periodicidad u = new Periodicidad(result.GetInt32(0));
                units.Add(u);

            }
            result.Close();
            bd.close();
            return units;
        }
        public List<Tecnico> obtenercodTec(string nomtec)
        {

            DataBase bd = new DataBase();
            bd.connect();
            List<Tecnico> units = new List<Tecnico>();

            string sql = "select tecnicos.cod from tecnicos where  tecnicos.Nombre='" + nomtec + "'";
            bd.CreateCommand(sql);

            DbDataReader result = bd.Query();

            while (result.Read())
            {
                Tecnico u = new Tecnico(result.GetInt32(0));
                units.Add(u);

            }
            result.Close();
            bd.close();
            return units;

        }

        public void modiTecnico(int tecnico, int cod)
        {


            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();
                string sql = "update periodicidad set tecnicos_cod='" + tecnico + "'where cod='" + cod + "';";

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

        public void modiFecha(string fecha, int cod)
        {


            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();
                string sql = "update periodicidad set fecha='" + fecha + "'where cod='" + cod + "';";

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
        public List<Periodicidad> existeClienteRegistrado(string fecha, string lugar)
        {

            DataBase bd = new DataBase();
            bd.connect();
            List<Periodicidad> units = new List<Periodicidad>();

            string sql = "select planilla.Cod from planilla,cliente,lugartratamiento, periodicidad where planilla.Cliente_Cod=Cliente.Cod and year(fecha)= '"+fecha+"' and cliente.Cod=lugartratamiento.Cliente_Cod and planilla.LugarTratamiento_Cod=lugartratamiento.Cod and lugartratamiento.NombreTratamiento='"+lugar+"' group by planilla.Cod;";
            bd.CreateCommand(sql);

            DbDataReader result = bd.Query();

            while (result.Read())
            {
                Periodicidad u = new Periodicidad(result.GetInt32(0));
                units.Add(u);

            }
            result.Close();
            bd.close();
            return units;

        }
        public List<Periodicidad> getLugarCod(string nombre)
        {
            DataBase bd = new DataBase();
            bd.connect();
            List<Periodicidad> units = new List<Periodicidad>();
            string sql = "select lugartratamiento.Cod from lugartratamiento where lugartratamiento.NombreTratamiento='"+nombre+"';";
            bd.CreateCommand(sql);
            DbDataReader result = bd.Query();
            while (result.Read())
            {
                Periodicidad u = new Periodicidad(result.GetInt32(0));
                units.Add(u);
            }
            result.Close();
            bd.close();
            return units;

        }

        public void modiNoconformidad(Periodicidad ad)
        {


            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();
                string sql = "update periodicidad set NoConformidad='" + ad.NoConformidad + "'where OTI='" + ad.Oti + "';";

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
        public List<InventarioNoConformidad> mostrarNoConformidad(string ot)
        {

            DataBase bd = new DataBase();
            bd.connect();
            List<InventarioNoConformidad> units = new List<InventarioNoConformidad>();

            string sql = "select periodicidad.NoConformidad from periodicidad where OTI='"+ot+"' group by NoConformidad";
            bd.CreateCommand(sql);

            DbDataReader result = bd.Query();

            while (result.Read())
            {
                InventarioNoConformidad u = new InventarioNoConformidad(result.GetString(0));
                units.Add(u);
               
            }
            result.Close();
            bd.close();
            return units;

        }

        public string mostrarNoConformidadString(string ot)
        {

            DataBase bd = new DataBase();
            bd.connect();

            string u = "";
            string sql = "select periodicidad.NoConformidad from periodicidad where OTI='" + ot + "' group by NoConformidad";
            bd.CreateCommand(sql);

            DbDataReader result = bd.Query();

            while (result.Read())
            {
               u = result.GetString(0);
               

            }
            result.Close();
            bd.close();
            return u;

        }
        public List<Inventariado> mostrarVacaciones(string s)
        {
            try
            {
                DataBase db = new DataBase();
                db.connect();


                String sql = "select tecnicos.Nombre,lugartratamiento.ruta,periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla order by servicio.Sigla asc), cliente.Nombre,cliente.rut, lugartratamiento.NombreTratamiento , periodicidad.Area_Cod, date_format(periodicidad.Fecha,'%Y/%m/%d'), planilla.Descripcion, planilla.cod, periodicidad.DescripcionParticular,periodicidad.nivel from tecnicos, servicio, cliente, periodicidad, lugartratamiento inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod  and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and periodicidad.Estado not like '%Replanificado%' and periodicidad.Estado not like '%Suspendido%' and year(Fecha)= '" + s + "' group by periodicidad.Fecha, lugartratamiento.NombreTratamiento,planilla.Cod,TipoPeridodicidad,tecnicos.nombre;";

                db.CreateCommand(sql);
                List<Inventariado> tec = new List<Inventariado>();
                DbDataReader result = db.Query();

                while (result.Read())
                {
                    string codtec = result.GetString(0);
                    string ruta = result.GetString(1);
                    string tipo = result.GetString(2);
                    string codser = result.GetString(3);
                    string codcli = result.GetString(4);
                    string codrut = result.GetString(5);
                    string codlugar = result.GetString(6);
                    string area = result.GetString(7);
                    DateTime fecha = result.GetDateTime(8);
                    string descrip = result.GetString(9);
                    string codpla = result.GetString(10);
                    string descripparticular = result.GetString(11);
                    string nivel = result.GetString(12);

                    Inventariado a = new Inventariado(codtec, ruta, tipo, codser, codcli, codrut, descrip, codlugar, area, fecha, codpla, descripparticular, nivel);
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