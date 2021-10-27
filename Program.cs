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
            int intInput;

            Console.WriteLine("Welcome to Test Prep");
            while (true)
            {
                Console.WriteLine("Please enter a value");
                string input = Console.ReadLine();
                var typedArgs = input.Split(' ');
                foreach (var item in typedArgs)
                {
                    if (int.TryParse(item, out intInput))
                    {
                        AbundantNumber(intInput);
                        Automorphic(intInput);
                        PrimeNumbers(intInput);
                        LeapYear(intInput);
                        OddEven(intInput);
                        StrongNumber(intInput);
                    }
                    else if (item.Length != 0)
                    {
                        Palindrome(item);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }
            }
        }

        private static void AbundantNumber(int input)
        {
            Console.WriteLine("Abundant Number Evaluation");
            int sum = 0;
            int iterationCount = 0;
            while (++iterationCount < input)
            {
                if (input % iterationCount == 0)
                {
                    sum += iterationCount;
                    if (sum > input) { break; }
                }
            }
            if (sum > input)
            {
                Console.WriteLine($"----{input} is an Abundant Number");
            } else
            {
                Console.WriteLine($"----{input} is Not Abundant Number");
            }
        }
        static void StrongNumber(int input)
        {
            Console.WriteLine("Strong Number Evaluation");
            int finalCalcd = 0;
            char[] chars = input.ToString().ToCharArray();
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

            if (input == finalCalcd)
            {
                Console.WriteLine($"----{input} is a strong number");
            } else
            {
                Console.WriteLine($"----{input} is not strong number");
            }
        }
        static void Palindrome(string input)
        {
            Console.WriteLine("Palindrome Evaluation");
            if (input == new string(input.ToCharArray().Reverse().ToArray()))
            {
                Console.WriteLine($"{input} is a palindrome");
            }
            int len = input.Length;
                
            string reversed = "";

            for (int i = len; i > 0; i--)
            {
                reversed = reversed + input.Substring(i-1, 1);
            }
            if (input == reversed)
            {
                Console.WriteLine($"----{input} is a palindrome #2");
            } else
            {
                Console.WriteLine($"----{input} is not a palindrome");
            }

        }
        
        static void OddEven(int max)
        {
            Console.WriteLine($"Display Even Numbers from 0 to {max}");
            List<string> list = new List<string>();
            
            for (int i = 0; i < max; i++)
            {
                if (i % 2 == 0)
                {
                    list.Add(i.ToString());
                }
            }
            int count=-1;
            foreach (var item in list)
            {
                if (++count!=list.Count)
                {
                    Console.Write($"----{item},");
                } else
                {
                    Console.Write($"----{item}");
                }
            }
        }
        static void LeapYear(int input)
        {
            DateTime input2date = DateTime.Parse($"01/01/{input}");
            
            Console.WriteLine($"Display Leap Years from 0000 AD to {input2date.Year} AD");
            int start = 0;

            for (int i = start; i < input2date.Year; i++)
            {
                DateTime currentOne = DateTime.Parse($"01/01/{i}");
                var curY = currentOne.Year;

                if (curY % 4 == 0)
                {
                    Console.WriteLine($"----{currentOne.Year}");
                }
            }
        }

        static void Automorphic(int input)
        {
            Console.WriteLine("Automorphic Evaluation");
            var calcdVal = input * input;

            string rightCharacter = calcdVal.ToString().Substring(calcdVal.ToString().Length-1,1);

            if (rightCharacter == input.ToString())
            {
                Console.WriteLine($"----{input} is an Automorphic Number");
            } else
            {
                Console.WriteLine($"----{input} is Not an Automorphic Number");
            }
        }

        static void PrimeNumbers(int max)
        {
            int x = 2;
            Console.WriteLine($"Prime Number Evaluation. Will print all the prime numbers between {x} and {max}");

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
                    Console.WriteLine($"----{x} is a prime");
                }
                x++;
            }
        }
    }
}
