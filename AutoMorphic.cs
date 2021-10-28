using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPrep
{
    public class AutoMorphic
    {
        public string Calculate(int input)
        {
            string results = "";
            //Console.WriteLine("Automorphic Evaluation");
            var calcdVal = input * input;

            string rightCharacter = calcdVal.ToString().Substring(calcdVal.ToString().Length - 1, 1);

            if (rightCharacter == input.ToString())
            {
                results = $"----{input} is an Automorphic Number";
                //Console.WriteLine($"----{input} is an Automorphic Number");
            }
            else
            {
                results = $"----{input} is Not an Automorphic Number";
                //Console.WriteLine($"----{input} is Not an Automorphic Number");
            }
            return results;
        }
    }
}
