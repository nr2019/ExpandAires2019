using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Data;
using System.Data.SqlClient;
using BE;
//using GUI;

namespace DAL
{ 
    public class DALBitacora : ICrudBD
    {
        private static BEBitacora _instancia = new BEBitacora();

        public static BEBitacora instancia
        {
            get
            {
                return _instancia;
            }
        }

        private DALBitacora()
        {
        }

        public DataTable SelectByFechas(DateTime fechaDesde, DateTime fechaHasta, string usuarioMail = null)
        {
            try
            {
                string _SP = "BitacoraSelectByFechas";
                SqlParameter[] sqlParametros = new SqlParameter[3];
                sqlParametros[0] = DALSqlHelper.instancia.crearParametro("fechaDesde", fechaDesde);
                sqlParametros[1] = DALSqlHelper.instancia.crearParametro("fechaHasta", fechaHasta);
                sqlParametros[2] = DALSqlHelper.instancia.crearParametro("usuarioMail", usuarioMail);
                return DALSqlHelper.instancia.EjecutarConsulta(_SP, sqlParametros);
            }
            catch (Exception __unusedException1__)
            {
                throw;
            }
        }

        public int Create(object T)
        {
            try
            {
                string _SP = "BitacoraInsert";
                SqlParameter[] sqlParametros = new SqlParameter[4];
                sqlParametros[0] = DALSqlHelper.instancia.crearParametro("fecha", ((BEBitacora)T).Fecha);
                sqlParametros[1] = DALSqlHelper.instancia.crearParametro("tipoEventoId", System.Convert.ToInt32(((BEBitacora)T).TipoEvento));
                // sqlParametros(2) = DALSqlHelper.instancia.crearParametro("usuarioMail", (CType(T, BEBitacora)).usuarioMail)
                sqlParametros[3] = DALSqlHelper.instancia.crearParametro("descripcion", ((BEBitacora)T).Descripcion);
                return DALSqlHelper.instancia.EjecutarComando(_SP, sqlParametros);
            }
            catch (Exception __unusedException1__)
            {
                throw;
            }
        }

        public List<object> RetrieveAll()
        {
            throw new NotImplementedException();
        }

        public int Update(object T)
        {
            throw new NotImplementedException();
        }

        public int Delete(object T)
        {
            throw new NotImplementedException();
        }
    }
}
