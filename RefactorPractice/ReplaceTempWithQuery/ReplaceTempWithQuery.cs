using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.ReplaceTempWithQuery
{
    public class ReplaceTempWithQuery
    {
        private double _quantity;

        private double _itemPrice;

        public double Sample()
        {
            double basePrice = this._quantity * this._itemPrice;
            if (basePrice > 1000)
            {
                return basePrice * 0.95;
            }
            else
            {
                return basePrice * 0.98;
            }
        }
    }
}