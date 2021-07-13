using GGZY.Core.Infrastructure;
using GGZY.Framework.Infrastructure.Filters;
using GGZY.YDPB.Api.App_Start;
using GGZY.YDPB.Api.Common;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace GGZY.YDPB.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API 配置和服务

            // Web API 路由
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.Filters.Add(new ApiExceptionFilterAttribute());
            //config.Filters.Add(new ApiSqlFilter());
            config.Filters.Add(new OperateTrackAttribute());
            //config.Formatters.Clear();
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            config.Formatters.Add(new FormUrlEncodedMediaTypeFormatter());
            config.Formatters.Add(new JsonMediaTypeFormatter());

            var jsonFormatter = new JsonMediaTypeFormatter();
            jsonFormatter.SerializerSettings.Converters.Add(new DBNullCreationConverter());
            jsonFormatter.SerializerSettings.Converters.Add(new Newtonsoft.Json.Converters.IsoDateTimeConverter()
            {
                DateTimeFormat = "yyyyMMddHHmmss"
            });
            //jsonFormatter.SerializerSettings.Converters.Add(new Core.Converters.JsonZeroConverter());
            jsonFormatter.SerializerSettings.Converters.Add(new DecimalConverter());
            jsonFormatter.SerializerSettings.ContractResolver = new DefaultContractResolver();
            //jsonFormatter.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
            jsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;//解决json序列化时的循环引用问题
            config.Services.Replace(typeof(IContentNegotiator), new JsonContentNegotiator(jsonFormatter));

            config.Filters.Add(new Common.ApiAuthorizeFilterAttribute());
        }
    }
}
