using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.MakingMethodCallsSimpler.ReplaceParameterWithMethods
{
    internal class ReplaceParameterWithMethods
    {
        private int _itemPrice;

        private int _quantity;

        public double GetPrice()
        {
            int basePrice = _quantity * _itemPrice;
            int discountLevel;
            if (_quantity > 100)
            {
                discountLevel = 2;
            }
            else
            {
                discountLevel = 1;
            }
            double finalPrice = DiscountedPrice(basePrice, discountLevel);
            return finalPrice;
        }

        private double DiscountedPrice(int basePrice, int discountLevel)
        {
            if (discountLevel == 2)
            {
                return basePrice * 0.1;
            }
            else
            {
                return basePrice * 0.05;
            }
        }
    }
}