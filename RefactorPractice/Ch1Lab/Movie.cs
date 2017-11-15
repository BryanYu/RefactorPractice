using System;
using System.Linq;

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
    }
}