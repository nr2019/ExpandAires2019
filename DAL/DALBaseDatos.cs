using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq;
using System.Data.SqlClient;

using System;
namespace DAL 
{    public class DALBaseDatos
    {
        private static DALBaseDatos _instancia = new DALBaseDatos();
        private string _RutaBackup;

        public static DALBaseDatos instancia
        {
            get
            {
                return _instancia;
            }
        }

        public string RutaBackups
        {
            get
            {
                return _RutaBackup;
            }
        }

        private DALBaseDatos()
        {
            //_RutaBackup = ConfigurationManager.AppSettings("rutaBackups");
        }

        public bool RealizarBackup()
        {
            if (true)
            {
                try
                {
                    string _SP = "BackupBaseDatos";
                    SqlParameter[] sqlParametros = new SqlParameter[1];
                    sqlParametros[0] = DALSqlHelper.instancia.crearParametro("dir", _RutaBackup);
                    return DALSqlHelper.instancia.EjecutarComando(_SP, sqlParametros) > 0;
                }
                catch (Exception __unusedException1__)
                {
                    throw;
                }
            }
        }

        public bool RealizarRestore(string path)
        {
            try
            {
                SqlConnection _unaConexionSql = new SqlConnection();
                //string connectionString = ConfigurationManager.AppSettings("strCon");
                //_unaConexionSql.ConnectionString = connectionString;
                string database = _unaConexionSql.Database;
                string _consuSQL = string.Format("ALTER DATABASE {1} SET SINGLE_USER WITH ROLLBACK IMMEDIATE RESTORE DATABASE {1} FROM DISK = '{0}' WITH REPLACE", path, database);
                DALSqlHelper.instancia.unaConsultaSQL = _consuSQL;
                DALSqlHelper.instancia.ExecuteNonQueryRestore();
                string _consuSQLMultiUser = string.Format("ALTER DATABASE {0} SET MULTI_USER", database);
                DALSqlHelper.instancia.unaConsultaSQL = _consuSQLMultiUser;
                return DALSqlHelper.instancia.ExecuteNonQueryRestore();
            }
            catch (Exception __unusedException1__)
            {
                throw;
            }
        }

        public Array getFilesRestore()
        {
            DirectoryInfo di = new DirectoryInfo(_RutaBackup);
            var archivosBak = di.GetFiles("*.bak").Select(f => new
            {
                f.Name,
                f.CreationTime
            }).OrderByDescending(p => p.CreationTime).ToArray();
            return archivosBak;
        }
    }
}

