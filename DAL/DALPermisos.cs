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
using DAL;

namespace DAL
{
    public class DALPermisos : ICrudBD
    {
        public int Create(object T) 
        {
            SqlParameter[] parametros = new SqlParameter[3];
            int res = 0;

            /*parametros[0] = DALSqlHelper.instancia.crearParametro("POSICION", (BEComponente)T).POSICION);
            parametros[1] = DALSqlHelper.instancia.crearParametro("FORMULARIO", (BEComponente)T).Formulario);
            parametros[2] = DALSqlHelper.instancia.crearParametro("COMPUESTO", (BEComponente)T).compuesto);
            res = DALSqlHelper.instancia.EjecutarComando("PERMISOS_CREAR", parametros);*/

            return res;
        }

        public int Delete(object T)
        {
            SqlParameter[] parametros = new SqlParameter[1];
            int res = 0;
            /*
                        parametros[0] = DALSqlHelper.instancia.crearParametro("IDPERMISO", T.idpermiso);

                        res = DALSqlHelper.instancia.EjecutarComando("PERMISOS_BORRAR", parametros);
                        */
            return res;
        }

        public List<object> RetrieveAll()
        {
            DataTable tabla = new DataTable();
            List<object> lista = new List<object>();

            tabla = DALSqlHelper.instancia.EjecutarConsulta("PERMISOS_LISTAR");

            foreach (DataRow registro in tabla.Rows)
            {
                if (registro["COMPUESTO"].ToString() == "X")
                {
                    BECompuesto result = new BECompuesto();
                    //result.IdPermiso = registro["IDPERMISO"];
                    result.IdPermiso = Convert.ToInt32(registro["IDPERMISO"].ToString());
                    // result.Posicion = registro("POSICION")
                    lista.Add(result);
                    result = null/* TODO Change to default(_) if this is not a reference type */;
                }
                else
                {
                    BEHoja result2 = new BEHoja();
                    //result2.IdPermiso = registro("IDPERMISO");
                    result2.IdPermiso = Convert.ToInt32(registro["IDPERMISO"].ToString());

                    // result2.Posicion = registro("POSICION")
                    result2.Formulario = registro["FORMULARIO"].ToString();
                    lista.Add(result2);
                    result2 = null/* TODO Change to default(_) if this is not a reference type */;
                }
            }

            return lista;
        }

        public int Update(object T)
        {
            throw new NotImplementedException();
        }

        public List<BEHoja> ListarFormularios()
        {
            DataTable tabla = new DataTable();
            List<BEHoja> lista = new List<BEHoja>();

            tabla = DALSqlHelper.instancia.EjecutarConsulta("FORMULARIOS_LISTAR");

            foreach (DataRow registro in tabla.Rows)
            {
                BEHoja result2 = new BEHoja();


                if ( registro["FORMULARIO"] == DBNull.Value )
                {
                    result2.Formulario = "";
                }
                else
                {
                    result2.Formulario = registro["FORMULARIO"].ToString();
                }
/*                if (IsDBNull(registro("FORMULARIO")) == true)
                    result2.Formulario = "";
                else
                    result2.Formulario = registro("FORMULARIO");
*/


                lista.Add(result2);
                result2 = null/* TODO Change to default(_) if this is not a reference type */;
            }

            return lista;
        }

        public List<BECompuesto> ListarPerfiles()
        {
            DataTable tabla = new DataTable();
            List<BECompuesto> lista = new List<BECompuesto>();

            tabla = DALSqlHelper.instancia.EjecutarConsulta("PERFILES_LISTAR");

            foreach (DataRow registro in tabla.Rows)
            {
                BECompuesto result2 = new BECompuesto();



                if (DBNull.Value == (registro["IDPERMISO"]))
                {
                    // antes devolvía ""
                    result2.IdPermiso = 0;
                } else
                {
                    result2.IdPermiso = Convert.ToInt32(registro["IDPERMISO"].ToString());
                }

                    

                lista.Add(result2);
                result2 = null/* TODO Change to default(_) if this is not a reference type */;
            }

            return lista;
        }
    }

}
