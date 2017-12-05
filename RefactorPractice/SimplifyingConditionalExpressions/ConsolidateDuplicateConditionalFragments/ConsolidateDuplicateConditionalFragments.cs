using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.SimplifyingConditionalExpressions.ConsolidateDuplicateConditionalFragments
{
    internal class ConsolidateDuplicateConditionalFragments
    {
        public void Sample()
        {
            var total = 0.0D;
            var price = 0.0D;
            if (IsSpecialDeal())
            {
                total = price * 0.95;
            }
            else
            {
                total = price * 0.98;
            }
            Send();
        }

        private bool IsSpecialDeal()
        {
            throw new NotImplementedException();
        }

        private void Send()
        {
            throw new NotImplementedException();
        }
    }
}