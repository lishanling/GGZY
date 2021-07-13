using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web.Mvc;
using GGZY.Core.Authentication;
using GGZY.Core.Authentication.FormsCookie;
using GGZY.Core.Authentication.Jwt;
using GGZY.Core.Cache;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Core.Utils;
using GGZY.Framework.Models;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Model;
using Newtonsoft.Json;

namespace GGZY.Framework.Controllers
{
    public partial class BaseController
    {


        #region ActionResult

        #region 验证码

        /// <summary>
        /// 创建图片验证码
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous,PortalUnFilter]
        public ActionResult ValidateCode()
        {
            var url = Url.Action("CreateValidateCode", "Base", new { t = DateTime.Now.ToString("yyyyMMddHHmmssfff") });
            //var url = $"/Base/CreateValidateCode?t={DateTime.Now:yyyyMMddHHmmssfff}";
            return JResult(new
            {
                ImgUrl = url
            });
        }

        /// <summary>
        /// 创建图片验证码
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous,PortalUnFilter]
        public ActionResult CreateValidateCode()
        {
            var validateCode = new ValidateCodeUtils();
            var code = validateCode.CreateRandomCode(4).ToLower();
            Cache.Set(code, code, 5);
            var img = validateCode.CreateImage(code);
            //var img = validateCode.CreateValidateGraphic(code);
            return File(img, "image/gif");
        }

        /// <summary>
        /// 验证码校验
        /// </summary>
        /// <param name="validateCode"></param>
        /// <returns></returns>
        protected bool CheckCode(string validateCode)
        {
            var lowerCode = validateCode.ToLower();
            if (Cache.IsSet(lowerCode))
            {
                Cache.Remove(lowerCode);
                return true;
            }
            return false;
        }

        #endregion

        /// <summary>
        /// 初始化
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        public virtual ActionResult Initial()
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            var id = Guid.NewGuid().ToString("N");
            Cache.Get(id, 5, () => rsa.ToXmlString(true));

            //把公钥适当转换，准备发往客户端
            RSAParameters parameter = rsa.ExportParameters(true);
            var exponent = CommonUtils.BytesToHexString(parameter.Exponent);
            var modules = CommonUtils.BytesToHexString(parameter.Modulus);
            return JResult(new
            {
                Id = id,
                Exponent = exponent,
                Modules = modules
            });
        }
        /// <summary>
        /// 地域信息
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        [AllowAnonymous]
        public ActionResult Region(string pid)
        {
            var r = Fw.SysAreaQuanguoService.Region(pid);
            return JResult(r);
        }
        /// <summary>
        /// 归属地结构树
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        public ActionResult GetRegionTree(string pid = null)
        {
            var r = Fw.SysAreaQuanguoService.RegionTree(pid);
            return JResult(r);
        }

        /// <summary>
        /// 归属地结构树
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        public ActionResult GetRegionTrees(string pid = null)
        {
            var r = Fw.SysAreaQuanguoService.RegionTrees(pid);
            return JResult(r);
        }
        #endregion

        #region Utils

        /// <summary>
        /// 转RSA加密为MD5加密
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        protected bool RsaToMd5(LoginModel model)
        {
            if (Cache.IsSet(model.Id))
            {
                var xmlString = Cache.Get<string>(model.Id);
                Cache.Remove(model.Id);
                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
                rsa.FromXmlString(xmlString);
                var bytes = rsa.Decrypt(CommonUtils.HexStringToBytes(model.Pwd), false);
                model.TruePwd = Encoding.ASCII.GetString(bytes);
                model.Md5Pwd = CommonUtils.Md5Str(model.TruePwd);
                model.RsaPwd = model.Pwd;
                model.Pwd = model.Md5Pwd;
                return true;
            }

            return false;
        }


        /// <summary>
        /// JSON 格式化结果
        /// </summary>
        /// <param name="data">结果对象</param>
        /// <param name="useGeneralResult">true使用统一结构返回结果 false 使用自定义结构返回结果</param>
        /// <returns></returns>
        protected virtual CustomResult JResult(object data, bool useGeneralResult = true)
        {
            return new CustomResult() { Data = data, UseGeneralResult = useGeneralResult };
        }

        /// <summary>
        /// 返回错误消息 JSON 格式化结果
        /// </summary>
        /// <param name="data">结果对象</param>
        /// <param name="useGeneralResult">true使用统一结构返回结果 false 使用自定义结构返回结果</param>
        /// <returns></returns>
        protected CustomResult FResult(string data, bool useGeneralResult = true)
        {
            return new CustomResult() { Data = data, UseGeneralResult = useGeneralResult, Success = false };
        }

       
        /// <summary>
        /// 通用附件地址构建
        /// </summary>
        /// <param name="id">附件唯一标识</param>
        /// <param name="pt">平台 服务平台：Fw ； 监督平台：Jd</param>
        /// <param name="fType">附件所在表 SYS_ATTACHEMNT：Sys ； T_ATTCHMENT:Att</param>
        /// <returns></returns>
        protected string CommonAttachmentBuilder(object id, string pt = "Fw", string fType = "Sys")
        {
            var url = string.Empty;
            if (id != null)
            {
                var attachmentId = id.ToString();
                if (attachmentId.Contains("."))
                {
                    id = attachmentId.Split('.').FirstOrDefault();
                }
                url = Url.RouteUrl("FileContent", new { id = id, Pt = pt, fType = fType });
            }

            return url;
        }
        #endregion


    }
}