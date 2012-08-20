using System.Web;

namespace Skight.LightWeb.Presentation.Web.FrontController
{
    public class BasicHttpHandler:IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            throw new System.NotImplementedException();
        }

        public bool IsReusable
        {
            get {return true; }
        }
    }
}