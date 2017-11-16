namespace RefatorPractice.Ch1Lab
{
    public class ChildrensPrice : Price
    {
        public override int GetPriceCode()
        {
            return Movie.Childrens;
        }
    }
}