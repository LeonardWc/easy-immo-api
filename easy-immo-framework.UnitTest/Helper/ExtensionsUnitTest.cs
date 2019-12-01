using easy_immo_framework.Helper;
using NUnit.Framework;
using System;

namespace easy_immo_framework.UnitTest.Helper
{
    internal class ExtensionsUnitTest
    {
        [Test]
        public void ToDate()
        {
            Assert.AreEqual(DateTime.MinValue, "".ToDate());
            Assert.AreEqual(DateTime.MinValue, "sdfsdfs".ToDate());
            Assert.AreEqual(DateTime.MinValue, "2018-28-12".ToDate());
            Assert.AreEqual(new DateTime(2018, 12, 15), "2018-12-15".ToDate());
        }

        [Test]
        public void ToInteger()
        {
            Assert.AreEqual(0, "".ToInteger());
            Assert.AreEqual(0, "sdfsdfs".ToInteger());
            Assert.AreEqual(0, "2.8".ToInteger());
            Assert.AreEqual(0, "2,5".ToInteger());
            Assert.AreEqual(8, "8".ToInteger());
        }

        [Test]
        public void ToDouble()
        {
            Assert.AreEqual(0, "".ToDouble());
            Assert.AreEqual(0, "sdfsdfs".ToDouble());
            Assert.AreEqual(4.8, "4.8".ToDouble());
            Assert.AreEqual(4.5, "4,5".ToDouble());
            Assert.AreEqual(10, "10".ToDouble());
        }
    }
}