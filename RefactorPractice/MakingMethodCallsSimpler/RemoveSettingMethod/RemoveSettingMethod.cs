using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.MakingMethodCallsSimpler.RemoveSettingMethod
{
    public class RemoveSettingMethod
    {
        public class Account
        {
            private string _id;

            public Account(string id)
            {
                this._id = id;
            }
        }
    }
}