using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RefactorPractice.MovingFeaturesBetweenObjects.InlineClass
{
    public class InlineClass
    {
        public class Person
        {
            public string Name { get; set; }

            public string Number { get; set; }

            public string AreaCode { get; set; }

            public string GetTelephoneNumber()
            {
                return $"({this.AreaCode}) {this.Number}";
            }
        }
    }
}