using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.MoveField
{
    public class MoveField
    {
        public class Account
        {
            public AccountType _type;

            public double InterestForAmonuntDays(double amount, int days)
            {
                return this._type.InterestRate * amount * days / 365;
            }
        }

        public class AccountType
        {
            public double InterestRate { get; set; }
        }
    }
}