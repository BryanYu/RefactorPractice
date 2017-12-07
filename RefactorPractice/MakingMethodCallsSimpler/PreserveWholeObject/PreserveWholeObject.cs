using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.MakingMethodCallsSimpler.PreserveWholeObject
{
    internal class PreserveWholeObject
    {
        public class Room
        {
            public bool WithinPlan(HeatingPlan plan)
            {
                int low = DaysTempRange().Low;
                int high = DaysTempRange().High;
                return plan.WithinRange(low, high);
            }

            private TempRange DaysTempRange()
            {
                return new TempRange();
            }
        }

        public class HeatingPlan
        {
            private TempRange _range;

            public bool WithinRange(int low, int high)
            {
                return (low > _range.Low && high <= _range.High);
            }
        }

        public class TempRange
        {
            public int Low { get; set; }

            public int High { get; set; }
        }
    }
}