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
    public class CatalogoInformes
    {

        public List<InformeServiciosPlanificado> InformebuscarServiciosPlanificados(string ini, string fin, string clasificacion, string cliente, string tipolugar, string lugar, string ruta, string periodicidad)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();
                string sql = "select cliente.Clasificacion, cliente.Nombre, lugartratamiento.TipoLugar,lugartratamiento.NombreTratamiento , plano.CodPlano, lugartratamiento.Ruta, DATE_FORMAT(fecha, '%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre from cliente, lugartratamiento, periodicidad, servicio, plano, tecnicos where Clasificacion='" + clasificacion + "' and cliente.Nombre='" + cliente + "' and TipoLugar='" + tipolugar + "' and lugartratamiento.NombreTratamiento='" + lugar + "' and Ruta='" + ruta + "' and periodicidad.Fecha between '" + ini + "' and '" + fin + "' and periodicidad.TipoPeridodicidad='" + periodicidad + "' and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod = periodicidad.Servicio_Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod group by fecha;";
                db.CreateCommand(sql);
                List<InformeServiciosPlanificado> ap = new List<InformeServiciosPlanificado>();
                DbDataReader result = db.Query();


                while (result.Read())
                {

                    string cla = result.GetString(0);
                    string cli = result.GetString(1);
                    string tlugar = result.GetString(2);
                    string lug = result.GetString(3);
                    string plano = result.GetString(4);
                    string ru = result.GetString(5);
                    string fecha = result.GetString(6);
                    string tperiodicidad = result.GetString(7);
                    string ser = result.GetString(8);
                    string tec = result.GetString(9);


                    InformeServiciosPlanificado a = new InformeServiciosPlanificado(cla, cli, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec);
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

        public List<InformeServiciosPlanificado> InformebuscarServiciosPlanificadosSoloCliente(string ini, string fin, string cliente)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();
                string sql = "select cliente.Clasificacion, cliente.Nombre, lugartratamiento.TipoLugar,lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta, DATE_FORMAT(fecha, '%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre from cliente, lugartratamiento, periodicidad, servicio, plano, tecnicos inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod and periodicidad.servicio_Cod=servicio.Cod and lugartratamiento.cliente_Cod=cliente.Cod and planilla.cod=periodicidad.planilla_Cod and lugartratamiento.Cod=planilla.lugartratamiento_Cod and lugartratamiento.Cod = plano.LugarTratamiento_Cod and cliente.Nombre='" + cliente + "' and periodicidad.Fecha between '" + ini + "' and '" + fin + "'   group by periodicidad.Fecha,lugartratamiento.NombreTratamiento;";
                db.CreateCommand(sql);
                List<InformeServiciosPlanificado> ap = new List<InformeServiciosPlanificado>();
                DbDataReader result = db.Query();


                while (result.Read())
                {

                    string cla = result.GetString(0);
                    string cli = result.GetString(1);
                    string tlugar = result.GetString(2);
                    string lug = result.GetString(3);
                    string plano = result.GetString(4);
                    string ru = result.GetString(5);
                    string fecha = result.GetString(6);
                    string tperiodicidad = result.GetString(7);
                    string ser = result.GetString(8);
                    string tec = result.GetString(9);


                    InformeServiciosPlanificado a = new InformeServiciosPlanificado(cla, cli, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec);
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

        public List<InformeServiciosPlanificado> InformebuscarServiciosPlanificadosSoloLugar(string ini, string fin, string lugar)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();
                string sql = "select cliente.Clasificacion, cliente.Nombre, lugartratamiento.TipoLugar,lugartratamiento.NombreTratamiento , plano.CodPlano, lugartratamiento.Ruta, DATE_FORMAT(fecha, '%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre from cliente, lugartratamiento, periodicidad, servicio, plano, tecnicos inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod  and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and lugartratamiento.NombreTratamiento='" + lugar + "' and periodicidad.Fecha between '" + ini + "' and '" + fin + "'  group by periodicidad.Fecha, planilla.Cod,lugartratamiento.NombreTratamiento, Clasificacion;";
                db.CreateCommand(sql);
                List<InformeServiciosPlanificado> ap = new List<InformeServiciosPlanificado>();
                DbDataReader result = db.Query();


                while (result.Read())
                {

                    string cla = result.GetString(0);
                    string cli = result.GetString(1);
                    string tlugar = result.GetString(2);
                    string lug = result.GetString(3);
                    string plano = result.GetString(4);
                    string ru = result.GetString(5);
                    string fecha = result.GetString(6);
                    string tperiodicidad = result.GetString(7);
                    string ser = result.GetString(8);
                    string tec = result.GetString(9);


                    InformeServiciosPlanificado a = new InformeServiciosPlanificado(cla, cli, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec);
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


        public List<InformeServiciosPlanificado> InformebuscarServiciosPlanificadosSoloFecha(string ini, string fin)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();
                string sql = "select cliente.Clasificacion, cliente.Nombre, lugartratamiento.TipoLugar,lugartratamiento.NombreTratamiento , plano.CodPlano, lugartratamiento.Ruta, DATE_FORMAT(fecha, '%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre from cliente, lugartratamiento, periodicidad, servicio, plano, tecnicos inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod  and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and periodicidad.Fecha between '" + ini + "' and '" + fin + "'  group by periodicidad.Fecha, planilla.Cod,tecnicos.Nombre, Clasificacion order by Fecha, tecnicos.Nombre;";
                db.CreateCommand(sql);
                List<InformeServiciosPlanificado> ap = new List<InformeServiciosPlanificado>();
                DbDataReader result = db.Query();


                while (result.Read())
                {

                    string cla = result.GetString(0);
                    string cli = result.GetString(1);
                    string tlugar = result.GetString(2);
                    string lug = result.GetString(3);
                    string plano = result.GetString(4);
                    string ru = result.GetString(5);
                    string fecha = result.GetString(6);
                    string tperiodicidad = result.GetString(7);
                    string ser = result.GetString(8);
                    string tec = result.GetString(9);


                    InformeServiciosPlanificado a = new InformeServiciosPlanificado(cla, cli, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec);
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

        public List<InformeServiciosPlanificado> InformebuscarServiciosPlanificadosSoloTipoLugar(string ini, string fin, string tipo)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();
                string sql = "select cliente.Clasificacion, cliente.Nombre, lugartratamiento.TipoLugar,lugartratamiento.NombreTratamiento , plano.CodPlano, lugartratamiento.Ruta, DATE_FORMAT(fecha, '%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre from cliente, lugartratamiento, periodicidad, servicio, plano, tecnicos inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod  and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and periodicidad.Fecha between '" + ini + "' and '" + fin + "' and lugartratamiento.TipoLugar='" + tipo + "' group by periodicidad.Fecha, planilla.Cod,tecnicos.Nombre, Clasificacion order by Fecha, tecnicos.Nombre;";
                db.CreateCommand(sql);
                List<InformeServiciosPlanificado> ap = new List<InformeServiciosPlanificado>();
                DbDataReader result = db.Query();


                while (result.Read())
                {

                    string cla = result.GetString(0);
                    string cli = result.GetString(1);
                    string tlugar = result.GetString(2);
                    string lug = result.GetString(3);
                    string plano = result.GetString(4);
                    string ru = result.GetString(5);
                    string fecha = result.GetString(6);
                    string tperiodicidad = result.GetString(7);
                    string ser = result.GetString(8);
                    string tec = result.GetString(9);


                    InformeServiciosPlanificado a = new InformeServiciosPlanificado(cla, cli, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec);
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


        public List<InformeServiciosPlanificado> InformebuscarServiciosPlanificadosSoloTipoRuta(string ini, string fin, string Ruta)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();
                string sql = "select cliente.Clasificacion, cliente.Nombre, lugartratamiento.TipoLugar,lugartratamiento.NombreTratamiento , plano.CodPlano, lugartratamiento.Ruta, DATE_FORMAT(fecha, '%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre from cliente, lugartratamiento, periodicidad, servicio, plano, tecnicos inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod  and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and periodicidad.Fecha between '" + ini + "' and '" + fin + "' and lugartratamiento.Ruta='" + Ruta + "'  group by periodicidad.Fecha, planilla.Cod,tecnicos.Nombre, Clasificacion order by Fecha, tecnicos.Nombre;";
                db.CreateCommand(sql);
                List<InformeServiciosPlanificado> ap = new List<InformeServiciosPlanificado>();
                DbDataReader result = db.Query();


                while (result.Read())
                {

                    string cla = result.GetString(0);
                    string cli = result.GetString(1);
                    string tlugar = result.GetString(2);
                    string lug = result.GetString(3);
                    string plano = result.GetString(4);
                    string ru = result.GetString(5);
                    string fecha = result.GetString(6);
                    string tperiodicidad = result.GetString(7);
                    string ser = result.GetString(8);
                    string tec = result.GetString(9);


                    InformeServiciosPlanificado a = new InformeServiciosPlanificado(cla, cli, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec);
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

        public List<InformeServiciosPlanificado> InformebuscarServiciosPlanificadosSoloTipoPeriodicidad(string ini, string fin, string periodicidad)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();
                string sql = "select cliente.Clasificacion, cliente.Nombre, lugartratamiento.TipoLugar,lugartratamiento.NombreTratamiento , plano.CodPlano, lugartratamiento.Ruta, DATE_FORMAT(fecha, '%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre from cliente, lugartratamiento, periodicidad, servicio, plano, tecnicos inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod  and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and periodicidad.Fecha between '" + ini + "' and '" + fin + "' and periodicidad.TipoPeridodicidad='" + periodicidad + "'  group by periodicidad.Fecha, planilla.Cod,tecnicos.Nombre, Clasificacion order by Fecha, tecnicos.Nombre;";
                db.CreateCommand(sql);
                List<InformeServiciosPlanificado> ap = new List<InformeServiciosPlanificado>();
                DbDataReader result = db.Query();


                while (result.Read())
                {

                    string cla = result.GetString(0);
                    string cli = result.GetString(1);
                    string tlugar = result.GetString(2);
                    string lug = result.GetString(3);
                    string plano = result.GetString(4);
                    string ru = result.GetString(5);
                    string fecha = result.GetString(6);
                    string tperiodicidad = result.GetString(7);
                    string ser = result.GetString(8);
                    string tec = result.GetString(9);


                    InformeServiciosPlanificado a = new InformeServiciosPlanificado(cla, cli, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec);
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

        public List<InformeServiciosPlanificado> InformebuscarServiciosPlanificadosClienteYLugar(string ini, string fin, string cliente, string lugar)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();
                string sql = "select cliente.Clasificacion, cliente.Nombre, lugartratamiento.TipoLugar,lugartratamiento.NombreTratamiento , plano.CodPlano, lugartratamiento.Ruta, DATE_FORMAT(fecha, '%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre from cliente, lugartratamiento, periodicidad, servicio, plano, tecnicos inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod  and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and periodicidad.Fecha between '" + ini + "' and '" + fin + "' and cliente.Nombre='" + cliente + "' and lugartratamiento.NombreTratamiento='" + lugar + "'   group by periodicidad.Fecha, planilla.Cod,tecnicos.Nombre, Clasificacion order by Fecha, tecnicos.Nombre;";
                db.CreateCommand(sql);
                List<InformeServiciosPlanificado> ap = new List<InformeServiciosPlanificado>();
                DbDataReader result = db.Query();


                while (result.Read())
                {

                    string cla = result.GetString(0);
                    string cli = result.GetString(1);
                    string tlugar = result.GetString(2);
                    string lug = result.GetString(3);
                    string plano = result.GetString(4);
                    string ru = result.GetString(5);
                    string fecha = result.GetString(6);
                    string tperiodicidad = result.GetString(7);
                    string ser = result.GetString(8);
                    string tec = result.GetString(9);


                    InformeServiciosPlanificado a = new InformeServiciosPlanificado(cla, cli, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec);
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






        public List<InformeServiciosRealizado> InformebuscarServiciosRealizados(string ini, string fin, string cliente, string tipo, string lugar, string ruta)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();
                string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta, DATE_FORMAT(fecha, '%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,periodicidad.OTI,periodicidad.Consumo, SUM(periodicidad.tiempo) from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla where fecha between '" + ini + "' and '" + fin + "' and cliente.Nombre='" + cliente + "' and TipoLugar='" + tipo + "' and lugartratamiento.NombreTratamiento='" + lugar + "' and lugartratamiento.Ruta='" + ruta + "' and periodicidad.Estado= 'Realizado' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Cod group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;";
                db.CreateCommand(sql);
                List<InformeServiciosRealizado> ap = new List<InformeServiciosRealizado>();
                DbDataReader result = db.Query();


                while (result.Read())
                {

                    string cla = result.GetString(0);
                    string tlugar = result.GetString(1);
                    string lug = result.GetString(2);
                    string plano = result.GetString(3);
                    string ru = result.GetString(4);
                    string fecha = result.GetString(5);
                    string tperiodicidad = result.GetString(6);
                    string ser = result.GetString(7);
                    string tec = result.GetString(8);
                    string not = result.GetString(9);
                    string consumo = result.GetString(10);
                    string tiempo = result.GetString(11);
                    InformeServiciosRealizado a = new InformeServiciosRealizado(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec, not, consumo, tiempo);
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



        public List<InformeServiciosRealizado> InformebuscarServiciosRealizadosSoloFechas(string ini, string fin)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();
                string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta, DATE_FORMAT(fecha, '%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,periodicidad.OTI, periodicidad.Consumo , SUM(periodicidad.tiempo) from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla where fecha between '" + ini + "' and '" + fin + "'  and periodicidad.Estado= 'Realizado' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Cod group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;";
                db.CreateCommand(sql);
                List<InformeServiciosRealizado> ap = new List<InformeServiciosRealizado>();
                DbDataReader result = db.Query();


                while (result.Read())
                {

                    string cla = result.GetString(0);
                    string tlugar = result.GetString(1);
                    string lug = result.GetString(2);
                    string plano = result.GetString(3);
                    string ru = result.GetString(4);
                    string fecha = result.GetString(5);
                    string tperiodicidad = result.GetString(6);
                    string ser = result.GetString(7);
                    string tec = result.GetString(8);
                    string not = result.GetString(9);
                    string consumo = result.GetString(10);
                    string tiempo = result.GetString(11);
                    InformeServiciosRealizado a = new InformeServiciosRealizado(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec, not, consumo, tiempo);
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
        public List<InformeServiciosRealizado> InformebuscarServiciosRealizadosSoloFechasSeparadas(string ini, string fin)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();
                string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta, DATE_FORMAT(fecha, '%d-%m-%Y'), periodicidad.TipoPeridodicidad, servicio.Sigla, tecnicos.Nombre,periodicidad.OTI,periodicidad.Consumo, periodicidad.tiempo  from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla where fecha between '" + ini + "' and '" + fin + "'  and periodicidad.Estado= 'Realizado' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Cod group by periodicidad.Fecha,lugartratamiento.NombreTratamiento,servicio.sigla ;";
                db.CreateCommand(sql);
                List<InformeServiciosRealizado> ap = new List<InformeServiciosRealizado>();
                DbDataReader result = db.Query();


                while (result.Read())
                {

                    string cla = result.GetString(0);
                    string tlugar = result.GetString(1);
                    string lug = result.GetString(2);
                    string plano = result.GetString(3);
                    string ru = result.GetString(4);
                    string fecha = result.GetString(5);
                    string tperiodicidad = result.GetString(6);
                    string ser = result.GetString(7);
                    string tec = result.GetString(8);
                    string not = result.GetString(9);
                    string consumo = result.GetString(10);
                    string tiempo = result.GetString(11);
                    InformeServiciosRealizado a = new InformeServiciosRealizado(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec, not, consumo,tiempo);
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

        public List<InformeServiciosRealizado> InformebuscarServiciosRealizadosSoloCliente(string ini, string fin, string cliente)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();


                string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta, DATE_FORMAT(fecha, '%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,periodicidad.OTI,periodicidad.Consumo, SUM(periodicidad.tiempo)  from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla where fecha between '" + ini + "' and '" + fin + "'  and periodicidad.Estado= 'Realizado' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Cod and cliente.Nombre='" + cliente + "' group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;";
                db.CreateCommand(sql);
                List<InformeServiciosRealizado> ap = new List<InformeServiciosRealizado>();
                DbDataReader result = db.Query();


                while (result.Read())
                {

                    string cla = result.GetString(0);
                    string tlugar = result.GetString(1);
                    string lug = result.GetString(2);
                    string plano = result.GetString(3);
                    string ru = result.GetString(4);
                    string fecha = result.GetString(5);
                    string tperiodicidad = result.GetString(6);
                    string ser = result.GetString(7);
                    string tec = result.GetString(8);
                    string not = result.GetString(9);
                    string consumo = result.GetString(10);
                    string tiempo = result.GetString(11);
                    InformeServiciosRealizado a = new InformeServiciosRealizado(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec, not, consumo, tiempo);
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

        public List<InformeServiciosRealizado> InformebuscarServiciosRealizadosSoloClienteYTipo(string ini, string fin, string cliente, string fundos)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();


                string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta, DATE_FORMAT(fecha, '%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,periodicidad.OTI,periodicidad.Consumo, SUM(periodicidad.tiempo)  from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla where fecha between '" + ini + "' and '" + fin + "'  and periodicidad.Estado= 'Realizado' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Cod and cliente.Nombre='" + cliente + "'and lugartratamiento.TipoLugar='" + fundos + "' group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;";
                db.CreateCommand(sql);
                List<InformeServiciosRealizado> ap = new List<InformeServiciosRealizado>();
                DbDataReader result = db.Query();


                while (result.Read())
                {

                    string cla = result.GetString(0);
                    string tlugar = result.GetString(1);
                    string lug = result.GetString(2);
                    string plano = result.GetString(3);
                    string ru = result.GetString(4);
                    string fecha = result.GetString(5);
                    string tperiodicidad = result.GetString(6);
                    string ser = result.GetString(7);
                    string tec = result.GetString(8);
                    string not = result.GetString(9);
                    string consumo = result.GetString(10);
                    string tiempo = result.GetString(11);
                    InformeServiciosRealizado a = new InformeServiciosRealizado(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec, not, consumo, tiempo);
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


        public List<InformeServiciosRealizado> InformebuscarServiciosRealizadosSoloTipo(string ini, string fin, string fundos)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();


                string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta, DATE_FORMAT(fecha, '%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,periodicidad.OTI,periodicidad.Consumo, SUM(periodicidad.tiempo)  from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla where fecha between '" + ini + "' and '" + fin + "'  and periodicidad.Estado= 'Realizado' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Cod and lugartratamiento.TipoLugar='" + fundos + "' group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;";
                db.CreateCommand(sql);
                List<InformeServiciosRealizado> ap = new List<InformeServiciosRealizado>();
                DbDataReader result = db.Query();


                while (result.Read())
                {

                    string cla = result.GetString(0);
                    string tlugar = result.GetString(1);
                    string lug = result.GetString(2);
                    string plano = result.GetString(3);
                    string ru = result.GetString(4);
                    string fecha = result.GetString(5);
                    string tperiodicidad = result.GetString(6);
                    string ser = result.GetString(7);
                    string tec = result.GetString(8);
                    string not = result.GetString(9);
                    string consumo = result.GetString(10);
                    string tiempo = result.GetString(11);
                    InformeServiciosRealizado a = new InformeServiciosRealizado(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec, not, consumo, tiempo);
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


        public List<InformeServiciosRealizado> InformebuscarServiciosRealizadosSoloLugar(string ini, string fin, string lugar)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();


                string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta, DATE_FORMAT(fecha, '%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,periodicidad.OTI,periodicidad.Consumo, SUM(periodicidad.tiempo)  from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla where fecha between '" + ini + "' and '" + fin + "'  and periodicidad.Estado= 'Realizado' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Cod and lugartratamiento.NombreTratamiento='" + lugar + "' group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;";
                db.CreateCommand(sql);
                List<InformeServiciosRealizado> ap = new List<InformeServiciosRealizado>();
                DbDataReader result = db.Query();


                while (result.Read())
                {

                    string cla = result.GetString(0);
                    string tlugar = result.GetString(1);
                    string lug = result.GetString(2);
                    string plano = result.GetString(3);
                    string ru = result.GetString(4);
                    string fecha = result.GetString(5);
                    string tperiodicidad = result.GetString(6);
                    string ser = result.GetString(7);
                    string tec = result.GetString(8);
                    string not = result.GetString(9);
                    string consumo = result.GetString(10);
                    string tiempo = result.GetString(11);
                    InformeServiciosRealizado a = new InformeServiciosRealizado(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec, not, consumo, tiempo);
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

        public List<InformeServiciosRealizado> InformebuscarServiciosRealizadosClienteYLugar(string ini, string fin, string cliente, string lugar)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();


                string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta, DATE_FORMAT(fecha, '%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,periodicidad.OTI,periodicidad.Consumo, SUM(periodicidad.tiempo)  from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla where fecha between '" + ini + "' and '" + fin + "'  and periodicidad.Estado= 'Realizado' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Cod and cliente.Nombre='" + cliente + "'  and lugartratamiento.NombreTratamiento='" + lugar + "' group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;";
                db.CreateCommand(sql);
                List<InformeServiciosRealizado> ap = new List<InformeServiciosRealizado>();
                DbDataReader result = db.Query();


                while (result.Read())
                {

                    string cla = result.GetString(0);
                    string tlugar = result.GetString(1);
                    string lug = result.GetString(2);
                    string plano = result.GetString(3);
                    string ru = result.GetString(4);
                    string fecha = result.GetString(5);
                    string tperiodicidad = result.GetString(6);
                    string ser = result.GetString(7);
                    string tec = result.GetString(8);
                    string not = result.GetString(9);
                    string consumo = result.GetString(10);
                    string tiempo = result.GetString(11);
                    InformeServiciosRealizado a = new InformeServiciosRealizado(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec, not, consumo, tiempo);
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

        public List<InformeServiciosRealizado> InformebuscarServiciosRealizadosSoloTecnicos(string ini, string fin, string tecnicos)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();


                string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta, DATE_FORMAT(fecha, '%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,periodicidad.OTI,periodicidad.Consumo, SUM(periodicidad.tiempo)  from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla where fecha between '" + ini + "' and '" + fin + "'  and periodicidad.Estado= 'Realizado' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Cod  and tecnicos.Nombre='" + tecnicos + "'  group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;";
                db.CreateCommand(sql);
                List<InformeServiciosRealizado> ap = new List<InformeServiciosRealizado>();
                DbDataReader result = db.Query();


                while (result.Read())
                {

                    string cla = result.GetString(0);
                    string tlugar = result.GetString(1);
                    string lug = result.GetString(2);
                    string plano = result.GetString(3);
                    string ru = result.GetString(4);
                    string fecha = result.GetString(5);
                    string tperiodicidad = result.GetString(6);
                    string ser = result.GetString(7);
                    string tec = result.GetString(8);
                    string not = result.GetString(9);
                    string consumo = result.GetString(10);
                    string tiempo = result.GetString(11);
                    InformeServiciosRealizado a = new InformeServiciosRealizado(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec, not, consumo, tiempo);
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

        public List<InformeServiciosRealizado> InformebuscarServiciosRealizadosTecnicosYLugar(string ini, string fin, string tecnicos, string lugar)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();


                string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta, DATE_FORMAT(fecha, '%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,periodicidad.OTI,periodicidad.Consumo, SUM(periodicidad.tiempo)  from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla where fecha between '" + ini + "' and '" + fin + "'  and periodicidad.Estado= 'Realizado' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Cod  and tecnicos.Nombre='" + tecnicos + "'and lugartratamiento.NombreTratamiento='" + lugar + "'  group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;";
                db.CreateCommand(sql);
                List<InformeServiciosRealizado> ap = new List<InformeServiciosRealizado>();
                DbDataReader result = db.Query();


                while (result.Read())
                {

                    string cla = result.GetString(0);
                    string tlugar = result.GetString(1);
                    string lug = result.GetString(2);
                    string plano = result.GetString(3);
                    string ru = result.GetString(4);
                    string fecha = result.GetString(5);
                    string tperiodicidad = result.GetString(6);
                    string ser = result.GetString(7);
                    string tec = result.GetString(8);
                    string not = result.GetString(9);
                    string consumo = result.GetString(10);
                    string tiempo = result.GetString(11);
                    InformeServiciosRealizado a = new InformeServiciosRealizado(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec, not, consumo, tiempo);
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

        public List<InformeServiciosRealizado> InformebuscarServiciosRealizadosSoloTipoPeriodicidad(string ini, string fin, string tipo)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();


                string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta, DATE_FORMAT(fecha, '%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,periodicidad.OTI,periodicidad.Consumo, SUM(periodicidad.tiempo)  from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla where fecha between '" + ini + "' and '" + fin + "'  and periodicidad.Estado= 'Realizado' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Cod  and periodicidad.TipoPeridodicidad='" + tipo + "'  group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;";
                db.CreateCommand(sql);
                List<InformeServiciosRealizado> ap = new List<InformeServiciosRealizado>();
                DbDataReader result = db.Query();


                while (result.Read())
                {

                    string cla = result.GetString(0);
                    string tlugar = result.GetString(1);
                    string lug = result.GetString(2);
                    string plano = result.GetString(3);
                    string ru = result.GetString(4);
                    string fecha = result.GetString(5);
                    string tperiodicidad = result.GetString(6);
                    string ser = result.GetString(7);
                    string tec = result.GetString(8);
                    string not = result.GetString(9);
                    string consumo = result.GetString(10);
                    string tiempo = result.GetString(11);
                    InformeServiciosRealizado a = new InformeServiciosRealizado(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec, not, consumo, tiempo);
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

        public List<InformeServiciosRealizado> InformebuscarServiciosRealizadosSoloRuta(string ini, string fin, string ruta)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();


                string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta, DATE_FORMAT(fecha, '%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,periodicidad.OTI,periodicidad.Consumo, SUM(periodicidad.tiempo)  from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla where fecha between '" + ini + "' and '" + fin + "'  and periodicidad.Estado= 'Realizado' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Cod  and lugartratamiento.Ruta='" + ruta + "'  group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;";
                db.CreateCommand(sql);
                List<InformeServiciosRealizado> ap = new List<InformeServiciosRealizado>();
                DbDataReader result = db.Query();


                while (result.Read())
                {

                    string cla = result.GetString(0);
                    string tlugar = result.GetString(1);
                    string lug = result.GetString(2);
                    string plano = result.GetString(3);
                    string ru = result.GetString(4);
                    string fecha = result.GetString(5);
                    string tperiodicidad = result.GetString(6);
                    string ser = result.GetString(7);
                    string tec = result.GetString(8);
                    string not = result.GetString(9);
                    string consumo = result.GetString(10);
                    string tiempo = result.GetString(11);
                    InformeServiciosRealizado a = new InformeServiciosRealizado(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec, not, consumo,tiempo);
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



        public List<InformeServiciosNoRealizado> InformebuscarServiciosNoRealizadoSoloFechas(string ini, string fin)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();

                string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta, periodicidad.Fecha, periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,periodicidad.OTI,nota.contenido from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla,nota where fecha between '" + ini + "' and '" + fin + "'  and periodicidad.Estado= 'No Realizado' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and nota.responsable='Norealizadon---' and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and periodicidad.cod=nota.periodicidad_cod and servicio.Cod=periodicidad.Servicio_Cod group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;";
                db.CreateCommand(sql);
                List<InformeServiciosNoRealizado> ap = new List<InformeServiciosNoRealizado>();
                DbDataReader result = db.Query();


                while (result.Read())
                {

                    string cla = result.GetString(0);
                    string tlugar = result.GetString(1);
                    string lug = result.GetString(2);
                    string plano = result.GetString(3);
                    string ru = result.GetString(4);
                    string fecha = result.GetString(5);
                    string tperiodicidad = result.GetString(6);
                    string ser = result.GetString(7);
                    string tec = result.GetString(8);
                    string oti = result.GetString(9);
                    string motivo = result.GetString(10);

                    InformeServiciosNoRealizado a = new InformeServiciosNoRealizado(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec,oti, motivo);
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


        public List<InformeServiciosNoRealizado> InformebuscarServiciosNoRealizadoClienteLugar(string ini, string fin, string cliente, string lugar)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();

                string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta, periodicidad.Fecha, periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,periodicidad.OTI,nota.contenido from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla,nota where fecha between '" + ini + "' and '" + fin + "'  and periodicidad.Estado= 'No Realizado' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and periodicidad.cod=nota.periodicidad_cod and nota.responsable='Norealizadon---' and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Codand servicio.Cod=periodicidad.Servicio_Cod and cliente.Nombre='" + cliente + "' and lugartratamiento.NombreTratamiento='" + lugar + "' group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;";
                db.CreateCommand(sql);
                List<InformeServiciosNoRealizado> ap = new List<InformeServiciosNoRealizado>();
                DbDataReader result = db.Query();


                while (result.Read())
                {

                    string cla = result.GetString(0);
                    string tlugar = result.GetString(1);
                    string lug = result.GetString(2);
                    string plano = result.GetString(3);
                    string ru = result.GetString(4);
                    string fecha = result.GetString(5);
                    string tperiodicidad = result.GetString(6);
                    string ser = result.GetString(7);
                    string tec = result.GetString(8);
                    string oti = result.GetString(9);
                    string motivo = result.GetString(10);

                    InformeServiciosNoRealizado a = new InformeServiciosNoRealizado(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec, oti, motivo);
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
        public List<InformeServiciosNoRealizado> InformebuscarServiciosNoRealizadoSoloCliente(string ini, string fin, string cliente)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();

                string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta, periodicidad.Fecha, periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,periodicidad.OTI,nota.contenido from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla,nota where fecha between '" + ini + "' and '" + fin + "'  and periodicidad.Estado= 'No Realizado' and periodicidad.Planilla_Cod = planilla.Cod and nota.responsable='Norealizadon---' and periodicidad.cod=nota.periodicidad_cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Codand servicio.Cod=periodicidad.Servicio_Cod and cliente.Nombre='" + cliente + "'group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;";
                db.CreateCommand(sql);
                List<InformeServiciosNoRealizado> ap = new List<InformeServiciosNoRealizado>();
                DbDataReader result = db.Query();


                while (result.Read())
                {

                    string cla = result.GetString(0);
                    string tlugar = result.GetString(1);
                    string lug = result.GetString(2);
                    string plano = result.GetString(3);
                    string ru = result.GetString(4);
                    string fecha = result.GetString(5);
                    string tperiodicidad = result.GetString(6);
                    string ser = result.GetString(7);
                    string tec = result.GetString(8);
                    string oti = result.GetString(9);
                    string motivo = result.GetString(10);

                    InformeServiciosNoRealizado a = new InformeServiciosNoRealizado(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec, oti, motivo);
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

        public List<InformeServiciosNoRealizado> InformebuscarServiciosNoRealizadoSoloLugar(string ini, string fin, string lugar)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();

                string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta, periodicidad.Fecha, periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,periodicidad.OTI,nota.contenido from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla, nota where fecha between '" + ini + "' and '" + fin + "'  and periodicidad.Estado= 'No Realizado' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Cod and nota.responsable='Norealizadon---' and periodicidad.cod=nota.periodicidad_cod  and servicio.Cod=periodicidad.Servicio_Cod and lugartratamiento.NombreTratamiento='" + lugar + "' group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;";
                db.CreateCommand(sql);
                List<InformeServiciosNoRealizado> ap = new List<InformeServiciosNoRealizado>();
                DbDataReader result = db.Query();


                while (result.Read())
                {

                    string cla = result.GetString(0);
                    string tlugar = result.GetString(1);
                    string lug = result.GetString(2);
                    string plano = result.GetString(3);
                    string ru = result.GetString(4);
                    string fecha = result.GetString(5);
                    string tperiodicidad = result.GetString(6);
                    string ser = result.GetString(7);
                    string tec = result.GetString(8);
                    string oti = result.GetString(9);
                    string motivo = result.GetString(10);

                    InformeServiciosNoRealizado a = new InformeServiciosNoRealizado(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec, oti, motivo);
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

        public List<InformeServiciosNoRealizado> InformebuscarServiciosNoRealizadoSoloRuta(string ini, string fin, string ruta)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();

                string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta, periodicidad.Fecha, periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,periodicidad.OTI,nota.contenido from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla,nota where fecha between '" + ini + "' and '" + fin + "'  and periodicidad.Estado= 'No Realizado' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and nota.responsable='Norealizadon---' and periodicidad.cod=nota.periodicidad_cod  and servicio.Cod=periodicidad.Servicio_Codand servicio.Cod=periodicidad.Servicio_Cod and lugartratamiento.Ruta='" + ruta + "' group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;";
                db.CreateCommand(sql);
                List<InformeServiciosNoRealizado> ap = new List<InformeServiciosNoRealizado>();
                DbDataReader result = db.Query();


                while (result.Read())
                {

                    string cla = result.GetString(0);
                    string tlugar = result.GetString(1);
                    string lug = result.GetString(2);
                    string plano = result.GetString(3);
                    string ru = result.GetString(4);
                    string fecha = result.GetString(5);
                    string tperiodicidad = result.GetString(6);
                    string ser = result.GetString(7);
                    string tec = result.GetString(8);
                    string oti = result.GetString(9);
                    string motivo = result.GetString(10);

                    InformeServiciosNoRealizado a = new InformeServiciosNoRealizado(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec, oti, motivo);
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


        public List<InformeServiciosNoRealizado> InformebuscarServiciosNoRealizadoSoloTipoPeriodicidad(string ini, string fin, string tipo)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();

                string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta, periodicidad.Fecha, periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,periodicidad.OTI,periodicidad.Consumo from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla where fecha between '" + ini + "' and '" + fin + "'  and periodicidad.Estado= 'No Realizado' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Codand servicio.Cod=periodicidad.Servicio_Cod and periodicidad.TipoPeridodicidad='" + tipo + "' group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;";
                db.CreateCommand(sql);
                List<InformeServiciosNoRealizado> ap = new List<InformeServiciosNoRealizado>();
                DbDataReader result = db.Query();


                while (result.Read())
                {

                    string cla = result.GetString(0);
                    string tlugar = result.GetString(1);
                    string lug = result.GetString(2);
                    string plano = result.GetString(3);
                    string ru = result.GetString(4);
                    string fecha = result.GetString(5);
                    string tperiodicidad = result.GetString(6);
                    string ser = result.GetString(7);
                    string tec = result.GetString(8);
                    string oti = result.GetString(9);
                    string motivo = result.GetString(10);

                    InformeServiciosNoRealizado a = new InformeServiciosNoRealizado(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec, oti, motivo);
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


        public List<InformeServiciosNoRealizado> InformebuscarServiciosNoRealizadoSoloTecnicos(string ini, string fin, string tecnicos)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();

                string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta, periodicidad.Fecha, periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,periodicidad.OTI,nota.contenido from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla,nota where fecha between '" + ini + "' and '" + fin + "'  and periodicidad.Estado= 'No Realizado' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and nota.responsable='Norealizadon---' and periodicidad.cod=nota.periodicidad_cod  and servicio.Cod=periodicidad.Servicio_Cod and servicio.Cod=periodicidad.Servicio_Cod and  tecnicos.Nombre='" + tecnicos + "' group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;";
                db.CreateCommand(sql);
                List<InformeServiciosNoRealizado> ap = new List<InformeServiciosNoRealizado>();
                DbDataReader result = db.Query();


                while (result.Read())
                {

                    string cla = result.GetString(0);
                    string tlugar = result.GetString(1);
                    string lug = result.GetString(2);
                    string plano = result.GetString(3);
                    string ru = result.GetString(4);
                    string fecha = result.GetString(5);
                    string tperiodicidad = result.GetString(6);
                    string ser = result.GetString(7);
                    string tec = result.GetString(8);
                    string oti = result.GetString(9);
                    string motivo = result.GetString(10);

                    InformeServiciosNoRealizado a = new InformeServiciosNoRealizado(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec, oti, motivo);
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

        public List<InformeGraficos> InformebuscarGraficos(string ini, string fin)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();
                string sql = "select DATE_FORMAT(periodicidad.Fecha,'%d-%m-%Y'), avg(periodicidad.Consumo),lugartratamiento.NombreTratamiento from periodicidad, lugartratamiento inner join planilla where periodicidad.Planilla_Cod=planilla.Cod and lugartratamiento.Cod=planilla.LugarTratamiento_Cod and periodicidad.Consumo!='0' and fecha between '" + ini + "' and '" + fin + "' group by lugartratamiento.NombreTratamiento;";
                db.CreateCommand(sql);
                List<InformeGraficos> ap = new List<InformeGraficos>();
                DbDataReader result = db.Query();


                while (result.Read())
                {
                    string fecha = result.GetString(0);
                    string lug = result.GetString(1);
                    string consumo = result.GetString(2);
                    string visitas = result.GetString(3);
                    InformeGraficos a = new InformeGraficos(fecha, lug, consumo,visitas);
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

        public void addCheck(Check ac)
        {
            try
            {
                DataAccess.DataBase bd = new DataAccess.DataBase();
                bd.connect();
                string sql = "insert into checkl values('" + ac.Cod + "','" + ac.Certificado + "','" + ac.Obs + "','" + ac.Fecha + "','" + ac.Periodicidad + "','" + ac.Iden + "','"+ac.Tecnico+"');";
                bd.CreateCommand(sql);
                bd.execute();
                bd.close();
            }
            catch (DataAccess.DataAccessException ex)
            {
                throw new BussinessRulesException(ex.Message);
            }
        }


        public List<InformeServiciosSuspendidos> InformebuscarServiciosSuspendidosSoloFechas(string ini, string fin)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();

                string sql = "select cliente.Nombre,lugartratamiento.TipoLugar,lugartratamiento.NombreTratamiento,plano.CodPlano,lugartratamiento.Ruta,DATE_FORMAT(fecha, '%d-%m-%Y'),periodicidad.TipoPeridodicidad,group_concat(distinct servicio.Sigla),periodicidad.OTI,nota.Responsable,nota.Contenido from cliente, lugartratamiento,plano,periodicidad,servicio,nota inner join planilla where planilla.Cod=periodicidad.Planilla_Cod and planilla.Cliente_Cod=cliente.Cod and cliente.Cod=lugartratamiento.Cliente_Cod and servicio.Cod=periodicidad.Servicio_Cod and nota.periodicidad_Cod=periodicidad.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and periodicidad.Estado='Suspendido' and periodicidad.Fecha between '" + ini +  "' and '" + fin + "' group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;";
                db.CreateCommand(sql);
                List<InformeServiciosSuspendidos> ap = new List<InformeServiciosSuspendidos>();
                DbDataReader result = db.Query();


                while (result.Read())
                {

                    string cla = result.GetString(0);
                    string tlugar = result.GetString(1);
                    string lug = result.GetString(2);
                    string plano = result.GetString(3);
                    string ru = result.GetString(4);
                    string fecha = result.GetString(5);
                    string tperiodicidad = result.GetString(6);
                    string ser = result.GetString(7);
                    string not = result.GetString(8);
                    string solicitud = result.GetString(9);
                    string motivo = result.GetString(10);

                    InformeServiciosSuspendidos a = new InformeServiciosSuspendidos(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, not, solicitud, motivo);
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

        public List<InformeServiciosSuspendidos> InformebuscarServiciosSuspendidosSoloCliente(string ini, string fin, string cliente)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();

                string sql = "select cliente.Nombre,lugartratamiento.TipoLugar,lugartratamiento.NombreTratamiento,plano.CodPlano,lugartratamiento.Ruta, DATE_FORMAT(fecha, '%d-%m-%Y'),periodicidad.TipoPeridodicidad,group_concat(distinct servicio.Sigla),periodicidad.OTI,nota.Responsable,nota.Contenido from cliente, lugartratamiento,plano,periodicidad,servicio,nota inner join planilla where planilla.Cod=periodicidad.Planilla_Cod and planilla.Cliente_Cod=cliente.Cod and cliente.Cod=lugartratamiento.Cliente_Cod and servicio.Cod=periodicidad.Servicio_Cod and nota.periodicidad_Cod=periodicidad.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and periodicidad.Estado='Suspendido' and periodicidad.Fecha between '" + ini + "' and '" + fin + "'and cliente.Nombre='" + cliente + "'  group by periodicidad.Fecha,lugartratamiento.NombreTratamiento  ;";
                db.CreateCommand(sql);
                List<InformeServiciosSuspendidos> ap = new List<InformeServiciosSuspendidos>();
                DbDataReader result = db.Query();


                while (result.Read())
                {

                    string cla = result.GetString(0);
                    string tlugar = result.GetString(1);
                    string lug = result.GetString(2);
                    string plano = result.GetString(3);
                    string ru = result.GetString(4);
                    string fecha = result.GetString(5);
                    string tperiodicidad = result.GetString(6);
                    string ser = result.GetString(7);
                    string not = result.GetString(8);
                    string solicitud = result.GetString(9);
                    string motivo = result.GetString(10);

                    InformeServiciosSuspendidos a = new InformeServiciosSuspendidos(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, not, solicitud, motivo);
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



        public List<InformeServiciosSuspendidos> InformebuscarServiciosSuspendidosClienteLugar(string ini, string fin, string cliente, string lugar)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();

                string sql = "select cliente.Nombre,lugartratamiento.TipoLugar,lugartratamiento.NombreTratamiento,plano.CodPlano,lugartratamiento.Ruta, DATE_FORMAT(fecha, '%d-%m-%Y'),periodicidad.TipoPeridodicidad,group_concat(distinct servicio.Sigla),periodicidad.OTI,nota.Responsable,nota.Contenido from cliente, lugartratamiento,plano,periodicidad,servicio,nota inner join planilla where planilla.Cod=periodicidad.Planilla_Cod and planilla.Cliente_Cod=cliente.Cod and cliente.Cod=lugartratamiento.Cliente_Cod and servicio.Cod=periodicidad.Servicio_Cod and nota.periodicidad_Cod=periodicidad.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and periodicidad.Estado='Suspendido' and periodicidad.Fecha between '" + ini + "' and '" + fin + "'and cliente.Nombre='" + cliente + "' and lugartratamiento.NombreTratamiento='" + lugar + "'  group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;;";
                db.CreateCommand(sql);
                List<InformeServiciosSuspendidos> ap = new List<InformeServiciosSuspendidos>();
                DbDataReader result = db.Query();


                while (result.Read())
                {

                    string cla = result.GetString(0);
                    string tlugar = result.GetString(1);
                    string lug = result.GetString(2);
                    string plano = result.GetString(3);
                    string ru = result.GetString(4);
                    string fecha = result.GetString(5);
                    string tperiodicidad = result.GetString(6);
                    string ser = result.GetString(7);
                    string not = result.GetString(8);
                    string solicitud = result.GetString(9);
                    string motivo = result.GetString(10);

                    InformeServiciosSuspendidos a = new InformeServiciosSuspendidos(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, not, solicitud, motivo);
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



        public List<InformeServiciosSuspendidos> InformebuscarServiciosSuspendidosTipo(string ini, string fin, string tipo)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();

                string sql = "select cliente.Nombre,lugartratamiento.TipoLugar,lugartratamiento.NombreTratamiento,plano.CodPlano,lugartratamiento.Ruta, DATE_FORMAT(fecha, '%d-%m-%Y'),periodicidad.TipoPeridodicidad,group_concat(distinct servicio.Sigla),periodicidad.OTI,nota.Responsable,nota.Contenido from cliente, lugartratamiento,plano,periodicidad,servicio,nota inner join planilla where planilla.Cod=periodicidad.Planilla_Cod and planilla.Cliente_Cod=cliente.Cod and cliente.Cod=lugartratamiento.Cliente_Cod and servicio.Cod=periodicidad.Servicio_Cod and nota.periodicidad_Cod=periodicidad.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and lugartratamiento.TipoLugar='" + tipo + "' and periodicidad.Estado='Suspendido' and periodicidad.Fecha between '" + ini + "' and '" + fin + "' group by periodicidad.Fecha,lugartratamiento.NombreTratamiento;";
                db.CreateCommand(sql);
                List<InformeServiciosSuspendidos> ap = new List<InformeServiciosSuspendidos>();
                DbDataReader result = db.Query();


                while (result.Read())
                {

                    string cla = result.GetString(0);
                    string tlugar = result.GetString(1);
                    string lug = result.GetString(2);
                    string plano = result.GetString(3);
                    string ru = result.GetString(4);
                    string fecha = result.GetString(5);
                    string tperiodicidad = result.GetString(6);
                    string ser = result.GetString(7);
                    string not = result.GetString(8);
                    string solicitud = result.GetString(9);
                    string motivo = result.GetString(10);

                    InformeServiciosSuspendidos a = new InformeServiciosSuspendidos(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, not, solicitud, motivo);
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

        public List<InformeServiciosSuspendidos> InformebuscarServiciosSuspendidosSololugar(string ini, string fin, string lugar)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();

                string sql = "select cliente.Nombre,lugartratamiento.TipoLugar,lugartratamiento.NombreTratamiento,plano.CodPlano,lugartratamiento.Ruta, DATE_FORMAT(fecha, '%d-%m-%Y'),periodicidad.TipoPeridodicidad,group_concat(distinct servicio.Sigla),periodicidad.OTI,nota.Responsable,nota.Contenido from cliente, lugartratamiento,plano,periodicidad,servicio,nota inner join planilla where planilla.Cod=periodicidad.Planilla_Cod and planilla.Cliente_Cod=cliente.Cod and cliente.Cod=lugartratamiento.Cliente_Cod and servicio.Cod=periodicidad.Servicio_Cod and nota.periodicidad_Cod=periodicidad.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and periodicidad.Estado='Suspendido' and periodicidad.Fecha between '" + ini + "' and '" + fin + "'and lugartratamiento.NombreTratamiento='" + lugar + "'  group by periodicidad.Fecha,lugartratamiento.NombreTratamiento  ;";
                db.CreateCommand(sql);
                List<InformeServiciosSuspendidos> ap = new List<InformeServiciosSuspendidos>();
                DbDataReader result = db.Query();


                while (result.Read())
                {

                    string cla = result.GetString(0);
                    string tlugar = result.GetString(1);
                    string lug = result.GetString(2);
                    string plano = result.GetString(3);
                    string ru = result.GetString(4);
                    string fecha = result.GetString(5);
                    string tperiodicidad = result.GetString(6);
                    string ser = result.GetString(7);
                    string not = result.GetString(8);
                    string solicitud = result.GetString(9);
                    string motivo = result.GetString(10);

                    InformeServiciosSuspendidos a = new InformeServiciosSuspendidos(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, not, solicitud, motivo);
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

        public List<InformeServiciosReplanificados> InformebuscarServiciosRePlanificados(string ini, string fin, string cliente, string tipo, string lugar, string ruta)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();
                string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta,DATE_FORMAT(periodicidad.Fecha,'%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,planilla.Descripcion from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla where fecha between '" + ini + "' and '" + fin + "' and cliente.Nombre='" + cliente + "' and TipoLugar='" + tipo + "' and lugartratamiento.NombreTratamiento='" + lugar + "' and lugartratamiento.Ruta='" + ruta + "'and periodicidad.Estado='Replanificado' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Cod group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;";
                db.CreateCommand(sql);
                List<InformeServiciosReplanificados> ap = new List<InformeServiciosReplanificados>();
                DbDataReader result = db.Query();


                while (result.Read())
                {

                    string cla = result.GetString(0);
                    string tlugar = result.GetString(1);
                    string lug = result.GetString(2);
                    string plano = result.GetString(3);
                    string ru = result.GetString(4);
                    string fecha = result.GetString(5);
                    string tperiodicidad = result.GetString(6);
                    string ser = result.GetString(7);
                    string tec = result.GetString(8);
                    string obs = result.GetString(9);

                    InformeServiciosReplanificados a = new InformeServiciosReplanificados(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec, obs);
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
        public List<InformeServiciosReplanificados> InformebuscarServiciosRePlanificadosSoloFechas(string ini, string fin)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();
                string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta,DATE_FORMAT(periodicidad.Fecha,'%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,planilla.Descripcion from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla where fecha between '" + ini + "' and '" + fin + "' and periodicidad.Estado='Replanificado' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Cod group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;";
                db.CreateCommand(sql);
                List<InformeServiciosReplanificados> ap = new List<InformeServiciosReplanificados>();
                DbDataReader result = db.Query();


                while (result.Read())
                {

                    string cla = result.GetString(0);
                    string tlugar = result.GetString(1);
                    string lug = result.GetString(2);
                    string plano = result.GetString(3);
                    string ru = result.GetString(4);
                    string fecha = result.GetString(5);
                    string tperiodicidad = result.GetString(6);
                    string ser = result.GetString(7);
                    string tec = result.GetString(8);
                    string obs = result.GetString(9);

                    InformeServiciosReplanificados a = new InformeServiciosReplanificados(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec, obs);
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

        public List<InformeServiciosReplanificados> InformebuscarServiciosRePlanificadosClienteLugar(string ini, string fin, string cliente, string lugar)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();
                string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta,DATE_FORMAT(periodicidad.Fecha,'%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,planilla.Descripcion from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla where fecha between '" + ini + "' and '" + fin + "' and periodicidad.Estado='Replanificado' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Cod and cliente.Nombre='" + cliente + "' and lugartratamiento.NombreTratamiento='" + lugar + "' group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;";
                db.CreateCommand(sql);
                List<InformeServiciosReplanificados> ap = new List<InformeServiciosReplanificados>();
                DbDataReader result = db.Query();


                while (result.Read())
                {

                    string cla = result.GetString(0);
                    string tlugar = result.GetString(1);
                    string lug = result.GetString(2);
                    string plano = result.GetString(3);
                    string ru = result.GetString(4);
                    string fecha = result.GetString(5);
                    string tperiodicidad = result.GetString(6);
                    string ser = result.GetString(7);
                    string tec = result.GetString(8);
                    string obs = result.GetString(9);

                    InformeServiciosReplanificados a = new InformeServiciosReplanificados(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec, obs);
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

        public List<InformeServiciosReplanificados> InformebuscarServiciosRePlanificadosCliente(string ini, string fin, string cliente)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();
                string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta,DATE_FORMAT(periodicidad.Fecha,'%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,planilla.Descripcion from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla where fecha between '" + ini + "' and '" + fin + "' and periodicidad.Estado='Replanificado' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Cod and cliente.Nombre='" + cliente + "' group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;";
                db.CreateCommand(sql);
                List<InformeServiciosReplanificados> ap = new List<InformeServiciosReplanificados>();
                DbDataReader result = db.Query();


                while (result.Read())
                {

                    string cla = result.GetString(0);
                    string tlugar = result.GetString(1);
                    string lug = result.GetString(2);
                    string plano = result.GetString(3);
                    string ru = result.GetString(4);
                    string fecha = result.GetString(5);
                    string tperiodicidad = result.GetString(6);
                    string ser = result.GetString(7);
                    string tec = result.GetString(8);
                    string obs = result.GetString(9);

                    InformeServiciosReplanificados a = new InformeServiciosReplanificados(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec, obs);
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
        public List<InformeServiciosReplanificados> InformebuscarServiciosRePlanificadosLugar(string ini, string fin, string lugar)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();
                string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta,DATE_FORMAT(periodicidad.Fecha,'%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,planilla.Descripcion from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla where fecha between '" + ini + "' and '" + fin + "' and periodicidad.Estado='Replanificado' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Cod and lugartratamiento.NombreTratamiento='" + lugar + "' group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;";
                db.CreateCommand(sql);
                List<InformeServiciosReplanificados> ap = new List<InformeServiciosReplanificados>();
                DbDataReader result = db.Query();


                while (result.Read())
                {

                    string cla = result.GetString(0);
                    string tlugar = result.GetString(1);
                    string lug = result.GetString(2);
                    string plano = result.GetString(3);
                    string ru = result.GetString(4);
                    string fecha = result.GetString(5);
                    string tperiodicidad = result.GetString(6);
                    string ser = result.GetString(7);
                    string tec = result.GetString(8);
                    string obs = result.GetString(9);
                    
                    InformeServiciosReplanificados a = new InformeServiciosReplanificados(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec, obs);
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

        public List<InformeServiciosReplanificados> InformebuscarServiciosRePlanificadosTipoLugar(string ini, string fin, string tipo)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();
                string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta,DATE_FORMAT(periodicidad.Fecha,'%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,planilla.Descripcion from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla where fecha between '" + ini + "' and '" + fin + "' and periodicidad.Estado='Replanificado' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Cod and lugartratamiento.TipoLugar='" + tipo + "' group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;";
                db.CreateCommand(sql);
                List<InformeServiciosReplanificados> ap = new List<InformeServiciosReplanificados>();
                DbDataReader result = db.Query();


                while (result.Read())
                {

                    string cla = result.GetString(0);
                    string tlugar = result.GetString(1);
                    string lug = result.GetString(2);
                    string plano = result.GetString(3);
                    string ru = result.GetString(4);
                    string fecha = result.GetString(5);
                    string tperiodicidad = result.GetString(6);
                    string ser = result.GetString(7);
                    string tec = result.GetString(8);
                    string obs = result.GetString(9);

                    InformeServiciosReplanificados a = new InformeServiciosReplanificados(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec, obs);
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

        public List<InformeServiciosReplanificados> InformebuscarServiciosRePlanificadosRuta(string ini, string fin, string ruta)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();
                string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta,DATE_FORMAT(periodicidad.Fecha,'%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,planilla.Descripcion from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla where fecha between '" + ini + "' and '" + fin + "' and periodicidad.Estado='Replanificado' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Cod and lugartratamiento.Ruta='" + ruta + "' group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;";
                db.CreateCommand(sql);
                List<InformeServiciosReplanificados> ap = new List<InformeServiciosReplanificados>();
                DbDataReader result = db.Query();


                while (result.Read())
                {

                    string cla = result.GetString(0);
                    string tlugar = result.GetString(1);
                    string lug = result.GetString(2);
                    string plano = result.GetString(3);
                    string ru = result.GetString(4);
                    string fecha = result.GetString(5);
                    string tperiodicidad = result.GetString(6);
                    string ser = result.GetString(7);
                    string tec = result.GetString(8);
                    string obs = result.GetString(9);

                    InformeServiciosReplanificados a = new InformeServiciosReplanificados(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec, obs);
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

        public List<VisualizadorCheckcs> InformeCheck(string cod, string tec)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();
                string sql = "select  checkl.Fecha,planilla.numero, lugartratamiento.NombreTratamiento,group_concat(distinct servicio.Sigla),group_concat(distinct area.NombreArea),periodicidad.OTI, checkl.Certificado,plano.CodPlano,checkl.Observaciones from tecnicos, checkl, lugartratamiento, planilla, periodicidad,servicio, plano, area where lugartratamiento.Cod= planilla.LugarTratamiento_Cod and planilla.Cod= periodicidad.Planilla_Cod and periodicidad.Cod= checkl.periodicidad_Cod and servicio.Cod= periodicidad.Servicio_Cod and area.cod=periodicidad.area_cod and plano.LugarTratamiento_Cod= lugartratamiento.Cod and checkl.identificador='" + cod + "' and tecnicos.Nombre='"+tec+"' group by fecha, NombreTratamiento;;";
                db.CreateCommand(sql);
                List<VisualizadorCheckcs> ap = new List<VisualizadorCheckcs>();
                DbDataReader result = db.Query();


                while (result.Read())
                {

                    string codfech = result.GetString(0);
                    string codnumero = result.GetString(1);
                    string codlugar = result.GetString(2);
                    string codservicio = result.GetString(3);
                    string codarea = result.GetString(4);
                    string codoti = result.GetString(5);
                    string codcerti = result.GetString(6);
                    string codplano = result.GetString(7);
                    string doc = result.GetString(8);
                    VisualizadorCheckcs a = new VisualizadorCheckcs(codfech, codnumero, codlugar, codservicio, codarea,codoti,codcerti, codplano, doc);

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

        public List<Check> InformeCheckCod(string ini)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();
                string sql = "select checkl.identificador from checkl where checkl.tecnico='" + ini + "' group by identificador";
                db.CreateCommand(sql);
                List<Check> ap = new List<Check>();
                DbDataReader result = db.Query();


                while (result.Read())
                {

                    int cod = result.GetInt32(0);


                    //  CheckList a = new CheckList(codnumero,codlugar,codservicio,codnoti,codcertificado,codplano);
                    Check a = new Check(cod);

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

        public List<Check> InformeCheckTec(string ini)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();
                string sql = "select tecnico from checkl where Fecha = '"+ini+"' group by Tecnico;";
                db.CreateCommand(sql);
                List<Check> ap = new List<Check>();
                DbDataReader result = db.Query();


                while (result.Read())
                {

                    string tecnico = result.GetString(0);


                    //  CheckList a = new CheckList(codnumero,codlugar,codservicio,codnoti,codcertificado,codplano);
                    Check a = new Check(tecnico);

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
  public List<Check> getmaxcodcheck()
        {

            DataBase bd = new DataBase();
            bd.connect();
            List<Check> units = new List<Check>();
            string sql = "select ifnull(last_insert_id(max(Cod)+1),0) from checkl;";
            bd.CreateCommand(sql);

            DbDataReader result = bd.Query();

            while (result.Read())
            {
                Check u = new Check(result.GetInt32(0));
                units.Add(u);

            }
            result.Close();
            bd.close();
            return units;

        }


  public List<Check> getmaxidenticheck()
  {

      DataBase bd = new DataBase();
      bd.connect();
      List<Check> units = new List<Check>();
      string sql = "select ifnull(last_insert_id(max(identificador)+1),0) from checkl;";
      bd.CreateCommand(sql);

      DbDataReader result = bd.Query();

      while (result.Read())
      {
          Check u = new Check(result.GetInt32(0));
          units.Add(u);

      }
      result.Close();
      bd.close();
      return units;

  }
  public List<InformeModificadosclase> InformebuscarModificadoSoloFechas(string ini, string fin)
  {
      try
      {

          DataAccess.DataBase db = new DataBase();
          db.connect();
          string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta,DATE_FORMAT(periodicidad.Fecha,'%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,nota.Contenido from  cliente inner join lugartratamiento on cliente.Cod=lugartratamiento.Cliente_Cod inner join planilla on planilla.LugarTratamiento_Cod=lugartratamiento.Cod inner join periodicidad on periodicidad.Planilla_Cod=planilla.Cod and periodicidad.Fecha between '"+ini+"' and '"+fin+"'inner join servicio on servicio.Cod=periodicidad.Servicio_Cod inner join tecnicos on periodicidad.Tecnicos_Cod=tecnicos.cod inner join nota on nota.periodicidad_Cod=periodicidad.Cod and nota.Responsable='NModificado--'inner join plano on plano.LugarTratamiento_Cod=lugartratamiento.Cod group by  nota.Contenido ;";
          db.CreateCommand(sql);
          List<InformeModificadosclase> ap = new List<InformeModificadosclase>();
          DbDataReader result = db.Query();


          while (result.Read())
          {

              string cla = result.GetString(0);
              string tlugar = result.GetString(1);
              string lug = result.GetString(2);
              string plano = result.GetString(3);
              string ru = result.GetString(4);
              string fecha = result.GetString(5);
              string tperiodicidad = result.GetString(6);
              string ser = result.GetString(7);
              string tec = result.GetString(8);
              string obs = result.GetString(9);

              InformeModificadosclase a = new InformeModificadosclase(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec, obs);
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

  public List<InformeModificadosclase> InformebuscarModificadoClienteLugar(string ini, string fin, string cliente , string lugar)
  {
      try
      {

          DataAccess.DataBase db = new DataBase();
          db.connect();
          string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta,DATE_FORMAT(periodicidad.Fecha,'%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,nota.Contenido from  cliente inner join lugartratamiento on cliente.Cod=lugartratamiento.Cliente_Cod and cliente.Nombre='"+cliente+"' and lugartratamiento.NombreTratamiento='"+lugar+"' inner join planilla on planilla.LugarTratamiento_Cod=lugartratamiento.Cod inner join periodicidad on periodicidad.Planilla_Cod=planilla.Cod and periodicidad.Fecha between '"+ini+"' and '"+fin+"'inner join servicio on servicio.Cod=periodicidad.Servicio_Cod inner join tecnicos on periodicidad.Tecnicos_Cod=tecnicos.cod inner join nota on nota.periodicidad_Cod=periodicidad.Cod and nota.Responsable='NModificado--'inner join plano on plano.LugarTratamiento_Cod=lugartratamiento.Cod group by  nota.Contenido ;";
          db.CreateCommand(sql);
          List<InformeModificadosclase> ap = new List<InformeModificadosclase>();
          DbDataReader result = db.Query();


          while (result.Read())
          {

              string cla = result.GetString(0);
              string tlugar = result.GetString(1);
              string lug = result.GetString(2);
              string plano = result.GetString(3);
              string ru = result.GetString(4);
              string fecha = result.GetString(5);
              string tperiodicidad = result.GetString(6);
              string ser = result.GetString(7);
              string tec = result.GetString(8);
              string obs = result.GetString(9);

              InformeModificadosclase a = new InformeModificadosclase(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec, obs);
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

  public List<InformeDescripcionClasecs> InformebuscarDescripcionesClienteLugar(string ini, string fin, string cliente, string lugar)
  {
      try
      {

          DataAccess.DataBase db = new DataBase();
          db.connect();
          string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta,DATE_FORMAT(periodicidad.Fecha,'%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,periodicidad.DescripcionParticular,planilla.Descripcion from  cliente inner join lugartratamiento on cliente.Cod=lugartratamiento.Cliente_Cod and cliente.Nombre='" + cliente + "' and lugartratamiento.NombreTratamiento='" + lugar + "' inner join planilla on planilla.LugarTratamiento_Cod=lugartratamiento.Cod inner join periodicidad on periodicidad.Planilla_Cod=planilla.Cod and periodicidad.Fecha between '" + ini + "' and '" + fin + "'inner join servicio on servicio.Cod=periodicidad.Servicio_Cod inner join tecnicos on periodicidad.Tecnicos_Cod=tecnicos.cod inner join plano on plano.LugarTratamiento_Cod=lugartratamiento.Cod and (periodicidad.DescripcionParticular not like '' or planilla.Descripcion not like '') group by  plano.CodPlano,fecha order by fecha;  ;";
          db.CreateCommand(sql);
          List<InformeDescripcionClasecs> ap = new List<InformeDescripcionClasecs>();
          DbDataReader result = db.Query();


          while (result.Read())
          {

              string cla = result.GetString(0);
              string tlugar = result.GetString(1);
              string lug = result.GetString(2);
              string plano = result.GetString(3);
              string ru = result.GetString(4);
              string fecha = result.GetString(5);
              string tperiodicidad = result.GetString(6);
              string ser = result.GetString(7);
              string tec = result.GetString(8);
              string obspar = result.GetString(9);
              string obsgen = result.GetString(10);

              InformeDescripcionClasecs a = new InformeDescripcionClasecs(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec, obspar,obsgen);
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
  public List<InformeDescripcionClasecs> InformebuscarDescripcionesSoloFechas(string ini, string fin)
  {
      try
      {

          DataAccess.DataBase db = new DataBase();
          db.connect();
          string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta,DATE_FORMAT(periodicidad.Fecha,'%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,periodicidad.DescripcionParticular,planilla.Descripcion from  cliente inner join lugartratamiento on cliente.Cod=lugartratamiento.Cliente_Cod inner join planilla on planilla.LugarTratamiento_Cod=lugartratamiento.Cod inner join periodicidad on periodicidad.Planilla_Cod=planilla.Cod and periodicidad.Fecha between '" + ini + "' and '" + fin + "'inner join servicio on servicio.Cod=periodicidad.Servicio_Cod inner join tecnicos on periodicidad.Tecnicos_Cod=tecnicos.cod inner join plano on plano.LugarTratamiento_Cod=lugartratamiento.Cod and (periodicidad.DescripcionParticular not like '' or planilla.Descripcion not like '') group by  plano.CodPlano,fecha order by fecha;";
          db.CreateCommand(sql);
          List<InformeDescripcionClasecs> ap = new List<InformeDescripcionClasecs>();
          DbDataReader result = db.Query();


          while (result.Read())
          {

              string cla = result.GetString(0);
              string tlugar = result.GetString(1);
              string lug = result.GetString(2);
              string plano = result.GetString(3);
              string ru = result.GetString(4);
              string fecha = result.GetString(5);
              string tperiodicidad = result.GetString(6);
              string ser = result.GetString(7);
              string tec = result.GetString(8);
              string obspar = result.GetString(9);
              string obsgen = result.GetString(10);

              InformeDescripcionClasecs a = new InformeDescripcionClasecs(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec, obspar, obsgen);
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

 
  public List<InformeGraficos> InformebuscarGraficosFORDecimal(string ini, string fin, List<string> lista, int decima)
  {
      try
      {
          int index = 0;
          string nombre = "";
          DbDataReader result = null;
          List<InformeGraficos> ap = new List<InformeGraficos>();
          DataAccess.DataBase db = new DataBase();
          db.connect();
          for (int i = lista.Count; i > 0; i--)
          {

              nombre = lista[index].ToString();
              // string sql = "select DATE_FORMAT(periodicidad.Fecha,'%d-%m-%Y'), avg(periodicidad.Consumo),lugartratamiento.NombreTratamiento from periodicidad, lugartratamiento inner join planilla where periodicidad.Planilla_Cod=planilla.Cod and lugartratamiento.Cod=planilla.LugarTratamiento_Cod and periodicidad.Consumo!='0' and fecha between '" + ini + "' and '" + fin + "'and lugartratamiento.nombretratamiento='"+nombre+"' group by lugartratamiento.NombreTratamiento;";
              string sql = "select  DATE_FORMAT(periodicidad.Fecha,'%d-%m-%Y'), ROUND(avg(periodicidad.Consumo),'" + decima + "'),lugartratamiento.NombreTratamiento, count(oti) from periodicidad, lugartratamiento inner join planilla where  periodicidad.Planilla_Cod=planilla.Cod and lugartratamiento.Cod=planilla.LugarTratamiento_Cod and periodicidad.OTI!='' and Servicio_Cod=2 and Servicio_Cod= periodicidad.Servicio_Cod  and periodicidad.Estado='Realizado' and fecha between '" + ini + "' and '" + fin + "'and lugartratamiento.nombretratamiento='" + nombre + "' group by lugartratamiento.NombreTratamiento;";
              db.CreateCommand(sql);

              result = db.Query();


              while (result.Read())
              {
                  string fecha = result.GetString(0);
                  string lug = result.GetString(1);
                  string consumo = result.GetString(2);
                  string visitas = result.GetString(3);

                  InformeGraficos a = new InformeGraficos(fecha, lug, consumo, visitas);
                  ap.Add(a);

              }
              index++;
              result.Close();
          }
          //   result.Close();
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
  public List<InformeGraficos> InformebuscarGraficosFORDecimalMES(string ini, string fin, List<string> lista, int decima,string año)
  {
      try
      {
          int index = 0;
          string nombre = "";
          DbDataReader result = null;
          List<InformeGraficos> ap = new List<InformeGraficos>();
          DataAccess.DataBase db = new DataBase();
          db.connect();
          for (int i = lista.Count; i > 0; i--)
          {

              nombre = lista[index].ToString();
              // string sql = "select DATE_FORMAT(periodicidad.Fecha,'%d-%m-%Y'), avg(periodicidad.Consumo),lugartratamiento.NombreTratamiento from periodicidad, lugartratamiento inner join planilla where periodicidad.Planilla_Cod=planilla.Cod and lugartratamiento.Cod=planilla.LugarTratamiento_Cod and periodicidad.Consumo!='0' and fecha between '" + ini + "' and '" + fin + "'and lugartratamiento.nombretratamiento='"+nombre+"' group by lugartratamiento.NombreTratamiento;";
              string sql = "select  DATE_FORMAT(periodicidad.Fecha,'%d-%m-%Y'), ROUND(avg(periodicidad.Consumo),'" + decima + "'),lugartratamiento.NombreTratamiento, count(oti) from periodicidad, lugartratamiento inner join planilla where  periodicidad.Planilla_Cod=planilla.Cod and lugartratamiento.Cod=planilla.LugarTratamiento_Cod and periodicidad.OTI!='' and Servicio_Cod=2 and Servicio_Cod= periodicidad.Servicio_Cod and periodicidad.Estado='Realizado' and year(Fecha)='" + año + "'  and  month(fecha) between '" + ini + "' and '" + fin + "'and lugartratamiento.nombretratamiento='" + nombre + "' group by lugartratamiento.NombreTratamiento;";
              db.CreateCommand(sql);

              result = db.Query();


              while (result.Read())
              {
                  string fecha = result.GetString(0);
                  string lug = result.GetString(1);
                  string consumo = result.GetString(2);
                  string visitas = result.GetString(3);
                 
                  InformeGraficos a = new InformeGraficos(fecha, lug, consumo, visitas);
                  ap.Add(a);

              }
              index++;
              result.Close();
          }
          //   result.Close();
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
  public List<InformeGraficos> InformebuscarGraficosOTI(string ini, string fin, List<string> lista)
  {
      try
      {
          int index = 0;
          string nombre = "";
          DbDataReader result = null;
          List<InformeGraficos> ap = new List<InformeGraficos>();
          DataAccess.DataBase db = new DataBase();
          db.connect();
          for (int i = lista.Count; i > 0; i--)
          {

              nombre = lista[index].ToString();
              // string sql = "select DATE_FORMAT(periodicidad.Fecha,'%d-%m-%Y'), avg(periodicidad.Consumo),lugartratamiento.NombreTratamiento from periodicidad, lugartratamiento inner join planilla where periodicidad.Planilla_Cod=planilla.Cod and lugartratamiento.Cod=planilla.LugarTratamiento_Cod and periodicidad.Consumo!='0' and fecha between '" + ini + "' and '" + fin + "'and lugartratamiento.nombretratamiento='"+nombre+"' group by lugartratamiento.NombreTratamiento;";
              string sql = "select  lugartratamiento.NombreTratamiento, oti from periodicidad, lugartratamiento inner join planilla where  periodicidad.Planilla_Cod=planilla.Cod and lugartratamiento.Cod=planilla.LugarTratamiento_Cod and periodicidad.OTI!='' and Servicio_Cod=2 and Servicio_Cod= periodicidad.Servicio_Cod and periodicidad.Estado='Realizado'  and fecha between '" + ini + "' and '" + fin + "'and lugartratamiento.nombretratamiento='" + nombre + "'group by fecha;";
              db.CreateCommand(sql);

              result = db.Query();


              while (result.Read())
              {
                
                  string lug = result.GetString(0);
                  string visitas = result.GetString(1);

                  InformeGraficos a = new InformeGraficos(lug, visitas);
                  ap.Add(a);

              }
              index++;
              result.Close();
          }
          //   result.Close();
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
  public List<InformeGraficos> InformebuscarGraficosOTIMES(string ini, string fin, List<string> lista, string año)
  {
      try
      {
          int index = 0;
          string nombre = "";
          DbDataReader result = null;
          List<InformeGraficos> ap = new List<InformeGraficos>();
          DataAccess.DataBase db = new DataBase();
          db.connect();
          for (int i = lista.Count; i > 0; i--)
          {

              nombre = lista[index].ToString();
              // string sql = "select DATE_FORMAT(periodicidad.Fecha,'%d-%m-%Y'), avg(periodicidad.Consumo),lugartratamiento.NombreTratamiento from periodicidad, lugartratamiento inner join planilla where periodicidad.Planilla_Cod=planilla.Cod and lugartratamiento.Cod=planilla.LugarTratamiento_Cod and periodicidad.Consumo!='0' and fecha between '" + ini + "' and '" + fin + "'and lugartratamiento.nombretratamiento='"+nombre+"' group by lugartratamiento.NombreTratamiento;";
              string sql = "select  lugartratamiento.NombreTratamiento, oti from periodicidad, lugartratamiento inner join planilla where  periodicidad.Planilla_Cod=planilla.Cod and lugartratamiento.Cod=planilla.LugarTratamiento_Cod and periodicidad.OTI!='' and Servicio_Cod=2 and Servicio_Cod= periodicidad.Servicio_Cod and periodicidad.Estado='Realizado' and year(Fecha)='"+año+"'  and  month(fecha) between '"+ini+"' and '"+fin+"'and lugartratamiento.nombretratamiento='" + nombre + "' ;";
              db.CreateCommand(sql);

              result = db.Query();


              while (result.Read())
              {

                  string lug = result.GetString(0);
                  string visitas = result.GetString(1);

                  InformeGraficos a = new InformeGraficos(lug, visitas);
                  ap.Add(a);

              }
              index++;
              result.Close();
          }
          //   result.Close();
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
  public List<InformeGraficos> InformebuscarGraficosOTIMESNAME(string ini, string fin, List<string> lista, string año)
  {
      try
      {
          int index = 0;
          string nombre = "";
          DbDataReader result = null;
          List<InformeGraficos> ap = new List<InformeGraficos>();
          DataAccess.DataBase db = new DataBase();
          db.connect();
          for (int i = lista.Count; i > 0; i--)
          {

              nombre = lista[index].ToString();
              // string sql = "select DATE_FORMAT(periodicidad.Fecha,'%d-%m-%Y'), avg(periodicidad.Consumo),lugartratamiento.NombreTratamiento from periodicidad, lugartratamiento inner join planilla where periodicidad.Planilla_Cod=planilla.Cod and lugartratamiento.Cod=planilla.LugarTratamiento_Cod and periodicidad.Consumo!='0' and fecha between '" + ini + "' and '" + fin + "'and lugartratamiento.nombretratamiento='"+nombre+"' group by lugartratamiento.NombreTratamiento;";
              string sql = "select  DATE_FORMAT(periodicidad.Fecha,'%d-%m-%Y'), ROUND(avg(periodicidad.Consumo),1),lugartratamiento.NombreTratamiento, count(oti), monthname(Fecha) from periodicidad, lugartratamiento inner join planilla where  periodicidad.Planilla_Cod=planilla.Cod and lugartratamiento.Cod=planilla.LugarTratamiento_Cod and periodicidad.OTI!='' and Servicio_Cod=2 and Servicio_Cod= periodicidad.Servicio_Cod and periodicidad.Estado='Realizado' and year(Fecha)='"+año+"'  and  month(fecha) between '"+ini+"' and '"+fin+"'and lugartratamiento.nombretratamiento='"+nombre+"' group by month(Fecha) order by  month(Fecha) ;";
              db.CreateCommand(sql);

              result = db.Query();


              while (result.Read())
              {
                   string fecha = result.GetString(0);
                  string lug = result.GetString(2);
                  string consumo = result.GetString(1);
                  string visi = result.GetString(3);
                  string mes = result.GetString(4);

                  InformeGraficos a = new InformeGraficos(fecha, consumo, lug, visi, mes);
                  ap.Add(a);

              }
              index++;
              result.Close();
          }
          //   result.Close();
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
  public List<InformeGraficos> InformebuscarGraficosFOREnteros(string ini, string fin, List<string> lista)
  {
      try
      {
          int index = 0;
          string nombre = "";
          DbDataReader result = null;
          List<InformeGraficos> ap = new List<InformeGraficos>();
          DataAccess.DataBase db = new DataBase();
          db.connect();
          for (int i = lista.Count; i > 0; i--)
          {

              nombre = lista[index].ToString();
              // string sql = "select DATE_FORMAT(periodicidad.Fecha,'%d-%m-%Y'), avg(periodicidad.Consumo),lugartratamiento.NombreTratamiento from periodicidad, lugartratamiento inner join planilla where periodicidad.Planilla_Cod=planilla.Cod and lugartratamiento.Cod=planilla.LugarTratamiento_Cod and periodicidad.Consumo!='0' and fecha between '" + ini + "' and '" + fin + "'and lugartratamiento.nombretratamiento='"+nombre+"' group by lugartratamiento.NombreTratamiento;";
              string sql = "select  DATE_FORMAT(periodicidad.Fecha,'%d-%m-%Y'), ROUND(avg(periodicidad.Consumo),0),lugartratamiento.NombreTratamiento, count(oti) from periodicidad, lugartratamiento inner join planilla where  periodicidad.Planilla_Cod=planilla.Cod and lugartratamiento.Cod=planilla.LugarTratamiento_Cod and periodicidad.OTI!='' and Servicio_Cod=2 and Servicio_Cod= periodicidad.Servicio_Cod  and periodicidad.Estado='Realizado' and fecha between '" + ini + "' and '" + fin + "'and lugartratamiento.nombretratamiento='" + nombre + "' group by lugartratamiento.NombreTratamiento;";
              db.CreateCommand(sql);

              result = db.Query();


              while (result.Read())
              {
                  string fecha = result.GetString(0);
                  string lug = result.GetString(1);
                  string consumo = result.GetString(2);
                  string visitas = result.GetString(3);

                  InformeGraficos a = new InformeGraficos(fecha, lug, consumo, visitas);
                  ap.Add(a);

              }
              index++;
              result.Close();
          }
          //   result.Close();
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
  public List<InventariadoInformeNoConformidad> InformebuscarNoConformidadSoloFechas(string ini, string fin)
  {
      try
      {

          DataAccess.DataBase db = new DataBase();
          db.connect();
          string sql = "select periodicidad.OTI,cliente.Nombre, lugartratamiento.Cod, lugartratamiento.NombreTratamiento, tecnicos.Nombre, DATE_FORMAT(fecha, '%d-%m-%Y'),group_concat(distinct servicio.Sigla), sum(periodicidad.Tiempo),periodicidad.NoConformidad, DATE_FORMAT(fecha, '%M-%y') from periodicidad,lugartratamiento,cliente,servicio, planilla, tecnicos where periodicidad.Servicio_Cod=servicio.Cod and lugartratamiento.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod=lugartratamiento.Cod and planilla.Cod=periodicidad.Planilla_Cod and periodicidad.Fecha between '" + ini + "' and '" + fin + "' and periodicidad.NoConformidad not like '" + "" + "' and periodicidad.Tecnicos_Cod=tecnicos.Cod and periodicidad.Estado='Realizado' group by planilla.Cod, periodicidad.Fecha,lugartratamiento.NombreTratamiento;";
          db.CreateCommand(sql);
          List<InventariadoInformeNoConformidad> ap = new List<InventariadoInformeNoConformidad>();
          DbDataReader result = db.Query();


          while (result.Read())
          {

              string codnot = result.GetString(0);
              string codcli = result.GetString(1);
              string codlug = result.GetString(2);
              string codnomlug = result.GetString(3);
              string codtec = result.GetString(4);
              string fecha = result.GetString(5);
              string codser = result.GetString(6);
              string codtiempo = result.GetString(7);
              string noconfor = result.GetString(8);
              string fechaformat = result.GetString(9);
              
              InventariadoInformeNoConformidad a = new InventariadoInformeNoConformidad(codnot, codcli, codlug, codnomlug, codtec, fecha, codser, codtiempo, noconfor, fechaformat);
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
  public List<InventariadoInformeNoConformidad> InformebuscarNoConformidadSoloFechasSEPARADAS(string ini, string fin)
  {
      try
      {

          DataAccess.DataBase db = new DataBase();
          db.connect();
          string sql = "select periodicidad.OTI,cliente.Nombre, lugartratamiento.Cod, lugartratamiento.NombreTratamiento, tecnicos.Nombre, DATE_FORMAT(fecha, '%d-%m-%Y'),servicio.Sigla, sum(periodicidad.Tiempo),periodicidad.NoConformidad, DATE_FORMAT(fecha, '%M-%y') from periodicidad,lugartratamiento,cliente,servicio, planilla, tecnicos where periodicidad.Servicio_Cod=servicio.Cod and lugartratamiento.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod=lugartratamiento.Cod and planilla.Cod=periodicidad.Planilla_Cod and periodicidad.Fecha between '" + ini + "' and '" + fin + "' and periodicidad.NoConformidad not like '" + "" + "' and periodicidad.Tecnicos_Cod=tecnicos.Cod and periodicidad.Estado='Realizado' group by periodicidad.cod periodicidad.Fecha,lugartratamiento.NombreTratamiento,servicio.Sigla;";
          db.CreateCommand(sql);
          List<InventariadoInformeNoConformidad> ap = new List<InventariadoInformeNoConformidad>();
          DbDataReader result = db.Query();


          while (result.Read())
          {

              string codnot = result.GetString(0);
              string codcli = result.GetString(1);
              string codlug = result.GetString(2);
              string codnomlug = result.GetString(3);
              string codtec = result.GetString(4);
              string fecha = result.GetString(5);
              string codser = result.GetString(6);
              string codtiempo = result.GetString(7);
              string noconfor = result.GetString(8);
              string fechaformat = result.GetString(9);

              InventariadoInformeNoConformidad a = new InventariadoInformeNoConformidad(codnot, codcli, codlug, codnomlug, codtec, fecha, codser, codtiempo, noconfor, fechaformat);
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
  public List<InventariadoInformeNoConformidad> InformebuscarNoConformidadTodoParametro(string ini, string fin, string cliente, string tipo, string lugar, string ruta)
  {
      try
      {

          DataAccess.DataBase db = new DataBase();
          db.connect();
          string sql = "select periodicidad.OTI,cliente.Nombre, lugartratamiento.Cod, lugartratamiento.NombreTratamiento, tecnicos.Nombre, DATE_FORMAT(fecha, '%d-%m-%Y'),group_concat(distinct servicio.Sigla), sum(distinct(periodicidad.Tiempo)),periodicidad.NoConformidad, DATE_FORMAT(fecha, '%M-%y') from periodicidad,lugartratamiento,cliente,servicio, planilla, tecnicos where periodicidad.Servicio_Cod=servicio.Cod and lugartratamiento.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod=lugartratamiento.Cod and planilla.Cod=periodicidad.Planilla_Cod and periodicidad.Fecha between 'ini' and 'fin' and cliente.Nombre='" + cliente + "' and TipoLugar='" + tipo + "' and lugartratamiento.NombreTratamiento='" + lugar + "' and lugartratamiento.Ruta='" + ruta + "' and periodicidad.NoConformidad not like '' and periodicidad.Tecnicos_Cod=tecnicos.Cod and periodicidad.Estado!='Replanificado' and periodicidad.Estado='Realizado' group by planilla.Cod, tecnicos.Nombre,periodicidad.Fecha,lugartratamiento.NombreTratamiento order by periodicidad.Fecha;";
          db.CreateCommand(sql);
          List<InventariadoInformeNoConformidad> ap = new List<InventariadoInformeNoConformidad>();
          DbDataReader result = db.Query();


          while (result.Read())
          {

              string codnot = result.GetString(0);
              string codcli = result.GetString(1);
              string codlug = result.GetString(2);
              string codnomlug = result.GetString(3);
              string codtec = result.GetString(4);
              string fecha = result.GetString(5);
              string codser = result.GetString(6);
              string codtiempo = result.GetString(7);
              string noconfor = result.GetString(8);
              string fechaformat = result.GetString(9);

              InventariadoInformeNoConformidad a = new InventariadoInformeNoConformidad(codnot, codcli, codlug, codnomlug, codtec, fecha, codser, codtiempo, noconfor, fechaformat);
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
  public List<InventariadoInformeNoConformidad> InformebuscarNoConformidadTodoParametroSEPARADAS(string ini, string fin, string cliente, string tipo, string lugar, string ruta)
  {
      try
      {

          DataAccess.DataBase db = new DataBase();
          db.connect();
          string sql = "select periodicidad.OTI,cliente.Nombre, lugartratamiento.Cod, lugartratamiento.NombreTratamiento, tecnicos.Nombre, DATE_FORMAT(fecha, '%d-%m-%Y'), servicio.Sigla,sum(distinct(periodicidad.Tiempo)),periodicidad.NoConformidad, DATE_FORMAT(fecha, '%M-%y') from periodicidad,lugartratamiento,cliente,servicio, planilla, tecnicos where periodicidad.Servicio_Cod=servicio.Cod and lugartratamiento.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod=lugartratamiento.Cod and planilla.Cod=periodicidad.Planilla_Cod and periodicidad.Fecha between 'ini' and 'fin' and cliente.Nombre='" + cliente + "' and TipoLugar='" + tipo + "' and lugartratamiento.NombreTratamiento='" + lugar + "' and lugartratamiento.Ruta='" + ruta + "' and periodicidad.NoConformidad not like '' and periodicidad.Tecnicos_Cod=tecnicos.Cod and periodicidad.Estado!='Replanificado' and periodicidad.Estado='Realizado' group by periodicidad.Cod, tecnicos.Nombre,periodicidad.Fecha,lugartratamiento.NombreTratamiento,servicio.sigla order by periodicidad.Fecha;";
          db.CreateCommand(sql);
          List<InventariadoInformeNoConformidad> ap = new List<InventariadoInformeNoConformidad>();
          DbDataReader result = db.Query();


          while (result.Read())
          {

              string codnot = result.GetString(0);
              string codcli = result.GetString(1);
              string codlug = result.GetString(2);
              string codnomlug = result.GetString(3);
              string codtec = result.GetString(4);
              string fecha = result.GetString(5);
              string codser = result.GetString(6);
              string codtiempo = result.GetString(7);
              string noconfor = result.GetString(8);
              string fechaformat = result.GetString(9);

              InventariadoInformeNoConformidad a = new InventariadoInformeNoConformidad(codnot, codcli, codlug, codnomlug, codtec, fecha, codser, codtiempo, noconfor, fechaformat);
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
  public List<InventariadoInformeNoConformidad> InformebuscarNoConformidadSoloCLiente(string ini, string fin, string cliente)
  {
      try
      {

          DataAccess.DataBase db = new DataBase();
          db.connect();


          string sql = "select periodicidad.OTI,cliente.Nombre, lugartratamiento.Cod, lugartratamiento.NombreTratamiento, tecnicos.Nombre, DATE_FORMAT(fecha, '%d-%m-%Y'),group_concat(distinct servicio.Sigla),sum(distinct(periodicidad.Tiempo)),periodicidad.NoConformidad, DATE_FORMAT(fecha, '%M-%y') from periodicidad,lugartratamiento,cliente,servicio, planilla, tecnicos where periodicidad.Servicio_Cod=servicio.Cod and lugartratamiento.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod=lugartratamiento.Cod and planilla.Cod=periodicidad.Planilla_Cod and periodicidad.Fecha between '" + ini + "' and '" + fin + "'   and periodicidad.NoConformidad not like '' and periodicidad.Tecnicos_Cod=tecnicos.Cod and cliente.Nombre='" + cliente + "' and periodicidad.Estado!='Replanificado'and periodicidad.Estado='Realizado' group by planilla.Cod, tecnicos.Nombre,periodicidad.Fecha,lugartratamiento.NombreTratamiento order by periodicidad.Fecha;";
          db.CreateCommand(sql);
          List<InventariadoInformeNoConformidad> ap = new List<InventariadoInformeNoConformidad>();
          DbDataReader result = db.Query();


          while (result.Read())
          {

              string codnot = result.GetString(0);
              string codcli = result.GetString(1);
              string codlug = result.GetString(2);
              string codnomlug = result.GetString(3);
              string codtec = result.GetString(4);
              string fecha = result.GetString(5);
              string codser = result.GetString(6);
              string codtiempo = result.GetString(7);
              string noconfor = result.GetString(8);
              string fechaformat = result.GetString(9);

              InventariadoInformeNoConformidad a = new InventariadoInformeNoConformidad(codnot, codcli, codlug, codnomlug, codtec, fecha, codser, codtiempo, noconfor, fechaformat);
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
  public List<InventariadoInformeNoConformidad> InformebuscarNoConformidadSoloCLienteSEPARADAS(string ini, string fin, string cliente)
  {
      try
      {

          DataAccess.DataBase db = new DataBase();
          db.connect();


          string sql = "select periodicidad.OTI,cliente.Nombre, lugartratamiento.Cod, lugartratamiento.NombreTratamiento, tecnicos.Nombre, DATE_FORMAT(fecha, '%d-%m-%Y'),servicio.Sigla, sum(distinct(periodicidad.Tiempo)),periodicidad.NoConformidad, DATE_FORMAT(fecha, '%M-%y') from periodicidad,lugartratamiento,cliente,servicio, planilla, tecnicos where periodicidad.Servicio_Cod=servicio.Cod and lugartratamiento.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod=lugartratamiento.Cod and planilla.Cod=periodicidad.Planilla_Cod and periodicidad.Fecha between '" + ini + "' and '" + fin + "'   and periodicidad.NoConformidad not like '' and periodicidad.Tecnicos_Cod=tecnicos.Cod and cliente.Nombre='" + cliente + "' and periodicidad.Estado!='Replanificado'and periodicidad.Estado='Realizado' group by periodicidad.Cod, tecnicos.Nombre,periodicidad.Fecha,lugartratamiento.NombreTratamiento,servicio.sigla order by periodicidad.Fecha;";
          db.CreateCommand(sql);
          List<InventariadoInformeNoConformidad> ap = new List<InventariadoInformeNoConformidad>();
          DbDataReader result = db.Query();


          while (result.Read())
          {

              string codnot = result.GetString(0);
              string codcli = result.GetString(1);
              string codlug = result.GetString(2);
              string codnomlug = result.GetString(3);
              string codtec = result.GetString(4);
              string fecha = result.GetString(5);
              string codser = result.GetString(6);
              string codtiempo = result.GetString(7);
              string noconfor = result.GetString(8);
              string fechaformat = result.GetString(9);

              InventariadoInformeNoConformidad a = new InventariadoInformeNoConformidad(codnot, codcli, codlug, codnomlug, codtec, fecha, codser, codtiempo, noconfor, fechaformat);
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
  public List<InventariadoInformeNoConformidad> InformebuscarNoConformidadSoloClienteYTipo(string ini, string fin, string cliente, string fundos)
  {
      try
      {

          DataAccess.DataBase db = new DataBase();
          db.connect();


          string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta, DATE_FORMAT(fecha, '%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,periodicidad.OTI,periodicidad.Consumo, sum(distinct(periodicidad.Tiempo)) from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla where fecha between '" + ini + "' and '" + fin + "'  and periodicidad.Estado= 'Realizado' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Cod and cliente.Nombre='" + cliente + "'and lugartratamiento.TipoLugar='" + fundos + "'periodicidad.NoConformidad not like '' and periodicidad.Estado!='Replanificado'and periodicidad.Estado='Realizado' group by planilla.Cod, tecnicos.Nombre,periodicidad.Fecha,lugartratamiento.NombreTratamiento order by periodicidad.Fecha ;";
          db.CreateCommand(sql);
          List<InventariadoInformeNoConformidad> ap = new List<InventariadoInformeNoConformidad>();
          DbDataReader result = db.Query();


          while (result.Read())
          {

              string codnot = result.GetString(0);
              string codcli = result.GetString(1);
              string codlug = result.GetString(2);
              string codnomlug = result.GetString(3);
              string codtec = result.GetString(4);
              string fecha = result.GetString(5);
              string codser = result.GetString(6);
              string codtiempo = result.GetString(7);
              string noconfor = result.GetString(8);
              string fechaformat = result.GetString(9);

              InventariadoInformeNoConformidad a = new InventariadoInformeNoConformidad(codnot, codcli, codlug, codnomlug, codtec, fecha, codser, codtiempo, noconfor, fechaformat);
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
  public List<InventariadoInformeNoConformidad> InformebuscarNoConformidadSoloClienteYTipoSEPARADAS(string ini, string fin, string cliente, string fundos)
  {
      try
      {

          DataAccess.DataBase db = new DataBase();
          db.connect();


          string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta, DATE_FORMAT(fecha, '%d-%m-%Y'), periodicidad.TipoPeridodicidad, servicio.Sigla, tecnicos.Nombre,periodicidad.OTI,periodicidad.Consumo, sum(distinct(periodicidad.Tiempo))  from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla where fecha between '" + ini + "' and '" + fin + "'  and periodicidad.Estado= 'Realizado' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Cod and cliente.Nombre='" + cliente + "'and lugartratamiento.TipoLugar='" + fundos + "'periodicidad.NoConformidad not like '' and periodicidad.Estado!='Replanificado'and periodicidad.Estado='Realizado' group by periodicidad.Cod, tecnicos.Nombre,periodicidad.Fecha,lugartratamiento.NombreTratamiento,servicio.Sigla order by periodicidad.Fecha;";
          db.CreateCommand(sql);
          List<InventariadoInformeNoConformidad> ap = new List<InventariadoInformeNoConformidad>();
          DbDataReader result = db.Query();


          while (result.Read())
          {

              string codnot = result.GetString(0);
              string codcli = result.GetString(1);
              string codlug = result.GetString(2);
              string codnomlug = result.GetString(3);
              string codtec = result.GetString(4);
              string fecha = result.GetString(5);
              string codser = result.GetString(6);
              string codtiempo = result.GetString(7);
              string noconfor = result.GetString(8);
              string fechaformat = result.GetString(9);

              InventariadoInformeNoConformidad a = new InventariadoInformeNoConformidad(codnot, codcli, codlug, codnomlug, codtec, fecha, codser, codtiempo, noconfor, fechaformat);
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
  public List<InventariadoInformeNoConformidad> InformebuscarNoConformidadSoloTipo(string ini, string fin, string fundos)
  {
      try
      {

          DataAccess.DataBase db = new DataBase();
          db.connect();


          string sql = "select periodicidad.OTI,cliente.Nombre, lugartratamiento.Cod, lugartratamiento.NombreTratamiento, tecnicos.Nombre, DATE_FORMAT(fecha, '%d-%m-%Y'),group_concat(distinct servicio.Sigla), sum(distinct(periodicidad.Tiempo)),periodicidad.NoConformidad, DATE_FORMAT(fecha, '%M-%y') from periodicidad,lugartratamiento,cliente,servicio, planilla, tecnicos where periodicidad.Servicio_Cod=servicio.Cod and lugartratamiento.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod=lugartratamiento.Cod and planilla.Cod=periodicidad.Planilla_Cod and periodicidad.Fecha between '" + ini + "' and '" + fin + "'   and periodicidad.NoConformidad not like '' and periodicidad.Tecnicos_Cod=tecnicos.Cod  and lugartratamiento.TipoLugar='" + fundos + "' and periodicidad.Estado!='Replanificado' and periodicidad.Estado='Realizado' group by planilla.Cod, tecnicos.Nombre,periodicidad.Fecha,lugartratamiento.NombreTratamiento order by periodicidad.Fecha;";
          db.CreateCommand(sql);
          List<InventariadoInformeNoConformidad> ap = new List<InventariadoInformeNoConformidad>();
          DbDataReader result = db.Query();


          while (result.Read())
          {

              string codnot = result.GetString(0);
              string codcli = result.GetString(1);
              string codlug = result.GetString(2);
              string codnomlug = result.GetString(3);
              string codtec = result.GetString(4);
              string fecha = result.GetString(5);
              string codser = result.GetString(6);
              string codtiempo = result.GetString(7);
              string noconfor = result.GetString(8);
              string fechaformat = result.GetString(9);

              InventariadoInformeNoConformidad a = new InventariadoInformeNoConformidad(codnot, codcli, codlug, codnomlug, codtec, fecha, codser, codtiempo, noconfor, fechaformat);
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
  public List<InventariadoInformeNoConformidad> InformebuscarNoConformidadSoloTipoSEPARADAS(string ini, string fin, string fundos)
  {
      try
      {

          DataAccess.DataBase db = new DataBase();
          db.connect();


          string sql = "select periodicidad.OTI,cliente.Nombre, lugartratamiento.Cod, lugartratamiento.NombreTratamiento, tecnicos.Nombre, DATE_FORMAT(fecha, '%d-%m-%Y'),servicio.Sigla, sum(distinct(periodicidad.Tiempo)),periodicidad.NoConformidad, DATE_FORMAT(fecha, '%M-%y') from periodicidad,lugartratamiento,cliente,servicio, planilla, tecnicos where periodicidad.Servicio_Cod=servicio.Cod and lugartratamiento.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod=lugartratamiento.Cod and planilla.Cod=periodicidad.Planilla_Cod and periodicidad.Fecha between '" + ini + "' and '" + fin + "'   and periodicidad.NoConformidad not like '' and periodicidad.Tecnicos_Cod=tecnicos.Cod  and lugartratamiento.TipoLugar='" + fundos + "' and periodicidad.Estado!='Replanificado'and periodicidad.Estado='Realizado' group by periodicidad.Cod, tecnicos.Nombre,periodicidad.Fecha,lugartratamiento.NombreTratamiento,servicio.Sigla order by periodicidad.Fecha;";
          db.CreateCommand(sql);
          List<InventariadoInformeNoConformidad> ap = new List<InventariadoInformeNoConformidad>();
          DbDataReader result = db.Query();


          while (result.Read())
          {

              string codnot = result.GetString(0);
              string codcli = result.GetString(1);
              string codlug = result.GetString(2);
              string codnomlug = result.GetString(3);
              string codtec = result.GetString(4);
              string fecha = result.GetString(5);
              string codser = result.GetString(6);
              string codtiempo = result.GetString(7);
              string noconfor = result.GetString(8);
              string fechaformat = result.GetString(9);

              InventariadoInformeNoConformidad a = new InventariadoInformeNoConformidad(codnot, codcli, codlug, codnomlug, codtec, fecha, codser, codtiempo, noconfor, fechaformat);
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
  public List<InventariadoInformeNoConformidad> InformebuscarNoConformidadSoloLugar(string ini, string fin, string lugar)
  {
      try
      {

          DataAccess.DataBase db = new DataBase();
          db.connect();


          string sql = "select periodicidad.OTI,cliente.Nombre, lugartratamiento.Cod, lugartratamiento.NombreTratamiento, tecnicos.Nombre, DATE_FORMAT(fecha, '%d-%m-%Y'),group_concat(distinct servicio.Sigla), sum(distinct(periodicidad.Tiempo)),periodicidad.NoConformidad, DATE_FORMAT(fecha, '%M-%y') from periodicidad,lugartratamiento,cliente,servicio, planilla, tecnicos where periodicidad.Servicio_Cod=servicio.Cod and lugartratamiento.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod=lugartratamiento.Cod and planilla.Cod=periodicidad.Planilla_Cod and periodicidad.Fecha between '" + ini + "' and '" + fin + "'   and periodicidad.NoConformidad not like '' and periodicidad.Tecnicos_Cod=tecnicos.Cod   and lugartratamiento.NombreTratamiento='" + lugar + "' and periodicidad.Estado!='Replanificado'and periodicidad.Estado='Realizado' group by planilla.Cod, tecnicos.Nombre,periodicidad.Fecha,lugartratamiento.NombreTratamiento order by periodicidad.Fecha;";
          db.CreateCommand(sql);
          List<InventariadoInformeNoConformidad> ap = new List<InventariadoInformeNoConformidad>();
          DbDataReader result = db.Query();


          while (result.Read())
          {

              string codnot = result.GetString(0);
              string codcli = result.GetString(1);
              string codlug = result.GetString(2);
              string codnomlug = result.GetString(3);
              string codtec = result.GetString(4);
              string fecha = result.GetString(5);
              string codser = result.GetString(6);
              string codtiempo = result.GetString(7);
              string noconfor = result.GetString(8);
              string fechaformat = result.GetString(9);

              InventariadoInformeNoConformidad a = new InventariadoInformeNoConformidad(codnot, codcli, codlug, codnomlug, codtec, fecha, codser, codtiempo, noconfor, fechaformat);
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
  public List<InventariadoInformeNoConformidad> InformebuscarNoConformidadSoloLugarSEPARADAS(string ini, string fin, string lugar)
  {
      try
      {

          DataAccess.DataBase db = new DataBase();
          db.connect();


          string sql = "select periodicidad.OTI,cliente.Nombre, lugartratamiento.Cod, lugartratamiento.NombreTratamiento, tecnicos.Nombre, DATE_FORMAT(fecha, '%d-%m-%Y'),servicio.Sigla, sum(distinct(periodicidad.Tiempo)),periodicidad.NoConformidad, DATE_FORMAT(fecha, '%M-%y') from periodicidad,lugartratamiento,cliente,servicio, planilla, tecnicos where periodicidad.Servicio_Cod=servicio.Cod and lugartratamiento.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod=lugartratamiento.Cod and planilla.Cod=periodicidad.Planilla_Cod and periodicidad.Fecha between '" + ini + "' and '" + fin + "'   and periodicidad.NoConformidad not like '' and periodicidad.Tecnicos_Cod=tecnicos.Cod   and lugartratamiento.NombreTratamiento='" + lugar + "' and periodicidad.Estado!='Replanificado'and periodicidad.Estado='Realizado' group by periodicidad.Cod, tecnicos.Nombre,periodicidad.Fecha,lugartratamiento.NombreTratamiento,servicio.Sigla order by periodicidad.Fecha;";
          db.CreateCommand(sql);
          List<InventariadoInformeNoConformidad> ap = new List<InventariadoInformeNoConformidad>();
          DbDataReader result = db.Query();


          while (result.Read())
          {

              string codnot = result.GetString(0);
              string codcli = result.GetString(1);
              string codlug = result.GetString(2);
              string codnomlug = result.GetString(3);
              string codtec = result.GetString(4);
              string fecha = result.GetString(5);
              string codser = result.GetString(6);
              string codtiempo = result.GetString(7);
              string noconfor = result.GetString(8);
              string fechaformat = result.GetString(9);

              InventariadoInformeNoConformidad a = new InventariadoInformeNoConformidad(codnot, codcli, codlug, codnomlug, codtec, fecha, codser, codtiempo, noconfor, fechaformat);
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
  public List<InventariadoInformeNoConformidad> InformebuscarNoConformidadClienteYLugar(string ini, string fin, string cliente, string lugar)
  {
      try
      {

          DataAccess.DataBase db = new DataBase();
          db.connect();


          string sql = "select periodicidad.OTI,cliente.Nombre, lugartratamiento.Cod, lugartratamiento.NombreTratamiento, tecnicos.Nombre, DATE_FORMAT(fecha, '%d-%m-%Y'),group_concat(distinct servicio.Sigla), sum(distinct(periodicidad.Tiempo)),periodicidad.NoConformidad, DATE_FORMAT(fecha, '%M-%y') from periodicidad,lugartratamiento,cliente,servicio, planilla, tecnicos where periodicidad.Servicio_Cod=servicio.Cod and lugartratamiento.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod=lugartratamiento.Cod and planilla.Cod=periodicidad.Planilla_Cod and periodicidad.Fecha between '" + ini + "' and '" + fin + "'   and periodicidad.NoConformidad not like '' and periodicidad.Tecnicos_Cod=tecnicos.Cod  and cliente.Nombre='" + cliente + "'   and lugartratamiento.NombreTratamiento='" + lugar + "' and periodicidad.Estado!='Replanificado'and periodicidad.Estado='Realizado' group by planilla.Cod, tecnicos.Nombre,periodicidad.Fecha,lugartratamiento.NombreTratamiento order by periodicidad.Fecha;";
          db.CreateCommand(sql);
          List<InventariadoInformeNoConformidad> ap = new List<InventariadoInformeNoConformidad>();
          DbDataReader result = db.Query();


          while (result.Read())
          {

              string codnot = result.GetString(0);
              string codcli = result.GetString(1);
              string codlug = result.GetString(2);
              string codnomlug = result.GetString(3);
              string codtec = result.GetString(4);
              string fecha = result.GetString(5);
              string codser = result.GetString(6);
              string codtiempo = result.GetString(7);
              string noconfor = result.GetString(8);
              string fechaformat = result.GetString(9);

              InventariadoInformeNoConformidad a = new InventariadoInformeNoConformidad(codnot, codcli, codlug, codnomlug, codtec, fecha, codser, codtiempo, noconfor, fechaformat);
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
  public List<InventariadoInformeNoConformidad> InformebuscarNoConformidadClienteYLugarSEPARADAS(string ini, string fin, string cliente, string lugar)
  {
      try
      {

          DataAccess.DataBase db = new DataBase();
          db.connect();


          string sql = "select periodicidad.OTI,cliente.Nombre, lugartratamiento.Cod, lugartratamiento.NombreTratamiento, tecnicos.Nombre, DATE_FORMAT(fecha, '%d-%m-%Y'),servicio.Sigla, sum(distinct(periodicidad.Tiempo)),periodicidad.NoConformidad, DATE_FORMAT(fecha, '%M-%y') from periodicidad,lugartratamiento,cliente,servicio, planilla, tecnicos where periodicidad.Servicio_Cod=servicio.Cod and lugartratamiento.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod=lugartratamiento.Cod and planilla.Cod=periodicidad.Planilla_Cod and periodicidad.Fecha between '" + ini + "' and '" + fin + "'   and periodicidad.NoConformidad not like '' and periodicidad.Tecnicos_Cod=tecnicos.Cod  and cliente.Nombre='" + cliente + "'  and lugartratamiento.NombreTratamiento='" + lugar + "' and periodicidad.Estado!='Replanificado'and periodicidad.Estado='Realizado' group by periodicidad.Cod, tecnicos.Nombre,periodicidad.Fecha,lugartratamiento.NombreTratamiento,servicio.Sigla order by periodicidad.Fecha;";
          db.CreateCommand(sql);
          List<InventariadoInformeNoConformidad> ap = new List<InventariadoInformeNoConformidad>();
          DbDataReader result = db.Query();


          while (result.Read())
          {

              string codnot = result.GetString(0);
              string codcli = result.GetString(1);
              string codlug = result.GetString(2);
              string codnomlug = result.GetString(3);
              string codtec = result.GetString(4);
              string fecha = result.GetString(5);
              string codser = result.GetString(6);
              string codtiempo = result.GetString(7);
              string noconfor = result.GetString(8);
              string fechaformat = result.GetString(9);

              InventariadoInformeNoConformidad a = new InventariadoInformeNoConformidad(codnot, codcli, codlug, codnomlug, codtec, fecha, codser, codtiempo, noconfor, fechaformat);
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
  public List<InventariadoInformeNoConformidad> InformebuscarNoConformidadSoloRuta(string ini, string fin, string ruta)
  {
      try
      {

          DataAccess.DataBase db = new DataBase();
          db.connect();


          string sql = "select periodicidad.OTI,cliente.Nombre, lugartratamiento.Cod, lugartratamiento.NombreTratamiento, tecnicos.Nombre, DATE_FORMAT(fecha, '%d-%m-%Y'),group_concat(distinct servicio.Sigla), sum(distinct(periodicidad.Tiempo)),periodicidad.NoConformidad, DATE_FORMAT(fecha, '%M-%y') from periodicidad,lugartratamiento,cliente,servicio, planilla, tecnicos where periodicidad.Servicio_Cod=servicio.Cod and lugartratamiento.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod=lugartratamiento.Cod and planilla.Cod=periodicidad.Planilla_Cod and periodicidad.Fecha between '" + ini + "' and '" + fin + "'   and periodicidad.NoConformidad not like '' and periodicidad.Tecnicos_Cod=tecnicos.Cod  and lugartratamiento.Ruta='" + ruta + "' and periodicidad.Estado!='Replanificado'and periodicidad.Estado='Realizado' group by planilla.Cod, tecnicos.Nombre,periodicidad.Fecha,lugartratamiento.NombreTratamiento order by periodicidad.Fecha;";
          db.CreateCommand(sql);
          List<InventariadoInformeNoConformidad> ap = new List<InventariadoInformeNoConformidad>();
          DbDataReader result = db.Query();


          while (result.Read())
          {

              string codnot = result.GetString(0);
              string codcli = result.GetString(1);
              string codlug = result.GetString(2);
              string codnomlug = result.GetString(3);
              string codtec = result.GetString(4);
              string fecha = result.GetString(5);
              string codser = result.GetString(6);
              string codtiempo = result.GetString(7);
              string noconfor = result.GetString(8);
              string fechaformat = result.GetString(9);

              InventariadoInformeNoConformidad a = new InventariadoInformeNoConformidad(codnot, codcli, codlug, codnomlug, codtec, fecha, codser, codtiempo, noconfor, fechaformat);
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
  public List<InventariadoInformeNoConformidad> InformebuscarNoConformidadSoloRutaSEPARADAS(string ini, string fin, string ruta)
  {
      try
      {

          DataAccess.DataBase db = new DataBase();
          db.connect();


          string sql = "select periodicidad.OTI,cliente.Nombre, lugartratamiento.Cod, lugartratamiento.NombreTratamiento, tecnicos.Nombre, DATE_FORMAT(fecha, '%d-%m-%Y'),servicio.Sigla,sum(distinct(periodicidad.Tiempo)),periodicidad.NoConformidad, DATE_FORMAT(fecha, '%M-%y') from periodicidad,lugartratamiento,cliente,servicio, planilla, tecnicos where periodicidad.Servicio_Cod=servicio.Cod and lugartratamiento.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod=lugartratamiento.Cod and planilla.Cod=periodicidad.Planilla_Cod and periodicidad.Fecha between '" + ini + "' and '" + fin + "'   and periodicidad.NoConformidad not like '' and periodicidad.Tecnicos_Cod=tecnicos.Cod  and lugartratamiento.Ruta='" + ruta + "' and periodicidad.Estado!='Replanificado' and periodicidad.Estado='Realizado' group by periodicidad.Cod, tecnicos.Nombre,periodicidad.Fecha,lugartratamiento.NombreTratamiento,servicio.Sigla order by periodicidad.Fecha;";
          db.CreateCommand(sql);
          List<InventariadoInformeNoConformidad> ap = new List<InventariadoInformeNoConformidad>();
          DbDataReader result = db.Query();


          while (result.Read())
          {

              string codnot = result.GetString(0);
              string codcli = result.GetString(1);
              string codlug = result.GetString(2);
              string codnomlug = result.GetString(3);
              string codtec = result.GetString(4);
              string fecha = result.GetString(5);
              string codser = result.GetString(6);
              string codtiempo = result.GetString(7);
              string noconfor = result.GetString(8);
              string fechaformat = result.GetString(9);

              InventariadoInformeNoConformidad a = new InventariadoInformeNoConformidad(codnot, codcli, codlug, codnomlug, codtec, fecha, codser, codtiempo, noconfor, fechaformat);
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
  public List<InventariadoInformeNoConformidad> InformebuscarNoConformidadSoloTecnicos(string ini, string fin, string tecnicos)
  {
      try
      {

          DataAccess.DataBase db = new DataBase();
          db.connect();


          string sql = "select periodicidad.OTI,cliente.Nombre, lugartratamiento.Cod, lugartratamiento.NombreTratamiento, tecnicos.Nombre, DATE_FORMAT(fecha, '%d-%m-%Y'),group_concat(distinct servicio.Sigla), sum(distinct(periodicidad.Tiempo)),periodicidad.NoConformidad, DATE_FORMAT(fecha, '%M-%y') from periodicidad,lugartratamiento,cliente,servicio, planilla, tecnicos where periodicidad.Servicio_Cod=servicio.Cod and lugartratamiento.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod=lugartratamiento.Cod and planilla.Cod=periodicidad.Planilla_Cod and periodicidad.Fecha between '" + ini + "' and '" + fin + "'   and periodicidad.NoConformidad not like '' and periodicidad.Tecnicos_Cod=tecnicos.Cod   and tecnicos.Nombre='" + tecnicos + "' and periodicidad.Estado!='Replanificado'and periodicidad.Estado='Realizado' group by planilla.Cod, tecnicos.Nombre,periodicidad.Fecha,lugartratamiento.NombreTratamiento order by periodicidad.Fecha;";
          db.CreateCommand(sql);
          List<InventariadoInformeNoConformidad> ap = new List<InventariadoInformeNoConformidad>();
          DbDataReader result = db.Query();
          while (result.Read())
          {

              string codnot = result.GetString(0);
              string codcli = result.GetString(1);
              string codlug = result.GetString(2);
              string codnomlug = result.GetString(3);
              string codtec = result.GetString(4);
              string fecha = result.GetString(5);
              string codser = result.GetString(6);
              string codtiempo = result.GetString(7);
              string noconfor = result.GetString(8);
              string fechaformat = result.GetString(9);

              InventariadoInformeNoConformidad a = new InventariadoInformeNoConformidad(codnot, codcli, codlug, codnomlug, codtec, fecha, codser, codtiempo, noconfor, fechaformat);
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
  public List<InventariadoInformeNoConformidad> InformebuscarNoConformidadSoloTecnicosSEPARADAS(string ini, string fin, string tecnicos)
  {
      try
      {

          DataAccess.DataBase db = new DataBase();
          db.connect();


          string sql = "select periodicidad.OTI,cliente.Nombre, lugartratamiento.Cod, lugartratamiento.NombreTratamiento, tecnicos.Nombre, DATE_FORMAT(fecha, '%d-%m-%Y'),servicio.Sigla,sum(distinct(periodicidad.Tiempo)),periodicidad.NoConformidad, DATE_FORMAT(fecha, '%M-%y') from periodicidad,lugartratamiento,cliente,servicio, planilla, tecnicos where periodicidad.Servicio_Cod=servicio.Cod and lugartratamiento.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod=lugartratamiento.Cod and planilla.Cod=periodicidad.Planilla_Cod and periodicidad.Fecha between '" + ini + "' and '" + fin + "'   and periodicidad.NoConformidad not like '' and periodicidad.Tecnicos_Cod=tecnicos.Cod   and tecnicos.Nombre='" + tecnicos + "' and periodicidad.Estado!='Replanificado'and periodicidad.Estado='Realizado' group by periodicidad.Cod, tecnicos.Nombre, periodicidad.Fecha,lugartratamiento.NombreTratamiento,servicio.Sigla order by periodicidad.Fecha;";
          db.CreateCommand(sql);
          List<InventariadoInformeNoConformidad> ap = new List<InventariadoInformeNoConformidad>();
          DbDataReader result = db.Query();
          while (result.Read())
          {

              string codnot = result.GetString(0);
              string codcli = result.GetString(1);
              string codlug = result.GetString(2);
              string codnomlug = result.GetString(3);
              string codtec = result.GetString(4);
              string fecha = result.GetString(5);
              string codser = result.GetString(6);
              string codtiempo = result.GetString(7);
              string noconfor = result.GetString(8);
              string fechaformat = result.GetString(9);

              InventariadoInformeNoConformidad a = new InventariadoInformeNoConformidad(codnot, codcli, codlug, codnomlug, codtec, fecha, codser, codtiempo, noconfor, fechaformat);
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
  public List<InventariadoInformeNoConformidad> InformebuscarNoConformidadTecnicosYLugar(string ini, string fin, string tecnicos, string lugar)
  {
      try
      {

          DataAccess.DataBase db = new DataBase();
          db.connect();


          string sql = "select periodicidad.OTI,cliente.Nombre, lugartratamiento.Cod, lugartratamiento.NombreTratamiento, tecnicos.Nombre, DATE_FORMAT(fecha, '%d-%m-%Y'),group_concat(distinct servicio.Sigla), sum(distinct(periodicidad.Tiempo)),periodicidad.NoConformidad, DATE_FORMAT(fecha, '%M-%y') from periodicidad,lugartratamiento,cliente,servicio, planilla, tecnicos where periodicidad.Servicio_Cod=servicio.Cod and lugartratamiento.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod=lugartratamiento.Cod and planilla.Cod=periodicidad.Planilla_Cod and periodicidad.Fecha between '" + ini + "' and '" + fin + "'   and periodicidad.NoConformidad not like '' and periodicidad.Tecnicos_Cod=tecnicos.Cod   and tecnicos.Nombre='" + tecnicos + "'and lugartratamiento.NombreTratamiento='" + lugar + "' and periodicidad.Estado!='Replanificado'and periodicidad.Estado='Realizado' group by planilla.Cod, tecnicos.Nombre,periodicidad.Fecha,lugartratamiento.NombreTratamiento order by periodicidad.Fecha;";
          db.CreateCommand(sql);
          List<InventariadoInformeNoConformidad> ap = new List<InventariadoInformeNoConformidad>();
          DbDataReader result = db.Query();
          while (result.Read())
          {

              string codnot = result.GetString(0);
              string codcli = result.GetString(1);
              string codlug = result.GetString(2);
              string codnomlug = result.GetString(3);
              string codtec = result.GetString(4);
              string fecha = result.GetString(5);
              string codser = result.GetString(6);
              string codtiempo = result.GetString(7);
              string noconfor = result.GetString(8);
              string fechaformat = result.GetString(9);

              InventariadoInformeNoConformidad a = new InventariadoInformeNoConformidad(codnot, codcli, codlug, codnomlug, codtec, fecha, codser, codtiempo, noconfor, fechaformat);
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
  public List<InventariadoInformeNoConformidad> InformebuscarNoConformidadTecnicosYLugarSEPERADAS(string ini, string fin, string tecnicos, string lugar)
  {
      try
      {

          DataAccess.DataBase db = new DataBase();
          db.connect();


          string sql = "select periodicidad.OTI,cliente.Nombre, lugartratamiento.Cod, lugartratamiento.NombreTratamiento, tecnicos.Nombre, DATE_FORMAT(fecha, '%d-%m-%Y'),servicio.Sigla, sum(distinct(periodicidad.Tiempo)),periodicidad.NoConformidad, DATE_FORMAT(fecha, '%M-%y') from periodicidad,lugartratamiento,cliente,servicio, planilla, tecnicos where periodicidad.Servicio_Cod=servicio.Cod and lugartratamiento.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod=lugartratamiento.Cod and planilla.Cod=periodicidad.Planilla_Cod and periodicidad.Fecha between '" + ini + "' and '" + fin + "'   and periodicidad.NoConformidad not like '' and periodicidad.Tecnicos_Cod=tecnicos.Cod   and tecnicos.Nombre='" + tecnicos + "'and lugartratamiento.NombreTratamiento='" + lugar + "' and periodicidad.Estado!='Replanificado' and periodicidad.Estado='Realizado' group by periodicidad.Cod, tecnicos.Nombre,periodicidad.Fecha,lugartratamiento.NombreTratamiento,servicio.Sigla order by periodicidad.Fecha;";
          db.CreateCommand(sql);
          List<InventariadoInformeNoConformidad> ap = new List<InventariadoInformeNoConformidad>();
          DbDataReader result = db.Query();
          while (result.Read())
          {

              string codnot = result.GetString(0);
              string codcli = result.GetString(1);
              string codlug = result.GetString(2);
              string codnomlug = result.GetString(3);
              string codtec = result.GetString(4);
              string fecha = result.GetString(5);
              string codser = result.GetString(6);
              string codtiempo = result.GetString(7);
              string noconfor = result.GetString(8);
              string fechaformat = result.GetString(9);

              InventariadoInformeNoConformidad a = new InventariadoInformeNoConformidad(codnot, codcli, codlug, codnomlug, codtec, fecha, codser, codtiempo, noconfor, fechaformat);
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
  public List<InventariadoInformeNoConformidad> InformebuscarNoConformidadTipoPeriodicidad(string ini, string fin, string tipo)
  {
      try
      {

          DataAccess.DataBase db = new DataBase();
          db.connect();


          string sql = "select periodicidad.OTI,cliente.Nombre, lugartratamiento.Cod, lugartratamiento.NombreTratamiento, tecnicos.Nombre, DATE_FORMAT(fecha, '%d-%m-%Y'),group_concat(distinct servicio.Sigla), sum(distinct(periodicidad.Tiempo)),periodicidad.NoConformidad, DATE_FORMAT(fecha, '%M-%y') from periodicidad,lugartratamiento,cliente,servicio, planilla, tecnicos where periodicidad.Servicio_Cod=servicio.Cod and lugartratamiento.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod=lugartratamiento.Cod and planilla.Cod=periodicidad.Planilla_Cod and periodicidad.Fecha between '" + ini + "' and '" + fin + "'   and periodicidad.NoConformidad not like '' and periodicidad.Tecnicos_Cod=tecnicos.Cod    and periodicidad.TipoPeridodicidad='" + tipo + "'and periodicidad.Estado!='Replanificado' and periodicidad.Estado='Realizado' group by planilla.Cod, tecnicos.Nombre,periodicidad.Fecha,lugartratamiento.NombreTratamiento order by periodicidad.Fecha;";
          db.CreateCommand(sql);
          List<InventariadoInformeNoConformidad> ap = new List<InventariadoInformeNoConformidad>();
          DbDataReader result = db.Query();
          while (result.Read())
          {

              string codnot = result.GetString(0);
              string codcli = result.GetString(1);
              string codlug = result.GetString(2);
              string codnomlug = result.GetString(3);
              string codtec = result.GetString(4);
              string fecha = result.GetString(5);
              string codser = result.GetString(6);
              string codtiempo = result.GetString(7);
              string noconfor = result.GetString(8);
              string fechaformat = result.GetString(9);

              InventariadoInformeNoConformidad a = new InventariadoInformeNoConformidad(codnot, codcli, codlug, codnomlug, codtec, fecha, codser, codtiempo, noconfor, fechaformat);
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
  public List<InventariadoInformeNoConformidad> InformebuscarNoConformidadTipoPeriodicidadSEPARADAS(string ini, string fin, string tipo)
  {
      try
      {

          DataAccess.DataBase db = new DataBase();
          db.connect();


          string sql = "select periodicidad.OTI,cliente.Nombre, lugartratamiento.Cod, lugartratamiento.NombreTratamiento, tecnicos.Nombre, DATE_FORMAT(fecha, '%d-%m-%Y'),servicio.Sigla,sum(distinct(periodicidad.Tiempo)),periodicidad.NoConformidad, DATE_FORMAT(fecha, '%M-%y') from periodicidad,lugartratamiento,cliente,servicio, planilla, tecnicos where periodicidad.Servicio_Cod=servicio.Cod and lugartratamiento.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod=lugartratamiento.Cod and planilla.Cod=periodicidad.Planilla_Cod and periodicidad.Fecha between '" + ini + "' and '" + fin + "'   and periodicidad.NoConformidad not like '' and periodicidad.Tecnicos_Cod=tecnicos.Cod    and periodicidad.TipoPeridodicidad='" + tipo + "'and periodicidad.Estado!='Replanificado' and periodicidad.Estado='Realizado' group by periodicidad.Cod, tecnicos.Nombre,periodicidad.Fecha,lugartratamiento.NombreTratamiento,servicio.Sigla order by periodicidad.Fecha;";
          db.CreateCommand(sql);
          List<InventariadoInformeNoConformidad> ap = new List<InventariadoInformeNoConformidad>();
          DbDataReader result = db.Query();
          while (result.Read())
          {

              string codnot = result.GetString(0);
              string codcli = result.GetString(1);
              string codlug = result.GetString(2);
              string codnomlug = result.GetString(3);
              string codtec = result.GetString(4);
              string fecha = result.GetString(5);
              string codser = result.GetString(6);
              string codtiempo = result.GetString(7);
              string noconfor = result.GetString(8);
              string fechaformat = result.GetString(9);

              InventariadoInformeNoConformidad a = new InventariadoInformeNoConformidad(codnot, codcli, codlug, codnomlug, codtec, fecha, codser, codtiempo, noconfor, fechaformat);
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
  public List<InventariadoInformeNoConformidad> InformebuscarNoConformidadTodoParametroTODO(string ini, string fin, string cliente, string tipo, string lugar, string ruta)
  {
      try
      {

          DataAccess.DataBase db = new DataBase();
          db.connect();
          string sql = "select periodicidad.OTI,cliente.Nombre, lugartratamiento.Cod, lugartratamiento.NombreTratamiento, tecnicos.Nombre, DATE_FORMAT(fecha, '%d-%m-%Y'),group_concat(distinct servicio.Sigla), sum(distinct(periodicidad.Tiempo)),periodicidad.NoConformidad, DATE_FORMAT(fecha, '%M-%y') from periodicidad,lugartratamiento,cliente,servicio, planilla, tecnicos where periodicidad.Servicio_Cod=servicio.Cod and lugartratamiento.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod=lugartratamiento.Cod and planilla.Cod=periodicidad.Planilla_Cod and periodicidad.Fecha between 'ini' and 'fin' and cliente.Nombre='" + cliente + "' and TipoLugar='" + tipo + "' and lugartratamiento.NombreTratamiento='" + lugar + "' and lugartratamiento.Ruta='" + ruta + "' and OTI != 0 and periodicidad.Estado!='Suspendido' and periodicidad.Tecnicos_Cod=tecnicos.Cod and periodicidad.Estado!='Replanificado'and periodicidad.Estado='Realizado' group by planilla.Cod, tecnicos.Nombre,periodicidad.Fecha,lugartratamiento.NombreTratamiento order by periodicidad.Fecha;";
          db.CreateCommand(sql);
          List<InventariadoInformeNoConformidad> ap = new List<InventariadoInformeNoConformidad>();
          DbDataReader result = db.Query();


          while (result.Read())
          {

              string codnot = result.GetString(0);
              string codcli = result.GetString(1);
              string codlug = result.GetString(2);
              string codnomlug = result.GetString(3);
              string codtec = result.GetString(4);
              string fecha = result.GetString(5);
              string codser = result.GetString(6);
              string codtiempo = result.GetString(7);
              string noconfor = result.GetString(8);
              string fechaformat = result.GetString(9);

              InventariadoInformeNoConformidad a = new InventariadoInformeNoConformidad(codnot, codcli, codlug, codnomlug, codtec, fecha, codser, codtiempo, noconfor, fechaformat);
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
  public List<InventariadoInformeNoConformidad> InformebuscarNoConformidadTodoParametroTODOSEPARADAS(string ini, string fin, string cliente, string tipo, string lugar, string ruta)
  {
      try
      {

          DataAccess.DataBase db = new DataBase();
          db.connect();
          string sql = "select periodicidad.OTI,cliente.Nombre, lugartratamiento.Cod, lugartratamiento.NombreTratamiento, tecnicos.Nombre, DATE_FORMAT(fecha, '%d-%m-%Y'),servicio.Sigla, sum(distinct(periodicidad.Tiempo)),periodicidad.NoConformidad, DATE_FORMAT(fecha, '%M-%y') from periodicidad,lugartratamiento,cliente,servicio, planilla, tecnicos where periodicidad.Servicio_Cod=servicio.Cod and lugartratamiento.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod=lugartratamiento.Cod and planilla.Cod=periodicidad.Planilla_Cod and periodicidad.Fecha between 'ini' and 'fin' and cliente.Nombre='" + cliente + "' and TipoLugar='" + tipo + "' and lugartratamiento.NombreTratamiento='" + lugar + "' and lugartratamiento.Ruta='" + ruta + "' and OTI != 0 and periodicidad.Estado!='Suspendido' and periodicidad.Tecnicos_Cod=tecnicos.Cod and periodicidad.Estado!='Replanificado' and periodicidad.Estado='Realizado' group by periodicidad.Cod, tecnicos.Nombre,periodicidad.Fecha,lugartratamiento.NombreTratamiento,servicio.Sigla order by periodicidad.Fecha;";
          db.CreateCommand(sql);
          List<InventariadoInformeNoConformidad> ap = new List<InventariadoInformeNoConformidad>();
          DbDataReader result = db.Query();


          while (result.Read())
          {

              string codnot = result.GetString(0);
              string codcli = result.GetString(1);
              string codlug = result.GetString(2);
              string codnomlug = result.GetString(3);
              string codtec = result.GetString(4);
              string fecha = result.GetString(5);
              string codser = result.GetString(6);
              string codtiempo = result.GetString(7);
              string noconfor = result.GetString(8);
              string fechaformat = result.GetString(9);

              InventariadoInformeNoConformidad a = new InventariadoInformeNoConformidad(codnot, codcli, codlug, codnomlug, codtec, fecha, codser, codtiempo, noconfor, fechaformat);
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
        //_________________________________aqui_____________________Problema
  public List<InventariadoInformeNoConformidad> InformebuscarNoConformidadSoloFechasTODO(string ini, string fin)
  {
      try
      {

          DataAccess.DataBase db = new DataBase();
          db.connect();
          string sql = "select periodicidad.OTI,cliente.Nombre, lugartratamiento.Cod, lugartratamiento.NombreTratamiento, tecnicos.Nombre, DATE_FORMAT(fecha, '%d-%m-%Y'),group_concat(distinct servicio.Sigla), sum(periodicidad.Tiempo),periodicidad.NoConformidad, DATE_FORMAT(fecha, '%M-%y') from periodicidad,lugartratamiento,cliente,servicio, planilla, tecnicos where periodicidad.Servicio_Cod=servicio.Cod and lugartratamiento.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod=lugartratamiento.Cod and planilla.Cod=periodicidad.Planilla_Cod and periodicidad.Fecha between '" + ini + "' and '" + fin + "' and OTI != 0 and periodicidad.Estado!='Suspendido' and periodicidad.Tecnicos_Cod=tecnicos.Cod and periodicidad.Estado!='Replanificado'and periodicidad.Estado='Realizado' group by planilla.Cod, tecnicos.Nombre,periodicidad.Fecha,lugartratamiento.NombreTratamiento order by periodicidad.Fecha;";
          db.CreateCommand(sql);
          List<InventariadoInformeNoConformidad> ap = new List<InventariadoInformeNoConformidad>();
          DbDataReader result = db.Query();


          while (result.Read())
          {

              string codnot = result.GetString(0);
              string codcli = result.GetString(1);
              string codlug = result.GetString(2);
              string codnomlug = result.GetString(3);
              string codtec = result.GetString(4);
              string fecha = result.GetString(5);
              string codser = result.GetString(6);
              string codtiempo = result.GetString(7);
              string noconfor = result.GetString(8);
              string fechaformat = result.GetString(9);

              InventariadoInformeNoConformidad a = new InventariadoInformeNoConformidad(codnot, codcli, codlug, codnomlug, codtec, fecha, codser, codtiempo, noconfor, fechaformat);
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
  public List<InventariadoInformeNoConformidad> InformebuscarNoConformidadSoloFechasTODOSEPARADAS(string ini, string fin)
  {
      try
      {

          DataAccess.DataBase db = new DataBase();
          db.connect();
          string sql = "select periodicidad.OTI,cliente.Nombre, lugartratamiento.Cod, lugartratamiento.NombreTratamiento, tecnicos.Nombre, DATE_FORMAT(fecha, '%d-%m-%Y'),servicio.Sigla,sum(periodicidad.Tiempo),periodicidad.NoConformidad, DATE_FORMAT(fecha, '%M-%y') from periodicidad,lugartratamiento,cliente,servicio, planilla, tecnicos where periodicidad.Servicio_Cod=servicio.Cod and lugartratamiento.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod=lugartratamiento.Cod and planilla.Cod=periodicidad.Planilla_Cod and periodicidad.Fecha between '" + ini + "' and '" + fin + "' and OTI != 0 and periodicidad.Estado!='Suspendido' and periodicidad.Tecnicos_Cod=tecnicos.Cod and periodicidad.Estado!='Replanificado'and periodicidad.Estado='Realizado' group by periodicidad.Cod, tecnicos.Nombre,periodicidad.Fecha,lugartratamiento.NombreTratamiento,servicio.Sigla order by periodicidad.Fecha;";
          db.CreateCommand(sql);
          List<InventariadoInformeNoConformidad> ap = new List<InventariadoInformeNoConformidad>();
          DbDataReader result = db.Query();


          while (result.Read())
          {

              string codnot = result.GetString(0);
              string codcli = result.GetString(1);
              string codlug = result.GetString(2);
              string codnomlug = result.GetString(3);
              string codtec = result.GetString(4);
              string fecha = result.GetString(5);
              string codser = result.GetString(6);
              string codtiempo = result.GetString(7);
              string noconfor = result.GetString(8);
              string fechaformat = result.GetString(9);

              InventariadoInformeNoConformidad a = new InventariadoInformeNoConformidad(codnot, codcli, codlug, codnomlug, codtec, fecha, codser, codtiempo, noconfor, fechaformat);
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
  public List<InventariadoInformeNoConformidad> InformebuscarNoConformidadSoloCLienteTODO(string ini, string fin, string cliente)
  {
      try
      {

          DataAccess.DataBase db = new DataBase();
          db.connect();


          string sql = "select periodicidad.OTI,cliente.Nombre, lugartratamiento.Cod, lugartratamiento.NombreTratamiento, tecnicos.Nombre, DATE_FORMAT(fecha, '%d-%m-%Y'),group_concat(distinct servicio.Sigla), sum(distinct(periodicidad.Tiempo)),periodicidad.NoConformidad, DATE_FORMAT(fecha, '%M-%y') from periodicidad,lugartratamiento,cliente,servicio, planilla, tecnicos where periodicidad.Servicio_Cod=servicio.Cod and lugartratamiento.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod=lugartratamiento.Cod and planilla.Cod=periodicidad.Planilla_Cod and periodicidad.Fecha between '" + ini + "' and '" + fin + "'    and OTI != 0 and periodicidad.Estado!='Suspendido' and periodicidad.Tecnicos_Cod=tecnicos.Cod and cliente.Nombre='" + cliente + "' and periodicidad.Estado!='Replanificado'and periodicidad.Estado='Realizado' group by planilla.Cod, tecnicos.Nombre,periodicidad.Fecha,lugartratamiento.NombreTratamiento order by periodicidad.Fecha;";
          db.CreateCommand(sql);
          List<InventariadoInformeNoConformidad> ap = new List<InventariadoInformeNoConformidad>();
          DbDataReader result = db.Query();


          while (result.Read())
          {

              string codnot = result.GetString(0);
              string codcli = result.GetString(1);
              string codlug = result.GetString(2);
              string codnomlug = result.GetString(3);
              string codtec = result.GetString(4);
              string fecha = result.GetString(5);
              string codser = result.GetString(6);
              string codtiempo = result.GetString(7);
              string noconfor = result.GetString(8);
              string fechaformat = result.GetString(9);

              InventariadoInformeNoConformidad a = new InventariadoInformeNoConformidad(codnot, codcli, codlug, codnomlug, codtec, fecha, codser, codtiempo, noconfor, fechaformat);
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
  public List<InventariadoInformeNoConformidad> InformebuscarNoConformidadSoloCLienteTODOSEPARADAS(string ini, string fin, string cliente)
  {
      try
      {

          DataAccess.DataBase db = new DataBase();
          db.connect();


          string sql = "select periodicidad.OTI,cliente.Nombre, lugartratamiento.Cod, lugartratamiento.NombreTratamiento, tecnicos.Nombre, DATE_FORMAT(fecha, '%d-%m-%Y'),servicio.Sigla, sum(periodicidad.Tiempo),periodicidad.NoConformidad, DATE_FORMAT(fecha, '%M-%y') from periodicidad,lugartratamiento,cliente,servicio, planilla, tecnicos where periodicidad.Servicio_Cod=servicio.Cod and lugartratamiento.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod=lugartratamiento.Cod and planilla.Cod=periodicidad.Planilla_Cod and periodicidad.Fecha between '" + ini + "' and '" + fin + "'    and OTI != 0 and periodicidad.Estado!='Suspendido' and periodicidad.Tecnicos_Cod=tecnicos.Cod and cliente.Nombre='" + cliente + "' and periodicidad.Estado!='Replanificado'and periodicidad.Estado='Realizado' group by periodicidad.Cod, tecnicos.Nombre,periodicidad.Fecha,lugartratamiento.NombreTratamiento,servicio.Sigla order by periodicidad.Fecha;";
          db.CreateCommand(sql);
          List<InventariadoInformeNoConformidad> ap = new List<InventariadoInformeNoConformidad>();
          DbDataReader result = db.Query();


          while (result.Read())
          {

              string codnot = result.GetString(0);
              string codcli = result.GetString(1);
              string codlug = result.GetString(2);
              string codnomlug = result.GetString(3);
              string codtec = result.GetString(4);
              string fecha = result.GetString(5);
              string codser = result.GetString(6);
              string codtiempo = result.GetString(7);
              string noconfor = result.GetString(8);
              string fechaformat = result.GetString(9);

              InventariadoInformeNoConformidad a = new InventariadoInformeNoConformidad(codnot, codcli, codlug, codnomlug, codtec, fecha, codser, codtiempo, noconfor, fechaformat);
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
  public List<InventariadoInformeNoConformidad> InformebuscarNoConformidadSoloClienteYTipoTODO(string ini, string fin, string cliente, string fundos)
  {
      try
      {

          DataAccess.DataBase db = new DataBase();
          db.connect();


          string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta, DATE_FORMAT(fecha, '%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,periodicidad.OTI,periodicidad.Consumo, sum(distinct(periodicidad.Tiempo)) from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla where fecha between '" + ini + "' and '" + fin + "'  and periodicidad.Estado= 'Realizado' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Cod and cliente.Nombre='" + cliente + "'and OTI != 0 and periodicidad.Estado!='Suspendido' and lugartratamiento.TipoLugar='" + fundos + "' and periodicidad.Estado!='Replanificado'and periodicidad.Estado='Realizado' group by planilla.Cod, tecnicos.Nombre,periodicidad.Fecha,lugartratamiento.NombreTratamiento order by periodicidad.Fecha;";
          db.CreateCommand(sql);
          List<InventariadoInformeNoConformidad> ap = new List<InventariadoInformeNoConformidad>();
          DbDataReader result = db.Query();


          while (result.Read())
          {

              string codnot = result.GetString(0);
              string codcli = result.GetString(1);
              string codlug = result.GetString(2);
              string codnomlug = result.GetString(3);
              string codtec = result.GetString(4);
              string fecha = result.GetString(5);
              string codser = result.GetString(6);
              string codtiempo = result.GetString(7);
              string noconfor = result.GetString(8);
              string fechaformat = result.GetString(9);

              InventariadoInformeNoConformidad a = new InventariadoInformeNoConformidad(codnot, codcli, codlug, codnomlug, codtec, fecha, codser, codtiempo, noconfor, fechaformat);
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
  public List<InventariadoInformeNoConformidad> InformebuscarNoConformidadSoloClienteYTipoTODOSEPARADAS(string ini, string fin, string cliente, string fundos)
  {
      try
      {

          DataAccess.DataBase db = new DataBase();
          db.connect();


          string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta, DATE_FORMAT(fecha, '%d-%m-%Y'), periodicidad.TipoPeridodicidad, servicio.Sigla, tecnicos.Nombre,periodicidad.OTI,periodicidad.Consumo,sum(periodicidad.Tiempo)  from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla where fecha between '" + ini + "' and '" + fin + "'  and periodicidad.Estado= 'Realizado' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Cod and cliente.Nombre='" + cliente + "'and OTI != 0 and periodicidad.Estado!='Suspendido' and lugartratamiento.TipoLugar='" + fundos + "'and periodicidad.Estado!='Replanificado'and periodicidad.Estado='Realizado' group by periodicidad.Cod, tecnicos.Nombre,periodicidad.Fecha,lugartratamiento.NombreTratamiento,servicio.Sigla order by periodicidad.Fecha;";
          db.CreateCommand(sql);
          List<InventariadoInformeNoConformidad> ap = new List<InventariadoInformeNoConformidad>();
          DbDataReader result = db.Query();


          while (result.Read())
          {

              string codnot = result.GetString(0);
              string codcli = result.GetString(1);
              string codlug = result.GetString(2);
              string codnomlug = result.GetString(3);
              string codtec = result.GetString(4);
              string fecha = result.GetString(5);
              string codser = result.GetString(6);
              string codtiempo = result.GetString(7);
              string noconfor = result.GetString(8);
              string fechaformat = result.GetString(9);

              InventariadoInformeNoConformidad a = new InventariadoInformeNoConformidad(codnot, codcli, codlug, codnomlug, codtec, fecha, codser, codtiempo, noconfor, fechaformat);
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
  public List<InventariadoInformeNoConformidad> InformebuscarNoConformidadSoloTipoTODO(string ini, string fin, string fundos)
  {
      try
      {

          DataAccess.DataBase db = new DataBase();
          db.connect();


          string sql = "select periodicidad.OTI,cliente.Nombre, lugartratamiento.Cod, lugartratamiento.NombreTratamiento, tecnicos.Nombre, DATE_FORMAT(fecha, '%d-%m-%Y'),group_concat(distinct servicio.Sigla), sum(distinct(periodicidad.Tiempo)),periodicidad.NoConformidad, DATE_FORMAT(fecha, '%M-%y') from periodicidad,lugartratamiento,cliente,servicio, planilla, tecnicos where periodicidad.Servicio_Cod=servicio.Cod and lugartratamiento.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod=lugartratamiento.Cod and planilla.Cod=periodicidad.Planilla_Cod and periodicidad.Fecha between '" + ini + "' and '" + fin + "'   and OTI != 0 and periodicidad.Estado!='Suspendido' and periodicidad.Tecnicos_Cod=tecnicos.Cod  and lugartratamiento.TipoLugar='" + fundos + "'and periodicidad.Estado!='Replanificado'and periodicidad.Estado='Realizado' group by planilla.Cod, tecnicos.Nombre,periodicidad.Fecha,lugartratamiento.NombreTratamiento order by periodicidad.Fecha;";
          db.CreateCommand(sql);
          List<InventariadoInformeNoConformidad> ap = new List<InventariadoInformeNoConformidad>();
          DbDataReader result = db.Query();


          while (result.Read())
          {

              string codnot = result.GetString(0);
              string codcli = result.GetString(1);
              string codlug = result.GetString(2);
              string codnomlug = result.GetString(3);
              string codtec = result.GetString(4);
              string fecha = result.GetString(5);
              string codser = result.GetString(6);
              string codtiempo = result.GetString(7);
              string noconfor = result.GetString(8);
              string fechaformat = result.GetString(9);

              InventariadoInformeNoConformidad a = new InventariadoInformeNoConformidad(codnot, codcli, codlug, codnomlug, codtec, fecha, codser, codtiempo, noconfor, fechaformat);
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
  public List<InventariadoInformeNoConformidad> InformebuscarNoConformidadSoloTipoTODOSEPARADAS(string ini, string fin, string fundos)
  {
      try
      {

          DataAccess.DataBase db = new DataBase();
          db.connect();


          string sql = "select periodicidad.OTI,cliente.Nombre, lugartratamiento.Cod, lugartratamiento.NombreTratamiento, tecnicos.Nombre, DATE_FORMAT(fecha, '%d-%m-%Y'),servicio.Sigla, sum(distinct(periodicidad.Tiempo)),periodicidad.NoConformidad, DATE_FORMAT(fecha, '%M-%y') from periodicidad,lugartratamiento,cliente,servicio, planilla, tecnicos where periodicidad.Servicio_Cod=servicio.Cod and lugartratamiento.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod=lugartratamiento.Cod and planilla.Cod=periodicidad.Planilla_Cod and periodicidad.Fecha between '" + ini + "' and '" + fin + "'   and OTI != 0 and periodicidad.Estado!='Suspendido' and periodicidad.Tecnicos_Cod=tecnicos.Cod  and lugartratamiento.TipoLugar='" + fundos + "'and periodicidad.Estado!='Replanificado'and periodicidad.Estado='Realizado' group by periodicidad.Cod, tecnicos.Nombre,periodicidad.Fecha,lugartratamiento.NombreTratamiento,servicio.Sigla order by periodicidad.Fecha;";
          db.CreateCommand(sql);
          List<InventariadoInformeNoConformidad> ap = new List<InventariadoInformeNoConformidad>();
          DbDataReader result = db.Query();


          while (result.Read())
          {

              string codnot = result.GetString(0);
              string codcli = result.GetString(1);
              string codlug = result.GetString(2);
              string codnomlug = result.GetString(3);
              string codtec = result.GetString(4);
              string fecha = result.GetString(5);
              string codser = result.GetString(6);
              string codtiempo = result.GetString(7);
              string noconfor = result.GetString(8);
              string fechaformat = result.GetString(9);

              InventariadoInformeNoConformidad a = new InventariadoInformeNoConformidad(codnot, codcli, codlug, codnomlug, codtec, fecha, codser, codtiempo, noconfor, fechaformat);
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
  public List<InventariadoInformeNoConformidad> InformebuscarNoConformidadSoloLugarTODO(string ini, string fin, string lugar)
  {
      try
      {

          DataAccess.DataBase db = new DataBase();
          db.connect();


          string sql = "select periodicidad.OTI,cliente.Nombre, lugartratamiento.Cod, lugartratamiento.NombreTratamiento, tecnicos.Nombre, DATE_FORMAT(fecha, '%d-%m-%Y'),group_concat(distinct servicio.Sigla), sum(distinct(periodicidad.Tiempo)),periodicidad.NoConformidad, DATE_FORMAT(fecha, '%M-%y') from periodicidad,lugartratamiento,cliente,servicio, planilla, tecnicos where periodicidad.Servicio_Cod=servicio.Cod and lugartratamiento.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod=lugartratamiento.Cod and planilla.Cod=periodicidad.Planilla_Cod and periodicidad.Fecha between '" + ini + "' and '" + fin + "'and OTI != 0 and periodicidad.Estado!='Suspendido' and periodicidad.Tecnicos_Cod=tecnicos.Cod   and lugartratamiento.NombreTratamiento='" + lugar + "'and periodicidad.Estado!='Replanificado'and periodicidad.Estado='Realizado' group by planilla.Cod, tecnicos.Nombre,periodicidad.Fecha,lugartratamiento.NombreTratamiento order by periodicidad.Fecha;";
          db.CreateCommand(sql);
          List<InventariadoInformeNoConformidad> ap = new List<InventariadoInformeNoConformidad>();
          DbDataReader result = db.Query();


          while (result.Read())
          {

              string codnot = result.GetString(0);
              string codcli = result.GetString(1);
              string codlug = result.GetString(2);
              string codnomlug = result.GetString(3);
              string codtec = result.GetString(4);
              string fecha = result.GetString(5);
              string codser = result.GetString(6);
              string codtiempo = result.GetString(7);
              string noconfor = result.GetString(8);
              string fechaformat = result.GetString(9);

              InventariadoInformeNoConformidad a = new InventariadoInformeNoConformidad(codnot, codcli, codlug, codnomlug, codtec, fecha, codser, codtiempo, noconfor, fechaformat);
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
  public List<InventariadoInformeNoConformidad> InformebuscarNoConformidadSoloLugarTODOSEPARADAS(string ini, string fin, string lugar)
  {
      try
      {

          DataAccess.DataBase db = new DataBase();
          db.connect();


          string sql = "select periodicidad.OTI,cliente.Nombre, lugartratamiento.Cod, lugartratamiento.NombreTratamiento, tecnicos.Nombre, DATE_FORMAT(fecha, '%d-%m-%Y'),servicio.Sigla,sum(distinct(periodicidad.Tiempo)),periodicidad.NoConformidad, DATE_FORMAT(fecha, '%M-%y') from periodicidad,lugartratamiento,cliente,servicio, planilla, tecnicos where periodicidad.Servicio_Cod=servicio.Cod and lugartratamiento.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod=lugartratamiento.Cod and planilla.Cod=periodicidad.Planilla_Cod and periodicidad.Fecha between '" + ini + "' and '" + fin + "'and OTI != 0 and periodicidad.Estado!='Suspendido' and periodicidad.Tecnicos_Cod=tecnicos.Cod   and lugartratamiento.NombreTratamiento='" + lugar + "'and periodicidad.Estado!='Replanificado'and periodicidad.Estado='Realizado' group by periodicidad.Cod, tecnicos.Nombre,periodicidad.Fecha,lugartratamiento.NombreTratamiento,servicio.Sigla order by periodicidad.Fecha;";
          db.CreateCommand(sql);
          List<InventariadoInformeNoConformidad> ap = new List<InventariadoInformeNoConformidad>();
          DbDataReader result = db.Query();


          while (result.Read())
          {

              string codnot = result.GetString(0);
              string codcli = result.GetString(1);
              string codlug = result.GetString(2);
              string codnomlug = result.GetString(3);
              string codtec = result.GetString(4);
              string fecha = result.GetString(5);
              string codser = result.GetString(6);
              string codtiempo = result.GetString(7);
              string noconfor = result.GetString(8);
              string fechaformat = result.GetString(9);

              InventariadoInformeNoConformidad a = new InventariadoInformeNoConformidad(codnot, codcli, codlug, codnomlug, codtec, fecha, codser, codtiempo, noconfor, fechaformat);
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
  public List<InventariadoInformeNoConformidad> InformebuscarNoConformidadClienteYLugarTODO(string ini, string fin, string cliente, string lugar)
  {
      try
      {

          DataAccess.DataBase db = new DataBase();
          db.connect();


          string sql = "select periodicidad.OTI,cliente.Nombre, lugartratamiento.Cod, lugartratamiento.NombreTratamiento, tecnicos.Nombre, DATE_FORMAT(fecha, '%d-%m-%Y'),group_concat(distinct servicio.Sigla), sum(distinct(periodicidad.Tiempo)),periodicidad.NoConformidad, DATE_FORMAT(fecha, '%M-%y') from periodicidad,lugartratamiento,cliente,servicio, planilla, tecnicos where periodicidad.Servicio_Cod=servicio.Cod and lugartratamiento.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod=lugartratamiento.Cod and planilla.Cod=periodicidad.Planilla_Cod and periodicidad.Fecha between '" + ini + "' and '" + fin + "'    and OTI != 0 and periodicidad.Estado!='Suspendido' and periodicidad.Tecnicos_Cod=tecnicos.Cod  and cliente.Nombre='" + cliente + "'  and lugartratamiento.NombreTratamiento='" + lugar + "'and periodicidad.Estado!='Replanificado'and periodicidad.Estado='Realizado' group by planilla.Cod, tecnicos.Nombre,periodicidad.Fecha,lugartratamiento.NombreTratamiento order by periodicidad.Fecha;";
          db.CreateCommand(sql);
          List<InventariadoInformeNoConformidad> ap = new List<InventariadoInformeNoConformidad>();
          DbDataReader result = db.Query();


          while (result.Read())
          {

              string codnot = result.GetString(0);
              string codcli = result.GetString(1);
              string codlug = result.GetString(2);
              string codnomlug = result.GetString(3);
              string codtec = result.GetString(4);
              string fecha = result.GetString(5);
              string codser = result.GetString(6);
              string codtiempo = result.GetString(7);
              string noconfor = result.GetString(8);
              string fechaformat = result.GetString(9);

              InventariadoInformeNoConformidad a = new InventariadoInformeNoConformidad(codnot, codcli, codlug, codnomlug, codtec, fecha, codser, codtiempo, noconfor, fechaformat);
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
  public List<InventariadoInformeNoConformidad> InformebuscarNoConformidadClienteYLugarTODOSEPARADAS(string ini, string fin, string cliente, string lugar)
  {
      try
      {

          DataAccess.DataBase db = new DataBase();
          db.connect();


          string sql = "select periodicidad.OTI,cliente.Nombre, lugartratamiento.Cod, lugartratamiento.NombreTratamiento, tecnicos.Nombre, DATE_FORMAT(fecha, '%d-%m-%Y'),servicio.Sigla, sum(distinct(periodicidad.Tiempo)),periodicidad.NoConformidad, DATE_FORMAT(fecha, '%M-%y') from periodicidad,lugartratamiento,cliente,servicio, planilla, tecnicos where periodicidad.Servicio_Cod=servicio.Cod and lugartratamiento.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod=lugartratamiento.Cod and planilla.Cod=periodicidad.Planilla_Cod and periodicidad.Fecha between '" + ini + "' and '" + fin + "'    and OTI != 0 and periodicidad.Estado!='Suspendido' and periodicidad.Tecnicos_Cod=tecnicos.Cod  and cliente.Nombre='" + cliente + "'  and lugartratamiento.NombreTratamiento='" + lugar + "'and periodicidad.Estado!='Replanificado'and periodicidad.Estado='Realizado' group by periodicidad.Cod, tecnicos.Nombre,periodicidad.Fecha,lugartratamiento.NombreTratamiento,servicio.Sigla order by periodicidad.Fecha;";
          db.CreateCommand(sql);
          List<InventariadoInformeNoConformidad> ap = new List<InventariadoInformeNoConformidad>();
          DbDataReader result = db.Query();


          while (result.Read())
          {

              string codnot = result.GetString(0);
              string codcli = result.GetString(1);
              string codlug = result.GetString(2);
              string codnomlug = result.GetString(3);
              string codtec = result.GetString(4);
              string fecha = result.GetString(5);
              string codser = result.GetString(6);
              string codtiempo = result.GetString(7);
              string noconfor = result.GetString(8);
              string fechaformat = result.GetString(9);

              InventariadoInformeNoConformidad a = new InventariadoInformeNoConformidad(codnot, codcli, codlug, codnomlug, codtec, fecha, codser, codtiempo, noconfor, fechaformat);
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
  public List<InventariadoInformeNoConformidad> InformebuscarNoConformidadSoloRutaTODO(string ini, string fin, string ruta)
  {
      try
      {

          DataAccess.DataBase db = new DataBase();
          db.connect();


          string sql = "select periodicidad.OTI,cliente.Nombre, lugartratamiento.Cod, lugartratamiento.NombreTratamiento, tecnicos.Nombre, DATE_FORMAT(fecha, '%d-%m-%Y'),group_concat(distinct servicio.Sigla), sum(distinct(periodicidad.Tiempo)),periodicidad.NoConformidad, DATE_FORMAT(fecha, '%M-%y') from periodicidad,lugartratamiento,cliente,servicio, planilla, tecnicos where periodicidad.Servicio_Cod=servicio.Cod and lugartratamiento.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod=lugartratamiento.Cod and planilla.Cod=periodicidad.Planilla_Cod and periodicidad.Fecha between '" + ini + "' and '" + fin + "' and OTI != 0 and periodicidad.Estado!='Suspendido' and periodicidad.Tecnicos_Cod=tecnicos.Cod  and lugartratamiento.Ruta='" + ruta + "'and periodicidad.Estado!='Replanificado'and periodicidad.Estado='Realizado' group by planilla.Cod, tecnicos.Nombre,periodicidad.Fecha,lugartratamiento.NombreTratamiento order by periodicidad.Fecha;";
          db.CreateCommand(sql);
          List<InventariadoInformeNoConformidad> ap = new List<InventariadoInformeNoConformidad>();
          DbDataReader result = db.Query();


          while (result.Read())
          {

              string codnot = result.GetString(0);
              string codcli = result.GetString(1);
              string codlug = result.GetString(2);
              string codnomlug = result.GetString(3);
              string codtec = result.GetString(4);
              string fecha = result.GetString(5);
              string codser = result.GetString(6);
              string codtiempo = result.GetString(7);
              string noconfor = result.GetString(8);
              string fechaformat = result.GetString(9);

              InventariadoInformeNoConformidad a = new InventariadoInformeNoConformidad(codnot, codcli, codlug, codnomlug, codtec, fecha, codser, codtiempo, noconfor, fechaformat);
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
  public List<InventariadoInformeNoConformidad> InformebuscarNoConformidadSoloRutaTODOSEPARADAS(string ini, string fin, string ruta)
  {
      try
      {

          DataAccess.DataBase db = new DataBase();
          db.connect();


          string sql = "select periodicidad.OTI,cliente.Nombre, lugartratamiento.Cod, lugartratamiento.NombreTratamiento, tecnicos.Nombre, DATE_FORMAT(fecha, '%d-%m-%Y'),servicio.Sigla, sum(distinct(periodicidad.Tiempo)),periodicidad.NoConformidad, DATE_FORMAT(fecha, '%M-%y') from periodicidad,lugartratamiento,cliente,servicio, planilla, tecnicos where periodicidad.Servicio_Cod=servicio.Cod and lugartratamiento.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod=lugartratamiento.Cod and planilla.Cod=periodicidad.Planilla_Cod and periodicidad.Fecha between '" + ini + "' and '" + fin + "' and OTI != 0 and periodicidad.Estado!='Suspendido' and periodicidad.Tecnicos_Cod=tecnicos.Cod  and lugartratamiento.Ruta='" + ruta + "'and periodicidad.Estado!='Replanificado' and periodicidad.Estado='Realizado' group by periodicidad.Cod, tecnicos.Nombre,periodicidad.Fecha,lugartratamiento.NombreTratamiento,servicio.Sigla order by periodicidad.Fecha;";
          db.CreateCommand(sql);
          List<InventariadoInformeNoConformidad> ap = new List<InventariadoInformeNoConformidad>();
          DbDataReader result = db.Query();


          while (result.Read())
          {

              string codnot = result.GetString(0);
              string codcli = result.GetString(1);
              string codlug = result.GetString(2);
              string codnomlug = result.GetString(3);
              string codtec = result.GetString(4);
              string fecha = result.GetString(5);
              string codser = result.GetString(6);
              string codtiempo = result.GetString(7);
              string noconfor = result.GetString(8);
              string fechaformat = result.GetString(9);

              InventariadoInformeNoConformidad a = new InventariadoInformeNoConformidad(codnot, codcli, codlug, codnomlug, codtec, fecha, codser, codtiempo, noconfor, fechaformat);
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
  public List<InventariadoInformeNoConformidad> InformebuscarNoConformidadSoloTecnicosTODO(string ini, string fin, string tecnicos)
  {
      try
      {

          DataAccess.DataBase db = new DataBase();
          db.connect();


          string sql = "select periodicidad.OTI,cliente.Nombre, lugartratamiento.Cod, lugartratamiento.NombreTratamiento, tecnicos.Nombre, DATE_FORMAT(fecha, '%d-%m-%Y'),group_concat(distinct servicio.Sigla), sum(distinct(periodicidad.Tiempo)),periodicidad.NoConformidad, DATE_FORMAT(fecha, '%M-%y') from periodicidad,lugartratamiento,cliente,servicio, planilla, tecnicos where periodicidad.Servicio_Cod=servicio.Cod and lugartratamiento.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod=lugartratamiento.Cod and planilla.Cod=periodicidad.Planilla_Cod and periodicidad.Fecha between '" + ini + "' and '" + fin + "' and OTI != 0 and periodicidad.Estado!='Suspendido' and periodicidad.Tecnicos_Cod=tecnicos.Cod   and tecnicos.Nombre='" + tecnicos + "'and periodicidad.Estado!='Replanificado' and periodicidad.Estado='Realizado' group by planilla.Cod, tecnicos.Nombre,periodicidad.Fecha,lugartratamiento.NombreTratamiento order by periodicidad.Fecha;";
          db.CreateCommand(sql);
          List<InventariadoInformeNoConformidad> ap = new List<InventariadoInformeNoConformidad>();
          DbDataReader result = db.Query();
          while (result.Read())
          {

              string codnot = result.GetString(0);
              string codcli = result.GetString(1);
              string codlug = result.GetString(2);
              string codnomlug = result.GetString(3);
              string codtec = result.GetString(4);
              string fecha = result.GetString(5);
              string codser = result.GetString(6);
              string codtiempo = result.GetString(7);
              string noconfor = result.GetString(8);
              string fechaformat = result.GetString(9);

              InventariadoInformeNoConformidad a = new InventariadoInformeNoConformidad(codnot, codcli, codlug, codnomlug, codtec, fecha, codser, codtiempo, noconfor, fechaformat);
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
  public List<InventariadoInformeNoConformidad> InformebuscarNoConformidadSoloTecnicosTODOSEPARADAS(string ini, string fin, string tecnicos)
  {
      try
      {

          DataAccess.DataBase db = new DataBase();
          db.connect();


          string sql = "select periodicidad.OTI,cliente.Nombre, lugartratamiento.Cod, lugartratamiento.NombreTratamiento, tecnicos.Nombre, DATE_FORMAT(fecha, '%d-%m-%Y'),servicio.Sigla,sum(distinct(periodicidad.Tiempo)),periodicidad.NoConformidad, DATE_FORMAT(fecha, '%M-%y') from periodicidad,lugartratamiento,cliente,servicio, planilla, tecnicos where periodicidad.Servicio_Cod=servicio.Cod and lugartratamiento.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod=lugartratamiento.Cod and planilla.Cod=periodicidad.Planilla_Cod and periodicidad.Fecha between '" + ini + "' and '" + fin + "' and OTI != 0 and periodicidad.Estado!='Suspendido' and periodicidad.Tecnicos_Cod=tecnicos.Cod   and tecnicos.Nombre='" + tecnicos + "'and periodicidad.Estado!='Replanificado' and periodicidad.Estado='Realizado' group by periodicidad.Cod, tecnicos.Nombre,periodicidad.Fecha,lugartratamiento.NombreTratamiento,servicio.Sigla order by periodicidad.Fecha;";
          db.CreateCommand(sql);
          List<InventariadoInformeNoConformidad> ap = new List<InventariadoInformeNoConformidad>();
          DbDataReader result = db.Query();
          while (result.Read())
          {

              string codnot = result.GetString(0);
              string codcli = result.GetString(1);
              string codlug = result.GetString(2);
              string codnomlug = result.GetString(3);
              string codtec = result.GetString(4);
              string fecha = result.GetString(5);
              string codser = result.GetString(6);
              string codtiempo = result.GetString(7);
              string noconfor = result.GetString(8);
              string fechaformat = result.GetString(9);

              InventariadoInformeNoConformidad a = new InventariadoInformeNoConformidad(codnot, codcli, codlug, codnomlug, codtec, fecha, codser, codtiempo, noconfor, fechaformat);
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
  public List<InventariadoInformeNoConformidad> InformebuscarNoConformidadTecnicosYLugarTODO(string ini, string fin, string tecnicos, string lugar)
  {
      try
      {

          DataAccess.DataBase db = new DataBase();
          db.connect();


          string sql = "select periodicidad.OTI,cliente.Nombre, lugartratamiento.Cod, lugartratamiento.NombreTratamiento, tecnicos.Nombre, DATE_FORMAT(fecha, '%d-%m-%Y'),group_concat(distinct servicio.Sigla), sum(distinct(periodicidad.Tiempo)),periodicidad.NoConformidad, DATE_FORMAT(fecha, '%M-%y') from periodicidad,lugartratamiento,cliente,servicio, planilla, tecnicos where periodicidad.Servicio_Cod=servicio.Cod and lugartratamiento.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod=lugartratamiento.Cod and planilla.Cod=periodicidad.Planilla_Cod and periodicidad.Fecha between '" + ini + "' and '" + fin + "' and OTI != 0 and periodicidad.Estado!='Suspendido' and periodicidad.Tecnicos_Cod=tecnicos.Cod   and tecnicos.Nombre='" + tecnicos + "'and lugartratamiento.NombreTratamiento='" + lugar + "'and periodicidad.Estado!='Replanificado'and periodicidad.Estado='Realizado' group by planilla.Cod, tecnicos.Nombre,periodicidad.Fecha,lugartratamiento.NombreTratamiento order by periodicidad.Fecha;";
          db.CreateCommand(sql);
          List<InventariadoInformeNoConformidad> ap = new List<InventariadoInformeNoConformidad>();
          DbDataReader result = db.Query();
          while (result.Read())
          {

              string codnot = result.GetString(0);
              string codcli = result.GetString(1);
              string codlug = result.GetString(2);
              string codnomlug = result.GetString(3);
              string codtec = result.GetString(4);
              string fecha = result.GetString(5);
              string codser = result.GetString(6);
              string codtiempo = result.GetString(7);
              string noconfor = result.GetString(8);
              string fechaformat = result.GetString(9);

              InventariadoInformeNoConformidad a = new InventariadoInformeNoConformidad(codnot, codcli, codlug, codnomlug, codtec, fecha, codser, codtiempo, noconfor, fechaformat);
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
  public List<InventariadoInformeNoConformidad> InformebuscarNoConformidadTecnicosYLugarTODOSEPARADAS(string ini, string fin, string tecnicos, string lugar)
  {
      try
      {

          DataAccess.DataBase db = new DataBase();
          db.connect();


          string sql = "select periodicidad.OTI,cliente.Nombre, lugartratamiento.Cod, lugartratamiento.NombreTratamiento, tecnicos.Nombre, DATE_FORMAT(fecha, '%d-%m-%Y'),servicio.Sigla,sum(distinct(periodicidad.Tiempo)),periodicidad.NoConformidad, DATE_FORMAT(fecha, '%M-%y') from periodicidad,lugartratamiento,cliente,servicio, planilla, tecnicos where periodicidad.Servicio_Cod=servicio.Cod and lugartratamiento.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod=lugartratamiento.Cod and planilla.Cod=periodicidad.Planilla_Cod and periodicidad.Fecha between '" + ini + "' and '" + fin + "' and OTI != 0 and periodicidad.Estado!='Suspendido' and periodicidad.Tecnicos_Cod=tecnicos.Cod   and tecnicos.Nombre='" + tecnicos + "'and lugartratamiento.NombreTratamiento='" + lugar + "'and periodicidad.Estado!='Replanificado' and periodicidad.Estado='Realizado' group by periodicidad.Cod, tecnicos.Nombre,periodicidad.Fecha,lugartratamiento.NombreTratamiento,servicio.Sigla order by periodicidad.Fecha;";
          db.CreateCommand(sql);
          List<InventariadoInformeNoConformidad> ap = new List<InventariadoInformeNoConformidad>();
          DbDataReader result = db.Query();
          while (result.Read())
          {

              string codnot = result.GetString(0);
              string codcli = result.GetString(1);
              string codlug = result.GetString(2);
              string codnomlug = result.GetString(3);
              string codtec = result.GetString(4);
              string fecha = result.GetString(5);
              string codser = result.GetString(6);
              string codtiempo = result.GetString(7);
              string noconfor = result.GetString(8);
              string fechaformat = result.GetString(9);

              InventariadoInformeNoConformidad a = new InventariadoInformeNoConformidad(codnot, codcli, codlug, codnomlug, codtec, fecha, codser, codtiempo, noconfor, fechaformat);
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
  public List<InventariadoInformeNoConformidad> InformebuscarNoConformidadTipoPeriodicidadTODO(string ini, string fin, string tipo)
  {
      try
      {

          DataAccess.DataBase db = new DataBase();
          db.connect();


          string sql = "select periodicidad.OTI,cliente.Nombre, lugartratamiento.Cod, lugartratamiento.NombreTratamiento, tecnicos.Nombre, DATE_FORMAT(fecha, '%d-%m-%Y'),group_concat(distinct servicio.Sigla), sum(distinct(periodicidad.Tiempo)),periodicidad.NoConformidad, DATE_FORMAT(fecha, '%M-%y') from periodicidad,lugartratamiento,cliente,servicio, planilla, tecnicos where periodicidad.Servicio_Cod=servicio.Cod and lugartratamiento.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod=lugartratamiento.Cod and planilla.Cod=periodicidad.Planilla_Cod and periodicidad.Fecha between '" + ini + "' and '" + fin + "' and OTI != 0 and periodicidad.Estado!='Suspendido' and periodicidad.Tecnicos_Cod=tecnicos.Cod    and periodicidad.TipoPeridodicidad='" + tipo + "'and periodicidad.Estado!='Replanificado'and periodicidad.Estado='Realizado'  group by planilla.Cod, tecnicos.Nombre,periodicidad.Fecha,lugartratamiento.NombreTratamiento order by periodicidad.Fecha;";
          db.CreateCommand(sql);
          List<InventariadoInformeNoConformidad> ap = new List<InventariadoInformeNoConformidad>();
          DbDataReader result = db.Query();
          while (result.Read())
          {

              string codnot = result.GetString(0);
              string codcli = result.GetString(1);
              string codlug = result.GetString(2);
              string codnomlug = result.GetString(3);
              string codtec = result.GetString(4);
              string fecha = result.GetString(5);
              string codser = result.GetString(6);
              string codtiempo = result.GetString(7);
              string noconfor = result.GetString(8);
              string fechaformat = result.GetString(9);

              InventariadoInformeNoConformidad a = new InventariadoInformeNoConformidad(codnot, codcli, codlug, codnomlug, codtec, fecha, codser, codtiempo, noconfor, fechaformat);
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
  public List<InventariadoInformeNoConformidad> InformebuscarNoConformidadTipoPeriodicidadTODOSEPARADAS(string ini, string fin, string tipo)
  {
      try
      {

          DataAccess.DataBase db = new DataBase();
          db.connect();


          string sql = "select periodicidad.OTI,cliente.Nombre, lugartratamiento.Cod, lugartratamiento.NombreTratamiento, tecnicos.Nombre, DATE_FORMAT(fecha, '%d-%m-%Y'),servicio.Sigla, sum(distinct(periodicidad.Tiempo)),periodicidad.NoConformidad, DATE_FORMAT(fecha, '%M-%y') from periodicidad,lugartratamiento,cliente,servicio, planilla, tecnicos where periodicidad.Servicio_Cod=servicio.Cod and lugartratamiento.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod=lugartratamiento.Cod and planilla.Cod=periodicidad.Planilla_Cod and periodicidad.Fecha between '" + ini + "' and '" + fin + "' and OTI != 0 and periodicidad.Estado!='Suspendido' and periodicidad.Tecnicos_Cod=tecnicos.Cod    and periodicidad.TipoPeridodicidad='" + tipo + "'and periodicidad.Estado!='Replanificado'and periodicidad.Estado='Realizado'  group by periodicidad.Cod, tecnicos.Nombre,periodicidad.Fecha,lugartratamiento.NombreTratamiento,servicio.Sigla order by periodicidad.Fecha;";
          db.CreateCommand(sql);
          List<InventariadoInformeNoConformidad> ap = new List<InventariadoInformeNoConformidad>();
          DbDataReader result = db.Query();
          while (result.Read())
          {

              string codnot = result.GetString(0);
              string codcli = result.GetString(1);
              string codlug = result.GetString(2);
              string codnomlug = result.GetString(3);
              string codtec = result.GetString(4);
              string fecha = result.GetString(5);
              string codser = result.GetString(6);
              string codtiempo = result.GetString(7);
              string noconfor = result.GetString(8);
              string fechaformat = result.GetString(9);

              InventariadoInformeNoConformidad a = new InventariadoInformeNoConformidad(codnot, codcli, codlug, codnomlug, codtec, fecha, codser, codtiempo, noconfor, fechaformat);
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
 }
}
