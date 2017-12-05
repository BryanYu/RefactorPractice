using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

using RefactorPractice.MovingFeaturesBetweenObjects.ExtractClass;

namespace RefactorPractice.OrganizingData.ReplaceSubclassWithFields
{
    internal class ReplaceSubclassWithFields
    {
        public class Person
        {
            private bool _isMale;

            private char _code;

            protected Person(bool isMale, char code)
            {
                this._isMale = isMale;
                this._code = code;
            }

            public bool IsMale()
            {
                return this._isMale;
            }

            public char GetCode()
            {
                return this._code;
            }

            public static Person CreateFemale()
            {
                return new Person(true, 'M');
            }
        }
    }
}