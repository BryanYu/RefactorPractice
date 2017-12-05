using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.OrganizingData.ReplaceTypeCodeWithStateOrStrategy
{
    public class ReplaceTypeCodeWithStateOrStrategy
    {
        public class Employee
        {
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
                set
                {
                    switch (value)
                    {
                        case EmployeeType.ENGINEER:
                            this._type = new Enginer();
                            break;

                        case EmployeeType.MANAGER:
                            this._type = new Manager();
                            break;

                        case EmployeeType.SALESMAN:
                            this._type = new SalesMan();
                            break;

                        default:
                            throw new ArgumentException();
                    }
                }
            }

            public Employee(int type)
            {
                this._type = EmployeeType.NewType(type);
            }

            private int PayAmount()
            {
                switch (this.Type)
                {
                    case EmployeeType.ENGINEER: return _monthlySalary;
                    case EmployeeType.SALESMAN: return _monthlySalary * _commission;
                    case EmployeeType.MANAGER: return _monthlySalary * _bonus;
                    default:
                        throw new ArgumentException();
                }
            }
        }

        public class Enginer : EmployeeType
        {
            public override int GetTypeCode()
            {
                return ENGINEER;
            }
        }

        public class Manager : EmployeeType
        {
            public override int GetTypeCode()
            {
                return MANAGER;
            }
        }

        public class SalesMan : EmployeeType
        {
            public override int GetTypeCode()
            {
                return SALESMAN;
            }
        }

        public abstract class EmployeeType
        {
            public const int ENGINEER = 0;

            public const int SALESMAN = 1;

            public const int MANAGER = 2;

            public abstract int GetTypeCode();

            public static EmployeeType NewType(int code)
            {
                switch (code)
                {
                    case ENGINEER:
                        return new Enginer();

                    case SALESMAN:
                        return new SalesMan();

                    case MANAGER:
                        return new Manager();

                    default:
                        throw new ArgumentException();
                }
            }
        }
    }
}