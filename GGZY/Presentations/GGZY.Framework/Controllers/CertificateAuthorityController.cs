using System;
using System.Text;
using System.Web.Mvc;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Framework.Models;
using GGZY.Services.DZBH.ParamModel;
using GGZY.Services.Infrastructure.Model;

namespace GGZY.Framework.Controllers
{
    /// <summary>
    /// CA操作类
    /// </summary>
    [AllowAnonymous, PortalUnFilter]
    public class CertificateAuthorityController : BaseController
    {
        #region CA检测|登录

        /// <summary>
        /// 生成签名
        /// </summary>
        /// <returns></returns>
        public ActionResult GetRandomForSign()
        {
            var r = Fw.TUserService.GetRandomForSign();
            return JResult(r);
        }
        /// <summary>
        /// 检测CA类型
        /// </summary>
        /// <param name="ca"></param>
        /// <returns></returns>
        public ActionResult CheckType(CertificateAuthorityModel ca)
        {
            var r = ca.CheckCaType();
            return JResult(r);
        }

        public ActionResult GetCaInfo(CertificateAuthorityModel ca)
        {
            var r = ca.GetCaInfo();
            return JResult(r);
        }
        #endregion

        #region CA 客户端签章

        /// <summary>
        /// 初始化签章客户端的链接
        /// </summary>
        /// <param name="signType">签章类型 FJGGFWCAU 签章（旧版）FJGGFWCAUU 签章（统一CA）</param>
        /// <param name="path">待签章附件地址</param>
        /// <param name="name">文件名</param>
        /// <returns></returns>
        public ActionResult CaClientSign(string signType, string path,string name)
        {
            var callbackUrl = $"{Host}{Url.Action("CaClientSignCallback")}";
            var tuple = CertificateAuthorityModel.CaClientSignFunc(signType, callbackUrl, path, name);
            return JResult(new
            {
                SignUrl = tuple.Item1,
                Guid = tuple.Item2,
            });
        }
        /// <summary>
        /// CA客户端签章成功后 回调方法
        /// </summary>
        /// <param name="model">CA客户端返回的参数</param>
        /// <param name="guid">CA客户端返回的参数</param>
        /// <param name="pre_name">CA客户端附件名称</param>
        /// <param name="suf_name">CA客户端附件后缀</param>
        /// <returns></returns>
        public ActionResult CaClientSignCallback(SignParamModel model, string guid,string pre_name,string suf_name)
        {
            var result = new GeneralResult();
            try
            {
                var r = CertificateAuthorityModel.CaClientSignCallbackFunc(Request.Files, model,pre_name,suf_name);
                if (r.Success)
                {
                  
                    Jd.SysAttachmentService.AddSignedAttachment(model, r.TData, guid);
                    result.SetSuccess(msg: "签章成功");
                }
                else
                {
                    result.SetFail(r.Msg);
                }
            }
            catch (Exception e)
            {
                result.SetException($"签章失败,原因:{e.Message}", e);
            }
            return Json(new
            {
                status = result.Success ? 1 : 0,
                msg = result.Msg
            }, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// CA客户端签章结果接口
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public ActionResult CaSignResult(string guid)
        {
            var attachment = Jd.SysAttachmentService.FindAttachmentByGuid(guid);
            if (attachment == null)
            {
                return FResult("签章失败");
            }

            var url = CommonAttachmentBuilder(guid, "Jd");// Url.RouteUrl("FileContent", new {id = guid, Pt = "Jd", fType = "Sys"});
            //var res = new UploadResData
            //{
            //    FullUrl = url,
            //    Url = attachment.FILEPATH,
            //    Id = guid,
            //    new_id = attachment.AID?.ToString(),
            //    Md5 = attachment.MD5,
            //    Name = attachment.FILETILE,
            //};
            var res = new 
            {
                full_url = url,
                url = attachment.FILEPATH,
                id = guid,
                new_id = attachment.AID?.ToString(),
                md5 = attachment.MD5,
                name = attachment.FILETILE,
                Url= url,
            };
            return JResult(res);
        }

        #endregion

        #region CA 签章 加密 解密

        public ActionResult CaValidate()
        {
            return View();
        }
        /// <summary>
        /// CA加密
        /// </summary>
        /// <returns></returns>
        public ActionResult Sign()
        {
            return View();
        }
        /// <summary>
        /// CA加密
        /// </summary>
        /// <returns></returns>
        public ActionResult Encode()
        {
            return View();
        }
        /// <summary>
        /// 解密
        /// </summary>
        /// <returns></returns>
        public ActionResult Decode()
        {
            return View();
        }

        /// <summary>
        /// 加密参数文件
        /// </summary>
        /// <returns></returns>
        public ActionResult InParamFile()
        {
            object parms = new
            {
                operation = "envelope_file",
                rcpt_erts = "",
            };
            var s = parms.Serializer();
            var bytes = Encoding.UTF8.GetBytes(s);
            var fileName = "inparam.txt";
            var contentype = fileName.ContentType();
            return File(bytes, contentype, fileName);
        }
        /// <summary>
        /// 解密文件上传
        /// </summary>
        /// <returns></returns>
        public ActionResult DecodeUpload(CaDecodeParamModel model)
        {
            var result = new GeneralResult();
            try
            {
                var r = CertificateAuthorityModel.CaClientDecodeCallbackFunc(Request.Files);
                if (r.Success)
                {
                    foreach (var data in r.TData)
                    {
                        Jd.SysAttachmentService.AddDecodeAttachment(data, model);
                    }

                    result.SetSuccess(msg: "签章成功");
                }
                else
                {
                    result.SetFail(r.Msg);
                }
            }
            catch (Exception e)
            {
                result.SetException($"签章失败,原因:{e.Message}", e);
            }

            return JResult(new
            {
                status = result.Success ? 1 : 0,
                msg = result.Msg
            }, false);
        }
        #endregion
    }
}