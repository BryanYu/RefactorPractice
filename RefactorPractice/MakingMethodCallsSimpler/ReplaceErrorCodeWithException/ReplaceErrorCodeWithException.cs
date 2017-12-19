using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.MakingMethodCallsSimpler.ReplaceErrorCodeWithException
{
    public class ReplaceErrorCodeWithException
    {
        private int _balance;

        public int Withdraw(int amount)
        {
            if (amount > _balance)
            {
                return -1;
            }
            this._balance -= amount;
            return 0;
        }
    }
}