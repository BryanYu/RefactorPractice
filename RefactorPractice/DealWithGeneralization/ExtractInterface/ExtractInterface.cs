using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.DealWithGeneralization.ExtractInterface
{
    public class ExtractInterface
    {
        public class Employee
        {
            private int _rate;

            public int Rate
            {
                get
                {
                    return this._rate;
                }
            }

            public bool HasSpecialSkill()
            {
                return true;
            }
        }

        public double Charge(Employee employee, int days)
        {
            int result = employee.Rate * days;
            if (employee.HasSpecialSkill())
            {
                return result * 1.05;
            }
            return result;
        }
    }
}