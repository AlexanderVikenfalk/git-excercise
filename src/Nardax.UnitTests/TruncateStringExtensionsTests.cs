﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Nardax.Tests
{
    [TestClass]
    public class TruncateStringExtensionsTests
    {
        private string _value;

        [TestInitialize]
        public void TestInitialize()
        {
            _value = "123456789";
        }

        [TestMethod]
        public void TruncateLeft_ValueIsLarger_TruncateRemovesLeftSide()
        {
            var expected = "9";

            var result = _value.TruncateLeft(1);
            
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TruncateLeft_ValueIsSmaller_TruncateRemovesLeftSide()
        {
            var expected = "123456789";

            var result = _value.TruncateLeft(20);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void RemoveWhiteChars()
        {
            var testString = "I\twill \tsurvive\t";

            var result = testString.RemoveWhiteChars();
            var expected = "Iwillsurvive";

            Assert.AreEqual(expected, result);

        }
 // Test
        [TestMethod]
        public void RepeatMe()
        {
            var expected = "käbbelkäbbelkäbbel";
            var result = "käbbel".RepeatMe(3);

            Assert.AreEqual(expected, result);
        }
    }
}
