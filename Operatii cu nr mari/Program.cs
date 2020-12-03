using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Program_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implementati operatii cu numere naturale mari. Adunare, scadere, inmultire, impartire, ridicare la putere, radacina patrata.

            BigInteger a = BigInteger.Parse("700000000000000000000000000000");
            BigInteger b = BigInteger.Parse("900000000000000000000000000000");

            int ca;

            Console.WriteLine("Introduceti 1 pentru a realiza o adunare, 2 pentru a realiza o scadere, 3 pentru a realiza o inmultire, " +
                "4 pentru a realiza o impartire, 5 pentru a realiza o ridicare la putere sau 6 pentru a realiza o radacina patrata");
            ca = int.Parse(Console.ReadLine());

            switch (ca)
            {
                case 1:
                    Console.WriteLine($"Adunarea numerelor este {a + b}");
                    break;
                case 2:
                    Console.WriteLine($"Scaderea numerelor este {a - b}");
                    break;
                case 3:
                    Console.WriteLine($"Inmultirea numerelor este {a * b}");
                    break;
                case 4:
                    Console.WriteLine($"Impartirea numerelor este {(a / b)},{(double)(a % b)}");
                    break;
                case 5:
                    BigInteger nr = BigInteger.Pow(UInt64.MaxValue, 7);
                    Console.WriteLine($"Rezultatul ridicarii la putere a numarului este {nr}");
                    break;
                case 6:
                    BigInteger nr2 = BigInteger.Pow(UInt64.MaxValue, 1/2); //Nu merge, nu stiu cum sa fac radacina patrata
                    Console.WriteLine($"Rezultatul radacinii patrate a numarului este {nr2}");
                    break;
                default:
                    Console.WriteLine("Numarul introdus nu e corect");
                    break;
            }
        }
    }
}
