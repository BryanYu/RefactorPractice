using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.DealWithGeneralization.ExtractSubClass
{
    public class ExtractSubClass
    {
        public class JobItem
        {
            private int _unitPrice;
            private int _quantity;
            private bool _isLabor;
            private Employee _employee;

            public int UnitPrice
            {
                get
                {
                    return (this._isLabor) ? this._employee.Rate : this._unitPrice;
                }
            }

            public int Quantity
            {
                get
                {
                    return this._quantity;
                }
            }

            public Employee Employee
            {
                get
                {
                    return this._employee;
                }
            }

            public int TotalPrice
            {
                get
                {
                    return this.UnitPrice * this._quantity;
                }
            }

            public JobItem(int unitPrice, int quantity, bool isLabor, Employee employee)
            {
                this._unitPrice = unitPrice;
                this._quantity = quantity;
                this._isLabor = isLabor;
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