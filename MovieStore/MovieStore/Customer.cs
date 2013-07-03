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
                
                var thisAmount = AmountFor(each);

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
                + thisAmount.ToString() + "\n";
                totalAmount += thisAmount;
            }

            // Add footer lines
            result += "Amount owed is " + totalAmount.ToString() + "\n";
            result += "You earned " + frequentRenterPoints.ToString()
            + " frequent renter points.";
            return result;
        }

        private static double AmountFor(Rental each)
        {
            double thisAmount = 0;
            // Determine amounts for each line
            switch (each.Movie.PriceCode)
            {
                case PriceCodes.Regular:
                    thisAmount += 2;
                    if (each.DaysRented > 2)
                    {
                        thisAmount += (each.DaysRented - 2)*1.5;
                    }
                    break;
                case PriceCodes.NewRelease:
                    thisAmount += each.DaysRented*3;
                    break;
                case PriceCodes.Childrens:
                    thisAmount += 1.5;
                    if (each.DaysRented > 3)
                    {
                        thisAmount = (each.DaysRented - 3)*1.5;
                    }
                    break;
            }
            return thisAmount;
        }
    }
}