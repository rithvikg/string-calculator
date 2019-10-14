using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace string_calculator.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Requirement1()
        {
            var sc = new Calculator("20");
            var res = sc.CalculateNumbers();
            Assert.AreEqual(res, 20);

            sc.SetInput("1,2");
            res = sc.CalculateNumbers();
            Assert.AreEqual(res, 3);

            sc.SetInput("5,ttyt");
            res = sc.CalculateNumbers();
            Assert.AreEqual(res, 5);
        }

        [TestMethod]
        public void Requirement2()
        {
            var sc = new Calculator("1,2,3,4,5,6,7,8,9,10,11,12");
            var res = sc.CalculateNumbers();
            Assert.AreEqual(res, 78);

            sc.SetInput("5,4,3");
            res = sc.CalculateNumbers();
            Assert.AreEqual(res, 12);

        }

        [TestMethod]
        public void Requirement3()
        {
            var sc = new Calculator("1\\n2,3");
            var res = sc.CalculateNumbers();
            Assert.AreEqual(res, 6);

        }

        [TestMethod]
        public void Requirement4()
        {
      
            try
            {
                var sc = new Calculator("1\\n2,-3");
                var res = sc.CalculateNumbers();
                Assert.Fail("no exception thrown");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is System.Exception);
            }
        }

        [TestMethod]
        public void Requirement5()
        {
            var sc = new Calculator("2,1001,6");
            var res = sc.CalculateNumbers();
            Assert.AreEqual(res, 8);

            sc.SetInput("2,1000,1");
            res = sc.CalculateNumbers();
            Assert.AreEqual(res, 3);
        }

        [TestMethod]
        public void Requirement6()
        {
            var sc = new Calculator("//#\\n2#5");
            var res = sc.CalculateNumbers();
            Assert.AreEqual(res, 7);

            sc.SetInput("//y\\n2yff,100");
            res = sc.CalculateNumbers();
            Assert.AreEqual(res, 102);

            sc.SetInput("//,\\n2,ff,100");
            res = sc.CalculateNumbers();
            Assert.AreEqual(res, 102);
        }

        [TestMethod]
        public void Requirement7()
        {
            var sc = new Calculator("//[***]\\n11***22***33");
            var res = sc.CalculateNumbers();
            Assert.AreEqual(res, 66);

            sc.SetInput("//[test]\\n1test22***33test2");
            res = sc.CalculateNumbers();
            Assert.AreEqual(res, 3);

        }
        [TestMethod]
        public void Requirement8()
        {
            var sc = new Calculator("//[*][!!][r9r]\\n11r9r22*hh*33!!44");
            var res = sc.CalculateNumbers();
            Assert.AreEqual(res, 110);

            sc.SetInput("//[test][***]\\n1test22***33test2");
            res = sc.CalculateNumbers();
            Assert.AreEqual(res, 58);

        }

        [TestMethod]
        public void StrecthGoal1()
        {
            var sc = new Calculator("2,,4,rrrr,1001,6");
            var res = sc.CalculateNumbers();
            Assert.AreEqual(res, 12);

        }
    }
}
