using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace RefatorPractice.Ch1Lab
{
    /// <summary>The movie.</summary>
    public class Movie
    {
        public const int Childrens = 2;

        public const int Regular = 0;

        public const int New_Release = 1;

        public string Title { get; }

        public int PriceCode { get; set; }

        public Movie(string title, int priceCode)
        {
            this.Title = title;
            this.PriceCode = priceCode;
        }

        public double GetCharge(int daysRented)
        {
            var result = 0.0;
            switch (this.PriceCode)
            {
                case Movie.Regular:
                    result += 2;
                    if (daysRented > 2)
                    {
                        result += (daysRented - 2) * 1.5;
                    }

                    break;

                case Movie.New_Release:
                    result += daysRented * 3;
                    break;

                case Movie.Childrens:
                    result += 1.5;
                    if (daysRented > 3)
                    {
                        result += (daysRented - 3) * 1.5;
                    }

                    break;
            }

            return result;
        }

        public int GetFrequentRenterPoints(int dayRented)
        {
            if (this.PriceCode == New_Release && dayRented > 1)
            {
                return 2;
            }

            return 1;
        }
    }
}