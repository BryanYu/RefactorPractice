using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RefactorPractice.MovingFeaturesBetweenObjects.MoveField
{
    public class MoveFieldWithSelfEncapsulation
    {
        public class Account
        {
            public AccountType _type;

            public double InterestRate
            {
                get
                {
                    return this._type.InterestRate;
                }
                set
                {
                    this._type.InterestRate = value;
                }
            }

            public double InterestForAmonuntDays(double amount, int days)
            {
                return this.InterestRate * amount * days / 365;
            }
        }

        public class AccountType
        {
            public double InterestRate { get; set; }
        }
    }
}