using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{  
    public class BESesion
    {
        private static BESesion FInstance = null;

        private BESesion()
        {
        }

        public static BESesion Instancia
        {
            get
            {
                if ((FInstance == null))
                    FInstance = new BESesion();

                return FInstance;
            }
        }

        private string _Abierta;
        public string Abierta
        {
            get
            {
                return _Abierta;
            }
            set
            {
                _Abierta = value;
            }
        }

        private BEUsuario _Usuario;
        public BEUsuario Usuario
        {
            get
            {
                return _Usuario;
            }
            set
            {
                _Usuario = value;
            }
        }

        private BEIdioma _Idioma;
        public BEIdioma Idioma
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

        private int _IntentosFallidos;
        public int IntentosFallidos
        {
            get
            {
                return _IntentosFallidos;
            }
            set
            {
                _IntentosFallidos = value;
            }
        }

        private List<BETraduccion> _Traducciones = new List<BETraduccion>();
        public List<BETraduccion> Traducciones
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

        private BECompuesto _Compuesto = new BECompuesto();
        public BECompuesto Compuesto
        {
            get
            {
                return _Compuesto;
            }
            set
            {
                _Compuesto = value;
            }
        }
    }
    // PERMISOS VAN EN OBJETO SESIÒN!!!!!!!!!!!!!!!!!!!!
}
