using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RefactorPractice.ComposingMethods.InlineTemp
{
    public class InlineTemp
    {
        public bool Sample()
        {
            return (this.GetBasePrice() > 1000);
        }

        public double GetBasePrice()
        {
            return double.MaxValue;
        }
    }
}