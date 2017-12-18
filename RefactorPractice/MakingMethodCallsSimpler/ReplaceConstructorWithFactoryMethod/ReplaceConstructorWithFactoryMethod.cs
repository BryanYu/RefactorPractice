using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.MakingMethodCallsSimpler.ReplaceConstructorWithFactoryMethod
{
    public class ReplaceConstructorWithFactoryMethodByTypeCode
    {
        public void Sample()
        {
            var employee = Employee.Create(Employee.ENGINEER);
        }

        public class Employee
        {
            private int _type;

            public const int ENGINEER = 0;
            public const int SALESMAN = 1;
            public const int MANAGER = 2;

            private Employee(int type)
            {
                this._type = type;
            }

            public static Employee Create(int type)
            {
                return new Employee(type);
            }
        }
    }
}