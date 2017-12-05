using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.OrganizingData.ReplaceTypeCodeWithSubclasses
{
    internal class ReplaceTypeCodeWithSubclasses
    {
        public class Employee
        {
            private int _type;

            public int Type
            {
                get
                {
                    return this._type;
                }
            }

            public const int ENGINEER = 0;

            public const int SALESMAN = 1;

            public const int MANAGER = 2;

            protected Employee(int type)
            {
                this._type = type;
            }

            public static Employee Create(int type)
            {
                switch (type)
                {
                    case Employee.ENGINEER: return new Engineer();
                    case Employee.MANAGER: return new Manager();
                    case Employee.SALESMAN: return new SalesMan();
                    default: throw new ArgumentException();
                }
            }
        }

        public class Engineer : Employee
        {
            public Engineer() : base(Employee.ENGINEER)
            {
            }

            public int Type
            {
                get
                {
                    return Employee.ENGINEER;
                }
            }
        }

        public class Manager : Employee
        {
            public Manager() : base(Employee.MANAGER)
            {
            }

            public int Type
            {
                get
                {
                    return Employee.MANAGER;
                }
            }
        }

        public class SalesMan : Employee
        {
            public SalesMan() : base(Employee.SALESMAN)
            {
            }

            public int Type
            {
                get
                {
                    return Employee.SALESMAN;
                }
            }
        }
    }
}