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
            public int Low { get; set; }

            public int High { get; set; }

            public IntRange(int low, int high)
            {
                this.Low = low;
                this.High = high;
            }

            public bool Includes(int arg)
            {
                return arg >= this.Low && arg <= this.High;
            }

            public void Grow(int factor)
            {
                this.High = this.High * factor;
            }
        }

        public class CappedRange : IntRange
        {
            public int Cap;

            public int High { get { return Math.Min(base.High, this.Cap); } }

            public CappedRange(int low, int high, int cap) : base(low, high)
            {
                this.Cap = cap;
            }
        }
    }
}