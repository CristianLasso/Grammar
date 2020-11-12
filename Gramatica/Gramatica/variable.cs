using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gramatica
{
    class Variable
    {
        public string Generador
        {
            get;
            set;
        }
        public string Produccion
        {
            get;
            set;
        }

        public Variable(string Gen, string Prod)
        {
            Generador = Gen;
            Produccion = Prod;
        }
    }
}
