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
                    var thisAmount = GetAmount(item);

                    frequentRenterPoints++;
                    if (item.Movie.PriceCode == Movie.New_Release && item.DayRented > 1)
                    {
                        frequentRenterPoints++;
                    }
                    result += $" {item.Movie.Title} {thisAmount}";
                    totalAmount += thisAmount;
                });
            result += $" Amount owed is {totalAmount} ";
            result += $"You earned {frequentRenterPoints} frequent renter points";

            return result;
        }

        private double GetAmount(Rental item)
        {
            var thisAmount = 0.0;
            switch (item.Movie.PriceCode)
            {
                case Movie.Regular:
                    thisAmount += 2;
                    if (item.DayRented > 2)
                    {
                        thisAmount += (item.DayRented - 2) * 1.5;
                    }

                    break;

                case Movie.New_Release:
                    thisAmount += item.DayRented * 3;
                    break;

                case Movie.Childrens:
                    thisAmount += 1.5;
                    if (item.DayRented > 3)
                    {
                        thisAmount += (item.DayRented - 3) * 1.5;
                    }

                    break;
            }

            return thisAmount;
        }
    }
}