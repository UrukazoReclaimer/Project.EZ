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
                string sql = "insert into planilla values('"+ac.Cod+"','"+ ac.CliRut +"','"+ac.Cod+"','"+ac.Descripcion+"','"+ac.Clicod+"','"+ac.LugarCod+ "')";
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
/*
        public void addplanilla(Planilla ac)
        {
            try
            {
                DataAccess.DataBase bd = new DataAccess.DataBase();
                bd.connect();
                string sql = "insert into planilla values('" + ac.Cod + "','" + ac.CliRut + "','" + ac.Consumo + "','" + ac.Cod + "','" + ac.Descripcion + "','" + ac.Clicod + "','" + ac.LugarCod + "')";
                bd.CreateCommand(sql);
                bd.execute();
                bd.close();
            }
            catch (DataAccess.DataAccessException ex)
            {
                throw new BussinessRulesException(ex.Message);
            }
        }
*/
        public void removePlanilla(string cliente, string area)
        {

            DataAccess.DataBase db = new DataAccess.DataBase();

            db.connect();

            string sql = "delete from planilla WHERE  =Cliente_Rut'" + cliente + "',and Area=" + area;

            db.CreateCommand(sql);

            db.execute();

            db.close();



        }
        public void removePeriodidicad(string cod)
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
             //   string sql = "update periodicidad set Estado='" + ac.Estado + "'where cod='" + ac.Codperi + "'and fecha='"+ac.Fecha+"';";
                string sql = "update periodicidad set Estado='" + ac.Estado + "'where cod='" + ac.Codperi +"';";

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
        //Hoooooooo

        public void modFecha(Periodicidad ac)
        {

            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();
                string sql = "update periodicidad set Fecha='" + ac.Fecha + "'where cod='" + ac.Codperi +"';";

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
                string sql = "update periodicidad set Tecnicos_Cod='" + ac.Codtec + "'where cod='" + ac.Codperi +"';";

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
                string sql = "update periodicidad set consumo='" + ac.Consumo + "'where cod='" + ac.Codperi + "'and fecha='" + ac.Fecha + "'and oti='"+ac.Oti+"';";

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
            //puede ser un condicion where
            string sql = "select periodicidad.Cod,periodicidad.Fecha,periodicidad.planilla_Cod from planilla,periodicidad,cliente,lugartratamiento  where planilla.Cod=periodicidad.planilla_Cod and lugartratamiento.CodNT=cliente.Cod  and cliente.Rut=planilla.Cliente_Rut and cliente.LugardeTratamiento='" + s + "';";
            bd.CreateCommand(sql);

            DbDataReader result = bd.Query();

            while (result.Read())
            {
                Periodicidad u = new Periodicidad(result.GetInt32(0), result.GetString(1),result.GetInt32(2));
                units.Add(u);

            }
            result.Close();
            bd.close();
            return units;

        }

        /**
         
        public List<Periodicidad> getcodfech(string s)
        {

            DataBase bd = new DataBase();
            bd.connect();
            List<Periodicidad> units = new List<Periodicidad>();
            //puede ser un condicion where
            string sql = "select periodicidad.planilla_Cod from planilla,periodicidad,cliente,lugartratamiento  where planilla.Cod=periodicidad.planilla_Cod and cliente.LugardeTratamiento=lugartratamiento.NombreTratamiento and cliente.Rut=planilla.Cliente_Rut and cliente.LugardeTratamiento='" + s + "' group by planilla_cod";
            //string sql = "select periodicidad.Cod,periodicidad.Fecha,periodicidad.planilla_Cod from planilla,periodicidad,cliente,lugartratamiento  where planilla.Cod=periodicidad.planilla_Cod and cliente.LugardeTratamiento=lugartratamiento.NombreTratamiento and cliente.Rut=planilla.Cliente_Rut and cliente.LugardeTratamiento='" + s + "';";
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
        **/
      

        public List<Periodicidad> getcodfech()
        {

            DataBase bd = new DataBase();
            bd.connect();
            List<Periodicidad> units = new List<Periodicidad>();
            //puede ser un condicion where
            string sql = "select ifnull(MAX(planilla.cod),0) from planilla inner join lugartratamiento where planilla.Cliente_Rut=Lugartratamiento.cliente_rut ;";
            //string sql = "select periodicidad.Cod,periodicidad.Fecha,periodicidad.planilla_Cod from planilla,periodicidad,cliente,lugartratamiento  where planilla.Cod=periodicidad.planilla_Cod and cliente.LugardeTratamiento=lugartratamiento.NombreTratamiento and cliente.Rut=planilla.Cliente_Rut and cliente.LugardeTratamiento='" + s + "';";
            bd.CreateCommand(sql);

            DbDataReader result = bd.Query();

            while (result.Read())
            {
                if (result.GetInt32(0)!=0)
                {
                    Periodicidad u = new Periodicidad(result.GetInt32(0));
                    units.Add(u);
                }
                else
                {
                   // result.Close();
                    //bd.close();
                }

            }
            result.Close();
            bd.close();
            return units;

        }


