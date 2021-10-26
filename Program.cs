using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            Armstrong();
            //PrimeNumbers(1000);
            //LeapYear();
            OddEven(100);
            //Palindrome(args);
            StrongNumber(args);
            Console.ReadLine();
            
        }
        static void StrongNumber(string[] input)
        {
            foreach (var item in input)
            {
                int finalCalcd = 0;
                char[] chars = item.ToCharArray();
                foreach (var chr in chars)
                {
                    int calculated = 1;
                    int digit = int.Parse(chr.ToString());
                    int counter = 1;
                    while(counter < digit + 1)
                    {
                        calculated *= counter;
                        counter++;
                    }
                    finalCalcd += calculated;
                }

                if (item == finalCalcd.ToString())
                {
                    Console.WriteLine("You have a strong number");
                } else
                {
                    Console.WriteLine($"You do not have a strong #. Calcd:  {finalCalcd}");
                }
            }
        }
        static void Palindrome(string[] input)
        {
            var words = input.ToList();
            foreach (var word in words)
            {
                if (word == new string(word.ToCharArray().Reverse().ToArray()))
                {
                    Console.WriteLine($"{word} is a palindrome");
                }
                int len = word.Length;
                
                string reversed = "";

                for (int i = len; i > 0; i--)
                {
                    reversed = reversed + word.Substring(i-1, 1);
                }
                if (word == reversed)
                {
                    Console.WriteLine($"{word} is a palindrome #2");
                } else
                {
                    Console.WriteLine($"{word} is not a palindrome");
                }

            }
        }
        static void OddEven(int max)
        {
            List<string> list = new List<string>();
            
            for (int i = 0; i < max; i++)
            {
                if (i % 2 == 0)
                {
                    //Console.WriteLine($"{i} is even");
                    list.Add(i.ToString());
                    
                } else
                {
                    //Console.WriteLine($"{i} is odd");
                }
            }
            foreach (var item in list)
            {
                Console.Write($"{item},");
            }
        }
        static void LeapYear()
        {
            int start = 0;
            int end = 2030;

            for (int i = start; i < end; i++)
            {
                DateTime currentOne = DateTime.Parse($"01/01/{i}");
                var curY = currentOne.Year;

                if (curY % 4 == 0)
                {
                    Console.WriteLine($"{currentOne.Year}");
                }
            }
        }

        static void Armstrong()
        {
            Console.WriteLine("Inside Armstrong");
        }

        static void PrimeNumbers(int max)
        {
            int x = 2;
            Console.WriteLine($"Inside Prime Number. Will print all the prime numbers between {x} and {max}");

            while(x < max + 1)
            {
                int count = 1;
                for (int i = 2; i < x; i++)
                {
                    if (x % i == 0)
                    {
                        count++;
                    }
                }
                if (count < 2) {
                    Console.WriteLine($"{x} is a prime");
                }
                x++;
            }
        }
    }
}
