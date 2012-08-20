namespace Skight.LightWeb.Presentation.Web.FrontController
{
    public interface CommandResolver
    {
        Command get_command_to_process(WebRequest request);
    }
}