using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;

namespace RefatorPractice.Ch1Lab
{
    public class Customer
    {
        private List<Rental> _rental = new List<Rental>();

        public string Name { get; }

        public Customer(string name)
        {
            this.Name = name;
        }

        public void AddRental(Rental rental)
        {
            this._rental.Add(rental);
        }

        public string GetStatement()
        {
            // 總消費金額
            var totalAmount = 0.0;

            // 常客積點
            var frequentRenterPoints = 0;
            var result = "Rental Record for" + this.Name;

            this._rental.ForEach(
                item =>
                {
                    frequentRenterPoints++;
                    if (item.Movie.PriceCode == Movie.New_Release && item.DayRented > 1)
                    {
                        frequentRenterPoints++;
                    }
                    result += $" {item.Movie.Title} {item.GetCharge()}";
                    totalAmount += item.GetCharge();
                });
            result += $" Amount owed is {totalAmount} ";
            result += $"You earned {frequentRenterPoints} frequent renter points";

            return result;
        }
    }
}