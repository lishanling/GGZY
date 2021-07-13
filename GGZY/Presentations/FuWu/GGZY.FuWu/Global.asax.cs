using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using GGZY.Core.Extensions;
using GGZY.Core.Models;

namespace GGZY.FuWu
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            MvcHandler.DisableMvcResponseHeader = true;
        }
        /// <summary>
        /// 全局异常捕获
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Application_Error(object sender, EventArgs e)
        {
            HttpApplication app = (HttpApplication)sender;
            var exception = app.Server.GetLastError();
            if (exception != null)
            {
                var result = new GeneralResult();
                result.SetException($"{exception.Message}", exception);
                var content = result.Serializer();
                app.Server.ClearError();
                app.Response.Clear();
                app.Response.Headers.Remove("Server");
                app.Response.Headers.Remove("X-AspNet-Version");
                app.Response.Headers.Remove("X-AspNetMvc-Version");
                app.Response.Headers.Remove("X-Powered-By");
                app.Response.Write(content);
                app.Response.End();
            }
        }
    }
}
