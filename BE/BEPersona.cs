using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{ 
    public abstract class BEPersona
    {
        private string _DNI;
        public string DNI
        {
            get
            {
                return _DNI;
            }
            set
            {
                _DNI = value;
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

        private string _Apellido;
        public string Apellido
        {
            get
            {
                return _Apellido;
            }
            set
            {
                _Apellido = value;
            }
        }


    }
}
