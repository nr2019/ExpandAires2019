using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BLL
{
    public class BLLTraduccion 
    {
        private DALTraduccion mptraducciones = new DALTraduccion();
        public List<BETraduccion> ListarTodo()
        {
            List<object> objs = new List<object>();
            List<BETraduccion> traducciones = new List<BETraduccion>();

            objs = mptraducciones.RetrieveAll();

            foreach (dynamic obj in objs)
            {
                if (obj is BETraduccion)
                {
                    BETraduccion traduccion = obj;

                    traducciones.Add(traduccion);
                }
            }

            return traducciones;
        }
    }

}
