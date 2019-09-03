using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{  
    public class BEFormularios
    {
        private string _IdFormulario;
        public string IdFormulario
        {
            get
            {
                return _IdFormulario;
            }
            set
            {
                _IdFormulario = value;
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

        private List<BEFormularios> _Formularios = new List<BEFormularios>();
        public List<BEFormularios> Formularios
        {
            get
            {
                return _Formularios;
            }
            set
            {
                _Formularios = value;
            }
        }
    }

}
