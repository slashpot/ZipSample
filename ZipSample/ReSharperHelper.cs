using JetBrains.Annotations;

namespace CustomSourceTemplate
{
    public static class JoeySourceTemplates
    {
        [SourceTemplate]
        public static void ae<T>(this T source)
        {
            /*$ Assert.AreEqual( $END$ , source);*/
        }

        [SourceTemplate]
        public static void abs<T>(this T source)
        {
            /*$ Math.Abs(source)*/
        }
    }
}

