using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPrep
{
    class Program
    {
        public readonly static string nL = Environment.NewLine;
        public readonly static string file = "C:/temp/TestPrepResults.txt";
        static void Main(string[] args)
        {
            int intInput;

            Console.WriteLine("Welcome to Test Prep");
            Console.WriteLine($"Results will be written to {file.Replace("/", "\\")}");
            if (File.Exists(file)) { File.Delete(file); }
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
                        File.AppendAllText(file, "Process is complete!" + nL);
                    }
                    else if (item.Length != 0)
                    {
                        Palindrome(item);
                        File.AppendAllText(file, "Process is complete!" + nL);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input" + nL);
                    }
                }

            }
        }

        private static void AbundantNumber(int input)
        {
            File.AppendAllText(file, "Abundant Number Evaluation" + nL);
            //Console.WriteLine("Abundant Number Evaluation");
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
                File.AppendAllText(file, $"----{input} is an Abundant Number" + nL);
                //Console.WriteLine($"----{input} is an Abundant Number");
            }
            else
            {
                File.AppendAllText(file, $"----{input} is Not Abundant Number" + nL);
                //Console.WriteLine($"----{input} is Not Abundant Number");
            }
        }
        static void StrongNumber(int input)
        {
            File.AppendAllText(file, "Strong Number Evaluation" + nL);
            //Console.WriteLine("Strong Number Evaluation");
            int finalCalcd = 0;
            char[] chars = input.ToString().ToCharArray();
            foreach (var chr in chars)
            {
                int calculated = 1;
                int digit = int.Parse(chr.ToString());
                int counter = 1;
                while (counter < digit + 1)
                {
                    calculated *= counter;
                    counter++;
                }
                finalCalcd += calculated;
            }

            if (input == finalCalcd)
            {
                File.AppendAllText(file, $"----{input} is a strong number" + nL);
                //Console.WriteLine($"----{input} is a strong number");
            }
            else
            {
                File.AppendAllText(file, $"----{input} is not strong number" + nL);
                //Console.WriteLine($"----{input} is not strong number");
            }
        }
        static void Palindrome(string input)
        {
            File.AppendAllText(file, "Palindrome Evaluation" + nL);
            //Console.WriteLine("Palindrome Evaluation");
            if (input == new string(input.ToCharArray().Reverse().ToArray()))
            {
                File.AppendAllText(file, $"{input} is a palindrome" + nL);
                //Console.WriteLine($"{input} is a palindrome");
            }
            int len = input.Length;

            string reversed = "";

            for (int i = len; i > 0; i--)
            {
                reversed = reversed + input.Substring(i - 1, 1);
            }
            if (input == reversed)
            {
                File.AppendAllText(file, $"----{input} is a palindrome #2" + nL);
                //Console.WriteLine($"----{input} is a palindrome #2");
            }
            else
            {
                File.AppendAllText(file, $"----{input} is not a palindrome" + nL);
                //Console.WriteLine($"----{input} is not a palindrome");
            }
        }

        static void OddEven(int max)
        {
            File.AppendAllText(file, $"Display Even Numbers from 0 to {max}" + nL);
            //Console.WriteLine($"Display Even Numbers from 0 to {max}");
            List<string> list = new List<string>();

            for (int i = 0; i < max; i++)
            {
                if (i % 2 == 0)
                {
                    list.Add(i.ToString());
                }
            }
            int count = 1;
            foreach (var item in list)
            {
                if (count != list.Count)
                {
                    File.AppendAllText(file, $"{item},");
                    //Console.Write($"{item},");
                }
                else
                {
                    File.AppendAllText(file, $"{item}" + nL);
                    //Console.WriteLine($"{item}");
                }
                count++;
            }
        }
        static void LeapYear(int input)
        {
            DateTime input2date;

            if (input < 100)
            {
                input2date = DateTime.Parse($"01/01/00{input}");
            }
            else
            {
                input2date = DateTime.Parse($"01/01/{input}");
            }

            File.AppendAllText(file, $"Display Leap Years from 0001 AD to {input2date.Year} AD" + nL);
            //Console.WriteLine($"Display Leap Years from 0000 AD to {input2date.Year} AD");
            int start = 1;

            for (int i = start; i < input2date.Year; i++)
            {
                DateTime currentOne;
                if (i < 10){
                    currentOne = DateTime.Parse($"01/01/000{i}");
                } else if (i < 100)
                {
                    currentOne = DateTime.Parse($"01/01/00{i}");
                }
                else 
                {
                    currentOne = DateTime.Parse($"01/01/{i}");
                }
                
                var curY = currentOne.Year;

                if (curY % 4 == 0)
                {
                    if(curY % 100 == 0 && curY % 400 != 0)
                    {
                        // if the year is divisible by 100 and not divisible by 400, leap year is skipped
                        //not a leap year per the rule
                    }
                    else
                    {
                        File.AppendAllText(file, $"----{currentOne.Year}" + nL);
                        //Console.WriteLine($"----{currentOne.Year}");
                    }

                }
            }
        }

        static void Automorphic(int input)
        {
            File.AppendAllText(file, "Automorphic Evaluation" + nL);
            //Console.WriteLine("Automorphic Evaluation");
            var calcdVal = input * input;

            string rightCharacter = calcdVal.ToString().Substring(calcdVal.ToString().Length - 1, 1);

            if (rightCharacter == input.ToString())
            {
                File.AppendAllText(file, $"----{input} is an Automorphic Number" + nL);
                //Console.WriteLine($"----{input} is an Automorphic Number");
            }
            else
            {
                File.AppendAllText(file, $"----{input} is Not an Automorphic Number" + nL);
                //Console.WriteLine($"----{input} is Not an Automorphic Number");
            }
        }

        static void PrimeNumbers(int max)
        {
            int x = 2;
            File.AppendAllText(file, $"Prime Number Evaluation. Will print all the prime numbers between {x} and {max}" + nL);
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
                    File.AppendAllText(file, $"----{x} is a prime" + nL);
                    //Console.WriteLine($"----{x} is a prime");
                }
                x++;
            }
        }
    }
}
