using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

using Microsoft.VisualBasic;
using System.Data.SqlClient;
using BE;
using DAL;
using System.Data;

namespace DAL 
{
    public class DALDvv : ICrudBD
    {
        private static DALDvv _instancia = new DALDvv();

        public static DALDvv instancia
        {
            get
            {
                return _instancia;
            }
        }

        private DALDvv()
        {
        }

        int ICrudBD.Create(object T)
        {
            string _SP = "DvvInsert";
            SqlParameter[] sqlParametros = new SqlParameter[2];
            sqlParametros[0] = DALSqlHelper.instancia.crearParametro("entidad", ((BEDvv)T).Entidad);
            sqlParametros[1] = DALSqlHelper.instancia.crearParametro("dvv", ((BEDvv)T).Dvv);
            return DALSqlHelper.instancia.EjecutarComando(_SP, sqlParametros);
        }

        List<object> ICrudBD.RetrieveAll()
        {
            string _SP = "DvvSelectAll";
            DataTable dtDvv;
            dtDvv = DALSqlHelper.instancia.EjecutarConsulta(_SP);

            List<BEDvv> lstDvv = new List<BEDvv>();
            List<object> lstDvv2 = new List<object>();
            lstDvv = MapearDvv(dtDvv);

            // lstDvv2 = lstDvv no puede convertir el tipo
            return lstDvv2;
        }

        int ICrudBD.Update(object T)
        {
            string _SP = "DvvUpdate";
            SqlParameter[] sqlParametros = new SqlParameter[2];
            sqlParametros[0] = DALSqlHelper.instancia.crearParametro("entidad", ((BEDvv)T).Entidad);
            sqlParametros[1] = DALSqlHelper.instancia.crearParametro("dvv", ((BEDvv)T).Dvv);
            return DALSqlHelper.instancia.EjecutarComando(_SP, sqlParametros);
        }

        int ICrudBD.Delete(object T)
        {
            string _SP = "DvvDelete";
            SqlParameter[] sqlParametros = new SqlParameter[1];
            sqlParametros[0] = DALSqlHelper.instancia.crearParametro("entidad", ((BEDvv)T).Entidad);
            return DALSqlHelper.instancia.EjecutarComando(_SP, sqlParametros);
        }

      
       
       
        public List<BEDvv> Retrieve(BEDvv unDvv)
        {
            
            List<BEDvv> lista = new List<BEDvv>();


            string _SP = "DvvSelect";
            SqlParameter[] sqlParametros = new SqlParameter[1];
            sqlParametros[0] = DALSqlHelper.instancia.crearParametro("entidad", unDvv.Entidad);
            DataTable dtDvv = new DataTable();
            dtDvv = DALSqlHelper.instancia.EjecutarConsulta(_SP, sqlParametros);
            if (dtDvv.Rows.Count <= 0)
            {
                return null;
            }
            else
            {
                lista = MapearDvv(dtDvv);
                 return lista;
            }
                /* TODO Change to default(_) if this is not a reference type */;
            //return MapearDvv(dtDvv)(0);
            
        }

        private List<BEDvv> MapearDvv(DataTable dt)
        {
            List<BEDvv> lstDvv = new List<BEDvv>();

            foreach (DataRow _row in dt.Rows)
            {
                BEDvv unDvv = new BEDvv();
                unDvv.Entidad = System.Convert.ToString(_row["entidad"]);
                unDvv.Dvv = System.Convert.ToInt32(_row["dvv"]);
                lstDvv.Add(unDvv);
            }

            return lstDvv;
        }

    }

}
