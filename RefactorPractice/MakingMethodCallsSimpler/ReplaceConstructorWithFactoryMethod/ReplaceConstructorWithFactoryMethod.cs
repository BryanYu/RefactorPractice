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

    public class ReplaceConstructorWithFactoryMethodByString
    {
        public class Employee
        {
            private int _type;

            public const int ENGINEER = 0;
            public const int SALESMAN = 1;
            public const int MANAGER = 2;

            public static Employee Create(int type)
            {
                switch (type)
                {
                    case ENGINEER:
                        return new Engineer();

                    case SALESMAN:
                        return new SalesMan();

                    case MANAGER:
                        return new Manager();

                    default: throw new ArgumentException("Incorrect type code value");
                }
            }
        }

        public class SalesMan : Employee
        {
        }

        public class Manager : Employee
        {
        }

        public class Engineer : Employee
        {
        }
    }
}