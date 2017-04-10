using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemas
{
    class ChangeString
    {
        public string build(string cadena)
        {

            var abecedario = Enumerable.Range('a', 'z' - 'a' + 1).Select(x => (char)x).ToList();
            abecedario.Insert(14,'ñ');

            var dic = new Dictionary<char, char>();

            int i;
            for(i = 0; i< abecedario.Count() - 1; i++)
            {
                dic.Add(abecedario[i], abecedario[i + 1]);
            }
            dic.Add(abecedario[i], abecedario[0]);

            StringBuilder salida = new StringBuilder();
            bool saltar;
            bool regresar;
            char caracter;

            for(int j = 0; j < cadena.Length; j++)
            {
                saltar = false;
                regresar = false;
                caracter = cadena[j];

                if (!Char.IsLetterOrDigit(cadena[j]))
                    saltar = true;
                if (Char.IsNumber(cadena[j]))
                    saltar = true;

                if (!saltar)
                {
                    if (Char.IsUpper(cadena[j]))
                    {
                        caracter = Char.ToLower(cadena[j]);
                        regresar = true;
                    }

                    caracter = dic[caracter];

                    if (regresar)
                        caracter = Char.ToUpper(caracter);
                }

                salida.Append(caracter);
            }

            return salida.ToString();
        }
    }
}
