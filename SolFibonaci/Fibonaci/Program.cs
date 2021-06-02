using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonaci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj elemenata:");
            int brojElemenata = Convert.ToInt32(Console.ReadLine());

            Fibonaciiii.clsMath b= new Fibonaciiii.clsMath();

           long[] rezultat = b.GenFibonacci(brojElemenata);

            foreach(long a in rezultat)
            {
            Console.WriteLine(a);


            }

            
            Console.ReadKey();

            



        }
    }
}
