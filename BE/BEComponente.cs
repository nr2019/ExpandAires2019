using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{  
    public abstract class BEComponente
    {
        private int _IdPermiso;
        public int IdPermiso
        {
            get
            {
                return _IdPermiso;
            }
            set
            {
                _IdPermiso = value;
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

        private int _Compuesto;
        public int Compuesto
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

        public abstract void Agregar(BEComponente c);
        public abstract void Borrar(BEComponente c);
        public abstract List<BEComponente> ObtHijos();
        public abstract List<BEComponente> ObtJerarquia();
    }
}
