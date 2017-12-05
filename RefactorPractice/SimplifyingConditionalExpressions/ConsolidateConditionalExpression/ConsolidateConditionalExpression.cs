using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.SimplifyingConditionalExpressions.ConsolidateConditionalExpression
{
    internal class ConsolidateConditionalExpression
    {
        public class LogicOR
        {
            private int _seniority;

            private int _monthsDisabled;

            private bool _isPartTime;

            private double DisabilityAmount()
            {
                if (IsNotEligibleForDisability())
                {
                    return 0;
                }

                return 1;
            }

            private bool IsNotEligibleForDisability()
            {
                return _seniority < 2 || _monthsDisabled > 12 || _isPartTime;
            }
        }

        public class LogicANDs
        {
            public double Sample()
            {
                return this.OnVacation() && this.LengthOfService() > 10 ? 1 : 0.5;
            }

            private int LengthOfService()
            {
                throw new NotImplementedException();
            }

            private bool OnVacation()
            {
                throw new NotImplementedException();
            }
        }
    }
}