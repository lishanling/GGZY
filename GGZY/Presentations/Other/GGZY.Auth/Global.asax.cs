using System;
using System.IO;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using Newtonsoft.Json.Linq;

namespace GGZY.Auth
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            //BundleConfig.RegisterBundles(BundleTable.Bundles);
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

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            HttpApplication app = (HttpApplication)sender;
            //var inputString = app.Request.InputStream.StreamToString(false);
            //if (inputString.CheckSqlStr())
            //{
            //    inputString = inputString.FilterSql();
            //    //app.Request.InputStream.
            //    using (StreamWriter sw = new StreamWriter(app.Request.InputStream))
            //    {
            //        sw.Write(inputString);
            //        sw.Flush();
            //        app.Request.InputStream.Seek(0, SeekOrigin.Begin);
            //    }
            //}
            
            //var rawUrl = app.Request.RawUrl;
            //if (rawUrl.IndexOf("test", StringComparison.CurrentCultureIgnoreCase) > -1)
            //{
            //    var key = "tbType";
            //    var tbName = string.Empty;
            //    var inputStream = app.Request.InputStream.StreamToString(Encoding.UTF8);
            //    JObject jobject = JObject.Parse(inputStream);
            //    if (jobject?.Property(key) != null && jobject.Property(key).HasValues)
            //    {
            //        tbName = (string)jobject[key];
            //    }

            //    if (!string.IsNullOrWhiteSpace(tbName))
            //    {
            //        var url = rawUrl.Replace("test", $"generic/{tbName}").Replace(app.Request.ApplicationPath,"").TrimStart('/');
            //        HttpContext.Current.RewritePath(url);
            //    }
            //}
        }
    }
}
