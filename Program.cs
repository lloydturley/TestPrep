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
        public readonly static string file = "c:/temp/TestPrepResults.txt";
        static void Main(string[] args)
        {
            dependencyInj();

        }
        static private void dependencyInj()
        {
            IAbundantNumber aNum = new AbundantNumber();
            IAutoMorphic autoM = new AutoMorphic();
            IPrimeNumbers primeNum = new PrimeNumbers();
            ILeapYear leapY = new LeapYear();
            IOddEven oE = new OddEven();
            IStrongNumber strongNum = new StrongNumber();
            IPalindrome pal = new Palindrome();
            IReverseString reverse = new ReverseString();
            IRemoveSpecialCharacters removeSp = new RemoveSpecialCharacters();

            Orchestrator orchestrator = new Orchestrator(
                aNum,autoM, leapY, oE, pal, primeNum, removeSp, reverse, strongNum,  _writer
                );
            orchestrator.Orchestrate(file);
        }

        
    }
}
