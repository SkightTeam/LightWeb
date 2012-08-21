using System.Web;

namespace Skight.LightWeb.Presentation.Web.FrontController
{
    public class WebRequestAdapter
    {
        public virtual WebRequest create_from(HttpContext context)
        {
            return new WebRequestImpl();
        }
    }
}