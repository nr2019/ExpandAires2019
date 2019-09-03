/// <summary> 
///
/// </summary>


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{  
    public class BECliente : BEPersona
    {
        private int _IdCliente;
        public int IdCliente
        {
            get
            {
                return _IdCliente;
            }
            set
            {
                _IdCliente = value;
            }
        }

        private DateTime _FechaNacimiento;
        public DateTime FechaNacimiento
        {
            get
            {
                return _FechaNacimiento;
            }
            set
            {
                _FechaNacimiento = value;
            }
        }


        private int _Altura;
        public int Altura
        {
            get
            {
                return _Altura;
            }
            set
            {
                _Altura = value;
            }
        }

        private string _Calle;
        public string Calle
        {
            get
            {
                return _Calle;
            }
            set
            {
                _Calle = value;
            }
        }

        private string _Depto;
        public string Depto
        {
            get
            {
                return _Depto;
            }
            set
            {
                _Depto = value;
            }
        }

        private int _Piso;
        public int Piso
        {
            get
            {
                return _Piso;
            }
            set
            {
                _Piso = value;
            }
        }

        private string _Estado;
        public string Estado
        {
            get
            {
                return _Estado;
            }
            set
            {
                _Estado = value;
            }
        }


        private string _Veraz;
        public string Veraz
        {
            get
            {
                return _Veraz;
            }
            set
            {
                _Veraz = value;
            }
        }
    }

}
