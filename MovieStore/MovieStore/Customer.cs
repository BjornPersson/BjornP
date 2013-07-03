using System.Collections;

namespace MovieStore
{
    public class Customer
    {
        private string m_Name;
        private ArrayList m_Rentals = new ArrayList();
        public Customer(string name)
        {
            m_Name = name;
        }
        public string Name
        {
            get { return m_Name; }
        }
        public void AddRental(Rental arg)
        {
            m_Rentals.Add(arg);
        }
        public string Statement()
        {
            double totalAmount = 0;
            int frequentRenterPoints = 0;
            IEnumerator rentals = m_Rentals.GetEnumerator();
            string result = "Rental record for " + m_Name + "\n";
            while (rentals.MoveNext())
            {
                Rental each = (Rental)rentals.Current;

                // Add frequent renter points
                frequentRenterPoints++;

                // Add bonus for a two-day new release rental
                if ((each.Movie.PriceCode == PriceCodes.NewRelease)
                && (each.DaysRented > 1))
                {
                    frequentRenterPoints++;
                }

                // Show figures for this rental
                result += "\t" + each.Movie.Title + "\t"
                + each.GetCharge().ToString() + "\n";
                totalAmount += each.GetCharge();
            }

            // Add footer lines
            result += "Amount owed is " + totalAmount.ToString() + "\n";
            result += "You earned " + frequentRenterPoints.ToString()
            + " frequent renter points.";
            return result;
        }
    }
}