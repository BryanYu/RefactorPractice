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
        public void Sample()
        {
            //Employee kent = Employee.Create(Employee.ENGINEER);
            Employee kent = Employee.CreateEngineer();
        }

        public class Employee
        {
            public const int ENGINEER = 0;

            public const int SALESMAN = 1;

            public const int MANAGER = 2;

            public static Employee CreateEngineer()
            {
                return new Engineer();
            }

            public static Employee CreateSalesMan()
            {
                return new SalesMan();
            }

            public static Employee CreateManager()
            {
                return new Manager();
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