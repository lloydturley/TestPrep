using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPrep
{
    public class Palindrome : IPalindrome
    {
        public string Calculate(string input)
        {
            string results = "";

            //Console.WriteLine("Palindrome Evaluation");
            if (input == new string(input.ToCharArray().Reverse().ToArray()))
            {
                results += $"{input} is a palindrome";
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
                results += $"----{input} is a palindrome #2";
                //Console.WriteLine($"----{input} is a palindrome #2");
            }
            else
            {
                results += $"----{input} is not a palindrome";
                //Console.WriteLine($"----{input} is not a palindrome");
            }
            return results;
        }
    }
}
