using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Conversie
{
    class Program
    {
        static void Main(string[] args)
        {
            //Scrieti un program C# care converteste un numar din baza b1 in baza b2.
            //Numarul pe care il convertim va fi un numar reprezentat in virgula fixa.

            //***** Am vrut sa scriu acest program astfel incat sa converteasca orice numar din orice baza in orice baza dar, *****
            //***** fiind incepatoare, nu prea m-am descurcat si am reusit doar ceea ce este in continuare: *****

            int b1, b2, num;

            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("Introduceti numarul 2 pentru a face o conversie din baza 2 intr-o alta baza");
            Console.WriteLine("Introduceti numarul 4 pentru a face o conversie din baza 4 in baza 10");
            Console.WriteLine("Introduceti numarul 10 pentru a face o conversie din baza 10 intr-o alta baza");
            Console.WriteLine("Introduceti numarul 16 pentru a face o conversie din baza 16 in baza 10");
            Console.WriteLine("-----------------------------------------------------------------------------");
            b1 = int.Parse(Console.ReadLine());

            switch (b1)
            {
                case 2: //Converteste orice numar din baza doi in bazele 2,8,10,16
                    Console.WriteLine("Introduceti un numar in baza 2");
                    num = int.Parse(Console.ReadLine());

                    Console.WriteLine("Introduceti baza in care vreti sa convertiti numarul (2,8,10,16)");
                    b2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Numarul convertit este " + Convert.ToString(num, b2));
                    break;

                case 4: //Converteste orice numar de maxim 3 cifre din baza patru in baza 10
                    Console.WriteLine("Introduceti un numar de maxim 3 cifre in baza 4");
                    num = int.Parse(Console.ReadLine());

                    int m, s, z, u;
                    double numconvertit;

                    s = num / 100 % 10;
                    z = num / 10 % 10;
                    u = num % 10;

                    numconvertit = s * (Math.Pow(4, 2)) + z * 4 + u;

                    Console.WriteLine("Numarul convertit este {0}", numconvertit);
                    break;

                case 10: //Converteste orice numar din baza 10 in bazele 2,8,10,16
                    Console.WriteLine("Introduceti un numar in baza 10");
                    Int32 n = int.Parse(Console.ReadLine());

                    Console.WriteLine("Introduceti baza in care vreti sa convertiti numarul (2,8,10,16)");
                    b2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Numarul convertit este " + Convert.ToString(n, b2));
                    break;

                case 16: //Converteste orice numare de maxim 4 cifre din baza 16 in baza 10
                    Console.WriteLine("Introduceti un numar de maxim 4 cifre in baza 16");
                    num = int.Parse(Console.ReadLine());

                    m = num / 1000 % 10;
                    s = num / 100 % 10;
                    z = num / 10 % 10;
                    u = num % 10;

                    numconvertit = m * (Math.Pow(16, 3)) + s * (Math.Pow(16, 2)) + z * 16 + u;

                    Console.WriteLine("Numarul convertit este {0}", numconvertit);
                    break;

                default:
                    Console.WriteLine("Numarul introdus nu e corect");
                    break;
            }
        }
    }
}
