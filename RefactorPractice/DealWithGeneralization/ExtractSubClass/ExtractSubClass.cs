using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.DealWithGeneralization.ExtractSubClass
{
    public class ExtractSubClass
    {
        public void Sample()
        {
            JobItem jobitem = new JobItem(0, 5);
        }

        public class JobItem
        {
            private int _unitPrice;

            private int _quantity;

            public int UnitPrice
            {
                get
                {
                    return this._unitPrice;
                }
            }

            public int Quantity
            {
                get
                {
                    return this._quantity;
                }
            }

            public bool IsLabor
            {
                get
                {
                    return false;
                }
            }

            public int TotalPrice
            {
                get
                {
                    return this.UnitPrice * this._quantity;
                }
            }

            public JobItem(int unitPrice, int quantity)
            {
                this._unitPrice = unitPrice;
                this._quantity = quantity;
            }
        }

        public class LaborItem : JobItem
        {
            private int _unitPrice;

            protected Employee _employee;

            public Employee Employee
            {
                get
                {
                    return this._employee;
                }
            }

            public bool IsLabor
            {
                get
                {
                    return true;
                }
            }

            public int UnitPrice
            {
                get
                {
                    return this._employee.Rate;
                }
            }

            public LaborItem(int unitPrice, int quantity, Employee employee)
                : base(0, quantity)
            {
                this._employee = employee;
            }
        }

        public class Employee
        {
            private int _rate;

            public int Rate
            {
                get
                {
                    return this._rate;
                }
            }

            public Employee(int rate)
            {
                this._rate = rate;
            }
        }
    }
}