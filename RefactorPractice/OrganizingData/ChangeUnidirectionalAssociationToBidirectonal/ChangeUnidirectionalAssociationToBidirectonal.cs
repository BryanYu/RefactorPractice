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
        }

        public class Customer
        {
            public List<Order> Orders { get; set; }
        }
    }
}