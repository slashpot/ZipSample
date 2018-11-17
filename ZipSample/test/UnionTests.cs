using ExpectedObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace ZipSample.test
{
    [TestClass]
    public class UnionTests
    {
        [TestMethod]
        public void Union_integers()
        {
            var first = new List<int> { 1, 3, 5 };
            var second = new List<int> { 5, 3, 7, 9 };

            var expected = new List<int> { 1, 3, 5, 7, 9 };

            var actual = MyUnion(first, second).ToList();
            expected.ToExpectedObject().ShouldEqual(actual);
        }

        private IEnumerable<int> MyUnion(IEnumerable<int> first, IEnumerable<int> second)
        {
            var hashset = new HashSet<int>();

            var enumerator = first.GetEnumerator();
            while (enumerator.MoveNext())
            {
                if (hashset.Add(enumerator.Current))
                {
                    yield return enumerator.Current;
                }
            }

            var enumerator1 = second.GetEnumerator();
            while (enumerator1.MoveNext())
            {
                if (hashset.Add(enumerator1.Current))
                {
                    yield return enumerator1.Current;
                }
            }
        }
    }
}