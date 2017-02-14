using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bil_opgave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bil_opgave.Tests
{
    [TestClass()]
    public class BilTests
    {
        // Dielselbil med og uden filter, samt Benzin bil har samme registreringsafgift
        // Så her teststes kun Diesel uden

        [TestMethod()]
        public void RegristreringsAfgiftTest_Diesel_Uden_År2014_50000()
        {
            DieselBil dieselbil = new DieselBil("Ford", "XXXXXX", 50000, 2014, 10, false, 5);
            Assert.AreEqual(52500, dieselbil.RegristreringsAfgift());
        }

        [TestMethod()]
        public void RegristreringsAfgiftTest_Diesel_Uden_År2014_80499()
        {
            DieselBil dieselbil = new DieselBil("Ford", "XXXXXX", 80499, 2014, 10, false, 5);
            Assert.AreEqual(84523.95, dieselbil.RegristreringsAfgift());
        }

        [TestMethod()]
        public void RegristreringsAfgiftTest_Diesel_Uden_År2014_80500()
        {
            DieselBil dieselbil = new DieselBil("Ford", "XXXXXX", 80500, 2014, 10, false, 5);
            Assert.AreEqual(84525, dieselbil.RegristreringsAfgift());
        }

        [TestMethod()]
        public void RegristreringsAfgiftTest_Diesel_Uden_År2014_80501()
        {
            DieselBil dieselbil = new DieselBil("Ford", "XXXXXX", 80501, 2014, 10, false, 5);
            Assert.AreEqual(84526.8, dieselbil.RegristreringsAfgift());
        }

        [TestMethod()]
        public void RegristreringsAfgiftTest_Diesel_Uden_År2014_100000()
        {
            DieselBil dieselbil = new DieselBil("Ford", "XXXXXX", 100000, 2014, 10, false, 5);
            Assert.AreEqual(119625, dieselbil.RegristreringsAfgift());
        }

        [TestMethod()]
        public void RegristreringsAfgiftTest_Diesel_Uden_År2015_50000()
        {
            DieselBil dieselbil = new DieselBil("Ford", "XXXXXX", 50000, 2015, 10, false, 5);
            Assert.AreEqual(52500, dieselbil.RegristreringsAfgift());
        }

        [TestMethod()]
        public void RegristreringsAfgiftTest_Diesel_Uden_År2015_81699()
        {
            DieselBil dieselbil = new DieselBil("Ford", "XXXXXX", 81699, 2015, 10, false, 5);
            Assert.AreEqual(85783.95, dieselbil.RegristreringsAfgift());
        }

        [TestMethod()]
        public void RegristreringsAfgiftTest_Diesel_Uden_År2015_81700()
        {
            DieselBil dieselbil = new DieselBil("Ford", "XXXXXX", 81700, 2015, 10, false, 5);
            Assert.AreEqual(85785, dieselbil.RegristreringsAfgift());
        }

        [TestMethod()]
        public void RegristreringsAfgiftTest_Diesel_Uden_År2015_81701()
        {
            DieselBil dieselbil = new DieselBil("Ford", "XXXXXX", 81701, 2015, 10, false, 5);
            Assert.AreEqual(85786.8, dieselbil.RegristreringsAfgift());
        }

        [TestMethod()]
        public void RegristreringsAfgiftTest_Diesel_Uden_År2015_100000()
        {
            DieselBil dieselbil = new DieselBil("Ford", "XXXXXX", 100000, 2015, 10, false, 5);
            Assert.AreEqual(118725, dieselbil.RegristreringsAfgift());
        }

 

    }
}