using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expansiune_Cantor
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Gasiti expansiunea Cantor pentru numerele 2, 7, 19, 87, 1000, 1000000.

            int[] a = new int[] { 2, 7, 19, 87, 1000, 1000000 };

            Console.WriteLine("Expansiunea Cantor pentru numerele 2, 7, 19, 87, 1000, 1000000 este:");
            for (int i = 0; i < a.Length; i++)
            {
                ECantor1(a[i]);
            }
            Console.WriteLine();

            // 2. Scrieti o functie care determina expansiunea Cantor a unui numar. Numarul va fi input pentru functie.

            int n;
            Console.WriteLine("Introduceti numarul pe care vreti sa il convertiti in expansiune Cantor");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Numarul in expansiune Cantor este:");
            ECantor2(n);
            Console.WriteLine();
        }

        private static void ECantor2(int n)
        {
            int y = n, x = 1;
            List<int> co = new List<int>();

            do
            {
                n = y % (x + 1);
                co.Add(n);
                y = (y - n) / (x + 1);
                x = x + 1;
            } while (y != 0);
            for (int i = co.Count - 1; i >= 1; i--)
            {
                Console.Write($"{co[i]} * {i + 1}! + ");
            }
            Console.Write($"{co[0]} * {1}!");
            Console.WriteLine();
        }

        private static void ECantor1(int a)
        {
            int y = a, n = 1;
            List<int> co = new List<int>();

            do
            {
                a = y % (n + 1);
                co.Add(a);
                y = (y - a) / (n + 1);
                n = n + 1;
            } while (y != 0);
            for (int i = co.Count - 1; i >= 1 ; i--)
            {
                Console.Write($"{co[i]} * {i + 1}! + ");
            }
            Console.Write($"{co[0]} * {1}!");
            Console.WriteLine();
        }
    }
}
