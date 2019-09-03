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
using BE;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DALUsuario : ICrudBD
    {
        private const string IDUSUARIO = "IDUSUARIO";

        public int Create(object T) 
        {
            SqlParameter[] parametros = new SqlParameter[5];
            int res;
            // @IDUSUARIO LO CALCULA LA BASE
            parametros[0] = DALSqlHelper.instancia.crearParametro("NOMBRE", ((BEUsuario)T).Nombre  );
            parametros[1] = DALSqlHelper.instancia.crearParametro("APELLIDO", ((BEUsuario)T).Apellido);
            parametros[2] = DALSqlHelper.instancia.crearParametro("DNI", ((BEUsuario)T).DNI);
            parametros[3] = DALSqlHelper.instancia.crearParametro("PASSWORD", ((BEUsuario)T).Password);
            parametros[4] = DALSqlHelper.instancia.crearParametro("BLOQUEADO", ((BEUsuario)T).Bloqueado);
            res = DALSqlHelper.instancia.EjecutarComando("USUARIO_ALTA", parametros);

            return res;
        }

        public int Delete(object T)
        {
            SqlParameter[] parametros = new SqlParameter[1];
            int res;

            parametros[0] = DALSqlHelper.instancia.crearParametro("IDUSUARIO", ((BEUsuario)T).IDusuario);
            res = DALSqlHelper.instancia.EjecutarComando("USUARIO_BAJA", parametros);

            return res;
        }

        public List<object> RetrieveAll()
        {
            DataTable tabla = new DataTable();
            List<object> lista = new List<object>();

            tabla = DALSqlHelper.instancia.EjecutarConsulta("USUARIO_LISTAR");

            foreach (DataRow registro in tabla.Rows)
            {
                // Dim result As DataRow = lista.NewRow
                BEUsuario result = new BEUsuario();
                result.IDusuario = Convert.ToInt32(registro["IDUSUARIO"].ToString());
                result.Nombre = registro["NOMBRE"].ToString();
                result.Apellido = registro["APELLIDO"].ToString();
                result.DNI = registro["DNI"].ToString();
                result.Password = registro["PASSWORD"].ToString();
                result.Bloqueado = registro["BLOQUEADO"].ToString();

                lista.Add(result);
                result = null/* TODO Change to default(_) if this is not a reference type */;
            }
            return lista;
        }

        public int Update(object T)
        {
            int res = 0;
            /*SqlParameter[] parametros = new SqlParameter[2];


            parametros[0] = DALSqlHelper.instancia.crearParametro("IDIOMA", ((BEUsuario)T).Idioma);
            parametros[1] = DALSqlHelper.instancia.crearParametro("DESCRIPCION", ((BEUsuario)T).Descripcion);

            res = DALSqlHelper.instancia.EjecutarComando("IDIOMA_MODIFICACION", parametros);
            */
            return res;
        }

        public BEUsuario RecuperarUsuario(BEUsuario UnUsuario)
        {
            DataTable tabla = new DataTable();
            SqlParameter[] parametro = new SqlParameter[1];
            BEUsuario Usbd = new BEUsuario();

            parametro[0] = DALSqlHelper.instancia.crearParametro("IDUSUARIO", UnUsuario.IDusuario);

            tabla = DALSqlHelper.instancia.EjecutarConsulta("USUARIO_RECUPERAR", parametro);

            if (tabla.Rows.Count > 0)
            {
                DataRow registro = tabla.Rows[0];
                Usbd.IDusuario = Convert.ToInt32(registro["IDUSUARIO"]);
                Usbd.Nombre = registro["NOMBRE"].ToString();
                Usbd.Apellido = registro["APELLIDO"].ToString();
                Usbd.DNI = registro["DNI"].ToString();
                Usbd.Password = registro["PASSWORD"].ToString();
                Usbd.Password = Usbd.Password.Trim();

                if (registro["BLOQUEADO"] == System.DBNull.Value)
                    Usbd.Bloqueado = "";
                else
                    Usbd.Bloqueado = registro["BLOQUEADO"].ToString();
            }
            else
                Usbd.IDusuario = -1;
            return Usbd;
        }

        public BEUsuario UsuarioCreado()
        {
            DataTable tabla = new DataTable();
            DataTable lista = new DataTable();
            BEUsuario ultimo = new BEUsuario();

            // Dim res As Integer

            lista.Columns.Add(new DataColumn("IDUSUARIO"));
            lista.Columns.Add(new DataColumn("NOMBRE"));
            lista.Columns.Add(new DataColumn("APELLIDO"));
            lista.Columns.Add(new DataColumn("DNI"));
            lista.Columns.Add(new DataColumn("PASSWORD"));
            lista.Columns.Add(new DataColumn("BLOQUEADO"));

            tabla = DALSqlHelper.instancia.EjecutarConsulta("USUARIO_CREADO");

            foreach (DataRow registro in tabla.Rows)
            {
                DataRow result = lista.NewRow();
                
                ultimo.IDusuario = Convert.ToInt32( registro["IDUSUARIO"] );
                ultimo.Nombre = registro["NOMBRE"].ToString();
                ultimo.Apellido = registro["APELLIDO"].ToString();
                ultimo.DNI = registro["DNI"].ToString();
                ultimo.Password = registro["PASSWORD"].ToString();
                ultimo.Password = ultimo.Password.Trim();

                    if (registro["BLOQUEADO"] == System.DBNull.Value)
                        ultimo.Bloqueado = "";
                else
                    ultimo.Bloqueado = registro["BLOQUEADO"].ToString();
            }


            return ultimo;
        }

        public BEUsuario BuscarDNI(BEUsuario UnUsuario)
        {
            DataTable tabla = new DataTable();
            SqlParameter[] parametro = new SqlParameter[1];
            BEUsuario Usbd = new BEUsuario();
            // Dim res As Integer

            parametro[0] = DALSqlHelper.instancia.crearParametro("DNI", UnUsuario.DNI);

            tabla = DALSqlHelper.instancia.EjecutarConsulta("USUARIO_BUSCARDNI");
            if (tabla.Rows.Count > 0)
            {
                DataRow registro = tabla.Rows[0];
                Usbd.IDusuario = Convert.ToInt32( registro["IDUSUARIO"]);
                Usbd.Nombre = registro["NOMBRE"].ToString();
                Usbd.Apellido = registro["APELLIDO"].ToString();
                Usbd.DNI = registro["DNI"].ToString();

                Usbd.Password = registro["PASSWORD"].ToString();
                //Usbd.Password = LTrim ( RTrim (Usbd.Password));
                Usbd.Password = Usbd.Password.Trim();

                if (registro["BLOQUEADO"] == System.DBNull.Value)
                    Usbd.Bloqueado = "";
                else
                    Usbd.Bloqueado = registro["BLOQUEADO"].ToString();
            }
            else
                Usbd.IDusuario = -1;
            return Usbd;
        }

        public int CambiarPass(BEUsuario UnUsuario)
        {
            DataTable tabla = new DataTable();
            SqlParameter[] parametros = new SqlParameter[2];
            int res;
            parametros[0] = DALSqlHelper.instancia.crearParametro("IDUSUARIO", UnUsuario.IDusuario);
            parametros[1] = DALSqlHelper.instancia.crearParametro("PASSWORD", UnUsuario.Password);
            res = DALSqlHelper.instancia.EjecutarComando("USUARIO_MODIFICACION_PASS", parametros);

            return res;
        }

        public int Bloquear(BEUsuario UnUsuario)
        {
            DataTable tabla = new DataTable();
            SqlParameter[] parametros = new SqlParameter[2];
            int res;
            parametros[0] = DALSqlHelper.instancia.crearParametro("IDUSUARIO", UnUsuario.IDusuario);
            parametros[1] = DALSqlHelper.instancia.crearParametro("BLOQUEADO", UnUsuario.Bloqueado);

            res = DALSqlHelper.instancia.EjecutarComando("USUARIO_BLOQUEADO", parametros);
            return res;
        }

        public int Desbloquear(BEUsuario UnUsuario)
        {
            DataTable tabla = new DataTable();
            SqlParameter[] parametros = new SqlParameter[2];
            int res;
            parametros[0] = DALSqlHelper.instancia.crearParametro("IDUSUARIO", UnUsuario.IDusuario);
            parametros[1] = DALSqlHelper.instancia.crearParametro("BLOQUEADO", UnUsuario.Bloqueado);

            res = DALSqlHelper.instancia.EjecutarComando("USUARIO_BLOQUEADO", parametros);

            return res;
        }
    }

}
