using System.Collections.Generic;
using System.Data;
using System.Web.Mvc;
using GGZY.Core.Models;
using GGZY.Framework.Controllers;

namespace GGZY.FuWu.Portal.Controllers
{
    /// <summary>
    /// 统计
    /// </summary>
    [AllowAnonymous]
    public class StatController: BaseController
    {
        #region 服务平台门户交易统计
        /// <summary>
        /// 有效期内公告统计
        /// </summary>
        /// <returns></returns>
        public ActionResult Notice()
        {
            var r = Fw.CommonService.NoticeStat();
            return JResult(r);
        }
        /// <summary>
        /// 获取交易统计页面--2.全省各地市交易量对比
        /// 1.分别多年、月、日进行统计，先按类型、地区进行分组统计
        /// 2.在作为地区的左链接，依次得到每个地区的公告数量
        /// </summary>
        public ActionResult RegionTrade()
        {
            var r = Fw.CommonService.RegionTradeStat();
            return JResult(r);
        }

        /// <summary>
        /// 获取交易统计页面--3.全省各类型交易量统计
        /// </summary>
        public ActionResult TradeType()
        {
            var r = Fw.CommonService.TradeTypeStat();
            return JResult(r);
        }

        /// <summary>
        /// 近一年交易走势统计
        /// </summary>
        /// <returns></returns>
        public ActionResult LastYearTradeTrend()
        {
            var r = Fw.CommonService.LastYearTradeTrendStat();
            return JResult(r);
        }
        /// <summary>
        /// 医疗药品走势统计
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult MedicalDrugsTrend(SearchCondition condition)
        {
            var r = Fw.CommonService.MedicalDrugsTrendStat(condition);
            return JResult(r);
        }
        #endregion
    }
}