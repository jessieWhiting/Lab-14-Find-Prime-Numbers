using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_14_Find_Prime_Numbers
{
    internal class PrimeNumber
    {
        public string GetPrime(int n)
        {
           int a = 0;
           for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                return "{0} is a Prime Number";
            }
            else
            {
                return "Not a Prime Number";
            }
               

        }
    }
}
