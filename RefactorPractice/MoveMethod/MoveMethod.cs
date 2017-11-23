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

            public double OverDraftCharge()
            {
                if (_type.IsPremium())
                {
                    double result = 10;
                    if (_daysOverdrawn > 7)
                    {
                        result += (_daysOverdrawn - 7) * 0.85;
                    }
                    return result;
                }
                else
                {
                    return _daysOverdrawn * 1.75;
                }
            }

            public double BankCharge()
            {
                double result = 4.5;
                if (_daysOverdrawn > 0)
                {
                    result += this.OverDraftCharge();
                }
                return result;
            }
        }
    }

    internal class AccountType
    {
        public bool IsPremium()
        {
            return true;
        }
    }
}