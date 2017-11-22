using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.IntroduceExplainingVarible
{
    public class IntroduceExplainingVarible
    {
        private double _quantity = 0;

        private double _itemPrice = 0;

        public double GetPrice()
        {
            return this._quantity * this._itemPrice - Math.Max(0, this._quantity - 500) * this._itemPrice * 0.05
                   + Math.Min(this._quantity * this._itemPrice * 0.1, 100);
        }
    }
}