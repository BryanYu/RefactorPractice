using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.MoveMethod
{
    public class MoveMethod
    {
        public class Account
        {
            private AccountType _type;

            private int _daysOverdrawn;

            public double BankCharge()
            {
                double result = 4.5;
                if (_daysOverdrawn > 0)
                {
                    result += this._type.OverDraftCharge(this);
                }
                return result;
            }

            public int GetDaysOverdrawn()
            {
                return this._daysOverdrawn;
            }
        }

        public class AccountType
        {
            public bool IsPremium()
            {
                return true;
            }

            public double OverDraftCharge(Account account)
            {
                if (IsPremium())
                {
                    double result = 10;
                    if (account.GetDaysOverdrawn() > 7)
                    {
                        result += (account.GetDaysOverdrawn() - 7) * 0.85;
                    }
                    return result;
                }
                else
                {
                    return account.GetDaysOverdrawn() * 1.75;
                }
            }
        }
    }
}