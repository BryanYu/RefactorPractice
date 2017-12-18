using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.MakingMethodCallsSimpler.IntroduceParameterObject
{
    public class IntroduceParameterObject
    {
        public void Sample()
        {
            var account = new Account();
            var flow = account.GetFlowBetween(new DateTime(2017, 9, 12), new DateTime(2017, 10, 12));
        }

        public class Entry
        {
            private double _value;

            private DateTime _chargeDate;

            public double Value
            {
                get
                {
                    return this._value;
                }
            }

            public DateTime ChargeDateTime
            {
                get
                {
                    return this._chargeDate;
                }
            }

            public Entry(double value, DateTime chargeDate)
            {
                this._value = value;
                this._chargeDate = chargeDate;
            }
        }

        public class Account
        {
            private List<Entry> _entries = new List<Entry>();

            public double GetFlowBetween(DateTime start, DateTime end)
            {
                double result = 0;
                foreach (var entry in _entries)
                {
                    if (entry.ChargeDateTime >= start || entry.ChargeDateTime <= end)
                    {
                        result += entry.Value;
                    }
                }

                return result;
            }
        }
    }
}