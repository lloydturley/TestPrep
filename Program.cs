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
        public readonly static Writer _writer = new Writer();
        public readonly static string file = "C:/temp/TestPrepResults.txt";
        static void Main(string[] args)
        {
            int intInput;
            AbundantNumber aNum = new AbundantNumber();
            AutoMorphic autoM = new AutoMorphic();
            PrimeNumbers primeNum = new PrimeNumbers();
            LeapYear leapY = new LeapYear();
            OddEven oE = new OddEven();
            StrongNumber strongNum = new StrongNumber();
            Palindrome pal = new Palindrome();
            ReverseString reverse = new ReverseString();

            Console.WriteLine("Welcome to Test Prep");
            Console.WriteLine($"Results will be written to {file.Replace("/", "\\")}");
            if (File.Exists(file)) { File.Delete(file); }
            while (true)
            {
                Console.WriteLine("Please enter a value");

                string input = Console.ReadLine();
                var typedArgs = input.Trim().Split(' ');

                foreach (var item in typedArgs)
                {
                    if (int.TryParse(item, out intInput))
                    {
                        _writer.Write(file, "Abundant Number Evaluation");
                        _writer.Write(file, aNum.Calculate(intInput));
                        _writer.Write(file, "Automorphic Evaluation");
                        _writer.Write(file, autoM.Calculate(intInput));
                        _writer.Write(file, $"Prime Number Evaluation. Will print all the prime numbers between 2 and {intInput}");
                        _writer.Write(file, primeNum.Calculate(intInput));
                        _writer.Write(file, $"Display Leap Years from 0001 AD to {intInput} AD");
                        _writer.Write(file, leapY.Calculate(intInput));
                        _writer.Write(file, $"Display Even Numbers from 0 to {intInput}");
                        _writer.Write(file, oE.Calculate(intInput));
                        _writer.Write(file, "Strong Number Evaluation");
                        _writer.Write(file, strongNum.Calculate(intInput));
                        Console.WriteLine("Process is complete!");
                    }
                    else if (item.Length != 0)
                    {
                        //item.All(Char.IsLetter())
                        _writer.Write(file, "Palindrome Evaluation");
                        _writer.Write(file, pal.Calculate(item));
                        _writer.Write(file, "Reverse String");
                        _writer.Write(file, reverse.Reverse(item).ToString());
                        Console.WriteLine("Process is complete!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }
            }
        }
    }
}
