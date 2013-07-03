using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MovieStore
{
    [TestClass]
    public class UnitTest1
    {

        // Movies
        Movie m_Cinderella;
        Movie m_StarWars;
        Movie m_Gladiator;
        Movie m_BruceAlmighty;
        // Rentals
        Rental m_Rental1;
        Rental m_Rental2;
        Rental m_Rental3;
        Rental m_Rental4;
        // Customers
        Customer m_MickeyMouse;
        Customer m_DonaldDuck;
        Customer m_BillClinton;
        Customer m_GeorgeBush;

        protected bool IsRunInSession { get; set; }
        [TestInitialize]
        public void Startup()
        {
            Init();
        }

        public void Init()
        {
            if (IsRunInSession) return;
            // Create movies
            m_Cinderella = new Movie("Cinderella", PriceCodes.Childrens);
            m_StarWars = new Movie("Star Wars", PriceCodes.Regular);
            m_Gladiator = new Movie("Gladiator", PriceCodes.NewRelease);
            m_BruceAlmighty = new Movie("Bruce Almighty", PriceCodes.NewRelease);
            // Create rentals
            m_Rental1 = new Rental(m_Cinderella, 5);
            m_Rental2 = new Rental(m_StarWars, 5);
            m_Rental3 = new Rental(m_Gladiator, 5);
            m_Rental4 = new Rental(m_BruceAlmighty, 365);
            // Create customers
            m_MickeyMouse = new Customer("Mickey Mouse");
            m_DonaldDuck = new Customer("Donald Duck");
            m_BillClinton = new Customer("Bill Clinton");
            m_GeorgeBush = new Customer("George Bush");

            IsRunInSession = true;
        }


        [TestMethod]
        public void MovieTest()
        {
            // Test title property
            Assert.AreEqual("Cinderella", m_Cinderella.Title);
            Assert.AreEqual("Star Wars", m_StarWars.Title);
            Assert.AreEqual("Gladiator", m_Gladiator.Title);

            // Test price code
            Assert.AreEqual(PriceCodes.Childrens, m_Cinderella.PriceCode);
            Assert.AreEqual(PriceCodes.Regular, m_StarWars.PriceCode);
            Assert.AreEqual(PriceCodes.NewRelease, m_Gladiator.PriceCode);
        }

        [TestMethod]
        public void RentalTest()
        {
            // Test Movie property
            Assert.AreEqual(m_Cinderella, m_Rental1.Movie);
            Assert.AreEqual(m_StarWars, m_Rental2.Movie);
            Assert.AreEqual(m_Gladiator, m_Rental3.Movie);
            // Test DaysRented property
            Assert.AreEqual(5, m_Rental1.DaysRented);
            Assert.AreEqual(5, m_Rental1.DaysRented);
            Assert.AreEqual(5, m_Rental1.DaysRented);
        }
    }
}
