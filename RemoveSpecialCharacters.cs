using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPrep
{
    public class RemoveSpecialCharacters
    {
        public string Remove(string input)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char item in input)
            {
                if(
                    (item >= '0' && item <= '9') || 
                    (item >= 'A' && item <= 'Z') || 
                    (item >= 'a' && item <= 'z') ||
                    (item == ' ')
                    )
                {
                    sb.Append(item);
                }
            }

            return sb.ToString();

        }
    }
}
