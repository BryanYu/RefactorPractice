using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.MakingMethodCallsSimpler.EncapsulateDowncast
{
    public class EncapsulateDowncast
    {
        public class Reading
        {
            private List<Reading> _readings = new List<Reading>();

            public object LastReading()
            {
                return this._readings.LastOrDefault();
            }
        }
    }
}