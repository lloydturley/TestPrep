using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPrep
{
    public class PrimeNumbers : IPrimeNumbers
    {
        public string Calculate(int max)
        {
            string results = "";
            int x = 2;

            //Console.WriteLine($"Prime Number Evaluation. Will print all the prime numbers between {x} and {max}");

            while (x < max + 1)
            {
                int count = 1;
                for (int i = 2; i < x; i++)
                {
                    if (x % i == 0)
                    {
                        count++;
                    }
                }
                if (count < 2)
                {
                    results += $"----{x} is a prime";
                    //Console.WriteLine($"----{x} is a prime");
                }
                x++;
            }
            return results;
        }
    }
}
