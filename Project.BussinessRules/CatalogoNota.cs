using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;       

namespace Project.BussinessRules
{
    public class CatalogoNota
    {

        public void addNota(Nota ac)
        {
            try
            {
                DataAccess.DataBase bd = new DataAccess.DataBase();
                bd.connect();
                //  string sql = "insert into cliente values('"+ac.Cod+"','" + ac.Nombre + "','" + ac.Rut + "','" + ac.Clasificacion + "','" + ac.LTratamiento +"'); insert into lugartratamiento values('"+ac.CODNT+"','"+ac.LTratamiento+"','"+ac.Cod+"','"+ac.RUT+"');";
                string sql = "insert into nota values('" + ac.COD + "','" + ac.CONTENIDO + "','" + ac.RESPONSABLE + "');";
                bd.CreateCommand(sql);
                bd.execute();
                bd.close();
            }
            catch (DataAccess.DataAccessException ex)
            {
                throw new BussinessRulesException(ex.Message);
            }
        }


        public void addNotaTemp(Nota ac)
        {
            try
            {
                DataAccess.DataBase bd = new DataAccess.DataBase();
                bd.connect();
                //  string sql = "insert into cliente values('"+ac.Cod+"','" + ac.Nombre + "','" + ac.Rut + "','" + ac.Clasificacion + "','" + ac.LTratamiento +"'); insert into lugartratamiento values('"+ac.CODNT+"','"+ac.LTratamiento+"','"+ac.Cod+"','"+ac.RUT+"');";
                string sql = "insert into nota values('" + ac.COD + "','" + ac.CONTENIDO + "','" + ac.RESPONSABLE + "');";
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
