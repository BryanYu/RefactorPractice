using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.InlineMethod
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