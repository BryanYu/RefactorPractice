using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.HideDelegate
{
    public class HideDelegate
    {
        public void Sample()
        {
            var person = new Person();
            var manager = person.GetManager();
        }

        public class Person
        {
            public Department Department;

            public Person GetManager()
            {
                return this.Department.Manager;
            }
        }

        public class Department
        {
            public string ChargeCode { get; set; }

            public Person Manager { get; }

            public Department(Person manager)
            {
                this.Manager = manager;
            }
        }
    }
}