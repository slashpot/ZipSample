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

        public static IEnumerable<TResult> MyZip<TFirst,TSecond,TResult>(IEnumerable<TFirst> girls, IEnumerable<TSecond> keys, Func<TFirst, TSecond, TResult> selector)
        {
            var girlEnumerator = girls.GetEnumerator();
            var keyEnumerator = keys.GetEnumerator();
            while (girlEnumerator.MoveNext() && keyEnumerator.MoveNext())
            {
                var secondElement = keyEnumerator.Current;
                var firstElement = girlEnumerator.Current;
                yield return  selector(firstElement, secondElement);
            }
        }

        public static IEnumerable<Tuple<string,string>> MyZip(IEnumerable<Key> keys, IEnumerable<Girl>girls)
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