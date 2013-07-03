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
    }
}