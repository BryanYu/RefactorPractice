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
                return plan.WithinRange(this.DaysTempRange());
            }

            private TempRange DaysTempRange()
            {
                return new TempRange();
            }
        }

        public class HeatingPlan
        {
            public bool WithinRange(TempRange roomRange)
            {
                return (roomRange.Low > roomRange.Low && roomRange.High <= roomRange.High);
            }
        }

        public class TempRange
        {
            public int Low { get; set; }

            public int High { get; set; }
        }
    }
}