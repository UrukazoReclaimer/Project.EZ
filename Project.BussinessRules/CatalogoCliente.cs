using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DataAccess;
using System.Data.Common;

namespace Project.BussinessRules
{
    public class CatalogoCliente
    {

        public List<LugarTratamiento> gettecnombrelugarcondition(string s)
        {

            DataAccess.DataBase bd = new DataBase();
            bd.connect();
            List<LugarTratamiento> units = new List<LugarTratamiento>();
            string sql = "select * from lugartratamiento  where NombreTratamiento='" + s + "'";
            bd.CreateCommand(sql);

            DbDataReader result = bd.Query();

            while (result.Read())
            {
                LugarTratamiento u = new LugarTratamiento(result.GetInt32(0), result.GetString(1));
                units.Add(u);

            }
            result.Close();
            bd.close();
            return units;

        }

        /*
         *Agrega un elemento cliente en la tabla Cliente
         * 
         * */

        public void addCliente(LugarTratamiento ac)
        {
            try
            {
                DataAccess.DataBase bd = new DataAccess.DataBase();
                bd.connect();            
                string sql = "insert into cliente values('" + ac.Cod + "','" + ac.Nombre + "','" + ac.Rut + "','" + ac.Clasificacion + "','" + ac.LTratamiento + "');";
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
         *Agrega un elemento lugardetatamiento a la tabla LugarTratamiento
         * 
         * */
        public void addLugar(LugarTratamiento ac)
        {
            try
            {
                DataAccess.DataBase bd = new DataAccess.DataBase();
                bd.connect();
                string sql = "insert into lugartratamiento values('" + ac.CODNT + "','" + ac.NombreTrata + "','" + ac.Ruta + "','" + ac.COD + "','" + ac.RUT + "','" + ac.TIPO + "','"+ac.ESTADO+"');";
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
        *Modificar un elemento lugardetratamiento en la tavla LugarTratamiento
        * 
        * */
        public void modLugar(LugarTratamiento ac)
        {

            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();
                string sql = "update lugartratamiento set nombretratamiento='" + ac.NombreTrata + "',ruta='" + ac.Ruta + "'where cod='" + ac.CODNT + "';";

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
        public void modLugarrut(LugarTratamiento ac)
        {

            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();
                string sql = "update lugartratamiento set nombretratamiento='" + ac.NombreTrata + "',ruta='" + ac.Ruta + "',cliente_cod='" + ac.Cod + "',cliente_rut='" + ac.Rut + "'where cod='" + ac.CODNT + "';";

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
        /*
         *Elimina un elemento cliente en la table Cliente
         * 
         * */
        public void removeCliente(string rut)
        {

            DataAccess.DataBase db = new DataAccess.DataBase();

            db.connect();

            string sql = "delete from cliente WHERE rut ='" + rut + "'";

            db.CreateCommand(sql);

            db.execute();

            db.close();



        }
        /*
        *Obtiene el rut el nombre y el codigo de un elemento cliente y lo guarda en una lista
        * 
        * */
        public List<cliente> getclie()
        {

            DataAccess.DataBase bd = new DataBase();
            bd.connect();
            List<cliente> units = new List<cliente>();
            string sql = "select * from cliente";
            bd.CreateCommand(sql);

            DbDataReader result = bd.Query();

            while (result.Read())
            {
                cliente u = new cliente(result.GetString(2), result.GetString(1), result.GetInt32(0));
                units.Add(u);

            }
            result.Close();
            bd.close();
            return units;

        }

        /*
         *Obtiene el rut el nombre y el codigo de un elemento cliente y lo guarda en una lista
         * 
         * */
        public List<cliente> getclierut()
        {

            DataAccess.DataBase bd = new DataBase();
            bd.connect();
            List<cliente> units = new List<cliente>();
            string sql = "select * from cliente order by cliente.nombre";
            bd.CreateCommand(sql);

            DbDataReader result = bd.Query();

            while (result.Read())
            {
                cliente u = new cliente(result.GetString(1), result.GetString(2));
                units.Add(u);

            }
            result.Close();
            bd.close();
            return units;

        }

        public List<cliente> getclierutcondition(string s)
        {

            DataAccess.DataBase bd = new DataBase();
            bd.connect();
            List<cliente> units = new List<cliente>();
            string sql = "select * from cliente where rut='" + s + "'";
            bd.CreateCommand(sql);

            DbDataReader result = bd.Query();

            while (result.Read())
            {
                cliente u = new cliente(result.GetString(1), result.GetString(2));
                units.Add(u);

            }
            result.Close();
            bd.close();
            return units;

        }

        public List<Plano> getlugconditionplano(string codplano)
        {

            DataAccess.DataBase bd = new DataBase();
            bd.connect();
            List<Plano> units = new List<Plano>();
            string sql = "select plano.CodPlano, lugartratamiento.NombreTratamiento from plano, lugartratamiento where plano.CodPlano='"+codplano+"' and plano.LugarTratamiento_Cod=lugartratamiento.Cod";
            bd.CreateCommand(sql);
            DbDataReader result = bd.Query();
            while (result.Read())
            {
                Plano u = new Plano(result.GetString(0), result.GetString(1));
                units.Add(u);
            }
            result.Close();
            bd.close();
            return units;
        }


        /*
        *Obtiene el maximo codigo de la tabla Cliente
        * 
        * */
        public List<cliente> getmaxcodcli()
        {

            DataBase bd = new DataBase();
            bd.connect();
            List<cliente> units = new List<cliente>();
            string sql = "select ifnull(last_insert_id(max(Cod)+1),0) from cliente;";
            bd.CreateCommand(sql);

            DbDataReader result = bd.Query();

            while (result.Read())
            {
                cliente u = new cliente(result.GetInt32(0));
                units.Add(u);

            }
            result.Close();
            bd.close();
            return units;

        }

        
        /*
         *Obtiene el codigo y el rut de los elementos de la tabla Cliente
         * 
         * */
        public List<cliente> getcliecod()
        {

            DataAccess.DataBase bd = new DataBase();
            bd.connect();
            List<cliente> units = new List<cliente>();
            string sql = "select * from cliente where cod";
            bd.CreateCommand(sql);

            DbDataReader result = bd.Query();

            while (result.Read())
            {
                cliente u = new cliente(result.GetInt32(0), result.GetString(1));
                units.Add(u);

            }
            result.Close();
            bd.close();
            return units;

        }

        public List<LugarTratamiento> getlugar(string s)
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


        public List<cliente> getclientcod(string s)
        {

            DataAccess.DataBase bd = new DataBase();
            bd.connect();
            List<cliente> units = new List<cliente>();
            string sql = "select * from cliente where cod='" + s + "';";
            bd.CreateCommand(sql);

            DbDataReader result = bd.Query();

            while (result.Read())
            {
                cliente u = new cliente(result.GetInt32(0), result.GetString(1));
                units.Add(u);

            }
            result.Close();
            bd.close();
            return units;

        }


        public List<cliente> getclientcodfornom(string s)
        {

            DataAccess.DataBase bd = new DataBase();
            bd.connect();
            List<cliente> units = new List<cliente>();
            string sql = "select cliente.cod from cliente where cliente.nombre='" + s + "';";
            bd.CreateCommand(sql);

            DbDataReader result = bd.Query();

            while (result.Read())
            {
                cliente u = new cliente(result.GetInt32(0));
                units.Add(u);

            }
            result.Close();
            bd.close();
            return units;

        }
        public List<cliente> getclienrutfornom(string s)
        {

            DataAccess.DataBase bd = new DataBase();
            bd.connect();
            List<cliente> units = new List<cliente>();
            string sql = "select cliente.cod,cliente.rut from cliente where cliente.nombre='" + s + "';";
            bd.CreateCommand(sql);

            DbDataReader result = bd.Query();

            while (result.Read())
            {
                cliente u = new cliente(result.GetInt32(0),result.GetString(1));
                units.Add(u);

            }
            result.Close();
            bd.close();
            return units;

        }
        public List<cliente> getLtracod()
        {

            DataAccess.DataBase bd = new DataBase();
            bd.connect();
            List<cliente> units = new List<cliente>();
            string sql = "select * from lugartratamiento";
            bd.CreateCommand(sql);

            DbDataReader result = bd.Query();

            while (result.Read())
            {
                cliente u = new cliente(result.GetInt32(0), result.GetString(1));
                units.Add(u);

            }
            result.Close();
            bd.close();
            return units;

        }


        public List<LugarTratamiento> getLtracod(string s)
        {

            DataAccess.DataBase bd = new DataBase();
            bd.connect();
            List<LugarTratamiento> units = new List<LugarTratamiento>();
            string sql = "select * from lugartratamiento where nombretratamiento='" + s + "';";
            bd.CreateCommand(sql);

            DbDataReader result = bd.Query();

            while (result.Read())
            {
                LugarTratamiento u = new LugarTratamiento(result.GetInt32(0), result.GetString(1));
                units.Add(u);

            }
            result.Close();
            bd.close();
            return units;

        }

        public cliente searchcli(string s)
        {

            try
            {

                DataAccess.DataBase bd = new DataBase();
                bd.connect();

                string sql = "select cod,nombre from cliente where nombre='" + s + "'";
                bd.CreateCommand(sql);

                DbDataReader result = bd.Query();
                result.Read();
                cliente u = new cliente(result.GetString(1), result.GetString(0));

                result.Close();
                bd.close();
                return u;
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

        public void modiCli(cliente ad)
        {


            try
            {

                DataAccess.DataBase db = new DataBase();
                db.connect();
                string sql = "update cliente set nombre='" + ad.Nombre + "',rut='" + ad.Rut + "',clasificacion='" + ad.Clasificacion + "',Lugardetratamiento='" + "'where rut='" + ad.Rut + "';";

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




        public List<cliente> mostrarplanilla(string s)
        {
            try
            {
                DataBase db = new DataBase();
                db.connect();
                string sql = "select cliente.Cod,cliente.Nombre,cliente.Rut,cliente.Clasificacion from cliente;";
                db.CreateCommand(sql);
                List<cliente> tec = new List<cliente>();
                DbDataReader result = db.Query();

                while (result.Read())
                {
                    int codcod = result.GetInt32(0);
                    string codnom = result.GetString(1);
                    string codrut = result.GetString(2);
                    string codclasi = result.GetString(3);





                    cliente a = new cliente(codcod, codnom, codrut, codclasi);
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

        public List<Inventariadoplano> mbuscarlugarplano(string s)
        {
            try
            {
                DataBase db = new DataBase();
                db.connect();
                string sql = "select cliente.cod,lugartratamiento.NombreTratamiento,cliente.Rut,plano.Codplano, lugartratamiento.RUTA, lugartratamiento.cod, lugartratamiento.TipoLugar, cliente.nombre from cliente,plano, lugartratamiento where lugartratamiento.cliente_Rut = cliente.Rut and plano.lugartratamiento_Cod=lugartratamiento.Cod and cliente.nombre like '%" + s + "%' order by cliente.cod";
                db.CreateCommand(sql);
                List<Inventariadoplano> tec = new List<Inventariadoplano>();
                DbDataReader result = db.Query();

                while (result.Read())
                {
                    int codcod = result.GetInt32(0);
                    string codnom = result.GetString(1);
                    string codrut = result.GetString(2);
                    string codclasi = result.GetString(3);
                    string codruta = result.GetString(4);
                    string codlug = result.GetString(5);
                    string codtipo = result.GetString(6);
                    string codnombre = result.GetString(7);

                    Inventariadoplano a = new Inventariadoplano(codcod, codnom, codrut, codclasi, codruta, codlug, codtipo,codnombre);
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


        public List<Inventariadoplano> mbuscarlugarplanoLUGAR(string s)
        {
            try
            {
                DataBase db = new DataBase();
                db.connect();
                string sql = "select cliente.cod,lugartratamiento.NombreTratamiento,cliente.Rut,plano.Codplano, lugartratamiento.RUTA, lugartratamiento.cod, lugartratamiento.TipoLugar, cliente.nombre from cliente,plano, lugartratamiento where lugartratamiento.cliente_Rut = cliente.Rut and plano.lugartratamiento_Cod=lugartratamiento.Cod and lugartratamiento.nombretratamiento like '%" + s + "%' order by cliente.cod";
                db.CreateCommand(sql);
                List<Inventariadoplano> tec = new List<Inventariadoplano>();
                DbDataReader result = db.Query();

                while (result.Read())
                {
                    int codcod = result.GetInt32(0);
                    string codnom = result.GetString(1);
                    string codrut = result.GetString(2);
                    string codclasi = result.GetString(3);
                    string codruta = result.GetString(4);
                    string codlug = result.GetString(5);
                    string codtipo = result.GetString(6);
                    string codnombre = result.GetString(7);

                    Inventariadoplano a = new Inventariadoplano(codcod, codnom, codrut, codclasi, codruta, codlug, codtipo, codnombre);
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


        public List<InventariadoCliente> mbuscarcontacto(string s)
        {
            try
            {
                DataBase db = new DataBase();
                db.connect();

             
                string sql = "  select cliente.Cod, lugartratamiento.RUTA, lugartratamiento.NombreTratamiento, contacto.NombreContacto, contacto.Email,contacto.Telefono,contacto.TipoContacto,plano.Codplano, contacto.id, cliente.rut, lugartratamiento.cod, cliente.nombre,Tipolugar,lugartratamiento.estado from lugartratamiento, contacto, plano,cliente where plano.lugartratamiento_Cod=lugartratamiento.Cod and lugartratamiento.cliente_Cod=cliente.Cod and contacto.lugartratamiento_Cod= lugartratamiento.Cod and lugartratamiento.cliente_Rut= cliente.Rut  and cliente.Nombre like'%" + s + "%'";
                db.CreateCommand(sql);
                List<InventariadoCliente> tec = new List<InventariadoCliente>();
                DbDataReader result = db.Query();

                while (result.Read())
                {
                    int codcod = result.GetInt32(0);
                    string codruta = result.GetString(1);
                    string codlugar = result.GetString(2);
                    string codnombre = result.GetString(3);
                    string codcorreo = result.GetString(4);
                    string codtelefono = result.GetString(5);
                    string codtipo = result.GetString(6);
                    string codplano = result.GetString(7);
                    string codid = result.GetString(8);
                    string codrut = result.GetString(9);
                    string codcli = result.GetString(10);
                    string codnombrecliente = result.GetString(11);
                    string codtipolugar = result.GetString(12);
                    string codestado = result.GetString(13);

                    InventariadoCliente a = new InventariadoCliente(codcod, codruta, codlugar, codnombre, codcorreo, codtelefono, codtipo, codplano, codid, codrut, codcli, codnombrecliente, codtipolugar, codestado);
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


        public List<InventariadoCliente> mbuscarcontactoLUGAR(string s)
        {
            try
            {
                DataBase db = new DataBase();
                db.connect();


                string sql = "  select cliente.Cod, lugartratamiento.RUTA, lugartratamiento.NombreTratamiento, contacto.NombreContacto, contacto.Email,contacto.Telefono,contacto.TipoContacto,plano.Codplano, contacto.id, cliente.rut, lugartratamiento.cod, cliente.nombre,Tipolugar,lugartratamiento.estado from lugartratamiento, contacto, plano,cliente where plano.lugartratamiento_Cod=lugartratamiento.Cod and lugartratamiento.cliente_Cod=cliente.Cod and contacto.lugartratamiento_Cod= lugartratamiento.Cod and lugartratamiento.cliente_Rut= cliente.Rut  and lugartratamiento.nombretratamiento like'%" + s + "%'";
                db.CreateCommand(sql);
                List<InventariadoCliente> tec = new List<InventariadoCliente>();
                DbDataReader result = db.Query();

                while (result.Read())
                {
                    int codcod = result.GetInt32(0);
                    string codruta = result.GetString(1);
                    string codlugar = result.GetString(2);
                    string codnombre = result.GetString(3);
                    string codcorreo = result.GetString(4);
                    string codtelefono = result.GetString(5);
                    string codtipo = result.GetString(6);
                    string codplano = result.GetString(7);
                    string codid = result.GetString(8);
                    string codrut = result.GetString(9);
                    string codcli = result.GetString(10);
                    string codnombrecliente = result.GetString(11);
                    string codtipolugar = result.GetString(12);
                    string codestado = result.GetString(13);

                    InventariadoCliente a = new InventariadoCliente(codcod, codruta, codlugar, codnombre, codcorreo, codtelefono, codtipo, codplano, codid, codrut, codcli, codnombrecliente, codtipolugar, codestado);
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


        public List<cliente> mbuscarPlanilla(string s)
        {
            try
            {
                DataBase db = new DataBase();
                db.connect();

              
                string sql = "select cliente.cod, cliente.Nombre, cliente.Rut, cliente.Clasificacion from cliente where cliente.nombre like '%" + s + "%'";
                db.CreateCommand(sql);
                List<cliente> tec = new List<cliente>();
                DbDataReader result = db.Query();

                while (result.Read())
                {
                    int codcod = result.GetInt32(0);
                    string codnom = result.GetString(1);
                    string codrut = result.GetString(2);
                    string codclasi = result.GetString(3);
                    //  string codnomtra = result.GetString(4);




                    cliente a = new cliente(codcod, codnom, codrut, codclasi);
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
        public List<cliente> mbuscarPlanillaLUGAR(string s)
        {
            try
            {
                DataBase db = new DataBase();
                db.connect();


                string sql = "select cliente.cod, cliente.Nombre, cliente.Rut, cliente.Clasificacion from cliente, lugartratamiento where cliente.Cod=lugartratamiento.Cliente_Cod and lugartratamiento.nombretratamiento like '%" + s + "%' group by cliente.Cod";
                db.CreateCommand(sql);
                List<cliente> tec = new List<cliente>();
                DbDataReader result = db.Query();

                while (result.Read())
                {
                    int codcod = result.GetInt32(0);
                    string codnom = result.GetString(1);
                    string codrut = result.GetString(2);
                    string codclasi = result.GetString(3);
                    //  string codnomtra = result.GetString(4);




                    cliente a = new cliente(codcod, codnom, codrut, codclasi);
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

