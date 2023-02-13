using Microsoft.VisualStudio.TestTools.UnitTesting;
using vstavka;
using System;

namespace UnitTesto
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestGenerata()
        {
            generate gener = new generate();
            int[] massa = gener.genMethod();
            Assert.IsNotNull(massa);
        }
        [TestMethod]
        public void TestMethod1()
        {
            int[] masOdyn = new int[] { 3, 81, 12, 51, 7, 94, 4, 33, 5, 92 };
            string expected = "3 4 5 7 12 33 51 81 92 94 ";
            Vstavkas sorter = new Vstavkas();
            string actual = sorter.sorta_vstavka(masOdyn);
            Assert.AreEqual(expected, actual);
        }
    }



    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] masOdyn = new int[] { 3, 81, 12, 51, 7, 94, 4, 33, 5, 92 };
            string expected = "3 4 5 7 12 33 51 81 92 94 ";
            Vstavkas sorter = new Vstavkas();
            string actual = sorter.sorta_vstavka(masOdyn);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void TestMethod2()
        {
            int[] masOdyn = new int[] { 3, 81, 12, 51, 7, 94, 4, 33, 5, 92 };
            string expected = "3 4 5 7 12 33 51 81 92 94 ";
            Obmene sorter = new Obmene();
            string actual = sorter.sorta_obmena(masOdyn);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int[] masOdyn = new int[] { 3, 81, 12, 51, 7, 94, 4, 33, 5, 92 };
            string expected = "3 4 5 7 12 33 51 81 92 94 ";
            Vybore sorter = new Vybore();
            string actual = sorter.sorta_vybora(masOdyn);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod1down()
        {
            int[] masOdyn = new int[] { 3, 81, 12, 51, 7, 94, 4, 33, 5, 92 };
            string expected = "94 92 81 51 33 12 7 5 4 3 ";
            Vstavkas sorter = new Vstavkas();
            string actual = sorter.sorta_vstavka_down(masOdyn);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2down()
        {
            int[] masOdyn = new int[] { 3, 81, 12, 51, 7, 94, 4, 33, 5, 92 };
            string expected = "94 92 81 51 33 12 7 5 4 3 ";
            Obmene sorter = new Obmene();
            string actual = sorter.sorta_obmena_down(masOdyn);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3down()
        {
            int[] masOdyn = new int[] { 3, 81, 12, 51, 7, 94, 4, 33, 5, 92 };
            string expected = "94 92 81 51 33 12 7 5 4 3 ";
            Vybore sorter = new Vybore();
            string actual = sorter.sorta_vybora_down(masOdyn);
            Assert.AreEqual(expected, actual);
        }
    }
}
