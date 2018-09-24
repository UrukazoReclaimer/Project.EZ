using Project.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessRules
{
    public class CatalogoContacto
    {
        public void addContacto(Contacto ac)
        {
            try
            {
                DataAccess.DataBase bd = new DataAccess.DataBase();
                bd.connect();
                string sql = "insert into contacto values('" + ac.Id + "','" + ac.CODNT + "','" + ac.Nombrecontacto + "','" + ac.Telefono + "','" + ac.Email + "','" + ac.Tipo + "')";
                bd.CreateCommand(sql);
                bd.execute();
                bd.close();
            }
            catch (DataAccess.DataAccessException ex)
            {
                throw new BussinessRulesException(ex.Message);
            }
        }

        public void addContactocliente(Contactocliente ac)
        {
            try
            {
                DataAccess.DataBase bd = new DataAccess.DataBase();
                bd.connect();
                string sql = "insert into contactocliente values('" + ac.Id + "','" + ac.COD + "','" + ac.RUT + "','" + ac.Nombrecontacto + "','" + ac.Telefono + "','" + ac.Email + "','" + ac.Tipo + "')";
                bd.CreateCommand(sql);
                bd.execute();
                bd.close();
            }
            catch (DataAccess.DataAccessException ex)
            {
                throw new BussinessRulesException(ex.Message);
            }
        }

        public void modicontacto(Contacto ad)
        {


            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();
                string sql = "update contacto set nombrecontacto='" + ad.Nombrecontacto + "',telefono='" + ad.Telefono + "',email='" + ad.Email + "',tipocontacto='" + ad.Tipo + "'where id='" + ad.Id + "';";

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
