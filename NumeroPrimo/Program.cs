using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroPrimo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os numeros para serem analisados:");

            Console.ReadLine().Split(',')
                .Select(x => int.Parse(x)).ToArray()
                .ToList()
                .ForEach
                     (numero =>
                     {
                         for (int i = 2; i <= numero; i++)
                         {
                             if (numero % i == 0)
                             {
                                 if (numero == i)
                                     Console.WriteLine(numero);
                                 else
                                     break;
                             }

                         }
                     });

            Console.ReadKey();
        }
    }
}
