using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemas
{
    class CompleteRange
    {
        public int[] build(int[] arreglo)
        {
            for(int i = arreglo.Count() -1; i > 0; i--)
            {
                if (arreglo[i] != arreglo[i - 1] + 1)
                {
                    var parte_a = arreglo.Take(i);
                    int[] parte_b = new int[arreglo.Count() - i];
                    Array.Copy(arreglo, i, parte_b, 0, arreglo.Count() - i);
                    //arreglo.CopyTo(parte_b, i);

                    var add = Enumerable.Range(arreglo[i-1]+1, (arreglo[i] - arreglo[i-1]) - 1 ).Select(x => x);
                    arreglo = parte_a.Concat(add).Concat(parte_b).ToArray();
                }
            }

            return arreglo;
        }

       
    }
}
