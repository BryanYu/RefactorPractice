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

        public void Withdraw(int amount)
        {
            if (amount > _balance)
            {
                throw new Exception("錯誤");
            }
            this._balance -= amount;
        }
    }
}