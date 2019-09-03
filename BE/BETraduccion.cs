using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{  
    public class BETraduccion
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

        private string _Formulario;
        public string Formulario
        {
            get
            {
                return _Formulario;
            }
            set
            {
                _Formulario = value;
            }
        }

        private string _Control;
        public string Control
        {
            get
            {
                return _Control;
            }
            set
            {
                _Control = value;
            }
        }

        private string _Traduccion;
        public string Traduccion
        {
            get
            {
                return _Traduccion;
            }
            set
            {
                _Traduccion = value;
            }
        }
    }

}
