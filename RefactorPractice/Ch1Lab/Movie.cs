using System;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;

namespace RefatorPractice.Ch1Lab
{
    /// <summary>The movie.</summary>
    public class Movie
    {
        public const int Childrens = 2;

        public const int Regular = 0;

        public const int New_Release = 1;

        private Price _price;
        public string Title { get; }

        public int PriceCode
        {
            get
            {
                return this._price.GetPriceCode();
            }
        }

        public Movie(string title, int priceCode)
        {
            this.Title = title;
            this.setPrice(priceCode);
        }

        public double GetCharge(int daysRented)
        {
            return this._price.GetCharge(daysRented);
        }

        public int GetFrequentRenterPoints(int dayRented)
        {
            if (this.PriceCode == New_Release && dayRented > 1)
            {
                return 2;
            }

            return 1;
        }

        private void setPrice(int priceCode)
        {
            switch (priceCode)
            {
                case Regular:
                    this._price = new RegularPrice();
                    break;

                case New_Release:
                    this._price = new NewReleasePrice();
                    break;

                case Childrens:
                    this._price = new ChildrensPrice();
                    break;
            }
        }
    }
}