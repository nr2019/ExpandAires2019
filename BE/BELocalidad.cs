using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{  
    public class BELocalidad
    {
        private int _IdLocalidad;
        public int IdLocalidad
        {
            get
            {
                return _IdLocalidad;
            }
            set
            {
                _IdLocalidad = value;
            }
        }

        private string _Nombre;
        public string Nombre
        {
            get
            {
                return _Nombre;
            }
            set
            {
                _Nombre = value;
            }
        }

        private string _ConServicio;
        public string ConServicio
        {
            get
            {
                return _ConServicio;
            }
            set
            {
                _ConServicio = value;
            }
        }

        private int _Disponibilidad;
        public int Disponibilidad
        {
            get
            {
                return _Disponibilidad;
            }
            set
            {
                _Disponibilidad = value;
            }
        }

        private int _EnConsumo;
        public int EnConsumo
        {
            get
            {
                return _EnConsumo;
            }
            set
            {
                _EnConsumo = value;
            }
        }

        private string _PendienteEval;
        public string PendienteEval
        {
            get
            {
                return _PendienteEval;
            }
            set
            {
                _PendienteEval = value;
            }
        }

        private string _Viable;
        public string Viable
        {
            get
            {
                return _Viable;
            }
            set
            {
                _Viable = value;
            }
        }
    }

}
