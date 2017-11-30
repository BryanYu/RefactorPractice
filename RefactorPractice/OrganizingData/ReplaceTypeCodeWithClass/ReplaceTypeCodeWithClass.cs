using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.OrganizingData.ReplaceTypeCodeWithClass
{
    public class ReplaceTypeCodeWithClass
    {
        public class Person
        {
            public static int O = 1;

            public static int A = 2;

            public static int B = 2;

            public static int AB = 3;

            private int _bloodGroup;

            public int BloodGroup
            {
                get
                {
                    return this._bloodGroup;
                }

                set
                {
                    this._bloodGroup = value;
                }
            }

            public Person(int bloodGroup)
            {
                this._bloodGroup = bloodGroup;
            }
        }
    }
}