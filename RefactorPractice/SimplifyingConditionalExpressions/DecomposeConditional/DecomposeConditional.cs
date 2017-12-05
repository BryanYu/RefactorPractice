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
            DateTime SUMMER_START = new DateTime();
            DateTime SUMMER_END = new DateTime();
            double charge = 0.0D;
            double quantity = 0.0D;

            if (DateTime.Now <= SUMMER_START || DateTime.Now >= SUMMER_END)
            {
                charge = quantity * _winterRate + _winterServiceCharge;
            }
            else
            {
                charge = quantity * _summerRate;
            }
        }
    }
}