namespace RefatorPractice.Ch1Lab
{
    public class Rental
    {
        public Movie Movie { get; }

        public int DayRented { get; }

        public Rental(Movie movie, int dayRented)
        {
            this.Movie = movie;
            this.DayRented = dayRented;
        }

        public double GetCharge()
        {
            return this.Movie.GetCharge(this.DayRented);
        }

        public int GetFrequentRenterPoints()
        {
            return this.Movie.GetFrequentRenterPoints(this.DayRented);
        }
    }
}