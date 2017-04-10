using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Problemas
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.Out.WriteLine("Problema 1");
            Console.Out.WriteLine("=================");

            CompleteRange completerange = new CompleteRange();

            int[] i = { 1, 2, 4, 5 };
            int[] o = completerange.build(i);
            string cadena = string.Format("entrada: {0} salida: {1}", string.Join("|", i), string.Join("|", o));
            Console.Out.WriteLine(cadena);

            int[] i2 = { 2, 4, 9 };
            int[] o2 = completerange.build(i2);
            cadena = string.Format("entrada: {0} salida: {1}", string.Join("|", i2), string.Join("|", o2));
            Console.Out.WriteLine(cadena);

            int[] i3 = { 55, 58, 60 };
            int[] o3 = completerange.build(i3);
            cadena = string.Format("entrada: {0} salida: {1}", string.Join("|", i3), string.Join("|", o3));

            
            Console.Out.WriteLine(cadena);
            Console.Out.WriteLine();

            //-----------------------------------------------------------------------

            Console.Out.WriteLine("Problema 2");
            Console.Out.WriteLine("=================");

            ChangeString changestring = new ChangeString();

            string in_ = "123 abñÑcd*3";
            string out_ = changestring.build(in_);
            cadena = string.Format("entrada: {0} salida: {1}", in_, out_);
            Console.Out.WriteLine(cadena);

            in_ = "**Casa 52";
            out_ = changestring.build(in_);
            cadena = string.Format("entrada: {0} salida: {1}", in_, out_);
            Console.Out.WriteLine(cadena);

            in_ = "123 abñÑcd*3";
            out_ = changestring.build(in_);
            cadena = string.Format("entrada: {0} salida: {1}", in_, out_);
            Console.Out.WriteLine(cadena);
            Console.Out.WriteLine();

            //----------------------------------------------------------------------
            Console.Out.WriteLine("Problema 3");
            Console.Out.WriteLine("=================");
            ClearPar clearpar = new ClearPar();

            string entrada = "()())()";
            string salida = clearpar.build(entrada);
            cadena = string.Format("entrada: {0} salida: {1}", entrada, salida);
            Console.Out.WriteLine(cadena);

            entrada = "()(()";
            salida = clearpar.build(entrada);
            cadena = string.Format("entrada: {0} salida: {1}", entrada, salida);
            Console.Out.WriteLine(cadena);

            entrada = ")(";
            salida = clearpar.build(entrada);
            cadena = string.Format("entrada: {0} salida: {1}", entrada, salida);
            Console.Out.WriteLine(cadena);

            entrada = "((()";
            salida = clearpar.build(entrada);
            cadena = string.Format("entrada: {0} salida: {1}", entrada, salida);
            Console.Out.WriteLine(cadena);            


            Console.In.ReadLine();

        }
    }
}
