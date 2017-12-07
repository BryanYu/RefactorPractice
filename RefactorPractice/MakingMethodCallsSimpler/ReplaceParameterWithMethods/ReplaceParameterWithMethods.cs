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
            return DiscountedPrice();
        }

        private int GetBasePrice()
        {
            return _quantity * _itemPrice;
        }

        private int GetDiscountLevel()
        {
            int discountLevel;
            if (_quantity > 100)
            {
                discountLevel = 2;
            }
            else
            {
                discountLevel = 1;
            }

            return discountLevel;
        }

        private double DiscountedPrice()
        {
            if (GetDiscountLevel() == 2)
            {
                return this.GetBasePrice() * 0.1;
            }
            else
            {
                return this.GetBasePrice() * 0.05;
            }
        }
    }
}