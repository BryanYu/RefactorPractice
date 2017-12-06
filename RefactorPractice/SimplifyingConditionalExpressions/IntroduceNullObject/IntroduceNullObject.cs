using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.SimplifyingConditionalExpressions.IntroduceNullObject
{
    internal class IntroduceNullObject
    {
        public void Sample()
        {
            Customer customer = (new Site()).Customer;
            BillingPlan plan = new BillingPlan();
            customer.Plan = plan;
            var customerName = customer.Name;
            int weeksDelinquent = customer.History.GetWeeksDelinquentInLastYear();
        }

        public class Site
        {
            private Customer _customer;

            public Customer Customer
            {
                get
                {
                    return this._customer == null ? Customer.NewNull() : this._customer;
                }
            }
        }

        public class Customer
        {
            public string Name { get; set; }

            public BillingPlan Plan { get; set; }

            public PaymentHistory History { get; set; }

            public bool IsNull()
            {
                return false;
            }

            protected Customer()
            {
            }

            public static Customer NewNull()
            {
                return new NullCustomer();
            }
        }

        public class BillingPlan
        {
        }

        public class PaymentHistory
        {
            public int GetWeeksDelinquentInLastYear()
            {
                return 0;
            }

            public static PaymentHistory NewNull()
            {
                return new NullPaymentHistory();
            }
        }

        public class NullCustomer : Customer
        {
            public bool IsNull()
            {
                return true;
            }

            public string Name
            {
                get
                {
                    return "occupant";
                }
            }

            private BillingPlan _plan;

            public BillingPlan Plan
            {
                set
                {
                    this._plan = value;
                }
            }

            public PaymentHistory History
            {
                get
                {
                    return PaymentHistory.NewNull();
                }
            }
        }

        public class NullPaymentHistory : PaymentHistory
        {
            public int GetWeeksDelinquentInLastYear()
            {
                return 0;
            }
        }
    }
}