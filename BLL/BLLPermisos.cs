using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BLL
{ 
    public class BLLPermisos
    {
        private DALPermisos mppermisos = new DALPermisos();
        // Dim ngbitacora As New BLLBitacora


        public int Crear(List<BEComponente> Permisos)
        {
            List<BEComponente> lista = new List<BEComponente>();
            int res;

            foreach (BEComponente t in Permisos)
            {
                if (t is BEHoja)
                {
                    BEHoja res2 = new BEHoja();
                    // res2.Posicion = t.Posicion
                    res2.Formulario = t.Formulario;

                    lista.Add(res2);
                    res2 = null/* TODO Change to default(_) if this is not a reference type */;
                }
                else if (t is BECompuesto)
                {
                    BECompuesto res1 = new BECompuesto();

                    // res1.Posicion = t.Posicion


                    lista.Add(res1);
                    res1 = null/* TODO Change to default(_) if this is not a reference type */;
                }
            }

            res = mppermisos.Create(lista);

            return res;
        }

        public List<BEHoja> ListarFormularios()
        {
            List<BEHoja> lista = new List<BEHoja>();

            lista = mppermisos.ListarFormularios();


            return lista;
        }

        public List<BECompuesto> ListarPerfiles()
        {
            List<BECompuesto> lista = new List<BECompuesto>();

            lista = mppermisos.ListarPerfiles();


            return lista;
        }
    }

}
