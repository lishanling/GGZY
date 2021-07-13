using GGZY.Core.Models;
using GGZY.Services;
using GGZY.YDPB.Api.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace GGZY.YDPB.Api.Common
{
    public class ApiAuthorizeFilterAttribute : AuthorizeAttribute
    {
        /// <summary>
        /// 身份授权认证
        /// </summary>
        /// <param name="actionContext"></param>
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            //var controller = (actionContext.Request.GetRouteData().Values["controller"] ?? "").ToString();
            //var action = (actionContext.Request.GetRouteData().Values["action"] ?? "").ToString();
            var result = new GeneralResult();
            if (!AllowAnonymous(actionContext) && actionContext.Request.Method != HttpMethod.Options)
            {
                var data = actionContext.Request.Content.ReadAsStringAsync().Result;
                if (String.IsNullOrWhiteSpace(data))
                {
                    result.SetFail("提交数据为空");
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.OK, result);
                    return;
                }
                RequestModel model ;
                try
                {
                    model = JsonConvert.DeserializeObject<RequestModel>(data);
                }
                catch (Exception ex)
                {
                    result.SetFail("提交数据非标准JSON格式");
                    GGZY.Core.Log.LoggerR.Error(Guid.NewGuid().ToString("N"),"提交数据非标准JSON格式:" + ex.Message + "\r\n，提交数据:" + data + "\r\n", ex);
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.OK, result);
                    return;
                }
                if(null ==model.validation)
                {
                    result.SetFail("认证信息缺失");
                    GGZY.Core.Log.LoggerR.Error(model.validation.DATAUUID,"认证信息缺失，提交数据:" + data );
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.OK, result);
                    return;
                }
                var SYSTEM_NO = model.validation.SYSTEM_NO;
                var dataMd5 = GGZY.Core.Utils.CommonUtils.Md5Str(model.data == null ? "" : JsonConvert.SerializeObject(model.data));
                var systemInfo = GlobalDataService.Instance.CenterList.Where(w => w.SYSTEM_NO == SYSTEM_NO).FirstOrDefault()?.PRIVATE_KEY;
                if(String.IsNullOrEmpty(systemInfo))
                {
                    result.SetFail("TOKEN认证失败:未找到" + SYSTEM_NO + " 对应的密钥信息");
                    GGZY.Core.Log.LoggerR.Error(model.validation.DATAUUID, "未找到 "+ SYSTEM_NO + " 对应的密钥信息" + "，提交数据:" + data );
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.OK, result);
                    return;
                }
                var validationToken = (model.validation.SYSTEM_NO + model.validation.DATAUUID + model.validation.TIME + dataMd5).CreateToken(systemInfo);
                if(model.validation.TOKEN != validationToken)
                {
                    result.SetFail("TOKEN认证失败");
                    GGZY.Core.Log.LoggerR.Error(model.validation.DATAUUID,"TOKEN认证失败，提交数据:" + data + ",认证TOKEN值："+validationToken);
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.OK, result);
                    return;
                }
                if (!GlobalDataService.Instance.DIC_Trade_INFO.ContainsKey(SYSTEM_NO))
                {
                    result.SetFail("SYSTEM_NO信息错误");
                    GGZY.Core.Log.LoggerR.Error(model.validation.DATAUUID, "SYSTEM_NO信息错误，提交数据:" + data);
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.OK, result);
                }
                if(model.data == null)
                {
                    if (actionContext.Request.GetRouteData().Route.RouteTemplate != "api/hall")
                    {
                        result.SetFail("数据集信息缺失");
                        GGZY.Core.Log.LoggerR.Error(model.validation.DATAUUID, "数据集信息缺失，提交数据:" + data);
                        actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.OK, result);
                        return;
                    }
                    return;
                }
                if (! actionContext.Request.RequestUri.AbsolutePath.ToLower().Contains("/api/hall") && !actionContext.Request.RequestUri.AbsolutePath.ToLower().Contains("/api/seatcheck"))
                {
                    var areacode = model.data["AREA_CODE"];
                    if (null == areacode)
                    {
                        result.SetFail("数据集缺少 AREA_CODE 信息");
                        GGZY.Core.Log.LoggerR.Error(model.validation.DATAUUID, "数据集缺少 AREA_CODE 信息，提交数据:" + data);
                        actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.OK, result);
                    }
                    if (GlobalDataService.Instance.DIC_Trade_INFO[SYSTEM_NO].ToString() != areacode.ToString())
                    {
                        result.SetFail("交易中心编码 AREA_CODE 错误:AREA_CODE 与 SYSTEM_NO信息不匹配");
                        GGZY.Core.Log.LoggerR.Error(model.validation.DATAUUID, "交易中心编码 AREA_CODE 错误:AREA_CODE 与 SYSTEM_NO信息不匹配，提交数据:" + data);
                        actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.OK, result);
                    }
                }

            }
            base.IsAuthorized(actionContext);
            

        }
        /// <summary>
        /// 允许匿名用户
        /// </summary>
        /// <param name="actionContext"></param>
        /// <returns></returns>
        private static bool AllowAnonymous(HttpActionContext actionContext)
        {
            var allowanonymous = true;
            //#if !DEBUG
            allowanonymous = actionContext.ActionDescriptor.GetCustomAttributes<AllowAnonymousAttribute>(true).Any()
                            || actionContext.ActionDescriptor.ControllerDescriptor.GetCustomAttributes<AllowAnonymousAttribute>(true).Any()
                            || (actionContext.Request.Properties.ContainsKey("AllowAnonymous") && DateTime.Now.ToString("yyyyMMddHHmm") == actionContext.Request.Properties["AllowAnonymous"]?.ToString());
            //#endif
            return allowanonymous;
        }
    }
}