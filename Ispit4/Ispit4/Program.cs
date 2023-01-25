using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4.
            //Napišite program koji će za definirani niz tipa double pronaći član koji najmanje odstupa od
            //prosječne vrijednosti niza. Program mora raditi ispravno za proizvoljni broj članova niza.

            double[] niz = { 1.2, 2.3, 4.1, 6.6 };
            double pros=0;
            double ods=0;

            for(int i = 0; i < niz.Length; i++)
            {
                pros= niz[i] + niz[i];
                ods = niz[i].CompareTo(pros);
            }
            pros=pros/niz.Length;
            Console.WriteLine("Prosjecna vrijednost je: "+pros);
            Console.WriteLine(ods);
            Console.ReadKey();
        }
    }
}
