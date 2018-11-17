using System;
using System.Collections;
using System.Collections.Generic;

namespace ZipSample
{
    public static class MyLinq
    {
        public static IEnumerable<T> MyConcat<T>(this IEnumerable<T> first, IEnumerable<T> second)
        {
            var firstEnu = first.GetEnumerator();
            var secondEnu = second.GetEnumerator();

            while (firstEnu.MoveNext())
            {
                yield return firstEnu.Current;
            }
            while (secondEnu.MoveNext())
            {
                yield return secondEnu.Current;
            }
        }

        public static IEnumerable<TSource> MyReverse<TSource>(this IEnumerable<TSource> source)
        {
            return new Stack<TSource>(source);
        }

        public static IEnumerable<int> MyOfType(this ArrayList source)
        {
            var enumerator = source.GetEnumerator();
            while (enumerator.MoveNext())
            {
                if (enumerator.Current is int i)
                {
                    yield return i;
                }
            }
        }

        public static IEnumerable<TResult> MyCast<TResult>(this IEnumerable arrayList)
        {
            var enumerator = arrayList.GetEnumerator();
            while (enumerator.MoveNext())
            {
                if (enumerator.Current is TResult result)
                {
                    yield return result;
                }
                else
                {
                    throw new MyException();
                }
            }
        }

        public static IEnumerable<Tuple<string, string>> MyZip(this IEnumerable<Girl> girls, IEnumerable<Key> keys)
        {
            var girlEnumerator = girls.GetEnumerator();
            var keyEnumerator = keys.GetEnumerator();
            while (girlEnumerator.MoveNext() && keyEnumerator.MoveNext())
            {
                yield return new Tuple<string, string>(girlEnumerator.Current.Name, keyEnumerator.Current.OwnerBoy.Name);
            }
        }
    }
}