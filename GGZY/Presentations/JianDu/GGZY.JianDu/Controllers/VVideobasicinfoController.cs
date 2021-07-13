using System;
using System.Collections.Generic;
using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYJD.DbEntity;

namespace GGZY.JianDu.Controllers
{
    public partial class JdVVideobasicinfoController
    {
        /// <summary>
        /// 交易场所视频
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult GetPageVideoBasicInfo(V_VIDEOBASICINFO model, SearchCondition search)
        {
            model.VISIBLE = 1;
            var r = Jd.VVideobasicinfoService.GetPageVideoBasicInfo(model, search);
            return JResult(r);
        }
        /// <summary>
        /// 获取视频节点
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult GetVideoTree(V_VIDEOBASICINFO model)
        {
            var r = Jd.VVideobasicinfoService.GetVideoTree(model);
            return JResult(r);
        }


    }
}