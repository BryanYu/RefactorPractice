namespace RefatorPractice.Ch1Lab
{
    public class Rental
    {
        public Movie Movie { get; }

        public int DayRented { get; }

        public Rental(Movie movie,
                      int dayRented)
        {
            this.Movie = movie;
            this.DayRented = dayRented;
        }

        public double GetCharge()
        {
            var result = 0.0;
            switch (this.Movie.PriceCode)
            {
                case Movie.Regular:
                    result += 2;
                    if (this.DayRented > 2)
                    {
                        result += (this.DayRented - 2) * 1.5;
                    }

                    break;

                case Movie.New_Release:
                    result += this.DayRented * 3;
                    break;

                case Movie.Childrens:
                    result += 1.5;
                    if (this.DayRented > 3)
                    {
                        result += (this.DayRented - 3) * 1.5;
                    }

                    break;
            }

            return result;
        }
    }
}