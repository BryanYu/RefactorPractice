using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.InlineClass
{
    public class InlineClass
    {
        public class Person
        {
            public string Name { get; set; }

            public TelephoneNumber Type
            {
                get
                {
                    return new TelephoneNumber();
                }
            }

            public string GetTelephoneNumber()
            {
                return this.Type.GetTelephoneNumber();
            }
        }

        public class TelephoneNumber
        {
            public string Number { get; set; }

            public string AreaCode { get; set; }

            public string GetTelephoneNumber()
            {
                return $"({this.AreaCode}) {this.Number}";
            }
        }
    }
}