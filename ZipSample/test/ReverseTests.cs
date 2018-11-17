﻿using ExpectedObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ZipSample.test
{
    [TestClass]
    public class ReverseTests
    {
        [TestMethod]
        public void reverse_string()
        {
            var source = new[] { "Apple", "Banana", "Cat" };

            var actual = source.MyReverse().ToList();
            var expected = new List<string> { "Cat", "Banana", "Apple" };

            expected.ToExpectedObject().ShouldEqual(actual);
        }
    }
}