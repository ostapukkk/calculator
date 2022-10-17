using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using calculator;

namespace test_calc
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Sum_5and4retern9()
        {
           // test example with inrut data

            int dn1 = 5, dn2 = 4;

            int excpected = 9;

            Form1 f = new Form1();

            int actual=  f.test_m(dn1, dn2);

            Assert.AreEqual(excpected, actual, "test is not correct");
                               
        }

        [TestMethod]
        public void Minus_5and4retern1()
        {
            // test example with inrut data

            int dn1 = 5, dn2 = 4;

            int excpected = 1;

            Form1 f = new Form1();

            int actual = f.test_m1(dn1, dn2);

            Assert.AreEqual(excpected, actual, "test is not correct");

        }

        [TestMethod]
        public void Umnozhenie_5and4retern20()
        {
            // test example with inrut data

            int dn1 = 5, dn2 = 4;

            int excpected = 20;

            Form1 f = new Form1();

            int actual = f.test_m2(dn1, dn2);

            Assert.AreEqual(excpected, actual, "test is not correct");

        }
        [TestMethod]
        public void Delenie_20and5retern4()
        {
            // test example with inrut data

            int dn1 = 20, dn2 = 5;

            int excpected = 4;

            Form1 f = new Form1();

            int actual = f.test_m3(dn1, dn2);

            Assert.AreEqual(excpected, actual, "test is not correct");

        }
    }
}
