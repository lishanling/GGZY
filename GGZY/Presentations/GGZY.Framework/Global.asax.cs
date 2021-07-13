using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using GGZY.Core.Extensions;
using GGZY.Core.Models;

namespace GGZY.Framework
{
    public class MvcApplication : System.Web.HttpApplication
    {
       
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
                app.Response.Write(content);
                app.Response.End();
            }
        }
    }
}