using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat_de_vanzari
{
    class Program
    {
        static void Main(string[] args)
        {
            // Scrieti un program C# de consola care sa modeleze functionarea acestui automat.
            // Precizari:
            // - Marfa se elibereaza cand in aparat sunt cel putin 20 centi (20 de centi fiind pretul produsului).
            // - Dupa eliberarea produsului se va da si rest (in cazul in care in automat sunt mai mult de 20 centi).

            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Pentru a primi produsul introduceti 20 centi in monede de 5,10,20 sau 50 centi");
            Console.WriteLine("------------------------------------------------------------------------------");

            int c, sum = 0, r;

            do
            {
                c = int.Parse(Console.ReadLine());

                if (c == 5)
                {
                    sum = sum + c;
                    Console.WriteLine($"In automat sunt {sum} centi");
                }
                if (c == 10)
                {
                    sum = sum + c;
                    Console.WriteLine($"In automat sunt {sum} centi");
                }
                if (c == 20)
                {
                    sum = sum + c;
                    Console.WriteLine($"In automat sunt {sum} centi");
                }
                if (c == 50)
                {
                    sum = sum + c;
                    Console.WriteLine($"In automat sunt {sum} centi");
                }
            } while (sum < 20);

            if (sum == 20)
            {
                Console.WriteLine();
                Console.WriteLine("********************");
                Console.WriteLine("Puteti lua produsul!");
                Console.WriteLine("********************");
            }
            if (sum > 20)
            {
                r = sum - 20;
                Console.WriteLine();
                Console.WriteLine("***********************");
                Console.WriteLine($"Restul este de {r} centi");
                Console.WriteLine("Puteti lua produsul!");
                Console.WriteLine("***********************");
            }
        }
    }
}
