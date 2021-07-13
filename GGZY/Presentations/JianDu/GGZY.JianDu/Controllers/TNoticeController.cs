using System;
using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYJD.DbEntity;

namespace GGZY.JianDu.Controllers
{
    public partial class JdTNoticeController
    {
        #region 监督平台-审批用户-通知
        /// <summary>
        /// 获取平台通知分页列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult NoticePublish(T_NOTICE model, SearchCondition search)
        {
            var r = Jd.TNoticeService.NoticePublish(model, search);
            return JResult(r);
        }
        /// <summary>
        /// 获取平台通知文章内容
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult NoticePublishContent(string id)
        {
            var r = Jd.TNoticeService.NoticePublishContent(id);
            return JResult(r);
        }
        #endregion
    }
}