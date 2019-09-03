using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SRV
{
    public class SRVGestorPolitica
    {
        private static SRVGestorPolitica _instancia = new SRVGestorPolitica();

        public static SRVGestorPolitica instancia
        {
            get
            {
                return _instancia;
            }
            set
            {
                _instancia = value;
            }
        }

        private SRVGestorPolitica()
        {
        }
         
        public bool ValidarPassword(string password)
        {
            Regex myregex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$");
            return myregex.IsMatch(password);
        }

        public bool ValidarMail(string mail)
        {
            Regex myregex = new Regex(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");
            return myregex.IsMatch(mail);
        }
    }

}
