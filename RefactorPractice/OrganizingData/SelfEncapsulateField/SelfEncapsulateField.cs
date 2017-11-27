using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.OrganizingData.SelfEncapsulateField
{
    public class SelfEncapsulateField
    {
        public class IntRange
        {
            private int _low;

            private int _high;

            public IntRange(int low, int high)
            {
                this._low = low;
                this._high = high;
            }

            public bool Includes(int arg)
            {
                return arg >= this._low && arg <= this._high;
            }

            public void Grow(int factor)
            {
                this._high = this._high * factor;
            }
        }
    }
}