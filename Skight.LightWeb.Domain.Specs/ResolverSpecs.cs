using System;
using System.Collections.Generic;
using System.Reflection;
using Machine.Specifications;
using Machine.Specifications.AutoMocking.Moq;
using Machine.Specifications.Model;

namespace Skight.LightWeb.Domain.Specs
{
    public class ResolverSpecs
    {
        private Establish context =
            () =>
                {
                    var dictioary = new Dictionary<Type, object>();
                    dictioary.Add(typeof (MockInterface), new MockImplementaion());
                    subject = new ResolverImpl(dictioary);
                };

       private It Container_get_by_interface_should_return_its_implementation_class =
            () => subject.get<MockInterface>().ShouldBeOfType<MockImplementaion>();

        private static ResolverImpl subject;
        private interface MockInterface { }
        private class MockImplementaion : MockInterface { }
        
    }

    
}