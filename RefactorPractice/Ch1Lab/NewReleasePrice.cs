namespace RefatorPractice.Ch1Lab
{
    public class NewReleasePrice : Price
    {
        public override int GetPriceCode()
        {
            return Movie.New_Release;
        }

        public override double GetCharge(int daysRented)
        {
            return daysRented * 3;
        }
    }
}