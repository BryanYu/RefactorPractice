using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

            public static Employee Create(string name)
            {
                var result = Assembly.GetExecutingAssembly();
                return result.CreateInstance(name) as Employee;
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

    public class ReplaceConstructorWithFactoryMethodByExplicitMethod
    {
        public void Sample()
        {
            Person person = Person.CreateFemale();
            Person person2 = Person.CreateMale();
        }

        public class Person
        {
            public static Person CreateMale()
            {
                return new Male();
            }

            public static Person CreateFemale()
            {
                return new Female();
            }
        }

        public class Male : Person
        {
        }

        public class Female : Person
        {
        }
    }
}