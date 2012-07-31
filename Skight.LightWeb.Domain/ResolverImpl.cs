using System;
using System.Collections.Generic;

namespace Skight.LightWeb.Domain
{
    public class ResolverImpl:Resolver
    {
        private readonly IDictionary<Type, object> item_resolvers;

        public ResolverImpl(IDictionary<Type, object> itemResolvers)
        {
            item_resolvers = itemResolvers;
        }

        public Dependency get<Dependency>()
        {
            return (Dependency) item_resolvers[typeof (Dependency)];
        }
    }
}