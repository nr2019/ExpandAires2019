using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{  
    public class BEEmpleado : BEPersona
    {
        private int _IdEmpleado;
        public int IdEmpleado
        {
            get
            {
                return _IdEmpleado;
            }
            set
            {
                _IdEmpleado = value;
            }
        }

        private int _IdCargo;
        public int IdCargo
        {
            get
            {
                return _IdCargo;
            }
            set
            {
                _IdCargo = value;
            }
        }

        private DateTime _FechaIngreso;
        public DateTime FechaIngreso
        {
            get
            {
                return _FechaIngreso;
            }
            set
            {
                _FechaIngreso = value;
            }
        }
    }

}
