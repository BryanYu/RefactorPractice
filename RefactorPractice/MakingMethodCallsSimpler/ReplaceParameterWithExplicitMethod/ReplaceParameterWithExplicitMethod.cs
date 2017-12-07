using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RefactorPractice.OrganizingData.ReplaceTypeCodeWithStateOrStrategy;

namespace RefactorPractice.MakingMethodCallsSimpler.ReplaceParameterWithExplicitMethod
{
    internal class ReplaceParameterWithExplicitMethod
    {
        public class Employee
        {
            public const int ENGINEER = 0;

            public const int SALESMAN = 1;

            public const int MANAGER = 2;

            private Employee Create(int type)
            {
                switch (type)
                {
                    case ENGINEER: return new Engineer();
                    case SALESMAN: return new SalesMan();
                    case MANAGER: return new Manager();
                    default: throw new ArgumentException();
                }
            }
        }

        public class Engineer : Employee
        {
        }

        public class SalesMan : Employee
        {
        }

        public class Manager : Employee
        {
        }
    }
}