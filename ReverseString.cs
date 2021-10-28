using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPrep
{
    public class ReverseString
    {
        public string Reverse(string input)
        {
            //string results = "";

            //var results = input.Reverse().ToArray().ToString();
            var results = new string(input.ToCharArray().Reverse().ToArray());

            return results;
        }
    }
}
