namespace MovieStore
{
    public class Movie
    {
        private string m_Title;
        private PriceCodes m_PriceCode;
        public Movie(string title, PriceCodes priceCode)
        {
            m_Title = title;
            m_PriceCode = priceCode;
        }
        public PriceCodes PriceCode
        {
            get { return m_PriceCode; }
            set { m_PriceCode = value; }
        }
        public string Title
        {
            get { return m_Title; }
        }
    }
}