/**
        public List<Periodicidad> getcodfech(string s)
        {

            DataBase bd = new DataBase();
            bd.connect();
            List<Periodicidad> units = new List<Periodicidad>();
            //puede ser un condicion where
            string sql = "select periodicidad.planilla_Cod from planilla,periodicidad,cliente,lugartratamiento  where planilla.Cod=periodicidad.planilla_Cod and cliente.LugardeTratamiento=lugartratamiento.NombreTratamiento and cliente.Rut=planilla.Cliente_Rut and cliente.LugardeTratamiento='" + s + "' group by planilla_cod";
            //string sql = "select periodicidad.Cod,periodicidad.Fecha,periodicidad.planilla_Cod from planilla,periodicidad,cliente,lugartratamiento  where planilla.Cod=periodicidad.planilla_Cod and cliente.LugardeTratamiento=lugartratamiento.NombreTratamiento and cliente.Rut=planilla.Cliente_Rut and cliente.LugardeTratamiento='" + s + "';";
            bd.CreateCommand(sql);

            DbDataReader result = bd.Query();

            while (result.Read())
            {
                Periodicidad u = new Periodicidad(result.GetInt32(0),result.GetString(1),result.GetInt32(2));
                units.Add(u);

            }
            result.Close();
            bd.close();
            return units;

        }

        **/


    
        public void addfecha(Periodicidad ac)
        {
            try
            {
                DataAccess.DataBase bd = new DataAccess.DataBase();
                bd.connect();
                string sql = "insert into periodicidad values('" + ac.Codperi + "','" + ac.Fecha + "','" + ac.Cod +  "','"+ac.Codser+"','"+ac.Codtec+"','"+ac.Codarea+"','"+ac.Oti+"','"+ac.Consumo+"','"+ac.Tperiodicidad+"','"+ac.Estado+"','"+ac.Observaciones+"')";
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
                 string sql = "update periodicidad  set periodicidad.Tecnicos_Cod='"+ac.Codtec+"' Where periodicidad.Planilla_Cod='"+ac.Codpla+"' and periodicidad.Fecha= '"+ac.Fecha+"' ;";

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

        //    public void modiPla(Planilla ad)
        //    {


        //       try
        //      {

        //          DataAccess.DataBase db = new DataBase();
        //          db.connect();
        //          string sql = "update planilla set Tecnicos_Cod='" + ad.TecCod + "',Sevicio_Cod='" + ad.SerCod + "',Cliente_Cod='" + ad.CliCod + "',Mes='" + ad.Mes + "',Dia='" + ad.Dia + "'where Servicio_Cod='" + ad.SerCod + "';";

        //         db.CreateCommand(sql);

        //         db.execute();
        //         db.close();
        //     }
        //    catch (DataAccess.DataAccessException ex)
        //    {
        //        throw new BussinessRulesException(ex.Message, ex.InnerException);

        //    }
        //    catch (Exception ex)
        //    {

        //        throw new BussinessRulesException(ex.Message);
        //    }

        //  }

        public List<Inventariado> mostrarplanilla(string s)
        {
            try
            {
                DataBase db = new DataBase();
                db.connect();

            
                String sql = "select tecnicos.Nombre,lugartratamiento.ruta,periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), cliente.Nombre,cliente.rut, lugartratamiento.NombreTratamiento , group_concat(distinct area.NombreArea), date_format(periodicidad.Fecha,'%Y/%m/%d'), planilla.Descripcion, planilla.cod, periodicidad.DescripcionParticular from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and periodicidad.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and year(Fecha)= '" + s + "' group by periodicidad.Fecha, lugartratamiento.NombreTratamiento;";
              
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

                    Inventariado a = new Inventariado(codtec,ruta,tipo,codser,codcli,codrut,descrip,codlugar,area,fecha,codpla,descripparticular);
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
                String sql = "select tecnicos.Nombre,lugartratamiento.ruta,periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), cliente.Nombre,cliente.rut, lugartratamiento.NombreTratamiento , group_concat(distinct area.NombreArea), periodicidad.Fecha, planilla.Descripcion, planilla.cod , periodicidad.DescripcionParticular from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and periodicidad.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and cliente.Nombre like '%" + s + "%' and periodicidad.Fecha between '" + y + "'and '" + z + "' group by periodicidad.Fecha, planilla.Cod,lugartratamiento.NombreTratamiento;";

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


                    Inventariado a = new Inventariado(codtec, ruta, tipo, codser, codcli, codrut, descrip, codlugar, area, fecha, codpla,descripparticular);
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


                String sql = "select tecnicos.Nombre,lugartratamiento.ruta,periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), cliente.Nombre,cliente.rut, lugartratamiento.NombreTratamiento , group_concat(distinct area.NombreArea), periodicidad.Fecha, planilla.Descripcion, planilla.cod , periodicidad.DescripcionParticular from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and periodicidad.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and lugartratamiento.nombretratamiento = '" + s + "' and periodicidad.Fecha between '" + y + "'and '" + z + "' group by periodicidad.Fecha, lugartratamiento.NombreTratamiento;";

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


                    Inventariado a = new Inventariado(codtec, ruta, tipo, codser, codcli, codrut, descrip, codlugar, area, fecha, codpla, descripparticular);
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

        public List<InventariadoR>  mostrarplanillaR(string s)
        {
            try
            {
                DataBase db = new DataBase();
                db.connect();

                //OJO esta estado metido
           //    String sql = "select tecnicos.Nombre, group_concat(distinct servicio.Sigla), cliente.Nombre,cliente.rut, planilla.consumo, lugartratamiento.NombreTratamiento , group_concat(distinct area.NombreArea), periodicidad.Fecha, planilla.Descripcion, planilla.cod, periodicidad.oti from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod  and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and periodicidad.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod group by periodicidad.Fecha, lugartratamiento.NombreTratamiento;";
                String sql = "select tecnicos.Nombre,lugartratamiento.ruta,periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), cliente.Nombre,cliente.rut, periodicidad.consumo, lugartratamiento.NombreTratamiento , group_concat(distinct area.NombreArea), date_format(periodicidad.Fecha,'%Y/%m/%d'), planilla.Descripcion, planilla.cod, periodicidad.oti, periodicidad.Estado from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod  and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and periodicidad.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and year(Fecha)= '" + s + "' group by periodicidad.Fecha, periodicidad.oti,lugartratamiento.NombreTratamiento , tecnicos.Nombre, servicio.Sigla, cliente.Nombre,cliente.rut, periodicidad.consumo;";
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

                   // InventariadoR a = new InventariadoR(codtec, codser, codcli, codrut, codcon, descrip, codlugar, area, fecha, codpla,oti, estado);
                    InventariadoR a = new InventariadoR(codtec,ruta,codtipo, codser, codcli, codrut, codcon, descrip, codlugar, area, fecha, codpla, oti, estado);
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

        public List<InventariadoR> mostrarplanillaRRealizados(string s)
        {
            try
            {
                DataBase db = new DataBase();
                db.connect();

                //OJO esta estado metido
                //    String sql = "select tecnicos.Nombre, group_concat(distinct servicio.Sigla), cliente.Nombre,cliente.rut, planilla.consumo, lugartratamiento.NombreTratamiento , group_concat(distinct area.NombreArea), periodicidad.Fecha, planilla.Descripcion, planilla.cod, periodicidad.oti from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod  and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and periodicidad.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod group by periodicidad.Fecha, lugartratamiento.NombreTratamiento;";
            //    String sql = "select tecnicos.Nombre,lugartratamiento.ruta,periodicidad.TipoPeridodicidad,  servicio.Sigla, cliente.Nombre,cliente.rut, periodicidad.consumo, lugartratamiento.NombreTratamiento , group_concat(distinct area.NombreArea), date_format(periodicidad.Fecha,'%Y/%m/%d'), planilla.Descripcion, planilla.cod, periodicidad.oti, periodicidad.Estado from estado, tecnicos, servicio, cliente, area, periodicidad, lugartratamiento inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod  and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and periodicidad.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and estado.periodicidad_cod=periodicidad.cod and periodicidad.estado='Realizado' group by Fecha, NombreTratamiento;";
                String sql = "select tecnicos.Nombre,lugartratamiento.ruta,periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), cliente.Nombre,cliente.rut, periodicidad.consumo, lugartratamiento.NombreTratamiento , group_concat(distinct area.NombreArea), date_format(periodicidad.Fecha,'%Y/%m/%d'), planilla.Descripcion, planilla.cod, periodicidad.oti, periodicidad.Estado from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod  and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and periodicidad.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and periodicidad.Estado='Realizado' and cliente.Nombre='"+s+"' group by periodicidad.Fecha, periodicidad.oti,lugartratamiento.NombreTratamiento , tecnicos.Nombre, servicio.Sigla, cliente.Nombre,cliente.rut, periodicidad.consumo;";
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

                    // InventariadoR a = new InventariadoR(codtec, codser, codcli, codrut, codcon, descrip, codlugar, area, fecha, codpla,oti, estado);
                    InventariadoR a = new InventariadoR(codtec, ruta, codtipo, codser, codcli, codrut, codcon, descrip, codlugar, area, fecha, codpla, oti, estado);
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


        public List<InventariadoR> mostrarplanillaRARealizar(string s)
        {
            try
            {
                DataBase db = new DataBase();
                db.connect();

                //OJO esta estado metido
                //    String sql = "select tecnicos.Nombre, group_concat(distinct servicio.Sigla), cliente.Nombre,cliente.rut, planilla.consumo, lugartratamiento.NombreTratamiento , group_concat(distinct area.NombreArea), periodicidad.Fecha, planilla.Descripcion, planilla.cod, periodicidad.oti from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod  and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and periodicidad.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod group by periodicidad.Fecha, lugartratamiento.NombreTratamiento;";
              //  String sql = "select tecnicos.Nombre,lugartratamiento.ruta,periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), cliente.Nombre,cliente.rut, periodicidad.consumo, lugartratamiento.NombreTratamiento , group_concat(distinct area.NombreArea), date_format(periodicidad.Fecha,'%Y/%m/%d'), planilla.Descripcion, planilla.cod, periodicidad.oti, periodicidad.Estado from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod  and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and periodicidad.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and periodicidad.Estado='P' group by periodicidad.Fecha, periodicidad.oti,lugartratamiento.NombreTratamiento , tecnicos.Nombre, servicio.Sigla, cliente.Nombre,cliente.rut, periodicidad.consumo;";
                String sql = "select tecnicos.Nombre,lugartratamiento.ruta,periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), cliente.Nombre,cliente.rut, periodicidad.consumo, lugartratamiento.NombreTratamiento , group_concat(distinct area.NombreArea), date_format(periodicidad.Fecha,'%Y/%m/%d'), planilla.Descripcion, planilla.cod, periodicidad.oti, periodicidad.Estado from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod  and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and periodicidad.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and periodicidad.Estado='P' and cliente.Nombre='"+s+"' group by periodicidad.Fecha, periodicidad.oti,lugartratamiento.NombreTratamiento , tecnicos.Nombre, servicio.Sigla, cliente.Nombre,cliente.rut, periodicidad.consumo";
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

                    // InventariadoR a = new InventariadoR(codtec, codser, codcli, codrut, codcon, descrip, codlugar, area, fecha, codpla,oti, estado);
                    InventariadoR a = new InventariadoR(codtec, ruta, codtipo, codser, codcli, codrut, codcon, descrip, codlugar, area, fecha, codpla, oti, estado);
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


        public List<InventariadoR> mostrarplanillaRNORealizados(string s)
        {
            try
            {
                DataBase db = new DataBase();
                db.connect();

                //OJO esta estado metido
                //    String sql = "select tecnicos.Nombre, group_concat(distinct servicio.Sigla), cliente.Nombre,cliente.rut, planilla.consumo, lugartratamiento.NombreTratamiento , group_concat(distinct area.NombreArea), periodicidad.Fecha, planilla.Descripcion, planilla.cod, periodicidad.oti from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod  and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and periodicidad.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod group by periodicidad.Fecha, lugartratamiento.NombreTratamiento;";
                String sql = "select tecnicos.Nombre,lugartratamiento.ruta,periodicidad.TipoPeridodicidad,  servicio.Sigla, cliente.Nombre,cliente.rut, periodicidad.consumo, lugartratamiento.NombreTratamiento , group_concat(distinct area.NombreArea), date_format(periodicidad.Fecha,'%Y/%m/%d'), planilla.Descripcion, planilla.cod, periodicidad.oti, periodicidad.Estado from estado, tecnicos, servicio, cliente, area, periodicidad, lugartratamiento inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod  and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and periodicidad.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and estado.periodicidad_cod=periodicidad.cod and periodicidad.estado='No Realizado' group by Fecha, NombreTratamiento;";
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

                    // InventariadoR a = new InventariadoR(codtec, codser, codcli, codrut, codcon, descrip, codlugar, area, fecha, codpla,oti, estado);
                    InventariadoR a = new InventariadoR(codtec, ruta, codtipo, codser, codcli, codrut, codcon, descrip, codlugar, area, fecha, codpla, oti, estado);
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





        public List<InventariadoR> mostrarplanillaRSuspendidos(string s)
        {
            try
            {
                DataBase db = new DataBase();
                db.connect();

                //OJO esta estado metido
                //    String sql = "select tecnicos.Nombre, group_concat(distinct servicio.Sigla), cliente.Nombre,cliente.rut, planilla.consumo, lugartratamiento.NombreTratamiento , group_concat(distinct area.NombreArea), periodicidad.Fecha, planilla.Descripcion, planilla.cod, periodicidad.oti from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod  and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and periodicidad.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod group by periodicidad.Fecha, lugartratamiento.NombreTratamiento;";
                String sql = "select tecnicos.Nombre,lugartratamiento.ruta,periodicidad.TipoPeridodicidad,  servicio.Sigla, cliente.Nombre,cliente.rut, periodicidad.consumo, lugartratamiento.NombreTratamiento , group_concat(distinct area.NombreArea), date_format(periodicidad.Fecha,'%Y/%m/%d'), planilla.Descripcion, planilla.cod, periodicidad.oti, periodicidad.Estado from estado, tecnicos, servicio, cliente, area, periodicidad, lugartratamiento inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod  and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and periodicidad.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and estado.periodicidad_cod=periodicidad.cod and periodicidad.estado='Suspendido' group by Fecha, NombreTratamiento;";
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

                    // InventariadoR a = new InventariadoR(codtec, codser, codcli, codrut, codcon, descrip, codlugar, area, fecha, codpla,oti, estado);
                    InventariadoR a = new InventariadoR(codtec, ruta, codtipo, codser, codcli, codrut, codcon, descrip, codlugar, area, fecha, codpla, oti, estado);
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


                //    String sql = "select tecnicos.Nombre, group_concat(distinct servicio.Sigla), cliente.Nombre,cliente.rut, planilla.consumo, lugartratamiento.NombreTratamiento , group_concat(distinct area.NombreArea), periodicidad.Fecha, planilla.Descripcion, planilla.cod, periodicidad.oti from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod  and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and periodicidad.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod group by periodicidad.Fecha, lugartratamiento.NombreTratamiento;";
                String sql = "select tecnicos.Nombre,lugartratamiento.ruta,periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), cliente.Nombre,cliente.rut, periodicidad.consumo, lugartratamiento.NombreTratamiento , group_concat(distinct area.NombreArea), date_format(periodicidad.Fecha,'%Y/%m/%d'), planilla.Descripcion, planilla.cod, periodicidad.oti, periodicidad.estado from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod  and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and periodicidad.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and cliente.nombre like '%" + s + "%' and periodicidad.Fecha between '" + y + "'and '" + z + "' group by periodicidad.Fecha, periodicidad.oti,lugartratamiento.NombreTratamiento , tecnicos.Nombre, servicio.Sigla, cliente.Nombre,cliente.rut;";
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

                    // InventariadoR a = new InventariadoR(codtec, codser, codcli, codrut, codcon, descrip, codlugar, area, fecha, codpla,oti, estado);
                    InventariadoR a = new InventariadoR(codtec, ruta, codtipo, codser, codcli, codrut, codcon, descrip, codlugar, area, fecha, codpla, oti, estado);
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


                //    String sql = "select tecnicos.Nombre, group_concat(distinct servicio.Sigla), cliente.Nombre,cliente.rut, planilla.consumo, lugartratamiento.NombreTratamiento , group_concat(distinct area.NombreArea), periodicidad.Fecha, planilla.Descripcion, planilla.cod, periodicidad.oti from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod  and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and periodicidad.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod group by periodicidad.Fecha, lugartratamiento.NombreTratamiento;";
                String sql = "select tecnicos.Nombre,lugartratamiento.ruta,periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), cliente.Nombre,cliente.rut, periodicidad.consumo, lugartratamiento.NombreTratamiento , group_concat(distinct area.NombreArea), date_format(periodicidad.Fecha,'%Y/%m/%d'), planilla.Descripcion, planilla.cod, periodicidad.oti, periodicidad.estado from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod  and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and periodicidad.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and lugartratamiento.nombretratamiento = '" + s + "' and periodicidad.Fecha between '" + y + "'and '" + z + "' group by periodicidad.Fecha, periodicidad.oti,lugartratamiento.NombreTratamiento , tecnicos.Nombre, servicio.Sigla, cliente.Nombre,cliente.rut;";
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

                    // InventariadoR a = new InventariadoR(codtec, codser, codcli, codrut, codcon, descrip, codlugar, area, fecha, codpla,oti, estado);
                    InventariadoR a = new InventariadoR(codtec, ruta, codtipo, codser, codcli, codrut, codcon, descrip, codlugar, area, fecha, codpla, oti, estado);
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


                //    String sql = "select tecnicos.Nombre, group_concat(distinct servicio.Sigla), cliente.Nombre,cliente.rut, planilla.consumo, lugartratamiento.NombreTratamiento , group_concat(distinct area.NombreArea), periodicidad.Fecha, planilla.Descripcion, planilla.cod, periodicidad.oti from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod  and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and periodicidad.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod group by periodicidad.Fecha, lugartratamiento.NombreTratamiento;";
                String sql = "select tecnicos.Nombre,lugartratamiento.ruta,periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), cliente.Nombre,cliente.rut, periodicidad.consumo, lugartratamiento.NombreTratamiento , group_concat(distinct area.NombreArea), date_format(periodicidad.Fecha,'%Y/%m/%d'), planilla.Descripcion, planilla.cod, periodicidad.oti, periodicidad.estado from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and periodicidad.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and periodicidad.Fecha between '" + s + "' and '" + y + "'group by periodicidad.Fecha, periodicidad.oti,lugartratamiento.NombreTratamiento , tecnicos.Nombre, servicio.Sigla, cliente.Nombre,cliente.rut;";
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

                    // InventariadoR a = new InventariadoR(codtec, codser, codcli, codrut, codcon, descrip, codlugar, area, fecha, codpla,oti, estado);
                    InventariadoR a = new InventariadoR(codtec, ruta, codtipo, codser, codcli, codrut, codcon, descrip, codlugar, area, fecha, codpla, oti, estado);
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
                String sql = "select tecnicos.Nombre,lugartratamiento.ruta,periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), cliente.Nombre,cliente.rut, lugartratamiento.NombreTratamiento , group_concat(distinct area.NombreArea), date_format(periodicidad.Fecha,'%Y/%m/%d'), planilla.Descripcion, planilla.cod, periodicidad.DescripcionParticular from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and periodicidad.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and periodicidad.Fecha between '" + s + "' and '" + y + "' group by periodicidad.Fecha, lugartratamiento.NombreTratamiento";
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


                        Inventariado a = new Inventariado(codtec, ruta, tipo, codser, codcli, codrut, descrip, codlugar, area, fecha, codpla, descripparticular);
                        tec.Add(a);

                    }
                    //}
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
               // String sql = "select tecnicos.Nombre, group_concat(distinct servicio.Sigla), cliente.Nombre,cliente.rut, planilla.consumo, lugartratamiento.NombreTratamiento , group_concat(distinct area.NombreArea), periodicidad.Fecha, planilla.Descripcion from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento, planilla where cliente.nombre like'" + s + "'";
                //falta el coooooooooooooooooooooooooood
               // string sql = "select ifnull(tecnicos.Nombre,''),ifnull(group_concat(distinct servicio.Sigla),''), ifnull(cliente.Nombre,''), ifnull(cliente.rut,''), ifnull(planilla.consumo,''), ifnull(lugartratamiento.NombreTratamiento,''), ifnull(group_concat(distinct area.NombreArea),''), ifnull(periodicidad.Fecha,''), ifnull(planilla.Descripcion,''), from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento, planilla where planilla.Cliente_Cod=cliente.Cod and cliente.nombre like '%"+s+"%' and planilla.Cod=periodicidad.Planilla_Cod and lugartratamiento.Cliente_Cod = cliente.cod and periodicidad.Servicio_Cod=servicio.Cod and periodicidad.Area_Cod=area.Cod;";
                string sql = " select tecnicos.Nombre,lugartratamiento.ruta,periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), cliente.Nombre,cliente.rut, lugartratamiento.NombreTratamiento , group_concat(distinct area.NombreArea), periodicidad.Fecha, planilla.Descripcion, planilla.cod, periodicidad.DescripcionParticular from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and periodicidad.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and cliente.Nombre like '%" + s + "%' group by periodicidad.Fecha, lugartratamiento.NombreTratamiento;";
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


                    Inventariado a = new Inventariado(codtec, ruta, tipo, codser, codcli, codrut, descrip, codlugar, area, fecha, codpla, descripparticular);
                    tec.Add(a);

                }
                //}
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
            //puede ser un condicion where
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

        public List<LugarTratamiento> allgetlugar()
        {

            DataBase bd = new DataBase();
            bd.connect();
            List<LugarTratamiento> units = new List<LugarTratamiento>();
            //puede ser un condicion where
            string sql = "select * from lugartratamiento;";
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
            //puede ser un condicion where
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

                //   string sql = "select cliente.Rut,tecnicos.Nombre,servicio.Nombre,planilla.Consumo,cliente.Nombre,lugartratamiento.Nom{ñ3breTratamiento,planilla.Area,periodicidad.Fecha from cliente,tecnicos,servicio,lugartratamiento,periodicidad inner join planilla where tecnicos.Cod=planilla.Tecnicos_Cod and cliente.Rut=planilla.Cliente_Rut and servicio.Cod=planilla.Servicio_Cod and lugartratamiento.Rut=planilla.Cliente_Rut and lugartratamiento.NombreTratamiento=cliente.LugardeTratamiento and periodicidad.planilla_Cod=planilla.Cod and periodicidad.planilla_Cod like'"+s+"'";
               // string sql = "select  Fecha, planilla.numero, lugartratamiento.NombreTratamiento, group_concat(distinct servicio.Sigla),plano.codplano  from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento, plano inner join planilla where lugartratamiento.Cod=plano.lugartratamiento_Cod and periodicidad.tecnicos_Cod=tecnicos.Cod and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and periodicidad.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and tecnicos.Nombre='" + s + "' and periodicidad.Fecha between'" + y + "'and '" + z + "' group by tecnicos.Nombre,lugartratamiento.NombreTratamiento,periodicidad.Fecha;";
                string sql = "select  date_format(periodicidad.Fecha,'%Y/%m/%d'), planilla.numero, lugartratamiento.NombreTratamiento, group_concat(distinct servicio.Sigla), periodicidad.oti, plano.codplano, planilla.descripcion, periodicidad.DescripcionParticular  from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento, plano inner join planilla where lugartratamiento.Cod=plano.lugartratamiento_Cod and periodicidad.tecnicos_Cod=tecnicos.Cod and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and periodicidad.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and periodicidad.estado!='Reaplanificado' and periodicidad.estado!='Suspendido' and planilla.lugartratamiento_Cod=lugartratamiento.Cod and tecnicos.Nombre='" + s + "' and periodicidad.Fecha between'" + y + "'and '" + z + "' group by fecha, NombreTratamiento;";
                db.CreateCommand(sql);
                List<CheckList> ap = new List<CheckList>();
                DbDataReader result = db.Query();

                while (result.Read())
                {
                    DateTime codfech = result.GetDateTime(0);
                    string codnumero = result.GetString(1);
                    string codlugar = result.GetString(2);
                    string codservicio = result.GetString(3);
                   string codoti = result.GetString(4);
                 //   string codcertificado = result.GetString(4);
                    string codplano = result.GetString(5);
                    string doc = result.GetString(6)+"  "+result.GetString(7);

              //  CheckList a = new CheckList(codnumero,codlugar,codservicio,codnoti,codcertificado,codplano);
                    CheckList a = new CheckList(codfech ,codnumero, codlugar, codservicio,codoti, codplano, doc);
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

                //   string sql = "select cliente.Rut,tecnicos.Nombre,servicio.Nombre,planilla.Consumo,cliente.Nombre,lugartratamiento.Nom{ñ3breTratamiento,planilla.Area,periodicidad.Fecha from cliente,tecnicos,servicio,lugartratamiento,periodicidad inner join planilla where tecnicos.Cod=planilla.Tecnicos_Cod and cliente.Rut=planilla.Cliente_Rut and servicio.Cod=planilla.Servicio_Cod and lugartratamiento.Rut=planilla.Cliente_Rut and lugartratamiento.NombreTratamiento=cliente.LugardeTratamiento and periodicidad.planilla_Cod=planilla.Cod and periodicidad.planilla_Cod like'"+s+"'";
                // string sql = "select  Fecha, planilla.numero, lugartratamiento.NombreTratamiento, group_concat(distinct servicio.Sigla),plano.codplano  from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento, plano inner join planilla where lugartratamiento.Cod=plano.lugartratamiento_Cod and periodicidad.tecnicos_Cod=tecnicos.Cod and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and periodicidad.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and tecnicos.Nombre='" + s + "' and periodicidad.Fecha between'" + y + "'and '" + z + "' group by tecnicos.Nombre,lugartratamiento.NombreTratamiento,periodicidad.Fecha;";
                string sql = "select periodicidad.cod from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento, plano inner join planilla where lugartratamiento.Cod=plano.lugartratamiento_Cod and periodicidad.tecnicos_Cod=tecnicos.Cod and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and periodicidad.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and periodicidad.estado!='Reaplanificado' and periodicidad.estado!='Suspendido' and planilla.lugartratamiento_Cod=lugartratamiento.Cod and tecnicos.Nombre='"+s+"' and periodicidad.Fecha between'"+y+"'and '"+z+"' group by fecha, NombreTratamiento;";
                db.CreateCommand(sql);
                List<Check> ap = new List<Check>();
                DbDataReader result = db.Query();

                while (result.Read())
                {
                   
                    int codnumero = result.GetInt32(0);
                    

                    //  CheckList a = new CheckList(codnumero,codlugar,codservicio,codnoti,codcertificado,codplano);
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

                //   string sql = "select cliente.Rut,tecnicos.Nombre,servicio.Nombre,planilla.Consumo,cliente.Nombre,lugartratamiento.NombreTratamiento,planilla.Area,periodicidad.Fecha from cliente,tecnicos,servicio,lugartratamiento,periodicidad inner join planilla where tecnicos.Cod=planilla.Tecnicos_Cod and cliente.Rut=planilla.Cliente_Rut and servicio.Cod=planilla.Servicio_Cod and lugartratamiento.Rut=planilla.Cliente_Rut and lugartratamiento.NombreTratamiento=cliente.LugardeTratamiento and periodicidad.planilla_Cod=planilla.Cod and periodicidad.planilla_Cod like'"+s+"'";
                //string sql = "select  Fecha, planilla.numero, lugartratamiento.NombreTratamiento, group_concat(distinct servicio.Sigla),plano.codplano  from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento, plano inner join planilla where lugartratamiento.CodNT=plano.lugartratamiento_CodNT and planilla.Tecnicos_Cod=tecnicos.Cod and planilla.Servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_CodNT=lugartratamiento.CodNT and tecnicos.Nombre='" + s + "' and periodicidad.Fecha between'" + y + "'and '" + z + "' group by tecnicos.Nombre,lugartratamiento.NombreTratamiento,periodicidad.Fecha ;";
                string sql = "select  cliente.Nombre,lugartratamiento.NombreTratamiento,plano.CodPlano,DATE_FORMAT(fecha, '%M'), DATE_FORMAT(fecha, '%d-%m-%Y'), servicio.Sigla, group_concat(distinct area.NombreArea), periodicidad.Estado,tecnicos.Nombre from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento, plano inner join planilla where lugartratamiento.Cod=plano.lugartratamiento_Cod and periodicidad.tecnicos_Cod=tecnicos.Cod and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and periodicidad.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod  and periodicidad.Fecha between'" + ini + "'and '" + fin + "' and lugartratamiento.NombreTratamiento='" + lugar + "'group by periodicidad.Fecha, periodicidad.oti,lugartratamiento.NombreTratamiento , tecnicos.Nombre, servicio.Sigla, cliente.Nombre,cliente.rut, periodicidad.consumo;";
                db.CreateCommand(sql);
                List<Informeservicioplanificacion> ap = new List<Informeservicioplanificacion>();
                DbDataReader result = db.Query();         

                
                while (result.Read())
                {
                    string cli = result.GetString(0);
                    string lug = result.GetString(1);
                    string plano = result.GetString(2);
                    string mes = result.GetString(3);
                    string fecha= result.GetString(4);
                    string servicio = result.GetString(5);
                    string area = result.GetString(6);
                    string estado = result.GetString(7);
                    string tec = result.GetString(8);


                    //  CheckList a = new CheckList(codnumero,codlugar,codservicio,codnoti,codcertificado,codplano);
                    Informeservicioplanificacion a = new Informeservicioplanificacion(cli, lug, plano, mes, fecha,servicio,area,estado,tec);
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

                //   string sql = "select cliente.Rut,tecnicos.Nombre,servicio.Nombre,planilla.Consumo,cliente.Nombre,lugartratamiento.NombreTratamiento,planilla.Area,periodicidad.Fecha from cliente,tecnicos,servicio,lugartratamiento,periodicidad inner join planilla where tecnicos.Cod=planilla.Tecnicos_Cod and cliente.Rut=planilla.Cliente_Rut and servicio.Cod=planilla.Servicio_Cod and lugartratamiento.Rut=planilla.Cliente_Rut and lugartratamiento.NombreTratamiento=cliente.LugardeTratamiento and periodicidad.planilla_Cod=planilla.Cod and periodicidad.planilla_Cod like'"+s+"'";
                //string sql = "select  Fecha, planilla.numero, lugartratamiento.NombreTratamiento, group_concat(distinct servicio.Sigla),plano.codplano  from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento, plano inner join planilla where lugartratamiento.CodNT=plano.lugartratamiento_CodNT and planilla.Tecnicos_Cod=tecnicos.Cod and planilla.Servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_CodNT=lugartratamiento.CodNT and tecnicos.Nombre='" + s + "' and periodicidad.Fecha between'" + y + "'and '" + z + "' group by tecnicos.Nombre,lugartratamiento.NombreTratamiento,periodicidad.Fecha ;";
                string sql = "select  cliente.Nombre,lugartratamiento.NombreTratamiento,plano.CodPlano,DATE_FORMAT(fecha, '%M'), DATE_FORMAT(fecha, '%d-%m-%Y'),servicio.Sigla, group_concat(distinct area.NombreArea), periodicidad.Estado,tecnicos.Nombre from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento, plano inner join planilla where lugartratamiento.Cod=plano.lugartratamiento_Cod and periodicidad.tecnicos_Cod=tecnicos.Cod and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and periodicidad.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod  and periodicidad.Fecha between'" + ini + "'and '" + fin + "'group by periodicidad.Fecha,tecnicos.Nombre, periodicidad.oti,lugartratamiento.NombreTratamiento , servicio.Sigla, cliente.Nombre,cliente.rut, periodicidad.consumo ;";
                db.CreateCommand(sql);
                List<Informeservicioplanificacion> ap = new List<Informeservicioplanificacion>();
                DbDataReader result = db.Query();         

                
                while (result.Read())
                {
                    string cli = result.GetString(0);
                    string lug = result.GetString(1);
                    string plano = result.GetString(2);
                    string mes = result.GetString(3);
                    string fecha= result.GetString(4);
                    string servicio = result.GetString(5);
                    string area = result.GetString(6);
                    string estado = result.GetString(7);
                    string tec = result.GetString(8);


                    //  CheckList a = new CheckList(codnumero,codlugar,codservicio,codnoti,codcertificado,codplano);
                    Informeservicioplanificacion a = new Informeservicioplanificacion(cli, lug, plano, mes, fecha,servicio,area,estado,tec);
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



          public List<Informeservicioplanificacion>  Informebuscarplanillarealizadosconcliente(string ini, string fin, string cliente)
          {
              try
              {

                  DataAccess.DataBase db = new DataBase();
                  db.connect();

                  //   string sql = "select cliente.Rut,tecnicos.Nombre,servicio.Nombre,planilla.Consumo,cliente.Nombre,lugartratamiento.NombreTratamiento,planilla.Area,periodicidad.Fecha from cliente,tecnicos,servicio,lugartratamiento,periodicidad inner join planilla where tecnicos.Cod=planilla.Tecnicos_Cod and cliente.Rut=planilla.Cliente_Rut and servicio.Cod=planilla.Servicio_Cod and lugartratamiento.Rut=planilla.Cliente_Rut and lugartratamiento.NombreTratamiento=cliente.LugardeTratamiento and periodicidad.planilla_Cod=planilla.Cod and periodicidad.planilla_Cod like'"+s+"'";
                  //string sql = "select  Fecha, planilla.numero, lugartratamiento.NombreTratamiento, group_concat(distinct servicio.Sigla),plano.codplano  from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento, plano inner join planilla where lugartratamiento.CodNT=plano.lugartratamiento_CodNT and planilla.Tecnicos_Cod=tecnicos.Cod and planilla.Servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_CodNT=lugartratamiento.CodNT and tecnicos.Nombre='" + s + "' and periodicidad.Fecha between'" + y + "'and '" + z + "' group by tecnicos.Nombre,lugartratamiento.NombreTratamiento,periodicidad.Fecha ;";
                  string sql = "select  cliente.Nombre,lugartratamiento.NombreTratamiento,plano.CodPlano,DATE_FORMAT(fecha, '%M'), DATE_FORMAT(fecha, '%d-%m-%Y'),servicio.Sigla, group_concat(distinct area.NombreArea), periodicidad.Estado,tecnicos.Nombre from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento, plano inner join planilla where lugartratamiento.Cod=plano.lugartratamiento_Cod and periodicidad.tecnicos_Cod=tecnicos.Cod and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and periodicidad.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod  and periodicidad.Fecha between'" + ini + "'and '" + fin + "' and cliente.nombre='" + cliente + "'group by periodicidad.Fecha, periodicidad.oti,lugartratamiento.NombreTratamiento , tecnicos.Nombre, servicio.Sigla, cliente.Nombre,cliente.rut, periodicidad.consumo  ;";
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


                      //  CheckList a = new CheckList(codnumero,codlugar,codservicio,codnoti,codcertificado,codplano);
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

                //   string sql = "select cliente.Rut,tecnicos.Nombre,servicio.Nombre,planilla.Consumo,cliente.Nombre,lugartratamiento.NombreTratamiento,planilla.Area,periodicidad.Fecha from cliente,tecnicos,servicio,lugartratamiento,periodicidad inner join planilla where tecnicos.Cod=planilla.Tecnicos_Cod and cliente.Rut=planilla.Cliente_Rut and servicio.Cod=planilla.Servicio_Cod and lugartratamiento.Rut=planilla.Cliente_Rut and lugartratamiento.NombreTratamiento=cliente.LugardeTratamiento and periodicidad.planilla_Cod=planilla.Cod and periodicidad.planilla_Cod like'"+s+"'";
                //string sql = "select  Fecha, planilla.numero, lugartratamiento.NombreTratamiento, group_concat(distinct servicio.Sigla),plano.codplano  from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento, plano inner join planilla where lugartratamiento.CodNT=plano.lugartratamiento_CodNT and planilla.Tecnicos_Cod=tecnicos.Cod and planilla.Servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_CodNT=lugartratamiento.CodNT and tecnicos.Nombre='" + s + "' and periodicidad.Fecha between'" + y + "'and '" + z + "' group by tecnicos.Nombre,lugartratamiento.NombreTratamiento,periodicidad.Fecha ;";
              //  string sql = "select cliente.Clasificacion, cliente.Nombre, lugartratamiento.NombreTratamiento, plano.CodPlano from cliente,lugartratamiento,plano where not cliente.Cod in (select planilla.Cliente_Cod from planilla) and cliente.Clasificacion='" + clasi + "' and cliente.Cod=lugartratamiento.Cliente_Cod and plano.LugarTratamiento_Cod= lugartratamiento.Cod  order by cliente.Nombre;;";
                string sql = "select cliente.Clasificacion,cliente.Nombre, lugartratamiento.NombreTratamiento, plano.CodPlano from cliente,lugartratamiento,plano inner join periodicidad where not cliente.Cod in (select planilla.Cliente_Cod from planilla) and cliente.Clasificacion='" + clasi + "' and periodicidad.Fecha between '" + ini + "' and '" + fin + "' and cliente.Cod=lugartratamiento.Cliente_Cod and plano.LugarTratamiento_Cod= lugartratamiento.Cod group by plano.CodPlano order by cliente.nombre;";
                db.CreateCommand(sql);
                List<InformeLugaresSPlanificacion> ap = new List<InformeLugaresSPlanificacion>();
                DbDataReader result = db.Query();         
                

                
                while (result.Read())
                {
                    string cla = result.GetString(0);
                    string nom = result.GetString(1);
                    string lug = result.GetString(2);
                    string plano = result.GetString(3);
                    


                    //  CheckList a = new CheckList(codnumero,codlugar,codservicio,codnoti,codcertificado,codplano);
                    InformeLugaresSPlanificacion a = new InformeLugaresSPlanificacion(cla,nom, lug, plano);
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
        public List<Periodicidad> getCodIndividual(string fecha, string codplanilla, string codservicio)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();

                //   string sql = "select cliente.Rut,tecnicos.Nombre,servicio.Nombre,planilla.Consumo,cliente.Nombre,lugartratamiento.NombreTratamiento,planilla.Area,periodicidad.Fecha from cliente,tecnicos,servicio,lugartratamiento,periodicidad inner join planilla where tecnicos.Cod=planilla.Tecnicos_Cod and cliente.Rut=planilla.Cliente_Rut and servicio.Cod=planilla.Servicio_Cod and lugartratamiento.Rut=planilla.Cliente_Rut and lugartratamiento.NombreTratamiento=cliente.LugardeTratamiento and periodicidad.planilla_Cod=planilla.Cod and periodicidad.planilla_Cod like'"+s+"'";
                //string sql = "select  Fecha, planilla.numero, lugartratamiento.NombreTratamiento, group_concat(distinct servicio.Sigla),plano.codplano  from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento, plano inner join planilla where lugartratamiento.CodNT=plano.lugartratamiento_CodNT and planilla.Tecnicos_Cod=tecnicos.Cod and planilla.Servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_CodNT=lugartratamiento.CodNT and tecnicos.Nombre='" + s + "' and periodicidad.Fecha between'" + y + "'and '" + z + "' group by tecnicos.Nombre,lugartratamiento.NombreTratamiento,periodicidad.Fecha ;";
                string sql = "select periodicidad.Cod from periodicidad, servicio  inner join cliente where periodicidad.Fecha='"+fecha+"' and periodicidad.Planilla_Cod='"+codplanilla+"' and periodicidad.Servicio_Cod='"+codservicio+"' group by periodicidad.cod;";
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
                                
             //   string sql = "select cliente.Rut,tecnicos.Nombre,servicio.Nombre,planilla.Consumo,cliente.Nombre,lugartratamiento.NombreTratamiento,planilla.Area,periodicidad.Fecha from cliente,tecnicos,servicio,lugartratamiento,periodicidad inner join planilla where tecnicos.Cod=planilla.Tecnicos_Cod and cliente.Rut=planilla.Cliente_Rut and servicio.Cod=planilla.Servicio_Cod and lugartratamiento.Rut=planilla.Cliente_Rut and lugartratamiento.NombreTratamiento=cliente.LugardeTratamiento and periodicidad.planilla_Cod=planilla.Cod and periodicidad.planilla_Cod like'"+s+"'";
                string sql = "select tecnicos.Nombre,lugartratamiento.ruta,periodicidad.TipoPeridodicidad, servicio.Nombre, cliente.Nombre,area.NombreArea, periodicidad.Fecha, planilla.Descripcion, periodicidad.DescripcionParticular from tecnicos, servicio, cliente, area, periodicidad inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and periodicidad.Area_Cod=area.Cod and periodicidad.Cod=planilla.Cod and periodicidad.planilla_Cod like '" + s + "'";
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


                    Inventariado a = new Inventariado(codtec, ruta, tipo, codser, codcli, codrut, descrip, codlugar, area, fecha, codpla, descripparticular);
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
        public List<Periodicidad> getcodperiodi(string rut, string fecha, string cod)
        {

            DataBase bd = new DataBase();
            bd.connect();
            List<Periodicidad> units = new List<Periodicidad>();
            //puede ser un condicion where
            string sql = "select periodicidad.Cod from periodicidad  inner join cliente where cliente.Rut='" + rut + "'and periodicidad.Fecha='" + fecha + "' and periodicidad.Planilla_Cod='"+cod+"';";
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

        public List<Periodicidad> getcodperiodiEstado(string rut, string fecha, string cod)
        {

            DataBase bd = new DataBase();
            bd.connect();
            List<Periodicidad> units = new List<Periodicidad>();
            //puede ser un condicion where
            string sql = "select periodicidad.cod, periodicidad.estado, periodicidad.oti  from periodicidad  inner join cliente where cliente.Rut='" + rut + "'and periodicidad.Fecha='" + fecha + "' and periodicidad.Planilla_Cod='" + cod + "';";
            bd.CreateCommand(sql);

            DbDataReader result = bd.Query();

            while (result.Read())
            {
                Periodicidad u = new Periodicidad(result.GetInt32(0),result.GetString(1),result.GetString(2));
                units.Add(u);

            }
            result.Close();
            bd.close();
            return units;

        }



        public List<Periodicidad> getcodperiodiInforme(string fecha, string lugar, string tecnico)
        {

            DataBase bd = new DataBase();
            bd.connect();
            List<Periodicidad> units = new List<Periodicidad>();
            //puede ser un condicion where
            string sql = "select  date_format(periodicidad.Fecha,'%Y/%m/%d'), periodicidad.Cod, lugartratamiento.NombreTratamiento,tecnicos.Nombre  from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento, plano inner join planilla where lugartratamiento.Cod=plano.lugartratamiento_Cod and periodicidad.tecnicos_Cod=tecnicos.Cod and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and periodicidad.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and tecnicos.Nombre='"+tecnico+"' and periodicidad.Fecha='"+fecha+"' and lugartratamiento.NombreTratamiento='"+lugar+"' group by periodicidad.Cod";
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





        public List<Periodicidad> getcodperiodiR(string fecha, string cod)
        {

            DataBase bd = new DataBase();
            bd.connect();
            List<Periodicidad> units = new List<Periodicidad>();
            //puede ser un condicion where
            string sql = "select periodicidad.Cod from periodicidad  inner join cliente where periodicidad.Fecha='"+fecha+"' and periodicidad.Planilla_Cod='"+cod+"' group by periodicidad.cod;";
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

        public List<Periodicidad> getcodperiodiwherePlanilla(string codpla)
        {

            DataBase bd = new DataBase();
            bd.connect();
            List<Periodicidad> units = new List<Periodicidad>();
            //puede ser un condicion where
            string sql = "select periodicidad.Cod from periodicidad inner join planilla where planilla.cod = '"+codpla+"' and periodicidad.Planilla_Cod=planilla.Cod;";
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



        public void addEstdo(Estado ac)
        {
            try
            {
                DataAccess.DataBase bd = new DataAccess.DataBase();
                bd.connect();
                string sql = "insert into Estado values('" + ac.COD + "','"+ac.ESTADO+"','" + ac.PERICOD + "')";
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
                string sql = "update planilla set Descripcion='" + ad.Descripcion+ "'where cod='" + ad.Cod + "';";

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

          public void daletesuspen (Periodicidad ad)
          {
               

              try
              {

                  DataAccess.DataBase db = new DataBase();
                  db.connect();
                  string sql = "delete periodicidad from periodicidad where Planilla_Cod='"+ad.Cod+"' and periodicidad.Fecha >'"+ad.Fecha+"';";

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