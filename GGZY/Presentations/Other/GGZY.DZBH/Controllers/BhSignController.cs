using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GGZY.Core.Log;
using GGZY.Framework.Controllers;
using GGZY.Services.DZBH.ParamModel;
using GGZY.Services.Infrastructure;
using GGZY.Services.Infrastructure.Model;
using GGZYFW.DbEntity;

namespace GGZY.DZBH.Controllers
{
    [AllowAnonymous]
    public class BhSignController : BaseController
    {
        /// <summary>
        /// 创建申请单pdf
        /// </summary>
        /// <param name="model">申请信息</param>
        /// <param name="mobile">手机号验证码</param>
        /// <param name="code">验证码</param>
        /// <returns></returns> 
        public ActionResult CreateApplicationPdf(BH_SEND_APPLICATION_FORM model, string mobile, string code)
        {
            //验证短信验证码
            var r = SmsModel.ValidateMobileCode(mobile, code);
            if (!r.Success)
            {
                return JResult(r);
            }
            string temPath = "/SignTemp/SQDTEMP.docx";
            return JResult(Fw.BhSignService.CreateApplicationPdf(model, temPath));
        }
        /// <summary>
        /// 创建调用签章客户端的链接
        /// </summary>
        /// <param name="attachmentId"></param>
        /// <returns></returns>
        public ActionResult CreateSignUrl(string attachmentId)
        {
            return JResult(Fw.BhSignService.CreateSignUrl(attachmentId));
        }
        /// <summary>
        /// 签章客户端的回调地址
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        [AllowAnonymous]
        public ActionResult UpLoadSign(SignParamModel param)
        {
            //Logger.Debug("签章回调收到");
            HttpFileCollectionBase files = HttpContext.Request.Files;
            var r = Fw.BhSignService.UpLoadSign(files, param);
            var result = new Hashtable();
            if (r.Success)
            {
                result["status"] = 1;
                result["msg"] = "签章成功";
            }
            else
            {
                result["status"] = 0;
                result["msg"] = "签章失败,原因：" + r.Msg;
            }
            Logger.Debug($"返回信息{result["msg"]}");
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 获取签章结果
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult GetSignResult(string id)
        {
            return JResult(Fw.BhSignService.GetSignResult(id));
        }
    }
}