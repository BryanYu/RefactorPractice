using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.DealWithGeneralization.ReplaceDelegationWithInheritance
{
    internal class ReplaceDelegationWithInheritance
    {
        public class Employee : Person
        {
            public string GetName()
            {
                return base.Name;
            }

            public void SetName(string name)
            {
                base.Name = name;
            }

            public string ToString()
            {
                return "Emp:" + base.LastName;
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