using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{  
    public class BEBitacora
    {
        private int _Id;
        public int Id
        {
            get
            {
                return _Id;
            }
            set
            {
                _Id = value;
            }
        }

        private Nullable<DateTime> _Fecha;
        public Nullable<DateTime> Fecha
        {
            get
            {
                return _Fecha;
            }
            set
            {
                _Fecha = value;
            }
        }

        private EnumTipoEvento _TipoEvento;
        public EnumTipoEvento TipoEvento
        {
            get
            {
                return _TipoEvento;
            }
            set
            {
                _TipoEvento = value;
            }
        }

        private int _IdUsuario;
        public int IdUsuario
        {
            get
            {
                return _IdUsuario;
            }
            set
            {
                _IdUsuario = value;
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
    }

}
