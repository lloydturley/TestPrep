using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPrep
{
    public class LeapYear
    {
        public string Calculate(int input)
        {
            string results = "";
            DateTime input2date;

            if (input < 100)
            {
                input2date = DateTime.Parse($"01/01/00{input}");
            }
            else
            {
                input2date = DateTime.Parse($"01/01/{input}");
            }

            //Console.WriteLine($"Display Leap Years from 0000 AD to {input2date.Year} AD");
            int start = 1;

            for (int i = start; i < input2date.Year; i++)
            {
                DateTime currentOne;
                if (i < 10)
                {
                    currentOne = DateTime.Parse($"01/01/000{i}");
                }
                else if (i < 100)
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
                    if (curY % 100 == 0 && curY % 400 != 0)
                    {
                        // if the year is divisible by 100 and not divisible by 400, leap year is skipped
                        //not a leap year per the rule
                    }
                    else
                    {
                        results += $"----{currentOne.Year}";
                        //Console.WriteLine($"----{currentOne.Year}");
                    }

                }
            }
            return results;
        }
    }
}
