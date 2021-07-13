using GGZY.Core.Models;
using GGZY.Framework.Controllers;
using GGZY.YDPB.Models;
using GGZYFW.DbEntity;
using Swashbuckle.Swagger.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace GGZY.YDPB.Controllers
{

    /// <summary>
    /// 交易场所
    /// </summary>
    [AllowAnonymous]
    public class HallController : BaseApiController
    {
        // GET api/hall
        /// <summary>
        /// 获取交易中心列表
        /// </summary>
        /// <remarks>
        /// <code>
        /// 返回示例：
        /// {
        ///    "result": true,
        ///    "msg": "成功",
        ///    "data": [
        ///    {
        ///        "AREACODE": "350000", //交易中心编码
        ///        "SYSTEM_NAME": "福建省公共资源交易中心" //交易中心名称
        ///    }
        /// }
        /// </code>
        /// </remarks>
        /// <returns>交易中心列表</returns>
        [HttpGet]
        public GeneralResult Get()
        {
            return Jd.TradeCenterService.ListAll();
        }
    }
}