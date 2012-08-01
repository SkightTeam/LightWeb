using System;
using System.Collections.Generic;

namespace Skight.LightWeb.Domain
{
    public class RegistrationImpl:Registration
    {
        private IDictionary<Type, object> item_resolvers;
        public RegistrationImpl(IDictionary<Type, object> item_resolvers)
        {
            this.item_resolvers = item_resolvers;
        }

        public void register<Contract, Implementaion>() where Implementaion : Contract, new()
        {
            item_resolvers.Add(typeof(Contract), new Implementaion());
        }
    }
}