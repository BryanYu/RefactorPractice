using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.OrganizingData.ReplaceTypeCodeWithClass
{
    public class ReplaceTypeCodeWithClass
    {
        public void Sample()
        {
            Person thePerson = new Person(BloodGroup.A);
            var code = thePerson.BloodGroup.Code;
            thePerson.BloodGroup = BloodGroup.AB;
        }

        public class Person
        {
            private BloodGroup _bloodGroup;

            public BloodGroup BloodGroup
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

            public Person(BloodGroup bloodGroup)
            {
                this._bloodGroup = bloodGroup;
            }
        }

        public class BloodGroup
        {
            public static BloodGroup O = new BloodGroup(0);

            public static BloodGroup A = new BloodGroup(1);

            public static BloodGroup B = new BloodGroup(2);

            public static BloodGroup AB = new BloodGroup(3);

            private static BloodGroup[] _values = { O, A, B, AB };

            private int _code;

            public int Code
            {
                get
                {
                    return this._code;
                }
            }

            public BloodGroup(int code)
            {
                this._code = code;
            }

            private static BloodGroup GetCode(int arg)
            {
                return _values[arg];
            }
        }
    }
}