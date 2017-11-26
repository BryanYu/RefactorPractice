using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RefactorPractice.ComposingMethods.ExtractMethod
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
            this.PrintBanner();
            double outstanding = this.GetOutStanding();

            // print detail
            this.PrintDetail(outstanding);
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