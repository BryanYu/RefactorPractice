using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.OrganizingData.ChangeValueToReference
{
    public class ChangeValueToReference
    {
        public class Customer
        {
            public string Name { get; set; }

            public Customer(string name)
            {
                this.Name = name;
            }
        }

        public class Order
        {
            public Customer Customer { get; set; }

            public Order(string customerName)
            {
                this.Customer = new Customer(customerName);
            }

            public static int NumberOfOrdersFor(List<Order> orders, string customer)
            {
                var result = 0;
                foreach (var order in orders)
                {
                    if (order.GetCusomterName().Equals(customer))
                    {
                        result++;
                    }
                }
                return result;
            }

            public string GetCusomterName()
            {
                return this.Customer.Name;
            }
        }
    }
}