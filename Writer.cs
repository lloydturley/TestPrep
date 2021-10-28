﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPrep
{
    public class Writer
    {
        public readonly static string nL = Environment.NewLine;

        public void Write(string outFile, string results)
        {
            try
            {
                File.AppendAllText(outFile, results + nL);
            }
            catch (Exception ex)
            {
                throw(ex);
            }
        }
    }

    
}