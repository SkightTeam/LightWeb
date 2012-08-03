using System;
using System.Collections.Generic;
using Skight.LightWeb.Domain;


namespace Skight.LightWeb.Application.Startup
{
    public class ApplicationStartup
    {
        public void run()
        {
            IDictionary<Type, object> item_resolvers = new Dictionary<Type, object>();
            var registration = new RegistrationImpl(item_resolvers);
            Container.initialize_with(new ResolverImpl(item_resolvers));
            registration.register<Repository,RepositoryImpl>();
        }

        /// <summary>
        /// Test purpose class an interface
        /// </summary>
        public interface Repository { }
        public class RepositoryImpl : Repository { }
    }
}