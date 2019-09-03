using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRV
{
    public class SRVFunciones
    {
        public int ValidarSoloLetras(string cadena)
        {
            int res;
            int result;

            if (int.TryParse(cadena, out result))
            {
                res = -1;
            }
            else
            {
                res = 1; 
            }

            return res;
        }

        public int ValidarSoloNumeros(string cadena)
        {
            int res = 1;
            int result;

            if (int.TryParse(cadena, out result))
            {
                res = 1;
            }
            else
            {
                res = -1;
            }

            return res;
        }
    }
}
