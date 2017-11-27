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
            private Customer _customer;

            public Order(string customerName)
            {
                this._customer = new Customer(customerName);
            }

            public string GetCustomerName()
            {
                return this._customer.Name;
            }

            private static int NumberOfOrderFor(List<Order> orders, Customer customer)
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

        public class Customer
        {
            public string Name { get; set; }

            public Customer(string name)
            {
                this.Name = name;
            }
        }
    }
}