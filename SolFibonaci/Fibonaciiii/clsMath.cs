using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonaciiii
{
    public class clsMath
    {
        public long[] GenFibonacci(int brojClanova)
        {

            long[] a = new long[brojClanova];
            a[0] = 0;
            a[1] = 1;


            for (int i = 2; i < brojClanova; i++)
            {

                a[i] = a[i - 2] + a[i - 1];


            }

            return a;

        }
    }
}
