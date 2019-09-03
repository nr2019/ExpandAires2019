using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE 
{ 
    public class BEUsuario : BEPersona
    {
        private int _IDusuario;
        public int IDusuario
        {
            get
            {
                return _IDusuario;
            }
            set
            {
                _IDusuario = value;
            }
        }

        private string _Password;
        public string Password
        {
            get
            {
                return _Password;
            }
            set
            {
                _Password = value;
            }
        }

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

        private string _Bloqueado;
        public string Bloqueado
        {
            get
            {
                return _Bloqueado;
            }
            set
            {
                _Bloqueado = value;
            }
        }
    }

}
