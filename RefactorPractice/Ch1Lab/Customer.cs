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

        private double GetAmount(Rental rental)
        {
            var result = 0.0;
            switch (rental.Movie.PriceCode)
            {
                case Movie.Regular:
                    result += 2;
                    if (rental.DayRented > 2)
                    {
                        result += (rental.DayRented - 2) * 1.5;
                    }

                    break;

                case Movie.New_Release:
                    result += rental.DayRented * 3;
                    break;

                case Movie.Childrens:
                    result += 1.5;
                    if (rental.DayRented > 3)
                    {
                        result += (rental.DayRented - 3) * 1.5;
                    }

                    break;
            }

            return result;
        }
    }
}