using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.MoveField
{
    public class MoveFieldWithSelfEncapsulation
    {
        public class Account
        {
            public AccountType _type;

            private double _interestRate;

            public double InterestForAmonuntDays(double amount, int days)
            {
                return this._interestRate * amount * days / 365;
            }
        }

        public class AccountType
        {
            public double InterestRate { get; set; }
        }
    }
}