using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPrep
{
    public class Orchestrator
    {
        private readonly IAbundantNumber _abundant;
        private readonly IAutoMorphic _auto;
        private readonly ILeapYear _leap;
        private readonly IOddEven _oddEven;
        private readonly IPalindrome _palindrome;
        private readonly IPrimeNumbers _prime;
        private readonly IRemoveSpecialCharacters _remove;
        private readonly IReverseString _reverse;
        private readonly IStrongNumber _strong;
        private readonly IWriter _writer;
        public Orchestrator(
            IAbundantNumber abundant,
            IAutoMorphic autoMorphic,
            ILeapYear leapYear,
            IOddEven oddEven,
            IPalindrome palindrome,
            IPrimeNumbers primeNumbers,
            IRemoveSpecialCharacters removeSpecialCharacters,
            IReverseString reverseString,
            IStrongNumber strongNumber,
            IWriter writer            
            )
        {
            _abundant = abundant;
            _auto = autoMorphic;
            _leap = leapYear;
            _oddEven = oddEven;
            _palindrome = palindrome;
            _remove = removeSpecialCharacters;
            _reverse = reverseString;
            _strong = strongNumber;
            _writer = writer;
        }
        public void Orchestrate(string file)
        {
            try
            {
                int intInput;

                Console.WriteLine("Welcome to Test Prep");
                Console.WriteLine($"Results will be written to {file.Replace("/", "\\")}");
                if (File.Exists(file)) { File.Delete(file); }
                while (true)
                {
                    Console.WriteLine("Please enter a value");

                    string input = Console.ReadLine();
                    input = _remove.Remove(input);
                    var typedArgs = input.Trim().Split(' ');

                    foreach (var item in typedArgs)
                    {
                        _writer.Write(file, item);
                        if (int.TryParse(item, out intInput))
                        {
                            _writer.Write(file, "Abundant Number Evaluation");
                            _writer.Write(file, _abundant.Calculate(intInput));
                            _writer.Write(file, "Automorphic Evaluation");
                            _writer.Write(file, _auto.Calculate(intInput));
                            _writer.Write(file, $"Prime Number Evaluation. Will print all the prime numbers between 2 and {intInput}");
                            _writer.Write(file, _prime.Calculate(intInput));
                            _writer.Write(file, $"Display Leap Years from 0001 AD to {intInput} AD");
                            _writer.Write(file, _leap.Calculate(intInput));
                            _writer.Write(file, $"Display Even Numbers from 0 to {intInput}");
                            _writer.Write(file, _oddEven.Calculate(intInput));
                            _writer.Write(file, "Strong Number Evaluation");
                            _writer.Write(file, _strong.Calculate(intInput));
                            Console.WriteLine("Process is complete!");
                        }
                        else if (item.Length != 0)
                        {
                            //item.All(Char.IsLetter())
                            _writer.Write(file, "Palindrome Evaluation");
                            _writer.Write(file, _palindrome.Calculate(item));
                            _writer.Write(file, "Reverse String");
                            _writer.Write(file, _reverse.Reverse(item).ToString());
                            _writer.Write(file, "Remove Special Chars");
                            _writer.Write(file, _remove.Remove(item));
                            Console.WriteLine("Process is complete!");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
    
    

}
