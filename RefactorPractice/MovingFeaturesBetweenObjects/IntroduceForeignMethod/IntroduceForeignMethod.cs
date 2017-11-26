using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.MovingFeaturesBetweenObjects.IntroduceForeignMethod
{
    public class IntroduceForeignMethod
    {
        public void Sample()
        {
            DateTime previousEnd = DateTime.Now;
            var newStart = GetNextDay(previousEnd);
        }

        private static DateTime GetNextDay(DateTime previousEnd)
        {
            return new DateTime(previousEnd.Year, previousEnd.Month, previousEnd.Day + 1);
        }
    }
}