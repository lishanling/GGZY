using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Filters;
using GGZY.Core.Log;
using GGZY.Core.Models;

namespace GGZY.Framework.Infrastructure.Filters
{
    /// <summary>
    /// 错误 捕获
    /// </summary>
    public class ApiExceptionFilterAttribute:ExceptionFilterAttribute
    {
        /// <summary>
        /// 错误处理
        /// </summary>
        /// <param name="actionExecutedContext"></param>
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            var action = actionExecutedContext.ActionContext.ActionDescriptor.ActionName;
            var controller = actionExecutedContext.ActionContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            var p = actionExecutedContext.Request.Content.ReadAsStringAsync().Result;
            Logger.Fatal($"API FATAL:{controller}/{action}?{p}", actionExecutedContext.Exception);
            actionExecutedContext.Response = actionExecutedContext.Request.CreateResponse(HttpStatusCode.OK, new
            {
                State= GeneralResultState.InternalServerError,
                Success =false,
                Msg=actionExecutedContext.Exception.Message
            });
            base.OnException(actionExecutedContext);
        }
    }
}