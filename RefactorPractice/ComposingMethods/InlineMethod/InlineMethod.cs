using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RefactorPractice.ComposingMethods.InlineMethod
{
    public class InlineMethod
    {
        private int _moreThanFiveLateDeliveries = 0;

        public int GetRating()
        {
            return (this._moreThanFiveLateDeliveries > 5) ? 2 : 1;
        }
    }
}