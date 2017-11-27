using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.OrganizingData.ReplaceDataValueWithObject
{
    public class ReplaceDataValueWithObject
    {
        public class Order
        {
            private string _customer { get; set; }

            public Order(string customer)
            {
                this._customer = customer;
            }

            private static int NumberOfOrderFor(List<Order> orders, string customer)
            {
                var result = 0;
                foreach (var order in orders)
                {
                    if (order._customer.Equals(customer))
                    {
                        result++;
                    }
                }
                return result;
            }
        }
    }
}