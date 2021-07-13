using GGZY.Core.Models;
using GGZYFW.DbEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GGZY.YDPB.Controllers
{
    public class TenderProjectController : BaseController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Route("api/tenderproject/list")]
        [HttpGet]
        public GeneralResult List(string keyword)
        {
            var result = new GeneralResult();
            var data = Fw.TenderProjectService.PageListNameValue(keyword);
            result.SetSuccess(data);
            return result;
        }
    }
}