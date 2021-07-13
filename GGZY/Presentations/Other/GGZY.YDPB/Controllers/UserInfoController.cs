using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GGZY.Services.Base;
using GGZY.Core.Models;
using GGZY.Services;
using GGZY.Services.Infrastructure.Extensions;

namespace GGZY.YDPB.Controllers
{
    public class UserInfoController : BaseController
    {
        //[Route("api/userinfo/test")]
        //[HttpGet]
        //public GeneralResult test()
        //{
        //    Jd.YdpbEvalRoomSeatRecordService.test();
        //    return new GeneralResult();
        //}

        [AcceptVerbs("GET")]
        public GGZY.Core.Models.GeneralResult Index()
        {
            var user = Identity.FwUser();
            var result = new GGZY.Core.Models.GeneralResult();
            if(null == user)
            {
                result.SetFail("登录失效");
                return result;
            }
            
            result.SetSuccess(new
            {
                ID = user.ID,
                ROLEIDS = user.GetRoleName(),
                USERNAME = user.USERNAME,
                MANAGE_NAME = user.MANAGE_NAME,
                AREACODE = user.AREACODE,
                TYPE = user.TYPE,
                UNIT = user.ZP_UNIT,
                LEGAL_CONTACT = user.LEGAL_CONTACT,
                LEGAL_CONTACT_PHONE = user.LEGAL_CONTACT_PHONE,
                CENTER_NAME = (user.GetRoleName().Contains("tradingCenter") 
                && GlobalDataService.Instance.Centers  !=null 
                && GlobalDataService.Instance.Centers .ContainsKey(user.AREACODE))? GlobalDataService.Instance.Centers[user.AREACODE]: user.ZP_UNIT
            });
            return result;
        }

        //[AllowAnonymous]
        ////[Route("External/SignOut")]
        //[AcceptVerbs("GET")]
        //public HttpResponseMessage LoginOut()
        //{
        //    HttpResponseMessage resp = new HttpResponseMessage(HttpStatusCode.Moved);
        //    resp.Headers.Location = new Uri(BaseUrl.Replace(new Uri(BaseUrl).PathAndQuery, "/Oauth/External/SignOut"));
        //    return resp;
        //}
    }
}
