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







        [TestMethod()]
        public void HalvÅrligEjerafgiftTest_Diesel_Uden_10()
        {
            DieselBil dieselbil = new DieselBil("Ford", "XXXXXX", 100000, 2014, 10, false, 5);
            Assert.AreEqual(2500, dieselbil.HalvÅrligEjerafgift());
        }

        [TestMethod()]
        public void HalvÅrligEjerafgiftTest_Diesel_Uden_14()
        {
            DieselBil dieselbil = new DieselBil("Ford", "XXXXXX", 100000, 2014, 14, false, 5);
            Assert.AreEqual(2500, dieselbil.HalvÅrligEjerafgift());
        }

        [TestMethod()]
        public void HalvÅrligEjerafgiftTest_Diesel_Uden_15()
        {
            DieselBil dieselbil = new DieselBil("Ford", "XXXXXX", 100000, 2014, 15, false, 5);
            Assert.AreEqual(1500, dieselbil.HalvÅrligEjerafgift());
        }

        [TestMethod()]
        public void HalvÅrligEjerafgiftTest_Diesel_Uden_16()
        {
            DieselBil dieselbil = new DieselBil("Ford", "XXXXXX", 100000, 2014, 16, false, 5);
            Assert.AreEqual(1500, dieselbil.HalvÅrligEjerafgift());
        }

        [TestMethod()]
        public void HalvÅrligEjerafgiftTest_Diesel_Uden_20()
        {
            DieselBil dieselbil = new DieselBil("Ford", "XXXXXX", 100000, 2014, 20, false, 5);
            Assert.AreEqual(1500, dieselbil.HalvÅrligEjerafgift());
        }

        [TestMethod()]
        public void HalvÅrligEjerafgiftTest_Diesel_Uden_24()
        {
            DieselBil dieselbil = new DieselBil("Ford", "XXXXXX", 100000, 2014, 24, false, 5);
            Assert.AreEqual(1500, dieselbil.HalvÅrligEjerafgift());
        }

        [TestMethod()]
        public void HalvÅrligEjerafgiftTest_Diesel_Uden_25()
        {
            DieselBil dieselbil = new DieselBil("Ford", "XXXXXX", 100000, 2014, 25, false, 5);
            Assert.AreEqual(1500, dieselbil.HalvÅrligEjerafgift());
        }

        [TestMethod()]
        public void HalvÅrligEjerafgiftTest_Diesel_Uden_26()
        {
            DieselBil dieselbil = new DieselBil("Ford", "XXXXXX", 100000, 2014, 26, false, 5);
            Assert.AreEqual(850, dieselbil.HalvÅrligEjerafgift());
        }

        [TestMethod()]
        public void HalvÅrligEjerafgiftTest_Diesel_Uden_30()
        {
            DieselBil dieselbil = new DieselBil("Ford", "XXXXXX", 100000, 2014, 30, false, 5);
            Assert.AreEqual(850, dieselbil.HalvÅrligEjerafgift());
        }




        [TestMethod()]
        public void HalvÅrligEjerafgiftTest_Diesel_Med_10()
        {
            DieselBil dieselbil = new DieselBil("Ford", "XXXXXX", 100000, 2014, 10, true, 5);
            Assert.AreEqual(2000, dieselbil.HalvÅrligEjerafgift());
        } //

        [TestMethod()]
        public void HalvÅrligEjerafgiftTest_Diesel_Med_14()
        {
            DieselBil dieselbil = new DieselBil("Ford", "XXXXXX", 100000, 2014, 14, true, 5);
            Assert.AreEqual(2000, dieselbil.HalvÅrligEjerafgift());
        }

        [TestMethod()]
        public void HalvÅrligEjerafgiftTest_Diesel_Med_15()
        {
            DieselBil dieselbil = new DieselBil("Ford", "XXXXXX", 100000, 2014, 15, true, 5);
            Assert.AreEqual(1000, dieselbil.HalvÅrligEjerafgift());
        }

        [TestMethod()]
        public void HalvÅrligEjerafgiftTest_Diesel_Med_16()
        {
            DieselBil dieselbil = new DieselBil("Ford", "XXXXXX", 100000, 2014, 16, true, 5);
            Assert.AreEqual(1000, dieselbil.HalvÅrligEjerafgift());
        }

        [TestMethod()]
        public void HalvÅrligEjerafgiftTest_Diesel_Med_20()
        {
            DieselBil dieselbil = new DieselBil("Ford", "XXXXXX", 100000, 2014, 20, true, 5);
            Assert.AreEqual(1000, dieselbil.HalvÅrligEjerafgift());
        }

        [TestMethod()]
        public void HalvÅrligEjerafgiftTest_Diesel_Med_24()
        {
            DieselBil dieselbil = new DieselBil("Ford", "XXXXXX", 100000, 2014, 24, true, 5);
            Assert.AreEqual(1000, dieselbil.HalvÅrligEjerafgift());
        }

        [TestMethod()]
        public void HalvÅrligEjerafgiftTest_Diesel_Med_25()
        {
            DieselBil dieselbil = new DieselBil("Ford", "XXXXXX", 100000, 2014, 25, true, 5);
            Assert.AreEqual(1000, dieselbil.HalvÅrligEjerafgift());
        }

        [TestMethod()]
        public void HalvÅrligEjerafgiftTest_Diesel_Med_26()
        {
            DieselBil dieselbil = new DieselBil("Ford", "XXXXXX", 100000, 2014, 26, true, 5);
            Assert.AreEqual(350, dieselbil.HalvÅrligEjerafgift());
        }

        [TestMethod()]
        public void HalvÅrligEjerafgiftTest_Diesel_Med_30()
        {
            DieselBil dieselbil = new DieselBil("Ford", "XXXXXX", 100000, 2014, 30, true, 5);
            Assert.AreEqual(350, dieselbil.HalvÅrligEjerafgift());
        }



        //


        [TestMethod()]
        public void HalvÅrligEjerafgiftTest_Benzin_10()
        {
            BenzinBil benzinbil = new BenzinBil("Ford", "XXXXXX", 100000, 2014, 10, 5);
            Assert.AreEqual(1200, benzinbil.HalvÅrligEjerafgift());
        }

        [TestMethod()]
        public void HalvÅrligEjerafgiftTest_Benzin_19()
        {
            BenzinBil benzinbil = new BenzinBil("Ford", "XXXXXX", 100000, 2014, 19, 5);
            Assert.AreEqual(1200, benzinbil.HalvÅrligEjerafgift());
        }

        [TestMethod()]
        public void HalvÅrligEjerafgiftTest_Benzin_20()
        {
            BenzinBil benzinbil = new BenzinBil("Ford", "XXXXXX", 100000, 2014, 20, 5);
            Assert.AreEqual(600, benzinbil.HalvÅrligEjerafgift());
        }

        [TestMethod()]
        public void HalvÅrligEjerafgiftTest_Benzin_21()
        {
            BenzinBil benzinbil = new BenzinBil("Ford", "XXXXXX", 100000, 2014, 21, 5);
            Assert.AreEqual(600, benzinbil.HalvÅrligEjerafgift());
        }

        [TestMethod()]
        public void HalvÅrligEjerafgiftTest_Benzin_24()
        {
            BenzinBil benzinbil = new BenzinBil("Ford", "XXXXXX", 100000, 2014, 24, 5);
            Assert.AreEqual(600, benzinbil.HalvÅrligEjerafgift());
        }

        [TestMethod()]
        public void HalvÅrligEjerafgiftTest_Benzin_27()
        {
            BenzinBil benzinbil = new BenzinBil("Ford", "XXXXXX", 100000, 2014, 27, 5);
            Assert.AreEqual(600, benzinbil.HalvÅrligEjerafgift());
        }

        [TestMethod()]
        public void HalvÅrligEjerafgiftTest_Benzin_28()
        {
            BenzinBil benzinbil = new BenzinBil("Ford", "XXXXXX", 100000, 2014, 28, 5);
            Assert.AreEqual(600, benzinbil.HalvÅrligEjerafgift());
        }

        [TestMethod()]
        public void HalvÅrligEjerafgiftTest_Benzin_29()
        {
            BenzinBil benzinbil = new BenzinBil("Ford", "XXXXXX", 100000, 2014, 29, 5);
            Assert.AreEqual(320, benzinbil.HalvÅrligEjerafgift());
        }

        [TestMethod()]
        public void HalvÅrligEjerafgiftTest_Benzin_35()
        {
            BenzinBil benzinbil = new BenzinBil("Ford", "XXXXXX", 100000, 2014, 35, 5);
            Assert.AreEqual(320, benzinbil.HalvÅrligEjerafgift());
        }

    }
}