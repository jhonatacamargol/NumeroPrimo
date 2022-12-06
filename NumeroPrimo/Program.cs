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
            int numero = 3, divivible = 0;
            Console.WriteLine("Digite um número máximo para imprimir os números primos!");
            int numero_final = int.Parse(Console.ReadLine());
            while (numero <= numero_final) 
            {
                for (int i = 1; i <= numero; i++)
                {
                    if (numero % i == 0)
                    {
                        divivible++;
                    }
                    if (divivible > 2)
                    {
                        break;
                    }
                }
                 if (divivible==2)
                 {
                            Console.Write("{0},",numero);
                 }
                 divivible = 0;
                numero++;
            }

            Console.ReadKey();
        }
    }
}
