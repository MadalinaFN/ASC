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

            Console.WriteLine("Conversie dintr-o baza intr-o alta baza tinta");

            string base2 = "10101";
            string base8 = "10101";
            string base10 = "10101";
            string base16 = "10101";

            Console.WriteLine("Conversie din baza 2 in alta baza");
            Console.WriteLine("Convert.ToInt32(base2, 2) = " + Convert.ToInt32(base2, 2));
            Console.WriteLine("Convert.ToInt32(base2, 8) = " + Convert.ToInt32(base2, 8));
            Console.WriteLine("Convert.ToInt32(base2, 10) = " + Convert.ToInt32(base2, 10));
            Console.WriteLine("Convert.ToInt32(base2, 16) = " + Convert.ToInt32(base2, 16));

            Console.WriteLine("Conversie din baza 8 in alta baza");
            Console.WriteLine("Convert.ToInt32(base8, 2) = " + Convert.ToInt32(base8, 2));
            Console.WriteLine("Convert.ToInt32(base8, 8) = " + Convert.ToInt32(base8, 8));
            Console.WriteLine("Convert.ToInt32(base8, 10) = " + Convert.ToInt32(base8, 10));
            Console.WriteLine("Convert.ToInt32(base8, 16) = " + Convert.ToInt32(base8, 16));

            Console.WriteLine("Conversie din baza 10 in alta baza");
            Console.WriteLine("Convert.ToInt32(base10, 2) = " + Convert.ToInt32(base10, 2));
            Console.WriteLine("Convert.ToInt32(base10, 8) = " + Convert.ToInt32(base10, 8));
            Console.WriteLine("Convert.ToInt32(base10, 10) = " + Convert.ToInt32(base10, 10));
            Console.WriteLine("Convert.ToInt32(base10, 16) = " + Convert.ToInt32(base10, 16));

            Console.WriteLine("Conversie din baza 16 in alta baza");
            Console.WriteLine("Convert.ToInt32(base16, 2) = " + Convert.ToInt32(base16, 2));
            Console.WriteLine("Convert.ToInt32(base16, 8) = " + Convert.ToInt32(base16, 8));
            Console.WriteLine("Convert.ToInt32(base16, 10) = " + Convert.ToInt32(base16, 10));
            Console.WriteLine("Convert.ToInt32(base16, 16) = " + Convert.ToInt32(base16, 16));



        }
    }
}
