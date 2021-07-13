using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using GGZY.Core.Extensions;
using GGZY.Core.Models;

namespace GGZY.BigData.GCJS
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
        }
        protected void Application_Error(object sender, EventArgs e)
        {
            HttpApplication app = (HttpApplication)sender;
            var exception = app.Server.GetLastError();
            if (exception != null)
            {
                var result = new GeneralResult();
                result.SetException($"{exception.Message}", exception);
                var content = result.Serializer();

                var datauuid = Guid.NewGuid().ToString();
                GGZY.Core.Log.LoggerR.Error(datauuid, exception.Message, exception);
                while (exception.InnerException != null)
                {
                    exception = exception.InnerException;
                    GGZY.Core.Log.LoggerR.Error(datauuid, exception.Message, exception);
                }
                app.Server.ClearError();
                app.Response.Clear();
                app.Response.Write(content);
                app.Response.End();
            }
        }
        protected void Application_PreSendRequestHeaders(object sender, EventArgs e)
        {
            HttpApplication app = sender as HttpApplication;
            if (app != null && app.Context != null)
            {
                //移除Server
                app.Context.Response.Headers.Remove("Server");
                //修改Server的值
                //app.Context.Response.Headers.Set("Server", "MyPreciousServer");

                //移除X-AspNet-Version，和上面效果一样
                app.Context.Response.Headers.Remove("X-AspNet-Version");

                //移除X-AspNetMvc-Version，和上面效果一样
                app.Context.Response.Headers.Remove("X-AspNetMvc-Version");
            }
        }
    }
}
