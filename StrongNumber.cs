using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPrep
{
    public class StrongNumber
    {
        public string Calculate(int input)
        {
            string results;
            
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
                results = $"----{input} is a strong number";
                //Console.WriteLine($"----{input} is a strong number");
            }
            else
            {
                results = $"----{input} is not strong number";
                //Console.WriteLine($"----{input} is not strong number");
            }
            return results;
        }
    }
}
