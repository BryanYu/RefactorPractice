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
            if (GetBasePrice() > 1000)
            {
                return GetBasePrice() * 0.95;
            }
            else
            {
                return GetBasePrice() * 0.98;
            }
        }

        private double GetBasePrice()
        {
            return this._quantity * this._itemPrice;
        }
    }
}