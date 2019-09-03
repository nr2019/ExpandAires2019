using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{  
    public class BEIdioma
    {
        private string _Idioma;
        public string Idioma
        {
            get
            {
                return _Idioma;
            }
            set
            {
                _Idioma = value;
            }
        }

        private string _Descripcion;
        public string Descripcion
        {
            get
            {
                return _Descripcion;
            }
            set
            {
                _Descripcion = value;
            }
        }

        private List<BETraduccion> _Traducciones = new List<BETraduccion>();
        public List<BETraduccion> Traduccion
        {
            get
            {
                return _Traducciones;
            }
            set
            {
                _Traducciones = value;
            }
        }
    }

}
