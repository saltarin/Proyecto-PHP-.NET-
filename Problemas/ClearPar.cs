using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problemas
{
    class ClearPar
    {
        public string build(string cad)
        {
            int cantidad = new Regex(@"\(\)").Matches(cad).Count;
            return string.Join("()", new string[cantidad + 1]);
        }

    }
}
