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
            private static Dictionary<string, Customer> _instances = new Dictionary<string, Customer>();
            public string Name { get; set; }

            private Customer(string name)
            {
                this.Name = name;
            }

            public static void LoadCustomers()
            {
                new Customer("Lemon Car Hire").Store();
                new Customer("Associated Coffee Machines").Store();
                new Customer("Bilston Gasworks").Store();
            }

            public static Customer Create(string name)
            {
                return _instances[name] as Customer;
            }

            private void Store()
            {
                _instances.Add(this.Name, this);
            }
        }

        public class Order
        {
            public Customer Customer { get; set; }

            public Order(string customerName)
            {
                this.Customer = Customer.Create(customerName);
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