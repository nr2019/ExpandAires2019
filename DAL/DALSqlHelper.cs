using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALSqlHelper
    {
        private static DALSqlHelper _instancia;
        private readonly string _connectionString;
        private readonly SqlConnection _unaConexionSql = new SqlConnection();
        private string _unaConsultaSQL;
//        Private _cn As New SqlConnection("DATA SOURCE = .\SQLEXPRESS; INITIAL CATALOG= EXPANDAIRES; INTEGRATED SECURITY = SSPI")
  //  Private _tx As SqlTransaction

        public static DALSqlHelper instancia
        {
            get
            { 
                if (_instancia == null)
                    _instancia = new DALSqlHelper();

                return _instancia;
            }
        }

        public string connectionString
        {
            get
            {
                return _connectionString;
            }
        }

        public string unaConsultaSQL
        {
            get
            {
                return _unaConsultaSQL;
            }
            set
            {
                _unaConsultaSQL = value;
            }
        }

        private DALSqlHelper()
        {
            //_connectionString = ConfigurationManager.AppSettings("strCon");
            //_unaConexionSql.ConnectionString = this.connectionString;
            _unaConexionSql.ConnectionString = "DATA SOURCE = INST_2019; INITIAL CATALOG = EXPANDAIRES; INTEGRATED SECURITY = SSPI";
            
            if (string.IsNullOrEmpty(_connectionString))
                throw new ApplicationException("No se pudo obtener el string de conexión a la base de datos. Verifique el archivo de recursos.");
        }

        public DataTable EjecutarConsulta(string unSP, SqlParameter[] sqlParameters = null)
        {
            DataTable unDataTable = new DataTable();

            try
            {
                SqlCommand unSqlCommand = new SqlCommand();
                unSqlCommand.Connection = _unaConexionSql;
                unSqlCommand.CommandText = unSP;
                unSqlCommand.CommandType = CommandType.StoredProcedure;

                if (sqlParameters != null)
                    unSqlCommand.Parameters.AddRange(sqlParameters);

                SqlDataAdapter unDataAdapter;
                unDataAdapter = new SqlDataAdapter(unSqlCommand);
                unDataAdapter.Fill(unDataTable);
            }
            catch (Exception ex)
            {
                throw;
            }

            return unDataTable;
        }

        public int EjecutarComando(string unSP, SqlParameter[] sqlParameters = null)
        {
            _unaConexionSql.Open();
            int cantFilas = -1;

            try
            {
                SqlCommand unSqlCommand = new SqlCommand();
                unSqlCommand.Connection = _unaConexionSql;
                unSqlCommand.CommandText = unSP;
                unSqlCommand.CommandType = CommandType.StoredProcedure;

                if (sqlParameters != null)
                    unSqlCommand.Parameters.AddRange(sqlParameters);

                cantFilas = unSqlCommand.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                _unaConexionSql.Close();
            }

            return cantFilas;
        }

        public int EjecutarEscalar(string unSP, SqlParameter[] sqlParameters = null)
        {
            _unaConexionSql.Open();
            int cantFilas = -1;

            try
            {
                SqlCommand unSqlCommand = new SqlCommand();
                unSqlCommand.Connection = _unaConexionSql;
                unSqlCommand.CommandText = unSP;
                unSqlCommand.CommandType = CommandType.StoredProcedure;

                if (sqlParameters != null)
                    unSqlCommand.Parameters.AddRange(sqlParameters);

                cantFilas = System.Convert.ToInt32(unSqlCommand.ExecuteScalar());
            }
            catch
            {
                throw;
            }
            finally
            {
                _unaConexionSql.Close();
            }

            return cantFilas;
        }

        public SqlParameter crearParametro(string nombre, string valor)
        {
            try
            {
                return new SqlParameter()
                {
                    ParameterName = "@" + nombre,
                    SqlDbType = SqlDbType.NVarChar,
                    Value = valor
                };
            }
            catch (Exception __unusedException1__)
            {
                throw;
            }
        }

        public SqlParameter crearParametro(string nombre, bool valor)
        {
            try
            {
                return new SqlParameter()
                {
                    ParameterName = "@" + nombre,
                    SqlDbType = SqlDbType.Int,
                    Value = valor
                };
            }
            catch (Exception __unusedException1__)
            {
                throw;
            }
        }

        public SqlParameter crearParametro(string nombre, Nullable<bool> valor)
        {
            try
            {
                return (valor == null ? new SqlParameter()
                {
                    ParameterName = "@" + nombre,
                    SqlDbType = SqlDbType.Int,
                    Value = DBNull.Value
                } : new SqlParameter()
                {
                    ParameterName = "@" + nombre,
                    SqlDbType = SqlDbType.Int,
                    Value = valor
                });
            }
            catch (Exception __unusedException1__)
            {
                throw;
            }
        }

        public SqlParameter crearParametro(string nombre, Nullable<DateTime> valor)
        {
            try
            {
                return new SqlParameter()
                {
                    ParameterName = "@" + nombre,
                    SqlDbType = SqlDbType.DateTime,
                    Value = valor
                };
            }
            catch (Exception __unusedException1__)
            {
                throw;
            }
        }

        public SqlParameter crearParametro(string nombre, int valor)
        {
            try
            {
                return (valor == -1 ? new SqlParameter()
                {
                    ParameterName = "@" + nombre,
                    SqlDbType = SqlDbType.Int,
                    Value = DBNull.Value
                } : new SqlParameter()
                {
                    ParameterName = "@" + nombre,
                    SqlDbType = SqlDbType.Int,
                    Value = valor
                });
            }
            catch (Exception __unusedException1__)
            {
                throw;
            }
        }

        public SqlParameter crearParametro(string nombre, Nullable<int> valor)
        {
            try
            {
                return (valor == null ? new SqlParameter()
                {
                    ParameterName = "@" + nombre,
                    SqlDbType = SqlDbType.Int,
                    Value = DBNull.Value
                } : new SqlParameter()
                {
                    ParameterName = "@" + nombre,
                    SqlDbType = SqlDbType.Int,
                    Value = valor
                });
            }
            catch (Exception __unusedException1__)
            {
                throw;
            }
        }

        public SqlParameter crearParametro(string nombre, decimal valor)
        {
            try
            {
                return (valor == -1 ? new SqlParameter()
                {
                    ParameterName = "@" + nombre,
                    SqlDbType = SqlDbType.Decimal,
                    Value = DBNull.Value
                } : new SqlParameter()
                {
                    ParameterName = "@" + nombre,
                    SqlDbType = SqlDbType.Decimal,
                    Value = valor
                });
            }
            catch (Exception __unusedException1__)
            {
                throw;
            }
        }

        public bool ExecuteNonQueryRestore()
        {
            bool isOk = false;
            SqlConnection unaConexionSqlRestore = new SqlConnection();
            //unaConexionSqlRestore.ConnectionString = ConfigurationManager.AppSettings("strConRestore");
            unaConexionSqlRestore.Open();

            try
            {
                SqlCommand unSqlCommand = new SqlCommand();
                unSqlCommand.Connection = unaConexionSqlRestore;
                unSqlCommand.CommandText = unaConsultaSQL;
                unSqlCommand.CommandType = CommandType.Text;
                unSqlCommand.ExecuteNonQuery();
                isOk = true;
            }
            catch (Exception __unusedException1__)
            {
                throw;
            }
            finally
            {
                SqlConnection.ClearAllPools();
                System.Threading.Thread.Sleep(10000);
                unaConexionSqlRestore.Close();
            }

            return isOk;
        }
    }
}
