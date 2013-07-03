namespace MovieStore
{
    public class Rental
    {
        private Movie m_Movie;
        private int m_DaysRented;

        public Rental(Movie movie, int daysRented)
        {
            m_Movie = movie;
            m_DaysRented = daysRented;
        }

        public int DaysRented
        {
            get { return m_DaysRented; }
        }

        public Movie Movie
        {
            get { return m_Movie; }
        }

        public double GetCharge()
        {
            double result = 0;
            // Determine amounts for rental line
            switch (Movie.PriceCode)
            {
                case PriceCodes.Regular:
                    result += 2;
                    if (DaysRented > 2)
                    {
                        result += (DaysRented - 2)*1.5;
                    }
                    break;
                case PriceCodes.NewRelease:
                    result += DaysRented*3;
                    break;
                case PriceCodes.Childrens:
                    result += 1.5;
                    if (DaysRented > 3)
                    {
                        result = (DaysRented - 3)*1.5;
                    }
                    break;
            }
            return result;
        }

        public int GetFrequentRenterPoints(int frequentRenterPoints)
        {
            // Add frequent renter points
            frequentRenterPoints++;

            // Add bonus for a two-day new release rental
            if ((Movie.PriceCode == PriceCodes.NewRelease)
                && (DaysRented > 1))
            {
                frequentRenterPoints++;
            }
            return frequentRenterPoints;
        }
    }
}