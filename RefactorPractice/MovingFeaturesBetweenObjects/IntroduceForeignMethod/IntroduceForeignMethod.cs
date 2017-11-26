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
            DateTime previousEnd = new DateTime();
            DateTime newStart = new DateTime(previousEnd.Year, previousEnd.Month, previousEnd.Day + 1);
        }
    }
}