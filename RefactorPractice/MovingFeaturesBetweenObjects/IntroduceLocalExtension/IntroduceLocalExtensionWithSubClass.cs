using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.MovingFeaturesBetweenObjects.IntroduceLocalExtension
{
    public class IntroduceLocalExtensionWithSubClass
    {
        public class MfDateSub
        {
            private static DateTime _dateTime;

            public MfDateSub(string dateString)
            {
                _dateTime = DateTime.Parse(dateString);
            }

            public static DateTime GetNextDay()
            {
                return new DateTime(_dateTime.Year, _dateTime.Month, _dateTime.Day + 1);
            }
        }
    }
}