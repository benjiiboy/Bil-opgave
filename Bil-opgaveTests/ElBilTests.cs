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
    public class ElBilTests
    {
        [TestMethod()]
        public void HalvÅrligEjerafgiftTest()
        {
            //arrange
            ElBil elbil = new ElBil("Ford", "NB27332", 100000, 2015, 4000, 30);

            //act
            int afgift = elbil.HalvÅrligEjerafgift();

            //assert
            Assert.AreEqual(0, afgift);
        }

        [TestMethod()]
        public void RegristreringsAfgiftTest_År2014_50000()
        {
            ElBil elbil = new ElBil("Ford", "NB27332", 50000, 2014, 4000, 30);
            Assert.AreEqual(10500, elbil.RegristreringsAfgift());
        }

        [TestMethod()]
        public void RegristreringsAfgiftTest_År2014_80499()
        {
            ElBil elbil = new ElBil("Ford", "NB27332", 80499, 2014, 4000, 30);
            Assert.AreEqual(16904.79, elbil.RegristreringsAfgift());
        }

        [TestMethod()]
        public void RegristreringsAfgiftTest_År2014_80500()
        {
            ElBil elbil = new ElBil("Ford", "NB27332", 80500, 2014, 4000, 30);
            Assert.AreEqual(16905, elbil.RegristreringsAfgift());
        }

        [TestMethod()]
        public void RegristreringsAfgiftTest_År2014_80501()
        {
            ElBil elbil = new ElBil("Ford", "NB27332", 80501, 2014, 4000, 30);
            Assert.AreEqual(16905.36, elbil.RegristreringsAfgift());
        }

        [TestMethod()]
        public void RegristreringsAfgiftTest_År2014_100000()
        {
            ElBil elbil = new ElBil("Ford", "NB27332", 100000, 2014, 4000, 30);
            Assert.AreEqual(23925, elbil.RegristreringsAfgift());
        }

        [TestMethod()]
        public void RegristreringsAfgiftTest_År2015_50000()
        {
            ElBil elbil = new ElBil("Ford", "NB27332", 50000, 2015, 4000, 30);
            Assert.AreEqual(10500, elbil.RegristreringsAfgift());
        }

        [TestMethod()]
        public void RegristreringsAfgiftTest_År2015_81699()
        {
            ElBil elbil = new ElBil("Ford", "NB27332", 81699, 2015, 4000, 30);
            Assert.AreEqual(17156.79, elbil.RegristreringsAfgift());
        }

        [TestMethod()]
        public void RegristreringsAfgiftTest_År2015_81700()
        {
            ElBil elbil = new ElBil("Ford", "NB27332", 81700, 2015, 4000, 30);
            Assert.AreEqual(17157, elbil.RegristreringsAfgift());
        }

        [TestMethod()]
        public void RegristreringsAfgiftTest_År2015_81701()
        {
            ElBil elbil = new ElBil("Ford", "NB27332", 81701, 2015, 4000, 30);
            Assert.AreEqual(17157.36, elbil.RegristreringsAfgift());
        }

        [TestMethod()]
        public void RegristreringsAfgiftTest_År2015_100000()
        {
            ElBil elbil = new ElBil("Ford", "NB27332", 100000, 2015, 4000, 30);
            Assert.AreEqual(23745, elbil.RegristreringsAfgift());
        }


    }
}