using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.SimplifyingConditionalExpressions.DecomposeConditional
{
    internal class DecomposeConditional
    {
        private double _winterRate;

        private double _winterServiceCharge;

        private double _summerRate;

        public void Sample()
        {
            double charge = 0.0D;
            double quantity = 0.0D;

            if (NotSummer(DateTime.Now))
            {
                charge = SummerCharge(quantity);
            }
            else
            {
                charge = WinterCharge(quantity);
            }
        }

        private double WinterCharge(double quantity)
        {
            return quantity * _summerRate;
        }

        private double SummerCharge(double quantity)
        {
            return quantity * _winterRate + _winterServiceCharge;
        }

        private static bool NotSummer(DateTime now)
        {
            DateTime SUMMER_START = new DateTime();
            DateTime SUMMER_END = new DateTime();
            return now <= SUMMER_START || now >= SUMMER_END;
        }
    }
}