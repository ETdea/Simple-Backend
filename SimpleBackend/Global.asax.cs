using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace SimpleBackend
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            DatabaseConfig.RegisterDbContext();
        }

        //void Application_Error(object sender, EventArgs e)
        //{
        //    // 發生未處理錯誤時執行的程式碼

        //    var error = Server.GetLastError();
        //    Server.Transfer("~/error.html");
        //}

        //protected void Application_Error(object sender, EventArgs e)
        //{
        //    Exception exception = Server.GetLastError();
        //    Response.Clear();

        //    HttpException httpException = exception as HttpException;

        //    string action = string.Empty;

        //    if (httpException != null)
        //    {
        //        switch (httpException.GetHttpCode())
        //        {
        //            case 404:
        //                // page not found 
        //                action = "NotFound";
        //                break;
        //            //TODO: handle other codes
        //            default:
        //                action = "general-error";
        //                break;
        //        }
        //    }
        //    else
        //    {
        //        //TODO: Define action for other exception types
        //        action = "general-error";
        //    }

        //    Server.ClearError();

        //    string culture = Thread.CurrentThread.CurrentCulture.Name;

        //    Exception exception = Server.GetLastError();
        //    Response.Redirect(String.Format("~/{0}/error/{1}", culture, action));
        //}
    }
}
