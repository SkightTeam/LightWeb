using Machine.Specifications;

namespace Skight.LightWeb.Domain.Specs
{
    public class ContainerSpecs
    {
       private It Container_get_by_interface_should_return_its_implementation_class =
            () => Container.get<IMockInterface>().ShouldBeOfType<MockImplementaion>();

        private interface IMockInterface { }
        private class MockImplementaion : IMockInterface { }
    }

    
}