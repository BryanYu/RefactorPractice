using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.InlineTemp
{
    public class InlineTemp
    {
        public bool Sample()
        {
            double basePrice = this.GetBasePrice();
            return (basePrice > 1000);
        }

        public double GetBasePrice()
        {
            return double.MaxValue;
        }
    }
}