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

            public static int ENGINEER = 0;

            public static int SALESMAN = 1;

            public static int MANAGER = 2;

            public Employee(int type)
            {
                this._type = type;
            }
        }
    }
}