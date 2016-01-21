using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoadTrip.ConsoleApp;

namespace RoadTrip.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "Rkbs,5453; Wdqiz,1245; Rwds,3890; Ujma,5589; Tbzmo,1303;";
            string expected = "1245,58,2587,1563,136";

            string result = Calculator.GetDistances(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string input = "Vgdfz,70; Mgknxpi,3958; Nsptghk,2626; Wuzp,2559; Jcdwi,3761;";
            string expected = "70,2489,67,1135,197";

            string result = Calculator.GetDistances(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string input = "Yvnzjwk,5363; Pkabj,5999; Xznvb,3584; Jfksvx,1240; Inwm,5720;";
            string expected = "1240,2344,1779,357,279";

            string result = Calculator.GetDistances(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            string input = "Ramytdb,2683; Voclqmb,5236;";
            string expected = "2683,2553";

            string result = Calculator.GetDistances(input);

            Assert.AreEqual(expected, result);
        }
    }
}
