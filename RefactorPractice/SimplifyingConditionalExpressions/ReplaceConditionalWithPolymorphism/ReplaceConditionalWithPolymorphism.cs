using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.SimplifyingConditionalExpressions.ReplaceConditionalWithPolymorphism
{
    internal class ReplaceConditionalWithPolymorphism
    {
        public class Employee
        {
            public const int ENGINERR = 0;
            public const int SALESMAN = 1;
            public const int MANAGER = 2;

            private EmployeeType _type;

            private int _monthlySalary;

            private int _commission;

            private int _bonus;

            public int Type
            {
                get
                {
                    return this._type.GetTypeCode();
                }
            }

            private int PayAmount()
            {
                switch (this.Type)
                {
                    case ENGINERR: return _monthlySalary;
                    case SALESMAN: return _monthlySalary + _commission;
                    case MANAGER: return _monthlySalary + _bonus;
                    default:
                        throw new ArgumentException();
                }
            }
        }

        public abstract class EmployeeType
        {
            public abstract int GetTypeCode();
        }

        public class Engineer : EmployeeType
        {
            public override int GetTypeCode()
            {
                return Employee.ENGINERR;
            }
        }

        public class SalesMan : EmployeeType
        {
            public override int GetTypeCode()
            {
                return Employee.SALESMAN;
            }
        }

        public class Manager : EmployeeType
        {
            public override int GetTypeCode()
            {
                return Employee.MANAGER;
            }
        }
    }
}