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
using DAL;
using System.Data;

namespace DAL
{
    public class DALTraduccion : ICrudBD
    {

         
        // Public Function Validar(IdiomaValidar As BEIdioma) As BEIdioma
        // Dim tabla As New DataTable
        // Dim parametro(0) As SqlParameter

        // parametro(0) = DALSqlHelper.instancia.crearParametro("IDIOMA", IdiomaValidar.Idioma)



        // tabla = DALSqlHelper.instancia.EjecutarConsulta("IDIOMA_VALIDAR", parametro)
        // If tabla.Rows.Count > 0 Then
        // IdiomaValidar.Idioma = tabla.Rows(0)("IDIOMA")
        // IdiomaValidar.Idioma = LTrim(RTrim(IdiomaValidar.Idioma))
        // IdiomaValidar.Descripcion = tabla.Rows(0)("DESCRIPCION")
        // Else
        // IdiomaValidar.Idioma = ""
        // End If

        // Return IdiomaValidar

        // End Function

        public int Create(dynamic T)
        {
            SqlParameter[] parametros = new SqlParameter[4];
            int res;

            parametros[0] = DALSqlHelper.instancia.crearParametro("IDIOMA", T.Idioma);
            parametros[1] = DALSqlHelper.instancia.crearParametro("FORMULARIO", T.Descripcion);
            parametros[2] = DALSqlHelper.instancia.crearParametro("CONTROL", T.control);
            parametros[3] = DALSqlHelper.instancia.crearParametro("TRADUCCION", T.traduccion);

            res = DALSqlHelper.instancia.EjecutarComando("TRADUCCION_ALTA", parametros);

            return res;
        }

        public List<object> RetrieveAll()
        {
            DataTable tabla = new DataTable();
            List<object> lista = new List<object>();


            tabla = DALSqlHelper.instancia.EjecutarConsulta("TRADUCCION_LISTAR");

            foreach (DataRow registro in tabla.Rows)
            {
                BETraduccion result = new BETraduccion();
                result.Idioma = registro["IDIOMA"].ToString();
                result.Formulario = registro["FORMULARIO"].ToString();
                result.Control = registro["CONTROL"].ToString();
                result.Traduccion = registro["TRADUCCION"].ToString();
                lista.Add(result);
                result = null/* TODO Change to default(_) if this is not a reference type */;
            }

            return lista;
        }

        public int Update(dynamic T)
        {
            SqlParameter[] parametros = new SqlParameter[4];
            int res;

            parametros[0] = DALSqlHelper.instancia.crearParametro("IDIOMA", T.Idioma);
            parametros[1] = DALSqlHelper.instancia.crearParametro("DESCRIPCION", T.Descripcion);
            parametros[2] = DALSqlHelper.instancia.crearParametro("CONTROL", T.control);
            parametros[3] = DALSqlHelper.instancia.crearParametro("TRADUCCION", T.traduccion);
            res = DALSqlHelper.instancia.EjecutarComando("TRADUCCION_MODIFICAR", parametros);

            return res;
        }

        public int Delete(dynamic T)
        {
            SqlParameter[] parametros = new SqlParameter[1];
            int res;

            parametros[0] = DALSqlHelper.instancia.crearParametro("IDIOMA", T.Idioma);
            res = DALSqlHelper.instancia.EjecutarComando("TRADUCCION_ELIMINAR", parametros);

            return res;
        }
    }

}
