using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RefactorPractice.ComposingMethods.ReplaceTempWithQuery
{
    public class ReplaceTempWithQuery
    {
        private double _quantity;

        private double _itemPrice;

        public double Sample()
        {
            if (this.GetBasePrice() > 1000)
            {
                return this.GetBasePrice() * 0.95;
            }
            else
            {
                return this.GetBasePrice() * 0.98;
            }
        }

        private double GetBasePrice()
        {
            return this._quantity * this._itemPrice;
        }
    }
}