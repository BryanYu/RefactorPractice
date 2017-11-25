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
            public string Name { get; set; }

            public string OfficeAreaCode { get; set; }

            public string OfficeNumber { get; set; }

            public string GetOfficeTelephoneNumber()
            {
                return $"({this.OfficeAreaCode}) {this.OfficeNumber}";
            }
        }
    }
}