using GGZY.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Web.Http;

namespace GGZY.YDPB.Api.Controllers
{
    public class TESTController : BaseApiController
    {
        [Route("api/test/md5")]
        [AllowAnonymous]
        [HttpGet]
        // GET api/<controller>
        public string md5(string keyword="")
        {
            return  "【"+ keyword + "】md5加密结果：【"+GGZY.Core.Utils.CommonUtils.Md5Str(keyword) + "】";
        }
        [Route("api/test/token")]
        [AllowAnonymous]
        [HttpGet]
        public string token(string keyword="",string secret="12345678")
        {
            return "【"+ keyword + "】Token计算结果：【" + CreateToken(keyword, secret) + "】";
        }

        private  string CreateToken(string message, string secret = "12345678")
        {
            secret = secret ?? "";
            var encoding = new System.Text.ASCIIEncoding();
            byte[] keyByte = encoding.GetBytes(secret);
            byte[] messageBytes = encoding.GetBytes(message);
            using (var hmacsha256 = new HMACSHA256(keyByte))
            {
                byte[] hashmessage = hmacsha256.ComputeHash(messageBytes);
                return Convert.ToBase64String(hashmessage).Replace("+", "_").Replace("/", "_").Replace("=", "_");
            }
        }
        [Route("api/test/notify")]
        [AllowAnonymous]
        [HttpGet]
        public  string NotifyAgain([FromUri] string SERIES_NUMBER ="",string areacode="")
        {
            if(String.IsNullOrEmpty(SERIES_NUMBER))
            {
                return "申请单编号不能为空";
            }

            Jd.YdpbBranchService.notify(SERIES_NUMBER,areacode);
            return "成功";
        }

        [Route("api/test/exception")]
        [AllowAnonymous]
        [HttpGet]
        public string Exception([FromUri] string areacode = "",string msg ="")
        {
            if(String.IsNullOrEmpty(areacode))
            {
                return "AREACODE 不能为空";
            }
            if(String.IsNullOrWhiteSpace(msg))
            {
                return "msg 不能为空";
            }
            Jd.YdpbBranchService.exceptionNotify(areacode, msg);
            return "成功";
        }

        [Route("api/test/query")]
        [AllowAnonymous]
        [HttpGet]
        public GeneralResult query([FromUri] string no="")
        {
            return  Jd.YdpbEvalApplyService.I_Query(no, "", "");
        }
    }
}