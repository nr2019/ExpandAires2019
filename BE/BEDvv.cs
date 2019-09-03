using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{  
    public class BEDvv
    {
        private string _Entidad;
        public string Entidad
        {
            get
            {
                return _Entidad;
            }
            set
            {
                _Entidad = value;
            }
        }

        private int _Dvv;
        public int Dvv
        {
            get
            {
                return _Dvv;
            }
            set
            {
                _Dvv = value;
            }
        }
    }
}
