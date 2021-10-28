using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPrep
{
    public class OddEven
    {
        public string Calculate(int max)
        {
            string results = "";
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
                    results += $"{item},";
                    //Console.Write($"{item},");
                }
                else
                {
                    results += $"{item}";
                    //Console.WriteLine($"{item}");
                }
                count++;
            }
            return results;
        }
    }
}
