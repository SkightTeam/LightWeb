using System;
using System.Collections.Generic;

namespace Skight.LightWeb.Domain
{
    public class RegistrationImpl:Registration
    {
        private IDictionary<Type, DiscreteItemResolver> item_resolvers;
        public RegistrationImpl(IDictionary<Type, DiscreteItemResolver> item_resolvers)
        {
            this.item_resolvers = item_resolvers;
        }

        public void register<Contract, Implementation>() where Implementation : Contract, new()
        {
            
            item_resolvers.Add(typeof(Contract), new MockResolverImpl<Implementation>());
        }

        private class MockResolverImpl<Implementation>:DiscreteItemResolver
            where Implementation :new()
        {
            public object resolve()
            {
                return new Implementation();
            }
        }
    }


}