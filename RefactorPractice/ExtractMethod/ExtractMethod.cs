using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.ExtractMethod
{
    internal class ExtractMethod
    {
        private void PrintBanner()
        {
            Console.WriteLine("**************************");
            Console.WriteLine("***** Customer Owes  *****");
            Console.WriteLine("**************************");
        }

        private void PrintOwing()
        {
            // print banner
            PrintBanner();
            double outstanding = GetOutStanding();

            // print detail
            PrintDetail(outstanding);
        }

        private double GetOutStanding()
        {
            var list = new List<double>();
            double result = 0.0;
            foreach (var argument in list)
            {
                result += argument;
            }

            return result;
        }

        private void PrintDetail(double outstanding)
        {
            Console.WriteLine("name:Customer");
            Console.WriteLine("amount:" + outstanding);
        }
    }
}