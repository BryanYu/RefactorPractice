using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.DealWithGeneralization.FormTemplateMethod
{
    internal class FormTemplateMethod
    {
        public class Customer
        {
            private List<Rental> _rentals;

            public List<Rental> Rental
            {
                get
                {
                    return this._rentals;
                }
            }

            public string Name { get; set; }

            public string GetTotalFrequentRenterPoints()
            {
                throw new NotImplementedException();
            }

            public string GetTotalCharge()
            {
                throw new NotImplementedException();
            }
        }

        public class Rental
        {
            public Movie Movie { get; set; }

            public decimal Charge { get; set; }
        }

        public class Movie
        {
            public string Title { get; set; }
        }

        public abstract class Statement
        {
            public string Value(Customer customer)
            {
                string result = this.HeaderString(customer);
                foreach (var rental in customer.Rental)
                {
                    result += this.EachRentalString(rental);
                }
                result = this.FooterString(customer);
                return result;
            }

            public abstract string HeaderString(Customer customer);

            public abstract string EachRentalString(Rental rental);

            public abstract string FooterString(Customer customer);
        }

        public class TextStatement : Statement
        {
            public override string FooterString(Customer customer)
            {
                var result = "Amount owed is" + customer.GetTotalCharge() + "\n";
                result += "You earned " + customer.GetTotalFrequentRenterPoints() + "frequent renter points";
                return result;
            }

            public override string EachRentalString(Rental rental)
            {
                return rental.Movie.Title + "\t" + rental.Charge + "\n";
            }

            public override string HeaderString(Customer customer)
            {
                return "Rental Record for" + customer.Name + "\n";
            }
        }

        public class HtmlStatement : Statement
        {
            public override string FooterString(Customer customer)
            {
                var result = "<P> You owe <EM>" + customer.GetTotalCharge() + "</EM><P>\n";
                result += "On this rental you earned <EM>" + customer.GetTotalFrequentRenterPoints()
                          + "</EM> frequent renter points<P>";
                return result;
            }

            public override string EachRentalString(Rental rental)
            {
                return rental.Movie.Title + ":" + rental.Charge + "<BR>\n";
            }

            public override string HeaderString(Customer customer)
            {
                return "<H1>Rentals for <EM>" + customer.Name + "</EM><H1><P>\n";
            }
        }
    }
}