using System.Collections;

namespace ZipSample
{
    public class Key
    {
        public Boy OwnerBoy { get; set; }
    }

    public class Boy
    {
        public string Name { get; set; }
    }

    public class Girl
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}