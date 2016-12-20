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

        public List<InformeServiciosPlanificado> InformebuscarServiciosPlanificados(string ini, string fin,string clasificacion, string cliente, string tipolugar, string lugar, string ruta, string periodicidad)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();

                //   string sql = "select cliente.Rut,tecnicos.Nombre,servicio.Nombre,planilla.Consumo,cliente.Nombre,lugartratamiento.NombreTratamiento,planilla.Area,periodicidad.Fecha from cliente,tecnicos,servicio,lugartratamiento,periodicidad inner join planilla where tecnicos.Cod=planilla.Tecnicos_Cod and cliente.Rut=planilla.Cliente_Rut and servicio.Cod=planilla.Servicio_Cod and lugartratamiento.Rut=planilla.Cliente_Rut and lugartratamiento.NombreTratamiento=cliente.LugardeTratamiento and periodicidad.planilla_Cod=planilla.Cod and periodicidad.planilla_Cod like'"+s+"'";
                //string sql = "select  Fecha, planilla.numero, lugartratamiento.NombreTratamiento, group_concat(distinct servicio.Sigla),plano.codplano  from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento, plano inner join planilla where lugartratamiento.CodNT=plano.lugartratamiento_CodNT and planilla.Tecnicos_Cod=tecnicos.Cod and planilla.Servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_CodNT=lugartratamiento.CodNT and tecnicos.Nombre='" + s + "' and periodicidad.Fecha between'" + y + "'and '" + z + "' group by tecnicos.Nombre,lugartratamiento.NombreTratamiento,periodicidad.Fecha ;";
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

                 
                    InformeServiciosPlanificado a = new InformeServiciosPlanificado(cla,cli,tlugar,lug,plano,ru,fecha,tperiodicidad,ser,tec);
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

        public List<InformeServiciosPlanificado> InformebuscarServiciosPlanificadosSoloCliente(string ini, string fin,string cliente)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();

                //   string sql = "select cliente.Rut,tecnicos.Nombre,servicio.Nombre,planilla.Consumo,cliente.Nombre,lugartratamiento.NombreTratamiento,planilla.Area,periodicidad.Fecha from cliente,tecnicos,servicio,lugartratamiento,periodicidad inner join planilla where tecnicos.Cod=planilla.Tecnicos_Cod and cliente.Rut=planilla.Cliente_Rut and servicio.Cod=planilla.Servicio_Cod and lugartratamiento.Rut=planilla.Cliente_Rut and lugartratamiento.NombreTratamiento=cliente.LugardeTratamiento and periodicidad.planilla_Cod=planilla.Cod and periodicidad.planilla_Cod like'"+s+"'";
                //string sql = "select  Fecha, planilla.numero, lugartratamiento.NombreTratamiento, group_concat(distinct servicio.Sigla),plano.codplano  from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento, plano inner join planilla where lugartratamiento.CodNT=plano.lugartratamiento_CodNT and planilla.Tecnicos_Cod=tecnicos.Cod and planilla.Servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_CodNT=lugartratamiento.CodNT and tecnicos.Nombre='" + s + "' and periodicidad.Fecha between'" + y + "'and '" + z + "' group by tecnicos.Nombre,lugartratamiento.NombreTratamiento,periodicidad.Fecha ;";
                string sql = "select cliente.Clasificacion, cliente.Nombre, lugartratamiento.TipoLugar,lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta, DATE_FORMAT(fecha, '%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre from cliente, lugartratamiento, periodicidad, servicio, plano, tecnicos inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod and periodicidad.servicio_Cod=servicio.Cod and lugartratamiento.cliente_Cod=cliente.Cod and planilla.cod=periodicidad.planilla_Cod and lugartratamiento.Cod=planilla.lugartratamiento_Cod and lugartratamiento.Cod = plano.LugarTratamiento_Cod and cliente.Nombre='"+cliente+"' and periodicidad.Fecha between '"+ini+"' and '"+fin+"'   group by periodicidad.Fecha,lugartratamiento.NombreTratamiento;";
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

                //   string sql = "select cliente.Rut,tecnicos.Nombre,servicio.Nombre,planilla.Consumo,cliente.Nombre,lugartratamiento.NombreTratamiento,planilla.Area,periodicidad.Fecha from cliente,tecnicos,servicio,lugartratamiento,periodicidad inner join planilla where tecnicos.Cod=planilla.Tecnicos_Cod and cliente.Rut=planilla.Cliente_Rut and servicio.Cod=planilla.Servicio_Cod and lugartratamiento.Rut=planilla.Cliente_Rut and lugartratamiento.NombreTratamiento=cliente.LugardeTratamiento and periodicidad.planilla_Cod=planilla.Cod and periodicidad.planilla_Cod like'"+s+"'";
                //string sql = "select  Fecha, planilla.numero, lugartratamiento.NombreTratamiento, group_concat(distinct servicio.Sigla),plano.codplano  from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento, plano inner join planilla where lugartratamiento.CodNT=plano.lugartratamiento_CodNT and planilla.Tecnicos_Cod=tecnicos.Cod and planilla.Servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_CodNT=lugartratamiento.CodNT and tecnicos.Nombre='" + s + "' and periodicidad.Fecha between'" + y + "'and '" + z + "' group by tecnicos.Nombre,lugartratamiento.NombreTratamiento,periodicidad.Fecha ;";
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

                //   string sql = "select cliente.Rut,tecnicos.Nombre,servicio.Nombre,planilla.Consumo,cliente.Nombre,lugartratamiento.NombreTratamiento,planilla.Area,periodicidad.Fecha from cliente,tecnicos,servicio,lugartratamiento,periodicidad inner join planilla where tecnicos.Cod=planilla.Tecnicos_Cod and cliente.Rut=planilla.Cliente_Rut and servicio.Cod=planilla.Servicio_Cod and lugartratamiento.Rut=planilla.Cliente_Rut and lugartratamiento.NombreTratamiento=cliente.LugardeTratamiento and periodicidad.planilla_Cod=planilla.Cod and periodicidad.planilla_Cod like'"+s+"'";
                //string sql = "select  Fecha, planilla.numero, lugartratamiento.NombreTratamiento, group_concat(distinct servicio.Sigla),plano.codplano  from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento, plano inner join planilla where lugartratamiento.CodNT=plano.lugartratamiento_CodNT and planilla.Tecnicos_Cod=tecnicos.Cod and planilla.Servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_CodNT=lugartratamiento.CodNT and tecnicos.Nombre='" + s + "' and periodicidad.Fecha between'" + y + "'and '" + z + "' group by tecnicos.Nombre,lugartratamiento.NombreTratamiento,periodicidad.Fecha ;";
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

                //   string sql = "select cliente.Rut,tecnicos.Nombre,servicio.Nombre,planilla.Consumo,cliente.Nombre,lugartratamiento.NombreTratamiento,planilla.Area,periodicidad.Fecha from cliente,tecnicos,servicio,lugartratamiento,periodicidad inner join planilla where tecnicos.Cod=planilla.Tecnicos_Cod and cliente.Rut=planilla.Cliente_Rut and servicio.Cod=planilla.Servicio_Cod and lugartratamiento.Rut=planilla.Cliente_Rut and lugartratamiento.NombreTratamiento=cliente.LugardeTratamiento and periodicidad.planilla_Cod=planilla.Cod and periodicidad.planilla_Cod like'"+s+"'";
                //string sql = "select  Fecha, planilla.numero, lugartratamiento.NombreTratamiento, group_concat(distinct servicio.Sigla),plano.codplano  from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento, plano inner join planilla where lugartratamiento.CodNT=plano.lugartratamiento_CodNT and planilla.Tecnicos_Cod=tecnicos.Cod and planilla.Servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_CodNT=lugartratamiento.CodNT and tecnicos.Nombre='" + s + "' and periodicidad.Fecha between'" + y + "'and '" + z + "' group by tecnicos.Nombre,lugartratamiento.NombreTratamiento,periodicidad.Fecha ;";
                string sql = "select cliente.Clasificacion, cliente.Nombre, lugartratamiento.TipoLugar,lugartratamiento.NombreTratamiento , plano.CodPlano, lugartratamiento.Ruta, DATE_FORMAT(fecha, '%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre from cliente, lugartratamiento, periodicidad, servicio, plano, tecnicos inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod  and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and periodicidad.Fecha between '" + ini + "' and '" + fin + "' and lugartratamiento.TipoLugar='"+tipo+"' group by periodicidad.Fecha, planilla.Cod,tecnicos.Nombre, Clasificacion order by Fecha, tecnicos.Nombre;";
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

                //   string sql = "select cliente.Rut,tecnicos.Nombre,servicio.Nombre,planilla.Consumo,cliente.Nombre,lugartratamiento.NombreTratamiento,planilla.Area,periodicidad.Fecha from cliente,tecnicos,servicio,lugartratamiento,periodicidad inner join planilla where tecnicos.Cod=planilla.Tecnicos_Cod and cliente.Rut=planilla.Cliente_Rut and servicio.Cod=planilla.Servicio_Cod and lugartratamiento.Rut=planilla.Cliente_Rut and lugartratamiento.NombreTratamiento=cliente.LugardeTratamiento and periodicidad.planilla_Cod=planilla.Cod and periodicidad.planilla_Cod like'"+s+"'";
                //string sql = "select  Fecha, planilla.numero, lugartratamiento.NombreTratamiento, group_concat(distinct servicio.Sigla),plano.codplano  from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento, plano inner join planilla where lugartratamiento.CodNT=plano.lugartratamiento_CodNT and planilla.Tecnicos_Cod=tecnicos.Cod and planilla.Servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_CodNT=lugartratamiento.CodNT and tecnicos.Nombre='" + s + "' and periodicidad.Fecha between'" + y + "'and '" + z + "' group by tecnicos.Nombre,lugartratamiento.NombreTratamiento,periodicidad.Fecha ;";
                string sql = "select cliente.Clasificacion, cliente.Nombre, lugartratamiento.TipoLugar,lugartratamiento.NombreTratamiento , plano.CodPlano, lugartratamiento.Ruta, DATE_FORMAT(fecha, '%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre from cliente, lugartratamiento, periodicidad, servicio, plano, tecnicos inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod  and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and periodicidad.Fecha between '" + ini + "' and '" + fin + "' and lugartratamiento.Ruta='"+Ruta+"'  group by periodicidad.Fecha, planilla.Cod,tecnicos.Nombre, Clasificacion order by Fecha, tecnicos.Nombre;";
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

                //   string sql = "select cliente.Rut,tecnicos.Nombre,servicio.Nombre,planilla.Consumo,cliente.Nombre,lugartratamiento.NombreTratamiento,planilla.Area,periodicidad.Fecha from cliente,tecnicos,servicio,lugartratamiento,periodicidad inner join planilla where tecnicos.Cod=planilla.Tecnicos_Cod and cliente.Rut=planilla.Cliente_Rut and servicio.Cod=planilla.Servicio_Cod and lugartratamiento.Rut=planilla.Cliente_Rut and lugartratamiento.NombreTratamiento=cliente.LugardeTratamiento and periodicidad.planilla_Cod=planilla.Cod and periodicidad.planilla_Cod like'"+s+"'";
                //string sql = "select  Fecha, planilla.numero, lugartratamiento.NombreTratamiento, group_concat(distinct servicio.Sigla),plano.codplano  from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento, plano inner join planilla where lugartratamiento.CodNT=plano.lugartratamiento_CodNT and planilla.Tecnicos_Cod=tecnicos.Cod and planilla.Servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_CodNT=lugartratamiento.CodNT and tecnicos.Nombre='" + s + "' and periodicidad.Fecha between'" + y + "'and '" + z + "' group by tecnicos.Nombre,lugartratamiento.NombreTratamiento,periodicidad.Fecha ;";
                string sql = "select cliente.Clasificacion, cliente.Nombre, lugartratamiento.TipoLugar,lugartratamiento.NombreTratamiento , plano.CodPlano, lugartratamiento.Ruta, DATE_FORMAT(fecha, '%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre from cliente, lugartratamiento, periodicidad, servicio, plano, tecnicos inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod  and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and periodicidad.Fecha between '" + ini + "' and '" + fin + "' and periodicidad.TipoPeridodicidad='"+periodicidad+"'  group by periodicidad.Fecha, planilla.Cod,tecnicos.Nombre, Clasificacion order by Fecha, tecnicos.Nombre;";
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

        public List<InformeServiciosPlanificado> InformebuscarServiciosPlanificadosClienteYLugar(string ini, string fin, string cliente,string lugar)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();

                //   string sql = "select cliente.Rut,tecnicos.Nombre,servicio.Nombre,planilla.Consumo,cliente.Nombre,lugartratamiento.NombreTratamiento,planilla.Area,periodicidad.Fecha from cliente,tecnicos,servicio,lugartratamiento,periodicidad inner join planilla where tecnicos.Cod=planilla.Tecnicos_Cod and cliente.Rut=planilla.Cliente_Rut and servicio.Cod=planilla.Servicio_Cod and lugartratamiento.Rut=planilla.Cliente_Rut and lugartratamiento.NombreTratamiento=cliente.LugardeTratamiento and periodicidad.planilla_Cod=planilla.Cod and periodicidad.planilla_Cod like'"+s+"'";
                //string sql = "select  Fecha, planilla.numero, lugartratamiento.NombreTratamiento, group_concat(distinct servicio.Sigla),plano.codplano  from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento, plano inner join planilla where lugartratamiento.CodNT=plano.lugartratamiento_CodNT and planilla.Tecnicos_Cod=tecnicos.Cod and planilla.Servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_CodNT=lugartratamiento.CodNT and tecnicos.Nombre='" + s + "' and periodicidad.Fecha between'" + y + "'and '" + z + "' group by tecnicos.Nombre,lugartratamiento.NombreTratamiento,periodicidad.Fecha ;";
                string sql = "select cliente.Clasificacion, cliente.Nombre, lugartratamiento.TipoLugar,lugartratamiento.NombreTratamiento , plano.CodPlano, lugartratamiento.Ruta, DATE_FORMAT(fecha, '%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre from cliente, lugartratamiento, periodicidad, servicio, plano, tecnicos inner join planilla where periodicidad.tecnicos_Cod=tecnicos.Cod  and periodicidad.servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and planilla.lugartratamiento_Cod=lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and periodicidad.Fecha between '" + ini + "' and '" + fin + "' and cliente.Nombre='"+cliente+"' and lugartratamiento.NombreTratamiento='"+lugar+"'   group by periodicidad.Fecha, planilla.Cod,tecnicos.Nombre, Clasificacion order by Fecha, tecnicos.Nombre;";
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

                //   string sql = "select cliente.Rut,tecnicos.Nombre,servicio.Nombre,planilla.Consumo,cliente.Nombre,lugartratamiento.NombreTratamiento,planilla.Area,periodicidad.Fecha from cliente,tecnicos,servicio,lugartratamiento,periodicidad inner join planilla where tecnicos.Cod=planilla.Tecnicos_Cod and cliente.Rut=planilla.Cliente_Rut and servicio.Cod=planilla.Servicio_Cod and lugartratamiento.Rut=planilla.Cliente_Rut and lugartratamiento.NombreTratamiento=cliente.LugardeTratamiento and periodicidad.planilla_Cod=planilla.Cod and periodicidad.planilla_Cod like'"+s+"'";
                //string sql = "select  Fecha, planilla.numero, lugartratamiento.NombreTratamiento, group_concat(distinct servicio.Sigla),plano.codplano  from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento, plano inner join planilla where lugartratamiento.CodNT=plano.lugartratamiento_CodNT and planilla.Tecnicos_Cod=tecnicos.Cod and planilla.Servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_CodNT=lugartratamiento.CodNT and tecnicos.Nombre='" + s + "' and periodicidad.Fecha between'" + y + "'and '" + z + "' group by tecnicos.Nombre,lugartratamiento.NombreTratamiento,periodicidad.Fecha ;";
                string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta, DATE_FORMAT(fecha, '%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,periodicidad.OTI,periodicidad.Consumo from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla where fecha between '" + ini + "' and '" + fin + "' and cliente.Nombre='" + cliente + "' and TipoLugar='" + tipo + "' and lugartratamiento.NombreTratamiento='" + lugar + "' and lugartratamiento.Ruta='" + ruta + "' and periodicidad.Estado= 'Realizado' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Cod group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;";
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

                    InformeServiciosRealizado a = new InformeServiciosRealizado(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec, not,consumo);
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

                //   string sql = "select cliente.Rut,tecnicos.Nombre,servicio.Nombre,planilla.Consumo,cliente.Nombre,lugartratamiento.NombreTratamiento,planilla.Area,periodicidad.Fecha from cliente,tecnicos,servicio,lugartratamiento,periodicidad inner join planilla where tecnicos.Cod=planilla.Tecnicos_Cod and cliente.Rut=planilla.Cliente_Rut and servicio.Cod=planilla.Servicio_Cod and lugartratamiento.Rut=planilla.Cliente_Rut and lugartratamiento.NombreTratamiento=cliente.LugardeTratamiento and periodicidad.planilla_Cod=planilla.Cod and periodicidad.planilla_Cod like'"+s+"'";
                //string sql = "select  Fecha, planilla.numero, lugartratamiento.NombreTratamiento, group_concat(distinct servicio.Sigla),plano.codplano  from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento, plano inner join planilla where lugartratamiento.CodNT=plano.lugartratamiento_CodNT and planilla.Tecnicos_Cod=tecnicos.Cod and planilla.Servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_CodNT=lugartratamiento.CodNT and tecnicos.Nombre='" + s + "' and periodicidad.Fecha between'" + y + "'and '" + z + "' group by tecnicos.Nombre,lugartratamiento.NombreTratamiento,periodicidad.Fecha ;";
                string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta, DATE_FORMAT(fecha, '%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,periodicidad.OTI,periodicidad.Consumo from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla where fecha between '" + ini + "' and '" + fin + "'  and periodicidad.Estado= 'Realizado' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Cod group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;";
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

                    InformeServiciosRealizado a = new InformeServiciosRealizado(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec, not, consumo);
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

            
                string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta, DATE_FORMAT(fecha, '%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,periodicidad.OTI,periodicidad.Consumo from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla where fecha between '" + ini + "' and '" + fin + "'  and periodicidad.Estado= 'Realizado' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Cod and cliente.Nombre='"+cliente+"' group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;";
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

                    InformeServiciosRealizado a = new InformeServiciosRealizado(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec, not, consumo);
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


                string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta, DATE_FORMAT(fecha, '%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,periodicidad.OTI,periodicidad.Consumo from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla where fecha between '" + ini + "' and '" + fin + "'  and periodicidad.Estado= 'Realizado' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Cod and cliente.Nombre='" + cliente + "'and lugartratamiento.TipoLugar='"+fundos+"' group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;";
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

                    InformeServiciosRealizado a = new InformeServiciosRealizado(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec, not, consumo);
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


                string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta, DATE_FORMAT(fecha, '%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,periodicidad.OTI,periodicidad.Consumo from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla where fecha between '" + ini + "' and '" + fin + "'  and periodicidad.Estado= 'Realizado' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Cod and lugartratamiento.TipoLugar='" + fundos + "' group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;";
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

                    InformeServiciosRealizado a = new InformeServiciosRealizado(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec, not, consumo);
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


                string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta, DATE_FORMAT(fecha, '%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,periodicidad.OTI,periodicidad.Consumo from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla where fecha between '" + ini + "' and '" + fin + "'  and periodicidad.Estado= 'Realizado' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Cod and lugartratamiento.NombreTratamiento='"+lugar+"' group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;";
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

                    InformeServiciosRealizado a = new InformeServiciosRealizado(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec, not, consumo);
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


                string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta, DATE_FORMAT(fecha, '%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,periodicidad.OTI,periodicidad.Consumo from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla where fecha between '" + ini + "' and '" + fin + "'  and periodicidad.Estado= 'Realizado' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Cod and cliente.Nombre='"+cliente+"'  and lugartratamiento.NombreTratamiento='"+lugar+"' group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;";
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

                    InformeServiciosRealizado a = new InformeServiciosRealizado(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec, not, consumo);
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


                string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta, DATE_FORMAT(fecha, '%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,periodicidad.OTI,periodicidad.Consumo from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla where fecha between '" + ini + "' and '" + fin + "'  and periodicidad.Estado= 'Realizado' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Cod  and tecnicos.Nombre='"+tecnicos+"'  group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;";
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

                    InformeServiciosRealizado a = new InformeServiciosRealizado(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec, not, consumo);
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


                string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta, DATE_FORMAT(fecha, '%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,periodicidad.OTI,periodicidad.Consumo from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla where fecha between '" + ini + "' and '" + fin + "'  and periodicidad.Estado= 'Realizado' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Cod  and tecnicos.Nombre='" + tecnicos + "'and lugartratamiento.NombreTratamiento='"+lugar+"'  group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;";
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

                    InformeServiciosRealizado a = new InformeServiciosRealizado(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec, not, consumo);
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


                string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta, DATE_FORMAT(fecha, '%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,periodicidad.OTI,periodicidad.Consumo from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla where fecha between '" + ini + "' and '" + fin + "'  and periodicidad.Estado= 'Realizado' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Cod  and periodicidad.TipoPeridodicidad='" + tipo + "'  group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;";
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

                    InformeServiciosRealizado a = new InformeServiciosRealizado(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec, not, consumo);
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


                string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta, DATE_FORMAT(fecha, '%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,periodicidad.OTI,periodicidad.Consumo from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla where fecha between '" + ini + "' and '" + fin + "'  and periodicidad.Estado= 'Realizado' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Cod  and lugartratamiento.Ruta='" + ruta + "'  group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;";
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

                    InformeServiciosRealizado a = new InformeServiciosRealizado(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec, not, consumo);
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

                string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta, periodicidad.Fecha, periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,periodicidad.OTI,periodicidad.Consumo from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla where fecha between '" + ini + "' and '" + fin + "'  and periodicidad.Estado= 'No Realizado' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Cod group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;";
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
                    string motivo = result.GetString(9);

                    InformeServiciosNoRealizado a = new InformeServiciosNoRealizado(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec,motivo);
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

                string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta, periodicidad.Fecha, periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,periodicidad.OTI,periodicidad.Consumo from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla where fecha between '" + ini + "' and '" + fin + "'  and periodicidad.Estado= 'No Realizado' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Codand servicio.Cod=periodicidad.Servicio_Cod and cliente.Nombre='"+cliente+"' and lugartratamiento.NombreTratamiento='"+lugar+"' group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;";
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
                    string motivo = result.GetString(9);

                    InformeServiciosNoRealizado a = new InformeServiciosNoRealizado(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec, motivo);
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

                string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta, periodicidad.Fecha, periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,periodicidad.OTI,periodicidad.Consumo from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla where fecha between '" + ini + "' and '" + fin + "'  and periodicidad.Estado= 'No Realizado' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Codand servicio.Cod=periodicidad.Servicio_Cod and cliente.Nombre='" + cliente + "'group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;";
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
                    string motivo = result.GetString(9);

                    InformeServiciosNoRealizado a = new InformeServiciosNoRealizado(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec, motivo);
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

        public List<InformeServiciosNoRealizado> InformebuscarServiciosNoRealizadoSoloLugar(string ini, string fin,string lugar)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();

                string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta, periodicidad.Fecha, periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,periodicidad.OTI,periodicidad.Consumo from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla where fecha between '" + ini + "' and '" + fin + "'  and periodicidad.Estado= 'No Realizado' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Codand servicio.Cod=periodicidad.Servicio_Cod and lugartratamiento.NombreTratamiento='" + lugar + "' group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;";
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
                    string motivo = result.GetString(9);

                    InformeServiciosNoRealizado a = new InformeServiciosNoRealizado(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec, motivo);
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

                string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta, periodicidad.Fecha, periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,periodicidad.OTI,periodicidad.Consumo from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla where fecha between '" + ini + "' and '" + fin + "'  and periodicidad.Estado= 'No Realizado' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Codand servicio.Cod=periodicidad.Servicio_Cod and lugartratamiento.Ruta='"+ruta+"' group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;";
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
                    string motivo = result.GetString(9);

                    InformeServiciosNoRealizado a = new InformeServiciosNoRealizado(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec, motivo);
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

                string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta, periodicidad.Fecha, periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,periodicidad.OTI,periodicidad.Consumo from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla where fecha between '" + ini + "' and '" + fin + "'  and periodicidad.Estado= 'No Realizado' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Codand servicio.Cod=periodicidad.Servicio_Cod and periodicidad.TipoPeridodicidad='"+tipo+"' group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;";
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
                    string motivo = result.GetString(9);

                    InformeServiciosNoRealizado a = new InformeServiciosNoRealizado(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec, motivo);
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

                string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta, periodicidad.Fecha, periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,periodicidad.OTI,periodicidad.Consumo from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla where fecha between '" + ini + "' and '" + fin + "'  and periodicidad.Estado= 'No Realizado' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Codand servicio.Cod=periodicidad.Servicio_Cod and  tecnicos.Nombre='" + tecnicos + "' group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;";
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
                    string motivo = result.GetString(9);

                    InformeServiciosNoRealizado a = new InformeServiciosNoRealizado(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser, tec, motivo);
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

                //   string sql = "select cliente.Rut,tecnicos.Nombre,servicio.Nombre,planilla.Consumo,cliente.Nombre,lugartratamiento.NombreTratamiento,planilla.Area,periodicidad.Fecha from cliente,tecnicos,servicio,lugartratamiento,periodicidad inner join planilla where tecnicos.Cod=planilla.Tecnicos_Cod and cliente.Rut=planilla.Cliente_Rut and servicio.Cod=planilla.Servicio_Cod and lugartratamiento.Rut=planilla.Cliente_Rut and lugartratamiento.NombreTratamiento=cliente.LugardeTratamiento and periodicidad.planilla_Cod=planilla.Cod and periodicidad.planilla_Cod like'"+s+"'";
                //string sql = "select  Fecha, planilla.numero, lugartratamiento.NombreTratamiento, group_concat(distinct servicio.Sigla),plano.codplano  from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento, plano inner join planilla where lugartratamiento.CodNT=plano.lugartratamiento_CodNT and planilla.Tecnicos_Cod=tecnicos.Cod and planilla.Servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_CodNT=lugartratamiento.CodNT and tecnicos.Nombre='" + s + "' and periodicidad.Fecha between'" + y + "'and '" + z + "' group by tecnicos.Nombre,lugartratamiento.NombreTratamiento,periodicidad.Fecha ;";
                string sql = "select DATE_FORMAT(periodicidad.Fecha,'%d-%m-%Y'), avg(periodicidad.Consumo),lugartratamiento.NombreTratamiento from periodicidad, lugartratamiento inner join planilla where periodicidad.Planilla_Cod=planilla.Cod and lugartratamiento.Cod=planilla.LugarTratamiento_Cod and periodicidad.Consumo!='0' and fecha between '" + ini + "' and '" + fin + "' group by lugartratamiento.NombreTratamiento;";
                db.CreateCommand(sql);
                List<InformeGraficos> ap = new List<InformeGraficos>();
                DbDataReader result = db.Query();


                while (result.Read())
                {                                                      
                    string fecha = result.GetString(0);
                    string lug = result.GetString(1);
                    string consumo = result.GetString(2);

                    InformeGraficos a = new InformeGraficos(fecha, lug, consumo);
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
                string sql = "insert into checkl values('" + ac.Cod + "','" + ac.Certificado + "','" + ac.Obs + "','" + ac.Fecha + "','" + ac.Periodicidad +"','" + ac.Iden + "');";
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

                string sql = "select cliente.Nombre,lugartratamiento.TipoLugar,lugartratamiento.NombreTratamiento,plano.CodPlano,lugartratamiento.Ruta, periodicidad.Fecha,periodicidad.TipoPeridodicidad,group_concat(distinct servicio.Sigla),periodicidad.OTI,nota.Responsable,nota.Contenido from cliente, lugartratamiento,plano,periodicidad,servicio,nota inner join planilla where planilla.Cod=periodicidad.Planilla_Cod and planilla.Cliente_Cod=cliente.Cod and cliente.Cod=lugartratamiento.Cliente_Cod and servicio.Cod=periodicidad.Servicio_Cod and nota.periodicidad_Cod=periodicidad.Cod and periodicidad.Estado='Suspendido' and periodicidad.Fecha between '" + ini + "' and '" + fin + "' ;";
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

                    InformeServiciosSuspendidos a = new InformeServiciosSuspendidos(cla, tlugar, lug, plano, ru, fecha, tperiodicidad, ser,not, solicitud, motivo);
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

                string sql = "select cliente.Nombre,lugartratamiento.TipoLugar,lugartratamiento.NombreTratamiento,plano.CodPlano,lugartratamiento.Ruta, periodicidad.Fecha,periodicidad.TipoPeridodicidad,group_concat(distinct servicio.Sigla),periodicidad.OTI,nota.Responsable,nota.Contenido from cliente, lugartratamiento,plano,periodicidad,servicio,nota inner join planilla where planilla.Cod=periodicidad.Planilla_Cod and planilla.Cliente_Cod=cliente.Cod and cliente.Cod=lugartratamiento.Cliente_Cod and servicio.Cod=periodicidad.Servicio_Cod and nota.periodicidad_Cod=periodicidad.Cod and periodicidad.Estado='Suspendido' and periodicidad.Fecha between '" + ini + "' and '" + fin + "'and cliente.Nombre='"+cliente+"'  group by periodicidad.Fecha,lugartratamiento.NombreTratamiento  ;";
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

                string sql = "select cliente.Nombre,lugartratamiento.TipoLugar,lugartratamiento.NombreTratamiento,plano.CodPlano,lugartratamiento.Ruta, periodicidad.Fecha,periodicidad.TipoPeridodicidad,group_concat(distinct servicio.Sigla),periodicidad.OTI,nota.Responsable,nota.Contenido from cliente, lugartratamiento,plano,periodicidad,servicio,nota inner join planilla where planilla.Cod=periodicidad.Planilla_Cod and planilla.Cliente_Cod=cliente.Cod and cliente.Cod=lugartratamiento.Cliente_Cod and servicio.Cod=periodicidad.Servicio_Cod and nota.periodicidad_Cod=periodicidad.Cod and periodicidad.Estado='Suspendido' and periodicidad.Fecha between '" + ini + "' and '" + fin + "'and lugartratamiento.NombreTratamiento='" + lugar + "'  group by periodicidad.Fecha,lugartratamiento.NombreTratamiento  ;";
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

                //   string sql = "select cliente.Rut,tecnicos.Nombre,servicio.Nombre,planilla.Consumo,cliente.Nombre,lugartratamiento.NombreTratamiento,planilla.Area,periodicidad.Fecha from cliente,tecnicos,servicio,lugartratamiento,periodicidad inner join planilla where tecnicos.Cod=planilla.Tecnicos_Cod and cliente.Rut=planilla.Cliente_Rut and servicio.Cod=planilla.Servicio_Cod and lugartratamiento.Rut=planilla.Cliente_Rut and lugartratamiento.NombreTratamiento=cliente.LugardeTratamiento and periodicidad.planilla_Cod=planilla.Cod and periodicidad.planilla_Cod like'"+s+"'";
                //string sql = "select  Fecha, planilla.numero, lugartratamiento.NombreTratamiento, group_concat(distinct servicio.Sigla),plano.codplano  from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento, plano inner join planilla where lugartratamiento.CodNT=plano.lugartratamiento_CodNT and planilla.Tecnicos_Cod=tecnicos.Cod and planilla.Servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_CodNT=lugartratamiento.CodNT and tecnicos.Nombre='" + s + "' and periodicidad.Fecha between'" + y + "'and '" + z + "' group by tecnicos.Nombre,lugartratamiento.NombreTratamiento,periodicidad.Fecha ;";
                string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta,DATE_FORMAT(periodicidad.Fecha,'%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,planilla.Descripcion from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla where fecha between '" + ini + "' and '" + fin + "' and cliente.Nombre='" + cliente + "' and TipoLugar='" + tipo + "' and lugartratamiento.NombreTratamiento='" + lugar + "' and lugartratamiento.Ruta='" + ruta + "'and periodicidad.Estado='Replanificar' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Cod group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;";
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

                //   string sql = "select cliente.Rut,tecnicos.Nombre,servicio.Nombre,planilla.Consumo,cliente.Nombre,lugartratamiento.NombreTratamiento,planilla.Area,periodicidad.Fecha from cliente,tecnicos,servicio,lugartratamiento,periodicidad inner join planilla where tecnicos.Cod=planilla.Tecnicos_Cod and cliente.Rut=planilla.Cliente_Rut and servicio.Cod=planilla.Servicio_Cod and lugartratamiento.Rut=planilla.Cliente_Rut and lugartratamiento.NombreTratamiento=cliente.LugardeTratamiento and periodicidad.planilla_Cod=planilla.Cod and periodicidad.planilla_Cod like'"+s+"'";
                //string sql = "select  Fecha, planilla.numero, lugartratamiento.NombreTratamiento, group_concat(distinct servicio.Sigla),plano.codplano  from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento, plano inner join planilla where lugartratamiento.CodNT=plano.lugartratamiento_CodNT and planilla.Tecnicos_Cod=tecnicos.Cod and planilla.Servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_CodNT=lugartratamiento.CodNT and tecnicos.Nombre='" + s + "' and periodicidad.Fecha between'" + y + "'and '" + z + "' group by tecnicos.Nombre,lugartratamiento.NombreTratamiento,periodicidad.Fecha ;";
                string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta,DATE_FORMAT(periodicidad.Fecha,'%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,planilla.Descripcion from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla where fecha between '"+ini+"' and '"+fin+"' and periodicidad.Estado='Replanificar' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Cod group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;";
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

        public List<InformeServiciosReplanificados> InformebuscarServiciosRePlanificadosClienteLugar(string ini, string fin,string cliente, string lugar)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();

                //   string sql = "select cliente.Rut,tecnicos.Nombre,servicio.Nombre,planilla.Consumo,cliente.Nombre,lugartratamiento.NombreTratamiento,planilla.Area,periodicidad.Fecha from cliente,tecnicos,servicio,lugartratamiento,periodicidad inner join planilla where tecnicos.Cod=planilla.Tecnicos_Cod and cliente.Rut=planilla.Cliente_Rut and servicio.Cod=planilla.Servicio_Cod and lugartratamiento.Rut=planilla.Cliente_Rut and lugartratamiento.NombreTratamiento=cliente.LugardeTratamiento and periodicidad.planilla_Cod=planilla.Cod and periodicidad.planilla_Cod like'"+s+"'";
                //string sql = "select  Fecha, planilla.numero, lugartratamiento.NombreTratamiento, group_concat(distinct servicio.Sigla),plano.codplano  from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento, plano inner join planilla where lugartratamiento.CodNT=plano.lugartratamiento_CodNT and planilla.Tecnicos_Cod=tecnicos.Cod and planilla.Servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_CodNT=lugartratamiento.CodNT and tecnicos.Nombre='" + s + "' and periodicidad.Fecha between'" + y + "'and '" + z + "' group by tecnicos.Nombre,lugartratamiento.NombreTratamiento,periodicidad.Fecha ;";
                string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta,DATE_FORMAT(periodicidad.Fecha,'%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,planilla.Descripcion from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla where fecha between '" + ini + "' and '" + fin + "' and periodicidad.Estado='Replanificar' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Cod and cliente.Nombre='"+cliente+"' and lugartratamiento.NombreTratamiento='"+lugar+"' group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;";
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

                //   string sql = "select cliente.Rut,tecnicos.Nombre,servicio.Nombre,planilla.Consumo,cliente.Nombre,lugartratamiento.NombreTratamiento,planilla.Area,periodicidad.Fecha from cliente,tecnicos,servicio,lugartratamiento,periodicidad inner join planilla where tecnicos.Cod=planilla.Tecnicos_Cod and cliente.Rut=planilla.Cliente_Rut and servicio.Cod=planilla.Servicio_Cod and lugartratamiento.Rut=planilla.Cliente_Rut and lugartratamiento.NombreTratamiento=cliente.LugardeTratamiento and periodicidad.planilla_Cod=planilla.Cod and periodicidad.planilla_Cod like'"+s+"'";
                //string sql = "select  Fecha, planilla.numero, lugartratamiento.NombreTratamiento, group_concat(distinct servicio.Sigla),plano.codplano  from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento, plano inner join planilla where lugartratamiento.CodNT=plano.lugartratamiento_CodNT and planilla.Tecnicos_Cod=tecnicos.Cod and planilla.Servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_CodNT=lugartratamiento.CodNT and tecnicos.Nombre='" + s + "' and periodicidad.Fecha between'" + y + "'and '" + z + "' group by tecnicos.Nombre,lugartratamiento.NombreTratamiento,periodicidad.Fecha ;";
                string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta,DATE_FORMAT(periodicidad.Fecha,'%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,planilla.Descripcion from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla where fecha between '" + ini + "' and '" + fin + "' and periodicidad.Estado='Replanificar' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Cod and cliente.Nombre='" + cliente + "' group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;";
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
        public List<InformeServiciosReplanificados> InformebuscarServiciosRePlanificadosLugar(string ini, string fin,string lugar)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();

                //   string sql = "select cliente.Rut,tecnicos.Nombre,servicio.Nombre,planilla.Consumo,cliente.Nombre,lugartratamiento.NombreTratamiento,planilla.Area,periodicidad.Fecha from cliente,tecnicos,servicio,lugartratamiento,periodicidad inner join planilla where tecnicos.Cod=planilla.Tecnicos_Cod and cliente.Rut=planilla.Cliente_Rut and servicio.Cod=planilla.Servicio_Cod and lugartratamiento.Rut=planilla.Cliente_Rut and lugartratamiento.NombreTratamiento=cliente.LugardeTratamiento and periodicidad.planilla_Cod=planilla.Cod and periodicidad.planilla_Cod like'"+s+"'";
                //string sql = "select  Fecha, planilla.numero, lugartratamiento.NombreTratamiento, group_concat(distinct servicio.Sigla),plano.codplano  from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento, plano inner join planilla where lugartratamiento.CodNT=plano.lugartratamiento_CodNT and planilla.Tecnicos_Cod=tecnicos.Cod and planilla.Servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_CodNT=lugartratamiento.CodNT and tecnicos.Nombre='" + s + "' and periodicidad.Fecha between'" + y + "'and '" + z + "' group by tecnicos.Nombre,lugartratamiento.NombreTratamiento,periodicidad.Fecha ;";
                string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta,DATE_FORMAT(periodicidad.Fecha,'%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,planilla.Descripcion from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla where fecha between '" + ini + "' and '" + fin + "' and periodicidad.Estado='Replanificar' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Cod and lugartratamiento.NombreTratamiento='" + lugar + "' group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;";
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

                //   string sql = "select cliente.Rut,tecnicos.Nombre,servicio.Nombre,planilla.Consumo,cliente.Nombre,lugartratamiento.NombreTratamiento,planilla.Area,periodicidad.Fecha from cliente,tecnicos,servicio,lugartratamiento,periodicidad inner join planilla where tecnicos.Cod=planilla.Tecnicos_Cod and cliente.Rut=planilla.Cliente_Rut and servicio.Cod=planilla.Servicio_Cod and lugartratamiento.Rut=planilla.Cliente_Rut and lugartratamiento.NombreTratamiento=cliente.LugardeTratamiento and periodicidad.planilla_Cod=planilla.Cod and periodicidad.planilla_Cod like'"+s+"'";
                //string sql = "select  Fecha, planilla.numero, lugartratamiento.NombreTratamiento, group_concat(distinct servicio.Sigla),plano.codplano  from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento, plano inner join planilla where lugartratamiento.CodNT=plano.lugartratamiento_CodNT and planilla.Tecnicos_Cod=tecnicos.Cod and planilla.Servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_CodNT=lugartratamiento.CodNT and tecnicos.Nombre='" + s + "' and periodicidad.Fecha between'" + y + "'and '" + z + "' group by tecnicos.Nombre,lugartratamiento.NombreTratamiento,periodicidad.Fecha ;";
                string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta,DATE_FORMAT(periodicidad.Fecha,'%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,planilla.Descripcion from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla where fecha between '" + ini + "' and '" + fin + "' and periodicidad.Estado='Replanificar' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Cod and lugartratamiento.TipoLugar='"+tipo+"' group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;";
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

                //   string sql = "select cliente.Rut,tecnicos.Nombre,servicio.Nombre,planilla.Consumo,cliente.Nombre,lugartratamiento.NombreTratamiento,planilla.Area,periodicidad.Fecha from cliente,tecnicos,servicio,lugartratamiento,periodicidad inner join planilla where tecnicos.Cod=planilla.Tecnicos_Cod and cliente.Rut=planilla.Cliente_Rut and servicio.Cod=planilla.Servicio_Cod and lugartratamiento.Rut=planilla.Cliente_Rut and lugartratamiento.NombreTratamiento=cliente.LugardeTratamiento and periodicidad.planilla_Cod=planilla.Cod and periodicidad.planilla_Cod like'"+s+"'";
                //string sql = "select  Fecha, planilla.numero, lugartratamiento.NombreTratamiento, group_concat(distinct servicio.Sigla),plano.codplano  from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento, plano inner join planilla where lugartratamiento.CodNT=plano.lugartratamiento_CodNT and planilla.Tecnicos_Cod=tecnicos.Cod and planilla.Servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_CodNT=lugartratamiento.CodNT and tecnicos.Nombre='" + s + "' and periodicidad.Fecha between'" + y + "'and '" + z + "' group by tecnicos.Nombre,lugartratamiento.NombreTratamiento,periodicidad.Fecha ;";
                string sql = "select cliente.nombre, lugartratamiento.TipoLugar, lugartratamiento.NombreTratamiento, plano.CodPlano, lugartratamiento.Ruta,DATE_FORMAT(periodicidad.Fecha,'%d-%m-%Y'), periodicidad.TipoPeridodicidad, group_concat(distinct servicio.Sigla), tecnicos.Nombre,planilla.Descripcion from cliente, lugartratamiento, plano, periodicidad,servicio,tecnicos,planilla where fecha between '" + ini + "' and '" + fin + "' and periodicidad.Estado='Replanificar' and periodicidad.Planilla_Cod = planilla.Cod and planilla.Cliente_Cod=cliente.Cod and planilla.LugarTratamiento_Cod= lugartratamiento.Cod and plano.LugarTratamiento_Cod=lugartratamiento.Cod and tecnicos.Cod = periodicidad.Tecnicos_Cod and servicio.Cod=periodicidad.Servicio_Cod and lugartratamiento.Ruta='" + ruta + "' group by periodicidad.Fecha,lugartratamiento.NombreTratamiento ;";
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

        public List<VisualizadorCheckcs> InformeCheck(string cod,string ini)
        {
            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();

                //   string sql = "select cliente.Rut,tecnicos.Nombre,servicio.Nombre,planilla.Consumo,cliente.Nombre,lugartratamiento.NombreTratamiento,planilla.Area,periodicidad.Fecha from cliente,tecnicos,servicio,lugartratamiento,periodicidad inner join planilla where tecnicos.Cod=planilla.Tecnicos_Cod and cliente.Rut=planilla.Cliente_Rut and servicio.Cod=planilla.Servicio_Cod and lugartratamiento.Rut=planilla.Cliente_Rut and lugartratamiento.NombreTratamiento=cliente.LugardeTratamiento and periodicidad.planilla_Cod=planilla.Cod and periodicidad.planilla_Cod like'"+s+"'";
                //string sql = "select  Fecha, planilla.numero, lugartratamiento.NombreTratamiento, group_concat(distinct servicio.Sigla),plano.codplano  from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento, plano inner join planilla where lugartratamiento.CodNT=plano.lugartratamiento_CodNT and planilla.Tecnicos_Cod=tecnicos.Cod and planilla.Servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_CodNT=lugartratamiento.CodNT and tecnicos.Nombre='" + s + "' and periodicidad.Fecha between'" + y + "'and '" + z + "' group by tecnicos.Nombre,lugartratamiento.NombreTratamiento,periodicidad.Fecha ;";
                string sql = "select  checkl.Fecha,planilla.numero, lugartratamiento.NombreTratamiento,servicio.Sigla,periodicidad.OTI, checkl.Certificado,plano.CodPlano,checkl.Observaciones from checkl, lugartratamiento, planilla, periodicidad,servicio, plano where lugartratamiento.Cod= planilla.LugarTratamiento_Cod and planilla.Cod= periodicidad.Planilla_Cod and periodicidad.Cod= checkl.periodicidad_Cod and servicio.Cod= periodicidad.Servicio_Cod and plano.LugarTratamiento_Cod= lugartratamiento.Cod and checkl.identificador='" + cod + "' and checkl.Fecha='" + ini + "'group by fecha, NombreTratamiento;;";
                db.CreateCommand(sql);
                List<VisualizadorCheckcs> ap = new List<VisualizadorCheckcs>();
                DbDataReader result = db.Query();


                while (result.Read())
                {

                    string codfech = result.GetString(0);
                    string codnumero = result.GetString(1);
                    string codlugar = result.GetString(2);
                    string codservicio = result.GetString(3);
                    string codoti = result.GetString(4);              
                    string codplano = result.GetString(5);
                    string doc = result.GetString(6);

                    //  CheckList a = new CheckList(codnumero,codlugar,codservicio,codnoti,codcertificado,codplano);
                    VisualizadorCheckcs a = new VisualizadorCheckcs(codfech, codnumero, codlugar, codservicio, codoti, codplano, doc);
                  
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

                //   string sql = "select cliente.Rut,tecnicos.Nombre,servicio.Nombre,planilla.Consumo,cliente.Nombre,lugartratamiento.NombreTratamiento,planilla.Area,periodicidad.Fecha from cliente,tecnicos,servicio,lugartratamiento,periodicidad inner join planilla where tecnicos.Cod=planilla.Tecnicos_Cod and cliente.Rut=planilla.Cliente_Rut and servicio.Cod=planilla.Servicio_Cod and lugartratamiento.Rut=planilla.Cliente_Rut and lugartratamiento.NombreTratamiento=cliente.LugardeTratamiento and periodicidad.planilla_Cod=planilla.Cod and periodicidad.planilla_Cod like'"+s+"'";
                //string sql = "select  Fecha, planilla.numero, lugartratamiento.NombreTratamiento, group_concat(distinct servicio.Sigla),plano.codplano  from tecnicos, servicio, cliente, area, periodicidad, lugartratamiento, plano inner join planilla where lugartratamiento.CodNT=plano.lugartratamiento_CodNT and planilla.Tecnicos_Cod=tecnicos.Cod and planilla.Servicio_Cod=servicio.Cod and planilla.Cliente_Rut=cliente.Rut and lugartratamiento.cliente_Cod=cliente.Cod and planilla.Area_Cod=area.Cod and planilla.cod=periodicidad.planilla_Cod and planilla.lugartratamiento_CodNT=lugartratamiento.CodNT and tecnicos.Nombre='" + s + "' and periodicidad.Fecha between'" + y + "'and '" + z + "' group by tecnicos.Nombre,lugartratamiento.NombreTratamiento,periodicidad.Fecha ;";
                string sql = "select checkl.cod from checkl where checkl.Fecha='"+ini+"'";
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




    }
}
