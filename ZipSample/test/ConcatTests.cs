using System;
using System.Collections.Generic;
using System.Linq;
using ExpectedObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ZipSample.test
{
    [TestClass]
    public class ConcatTests
    {

        [TestMethod]
        public void concat_integers()
        {
            var first = new[] {1, 3, 5};
            var second = new[] {2, 4, 6};

            var actual = first.MyConcat(second).ToArray();

            var expected = new[] {1, 3, 5, 2, 4, 6};
            expected.ToExpectedObject().ShouldEqual(actual);
        }

        [TestMethod]
        public void concat_employee()
        {
            var first = new List<Employee>()
            {
                new Employee(){Id=1,Name="Eric"}
            };

            var second = new List<Employee>()
            {
                new Employee(){Id=2,Name="Ben"}
            };
            var actual= first.MyConcat(second).ToList();
            var expected =new List<Employee>()
            {
                new Employee(){Id=1,Name="Eric"},
                new Employee(){Id=2,Name="Ben"}
            };
            expected.ToExpectedObject().ShouldEqual(actual);
        }
    }
}