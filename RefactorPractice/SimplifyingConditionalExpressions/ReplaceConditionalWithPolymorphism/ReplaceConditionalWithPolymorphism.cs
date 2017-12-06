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

            public int MonthlySalary { get; set; }

            public int Commission { get; set; }

            public int Bonus { get; set; }

            public int PayAmount()
            {
                return this._type.PayAmount(this);
            }

            public int Type
            {
                get
                {
                    return this._type.GetTypeCode();
                }
            }
        }

        public abstract class EmployeeType
        {
            public abstract int GetTypeCode();

            public abstract int PayAmount(Employee emp);
        }

        public class Engineer : EmployeeType
        {
            public override int GetTypeCode()
            {
                return Employee.ENGINERR;
            }

            public override int PayAmount(Employee emp)
            {
                return emp.MonthlySalary;
            }
        }

        public class SalesMan : EmployeeType
        {
            public override int GetTypeCode()
            {
                return Employee.SALESMAN;
            }

            public override int PayAmount(Employee emp)
            {
                return emp.MonthlySalary + emp.Commission;
            }
        }

        public class Manager : EmployeeType
        {
            public override int GetTypeCode()
            {
                return Employee.MANAGER;
            }

            public override int PayAmount(Employee emp)
            {
                return emp.MonthlySalary + emp.Bonus;
            }
        }
    }
}