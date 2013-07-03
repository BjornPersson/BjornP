﻿namespace MovieStore
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

        public static double GetCharge(Rental rental)
        {
            double result = 0;
            // Determine amounts for rental line
            switch (rental.Movie.PriceCode)
            {
                case PriceCodes.Regular:
                    result += 2;
                    if (rental.DaysRented > 2)
                    {
                        result += (rental.DaysRented - 2)*1.5;
                    }
                    break;
                case PriceCodes.NewRelease:
                    result += rental.DaysRented*3;
                    break;
                case PriceCodes.Childrens:
                    result += 1.5;
                    if (rental.DaysRented > 3)
                    {
                        result = (rental.DaysRented - 3)*1.5;
                    }
                    break;
            }
            return result;
        }
    }
}