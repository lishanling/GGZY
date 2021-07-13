using GGZY.Core.Extensions;
using GGZY.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace GGZY.YDPB
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
            
            
        }
        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            if (HttpContext.Current.Request.HttpMethod == "OPTIONS")
            {
                HttpContext.Current.Response.StatusCode = 200;
                HttpContext.Current.Response.End();
            }
        }
       
        public override void Init()
        {
            //ע���¼�
            this.AuthenticateRequest += WebApiApplication_AuthenticateRequest;
            base.Init();
        }

        //����session֧��
        void WebApiApplication_AuthenticateRequest(object sender, EventArgs e)
        {
            //���� webapi ֧��session �Ự
            HttpContext.Current.SetSessionStateBehavior(System.Web.SessionState.SessionStateBehavior.Required);
        }

        protected void Application_PreSendRequestHeaders(object sender, EventArgs e)
        {
            HttpApplication app = sender as HttpApplication;
            if (app != null && app.Context != null)
            {
                //�Ƴ�Server
                app.Context.Response.Headers.Remove("Server");
                //�޸�Server��ֵ
                //app.Context.Response.Headers.Set("Server", "MyPreciousServer");

                //�Ƴ�X-AspNet-Version��������Ч��һ��
                app.Context.Response.Headers.Remove("X-AspNet-Version");

                //�Ƴ�X-AspNetMvc-Version��������Ч��һ��
                app.Context.Response.Headers.Remove("X-AspNetMvc-Version");
            }
        }
    }
}
