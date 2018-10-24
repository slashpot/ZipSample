using System.Collections.Generic;

namespace ZipSample.test
{
    public class Repository
    {
        public static IEnumerable<Girl> Get3Girls()
        {
            yield return new Girl { Age = 18, Name = "Jean" };
            yield return new Girl { Age = 20, Name = "Mary" };
            yield return new Girl { Age = 23, Name = "Karen" };
        }

        public static IEnumerable<Girl> Get5Girls()
        {
            yield return new Girl { Age = 18, Name = "Jean" };
            yield return new Girl { Age = 20, Name = "Mary" };
            yield return new Girl { Age = 23, Name = "Karen" };
            yield return new Girl { Age = 43, Name = "Sharon" };
            yield return new Girl { Age = 33, Name = "Vivian" };
        }

        public static IEnumerable<Key> Get5Keys()
        {
            yield return new Key { OwnerBoy = new Boy { Name = "Joey" } };
            yield return new Key { OwnerBoy = new Boy { Name = "Frank" } };
            yield return new Key { OwnerBoy = new Boy { Name = "Bob" } };
            yield return new Key { OwnerBoy = new Boy { Name = "David" } };
            yield return new Key { OwnerBoy = new Boy { Name = "Tom" } };
        }

        public static IEnumerable<Key> Get3Keys()
        {
            yield return new Key { OwnerBoy = new Boy { Name = "Joey" } };
            yield return new Key { OwnerBoy = new Boy { Name = "Frank" } };
            yield return new Key { OwnerBoy = new Boy { Name = "Bob" } };
        }
    }
}