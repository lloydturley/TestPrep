using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPrep
{
    public class AbundantNumber
    {
        public string Calculate(int input)
        {
            try
            {

                int sum = 0;
                int iterationCount = 0;
                string result;
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
                    result = $"----{input} is an Abundant Number";
                    //Console.WriteLine($"----{input} is an Abundant Number");
                }
                else
                {
                    result = $"----{input} is Not an Abundant Number";
                    //Console.WriteLine($"----{input} is Not Abundant Number");
                }
                return result;
            }
            catch (Exception)
            {
                throw;
            }
            
        }
    }
}
