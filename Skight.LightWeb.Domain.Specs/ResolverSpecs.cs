using System;
using System.Collections.Generic;
using Machine.Specifications;

namespace Skight.LightWeb.Domain.Specs
{
    public class When_bind_a_class_to_a_intefercate
    {
        private Establish context =
            () =>
                {
                    var dictioary = new Dictionary<Type, object>();
                    dictioary.Add(typeof (MockInterface), new MockImplementaion());
                    subject = new ResolverImpl(dictioary);
                };

       private It should_resolve_the_interface_to_the_class =
            () => subject.get<MockInterface>().ShouldBeOfType<MockImplementaion>();

        private static ResolverImpl subject;
        private interface MockInterface { }
        private class MockImplementaion : MockInterface { }
        
    }

    
}