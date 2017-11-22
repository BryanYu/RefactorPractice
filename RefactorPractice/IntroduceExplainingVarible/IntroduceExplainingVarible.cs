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
            var basePrice = this._quantity * this._itemPrice;
            var quantityDiscount = Math.Max(0, this._quantity - 500) * this._itemPrice * 0.05;
            var shipping = Math.Min(basePrice * 0.1, 100);
            return basePrice - quantityDiscount + shipping;
        }
    }
}