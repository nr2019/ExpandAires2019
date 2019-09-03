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
    public class DALIdioma : ICrudBD
    {
        public BEIdioma Validar(BEIdioma IdiomaValidar) 
        {
            DataTable tabla = new DataTable();
            SqlParameter[] parametro = new SqlParameter[1];

            parametro[0] = DALSqlHelper.instancia.crearParametro("IDIOMA", IdiomaValidar.Idioma);



            tabla = DALSqlHelper.instancia.EjecutarConsulta("IDIOMA_VALIDAR", parametro);
            if (tabla.Rows.Count > 0)
            {
                // Se toma el primer valor
                DataRow row = tabla.Rows[0];
                IdiomaValidar.Idioma = row["IDIOMA"].ToString();
                
                //IdiomaValidar.Idioma = LTrim(RTrim(IdiomaValidar.Idioma));
                IdiomaValidar.Idioma = IdiomaValidar.Idioma.Trim();
                IdiomaValidar.Descripcion = row["DESCRIPCION"].ToString();
            }
            else
                IdiomaValidar.Idioma = "";

            return IdiomaValidar;
        }

        public int Create(object T)
        {
            SqlParameter[] parametros = new SqlParameter[2];
            int res;

            parametros[0] = DALSqlHelper.instancia.crearParametro("IDIOMA", ((BEIdioma)T).Idioma);
            parametros[1] = DALSqlHelper.instancia.crearParametro("DESCRIPCION", ((BEIdioma)T).Descripcion);

            res = DALSqlHelper.instancia.EjecutarComando("IDIOMA_ALTA", parametros);

            return res;
        }

        public List<object> RetrieveAll()
        {
            DataTable tabla = new DataTable();
            List<object> lista = new List<object>();


            tabla = DALSqlHelper.instancia.EjecutarConsulta("IDIOMAS_LISTAR");

            foreach (DataRow registro in tabla.Rows)
            {
                BEIdioma result = new BEIdioma();
                result.Idioma = registro["IDIOMA"].ToString();
                result.Descripcion = registro["DESCRIPCION"].ToString();

                lista.Add(result);
                result = null/* TODO Change to default(_) if this is not a reference type */;
            }

            return lista;
        }

        public int Update(object T)
        {
            SqlParameter[] parametros = new SqlParameter[2];
            int res;

            parametros[0] = DALSqlHelper.instancia.crearParametro("IDIOMA", ((BEIdioma)T).Idioma);
            parametros[1] = DALSqlHelper.instancia.crearParametro("DESCRIPCION", ((BEIdioma)T).Descripcion);
            res = DALSqlHelper.instancia.EjecutarComando("IDIOMA_MODIFICACIONES", parametros);

            return res;
        }

        public int Delete(object T)
        {
            SqlParameter[] parametros = new SqlParameter[1];
            int res;

            parametros[0] = DALSqlHelper.instancia.crearParametro("IDIOMA", ((BEIdioma)T).Idioma);
            res = DALSqlHelper.instancia.EjecutarComando("IDIOMA_ELIMINAR", parametros);

            return res;
        }
    }

}
