using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.ExtractMethod
{
    internal class ExtractMethodWithOutLocalVariable
    {
        private static void PrintBanner()
        {
            Console.WriteLine("**************************");
            Console.WriteLine("***** Customer Owes  *****");
            Console.WriteLine("**************************");
        }

        private void PrintOwing()
        {
            var list = new List<double>();
            double outstanding = 0.0;

            // print banner
            PrintBanner();

            foreach (var argument in list)
            {
                outstanding += argument;
            }

            // print detail
            Console.WriteLine("name:Customer");
            Console.WriteLine("amount:" + outstanding);
        }
    }
}