using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.DealWithGeneralization.FormTemplateMethod
{
    internal class FormTemplateMethod
    {
        private List<Rental> _rentals;
        public string Name { get; set; }

        public string StateMent()
        {
            var result = "Rental Record for" + this.Name + "\n";
            foreach (var rental in this._rentals)
            {
                result += rental.Movie.Title + "\t" + rental.Charge + "\n";
            }
            result += "Amount owed is" + GetTotalCharge() + "\n";
            result += "You earned " + GetTotalFrequentRenterPoints() + "frequent renter points";
            return result;
        }

        public string HtmlStatMent()
        {
            var result = "<H1>Rentals for <EM>" + this.Name + "</EM><H1><P>\n";
            foreach (var rental in this._rentals)
            {
                result += rental.Movie.Title + ":" + rental.Charge + "<BR>\n";
            }
            result += "<P> You owe <EM>" + GetTotalCharge() + "</EM><P>\n";
            result += "On this rental you earned <EM>" + GetTotalFrequentRenterPoints()
                      + "</EM> frequent renter points<P>";
            return result;
        }

        private string GetTotalFrequentRenterPoints()
        {
            throw new NotImplementedException();
        }

        private string GetTotalCharge()
        {
            throw new NotImplementedException();
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
    }
}