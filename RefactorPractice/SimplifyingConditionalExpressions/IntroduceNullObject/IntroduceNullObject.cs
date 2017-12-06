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
            BillingPlan plan;
            int weeksDelinquent;

            if (customer == null)
            {
                plan = new BillingPlan();
            }
            else
            {
                plan = customer.Plan;
            }

            if (customer == null)
            {
                weeksDelinquent = 0;
            }
            else
            {
                weeksDelinquent = customer.History.GetWeeksDelinquentInLastYear();
            }
        }

        public class Site
        {
            private Customer _customer;

            public Customer Customer
            {
                get
                {
                    return this._customer;
                }
            }
        }

        public class Customer
        {
            public string Name { get; set; }

            public BillingPlan Plan { get; set; }

            public PaymentHistory History { get; set; }
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
        }
    }
}