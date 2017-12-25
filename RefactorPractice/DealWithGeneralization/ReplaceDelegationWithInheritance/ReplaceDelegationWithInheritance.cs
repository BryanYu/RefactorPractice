using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.DealWithGeneralization.ReplaceDelegationWithInheritance
{
    internal class ReplaceDelegationWithInheritance
    {
        public class Employee
        {
            private Person _person = new Person();

            public string GetName()
            {
                return this._person.Name;
            }

            public void SetName(string name)
            {
                this._person.Name = name;
            }

            public string ToString()
            {
                return "Emp:" + this._person.LastName;
            }
        }

        public class Person
        {
            public string Name { get; set; }

            public string LastName
            {
                get
                {
                    return this.Name.Substring(this.Name.LastIndexOf("") + 1);
                }
            }
        }
    }
}