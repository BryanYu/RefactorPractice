using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.ExtractClass
{
    public class ExtractClass
    {
        public class Person
        {
            private TelephoneNumber _officeTelephone = new TelephoneNumber();

            public string Name { get; set; }

            public string GetOfficeTelephoneNumber()
            {
                return $"({this._officeTelephone.AreaCode}) {this._officeTelephone.Number}";
            }
        }

        public class TelephoneNumber
        {
            public string AreaCode { get; set; }

            public string Number { get; set; }
        }
    }
}