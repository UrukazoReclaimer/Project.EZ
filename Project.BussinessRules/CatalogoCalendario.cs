using Project.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessRules
{
    public class CatalogoCalendario
    {
      
       
        public List<CalendarioFechas> mostrarCalendario(int codtec, string ini, string fin,int celda)
        {
            try
            {
                
                DataBase db2 = new DataBase();
                db2.connect();
                string sql2 = "  SELECT DATE_FORMAT(calendario.Fecha,'%Y-%m-%d') as fech1,lugartratamiento.Ruta, if(servicio.cod='11',periodicidad.TipoPeridodicidad,NombreTratamiento), group_concat(distinct servicio.Sigla) FROM calendario LEFT  JOIN periodicidad  ON calendario.fecha=periodicidad.fecha and periodicidad.Tecnicos_Cod='" + codtec + "'   LEFT  JOIN planilla  ON planilla.Cod=periodicidad.Planilla_Cod  LEFT  JOIN lugartratamiento ON lugartratamiento.Cod=planilla.LugarTratamiento_Cod  LEFT  JOIN cliente ON  lugartratamiento.Cliente_Cod=cliente.Cod   LEFT  JOIN tecnicos ON periodicidad.Tecnicos_Cod=tecnicos.cod and tecnicos.Cod='" + codtec + "'  LEFT  JOIN servicio ON servicio.Cod=periodicidad.Servicio_Cod  where calendario.Fecha between '" + ini + "' and '" + fin + "' group by calendario.fecha, NombreTratamiento  order by fech1, NombreTratamiento ";
                db2.CreateCommand(sql2);
                List<CalendarioFechas> tec2 = new List<CalendarioFechas>();
                DbDataReader result2 = db2.Query();
                string fecha2;
                string ruta2;
                string lugar2;
                string servicio2;
                while (result2.Read())
                {
                     
                      
                    fecha2 = result2.GetString(0);

                    if (result2.IsDBNull(1))
                    {

                        ruta2 = "";
                    }
                    else
                    {
                        ruta2 = result2.GetString(1);
                    }
                    if (result2.IsDBNull(2))
                    {

                        lugar2 = "";
                    }
                    else { 
                    lugar2 = result2.GetString(2);
                        }

                    if (result2.IsDBNull(3))
                    {

                        servicio2 = "";
                    }
                    else
                    {
                        servicio2 = result2.GetString(3);
                    }
                    CalendarioFechas a2 = new CalendarioFechas(fecha2,ruta2, lugar2, servicio2);
                    a2 = new CalendarioFechas(fecha2, ruta2,lugar2, servicio2);
                    tec2.Add(a2);
                }

                result2.Close();
                db2.close();
                


                DataBase db = new DataBase();
                db.connect();
                string sql = "  SELECT DATE_FORMAT(calendario.Fecha,'%Y-%m-%d') as fech1,lugartratamiento.Ruta, if(servicio.cod='11',periodicidad.TipoPeridodicidad,NombreTratamiento), group_concat(distinct servicio.Sigla) FROM calendario LEFT  JOIN periodicidad  ON calendario.fecha=periodicidad.fecha and periodicidad.Tecnicos_Cod='" + codtec + "'   LEFT  JOIN planilla  ON planilla.Cod=periodicidad.Planilla_Cod  LEFT  JOIN lugartratamiento ON lugartratamiento.Cod=planilla.LugarTratamiento_Cod  LEFT  JOIN cliente ON  lugartratamiento.Cliente_Cod=cliente.Cod   LEFT  JOIN tecnicos ON periodicidad.Tecnicos_Cod=tecnicos.cod and tecnicos.Cod='" + codtec + "'  LEFT  JOIN servicio ON servicio.Cod=periodicidad.Servicio_Cod  where calendario.Fecha between '" + ini + "' and '" + fin + "' group by calendario.fecha, NombreTratamiento  order by fech1, NombreTratamiento ";              
                db.CreateCommand(sql);
                List<CalendarioFechas> tec = new List<CalendarioFechas>();
                DbDataReader result = db.Query();
                string fecha;
                string lugar;
                string servicio;
                string aux = ini;
                string auxif = "";
                string auxifecha = "";
                string ruta;
                fecha = "";
                ruta = "";
                lugar = "";
                servicio2 = "";
                int contador = 0;
                int contadorwhile = 0;
                while (result.Read() || contador <= celda)
                {
/*          
                    if (lugar == auxif && auxif != "" && fecha == auxifecha)
                    {
                        lugar = "";
                    }

                    else
                    {
 */

                        if (result.IsDBNull(0))
                        {
                            fecha = "";
                        }
                        else
                        {
                            fecha = result.GetString(0);
                            auxifecha = fecha;
                        }

                        if (result.IsDBNull(1))
                        {
                            ruta = "";
                        }
                        else
                        {
                            ruta = result.GetString(1);
                      
                        }

                        int cont2 = tec2.Count();
                    if (result.IsDBNull(2) || cont2 <= contadorwhile)
                 // if (result.IsDBNull(1) )
                        {
                             
                            lugar = "";
                        }
                        else
                        {
                            lugar = result.GetString(2);
                            auxif = result.GetString(2);
                        }


                    if (result.IsDBNull(3) || cont2 <= contadorwhile)
                    // if (result.IsDBNull(1) )
                    {

                        servicio = "";
                    }
                    else
                    {
                        servicio = result.GetString(3);
                       
                    }
                        //algo asi caasi
                   // }
                        CalendarioFechas a = new CalendarioFechas(fecha,ruta, lugar,servicio);
                        while (fecha != aux && contador <= celda)
                        {
                            a = new CalendarioFechas(aux,"", "", "");
                            tec.Add(a);
                            contador++;
                        }

                        a = new CalendarioFechas(fecha,ruta, lugar,servicio);
                        tec.Add(a);
                        contadorwhile++;
                        if (contador <= celda)
                        {
                            lugar = auxif;
                            auxif = "";
                            fecha = auxifecha;
                            servicio = "";
                            contador++;
                        }
                        else
                        {
                            contador = 0;
                        }
                                                       
                    aux = fecha;
                   // contadorwhile ++;

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
