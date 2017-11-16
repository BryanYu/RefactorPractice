namespace RefatorPractice.Ch1Lab
{
    public abstract class Price
    {
        public abstract int GetPriceCode();

        public double GetCharge(int daysRented)
        {
            var result = 0.0;
            switch (this.GetPriceCode())
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
    }
}