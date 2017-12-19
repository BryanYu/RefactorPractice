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
        public class Employee
        {
            private string _name;

            private string _id;

            private int _annualCost;

            public string Name
            {
                get
                {
                    return this._name;
                }
            }

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

            public Employee(string name, string id, int annualCost)
            {
                this._name = name;
                this._id = id;
                this._annualCost = annualCost;
            }
        }

        public class Department
        {
            private string _name;

            public List<Employee> _employees = new List<Employee>();

            public string Name
            {
                get
                {
                    return this._name;
                }
            }

            public Department(string name)
            {
                this._name = name;
            }

            public int GetTotalAnnualCost()
            {
                return this._employees.Sum(item => item.AnnualCost);
            }
        }
    }
}