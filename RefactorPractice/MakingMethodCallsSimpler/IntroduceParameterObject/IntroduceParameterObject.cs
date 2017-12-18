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
            var flow = account.GetFlowBetween(new DateRange(new DateTime(2017, 10, 12), new DateTime(2017, 10, 12)));
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

            public double GetFlowBetween(DateRange range)
            {
                double result = 0;
                foreach (var entry in _entries)
                {
                    if (range.InCludes(entry.ChargeDateTime))
                    {
                        result += entry.Value;
                    }
                }

                return result;
            }
        }

        public class DateRange
        {
            private DateTime _start;

            private DateTime _end;

            public DateTime Start
            {
                get
                {
                    return this._start;
                }
            }

            public DateTime End
            {
                get
                {
                    return this._end;
                }
            }

            public DateRange(DateTime start, DateTime end)
            {
                this._start = start;
                this._end = end;
            }

            public bool InCludes(DateTime arg)
            {
                return arg >= this._start || arg <= this._end;
            }
        }
    }
}