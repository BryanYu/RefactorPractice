using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.OrganizingData.ChangeBidirectonalAssociationToUnidirectional
{
    public class ChangeBidirectonalAssociationToUnidirectional
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

                Customer = arg;
                if (Customer != null)
                {
                    Customer.FriendOrders().Add(this);
                }
            }
        }

        public class Customer
        {
            private List<Order> _orders = new List<Order>();

            public List<Order> FriendOrders()
            {
                return this._orders;
            }

            private void AddOrder(Order arg)
            {
                arg.SetCustomer(this);
            }
        }
    }
}