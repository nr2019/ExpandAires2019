using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE 
{ 
    public class BECompuesto : BEComponente
    {
        private List<BEComponente> _lista = new List<BEComponente>();

        public List<BEComponente> Lista
        {
            get
            {
                return _lista;
            }
            set
            {
                _lista = value;
            }
        }

        public override void Agregar(BEComponente c)
        {
            Lista.Add(c);
        }

        public override void Borrar(BEComponente c)
        {
            Lista.Remove(c);
        }

        public override List<BEComponente> ObtHijos()
        {
            List<BEComponente> ret = new List<BEComponente>();

            foreach (BEComponente b in Lista)
                ret.Add(b);

            return ret;
        }

        public override List<BEComponente> ObtJerarquia()
        {
            List<BEComponente> resultado = new List<BEComponente>();
            List<BEComponente> intermedia = new List<BEComponente>();

            foreach (BEComponente r in this.Lista)
            {
                resultado.Add(r);

                if (r is BECompuesto)
                    intermedia = buscar(resultado, r);
            }

            return resultado;
        }


        private List<BEComponente> buscar(List<BEComponente> lst, BEComponente obj)
        {
            List<BEComponente> intermedia = new List<BEComponente>();
            intermedia = obj.ObtJerarquia();

            foreach (BEComponente inter in intermedia)
                lst.Add(inter);

            return lst;
        }
    }
}
