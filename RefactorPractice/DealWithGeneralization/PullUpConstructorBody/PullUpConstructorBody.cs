using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.DealWithGeneralization.PullUpConstructorBody
{
    public class PullUpConstructorBody
    {
        public class Employee
        {
            protected string _name;

            protected string _id;
        }

        public class Manager : Employee
        {
            private int _grade;

            public Manager(string name, string id, int grade)
            {
                this._name = name;
                this._id = id;
                this._grade = grade;
            }
        }
    }
}