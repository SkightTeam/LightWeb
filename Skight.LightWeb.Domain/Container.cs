namespace Skight.LightWeb.Domain
{
    public class Container
    {
        private static Resolver underlying_resolver;
        public static T get<T>()
        {
            return underlying_resolver.get<T>();
        }

        public static void initialize_with(Resolver resolver)
        {
            underlying_resolver = resolver;
        }
    }
}