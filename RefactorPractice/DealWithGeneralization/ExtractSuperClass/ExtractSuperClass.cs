using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.DealWithGeneralization.ExtractSuperClass
{
    public class ExtractSuperClass
    {
        public abstract class Party
        {
            protected Party(string name)
            {
                this._name = name;
            }

            protected string _name;

            public string Name
            {
                get
                {
                    return this._name;
                }
            }

            public abstract int GetAnnualCost();
        }

        public class Employee : Party
        {
            private string _id;

            private int _annualCost;

            public string Id
            {
                get
                {
                    return this._id;
                }
            }

            public int AnnualCost
            {
                get
                {
                    return this._annualCost;
                }
            }

            public Employee(string name, string id, int annualCost) : base(name)
            {
                this._id = id;
                this._annualCost = annualCost;
            }

            public override int GetAnnualCost()
            {
                return this.AnnualCost;
            }
        }

        public class Department : Party
        {
            public List<Employee> _employees = new List<Employee>();

            public Department(string name) : base(name)
            {
            }

            public override int GetAnnualCost()
            {
                return this._employees.Sum(item => item.AnnualCost);
            }
        }
    }
}