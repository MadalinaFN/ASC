using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Moore_s_Law
{
    class Program
    {
        static void Main(string[] args)
        {
            //Legea lui Moore spune ca puterea de calcul se dubleaza la fiecare 18 luni, iar pretul ramane acelasi.
            //Dupa cat timp vom avea o putere de calcul de 100 de ori mai mare fata de cat avem la un moment dat, la acelasi pret?
            //Dupa cat timp vom avea o putere de calcul de n ori mai mare, la acelasi pret?

            double x = 100;
            double y = Math.Log(x, 2.0)*18;
            double n = y / 12;
            Console.WriteLine($"Peste {n} ani vom avea o putere de calcul de 100 de ori mai mare la acelasi pret");

        }
    }
}
