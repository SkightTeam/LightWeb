using Machine.Specifications;

namespace Skight.LightWeb.Domain.Specs
{
    public class DependencyIntegrationSpecs
    {
        private Because of =
            () => service = Container.get<StubService>();

        private It should_inject_repository_into_service =
            () => service.Repository.ShouldBeOfType<StubRepositoryImpl>();

        private It inject_repository_should_not_be_null =
            () => service.Repository.ShouldNotBeNull();
             
        private static StubService service;
    }

    public interface StubService
    {
        StubRepository Repository { get; } 
    }

    public class StubServiceImpl : StubService
    {
        private StubRepository repository;

        public StubServiceImpl(StubRepository repository)
        {
            this.repository = repository;
        }

        public StubRepository Repository
        {
            get { return repository; }
        }
    }
    public interface StubRepository
    {
        
    }
    public class StubRepositoryImpl:StubRepository
    {
        
    }

}