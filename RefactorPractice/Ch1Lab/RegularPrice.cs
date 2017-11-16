namespace RefatorPractice.Ch1Lab
{
    public class RegularPrice : Price
    {
        public override int GetPriceCode()
        {
            return Movie.Regular;
        }
    }
}