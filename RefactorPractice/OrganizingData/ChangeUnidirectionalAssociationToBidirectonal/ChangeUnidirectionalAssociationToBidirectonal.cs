using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.OrganizingData.ChangeUnidirectionalAssociationToBidirectonal
{
    public class ChangeUnidirectionalAssociationToBidirectonal
    {
        public class Order
        {
            public Customer Customer { get; set; }

            public void SetCustomer(Customer arg)
            {
                if (Customer != null)
                {
                    Customer.FriendOrders().Remove(this);
                }

                this.Customer = arg;

                if (Customer != null)
                {
                    Customer.FriendOrders().Add(this);
                }
            }
        }

        public class Customer
        {
            private List<Order> _orders { get; set; }

            public List<Order> FriendOrders()
            {
                return _orders;
            }

            public void AddOrder(Order arg)
            {
                arg.SetCustomer(this);
            }
        }
    }
}