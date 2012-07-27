namespace Skight.LightWeb.Domain
{
    public class Container
    {
        public static T get<T>()
        {
            return default(T);
        } 
    }
}