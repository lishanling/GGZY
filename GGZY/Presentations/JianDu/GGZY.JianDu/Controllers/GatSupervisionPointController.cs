using Dos.ORM;
using GGZY.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GGZY.Framework.Controllers;
using GGZYFW.DbEntity;
using GGZY.Core.Extensions;

namespace GGZY.JianDu.Controllers
{
    public class GatSupervisionPointController : BaseController
    {
        // GET: GatSupervisionPoint
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 列表页查询
        /// </summary>
        /// <param name="tender_project_code"></param>
        /// <returns></returns>
        // GET: BidderExpert
        //监督点
        //public ActionResult Search(string tender_project_code)
        //{
        //    var result = Fw.WarnExpressionService.Collection(tender_project_code);
        //    return JResult(result);
        //}

        /// <summary>
        /// 根据招标项目信息查询监督点列表
        /// </summary>
        /// <param name="search"></param>
        /// <param name="tender_project_code"></param>
        /// <returns></returns>
        public ActionResult SupervisionPoints(SearchCondition search, string tender_project_code = "")
        {
            if (String.IsNullOrWhiteSpace(tender_project_code))
            {
                var r = new GeneralResult();
                r.SetFail("招标项目编号不能为空");
                return JResult(r);
            }
            var data = Fw.WarnResultService.PageTable(search, tender_project_code);
            return JResult(data);
        }
         

        /// <summary>
        /// 监督点信息
        /// </summary>
        /// <param name="m_id"></param>
        /// <returns></returns>
        public ActionResult WarnResultDetail(string m_id)
        {
            var r = Fw.WarnResultService.WarnResultDetail(m_id);
            return JResult(r);
        }
        //public ActionResult Detail(string id)
        //{
        //    GeneralResult r = new GeneralResult();
        //    var record = service.SupervisionPointService.Detail(id);
        //    if (null == record)
        //    {
        //        r.SetFail("记录信息不存在");
        //        return JResult(r);
        //    }
        //    //监督点信息
        //    var record_data = new
        //    {
        //        ID = record.ID,
        //        SP_NAME = record.SP_NAME,
        //        SP_STATUS = record.SP_STATUS,
        //        SP_TYPE = record.SP_TYPE,
        //        SP_WAY = record.SP_WAY,
        //        SP_POINT_RULE = record.SP_POINT_RULE,
        //        CONTENT = record.CONTENT
        //    };
        //    if (id != null)
        //    {
        //        //监督点内容,监督点动态
        //        var sp = service.SpDynamicService.Collection(id);

        //        //预警反馈表
        //        var feedback = service.FeedBackService.Collection(id);
        //        r.SetSuccess(new
        //        {
        //            ClueInfo = record_data,
        //            Sp = sp,
        //            Feedback = feedback
        //        });
        //        return JResult(r);
        //    }

        //    r.SetFail("线索类型错误");
        //    return JResult(r);
        //}
    }
}