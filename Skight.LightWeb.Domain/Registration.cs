namespace Skight.LightWeb.Domain
{
    public interface Registration
    {
        void register<Contract, Implementaion>() where Implementaion : Contract;
    }
}