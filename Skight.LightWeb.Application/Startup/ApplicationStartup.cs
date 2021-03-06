﻿using System;
using System.Collections.Generic;
using Skight.LightWeb.Domain;
using Skight.LightWeb.Presentation.Web.FrontController;


namespace Skight.LightWeb.Application.Startup
{
    public class ApplicationStartup
    {
        public void run()
        {
            IDictionary<Type, DiscreteItemResolver> item_resolvers = new Dictionary<Type, DiscreteItemResolver>();
            Container.initialize_with(new ResolverImpl(item_resolvers));
            var registration = new RegistrationImpl(item_resolvers);
            registration.register<Repository,RepositoryImpl>();
            registration.register<FrontController,FrontControllerImpl>();
            registration.register<CommandResolver,CommandResolverImpl>();
            
        }

        /// <summary>
        /// Test purpose class an interface
        /// </summary>
        public interface Repository { }
        public class RepositoryImpl : Repository { }
    }
}