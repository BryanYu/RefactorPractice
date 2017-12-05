using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.OrganizingData.ReplaceTypeCodeWithStateOrStrategy
{
    public class ReplaceTypeCodeWithStateOrStrategy
    {
        public class Employee
        {
            private int _type;

            private int _monthlySalary;

            private int _commission;

            private int _bonus;

            private const int ENGINEER = 0;

            private const int SALESMAN = 1;

            private const int MANAGER = 2;

            public Employee(int type)
            {
                this._type = type;
            }

            private int PayAmount()
            {
                switch (this._type)
                {
                    case ENGINEER: return _monthlySalary;
                    case SALESMAN: return _monthlySalary * _commission;
                    case MANAGER: return _monthlySalary * _bonus;
                    default:
                        throw new ArgumentException();
                }
            }
        }
    }
}