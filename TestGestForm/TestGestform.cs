using GestForm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestGestform
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestRangeOfNumbers()
        {
            int min = -1000;
            int max = 1000;
            List<int> listeNumber = RandomListGenerator.Generate();
            for (int i = 0; i < 100000; i++)
            {
                Assert.IsTrue(listeNumber.Any(number => number >= min && number <= max));
            }
        }
        [TestMethod]
        public void TestSizeOfListIs10()
        {
            int sizeOfList = 10;
            List<int> listeNumber = RandomListGenerator.Generate();

            Assert.AreEqual(listeNumber.Count, sizeOfList);
        }

        [TestMethod]
        public void TestGestformWithNumber159()
        {
            int number = 159;

            string waitedResult = "Geste";

            Assert.AreEqual(waitedResult, Gestform.Work(number));
        }

        [TestMethod]
        public void TestGestformWithNumberMines855()
        {
            int number = -855;

            string waitedResult = "Gestform";

            Assert.AreEqual(waitedResult, Gestform.Work(number));
        }

        [TestMethod]
        public void TestGestformWithNumber2()
        {
            int number = 2;

            string waitedResult = "2";

            Assert.AreEqual(waitedResult, Gestform.Work(number));
        }

        [TestMethod]
        public void TestGestformWithNumber395()
        {
            int number = 395;

            string waitedResult = "Forme";

            Assert.AreEqual(waitedResult, Gestform.Work(number));
        }
    }
}
