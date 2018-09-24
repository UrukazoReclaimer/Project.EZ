using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.Common;

namespace Project.DataAccess
{
   public class DataBase
    {
        DbConnection connection;
        DbCommand command;
        string stringConnection;
        DbProviderFactory factory;
        DbDataAdapter adap;

        public DataBase()
        {

            string provider = ConfigurationManager.AppSettings.Get("PROVEEDOR");
            this.stringConnection = ConfigurationManager.AppSettings.Get("CADENA");
            factory = DbProviderFactories.GetFactory(provider);
           
        }

        public void connect()
        {

            this.connection = factory.CreateConnection();
            this.connection.ConnectionString = stringConnection;
            this.connection.Open();
        }

  
   
        public void CreateCommand(string mysql)
        {
            this.command = factory.CreateCommand();
            this.command.Connection = connection;
            this.command.CommandType = CommandType.Text;
            this.command.CommandText = mysql;
        }

        public void CreateCommandPA(string mysql)
        {
            this.command = factory.CreateCommand();
            this.command.Connection = connection;
            this.command.CommandType = CommandType.StoredProcedure;
            this.command.CommandText = mysql;
            
        }

     

        public DbDataReader Query()
        {
            try
            {

                return command.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw new DataAccess.DataAccessException(ex.Message);
            }
        }

        public void close()
        {
            this.connection.Close();
        }

        public void execute()
        {
            try
            {
                this.command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new DataAccess.DataAccessException(ex.Message);
            }
        }

        public void excalar()
        {
            try
            {
                this.command.ExecuteScalar();

            }
            catch (Exception ex)
            {
                throw new DataAccess.DataAccessException(ex.Message);
            }

        }

        public void createParameter(string name, DbType type, object value)
        {

            DbParameter parameter = factory.CreateParameter();
            parameter.DbType = type;
            parameter.ParameterName = name;
            parameter.Value = value;
            this.command.Parameters.Add(parameter);
        }

      
                }
            
          
        
       
    }

