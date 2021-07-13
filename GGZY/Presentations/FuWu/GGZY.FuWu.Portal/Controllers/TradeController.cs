using System.Web.Mvc;
using System.Web.UI;
using GGZY.Core.Cache;
using GGZY.Core.Extensions;
using GGZY.Core.Log;
using GGZY.Core.Models;
using GGZY.Core.Utils;
using GGZY.Framework.Controllers;
using GGZY.Services.Infrastructure.Helper;
using GGZYFW.DbEntity;
using GGZYJH.DbEntity;

namespace GGZY.FuWu.Portal.Controllers
{
    /// <summary>
    /// 交易信息
    /// </summary>
    [AllowAnonymous]
    public class TradeController : BaseController
    {
        //[OutputCache(Duration = 7200)]
        public ActionResult TradeInfoProTypes(SearchCondition search)
        {
            //Response.Cache.SetOmitVaryStar(true);
            var r = Fw.MvJyxxService.TradeInfoProTypes(search);
            return JResult(r);
        }
        //[OutputCache(Duration=120)]
        public ActionResult TradeInfo(MV_JYXX model, SearchCondition search, T_MEDICAL medical, ZP_NOTICE notice)
        {

            //Response.Cache.SetOmitVaryStar(true);
            //if (search.EndTime.HasValue)
            //{
            //    search.EndTime = search.EndTime.Value.AddDays(1).AddSeconds(-1);
            //}

            if (search.BeginTime.HasValue)
            {
                search.BeginTime = search.BeginTime.Value.Date;
            }
            if (search.EndTime.HasValue)
            {
                search.EndTime = search.EndTime.Value.Date.AddDays(1).AddSeconds(-1);
            }
            if (model.KIND == "YLYP")
            {
                return JResult(Fw.TMedicalService.PageDataTable(medical, search));
            }

            if (model.KIND == "BID")
            {
                return JResult(ZBCG.ZpNoticeService.BidPageList(notice, search));
            }

            var md5Parms = model.Md5Param();
            var searchParams = search.Md5Param();
            var cacheKey = $"{ConfigHelper.APP_KEY_GGZYFW}:TradeInfo:{search.PageNo}:{md5Parms}:{searchParams}";
            Logger.Info($"{cacheKey} {Cache.IsSet(cacheKey)}");
            var r = Cache.Get<PageTableResult>(cacheKey, 5, () => Fw.MvJyxxService.TradeInfoPageList(model, search));
            return JResult(r);

        }
        /// <summary>
        /// 交易信息明细
        /// </summary>
        /// <param name="type"></param>
        /// <param name="cid"></param>
        /// <returns></returns>
        public ActionResult TradeInfoDetail(string type, string cid)
        {
            switch (type)
            {
                case "GCJS":    //工程建设
                                //var m = Fw.MvJyxxService.GCJS_TradeInfo(cid,ids =>CommonAttachmentBuilder(ids,fType:"Att"));
                    var m = Fw.MvJyxxService.GCJS_TradeInfoDetail(cid, null);
                    //foreach (var n in m.Nodes)
                    //{
                    //    foreach (var c in n.Children)
                    //    {
                    //        c.Attachment = Url.Action("GetFile", "Home", new {fid = c.Attachment});
                    //    }
                    //}
                    return JResult(m);
                case "ZFCG":    //政府采购
                    return JResult(Fw.MvJyxxService.ZFCG_TradeInfo(cid));
                case "TDSYQ":   //土地使用权
                    return JResult(Fw.MvJyxxService.TDSYQ_TradeInfo(cid));
                case "KYQ":     //矿业权
                    return JResult(Fw.MvJyxxService.KYQ_TradeInfo(cid));
                case "GYCQ":    //国有产权
                    return JResult(Fw.MvJyxxService.GYCQ_TradeInfo(cid));
                case "BXGG":    //比选公告
                    return JResult(Fw.MvJyxxService.BXGG_TradeInfo(cid));
                case "QT": //其他
                    return JResult(Fw.MvJyxxService.OtherTradeInfo(cid));
                case "YLYP": //医疗药品
                    //todo
                    break;
                case "BID": //招标采购网历史数据明细
                    return JResult(ZBCG.ZpNoticeService.BidDetail(cid));
                case "NEWS": //新闻详情
                    return JResult(Fw.PtArticleService.ArticleDetail(cid));
                case "LEGALPERSON": //主体资信
                    return JResult(Fw.CommonService.SearchDetail(cid));
              
            }
            var r= new GeneralResult();
            r.SetFail("参数错误");
            return JResult(r);
        }

        //[OutputCache(Duration = 1800, Location = OutputCacheLocation.Client)]
        public ActionResult TradeInfoContent(string m_id, string type)
        {
            //Response.Cache.SetOmitVaryStar(true);
            var r = Fw.MvJyxxService.EngineerTradeAnnContent(m_id, type);
            return JResult(r);
        }
        /// <summary>
        /// 服务平台门户-交易信息-详情页-顶部项目信息
        /// </summary>
        /// <param name="cid"></param>
        /// <returns></returns>
        public ActionResult EngineerTradeInfo(string cid)
        {
            var baseInfo = Fw.TenderAnnQuaInqueryAnnService.EngineerTradeBaseInfo(cid);
            return JResult(baseInfo);
        }

        /// <summary>
        /// 医疗药品
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult MedicalInfo(T_MEDICAL model, SearchCondition search)
        {
            var r = Fw.TMedicalService.PageDataTable(model, search);
            return JResult(r);
        }
        /// <summary>
        /// 招标采购网列表数据
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult BidPageList(ZP_NOTICE model, SearchCondition search)
        {
            var r = ZBCG.ZpNoticeService.BidPageList(model, search);
            return JResult(r);
        }
    }
}