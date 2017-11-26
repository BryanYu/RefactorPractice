using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.RemoveMiddleMan
{
    public class RemoveMiddleMan
    {
        public void Sample()
        {
            var person = new Person();
            var manager = person.Department.Manager;
        }

        public class Person
        {
            public Department Department;
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